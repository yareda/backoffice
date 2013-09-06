using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using ClearOffice.Infrastructure;
using ClearOffice.Security;
using DevExpress.XtraEditors;
using ClearOffice.Hrm.Business;
using ClearOffice.Hrm.Business.Data;

namespace ClearOffice.Hrm.Views
{
    public partial class NodeEdit : DevExpress.XtraEditors.XtraForm, IDetailForm
    {
        private readonly JobProxy proxy;
        private Organization node;
        private HRMPermissionHelper hph;
        private PermissionManager permissionManager;
        private bool newMode;
        public NodeEdit()
        {
            InitializeComponent();
            proxy = new JobProxy();
            hph = new HRMPermissionHelper();
            permissionManager = PermissionManager.GetPermissionManager();
            AuthorizeForm();
            LoadLookups();
        }

        private void LoadLookups()
        {
            this.organizationTypeBindingSource.DataSource = proxy.Context.OrganizationNodeTypes.ToList();
            this.parentNodeBindingSource.DataSource = proxy.Context.Organizations.ToList();
        }

        private void organizationBindingSource_CurrentItemChanged(object sender, EventArgs e)
        {
            var data = organizationBindingSource.DataSource as Organization;
            saveCommand.Enabled = data.IsValid();
            AuthorizeForm();
        }

        #region IDetailForm Members

        public void ShowObject(object keyValue)
        {
            try
            {
                if (null == keyValue)
                {
                    node = new Organization();
                    this.newMode = true;
                }
                else
                {
                    var data = keyValue as Organization;
                    node = proxy.Context.Organizations.FirstOrDefault(o => o.NodeId == data.NodeId);
                }

                organizationBindingSource.DataSource = node;
            }
            catch (Exception exception)
            {
                ViewHelper.ShowErrorMessage("Error loading organizaton node information", exception);
            }
        }

        public bool DataChanged()
        {
            throw new NotImplementedException();
        }

        public void SaveChanges()
        {
            try
            {
                organizationBindingSource.EndEdit();
                if (newMode)
                    proxy.Context.Organizations.AddObject(node);
                proxy.Save();
                this.DialogResult = DialogResult.OK;
            }
            catch (Exception exception)
            {
                ViewHelper.ShowErrorMessage("Error occured while saving organizaton node.", exception);
            }
            this.Close();
          
        }

        public void DeleteObject()
        {
            throw new NotImplementedException();
        }

        public bool ValidateForm()
        {
            throw new NotImplementedException();
        }

        #endregion

        private void saveCommand_Click(object sender, EventArgs e)
        {
            SaveChanges();
        }

        private void cancelCommand_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.Cancel;
            this.Close();
        }


        public void AuthorizeForm()
        {
            saveCommand.Enabled = permissionManager.IsAuthorized(PermissionManager.HRM_APPLICATION,
                                                                 hph.ItemName(
                                                                     HRMPermissionHelper.Operation.
                                                                         AddOrganizationHierarchy));

        }
    }
}