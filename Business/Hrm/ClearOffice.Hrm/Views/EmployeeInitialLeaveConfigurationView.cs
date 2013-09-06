using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using ClearOffice.Hrm.Business;
using ClearOffice.Hrm.Business.Data;
using ClearOffice.Infrastructure;
using ClearOffice.Security;
using DevExpress.XtraEditors;

namespace ClearOffice.Hrm.Views
{
    public partial class EmployeeInitialLeaveConfigurationView : DevExpress.XtraEditors.XtraForm, IListForm
    {
        private LeaveProxy _proxy = new LeaveProxy();
        private List<EmployeeInfo> empList = new List<EmployeeInfo>();
        private PermissionManager permissionManager;
        private HRMPermissionHelper hph;
        public EmployeeInitialLeaveConfigurationView()
        {
            InitializeComponent();
            hph = new HRMPermissionHelper();
            permissionManager = PermissionManager.GetPermissionManager();
            AuthorizeForm();
        }

        public void ShowList()
        {
            empList = _proxy.Context.EmployeeInfoes.Where(e => e.StatusId == Employee.StatusActive).ToList();
            employeeBindingSource.DataSource = empList;
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
        private void simpleButton2_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            employeeBindingSource.EndEdit();
            try
            {
                LeaveCalculationHelper.AddInitialLeave(empList);
                ViewHelper.ShowSuccessMessage("Leave Configuration has successfully completed.");
                this.Close();
            }
            catch (ApplicationException appException)
            {
                ViewHelper.ShowErrorMessage(appException.Message);
            }
            catch (Exception exception)
            {
                ViewHelper.ShowErrorMessage("Error has occured while calculating leave.", exception);
            }
        }


        public void AuthorizeForm()
        {
            btnSave.Enabled = permissionManager.IsAuthorized(PermissionManager.HRM_APPLICATION,
                                                             hph.ItemName(
                                                                 HRMPermissionHelper.Operation.ConfigureIntialLeave));
        }
    }
}