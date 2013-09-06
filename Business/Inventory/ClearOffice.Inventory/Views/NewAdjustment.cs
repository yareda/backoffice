using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using ClearOffice.Infrastructure;
using ClearOffice.Inventory.DataAccess;
using ClearOffice.Security;
using DevExpress.XtraEditors;

namespace ClearOffice.Inventory.Views
{
    public partial class NewAdjustment : DevExpress.XtraEditors.XtraForm ,IDetailForm
       {
        private InventoryEntities context;
        private PermissionManager permissionManager;
        private InventoryPermissionHelper iph;
        private Adjustment adjustment;
        public int AdjustmentId {get; set; }
        public NewAdjustment()
        {
            InitializeComponent();
            context =new InventoryEntities();
            iph = new InventoryPermissionHelper();
            permissionManager = PermissionManager.GetPermissionManager();
            AuthorizeForm();
            
        }

        public void ShowObject(object keyValue)
        {
            adjustment = new Adjustment {AdjustmentNo = InventoryHelper.GetNextAdjustmentNo()};
            adjustmentBindingSource.DataSource = adjustment;
            Loadlookup();
        }

        private void Loadlookup()
        {
            var warehouse = context.Warehouses.ToList();
            warehouseBindingSource.DataSource = warehouse;
        }

        public bool DataChanged()
        {
            throw new NotImplementedException();
        }

        public void SaveChanges()
        {
            adjustmentBindingSource.EndEdit();
            var newadjustmentno = InventoryHelper.GetNextAdjustmentNo();
            adjustment.AdjustmentNo = newadjustmentno;
            adjustment.StatusId = InventoryHelper.STATUS_PENDING;
            try
            {
                context.Adjustments.AddObject(adjustment);
                context.SaveChanges();
                var obj = context.Adjustments.Single(a => a.AdjustmentNo == newadjustmentno);
                this.AdjustmentId = obj.AdjustmentId;
                this.DialogResult = DialogResult.OK;
                InventoryHelper.UpdateAdjustmentNo(newadjustmentno);
            }
            catch (Exception exception)
            {

                ViewHelper.ShowErrorMessage("Error saving new adjustment record.", exception);
            }
        }

        public void DeleteObject()
        {
            throw new NotImplementedException();
        }

        public bool ValidateForm()
        {
            throw new NotImplementedException();
        }

        public void AuthorizeForm()
        {
            saveCommand.Enabled = permissionManager.IsAuthorized(PermissionManager.INVENTORY_APPLICATION,
                                                              iph.ItemName(
                                                                  InventoryPermissionHelper.Operation.AddItemAdjustment));
        }

        private void saveCommand_Click(object sender, EventArgs e)
        {
            SaveChanges();
        }

        private void cancelCommand_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.Cancel;
            this.Close();
        }
       }
}