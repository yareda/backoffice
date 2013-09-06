using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using ClearOffice.Inventory.Properties;
using ClearOffice.Security;
using DevExpress.XtraBars.Ribbon;
using DevExpress.XtraEditors;
using ClearOffice.Infrastructure;
using ClearOffice.Inventory.DataAccess;

namespace ClearOffice.Inventory.Views
{
    public partial class IssueEdit : DevExpress.XtraEditors.XtraForm, IDetailForm
    {
        private InventoryEntities context;
        private PermissionManager permissionManager;
        private InventoryPermissionHelper iph;
        private Issue issue;

        public IssueEdit()
        {
            InitializeComponent();
            context = new InventoryEntities();
            iph = new InventoryPermissionHelper();
            permissionManager = PermissionManager.GetPermissionManager();
            LoadLookups();
        }

        private void LoadLookups()
        {
            var warehouses = context.Warehouses.ToList();
            warehouseBindingSource.DataSource = warehouses.ToList();

            var statuses = context.TransactionStatus.ToList();
            statusBindingSource.DataSource = statuses;

            var items = context.ItemInfoes.ToList();
            itemsBindingSource.DataSource = items.ToList();
        }

        public void ShowObject(object keyValue)
        {
            try
            {
                var info = keyValue as IssueInfo;
                issue = context.Issues.Single(i => i.IssueId == info.IssueId);
                issueBindingSource.DataSource = issue;
                issueDetailBindingSource.DataSource = issue.IssueItems;
                this.Text = string.Format("Issue: {0}", issue.IssueNo);
                AuthorizeForm();
            }
            catch (Exception exception)
            {
                ViewHelper.ShowErrorMessage("Error loading issue information", exception);
            }
        }

        public bool DataChanged()
        {
            return context.ObjectStateManager.GetObjectStateEntries(EntityState.Added | EntityState.Modified | EntityState.Deleted).Any();
        }

        public void SaveChanges()
        {
            issueBindingSource.EndEdit();
            issueDetailBindingSource.EndEdit();
            try
            {
                context.SaveChanges();
            }
            catch (Exception exception)
            {
                ViewHelper.ShowErrorMessage("Error saving issue record", exception);
            }
        }

        public void DeleteObject()
        {
            try
            {
                var result = ViewHelper.ShowConfirmDialog(string.Format("Are you sure you want to delete the issue record: {0} ?", issue.IssueNo));
                if (result == DialogResult.Yes)
                {
                    context.DeleteIssue(issue.IssueId);
                    this.Close();
                }
            }
            catch (Exception exception)
            {
                ViewHelper.ShowErrorMessage("Error deleting selected Item information", exception);
            }
        }

        public bool ValidateForm()
        {
            return issue.IsValid();
        }

        public void AuthorizeForm()
        {
            // Enable/Disable Save and Post buttons based on the status of the record
            saveBarButtonItem.Enabled = (issue.IsValid() && DataChanged() && issue.IsSavable());
            postBarButtonItem.Enabled = issue.IsValid() && issue.IsSavable();
            deleteBarButtonItem.Enabled = issue.IsSavable();
            gridView1.OptionsBehavior.Editable = issue.IsSavable();
            removeItemRepositoryItemButtonEdit.Enabled = issue.IsSavable();
            saveBarButtonItem.Enabled = permissionManager.IsAuthorized(PermissionManager.INVENTORY_APPLICATION,
                                                             iph.ItemName(
                                                                 InventoryPermissionHelper.Operation.UpdateItemIssue));
            deleteBarButtonItem.Enabled = permissionManager.IsAuthorized(PermissionManager.INVENTORY_APPLICATION,
                                                             iph.ItemName(
                                                                 InventoryPermissionHelper.Operation.DeleteItemIssue));
            postBarButtonItem.Enabled = permissionManager.IsAuthorized(PermissionManager.INVENTORY_APPLICATION,
                                                             iph.ItemName(
                                                                 InventoryPermissionHelper.Operation.PostItemIssue));
        }

        private void PostIssue()
        {
            var confirm = ViewHelper.ShowConfirmDialog(@"This action is irreversible. Are you sure you want to continue?");
            if (confirm == DialogResult.No || confirm == DialogResult.Cancel)
                return;
            try
            {
                if (issue.IsValid() && issue.IsSavable())
                {
                    SaveChanges();
                    InventoryHelper.PostIssue(issue.IssueId);
                    ViewHelper.ShowSuccessMessage("Issue posted successfully");
                }
            }
            catch (Exception exception)
            {
                ViewHelper.ShowErrorMessage(exception.Message, exception.InnerException);
            }
        }

        private void IssueEdit_Activated(object sender, EventArgs e)
        {
            var p = this.MdiParent as RibbonForm;
            p.Ribbon.SelectedPage = p.Ribbon.Pages[Constants.INVENTORY_RIBBON_NAME];
        }

        private void issueBindingSource_CurrentItemChanged(object sender, EventArgs e)
        {
            AuthorizeForm();
        }

        private void issueDetailBindingSource_CurrentItemChanged(object sender, EventArgs e)
        {
            AuthorizeForm();
        }

        private void IssueEdit_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (issue.IsSavable() && issue.IsValid())
            {
                if (this.DataChanged())
                {
                    var response = MessageBox.Show(Resources.DATA_CHANGE_MESSAGE, Resources.DATA_CHANGE_TITLE,
                                                   MessageBoxButtons.YesNoCancel, MessageBoxIcon.Exclamation);

                    switch (response)
                    {
                        case DialogResult.Yes:
                            SaveChanges();
                            break;
                        case DialogResult.Cancel:
                            e.Cancel = true;
                            break;
                    }
                }
            }
        }

        private void saveBarButtonItem_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            SaveChanges();
        }

        private void deleteBarButtonItem_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            DeleteObject();
        }

        private void gridControl1_KeyDown(object sender, KeyEventArgs e)
        {
            // If the current receiving is posted then return
            if (!issue.IsSavable()) return;

            // Select the currently selected object and remove it from the underlying object collection.
            if (e.KeyCode == Keys.Delete && issueDetailBindingSource.Current != null)
            {
                RemoveDetailItem();
            }
        }

        private void postBarButtonItem_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            PostIssue();
        }

        private void removeItemRepositoryItemButtonEdit_Click(object sender, EventArgs e)
        {
            RemoveDetailItem();
        }

        private void RemoveDetailItem()
        {
            if (ViewHelper.ShowConfirmDialog("Do you want to remove the selected item") == DialogResult.Yes)
            {
                var item = issueDetailBindingSource.Current as IssueDetail;
                if (null != item)
                    issue.IssueItems.Remove(item);
            }
        }
    }
}