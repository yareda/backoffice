using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using ClearOffice.Inventory.DataAccess;
using ClearOffice.Security;
using DevExpress.XtraBars.Ribbon;
using DevExpress.XtraEditors;
using ClearOffice.Infrastructure;

namespace ClearOffice.Inventory.Views
{
    public partial class ItemsListView : DevExpress.XtraEditors.XtraForm, IListForm
    {
        private InventoryEntities context;
        private PermissionManager permissionManager;
        private InventoryPermissionHelper iph;
        public ItemsListView()
        {
            InitializeComponent();
            context = new InventoryEntities();
            iph = new InventoryPermissionHelper();
            permissionManager = PermissionManager.GetPermissionManager();
            AuthorizeForm();
        }

        public void ShowList()
        {
            itemListBindingSource.DataSource = context.ItemInfoes.ToList();
        }

        public void OpenSelectedItem()
        {
            throw new NotImplementedException();
        }

        public object GetSelectedItem()
        {
            return itemListBindingSource.Current as ItemInfo;
        }

        public void RefreshList()
        {
            context = new InventoryEntities();
            ShowList();
        }

        public void AuthorizeForm()
        {
          newItemBarButtonItem.Enabled = permissionManager.IsAuthorized(PermissionManager.INVENTORY_APPLICATION,
                                                             iph.ItemName(
                                                                 InventoryPermissionHelper.Operation.AddItem));
        }

        private void newItemBarButtonItem_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            NewItem();
        }

        private void NewItem()
        {
            var form = new ItemDetail();
            form.ShowObject(null);
            var result = form.ShowDialog(this);
            if (result == DialogResult.OK)
                RefreshList();
        }

        private void LoadSelectedItem()
        {
            try
            {
                var item = itemListBindingSource.Current as ItemInfo;
                var form = new ItemDetail();
                form.ShowObject(item);
                var result = form.ShowDialog(this);
                if (result == DialogResult.OK)
                    RefreshList();
            }
            catch (Exception exception)
            {
                ViewHelper.ShowErrorMessage("Error loading Item information", exception);
            }
        }

        private void gridControl1_DoubleClick(object sender, EventArgs e)
        {
            LoadSelectedItem();
        }

        private void newItemToolStripMenuItem_Click(object sender, EventArgs e)
        {
            NewItem();
        }

        private void openItemToolStripMenuItem_Click(object sender, EventArgs e)
        {
            LoadSelectedItem();
        }

        private void deleteItemToolStripMenuItem_Click(object sender, EventArgs e)
        {
            try
            {
                var item = itemListBindingSource.Current as ItemInfo;
                var result = ViewHelper.ShowConfirmDialog(string.Format("Are you sure you want to delete the item: {0} ?",item.ItemNo));
                if(result==DialogResult.Yes)
                {
                    var data = context.InventoryItems.SingleOrDefault(i => i.ItemId == item.ItemId);
                    context.InventoryItems.DeleteObject(data);
                    context.SaveChanges();
                    RefreshList();
                }
            }
            catch (Exception exception)
            {
                ViewHelper.ShowErrorMessage("Error deleting selected Item information", exception);
            }

        }

        private void refreshBarButtonItem_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            RefreshList();
        }

        private void ItemsListView_Activated(object sender, EventArgs e)
        {
            var p = this.MdiParent as RibbonForm;
            p.Ribbon.SelectedPage = p.Ribbon.Pages[Constants.INVENTORY_RIBBON_NAME];
        }
    }
}