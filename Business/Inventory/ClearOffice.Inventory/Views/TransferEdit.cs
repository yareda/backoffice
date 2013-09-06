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
    public partial class TransferEdit : DevExpress.XtraEditors.XtraForm,IDetailForm
    {
        private InventoryEntities context;
        private Transfer transfer;
        private ItemReturn itemReturn;
        private PermissionManager permissionManager;
        private InventoryPermissionHelper iph;
        public TransferEdit()
        {
            InitializeComponent();
            context = new InventoryEntities();
            iph = new InventoryPermissionHelper();
            permissionManager = PermissionManager.GetPermissionManager();            
            LoadLookups();
        }

        private void LoadLookups()
        {
            var sourceWarehouse = context.Warehouses.ToList();
            sourceBindingSource.DataSource = sourceWarehouse;
            var destinationWarehouse = context.Warehouses.ToList();
            destinationBindingSource.DataSource = destinationWarehouse;
            var statuses = context.TransactionStatus.ToList();
            statusBindingSource.DataSource = statuses;
            var items = context.ItemInfoes.ToList();
            itemsBindingSource.DataSource = items;
        }

        public void ShowObject(object keyValue)
        {
            try
            {
                var info = keyValue as TransferInfo;
                transfer = context.Transfers.Single(t => t.TransferId== info.TransferId);
                transferBindingSource.DataSource = transfer;
                transferDetailBindingSource.DataSource = transfer.TransferItems;
                this.Text = string.Format("Transfer: {0}", transfer.TransferNo);
                AuthorizeForm();
            }
            catch (Exception exception)
            {
                ViewHelper.ShowErrorMessage("Error loading stock transfer information", exception);
            }
        }

        public bool DataChanged()
        {
            return context.ObjectStateManager.GetObjectStateEntries(EntityState.Added | EntityState.Modified | EntityState.Deleted).Any();
        }

        public void SaveChanges()
        {
            transferBindingSource.EndEdit();
            transferDetailBindingSource.EndEdit();
            try
            {
                context.SaveChanges();
            }
            catch (Exception exception)
            {
                ViewHelper.ShowErrorMessage("Error saving stock transfer record", exception);
            }
        }

        public void DeleteObject()
        {
            try
            {
                var result = ViewHelper.ShowConfirmDialog(string.Format("Are you sure you want to delete the transfer record: {0} ?", transfer.TransferNo));
                if (result == DialogResult.Yes)
                {
                    context.DeleteTransfer(transfer.TransferId);
                    this.Close();
                }
            }
            catch (Exception exception)
            {
                ViewHelper.ShowErrorMessage("Error deleting selected transfer information", exception);
            }
        }

        public bool ValidateForm()
        {
            return transfer.IsValid();
        }

        public void AuthorizeForm()
        {
            saveBarButtonItem.Enabled = (transfer.IsValid() && DataChanged() && transfer.IsSavable());
            postBarButtonItem.Enabled = transfer.IsValid() && transfer.IsSavable();
            deleteBarButtonItem.Enabled = transfer.IsSavable();
            gridView1.OptionsBehavior.Editable = transfer.IsSavable();
            deleteRepositoryItemButtonEdit.Enabled = transfer.IsSavable();
            saveBarButtonItem.Enabled = permissionManager.IsAuthorized(PermissionManager.INVENTORY_APPLICATION,
                                                             iph.ItemName(
                                                                 InventoryPermissionHelper.Operation.UpdateItemTransfer));
            deleteBarButtonItem.Enabled = permissionManager.IsAuthorized(PermissionManager.INVENTORY_APPLICATION,
                                                                         iph.ItemName(
                                                                             InventoryPermissionHelper.Operation.
                                                                                 DeleteItemTransfer));
            postBarButtonItem.Enabled = permissionManager.IsAuthorized(PermissionManager.INVENTORY_APPLICATION,
                                                                       iph.ItemName(
                                                                           InventoryPermissionHelper.Operation.
                                                                               PostItemTransfer));
        }

        private void PostTransfer()
        {
            var confirm = ViewHelper.ShowConfirmDialog(@"This action is irreversible. Are you sure you want to continue?");
            if (confirm == DialogResult.No || confirm == DialogResult.Cancel)
                return;
            try
            {
                if (transfer.IsValid() && transfer.IsSavable())
                {
                    SaveChanges();
                    InventoryHelper.PostTransfer(transfer.TransferId);
                    ViewHelper.ShowSuccessMessage("Transfer record posted successfully");
                }
            }
            catch (Exception exception)
            {
                ViewHelper.ShowErrorMessage(exception.Message, exception.InnerException);
            }
        }

        private void TransferEdit_Activated(object sender, EventArgs e)
        {
            var p = this.MdiParent as RibbonForm;
            p.Ribbon.SelectedPage = p.Ribbon.Pages[Constants.INVENTORY_RIBBON_NAME];
        }

        private void transferBindingSource_CurrentItemChanged(object sender, EventArgs e)
        {
            AuthorizeForm();
        }

        private void transferDetailBindingSource_CurrentItemChanged(object sender, EventArgs e)
        {
            AuthorizeForm();
        }

        private void TransferEdit_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (transfer.IsSavable() && transfer.IsValid())
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

        private void postBarButtonItem_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            PostTransfer();
        }

        private void deleteRepositoryItemButtonEdit_Click(object sender, EventArgs e)
        {
            RemoveDetailItem();
        }

        private void RemoveDetailItem()
        {
            if (ViewHelper.ShowConfirmDialog("Do you want to remove the selected item") == DialogResult.Yes)
            {
                var item = transferDetailBindingSource.Current as TransferDetail;
                if (null != item)
                    transfer.TransferItems.Remove(item);
            }
        }
    }
}