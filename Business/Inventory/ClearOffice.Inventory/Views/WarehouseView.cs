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
    public partial class WarehouseView : DevExpress.XtraEditors.XtraForm,IListForm
    {
        private LookupProxy proxy =new LookupProxy();
        private PermissionManager permissionManager;
        private InventoryPermissionHelper iph;
        public WarehouseView()
        {
            InitializeComponent();
            ShowList();
            iph = new InventoryPermissionHelper();
            permissionManager = PermissionManager.GetPermissionManager();
            AuthorizeForm();
            
        }
        public void Save()
        {
            if (proxy.IsDirty())
            {
                try
                {
                    proxy.Save();
                    this.DialogResult = DialogResult.OK;
                }
                catch (Exception ex)
                {
                    ViewHelper.ShowErrorMessage("Error occured while saving the given warehouse.", ex);
                }
            }
            this.Close();
        }
        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.Cancel;
           this.Close();
        }
        
        public void ShowList()
        {
            warehousebindingSource.DataSource = proxy.Context.Warehouses;
          
        }
        private void btnSave_Click(object sender, EventArgs e)
        {
            Save();
        }
        public void AuthorizeForm()
        {
            btnSave.Enabled = permissionManager.IsAuthorized(PermissionManager.INVENTORY_APPLICATION,
                                                             iph.ItemName(
                                                                 InventoryPermissionHelper.Operation.AddWarehouse));

        }
#region list operations
        public void OpenSelectedItem()
        {
            throw new NotImplementedException();
        }

        public object GetSelectedItem()
        {
            throw new NotImplementedException();
        }

        public void RefreshList()
        {
            throw new NotImplementedException();
        }
#endregion
    }
}