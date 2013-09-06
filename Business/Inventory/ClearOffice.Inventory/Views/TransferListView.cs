using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using ClearOffice.Security;
using DevExpress.XtraBars.Ribbon;
using DevExpress.XtraEditors;
using ClearOffice.Infrastructure;
using ClearOffice.Inventory.DataAccess;

namespace ClearOffice.Inventory.Views
{
    public partial class TransferListView : DevExpress.XtraEditors.XtraForm,IListForm
    {
        private InventoryEntities context;
        private PermissionManager permissionManager;
        private InventoryPermissionHelper iph;
        public TransferListView()
        {
            InitializeComponent();
            context = new InventoryEntities();
            iph = new InventoryPermissionHelper();
            permissionManager = PermissionManager.GetPermissionManager();
            AuthorizeForm();
        }

        public void ShowList()
        {
            transferListBindingSource.DataSource = context.TransferInfoes.ToList();
        }

        public void OpenSelectedItem()
        {
            var editor = new TransferEdit();
            var obj = transferListBindingSource.Current as TransferInfo;
            editor.ShowObject(obj);
            editor.MdiParent = this.MdiParent;
            editor.Show();
        }

        public object GetSelectedItem()
        {
            return transferListBindingSource.Current as TransferInfo;
        }

        public void RefreshList()
        {
            context = new InventoryEntities();
            ShowList();
        }

        public void AuthorizeForm()
        {
            newBarButtonItem.Enabled = permissionManager.IsAuthorized(PermissionManager.INVENTORY_APPLICATION,
                                                                      iph.ItemName(
                                                                          InventoryPermissionHelper.Operation.
                                                                              AddItemTransfer));
            }


        private void NewTransfer()
        {
            var form = new NewTransfer();
            form.ShowObject(null);
            var result = form.ShowDialog(this);

            if (result == DialogResult.OK)
            {
                //Load IssueEdit form here
                var editor = new TransferEdit();
                var transfer = context.TransferInfoes.SingleOrDefault(t => t.TransferId== form.TransferId);
                editor.ShowObject(transfer);
                editor.MdiParent = this.MdiParent;
                editor.Show();
                RefreshList();
            }
        }

        private void TransferListView_Activated(object sender, EventArgs e)
        {
            var p = this.MdiParent as RibbonForm;
            p.Ribbon.SelectedPage = p.Ribbon.Pages[Constants.INVENTORY_RIBBON_NAME];
        }

        private void newBarButtonItem_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            NewTransfer();
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