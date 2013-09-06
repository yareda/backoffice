using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using ClearOffice.Hrm.Business;
using ClearOffice.Infrastructure;
using ClearOffice.Security;
using DevExpress.XtraEditors;

namespace ClearOffice.Hrm.Lookup
{
    public partial class OrganizationNodeTypeView : DevExpress.XtraEditors.XtraForm ,IListForm
    {
        LookupProxy proxy =new LookupProxy();
        private PermissionManager permissionManager;
        private HRMPermissionHelper hph;
        public OrganizationNodeTypeView()
        {
            InitializeComponent();
            hph = new HRMPermissionHelper();
            permissionManager = PermissionManager.GetPermissionManager();
            AuthorizeForm();
            ShowList();
        }

        public void ShowList()
        {
            organizationnodebindingSource.DataSource = proxy.Context.OrganizationNodeTypes;
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
                    ViewHelper.ShowErrorMessage("Error occured while saving the given organization type.", ex);
                }

            }
            Close();
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

        private void btnOk_Click(object sender, EventArgs e)
        {
            Save();
        }


        public void AuthorizeForm()
        {
            btnOk.Enabled = permissionManager.IsAuthorized(PermissionManager.HRM_APPLICATION,
                                                    hph.ItemName(HRMPermissionHelper.Operation.AddLookupItem));
        }
    }
}