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
    public partial class IssueListView : DevExpress.XtraEditors.XtraForm,IListForm
    {
        private InventoryEntities context;
        private PermissionManager permissionManager;
        private InventoryPermissionHelper iph;
        public IssueListView()
        {
            InitializeComponent();
            context = new InventoryEntities();
            iph = new InventoryPermissionHelper();
            permissionManager = PermissionManager.GetPermissionManager();
            AuthorizeForm();
        }

        public void ShowList()
        {
            issuesBindingSource.DataSource = context.IssueInfoes.ToList();
        }

        public void OpenSelectedItem()
        {
            var editor = new IssueEdit();
            var issue = issuesBindingSource.Current as IssueInfo;
            editor.ShowObject(issue);
            editor.MdiParent = this.MdiParent;
            editor.Show();
        }

        public object GetSelectedItem()
        {
            return issuesBindingSource.Current;
        }

        public void RefreshList()
        {
            context = new InventoryEntities();
            ShowList();
        }

        public void AuthorizeForm()
        {
            newIssueBarButtonItem.Enabled = permissionManager.IsAuthorized(PermissionManager.INVENTORY_APPLICATION,
                                                              iph.ItemName(
                                                                  InventoryPermissionHelper.Operation.AddItemIssue));
        }

        private void newIssueBarButtonItem_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            NewIssue();
        }

        private void NewIssue()
        {
            var form = new NewIsssue();
            form.ShowObject(null);
            var result = form.ShowDialog(this);
            if (result == DialogResult.OK)
            {
                //Load IssueEdit form here
                var editor = new IssueEdit();
                var issue = context.IssueInfoes.SingleOrDefault(i => i.IssueId == form.IssueId);
                editor.ShowObject(issue);
                editor.MdiParent = this.MdiParent;
                editor.Show();
                RefreshList();
            }
        }

        private void refreshBarButtonItem_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            RefreshList();
        }

        private void IssueListView_Activated(object sender, EventArgs e)
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