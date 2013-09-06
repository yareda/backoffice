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
    public partial class NewReceiving : DevExpress.XtraEditors.XtraForm,IDetailForm
    {
        private InventoryEntities context;
        private PermissionManager permissionManager;
        private InventoryPermissionHelper iph;
        private Receiving receiving;

        public int NewReceivingId { get; set; }

        public NewReceiving()
        {
            InitializeComponent();
            context = new InventoryEntities();
            iph = new InventoryPermissionHelper();
            permissionManager = PermissionManager.GetPermissionManager();
            AuthorizeForm();
            LoadLookup();
        }

        private void LoadLookup()
        {
            var suppliers = context.Suppliers.ToList();
            supplierBindingSource.DataSource = suppliers;

            var warehouses = context.Warehouses.ToList();
            warehouseBindingSource.DataSource = warehouses;
        }

        public void ShowObject(object keyValue)
        {
            receiving = new Receiving();
            receiving.GRN = InventoryHelper.GetNextGrnNo();
            receivingBindingSource.DataSource = receiving;
        }

        public bool DataChanged()
        {
            throw new NotImplementedException();
        }

        public void SaveChanges()
        {
            receivingBindingSource.EndEdit();
            var newGrn = InventoryHelper.GetNextGrnNo();
            receiving.GRN = newGrn;
            receiving.StatusId = InventoryHelper.STATUS_PENDING;

            try
            {
                context.Receivings.AddObject(receiving);
                context.SaveChanges();
                var obj = context.Receivings.Single(r => r.GRN == newGrn);
                this.NewReceivingId = obj.ReceivingId;
                this.DialogResult = DialogResult.OK;
                InventoryHelper.UpdateGRNumber(newGrn);
            }
            catch (Exception exception)
            {
                ViewHelper.ShowErrorMessage("Error saving new receiving record.",exception);                
            }
        }

        public void DeleteObject()
        {
            throw new NotImplementedException();
        }

        public bool ValidateForm()
        {
            return receiving.IsValid();
        }

        public void AuthorizeForm()
        {
            saveCommand.Enabled = permissionManager.IsAuthorized(PermissionManager.INVENTORY_APPLICATION,
                                                                iph.ItemName(
                                                                    InventoryPermissionHelper.Operation.AddItemReceiving));
        }

        private void receivingBindingSource_CurrentItemChanged(object sender, EventArgs e)
        {
            saveCommand.Enabled = receiving.IsValid();
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