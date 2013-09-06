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
    public partial class ReturnListView : DevExpress.XtraEditors.XtraForm, IListForm
    {
        private InventoryEntities context;
        private PermissionManager permissionManager;
        private InventoryPermissionHelper iph;
        public ReturnListView()
        {
            InitializeComponent();
            context = new InventoryEntities();
            iph = new InventoryPermissionHelper();
            permissionManager = PermissionManager.GetPermissionManager();
            AuthorizeForm();
        }

        public void ShowList()
        {
            returnBindingSource.DataSource = context.ReturnInfoes.ToList();
        }

        public void OpenSelectedItem()
        {
            var editor = new ReturnEdit();
            var obj = returnBindingSource.Current as ReturnInfo;
            editor.ShowObject(obj);
            editor.MdiParent = this.MdiParent;
            editor.Show();
        }

        public object GetSelectedItem()
        {
            return returnBindingSource.Current as ReturnInfo;
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
                                                                   InventoryPermissionHelper.Operation.AddItemReturn));
        }

        private void NewReturn()
        {
            var form = new NewReturn();
            form.ShowObject(null);
            var result = form.ShowDialog(this);

            if (result == DialogResult.OK)
            {
                //Load IssueEdit form here
                var editor = new ReturnEdit();
                var issue = context.ReturnInfoes.SingleOrDefault(i => i.ReturnId == form.ReturnId);
                editor.ShowObject(issue);
                editor.MdiParent = this.MdiParent;
                editor.Show();
                RefreshList();
            }
        }

        private void newBarButtonItem_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            NewReturn();
        }

        private void refreshBarButtonItem_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            RefreshList();
        }

        private void ReturnListView_Activated(object sender, EventArgs e)
        {
            var p = this.MdiParent as RibbonForm;
            p.Ribbon.SelectedPage = p.Ribbon.Pages[Constants.INVENTORY_RIBBON_NAME];
        }

        private void gridControl1_DoubleClick(object sender, EventArgs e)
        {
            OpenSelectedItem();
        }
    }
}