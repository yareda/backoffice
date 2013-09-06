using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using ClearOffice.Infrastructure;
using ClearOffice.Inventory.DataAccess;
using ClearOffice.Security;
using DevExpress.XtraEditors;

namespace ClearOffice.Inventory.Views
{
    public partial class MeasurmentView : DevExpress.XtraEditors.XtraForm,IListForm
    {
        private LookupProxy proxy = new LookupProxy();
        private PermissionManager permissionManager;
        private InventoryPermissionHelper iph;
        public MeasurmentView()
        {
            InitializeComponent();
            iph = new InventoryPermissionHelper();
            permissionManager = PermissionManager.GetPermissionManager();
            AuthorizeForm();
            ShowList(); 
        }

        public void ShowList()
        {
            measurmentbindingSource.DataSource = proxy.Context.MeasurementUnits;
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
                    ViewHelper.ShowErrorMessage("Error occured while saving the given measurment.", ex);
                }
            }
            this.Close();
        }

        

        public void AuthorizeForm()
        {
            btnSave.Enabled = permissionManager.IsAuthorized(PermissionManager.INVENTORY_APPLICATION,
                                                             iph.ItemName(
                                                                 InventoryPermissionHelper.Operation.AddMeasurement));

        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            Save();
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.Cancel;
            Close();
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