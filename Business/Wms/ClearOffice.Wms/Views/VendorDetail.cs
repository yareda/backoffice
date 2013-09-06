using System;
using System.Collections.Generic;
using System.Data;
using System.Windows.Forms;
using ClearOffice.Infrastructure;
using ClearOffice.Security;
using ClearOffice.Wms.Business;
using System.Linq;

namespace ClearOffice.Wms.Views
{
    /// <summary>
    /// Displays vendor detail for adding new records and editing existing ones.    
    /// </summary>
    public partial class VendorDetail : DevExpress.XtraEditors.XtraForm, IDetailForm
    {
        private WmsEntities _context;
        private Vendor _vendor;
        private bool _newMode;
        private bool cancelChanges;
        private PermissionManager _pm;
        private WorkshopPermissionHelper _wph;
        public VendorDetail()
        {
            InitializeComponent();
            _context = new WmsEntities();
            _pm = PermissionManager.GetPermissionManager();
            _wph = new WorkshopPermissionHelper();

            AuthorizeForm();
        }
        /// <summary>
        /// Loads a a vendor object which is identified by the keyValue primar key. If we want to add new
        /// records then pass null value to this method.
        /// </summary>
        /// <param name="keyValue"></param>
        public void ShowObject(object keyValue)
        {

            // If keyValue is null then we expect that this is new mode and will act accordingly


            if (keyValue == null) _newMode = true;

            if (_newMode)
            {
                _vendor = new Vendor();
                this.Text = @"Vendor";
            }
            else
            {
             var ven = (Vendor) keyValue;
             vendorBindingSource.DataSource = _context.Vendors.First(c => c.VendorId == ven.VendorId);
             LoadLookups();
            }

            
            
        }

        private void LoadLookups()
        {
            VendorTypeBindingSource.DataSource = GetAllVendorTypes();
            CountryBindingSource.DataSource = _context.Countries.ToList();
        }

        private IEnumerable<LookupItem> GetCountery()
        {
            int itemId = Convert.ToInt32(LookupItems.Country);
            return _context.LookupItems.Where(ve => ve.LookupId == itemId);
        }

        private IEnumerable<LookupItem> GetAllVendorTypes()
        {
            int itemId = Convert.ToInt32(LookupItems.VendorType);
            return _context.LookupItems.Where(li => li.LookupId == itemId);
        }

        /// <summary>
        /// Checks the status of the context for any type of data change (new,edited,deleted) and 
        /// </summary>
        /// <returns></returns>
        public bool DataChanged()
        {
            return _context.ObjectStateManager.GetObjectStateEntries(EntityState.Added | EntityState.Modified |
                                             EntityState.Deleted).Any();
        }

        public void SaveChanges()
        {
            if (!ValidateForm()) return;
            vendorBindingSource.EndEdit();
            try
            {
                //If we are in new mode then we need to add the new object to the context
                if (_newMode)
                _context.Vendors.AddObject(_vendor);
                //Save the changes to the database through the context
                    _context.SaveChanges();
                this.Close();
            }
            catch (Exception e)
            {
                ViewHelper.ShowErrorMessage(@"Error saving vendor information.");
                ErrorLogger.LogError(this, e);
            }
        }

        /// <summary>
        /// Deletes the current item from the database. This command should be enabled only if it makes sense
        /// to delete the object. If hard delete is not applicable for whatever reason then this method should
        /// resorte to soft delete method.
        /// </summary>
        public void DeleteObject()
        {
            if (_newMode) return;
            vendorBindingSource.EndEdit();
            try
            {
                _context.Vendors.DeleteObject(_vendor);
                _context.SaveChanges();
                this.Close();
            }
            catch (Exception e)
            {
                ViewHelper.ShowErrorMessage(@"Error deleting the current vendor.");
                ErrorLogger.LogError(this, e);
            }
        }
        /// <summary>
        /// This is where validation logic resideds. For this specific method we want to make sure that the
        /// user supplies Vendor Name and contact information before saving
        /// </summary>
        /// <returns></returns>
        public bool ValidateForm()
        {
            //Check Vendor Name property
            if (nameTextBox.Text == string.Empty)
            {
                errorProvider1.SetError(nameTextBox, "Vendor Name is required");
                return false;
            }

            //Check Contract Name property
            if (contactTextBox.Text == string.Empty)
            {
                errorProvider1.SetError(contactTextBox, "Contact Name is required");
            }

            return true;
        }

        /// <summary>
        /// This method is used to track object state and allows UI elements to respond to the associated states.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void vendorBindingSource_CurrentItemChanged(object sender, EventArgs e)
        {
            //This is required ONLY when we are using a form for both NEW and EDIT methods. Here we only need to manage
            //the Save button only during edit mode because we dont have the state for new objects which are not yet added
            //to the context.
            if (!_newMode)
            {
                saveToolStripButton.Enabled = DataChanged();
            }
        }

        private void VendorDetail_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (!cancelChanges)
            {
                if (DataChanged())
                {
                    //var response = MessageBox.Show(Resources.DATA_CHANGE_MESSAGE, Resources.DATA_CHANGE_TITLE,
                    //                               MessageBoxButtons.YesNoCancel, MessageBoxIcon.Exclamation);
                    var response = MessageBox.Show("Do you want to save changes?", "Warnning",
                                                  MessageBoxButtons.YesNoCancel, MessageBoxIcon.Exclamation);
                    switch (response)
                    {
                        case DialogResult.Yes:
                            SaveChanges();
                            break;
                        case DialogResult.No:
                            break;
                        case DialogResult.Cancel:
                            e.Cancel = true;
                            break;
                    }
                   }
                  }
        }

        private void saveToolStripButton_Click(object sender, EventArgs e)
        {
            SaveChanges();
        }

        public void AuthorizeForm()
        {
            saveToolStripButton.Enabled = _pm.IsAuthorized(PermissionManager.WORKSHOP_APPLICATION,
                                                     _wph.ItemName(WorkshopPermissionHelper.Operation.UpdateVendor));
        }
    }
}