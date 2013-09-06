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
    public partial class AdjustmentEdit : DevExpress.XtraEditors.XtraForm,IDetailForm
    {
        public InventoryEntities context;
        private PermissionManager permissionManager;
        private InventoryPermissionHelper iph;
        private Adjustment adjustment;
        public AdjustmentEdit()
        {
            InitializeComponent();
            context =new InventoryEntities();
            iph = new InventoryPermissionHelper();
            permissionManager = PermissionManager.GetPermissionManager();
            
           
        }

        private void LoadLookups()
        {
            var warehouses = context.Warehouses.ToList();
            warehouseBindingSource.DataSource = warehouses;

            var statuses = context.TransactionStatus.ToList();
            transactionstatusbindingSource.DataSource = statuses;

            var items = context.ItemInfoes.ToList();
            itemBindingSource.DataSource = items.ToList();

         }

        public void ShowObject(object keyValue)
        {
            try
            {
                var info = keyValue as AdjustmentInfo;
                adjustment = context.Adjustments.Single(i => i.AdjustmentId == info.AdjustmentId);
                adjustmentBindingSource.DataSource = adjustment;
                adjustmentDetailbindingSource.DataSource = adjustment.adjustment_detail;
                LoadLookups();
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
            adjustmentBindingSource.EndEdit();
            adjustmentDetailbindingSource.EndEdit();
            
            try
            {
                context.SaveChanges();
            }
            catch (Exception exception)
            {

                ViewHelper.ShowErrorMessage("Error saving adjustment detail record", exception);
            }
        }

        public void DeleteObject()
        {
            var confirm = ViewHelper.ShowConfirmDialog(
                    string.Format("Are you sure you want to delete the selected adjustment? {0} ?",
                                  adjustment.AdjustmentNo));
            if (confirm == DialogResult.Yes)
            {
                var vhc = context.Adjustments.SingleOrDefault(vh => vh.AdjustmentId == adjustment.AdjustmentId);
                if (vhc != null)
                {
                    try
                    {
                        context.Adjustments.DeleteObject(vhc);
                        context.SaveChanges();
                        this.Close();
                    }
                    catch (Exception exception)
                    {

                        ViewHelper.ShowErrorMessage("Unable to delete the selected adjustment.", exception);
                    }

                }
            }
        }

        public bool ValidateForm()
        {
            throw new NotImplementedException();
        }

        public void AuthorizeForm()
        {
            saveBarButtonItem.Enabled = (adjustment.IsValid() && DataChanged() && adjustment.IsSavable());
            postBarButtonItem.Enabled = adjustment.IsValid() && adjustment.IsSavable();
            deleteBarButtonItem.Enabled = adjustment.IsSavable();
            gridView1.OptionsBehavior.Editable = adjustment.IsSavable();
            saveBarButtonItem.Enabled = permissionManager.IsAuthorized(PermissionManager.INVENTORY_APPLICATION,
                                                             iph.ItemName(
                                                                 InventoryPermissionHelper.Operation.UpdateAdjustment));
            deleteBarButtonItem.Enabled = permissionManager.IsAuthorized(PermissionManager.INVENTORY_APPLICATION,
                                                                         iph.ItemName(
                                                                             InventoryPermissionHelper.Operation.
                                                                                 DeleteAdjustment));
            postBarButtonItem.Enabled = permissionManager.IsAuthorized(PermissionManager.INVENTORY_APPLICATION,
                                                                       iph.ItemName(
                                                                           InventoryPermissionHelper.Operation.
                                                                               PostItemAdjustment));


        }

        private void saveBarButtonItem_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            SaveChanges();
        }

        private void postBarButtonItem_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            Postadjustment();
        }

        private void Postadjustment()
        {
            var confirm = ViewHelper.ShowConfirmDialog(@"This action is irreversible. Are you sure you want to continue?");
            if (confirm == DialogResult.No || confirm == DialogResult.Cancel)
                return;
            try
            {
                if (adjustment.IsValid() && adjustment.IsSavable())
                {
                    SaveChanges();
                    InventoryHelper.PostAdjustment(adjustment.AdjustmentId);
                    ViewHelper.ShowSuccessMessage("Adjustment posted successfully");
                }
            }
            catch (Exception exception)
            {
                ViewHelper.ShowErrorMessage(exception.Message, exception.InnerException);
            }
        }

        private void deleteBarButtonItem_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            DeleteObject();
        }

        private void repositoryItemGridLookUpEdit1_EditValueChanged(object sender, EventArgs e)
        {
            //
         }

        
    }
}