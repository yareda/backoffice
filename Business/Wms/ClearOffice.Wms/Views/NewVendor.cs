using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using ClearOffice.Infrastructure;
using ClearOffice.Security;
using ClearOffice.Wms.Business;

namespace ClearOffice.Wms.Views
{
    public partial class NewVendor : DevExpress.XtraEditors.XtraForm, IDetailForm
    {
        private WmsEntities _context;
        private bool _newMode;
        private PermissionManager _pm;
        private WorkshopPermissionHelper _wph;

        public NewVendor()
        {
            InitializeComponent();
            _context = new WmsEntities();
            _pm = PermissionManager.GetPermissionManager();
            _wph = new WorkshopPermissionHelper();

            AuthorizeForm();
        }

        
        public void ShowObject(object keyValue)
        {
            if (keyValue == null) _newMode = true; else _newMode = false;
            if (_newMode)
            {
                VendorDataBindingSource.DataSource = new Vendor();
                LoadLookups();
            }
        }

        private void LoadLookups()
        {
            VendorTypeDataBindingSource.DataSource = GetAllVendorTypes();
            CountryBindingSource.DataSource = _context.Countries.ToList();
        }

        //private IEnumerable<Country> GetCountery()
        //{
        //    //int itemId = Convert.ToInt32(Country);
        //    return _context.Countries.ToList();
        //}

        private IEnumerable<LookupItem> GetAllVendorTypes()
        {
            int itemId = Convert.ToInt32(LookupItems.VendorType);
            return _context.LookupItems.Where(li => li.LookupId == itemId);
        }

        public bool DataChanged()
        {
            return _context.ObjectStateManager.GetObjectStateEntries(EntityState.Added | EntityState.Modified |
                                            EntityState.Deleted).Any();
        }

        public void SaveChanges()
        {
            if (!ValidateForm()) return;
            VendorDataBindingSource.EndEdit();
            var vendor = (Vendor) VendorDataBindingSource.DataSource;
            try
            {
               if(_newMode)
               {   _context=new WmsEntities();
                   _context.Vendors.AddObject(vendor);
                   _context.SaveChanges();
                   this.Close();
               }
            }
            
            catch (Exception e)
            {
                ViewHelper.ShowErrorMessage(@"Error saving vendor information.");
                ErrorLogger.LogError(this, e);
            }
        }

        public void DeleteObject()
        {
            throw new NotImplementedException();
        }

        public bool ValidateForm()
        {
            bool result = true;
            if (nameTextBox.Text == string.Empty)
            {
                errorProvider.SetError(nameTextBox, "Vendor Name is required");
                result = false;
            }
            if(vendorTypeLookUpEdit.Text==string.Empty)
            {
                errorProvider.SetError(vendorTypeLookUpEdit,"Vendore Type is required");
                result = false;
            }

            if (countryLookUpEdit.Text == string.Empty)
            {
                errorProvider.SetError(countryLookUpEdit, "Country is required");
                result = false;
            }
            
            if (result) return true;
            return false;
        }

        
        private void saveToolStripButton_Click_1(object sender, EventArgs e)
        {
            SaveChanges();
        }

        private void VendorTypeDataBindingSource_CurrentChanged(object sender, EventArgs e)
        {
            if (!_newMode)
            {
                saveToolStripButton.Enabled = DataChanged();
            }
            AuthorizeForm();
        }

        public void AuthorizeForm()
        {
            saveToolStripButton.Enabled = _pm.IsAuthorized(PermissionManager.WORKSHOP_APPLICATION,
                                                           _wph.ItemName(
                                                               WorkshopPermissionHelper.Operation.AddVendors));
        }
    }
}