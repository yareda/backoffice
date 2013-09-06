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
    public partial class AssetCategoryList : DevExpress.XtraEditors.XtraForm ,IListForm ,IDetailForm
    {
        private FixedAssetEntities _context;
        private AssetCategory _assetCategory;
        private PermissionManager permissionManager;
        private FixedAssetPermissionHelper faph;
        public AssetCategoryList()
        {
            InitializeComponent();
            _context =new FixedAssetEntities();
            permissionManager = PermissionManager.GetPermissionManager();
            faph = new FixedAssetPermissionHelper();    
            AuthorizeForm();
            ShowList();
        }
        public void ShowList()
        {
            var assetcategory = _context.AssetCategories.ToList();
            assetcategorybindingSource.DataSource = assetcategory.ToList();
        }

        public void OpenSelectedItem()
        {
          if(_assetCategory!=null)
          {
              var assetcategorydetail = new AssetCategoryView();
              assetcategorydetail.ShowObject(_assetCategory);
              assetcategorydetail.ShowDialog();
          }
        }

        public object GetSelectedItem()
        {
            return assetcategorybindingSource.Current;
        }
        
        private void newCategory_Click(object sender, EventArgs e)
        {
            var assetcategory = new AssetCategoryView();
            assetcategory.ShowObject(null);
            assetcategory.ShowDialog();

        }

        private void gridControl1_Click(object sender, EventArgs e)
        {

            if (gridView1.SelectedRowsCount > 0)
            {
                var selected = (AssetCategory)gridView1.GetRow((int)gridView1.GetSelectedRows().GetValue(0));
                if (null != selected)
                {
                    _assetCategory = _context.AssetCategories.FirstOrDefault(ct => ct.CategoryId == selected.CategoryId);

                }
            }
            GetSelectedItem();
            btnDelete.Enabled = true;
        }

        private void gridControl1_DoubleClick(object sender, EventArgs e)
        {
            if (gridView1.SelectedRowsCount > 0)
            {
                var selected = (AssetCategory)gridView1.GetRow((int)gridView1.GetSelectedRows().GetValue(0));
                if (null != selected)
                {
                    _assetCategory = _context.AssetCategories.FirstOrDefault(ct => ct.CategoryId == selected.CategoryId);

                }
            }
            OpenSelectedItem();
        }
        public void RefreshList()
        {
            _context = new FixedAssetEntities();
            assetcategorybindingSource.DataSource = _context.AssetCategories.ToList();
        }

        private void btnRefresh_Click(object sender, EventArgs e)
        {
            RefreshList();
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            var result = ViewHelper.ShowConfirmDialog("Are you sure you want to delete the current record?");
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
            return;
        }


        public void ShowObject(object keyValue)
        {
            throw new NotImplementedException();
        }

        public bool DataChanged()
        {
            throw new NotImplementedException();
        }

        public void SaveChanges()
        {
            throw new NotImplementedException();
        }

        public void DeleteObject()
        {
            try
            {
                _context = new FixedAssetEntities();
                var d = _context.AssetCategories.First(ct => ct.CategoryId == _assetCategory.CategoryId);
                _context.DeleteObject(d);
                _context.SaveChanges();
                RefreshList();

            }
            catch (Exception exception)
            {
                ViewHelper.ShowErrorMessage("Unable to delete the selected category.",exception);
            }
        }

        public bool ValidateForm()
        {
            throw new NotImplementedException();
        }


        public void AuthorizeForm()
        {
            newCategory.Enabled = permissionManager.IsAuthorized(PermissionManager.FIXED_ASSET_APPLICATION,
                                                                 faph.ItemName(
                                                                     FixedAssetPermissionHelper.Operation.
                                                                         AddAssetCategory));
            btnDelete.Enabled = permissionManager.IsAuthorized(PermissionManager.FIXED_ASSET_APPLICATION,
                                                               faph.ItemName(
                                                                   FixedAssetPermissionHelper.Operation.
                                                                       DeleteAssetCategory));
        }
    }
}