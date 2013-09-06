using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using ClearOffice.Hrm.Business;
using ClearOffice.Infrastructure;
using ClearOffice.Security;
using DevExpress.XtraEditors;
using ClearOffice.Hrm.Business.Data;
namespace ClearOffice.Hrm.Views
{
    public partial class LeaveRequestView : DevExpress.XtraEditors.XtraForm, IDetailForm
    {
        private LeaveProxy _proxy = new LeaveProxy();
        public int EmployeeId { get; set; }
        private Employee employee;
        private PermissionManager permissionManager;
        private HRMPermissionHelper hph;
        public LeaveRequestView()
        {
            InitializeComponent();
            hph = new HRMPermissionHelper();
            permissionManager = PermissionManager.GetPermissionManager();
            AuthorizeForm();
        }

        public void ShowObject(object keyValue)
        {
            if (keyValue == null)
            {
                var eid = Convert.ToInt32(EmployeeId);
                var emp = _proxy.Context.Employees.FirstOrDefault(e => e.EmployeeId == eid);
                employee = emp;
                employeeBindingSource.DataSource = emp;
                requestBindingSource.DataSource = new EmployeePto() { EmployeeId = eid };
            }
            else
            {
                var obj = (EmployeePto)keyValue;
                requestBindingSource.DataSource = obj;
                var emp = _proxy.Context.Employees.FirstOrDefault(e => e.EmployeeId == obj.EmployeeId);
                employee = emp;
                employeeBindingSource.DataSource = emp;
            }

            if (null != employee)
                this.Text = string.Format("Leave request for : {0} {1}", employee.PersonalDetail.FirstName, employee.PersonalDetail.LastName);
        }

        public bool DataChanged()
        {
            throw new NotImplementedException();
        }

        public void SaveChanges()
        {
            try
            {
                var obj = (EmployeePto)requestBindingSource.Current;
                obj.Status = EmployeePto.StatusPending;
                _proxy.Context.EmployeePtoes.AddObject(obj);
                _proxy.Save();
                this.Close();
            }
            catch (Exception exception)
            {
                ViewHelper.ShowErrorMessage("Error occured while saving the given leave request.", exception);

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

        private void btnRequest_Click(object sender, EventArgs e)
        {
            SaveChanges();
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }


        public void AuthorizeForm()
        {
            btnRequest.Enabled = permissionManager.IsAuthorized(PermissionManager.HRM_APPLICATION,
                                                                hph.ItemName(
                                                                    HRMPermissionHelper.Operation.AddLeaveRequest));

        }

        private void requestBindingSource_CurrentItemChanged(object sender, EventArgs e)
        {
            var obj = (EmployeePto)requestBindingSource.Current;
            btnRequest.Enabled = obj.IsValid();
        }
    }
}