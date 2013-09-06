using System;
using System.Collections;
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

namespace ClearOffice.FixedAsset.Views
{
    public partial class CustodianDetail : DevExpress.XtraEditors.XtraForm,IDetailForm ,IListForm
    {
        private FixedAssetEntities _context;
        //private bool _newMode;
        public Custodian _custodian;
        public Asset _asset;
        public Custodian Custodian { get; set; }
        public CustodianAsset CustodianAsset { get; set; }
        private PermissionManager permissionManager;
        private FixedAssetPermissionHelper faph;
        public CustodianDetail()
       {
            InitializeComponent();
            _context =new FixedAssetEntities();
            permissionManager = PermissionManager.GetPermissionManager();
            faph = new FixedAssetPermissionHelper();
            AuthorizeForm();
        }

        public void ShowObject(object keyValue)
        {
            var cust = (Custodian) keyValue;
            //_newMode = false;
            _custodian = _context.Custodians.FirstOrDefault(il => il.CustodianId == cust.CustodianId);
             custodiandetailbindingSource.DataSource = _custodian;
             LoadLookUp();
           if (_custodian != null)
            {
                var cal =_context.CustodianAssetsLists.Where(ci=>ci.CustodianId ==cust.CustodianId);
                custodianassetbindingSource.DataSource = cal.ToList();
            }
              
        }
        private void LoadLookUp()
        {
             var department = _context.LookupItems.Where(d => d.LookupId == (int) LookupItems.Departement);
            departmentbindingSource.DataSource = department.ToList();
            var status = _context.LookupItems.Where(d => d.LookupId == (int)LookupItems.CustodyAssignmentStatus);
            statusbindingSource.DataSource = status.ToList();
        }

        public bool DataChanged()
        {
            return _context.ObjectStateManager.GetObjectStateEntries(EntityState.Added | EntityState.Modified |
                                                                    EntityState.Deleted).Any();
        }
        public void SaveChanges()
        {
            if (!ValidateForm()) return;
            custodiandetailbindingSource.EndEdit();
            _custodian = (Custodian) custodiandetailbindingSource.DataSource;        
           try
                {
                    _context.SaveChanges();

                }
           catch (Exception exception)
                {

                   ViewHelper.ShowErrorMessage("Error occured while saving custodian.",exception);
                }          
        }
        public void DeleteObject()
        {
            if (_custodian != null)
            {
                custodiandetailbindingSource.EndEdit();
                _custodian = (Custodian)custodiandetailbindingSource.DataSource;
                try
                {
                    foreach (var p in _custodian.CustodianAsset.ToList())
                    {
                        if (p.RecordId == 0)
                            _custodian.CustodianAsset.Remove(p);
                        else
                            _context.CustodianAssets.DeleteObject(p);
                    }
                    _context.DeleteObject(_custodian);
                    _context.SaveChanges();
                    Close();
                }
                catch (Exception)
                {
                    ViewHelper.ShowErrorMessage("Unable to delete the selected custodian!");
                }
            }
        }

        public bool ValidateForm()
        {
            if (txtBadgeNo.Text == string.Empty)
            {
                custodianerrorProvider.SetError(txtBadgeNo, "Badge # is Required");
                return false;
            }
            if (txtFirstName.Text == string.Empty)
            {
                custodianerrorProvider.SetError(txtFirstName, "First name is required");
                return false;
            }

          return true;
        }


        private void btnCustodianSave_Click(object sender, EventArgs e)
        {
              SaveChanges();
            if(_custodian.Status ==false)
            {
                ViewHelper.ShowSuccessMessage("The asset taken must be returned!");
                DialogResult = DialogResult.OK;
           
            }

        }

        private void btnDeleteCustodian_Click(object sender, EventArgs e)
        {
            var result = ViewHelper.ShowConfirmDialog("Are you sure, you want to delete the current record?");
            if (result == DialogResult.Yes)
            {
                try
                {
                    DeleteObject();
                }
                catch (Exception)
                {
                    ViewHelper.ShowDeleteError();
                }
            }
            else
            {
                return;
            }
            return;
        }
        public void ShowList()
        {
            throw new NotImplementedException();
        }

        public void OpenSelectedItem()
        {
            throw new NotImplementedException();
        }

        public object GetSelectedItem()
        {
            throw new NotImplementedException();
        }


        public void RefreshList()
        {
            throw new NotImplementedException();
        }


        public void AuthorizeForm()
        {
            btnCustodianSave.Enabled = permissionManager.IsAuthorized(PermissionManager.FIXED_ASSET_APPLICATION,
                                                                      faph.ItemName(
                                                                          FixedAssetPermissionHelper.Operation.
                                                                              UpdateCustodian));
            btnDeleteCustodian.Enabled = permissionManager.IsAuthorized(PermissionManager.FIXED_ASSET_APPLICATION,
                                                                        faph.ItemName(
                                                                            FixedAssetPermissionHelper.Operation.
                                                                                DeleteCustodian));
        }
    }
}