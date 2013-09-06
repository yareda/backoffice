using System;
using System.Data;
using System.Linq;
using System.Windows.Forms;
using ClearOffice.Infrastructure;
using ClearOffice.Security;
using ClearOffice.Wms.Business;

namespace ClearOffice.Wms.Views
{
	public partial class LookUpDetail: DevExpress.XtraEditors.XtraForm,IDetailForm
	{
	    private bool newMode;
        private WmsEntities _context;
	    private LookupItem lookupItem;
        private bool cancelChanges;
	    private PermissionManager _pm;
	    private WorkshopPermissionHelper _wph;
        public LookUpDetail()
		{
            InitializeComponent();
            _context=new WmsEntities();

            _pm = PermissionManager.GetPermissionManager();
            _wph = new WorkshopPermissionHelper(); 

            AuthorizeForm();
		}

        private void saveToolStripButton_Click(object sender, EventArgs e)
        {
           SaveChanges();
        }

        public void ShowObject(object keyValue)
        {
            if (keyValue == null) newMode = true;

            if (!newMode)
            {
                 var look = (LookupItem)keyValue;
                lookupItemBindingSource.DataSource = _context.LookupItems.First(c => c.ItemId == look.ItemId);
                
            }
        }

        public bool DataChanged()
        {
            return _context.ObjectStateManager.GetObjectStateEntries(EntityState.Added | EntityState.Modified |
                                            EntityState.Deleted).Any();
        }

        public void SaveChanges()
        {
            if (!ValidateForm()) return;
            lookupItemBindingSource.EndEdit();
            try
            {
               
                if (newMode)
                    _context.LookupItems.AddObject(lookupItem);
                    _context.SaveChanges();
                    this.Close();
            }
            catch (Exception e)
            {
                ViewHelper.ShowErrorMessage(@"Error saving Lookup Item information.");
                ErrorLogger.LogError(this, e);
            }
        }

        public void DeleteObject()
        {
            throw new NotImplementedException();
        }

        public bool ValidateForm()
        {
            bool value = true;
            if(nameTextBox.Text==string.Empty)
            {
                errorProvider.SetError(nameTextBox,"error while saving Name ");
                value = false;
            }
            if(codeTextBox.Text==string.Empty)
            {
                errorProvider.SetError(codeTextBox,"error while saving the code");
                value = false;
            }
            if (value) return true;
            return false;
        }

        private void lookupItemBindingSource_CurrentChanged(object sender, EventArgs e)
        {
            //if (!newMode)
            //{
            //    saveToolStripButton.Enabled = DataChanged();
            //}
        }

        private void LookUpDetail_FormClosed(object sender, System.Windows.Forms.FormClosedEventArgs e)
        {
            if (!cancelChanges)
            {
                if (DataChanged())
                {
                    var response = MessageBox.Show("Do you want to save changes?", "Warnning",MessageBoxButtons.YesNo, MessageBoxIcon.Exclamation);
                    switch (response)
                    {
                        case DialogResult.Yes:
                            SaveChanges();
                            break;
                        case DialogResult.No:
                            break;
                        
                    }
                }
            }
        }

        public void AuthorizeForm()
        {
            saveToolStripButton.Enabled = _pm.IsAuthorized(PermissionManager.WORKSHOP_APPLICATION,
                                                           _wph.ItemName(
                                                               WorkshopPermissionHelper.Operation.UpdateLookupItem));
        }
    }
}