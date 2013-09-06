using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using ClearOffice.FixedAsset.DataAccess;
using ClearOffice.Infrastructure;
using ClearOffice.Security;
using DevExpress.XtraEditors;

namespace ClearOffice.FixedAsset.Views
{
    public partial class AssetCategoryView : DevExpress.XtraEditors.XtraForm, IDetailForm
    {
        private FixedAssetEntities _context;
        private AssetCategory _assetCategory;
        private bool _newMode;
        private PermissionManager permissionManager;
        private FixedAssetPermissionHelper faph;
        public AssetCategoryView()
        {
            InitializeComponent();
            _context =new FixedAssetEntities();
            permissionManager = PermissionManager.GetPermissionManager();
            faph = new FixedAssetPermissionHelper();
            AuthorizeForm();
        }

        public void ShowObject(object keyValue)
        {
            if (keyValue == null)
            {
                _assetCategory = new AssetCategory();
                _newMode = true;
                assetcategorybindingSource.DataSource = _assetCategory;
                Text = @"New Asset Category";

            }
            else
            {
                _newMode = false;
                var value = (AssetCategory)keyValue;
                _assetCategory =_context.AssetCategories.FirstOrDefault(li=>li.CategoryId == value.CategoryId);
                assetcategorybindingSource.DataSource = _assetCategory;
                Text = @"Edit  Asset Category ";
            }
          
        }
    

       public bool DataChanged()
        {
            throw new NotImplementedException();
        }

        public void SaveChanges()
        {
            if (!ValidateForm()) return;
            assetcategorybindingSource.EndEdit();
            _assetCategory = (AssetCategory)assetcategorybindingSource.DataSource;
            if (_newMode)
                _context.AssetCategories.AddObject(_assetCategory);
            try
            {
                _context.SaveChanges();
                _newMode = false;
                this.Close();
             }
            catch (Exception ex )
            {
                ViewHelper.ShowErrorMessage("Error occured while saving the current asset category.", ex);
            }
        }

        public void DeleteObject()
        {
            throw new NotImplementedException();
        }

        public bool ValidateForm()
        {
            if (nameTextBox.Text == string.Empty)
            {
                errorProvider1.SetError(nameTextBox, "name # is Required");
                return false;
            }
            if (codeTextBox.Text == string.Empty)
            {
                errorProvider1.SetError(nameTextBox, "Rate # is Required");
                return false;
            }
            return true;
        }

        private void btnCategorySave_Click(object sender, EventArgs e)
        {
            SaveChanges();
        }


        public void AuthorizeForm()
        {
            btnCategorySave.Enabled = permissionManager.IsAuthorized(PermissionManager.FIXED_ASSET_APPLICATION,
                                                                     faph.ItemName(
                                                                         FixedAssetPermissionHelper.Operation.
                                                                             AddAssetCategory));

        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.Cancel;
            this.Close();
        }
    }
}