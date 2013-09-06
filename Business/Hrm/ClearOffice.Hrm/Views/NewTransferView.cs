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
    public partial class NewTransferView : DevExpress.XtraEditors.XtraForm ,IDetailForm
    {
        private ProfileProxy _proxy =new ProfileProxy();
        public bool NewMode { get; set; }
        private PermissionManager permissionManager;
        private HRMPermissionHelper hph;
        private Employee _employee { get; set; }
        public NewTransferView()
        {
            InitializeComponent();
            hph = new HRMPermissionHelper();
            permissionManager = PermissionManager.GetPermissionManager();
            AuthorizeForm();

        }

        public void ShowObject(object keyValue)
        {
            if (NewMode)
            {
                var eid = Convert.ToInt32(keyValue);
                var empl = _proxy.Context.Employees.First(emp => emp.EmployeeId == eid);

                if (empl != null)
                {
                    _employee = empl;
                    prevJobBindingSource.DataSource = _proxy.Context.Jobs.ToList();
                    prevJobTitleLookUpEdit.EditValue = Convert.ToInt32(empl.JobId);
                    prevDepartmentBindingSource.DataSource =_proxy.Context.Organizations.ToList();
                    prevLocationLookUpEdit.EditValue = Convert.ToInt32(empl.NodeId);
                    var jobs = _proxy.Context.Jobs.ToList();
                    var depts = _proxy.Context.Organizations.ToList();
                    newJobBindingSource.DataSource = jobs;
                    newDepartmentBindingSource.DataSource = depts;
                    employeeBindingSource.DataSource =
                    _proxy.Context.EmployeeInfoes.FirstOrDefault(ep => ep.EmployeeId == eid);
                    transferBindingSource.DataSource = new EmployeeTransfer() { EmployeeId = eid,NewTitle =Convert.ToInt32(empl.JobId),NewLocation = Convert.ToInt32(empl.NodeId)};
                }
            }
            else
            {
                // TODO: For the Detail purpose.
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
                var obj = (EmployeeTransfer) transferBindingSource.Current;
                if(obj!=null)
                {
                    if(_employee!=null)
                    {
                        obj.PrevLocation = Convert.ToInt32(_employee.NodeId);
                        obj.PrevTitle = Convert.ToInt32(_employee.JobId);
                        _employee.JobId = obj.NewTitle;
                        _employee.NodeId = obj.NewLocation;
                    }
                    _proxy.Context.EmployeeTransfers.AddObject(obj);
                    _proxy.Save();
                    this.DialogResult = DialogResult.OK;
                }
            }
            catch (Exception exception)
            {
                
                ViewHelper.ShowErrorMessage("Error occured while saving the current transfer.");
                this.DialogResult = DialogResult.Cancel;
                return;
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

        private void btnTransfer_Click(object sender, EventArgs e)
        {
            SaveChanges();
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }


        public void AuthorizeForm()
        {
            btnTransfer.Enabled = permissionManager.IsAuthorized(PermissionManager.HRM_APPLICATION,
                                                                 hph.ItemName(
                                                                     HRMPermissionHelper.Operation.TransferEmployee));

        }
    }
}