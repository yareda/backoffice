using System;
using System.Linq;
using ClearOffice.Fleet.Business;
using ClearOffice.Security;
using DevExpress.XtraBars.Ribbon;
using ClearOffice.Infrastructure;

namespace ClearOffice.Fleet.Views
{
    public partial class CouponDetailView : DevExpress.XtraEditors.XtraForm, IDetailForm
    {
        private FleetEntities context;
        private Coupon coupon;
        private PermissionManager _pm;
        private FleetPermissionHelper _fph;
        public CouponDetailView()
        {
            InitializeComponent();
            context = new FleetEntities();
            LoadLookups();
            _pm = PermissionManager.GetPermissionManager();
            _fph = new FleetPermissionHelper();

            AuthorizeForm();
        }

        private void LoadLookups()
        {
            vehiclesBindingSource.DataSource = context.VehicleInfoes.ToList();
            var fuelTypeLookupId = Convert.ToInt32(FleetLookups.FuelType);
            fuelTypeBindingSource.DataSource = context.LookupItems.Where(li => li.LookupId.Value == fuelTypeLookupId);
        }

        #region IDetailForm members

        public void ShowObject(object keyValue)
        {
            var couponInfo = keyValue as CouponInfo;
            try
            {
                coupon = context.Coupons.FirstOrDefault(c => c.CouponId == couponInfo.CouponId);
                couponBindingSource.DataSource = coupon;
                transactionsBindingSource.DataSource = coupon.CouponTransaction;
                chartBindingSource.DataSource = couponInfo;
            }
            catch (Exception exception)
            {
                ViewHelper.ShowErrorMessage("Error loading coupon information", exception);
            }

        }

        public bool DataChanged()
        {
            throw new NotImplementedException();
        }

        public void SaveChanges()
        {
            try
            {
                context.SaveChanges();
            }
            catch (Exception exception)
            {
                ViewHelper.ShowErrorMessage("Error saving coupon information", exception);
            }
        }

        public void DeleteObject()
        {
            throw new NotImplementedException();
        }

        public bool ValidateForm()
        {
            throw new NotImplementedException();
        }

        #endregion

        private void CouponDetailView_Activated(object sender, EventArgs e)
        {
            var p = this.MdiParent as RibbonForm;
            p.Ribbon.SelectedPage = p.Ribbon.Pages[Constants.FLEET_RIBBON_NAME];
        }

        private void newToolStripButton_Click(object sender, EventArgs e)
        {
            LoadLookups();
            var transaction = new CouponTransaction();
            consumptionBindingSource.DataSource = transaction;
        }

        private void saveToolStripButton_Click(object sender, EventArgs e)
        {
            var transaction = consumptionBindingSource.Current as CouponTransaction;
            coupon.CouponTransaction.Add(transaction);
        }

        private void toolStripButton2_Click(object sender, EventArgs e)
        {
            try
            {
                var transaction = consumptionBindingSource.Current as CouponTransaction;
                coupon.CouponTransaction.Remove(transaction);
            }
            catch (Exception)
            {

            }
        }

        private void saveCouponBarButtonItem_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            SaveChanges();
        }

        private void deleteBarButtonItem_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            try
            {
                context.Coupons.DeleteObject(coupon);
                context.SaveChanges();
            }
            catch (Exception exception)
            {
                ViewHelper.ShowErrorMessage("Error deleting coupon record", exception);
            }
        }

        private void consumptionBindingSource_CurrentItemChanged(object sender, EventArgs e)
        {
            var transaction = consumptionBindingSource.Current as CouponTransaction;
            saveToolStripButton.Enabled = (transaction != null);
            cancelToolStripButton.Enabled = (transaction != null);
            if (transaction != null) saveToolStripButton.Enabled = transaction.IsValid();

            AuthorizeForm();
        }
        public void AuthorizeForm()
        {
            saveCouponBarButtonItem.Enabled = _pm.IsAuthorized(PermissionManager.FLEET_APPLICATION, _fph.ItemName(
                                                               FleetPermissionHelper.Operation.AddNewCoupon));
            deleteBarButtonItem.Enabled = _pm.IsAuthorized(PermissionManager.FLEET_APPLICATION, _fph.ItemName(
                FleetPermissionHelper.Operation.DeleteCoupon));
            newToolStripButton.Enabled = _pm.IsAuthorized(PermissionManager.FLEET_APPLICATION, _fph.ItemName(
                FleetPermissionHelper.Operation.CanConsumeCoupon));
        }
    }
}