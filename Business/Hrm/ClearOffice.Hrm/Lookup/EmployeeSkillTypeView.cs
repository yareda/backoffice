using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using ClearOffice.Infrastructure;
using ClearOffice.Security;
using DevExpress.XtraEditors;
using ClearOffice.Hrm.Business;
namespace ClearOffice.Hrm.Lookup
{
    public partial class EmployeeSkillTypeView : DevExpress.XtraEditors.XtraForm,IListForm
    {
        private LookupProxy _proxy = new LookupProxy();
        private PermissionManager permissionManager;
        private HRMPermissionHelper hph;
        public EmployeeSkillTypeView()
        {
            InitializeComponent();
            hph = new HRMPermissionHelper();
            permissionManager = PermissionManager.GetPermissionManager();
            AuthorizeForm();
            ShowList();
        }

        private void btnOk_Click(object sender, EventArgs e)
        {
            if (_proxy.IsDirty())
            {
                try
                {
                    _proxy.Save();
                    this.DialogResult = DialogResult.OK;
                }
                catch (Exception ex)
                {
                    ViewHelper.ShowErrorMessage("Error occured while saving the given skill type.",ex);
                }
            }
            this.Close();
        }

        public void ShowList()
        {
            employeeSkillTypeBindingSource.DataSource = _proxy.Context.EmployeeSkillTypes;
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