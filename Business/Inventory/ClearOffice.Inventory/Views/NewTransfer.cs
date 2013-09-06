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
    public partial class NewTransfer : DevExpress.XtraEditors.XtraForm,IDetailForm
    {
        private InventoryEntities context;
        private Transfer transfer;
        private PermissionManager permissionManager;
        private InventoryPermissionHelper iph;
        public int TransferId { get; set; }
        
        public NewTransfer()
        {
            InitializeComponent();
            context = new InventoryEntities();
            iph = new InventoryPermissionHelper();
            permissionManager = PermissionManager.GetPermissionManager();
            AuthorizeForm();
            var sourceWarehouse = context.Warehouses.ToList();
            sourceWarehouseBindingSource.DataSource = sourceWarehouse;
            var destinationWarehouse = context.Warehouses.ToList();
            destinationWarehouseBindingSource.DataSource = destinationWarehouse;
        }

        public void ShowObject(object keyValue)
        {
            transfer = new Transfer();
            transfer.TransferNo = InventoryHelper.GetNextTransferNo();
            transferBindingSource.DataSource = transfer;
        }

        public bool DataChanged()
        {
            throw new NotImplementedException();
        }

        public void SaveChanges()
        {
            transferBindingSource.EndEdit();
            var newTransferNo = InventoryHelper.GetNextTransferNo();
            transfer.TransferNo= newTransferNo;
            transfer.StatusId = InventoryHelper.STATUS_PENDING;

            try
            {
                context.Transfers.AddObject(transfer);
                context.SaveChanges();
                var obj = context.Transfers.Single(t => t.TransferNo == newTransferNo);
                this.TransferId = obj.TransferId;
                this.DialogResult = DialogResult.OK;
                InventoryHelper.UpdateTransferNo(newTransferNo);
            }
            catch (Exception exception)
            {
                ViewHelper.ShowErrorMessage("Error saving new stock transfer record.", exception);
            }
        }

        public void DeleteObject()
        {
            throw new NotImplementedException();
        }

        public bool ValidateForm()
        {
            return transfer.IsValid();
        }

        public void AuthorizeForm()
        {
            saveCommand.Enabled = permissionManager.IsAuthorized(PermissionManager.INVENTORY_APPLICATION,
                                                               iph.ItemName(
                                                                   InventoryPermissionHelper.Operation.AddItemTransfer));
        }

        private void saveCommand_Click(object sender, EventArgs e)
        {
            SaveChanges();
        }

        private void cancelCommand_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.Cancel;
        }

        private void transferBindingSource_CurrentItemChanged(object sender, EventArgs e)
        {
            saveCommand.Enabled = transfer.IsValid();
        }
    }
}