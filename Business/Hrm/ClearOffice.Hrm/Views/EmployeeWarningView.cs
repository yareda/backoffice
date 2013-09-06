using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using ClearOffice.Hrm.Business;
using ClearOffice.Hrm.Business.Data;
using ClearOffice.Infrastructure;
using ClearOffice.Security;
using DevExpress.XtraEditors;
using System.Linq;
namespace ClearOffice.Hrm.Views
{
    public partial class EmployeeWarningView : DevExpress.XtraEditors.XtraForm,IDetailForm
    {
        private ProfileProxy _proxy = new ProfileProxy();
        private Employee _employee { get; set; }
        private PermissionManager permissionManager;
        private HRMPermissionHelper hph;
        public EmployeeWarningView()
        {
            InitializeComponent();
            hph = new HRMPermissionHelper();
            permissionManager = PermissionManager.GetPermissionManager();
            AuthorizeForm();
        }

        public void ShowObject(object keyValue)
        {
            var eid = Convert.ToInt32(keyValue);
            var emp = _proxy.Context.Employees.FirstOrDefault(e => e.EmployeeId == eid);
            if(emp!=null)
            {
                _employee = emp;
                employeeBindingSource.DataSource =
                    _proxy.Context.EmployeeInfoes.FirstOrDefault(em => em.EmployeeId == eid);
                warningTypeBindingSource.DataSource = _proxy.Context.WarningTypes.ToList();
                warningBindingSource.DataSource = new EmployeeWarning() {EmployeeId = eid};
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
                warningBindingSource.EndEdit();
                var obj = (EmployeeWarning) warningBindingSource.Current;
                if(obj!=null)
                {
                    _proxy.Context.EmployeeWarnings.AddObject(obj);
                    _proxy.Save();
                    this.Close();
                }
            }
            catch (Exception exception)
            {
                ViewHelper.ShowErrorMessage("Error occured while saving the given warning",exception);
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

        private void simpleButton1_Click(object sender, EventArgs e)
        {
            SaveChanges();
        }

        private void simpleButton2_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void warningBindingSource_CurrentItemChanged(object sender, EventArgs e)
        {
            var obj = (EmployeeWarning) warningBindingSource.Current;
            btnSave.Enabled = obj.IsValid();
        }



        public void AuthorizeForm()
        {
            btnSave.Enabled = permissionManager.IsAuthorized(PermissionManager.HRM_APPLICATION,
                                                             hph.ItemName(HRMPermissionHelper.Operation.WarnEmployee));
        }
    }
}