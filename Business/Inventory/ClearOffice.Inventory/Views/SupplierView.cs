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
    public partial class SupplierView : DevExpress.XtraEditors.XtraForm,IListForm
    {
        private LookupProxy proxy =new LookupProxy();
        private PermissionManager permissionManager;
        private InventoryPermissionHelper iph;
        public SupplierView()
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
                    ViewHelper.ShowErrorMessage("Error occured while saving the given supplier.", ex);
                }
            }
            this.Close();
        }
        public void ShowList()
        {
            supplierbindingSource.DataSource = proxy.Context.Suppliers;
        }

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

        public void AuthorizeForm()
        {
            btnSave.Enabled = permissionManager.IsAuthorized(PermissionManager.INVENTORY_APPLICATION,
                                                               iph.ItemName(
                                                                   InventoryPermissionHelper.Operation.AddSupplier));
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            Save();
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.Cancel;
            this.Close();
        }
    }
}