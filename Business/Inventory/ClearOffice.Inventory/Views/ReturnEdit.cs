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
    public partial class ReturnEdit : DevExpress.XtraEditors.XtraForm,IDetailForm
    {
        private InventoryEntities context;
        private ItemReturn itemReturn; 
        private PermissionManager permissionManager;
        private InventoryPermissionHelper iph;

        public ReturnEdit()
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
            warehouseBindingSource.DataSource = warehouses;

            var statuses = context.TransactionStatus.ToList();
            statusBindingSource.DataSource = statuses;

            var items = context.ItemInfoes.ToList();
            itemsBindingSource.DataSource = items.ToList();
        }

        public void ShowObject(object keyValue)
        {
            try
            {
                var info = keyValue as ReturnInfo;
                itemReturn = context.ItemReturns.Single(r => r.ReturnId== info.ReturnId);
                returnBindingSource.DataSource = itemReturn;
                returnDetailBindingSource.DataSource = itemReturn.ReturnedItems;
                this.Text = string.Format("Return: {0}", itemReturn.ReturnNo);
                AuthorizeForm();
            }
            catch (Exception exception)
            {
                ViewHelper.ShowErrorMessage("Error loading return information", exception);
            }
        }

        public bool DataChanged()
        {
            return context.ObjectStateManager.GetObjectStateEntries(EntityState.Added | EntityState.Modified | EntityState.Deleted).Any();
        }

        public void SaveChanges()
        {
            returnBindingSource.EndEdit();
            returnDetailBindingSource.EndEdit();
            try
            {
                context.SaveChanges();
            }
            catch (Exception exception)
            {
                ViewHelper.ShowErrorMessage("Error saving return record", exception);
            }
        }

        public void DeleteObject()
        {
            try
            {
                var result = ViewHelper.ShowConfirmDialog(string.Format("Are you sure you want to delete the return record: {0} ?", itemReturn.ReturnNo));
                if (result == DialogResult.Yes)
                {
                    context.DeleteReturn(itemReturn.ReturnId);
                    this.Close();
                }
            }
            catch (Exception exception)
            {
                ViewHelper.ShowErrorMessage("Error deleting selected return information", exception);
            }
        }

        public bool ValidateForm()
        {
            return itemReturn.IsValid();
        }

        public void AuthorizeForm()
        {
            // Enable/Disable Save and Post buttons based on the status of the record
            saveBarButtonItem.Enabled = (itemReturn.IsValid() && DataChanged() && itemReturn.IsSavable());
            postBarButtonItem.Enabled = itemReturn.IsValid() && itemReturn.IsSavable();
            deleteBarButtonItem.Enabled = itemReturn.IsSavable();
            gridView1.OptionsBehavior.Editable = itemReturn.IsSavable();
            deleteRepositoryItemButtonEdit.Enabled = itemReturn.IsSavable();
            saveBarButtonItem.Enabled = permissionManager.IsAuthorized(PermissionManager.INVENTORY_APPLICATION,
                                                             iph.ItemName(
                                                                 InventoryPermissionHelper.Operation.UpdateItemReturn));
            deleteBarButtonItem.Enabled = permissionManager.IsAuthorized(PermissionManager.INVENTORY_APPLICATION,
                                                                         iph.ItemName(
                                                                             InventoryPermissionHelper.Operation.
                                                                                 DeleteItemReturn));
            postBarButtonItem.Enabled = permissionManager.IsAuthorized(PermissionManager.INVENTORY_APPLICATION,
                                                                       iph.ItemName(
                                                                           InventoryPermissionHelper.Operation.
                                                                               PostItemReturn));
        }

        private void PostReturn()
        {
            var confirm = ViewHelper.ShowConfirmDialog(@"This action is irreversible. Are you sure you want to continue?");
            if (confirm == DialogResult.No || confirm == DialogResult.Cancel)
                return;
            try
            {
                if (itemReturn.IsValid() && itemReturn.IsSavable())
                {
                    SaveChanges();
                    InventoryHelper.PostReturn(itemReturn.ReturnId);
                    ViewHelper.ShowSuccessMessage("Return record posted successfully");
                }
            }
            catch (Exception exception)
            {
                ViewHelper.ShowErrorMessage(exception.Message, exception.InnerException);
            }
        }

        private void ReturnEdit_Activated(object sender, EventArgs e)
        {
            var p = this.MdiParent as RibbonForm;
            p.Ribbon.SelectedPage = p.Ribbon.Pages[Constants.INVENTORY_RIBBON_NAME];
        }

        private void returnBindingSource_CurrentItemChanged(object sender, EventArgs e)
        {
            AuthorizeForm();
        }

        private void returnDetailBindingSource_CurrentItemChanged(object sender, EventArgs e)
        {
            AuthorizeForm();
        }

        private void ReturnEdit_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (itemReturn.IsSavable() && itemReturn.IsValid())
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
            PostReturn();
        }

        private void deleteRepositoryItemButtonEdit_Click(object sender, EventArgs e)
        {
            RemoveDetailItem();
        }

        private void RemoveDetailItem()
        {
            if (ViewHelper.ShowConfirmDialog("Do you want to remove the selected item") == DialogResult.Yes)
            {
                var item = returnDetailBindingSource.Current as ReturnDetail;
                if (null != item)
                    itemReturn.ReturnedItems.Remove(item);
            }
        }
    }
}