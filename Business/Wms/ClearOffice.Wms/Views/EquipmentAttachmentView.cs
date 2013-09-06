using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using ClearOffice.Infrastructure;
using ClearOffice.Security;
using DevExpress.XtraEditors;
using ClearOffice.Wms.Business;
namespace ClearOffice.Wms.Views
{
    public partial class EquipmentAttachmentView : DevExpress.XtraEditors.XtraForm,IDetailForm
    {
        private EquipmentAttachment _equipmentAttachment;
        public Equipment Equipment { get; set; }
        private WmsEntities _context;
        public EquipmentDetail EquipmentDetail { get; set; }
        private bool _newMode;

        private PermissionManager _pm;
        private WorkshopPermissionHelper _wph;

        public EquipmentAttachmentView()
        {
            InitializeComponent();
            _context = new WmsEntities();
            _pm = PermissionManager.GetPermissionManager();
            _wph = new WorkshopPermissionHelper();

            AuthorizeForm();
        }
        public void ShowObject(object keyValue)
        {
            if (keyValue == null)
            {
                _equipmentAttachment = new EquipmentAttachment(){EquipmentId = Equipment.EquipmentId};
                attachmentBindingSource.DataSource = _equipmentAttachment;
                _newMode = true;
            }
        }
        public bool DataChanged()
        {
            return _context.ObjectStateManager.GetObjectStateEntries(EntityState.Added | EntityState.Modified | EntityState.Deleted).Any();
        }

        public void SaveChanges()
        {
            attachmentBindingSource.EndEdit();
            //_equipmentAttachment = (EquipmentAttachment) attachmentBindingSource.DataSource;
            if(_newMode)
                _context.EquipmentAttachments.AddObject(_equipmentAttachment);
            try
            {
                if(!ValidateForm())
                    return;
                _context.SaveChanges();
                EquipmentDetail.ReloadAttachments();
                Close();
            }
            catch (Exception ex)
            {
                ViewHelper.ShowErrorMessage("Error occured while saving the current attachment.", ex);
                return;
            }
        }

        public void DeleteObject()
        {
            throw new NotImplementedException();
        }

        public bool ValidateForm()
        {
            var result = true;
            if (discriptionTextBox.Text == string.Empty)
            {
                attachmentErrorProvider.SetError(discriptionTextBox,"Description Is Required.");
                result = false;
            }
            return result;
        }

        private void btnSelect_Click(object sender, EventArgs e)
        {
            openFileDialog1.ShowDialog();
            try
            {
                var file = openFileDialog1.OpenFile();
                //read byte[] from the file streem.
                var length = (int)file.Length;
                var buffer = new byte[length];
                file.Read(buffer, 0, length);
                _equipmentAttachment.File = buffer;
                //Get the file name of the selected file.
                var fileNames = openFileDialog1.FileNames;
                txtAtachment.Text = fileNames[0];
                _equipmentAttachment.FileName = fileNames[0];
                var str = fileNames[0].Split('\\');
                var len = str.Length;
                var fn = str[len - 1];
                //get the file extention.
                var ext = fn.Split('.');
                var extleng = ext.Length;
                var extention = ext[extleng - 1];
                _equipmentAttachment.FileType = extention;
            }
            catch (Exception)
            {

            }  
        }

        private void saveToolStripButton_Click(object sender, EventArgs e)
        {
            SaveChanges();
        }


        public void AuthorizeForm()
        {
            saveToolStripButton.Enabled = _pm.IsAuthorized(PermissionManager.WORKSHOP_APPLICATION,
                                                           _wph.ItemName(
                                                               WorkshopPermissionHelper.Operation.AddEquipmentAttachment));
        }
    }
}