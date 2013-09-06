using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using ClearOffice.Infrastructure;
using ClearOffice.FixedAsset.DataAccess;
using ClearOffice.FixedAsset.DataAccess;
using System.Linq;
using System.Data;
using ClearOffice.Security;

namespace ClearOffice.FixedAsset.Views
{
    public partial class CustodianAssetView : DevExpress.XtraEditors.XtraForm ,IDetailForm
    {
        private FixedAssetEntities _context;
        public CustodianAsset custodianassets;
        public bool _newMode;
        public Asset assetList;
        public Custodian _Custodian;
        public Custodian Custodian { get; set; }
        private PermissionManager permissionManager;
        private FixedAssetPermissionHelper faph;
        public CustodianAsset CurrentObject
        {
            get { return custodianassets; }
        }
        public CustodianAssetView()
        {
            InitializeComponent();
            _context = new FixedAssetEntities();
            permissionManager = PermissionManager.GetPermissionManager();
            faph = new FixedAssetPermissionHelper();
            AuthorizeForm();
        }

        public void ShowObject(object keyValue)
        {
            var value = (Asset)keyValue;
            assetList = value;
            custodianassets = new CustodianAsset() {AssetId = value.AssetId};
            cutodianassetbindingSource.DataSource = custodianassets;
            if (keyValue != null && custodianassets.RecordId == 0)
            {
                _newMode = true;
                Text = string.Format("Assign cutodian Asset#: {0}", value.AssetNumber);
                LoadLookups();
            }
            if(!_newMode && custodianassets.RecordId !=0)
            {
                Text = string.Format("Edit for Asset#: {0}", value.AssetId);
            }

        }

        private void LoadLookups()
        {
            cutodianbindingSource.DataSource = _context.ActiveCustodianStatuses.ToList();
        }

        public void SaveChanges()
        {
            if (!ValidateForm()) return;
            cutodianassetbindingSource.EndEdit();
            custodianassets = (CustodianAsset) cutodianassetbindingSource.DataSource;
            custodianassets.Status = (int)CustodyAssignmentStatus.Assigned;
            if (_newMode) _context.CustodianAssets.AddObject(custodianassets);        
           {
                try
                {
                    _context.SaveChanges();
                    ViewHelper.ShowSuccessMessage("The Asset has succesfully been Assigned.");
                    Close();
                }
                catch (Exception exception)
                {

                    ViewHelper.ShowErrorMessage("Error occured while assigning asset to the current custodian.", exception);
                }

            }

          }

        public bool ValidateForm()
        {
           if (cmbDateFrom.Text == string.Empty)
            {
                custodianasseterrorProvider.SetError(cmbDateFrom, "Date from is required");
                return false;
            }
           if (assetList.Status == (int)AssetStatuses.Sold)
            {
                ViewHelper.ShowErrorMessage("The asset you selected is sold.Select another asset.");
                DialogResult = DialogResult.No;
                return false;
            }
            if (assetList.Status == (int)AssetStatuses.Disposed)
            {
                ViewHelper.ShowErrorMessage("The asset you selected is disposed.Select another asset");
                DialogResult = DialogResult.No;
                return false;
            }
            var ast = from row in _context.CustodianAssets.ToList()
                      where row.AssetId == assetList.AssetId && row.Status == (int)CustodyAssignmentStatus.Assigned
                      select row;
            if (ast.Count() != 0)
            {
                ViewHelper.ShowErrorMessage("The selected asset has already been assigned.");
                DialogResult = DialogResult.No;
                return false;
            }
            return true;
        }

        private void btnAssignAsset_Click(object sender, EventArgs e)
        {
            SaveChanges();
        }

        public void DeleteObject()
        {
            throw new NotImplementedException();
        }
        public bool DataChanged()
        {
            throw new NotImplementedException();
        }

        public void AuthorizeForm()
        {
            btnAssignAsset.Enabled = permissionManager.IsAuthorized(PermissionManager.FIXED_ASSET_APPLICATION,
                                                                    faph.ItemName(
                                                                        FixedAssetPermissionHelper.Operation.
                                                                            AssignNewAsset));
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }


    }
}