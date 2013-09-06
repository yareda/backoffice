using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using ClearOffice.Infrastructure;
using ClearOffice.Security;
using DevExpress.XtraBars.Ribbon;
using DevExpress.XtraEditors;
using ClearOffice.FixedAsset.DataAccess;
using System.Linq;
namespace ClearOffice.FixedAsset.Views
{
    public partial class AssetList : DevExpress.XtraEditors.XtraForm, IListForm
    {
        private FixedAssetEntities _context;
        private PermissionManager permissionManager;
        private FixedAssetPermissionHelper faph;
        public AssetList()
        {
            InitializeComponent();
            assetGridControl.Dock = DockStyle.Fill;
            _context = new FixedAssetEntities();
            permissionManager = PermissionManager.GetPermissionManager();
            faph = new FixedAssetPermissionHelper();    
            AuthorizeForm();
        }

        public void ShowList()
        {
            var list = _context.AssetListInfoes.ToList();
            assetListBindingSource.DataSource = list;
        }

        public void OpenSelectedItem()
        {
            var selected = (Asset)GetSelectedItem();
            if (selected != null)
            {
                var assetDetail = new AssetDetail();
                assetDetail.ShowObject(selected.AssetId);
                assetDetail.MdiParent = this.MdiParent;
                assetDetail.Text = assetDetail.Text + " " + selected.AssetNumber;
                assetDetail.Show();
                return;
            }
        }

        public object GetSelectedItem()
        {
            var listinfo = (AssetListInfo)assetListBindingSource.Current;
            var selected = _context.Assets.FirstOrDefault(a => a.AssetId == listinfo.AssetId);
            return selected;
        }
        public void RefreshList()
        {
            var context = new FixedAssetEntities();
            var list = context.AssetListInfoes.ToList();
            assetListBindingSource.DataSource = list;
        }

        private void gridControl1_Click(object sender, EventArgs e)
        {
            var selected = GetSelectedItem();
            if (selected != null)
                deleteAssetBarButtonItem.Enabled = true;
        }

        private void gridControl1_DoubleClick(object sender, EventArgs e)
        {
            OpenSelectedItem();
            AuthorizeForm();
        }

        private void DeleteAsset()
        {
            var asset = GetSelectedItem();
            if (asset != null)
            {
                var result = ViewHelper.ShowConfirmDialog("Are you sure you want to delete this asset?");
                if (result == DialogResult.Yes)
                {
                    try
                    {
                        AuthorizeForm();
                        _context.DeleteObject(asset);
                        _context.SaveChanges();
                        RefreshList();
                    }
                    catch (Exception exception)
                    {
                        ViewHelper.ShowErrorMessage("Error deleting asset.",exception);                        
                    }
                }
            }
        }

        private void refreshListBarButtonItem_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            RefreshList();
        }

        private void deleteAssetBarButtonItem_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            
            DeleteAsset();
         }

        private void AssetList_Activated(object sender, EventArgs e)
        {
            try
            {
                var p = this.MdiParent as RibbonForm;
                p.Ribbon.SelectedPage = p.Ribbon.Pages["Fixed Asset"];
            }
            catch
            {

            }
        }

        private void calculateDepreciationBarButtonItem_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            DepereciationHelper.CalculateDepreciationToAll();
        }

        private void assignBarButtonItem_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            var selectedAsset = GetSelectedItem();
            if (selectedAsset != null)
            {
                var custAsset = new CustodianAssetView();
                custAsset.ShowObject(selectedAsset);
                custAsset.ShowDialog();
            }

            return;

        }


        public void AuthorizeForm()
        {
            deleteAssetBarButtonItem.Enabled = permissionManager.IsAuthorized(
                PermissionManager.FIXED_ASSET_APPLICATION,
                faph.ItemName(FixedAssetPermissionHelper.Operation.DeleteAsset));
            assignBarButtonItem.Enabled = permissionManager.IsAuthorized(PermissionManager.FIXED_ASSET_APPLICATION,
                                                                         faph.ItemName(
                                                                             FixedAssetPermissionHelper.Operation.
                                                                                 AssignNewAsset));
            calculateDepreciationBarButtonItem.Enabled =
                permissionManager.IsAuthorized(PermissionManager.FIXED_ASSET_APPLICATION,
                                               faph.ItemName(FixedAssetPermissionHelper.Operation.CalculateDepreciation));


        }
    }
}