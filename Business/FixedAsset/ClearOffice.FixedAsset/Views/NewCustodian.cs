using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using ClearOffice.Infrastructure;
using ClearOffice.FixedAsset.DataAccess;
using System.Linq;
using System.Data;
using ClearOffice.Security;
using DevExpress.XtraEditors;

namespace ClearOffice.FixedAsset.Views
{
    public partial class NewCustodian : DevExpress.XtraEditors.XtraForm,IDetailForm
    {
        public FixedAssetEntities _context;
        public Custodian _custodian;
        public Custodian Custodian { get; set; }
        private PermissionManager permissionManager;
        private FixedAssetPermissionHelper faph;
        private bool _newmode;

        public NewCustodian()
        {
            InitializeComponent();
            _context =new FixedAssetEntities();
            permissionManager = PermissionManager.GetPermissionManager();
            faph = new FixedAssetPermissionHelper();
            AuthorizeForm();
        }

        public void ShowObject(object keyValue)
        {
           if(keyValue==null)
            {
                _custodian =new Custodian();
                _newmode = true;
                custodianBindingSource.DataSource = _custodian;
                Loaddepartmentlookup();
                Text = @"New Custodian";
                
            }
        }

        private void Loaddepartmentlookup()
        {
            var department = _context.LookupItems.Where(d => d.LookupId == (int)LookupItems.Departement);
            departmentbindingSource.DataSource = department.ToList();
        }

        public bool DataChanged()
        {
            return _context.ObjectStateManager.GetObjectStateEntries(EntityState.Added | EntityState.Modified |
                                                                    EntityState.Deleted).Any();
        }

        public void SaveChanges()
        {
            if (!ValidateForm()) return;
            custodianBindingSource.EndEdit();
            _custodian = (Custodian)custodianBindingSource.DataSource;
            _custodian.Status = true;
            if(_newmode)
                _context.Custodians.AddObject(_custodian);
            try
            {
                _context.SaveChanges();
                _newmode = false;
                this.Close();
                var cutodiandetail = new CustodianDetail();
                cutodiandetail.ShowObject(_custodian);
                cutodiandetail.ShowDialog();
            }
            catch (Exception ex)
            {

                ViewHelper.ShowErrorMessage("Error occured while saving the current custodian information.", ex);
            }
        }

       

        public bool ValidateForm()
        {
            if(txtBadgeNo.Text ==string.Empty)
            {
                errorProvider1.SetError(txtBadgeNo,"Badge # is Required");
                return false;
            }
            if(txtFirstName.Text ==string.Empty)
            {
                errorProvider1.SetError(txtFirstName,"First name is required");
                return false;
            }
           if (cmbDepartment.Text == string.Empty)
            {
                errorProvider1.SetError(cmbDepartment, "Department Should be Selected");
                return false;
            }
            return true;
        }

        private void btnCustodianSave_Click(object sender, EventArgs e)
        {
           SaveChanges();
        }

        public void DeleteObject()
        {
            throw new NotImplementedException();
        }




        public void AuthorizeForm()
        {
            btnCustodianSave.Enabled = permissionManager.IsAuthorized(PermissionManager.FIXED_ASSET_APPLICATION,
                                                                      faph.ItemName(
                                                                          FixedAssetPermissionHelper.Operation.
                                                                              AddCustodian));
         }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}