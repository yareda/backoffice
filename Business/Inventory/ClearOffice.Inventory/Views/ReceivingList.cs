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
using DevExpress.XtraBars.Ribbon;
using DevExpress.XtraEditors;

namespace ClearOffice.Inventory.Views
{
    public partial class ReceivingList : DevExpress.XtraEditors.XtraForm,IListForm
    {
        private InventoryEntities context;
        private PermissionManager permissionManager;
        private InventoryPermissionHelper iph;
        public ReceivingList()
        {
            InitializeComponent();
            context = new InventoryEntities();
            iph = new InventoryPermissionHelper();
            permissionManager = PermissionManager.GetPermissionManager();
            AuthorizeForm();
        }

        public void ShowList()
        {
            receivingsBindingSource.DataSource = context.ReceivingInfoes.ToList();
        }

        public void OpenSelectedItem()
        {
            var editor = new ReceivingEdit();
            var receiving = receivingsBindingSource.Current as ReceivingInfo;
            editor.ShowObject(receiving);
            editor.MdiParent = this.MdiParent;
            editor.Show();
        }

        public object GetSelectedItem()
        {
            return receivingsBindingSource.Current as ReceivingInfo;
        }

        public void RefreshList()
        {
            context = new InventoryEntities();
            ShowList();
        }

        public void AuthorizeForm()
        {
            newReceivingBarButtonItem.Enabled = permissionManager.IsAuthorized(PermissionManager.INVENTORY_APPLICATION,
                                                                         iph.ItemName(
                                                                             InventoryPermissionHelper.Operation.
                                                                                 AddItemReceiving));
        }

        private void ReceivingList_Activated(object sender, EventArgs e)
        {
            var p = this.MdiParent as RibbonForm;
            p.Ribbon.SelectedPage = p.Ribbon.Pages[Constants.INVENTORY_RIBBON_NAME];
        }

        private void newReceivingBarButtonItem_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            var form = new NewReceiving();
            form.ShowObject(null);
            var result = form.ShowDialog(this);
            if(result==DialogResult.OK)
            {
                //Load the receiving edit form here
                var editor = new ReceivingEdit();
                var receiving = context.ReceivingInfoes.SingleOrDefault(s => s.ReceivingId == form.NewReceivingId);
                editor.ShowObject(receiving);
                editor.MdiParent = this.MdiParent;                
                editor.Show();
                RefreshList();
            }
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