using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using ClearOffice.FixedAsset.DataAccess;
using ClearOffice.Infrastructure;
using ClearOffice.Security;
using DevExpress.XtraEditors;
using System.Linq;
namespace ClearOffice.FixedAsset.Views
{
    public partial class NewAsset : DevExpress.XtraEditors.XtraForm,IDetailForm
    {
        private FixedAssetEntities _context;
        private bool _saveAndNew;
        private PermissionManager permissionManager;
        private FixedAssetPermissionHelper faph;
        public XtraForm MainParent { get; set; }


        public NewAsset()
        {
            InitializeComponent(); 
            _context = new FixedAssetEntities();
            permissionManager = PermissionManager.GetPermissionManager();
            faph = new FixedAssetPermissionHelper();
            AuthorizeForm();
    
        }

        public void ShowObject(object keyValue)
        {
            //Load new fixed asset object.
            if (keyValue == null)
            {
                newAssetBindingSource.DataSource = new Asset();
                LoadLookups();
            }
        }

        private void LoadLookups()
        {
            catagoryBindingSource.DataSource =_context.AssetCategories.ToList();
            groupBindingSource.DataSource = _context.LookupItems.Where(li => li.LookupId == (int) LookupItems.AssetGroup);
            costCenterBindingSource.DataSource =
                _context.LookupItems.Where(li => li.LookupId == (int) LookupItems.CostCenter);
            depreciationMethodBindingSource.DataSource =
                _context.LookupItems.Where(li => li.LookupId == (int) LookupItems.DepreciationMethods);
            locationBindingSource.DataSource =
                _context.LookupItems.Where(li => li.LookupId == (int) LookupItems.Location);
        }

        public bool DataChanged()
        {
            throw new NotImplementedException();
        }

        public void SaveChanges()
        {
            var asset = (Asset) newAssetBindingSource.DataSource;
            asset.Status =(int)AssetStatuses.Active;
            if(!ValidateForm())
                return;
            try
            {
                _context.Assets.AddObject(asset);
                _context.SaveChanges();
                if (!_saveAndNew)
                {
                    Close();
                    var asdForm = new AssetDetail();
                    asdForm.MdiParent = MainParent;
                    asdForm.ShowObject(asset.AssetId);
                    asdForm.Show();
                }
                else
                {
                    ShowObject(null);
                }
            }
            catch (Exception ex)
            {
                
              ViewHelper.ShowErrorMessage("Error occured while saving the current asset.",ex);
            }
        }

        public void DeleteObject()
        {
            throw new NotImplementedException();
        }

        public bool ValidateForm()
        {
            bool result = true;
            assetErrorProvider.Clear();
            if (assetNumberTextBox.Text == string.Empty)
            {
                assetErrorProvider.SetError(assetNumberTextBox, "Asset number is required.");
                result = false;
            }
            if (groupIdLookUpEdit.EditValue == DBNull.Value)
            {
                assetErrorProvider.SetError(groupIdLookUpEdit, "Asset group is required.");
                result = false;
            }
            if (depreciationMethodLookUpEdit.EditValue == DBNull.Value)
            {
                assetErrorProvider.SetError(depreciationMethodLookUpEdit,"Depreciation method is required.");
                result = false;
            }
            if (costCenterIdLookUpEdit.EditValue == DBNull.Value)
            {
                assetErrorProvider.SetError(costCenterIdLookUpEdit,"Cost center is required.");
                result = false;
            }
            if (assetValueTextBox.Text == string.Empty)
            {
                assetErrorProvider.SetError(assetValueTextBox,"The asset value is required.");
                result = false;
            }
            if (depreciationMethodLookUpEdit.EditValue != DBNull.Value)
            {
                if ((int)depreciationMethodLookUpEdit.EditValue == (int)DepreciationMethods.StraightLine && salvageValueTextBox.Text == string.Empty)
                {
                    assetErrorProvider.SetError(salvageValueTextBox,"Salvage value can't be empty.");
                    result = false;
                }
            }
            if (usefulLifeTextBox.Text == string.Empty)
            {
                assetErrorProvider.SetError(usefulLifeTextBox,"Usefull life of the asset is required.");
                result = false;
            }
            return result;
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            _saveAndNew = false;
            SaveChanges();
        }

        private void btnSaveAndNew_Click(object sender, EventArgs e)
        {
            _saveAndNew = true;
            SaveChanges();
        }


        public void AuthorizeForm()
        {
            btnSave.Enabled = permissionManager.IsAuthorized(PermissionManager.FIXED_ASSET_APPLICATION,
                                                             faph.ItemName(FixedAssetPermissionHelper.Operation.AddAsset));
            btnSaveAndNew.Enabled = permissionManager.IsAuthorized(PermissionManager.FIXED_ASSET_APPLICATION,
                                                                   faph.ItemName(
                                                                       FixedAssetPermissionHelper.Operation.AdjustAsset));
        }
    }
}