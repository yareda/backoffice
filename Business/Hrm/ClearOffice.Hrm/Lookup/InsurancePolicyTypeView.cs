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
    public partial class InsurancePolicyTypeView : DevExpress.XtraEditors.XtraForm ,IListForm
    {
        LookupProxy proxy =new LookupProxy();
        private PermissionManager permissionManager;
        private HRMPermissionHelper hph;
        public InsurancePolicyTypeView()
        {
            InitializeComponent();
            hph = new HRMPermissionHelper();
            permissionManager = PermissionManager.GetPermissionManager();
            AuthorizeForm();
            ShowList();
        }

        public void ShowList()
        {
            InsurancepolicybindingSource.DataSource = proxy.Context.InsurancePolicyTypes;
        }

        public void Save()
        {
            if (proxy.IsDirty())
            {
               try
                {
                    proxy.Save();

                }
                catch (Exception ex)
                {
                    ViewHelper.ShowErrorMessage("Error occured while saving the given insurance policy.", ex);
                }

            }
            Close();
        }

        private void btnOk_Click(object sender, EventArgs e)
        {
            Save();
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
            btnOk.Enabled = permissionManager.IsAuthorized(PermissionManager.HRM_APPLICATION,
                                                       hph.ItemName(HRMPermissionHelper.Operation.AddLookupItem));
        }
    }
}