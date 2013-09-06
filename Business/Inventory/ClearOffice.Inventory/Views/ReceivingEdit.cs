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
    public partial class ReceivingEdit : DevExpress.XtraEditors.XtraForm, IDetailForm
    {
        private InventoryEntities context;
        private Receiving receiving;
        private PermissionManager permissionManager;
        private InventoryPermissionHelper iph;

        public ReceivingEdit()
        {
            InitializeComponent();
            context = new InventoryEntities();
            iph = new InventoryPermissionHelper();
            permissionManager = PermissionManager.GetPermissionManager();
            LoadLookups();
        }

        private void LoadLookups()
        {
            var suppliers = context.Suppliers.ToList();
            supplierBindingSource.DataSource = suppliers;

            var warehouses = context.Warehouses.ToList();
            warehouseBindingSource.DataSource = warehouses;

            var statuses = context.TransactionStatus.ToList();
            statusBindingSource.DataSource = statuses;

            var items = context.ItemInfoes.ToList();
            itemsLookupBindingSource.DataSource = items;
        }

        public void ShowObject(object keyValue)
        {
            try
            {
                var info = keyValue as ReceivingInfo;
                receiving = context.Receivings.Single(r => r.ReceivingId == info.ReceivingId);
                receivingBindingSource.DataSource = receiving;
                receivingDetailBindingSource.DataSource = receiving.ReceivingItems;
                this.Text = string.Format("Receiving: {0}", receiving.GRN);
                AuthorizeForm();
            }
            catch (Exception exception)
            {
                ViewHelper.ShowErrorMessage("Error loading receiving", exception);
            }
        }

        public bool DataChanged()
        {
            return context.ObjectStateManager.GetObjectStateEntries(EntityState.Added | EntityState.Modified | EntityState.Deleted).Any();
        }

        public void SaveChanges()
        {
            receivingBindingSource.EndEdit();
            receivingDetailBindingSource.EndEdit();
            try
            {
                context.SaveChanges();
            }
            catch (Exception exception)
            {
                ViewHelper.ShowErrorMessage("Error saving receiving record.", exception);
            }
        }

        public void DeleteObject()
        {
            try
            {
                var result = ViewHelper.ShowConfirmDialog(string.Format("Are you sure you want to delete the receiving record: {0} ?", receiving.GRN));
                if (result == DialogResult.Yes)
                {
                    context.DeleteReceiving(receiving.ReceivingId);
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
            return receiving.IsValid();
        }

        public void AuthorizeForm()
        {
            // Enable/Disable Save and Post buttons based on the status of the record
            saveBarButtonItem.Enabled = (receiving.IsValid() && DataChanged() && receiving.IsSavable());
            postBarButtonItem.Enabled = receiving.IsValid() && receiving.IsSavable();
            deleteBarButtonItem.Enabled = receiving.IsSavable();
            gridView1.OptionsBehavior.Editable = receiving.IsSavable();
            deleteItemRepositoryItemButtonEdit.Enabled = receiving.IsSavable();
            saveBarButtonItem.Enabled = permissionManager.IsAuthorized(PermissionManager.INVENTORY_APPLICATION,
                                                             iph.ItemName(
                                                                 InventoryPermissionHelper.Operation.UpdateItemReceiving));
            deleteBarButtonItem.Enabled = permissionManager.IsAuthorized(PermissionManager.INVENTORY_APPLICATION,
                                                                         iph.ItemName(
                                                                             InventoryPermissionHelper.Operation.
                                                                                 DeleteItemRecieving));
            postBarButtonItem.Enabled = permissionManager.IsAuthorized(PermissionManager.INVENTORY_APPLICATION,
                                                                       iph.ItemName(
                                                                           InventoryPermissionHelper.Operation.
                                                                               PostItemReceiving));
        }

        private void ReceivingEdit_Activated(object sender, EventArgs e)
        {
            var p = this.MdiParent as RibbonForm;
            p.Ribbon.SelectedPage = p.Ribbon.Pages[Constants.INVENTORY_RIBBON_NAME];
        }

        private void receivingBindingSource_CurrentItemChanged(object sender, EventArgs e)
        {
            AuthorizeForm();
        }

        private void receivingDetailBindingSource_CurrentItemChanged(object sender, EventArgs e)
        {
            AuthorizeForm();
        }

        private void postBarButtonItem_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            PostReceiving();
        }

        private void PostReceiving()
        {
            var confirm = ViewHelper.ShowConfirmDialog(@"This action is irreversible. Are you sure you want to continue?");
            if (confirm == DialogResult.No || confirm == DialogResult.Cancel)
                return;
            try
            {
                if (receiving.IsValid() && receiving.IsSavable())
                {
                    SaveChanges();
                    InventoryHelper.PostReceiving(receiving.ReceivingId);
                    ViewHelper.ShowSuccessMessage("Receiving posted successfully");
                }
            }
            catch (Exception exception)
            {
                ViewHelper.ShowErrorMessage(exception.Message, exception.InnerException);
            }
        }

        private void saveBarButtonItem_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            SaveChanges();
        }

        private void ReceivingEdit_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (receiving.IsSavable() && receiving.IsValid())
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

        private void deleteBarButtonItem_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            DeleteObject();
        }

        private void gridControl1_KeyDown(object sender, KeyEventArgs e)
        {
            // If the current receiving is posted then return
            if (!receiving.IsSavable()) return;

            // Select the currently selected object and remove it from the underlying object collection.
            if (e.KeyCode == Keys.Delete && receivingDetailBindingSource.Current != null)
            {
                DeleteItemDetail();
            }
        }

        private void DeleteItemDetail()
        {
            if (ViewHelper.ShowConfirmDialog("Do you want to remove the selected item") == DialogResult.Yes)
            {
                var item = receivingDetailBindingSource.Current as ReceivingDetail;
                if (null != item)
                    receiving.ReceivingItems.Remove(item);
            }
        }

        private void deleteItemRepositoryItemButtonEdit_Click(object sender, EventArgs e)
        {
            DeleteItemDetail();
        }
    }
}