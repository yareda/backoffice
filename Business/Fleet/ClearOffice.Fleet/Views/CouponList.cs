using System;
using System.Linq;
using System.Windows.Forms;
using ClearOffice.Infrastructure;
using ClearOffice.Fleet.Business;
using ClearOffice.Security;
using DevExpress.XtraBars.Ribbon;

namespace ClearOffice.Fleet.Views
{
    public partial class CouponList : DevExpress.XtraEditors.XtraForm, IListForm
    {
        private  FleetEntities context;
        private PermissionManager _pm;
        private FleetPermissionHelper _fph;
        public CouponList()
        {
            InitializeComponent();
            context = new FleetEntities();

            _pm = PermissionManager.GetPermissionManager();
            _fph = new FleetPermissionHelper();

            AuthorizeForm();
        }

        #region IListForm members

        public void ShowList()
        {
            this.couponsBindingSource.DataSource = context.CouponInfoes.ToList();
        }

        public void OpenSelectedItem()
        {
            throw new NotImplementedException();
        }

        public object GetSelectedItem()
        {
            return couponsBindingSource.Current;
        }

        public void RefreshList()
        {
            context = new FleetEntities();
            this.couponsBindingSource.DataSource = context.CouponInfoes.ToList();
        }

        #endregion

        private void refreshBarButtonItem_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            RefreshList();
        }

        private void newCouponBarButtonItem_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            var form = new NewCouponView();
            form.ShowObject(null);
            var result = form.ShowDialog();
            if (result == DialogResult.OK)
            {
                ShowList();
            }
        }

        private void CouponList_Activated(object sender, EventArgs e)
        {
            var p = this.MdiParent as RibbonForm;
            p.Ribbon.SelectedPage = p.Ribbon.Pages[Constants.FLEET_RIBBON_NAME];
        }

        private void gridControl1_DoubleClick(object sender, EventArgs e)
        {
            var coupon = (CouponInfo)couponsBindingSource.Current;
            var detail = new CouponDetailView();
            detail.ShowObject(coupon);
            detail.MdiParent = this.MdiParent;
            detail.Show();
        }


        public void AuthorizeForm()
        {
            newCouponBarButtonItem.Enabled = _pm.IsAuthorized(PermissionManager.FLEET_APPLICATION, _fph.ItemName(
                FleetPermissionHelper.Operation.AddNewCoupon));

        }
    }
}