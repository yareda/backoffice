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
using ClearOffice.Wms.Business;
using DevExpress.XtraEditors;

namespace ClearOffice.Wms.Views
{
    public partial class MicilaneousView : DevExpress.XtraEditors.XtraForm,IDetailForm
    {
        private WmsEntities _context;
        public MiscellaneousItems _micellaneous;
        public MiscellaneousItems selectedmiscelaneous { get; set; }
        private PermissionManager _pm;
        private WorkshopPermissionHelper _wph;
        public MiscellaneousItems CurrentObject
        {
            get { return _micellaneous; }
        }
      
        public MicilaneousView()
        {
            InitializeComponent();
            _context =new WmsEntities();
            _pm = PermissionManager.GetPermissionManager();
            _wph = new WorkshopPermissionHelper();

            AuthorizeForm();
        }

        public void ShowObject(object keyValue)
        {
            _micellaneous = keyValue as MiscellaneousItems;
            newmiscbindingSource.DataSource = _micellaneous;
            if (_micellaneous != null && _micellaneous.MisPartId == 0)
            {
                LoadLookups();
                Text = @"New Miscellaneous Items";
            }
            if (_micellaneous != null && _micellaneous.MisPartId != 0)
            {
                LoadLookups();
                Text = @"Edit Miscellaneous Items";
            }
        }
        private void LoadLookups()
        {
            PartbindingSource.DataSource = _context.Parts.ToList();
        }

        public bool DataChanged()
        {
            return _context.ObjectStateManager.GetObjectStateEntries(EntityState.Added | EntityState.Modified |
                                          EntityState.Deleted).Any();
        }

        public void SaveChanges()
        {
            if (!ValidateForm()) return;
            newmiscbindingSource.EndEdit();
            _micellaneous = (MiscellaneousItems) newmiscbindingSource.DataSource;
            this.DialogResult = DialogResult.OK;
         }
      
        public bool ValidateForm()
        {
          
           if (lookUpEdit1.Text == string.Empty)
            {
                errorProvider1.SetError(txtQuantity, "Part is required");
                return false;
            }
           if (txtQuantity.Text == string.Empty)
            {
                errorProvider1.SetError(txtQuantity, "Qauntity is required");
                return false;
            }
            if (unitPriceTextBox.Text == string.Empty)
            {
                errorProvider1.SetError(unitPriceTextBox, "Unit Price is required");
                return false;
            }
         
            return true;
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            SaveChanges();
        }

        private void unitPriceTextBox_TextChanged(object sender, EventArgs e)
        {
            if (unitPriceTextBox.Text != "")
            {
                if (txtQuantity.Text != "")
                    miscTotal.Text = (Convert.ToInt32(txtQuantity.Text) * Convert.ToInt32(unitPriceTextBox.Text)).ToString();
            }
        }
        public void DeleteObject()
        {
            throw new NotImplementedException();
        }



        public void AuthorizeForm()
        {
            btnSave.Enabled = _pm.IsAuthorized(PermissionManager.WORKSHOP_APPLICATION,
                                                       _wph.ItemName(WorkshopPermissionHelper.Operation.AddNewMicelaneousItem)) || _pm.IsAuthorized(PermissionManager.WORKSHOP_APPLICATION,
                                                       _wph.ItemName(WorkshopPermissionHelper.Operation.UpdateMiscelaneousItem));
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }


    }
}