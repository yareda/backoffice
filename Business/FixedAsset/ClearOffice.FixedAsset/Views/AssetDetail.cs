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
    public partial class AssetDetail : DevExpress.XtraEditors.XtraForm, IDetailForm
    {
        private FixedAssetEntities _context;
        private Asset _asset;
        public object CurrenObject { get { return _asset; } }
        private PermissionManager permissionManager;
        private FixedAssetPermissionHelper faph;

        public AssetDetail()
        {
            InitializeComponent();
            assetPanel.Location = new Point(0, 0);
            assetPanel.Dock = DockStyle.Fill;
            _context = new FixedAssetEntities();
            permissionManager = PermissionManager.GetPermissionManager();
            faph = new FixedAssetPermissionHelper();
            AuthorizeForm();

        }
        public void ShowObject(object keyValue)
        {
            _asset = _context.Assets.FirstOrDefault(a => a.AssetId == (int)keyValue);
            assetDetailBindingSource.DataSource = _asset;
            adjustementBindingSource.DataSource = _context.Adjustments.Where(aj => aj.AssetId == _asset.AssetId);
            adjustementTypeBindingSource.DataSource =
                _context.LookupItems.Where(li => li.LookupId == (int)LookupItems.AdjustementType);
            adjustStatusBindingSource.DataSource =
                _context.LookupItems.Where(li => li.LookupId == (int)LookupItems.AdjustementStatus);
            deperciationBindingSource.DataSource = _context.Depreciations.Where(d => d.AssetId == _asset.AssetId);
            var cta = _context.CustodianAssetInfoes.Where(ca => ca.AssetId == _asset.AssetId);
            custodianAssetBindingSource.DataSource = cta.ToList();
            var assetListInfo = _context.AssetListInfoes.FirstOrDefault(a => a.AssetId == _asset.AssetId);
            txtCurrentBookvalue.Text = assetListInfo.CurrentBookValue.ToString();
            txtDeperToDate.Text = assetListInfo.DepreciationToDate.ToString();
            LoadLookups();

            disposeAssetBarButtonItem.Enabled = _asset.Status == (int)AssetStatuses.Active;
            linkDispoInfo.Visible = _asset.Status == (int)AssetStatuses.Disposed;
            btnNewAdj.Enabled = _asset.Status == (int)AssetStatuses.Active;
            var cusAsset = _context.CustodianAssets.FirstOrDefault(c => c.AssetId == _asset.AssetId && c.Status == (int)CustodyAssignmentStatus.Assigned);
            returnBarButtonItem.Enabled = cusAsset != null;
            transferAssetBarButtonItem.Enabled = cusAsset != null;
            saveAssetBarButtonItem.Enabled = _asset.Status == (int)AssetStatuses.Active;
        }

        private void LoadLookups()
        {
            catagoryBindingSource.DataSource = _context.AssetCategories.ToList();
            groupBindingSource.DataSource = _context.LookupItems.Where(li => li.LookupId == (int)LookupItems.AssetGroup);
            locationBindingSource.DataSource =
                _context.LookupItems.Where(li => li.LookupId == (int)LookupItems.Location);
            costCenterBindingSource.DataSource =
                _context.LookupItems.Where(li => li.LookupId == (int)LookupItems.CostCenter);
            physicalConditionBindingSource.DataSource =
                _context.LookupItems.Where(li => li.LookupId == (int)LookupItems.PhysicalCondition);
            depreciationMethodBindingSource.DataSource =
                _context.LookupItems.Where(li => li.LookupId == (int)LookupItems.DepreciationMethods);
            assetStatusBindingSource.DataSource =
                _context.LookupItems.Where(li => li.LookupId == (int)LookupItems.AssetStatus);
            vendorBindingSource.DataSource = _context.LookupItems.Where(li => li.LookupId == (int)LookupItems.Vendor);
        }

        public bool DataChanged()
        {
            return _context.ObjectStateManager.GetObjectStateEntries(EntityState.Added | EntityState.Modified |
                                  EntityState.Deleted).Any();
        }

        public void SaveChanges()
        {
            if (!ValidateForm())
                return;
            try
            {
                _context.SaveChanges();
                saveAssetBarButtonItem.Enabled = false;
            }
            catch (Exception ex)
            {
                ViewHelper.ShowErrorMessage("Error occured while saving the current asset.", ex);
                return;
            }
        }

        public void DeleteObject()
        {
            throw new NotImplementedException();
        }

        public bool ValidateForm()
        {
            bool result = true;
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
                assetErrorProvider.SetError(depreciationMethodLookUpEdit, "Depreciation method is required.");
                result = false;
            }
            if (costCenterIdLookUpEdit.EditValue == DBNull.Value)
            {
                assetErrorProvider.SetError(costCenterIdLookUpEdit, "Cost center is required.");
                result = false;
            }
            return result;
        }

        private void assetDetailBindingSource_CurrentItemChanged(object sender, EventArgs e)
        {
            saveAssetBarButtonItem.Enabled = DataChanged() && _asset.Status == (int)AssetStatuses.Active;
            disposeAssetBarButtonItem.Enabled = _asset.Status == (int)AssetStatuses.Active;
            linkDispoInfo.Visible = _asset.Status == (int)AssetStatuses.Disposed;
            AuthorizeForm();
        }

        private void btnNewAdj_Click(object sender, EventArgs e)
        {
            var adjustement = new Adjustment() { AssetId = _asset.AssetId };
            // NOte The previous value is always set to current book value of the asset but for the time bing I am using the asset value as previous value.
            adjustement.PreviousValue = _asset.AssetValue;
            var adjedit = new AdjustementEdit();
            adjedit.ShowObject(adjustement);
            var result = adjedit.ShowDialog();
            if (result == DialogResult.OK)
            {
                adjustementBindingSource.DataSource = _context.Adjustments.Where(a => a.AssetId == _asset.AssetId);
                return;
            }
        }

        private void adjustementBindingSource_CurrentItemChanged(object sender, EventArgs e)
        {
            saveAssetBarButtonItem.Enabled = true;
            AuthorizeForm();
        }

        private void gridControl2_Click(object sender, EventArgs e)
        {
            var adjustement = (Adjustment)adjustementBindingSource.Current;
            if (adjustement != null)
            {
                btnDeleteAdj.Enabled = _asset.Status == (int)AssetStatuses.Active;
                btnPostAdj.Enabled = (adjustement.Status == (int)AdjustemntStatus.Pending) && _asset.Status == (int)AssetStatuses.Active;
            }
        }

        private void gridControl2_DoubleClick(object sender, EventArgs e)
        {
            var adjustement = (Adjustment)adjustementBindingSource.Current;
            if (adjustement != null)
            {
                var adjedit = new AdjustementEdit();
                adjedit.ShowObject(adjustement);
                var result = adjedit.ShowDialog();
                if (result == DialogResult.OK)
                {
                    adjustementBindingSource.DataSource =
                        _context.Adjustments.Where(a => a.AssetId == _asset.AssetId);
                    return;
                }
            }
        }

        private void btnPostAdj_Click(object sender, EventArgs e)
        {
            var adjustement = (Adjustment)adjustementBindingSource.Current;
            if (adjustement != null)
            {
                var result = ViewHelper.ShowConfirmDialog("Are you sure you want to post this adjustement ?");
                if (result == DialogResult.Yes)
                {
                    //set the the asset value to the adjusted value
                    _asset.AssetValue = adjustement.AdjustedValue;
                    adjustement.Status = (int)AdjustemntStatus.Posted;
                    _asset.Adjustments.Add(adjustement);
                    _asset.AssetValue = adjustement.AdjustedValue;
                    var res = ViewHelper.ShowConfirmDialog("You haven't saved some asset information.Do you want to save ?");
                    if (res == DialogResult.Yes)
                    {
                        SaveChanges();
                        this.Close();
                        return;
                    }
                    else
                    {
                        adjustement.Status = (int)AdjustemntStatus.Pending;
                        _asset.Adjustments.Add(adjustement);
                        return;
                    }
                }
            }
        }

        private void linkDispoInfo_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            var disposal = _asset.Disposals.FirstOrDefault();
            if (disposal != null)
            {
                var disposalForm = new AssetDisposal();
                disposalForm.ShowObject(disposal);
                var val = disposalForm.ShowDialog();
            }
        }

        private void DisposeAsset()
        {
            var result = ViewHelper.ShowConfirmDialog("Are you sure you want to dispose this Asset ?");
            if (result == DialogResult.Yes)
            {
                var disposal = new Disposal() { AssetId = _asset.AssetId };
                var disposalForm = new AssetDisposal();
                disposalForm.ShowObject(disposal);
                var val = disposalForm.ShowDialog();
                if (val == DialogResult.OK)
                {
                    if (DataChanged())
                    {
                        var res =
                            ViewHelper.ShowConfirmDialog("you haven't saved some asset information.Do you want to save ?");
                        if (res == DialogResult.Yes)
                        {
                            SaveChanges();
                            this.Close();
                            return;
                        }
                        else
                        {
                            this.Close();
                            return;
                        }
                    }
                    else
                    {
                        this.Close();
                        return;
                    }
                }
            }
        }

        private void LoadDepreciationHistory()
        {
            var context2 = new FixedAssetEntities();
            deperciationBindingSource.DataSource = context2.Depreciations.Where(d => d.AssetId == _asset.AssetId);
        }

        private void DeleteAsset()
        {
            var result = ViewHelper.ShowConfirmDialog("Are you sure you want to delete this asset?");
            if (result == DialogResult.Yes)
            {
                try
                {
                    _context.DeleteObject(_asset);
                    _context.SaveChanges();
                    this.Close();
                }
                catch (Exception)
                {
                    ViewHelper.ShowDeleteError();
                    return;
                }
            }
        }

        private void btnDeleteAdj_Click(object sender, EventArgs e)
        {
            var adjust = (Adjustment)adjustementBindingSource.Current;
            if (adjust != null)
                _asset.Adjustments.Remove(adjust);
        }

        private void ReturnAsset()
        {
            var custasset =
                _context.CustodianAssets.Where(
                    al => al.AssetId == _asset.AssetId && al.Status == (int)CustodyAssignmentStatus.Assigned).FirstOrDefault();
            var result = ViewHelper.ShowConfirmDialog("Are you sure you want to return the selected asset?");
            if (result == DialogResult.Yes)
            {
                if (custasset != null)
                {
                    custasset.Status = (int)CustodyAssignmentStatus.Returned;
                    custasset.DateTo = DateTime.Today;
                    _context.SaveChanges();
                    ViewHelper.ShowSuccessMessage("The Asset has succesfully been Returned.");
                    this.Close();
                }
            }

            else if (result == DialogResult.No)
            {
                return;
            }
            else
            {
                return;
            }
        }


        private void TransferAsset()
        {
            var selectedAsset = assetDetailBindingSource.Current;
            if (selectedAsset != null)
            {
                var custAsset = new TransferAsset();
                custAsset.asset = (Asset)selectedAsset;
                custAsset.ShowObject(selectedAsset);
                custAsset.ShowDialog();
            }
        }

        private void CalculateDepreciation()
        {
            DepereciationHelper.CalculateDepreciation(this._asset);
        }

        private void saveAssetBarButtonItem_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            SaveChanges();
        }

        private void deleteAssetBarButtonItem_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            DeleteAsset();
        }

        private void calculateDepreciationBarButtonItem_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            CalculateDepreciation();
            LoadDepreciationHistory();
        }

        private void transferAssetBarButtonItem_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            TransferAsset();
        }

        private void returnBarButtonItem_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            ReturnAsset();
        }

        private void disposeAssetBarButtonItem_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            DisposeAsset();
        }

        private void AssetDetail_Activated(object sender, EventArgs e)
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


        public void AuthorizeForm()
        {
            saveAssetBarButtonItem.Enabled = permissionManager.IsAuthorized(PermissionManager.FIXED_ASSET_APPLICATION,
                                                                            faph.ItemName(FixedAssetPermissionHelper.Operation.UpdateAsset));
            transferAssetBarButtonItem.Enabled =permissionManager.IsAuthorized(PermissionManager.FIXED_ASSET_APPLICATION,
                                               faph.ItemName(FixedAssetPermissionHelper.Operation.TransferAsset));
            returnBarButtonItem.Enabled = permissionManager.IsAuthorized(PermissionManager.FIXED_ASSET_APPLICATION,
                                           faph.ItemName(FixedAssetPermissionHelper.Operation.ReturnAsset));
            disposeAssetBarButtonItem.Enabled = permissionManager.IsAuthorized(PermissionManager.FIXED_ASSET_APPLICATION,faph.ItemName
                                               (FixedAssetPermissionHelper.Operation.DisposeAsset));
            calculateDepreciationBarButtonItem.Enabled =
                permissionManager.IsAuthorized(PermissionManager.FIXED_ASSET_APPLICATION,
                                               faph.ItemName(FixedAssetPermissionHelper.Operation.CalculateDepreciation));
            deleteAssetBarButtonItem.Enabled = permissionManager.IsAuthorized(
                PermissionManager.FIXED_ASSET_APPLICATION,
                faph.ItemName(FixedAssetPermissionHelper.Operation.DeleteAsset));


        }
    }
}