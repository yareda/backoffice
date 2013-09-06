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
    public partial class NewReturn : DevExpress.XtraEditors.XtraForm,IDetailForm
    {
        private InventoryEntities context;
        private PermissionManager permissionManager;
        private InventoryPermissionHelper iph;
        private ItemReturn itemReturn;

        public int ReturnId { get; set; }

        public NewReturn()
        {
            InitializeComponent();
            context = new InventoryEntities();
            iph = new InventoryPermissionHelper();
            permissionManager = PermissionManager.GetPermissionManager();
            AuthorizeForm();
            var warehouses = context.Warehouses.ToList();
            warehouseBindingSource.DataSource = warehouses;
        }

        public void ShowObject(object keyValue)
        {
            itemReturn = new ItemReturn();
            itemReturn.ReturnNo = InventoryHelper.GetNextReturnNo();
            returnBindingSource.DataSource = itemReturn;
        }

        public bool DataChanged()
        {
            throw new NotImplementedException();
        }

        public void SaveChanges()
        {
            returnBindingSource.EndEdit();
            var newReturnNo= InventoryHelper.GetNextReturnNo();
            itemReturn.ReturnNo = newReturnNo;
            itemReturn.StatusId = InventoryHelper.STATUS_PENDING;

            try
            {
                context.ItemReturns.AddObject(itemReturn);
                context.SaveChanges();
                var obj = context.ItemReturns.Single(r => r.ReturnNo == newReturnNo);
                this.ReturnId= obj.ReturnId;
                this.DialogResult = DialogResult.OK;
                InventoryHelper.UpdateReturnNo(newReturnNo);
            }
            catch (Exception exception)
            {
                ViewHelper.ShowErrorMessage("Error saving new return record.", exception);
            }
        }

        public void DeleteObject()
        {
            throw new NotImplementedException();
        }

        public bool ValidateForm()
        {
            return itemReturn.IsValid();
        }

        public void AuthorizeForm()
        {
            saveCommand.Enabled = permissionManager.IsAuthorized(PermissionManager.INVENTORY_APPLICATION,
                                                                iph.ItemName(
                                                                    InventoryPermissionHelper.Operation.AddItemReturn));
        }

        private void returnBindingSource_CurrentItemChanged(object sender, EventArgs e)
        {
            saveCommand.Enabled = itemReturn.IsValid();
        }

        private void saveCommand_Click(object sender, EventArgs e)
        {
            SaveChanges();
        }

        private void cancelCommand_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.Cancel;
        }
    }
}