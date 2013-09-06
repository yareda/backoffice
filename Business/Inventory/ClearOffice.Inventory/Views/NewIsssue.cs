using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using ClearOffice.Security;
using DevExpress.XtraEditors;
using ClearOffice.Infrastructure;
using ClearOffice.Inventory.DataAccess;

namespace ClearOffice.Inventory.Views
{
    public partial class NewIsssue : DevExpress.XtraEditors.XtraForm,IDetailForm
    {
        private InventoryEntities context;
        private PermissionManager permissionManager;
        private InventoryPermissionHelper iph;
        private Issue issue;

        public int IssueId { get; set; }

        public NewIsssue()
        {
            InitializeComponent();
            context = new InventoryEntities();
            iph = new InventoryPermissionHelper();
            permissionManager = PermissionManager.GetPermissionManager();
            AuthorizeForm();
            var warehouses = context.Warehouses.ToList();
            warehouseBindingSource.DataSource = warehouses.ToList();
        }

        public void ShowObject(object keyValue)
        {
            issue = new Issue();
            issue.IssueNo = InventoryHelper.GetNextIssueNo();
            issueBindingSource.DataSource = issue;
        }

        public bool DataChanged()
        {
            throw new NotImplementedException();
        }

        public void SaveChanges()
        {
            issueBindingSource.EndEdit();
            var newIssueNo = InventoryHelper.GetNextIssueNo();
            issue.IssueNo= newIssueNo;
            issue.StatusId = InventoryHelper.STATUS_PENDING;

            try
            {
                context.Issues.AddObject(issue);
                context.SaveChanges();
                var obj = context.Issues.Single(i => i.IssueNo== newIssueNo);
                this.IssueId= obj.IssueId;
                this.DialogResult = DialogResult.OK;
                InventoryHelper.UpdateIssueNo(newIssueNo);
            }
            catch (Exception exception)
            {
                ViewHelper.ShowErrorMessage("Error saving new issue record.", exception);
            }
        }

        public void DeleteObject()
        {
            throw new NotImplementedException();
        }

        public bool ValidateForm()
        {
            return issue.IsValid();
        }

        public void AuthorizeForm()
        {
            saveCommand.Enabled = permissionManager.IsAuthorized(PermissionManager.INVENTORY_APPLICATION,
                                                                iph.ItemName(
                                                                    InventoryPermissionHelper.Operation.AddItemIssue));
        }

        private void cancelCommand_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.Cancel;
        }

        private void saveCommand_Click(object sender, EventArgs e)
        {
            SaveChanges();
        }

        private void issueBindingSource_CurrentItemChanged(object sender, EventArgs e)
        {
            saveCommand.Enabled = issue.IsValid();
        }
    }
}