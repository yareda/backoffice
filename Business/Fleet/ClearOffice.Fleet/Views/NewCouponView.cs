using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using ClearOffice.Security;
using DevExpress.XtraEditors;
using ClearOffice.Infrastructure;
using ClearOffice.Fleet.Business;

namespace ClearOffice.Fleet.Views
{
    public partial class NewCouponView : DevExpress.XtraEditors.XtraForm, IDetailForm
    {
        private readonly FleetEntities context;
        private Coupon coupon;
        private PermissionManager _pm;
        private FleetPermissionHelper _fph;
        public NewCouponView()
        {
            InitializeComponent();
            context = new FleetEntities();


            _pm = PermissionManager.GetPermissionManager();
            _fph = new FleetPermissionHelper();

            AuthorizeForm();
        }

        #region IDetailForm members
        
        public void ShowObject(object keyValue)
        {
            coupon = new Coupon();
            couponBindingSource.DataSource = coupon;
        }

        public bool DataChanged()
        {
            throw new NotImplementedException();
        }

        public void SaveChanges()
        {
            couponBindingSource.EndEdit();
            try
            {
                context.Coupons.AddObject(coupon);
                context.SaveChanges();
                this.DialogResult = DialogResult.OK;                
            }
            catch (Exception exception)
            {
                ViewHelper.ShowErrorMessage("Error adding coupon information",exception);                
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

        private void addCommand_Click(object sender, EventArgs e)
        {
            SaveChanges();
        }

        private void cancelCommand_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.Cancel;
        }

        private void couponBindingSource_CurrentItemChanged(object sender, EventArgs e)
        {
            this.addCommand.Enabled = coupon.IsValid();
        }


        public void AuthorizeForm()
        {
            addCommand.Enabled = _pm.IsAuthorized(PermissionManager.FLEET_APPLICATION, _fph.ItemName(
                FleetPermissionHelper.Operation.AddNewCoupon));
        }
    }
}