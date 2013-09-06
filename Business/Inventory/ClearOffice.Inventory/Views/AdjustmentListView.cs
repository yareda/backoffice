using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using ClearOffice.Infrastructure;
using ClearOffice.Inventory.DataAccess;
using ClearOffice.Security;
using DevExpress.XtraEditors;

namespace ClearOffice.Inventory.Views
{
    public partial class AdjustmentListView : DevExpress.XtraEditors.XtraForm ,IListForm
    {
        private InventoryEntities context;
        private PermissionManager permissionManager;
        private InventoryPermissionHelper iph;
        public AdjustmentListView()
        {
            InitializeComponent();
            context =new InventoryEntities();
            iph = new InventoryPermissionHelper();
            permissionManager = PermissionManager.GetPermissionManager();
            AuthorizeForm();
        }

        private void newAdjustmentBarButtonItem_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            newAdjustment();
        }

        private void newAdjustment()
        {
            var form = new NewAdjustment();
            form.ShowObject(null);
            var result = form.ShowDialog(this);
            if (result == DialogResult.OK)
            {
                //Load Adjustment Edit form here
                var editor = new AdjustmentEdit();
                var adjust = context.AdjustmentInfoes.SingleOrDefault(i => i.AdjustmentId == form.AdjustmentId);
                editor.ShowObject(adjust);
                editor.MdiParent = this.MdiParent;
                editor.Show();
                RefreshList();
            }
        }

        public void ShowList()
        {
            adjutmentBindingSource.DataSource = context.AdjustmentInfoes.ToList();
        }

        public void OpenSelectedItem()
        {
            var editor = new AdjustmentEdit();
            var adjust = adjutmentBindingSource.Current as AdjustmentInfo;
            editor.ShowObject(adjust);
            editor.MdiParent = this.MdiParent;
            editor.Show();
        }

        public object GetSelectedItem()
        {
            throw new NotImplementedException();
        }

        public void RefreshList()
        {
            context = new InventoryEntities();
            ShowList();
        }

        public void AuthorizeForm()
        {
            newAdjustmentBarButtonItem.Enabled = permissionManager.IsAuthorized(PermissionManager.INVENTORY_APPLICATION,
                                                                          iph.ItemName(
                                                                              InventoryPermissionHelper.Operation.
                                                                                  AddItemAdjustment));
        }

        private void refreshBarButtonItem_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
           RefreshList();
        }

        private void gridControl1_DoubleClick(object sender, EventArgs e)
        {
            OpenSelectedItem();
        }
    }
}