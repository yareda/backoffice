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
    public partial class TerminationView : DevExpress.XtraEditors.XtraForm ,IDetailForm
    {
        private ProfileProxy _proxy;
        private Employee _employee { get; set; }
        private EmployeeTermination _employeeTermination;
        private HRMPermissionHelper hph;
        private PermissionManager permissionManager;

        public TerminationView()
        {
            InitializeComponent();
            _proxy = new ProfileProxy();
            hph = new HRMPermissionHelper();
            permissionManager = PermissionManager.GetPermissionManager();
            AuthorizeForm();
           
        }

        public void ShowObject(object keyValue)
        {     
            var emid = Convert.ToInt32(keyValue);
            _employeeTermination = new EmployeeTermination { EmployeeId = emid };
            employeeInfoBindingSource.DataSource =_proxy.Context.EmployeeInfoes.FirstOrDefault(ep => ep.EmployeeId == emid);
            terminationBindingSource.DataSource =_employeeTermination;
            var empl = _proxy.Context.Employees.FirstOrDefault(emp => emp.EmployeeId == emid);
            if (empl != null)
                _employee = empl;           
            
        }
        public void SaveChanges()
        {
            try
            {
                var obj = (EmployeeTermination)terminationBindingSource.Current;
                if (obj != null)
                {
                    if (_employee != null)
                    {
                        _employee.StatusId = Employee.StatusTerminated;
                     }
                    _proxy.Context.EmployeeTerminations.AddObject(obj);
                    _proxy.Save();
                    this.DialogResult = DialogResult.OK;
                }
            }
            catch (Exception exception)
            {

                ViewHelper.ShowErrorMessage("Error occured while saving the given termination.");
                this.DialogResult = DialogResult.Cancel;
                return;
            }
        }
        public bool DataChanged()
        {
            throw new NotImplementedException();
        }
        public void DeleteObject()
        {
            throw new NotImplementedException();
        }

        public bool ValidateForm()
        {
            throw new NotImplementedException();
        }

        private void btnSaveTermination_Click(object sender, EventArgs e)
        {
            SaveChanges();
        }

        private void btnCancelTermination_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void terminationBindingSource_CurrentItemChanged(object sender, EventArgs e)
        {
            var empterm = (EmployeeTermination) terminationBindingSource.Current;
            btnSaveTermination.Enabled = empterm.IsValid();
            AuthorizeForm();
        }

        public void AuthorizeForm()
        {
            btnSaveTermination.Enabled = permissionManager.IsAuthorized(PermissionManager.HRM_APPLICATION,
                                                                        hph.ItemName(
                                                                            HRMPermissionHelper.Operation.
                                                                                TerminateEmployee));

        }
    }
}