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
    public partial class TrainingAttendanceView : DevExpress.XtraEditors.XtraForm,IDetailForm
    {
        private TrainingProxy _proxy = new TrainingProxy();
        private int _trainingId;
        private HRMPermissionHelper hph;
        private PermissionManager permissionManager;
        public TrainingAttendanceView()
        {
            InitializeComponent();
            hph = new HRMPermissionHelper();
            permissionManager = PermissionManager.GetPermissionManager();
            AuthorizeForm();
        }
        public void ShowObject(object keyValue)
        {
            var tid = Convert.ToInt32(keyValue);
            _trainingId = tid;
            var ta = _proxy.Context.TrainingAttendances.Where(t => t.TrainingId == tid);
            var emps = _proxy.Context.EmployeeInfoTrainings.ToList();

            //check if the current employee has already been registerd.

            foreach (var emp in emps)
            {
                var e = (from r in ta
                        where r.EmployeeId == emp.EmployeeId
                        select r).FirstOrDefault();
                if(e!=null)
                {
                    emp.Attended = true;
                }
            }

            attendanceBindingSource.DataSource = emps;

        }

        public bool DataChanged()
        {
            throw new NotImplementedException();
        }

        public void SaveChanges()
        {
            try
            {
                var tlist = (List<EmployeeInfoTraining>) attendanceBindingSource.List;
                var ta = _proxy.Context.TrainingAttendances.Where(t => t.TrainingId == _trainingId);
                foreach (var t in tlist)
                {
                    if(t.Attended)
                    {
                        var x = (from r in ta
                                 where r.EmployeeId == t.EmployeeId
                                 select r).FirstOrDefault();
                        if (x == null)
                        {
                            var obj = new TrainingAttendance() {TrainingId = _trainingId, EmployeeId = t.EmployeeId};
                            _proxy.Context.TrainingAttendances.AddObject(obj);
                        }
                        continue;
                    }
                    else
                    {
                        var x = (from r in ta
                                 where r.EmployeeId == t.EmployeeId
                                 select r).FirstOrDefault();
                        if(x!=null)
                        {
                            _proxy.Context.TrainingAttendances.DeleteObject(x);
                        }
                        continue;
                    }
                }
                _proxy.Save();
                this.DialogResult = DialogResult.OK;
            }
            catch (Exception exception)
            {
                ViewHelper.ShowErrorMessage("Error has occured while saving attendance information.",exception);
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

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            SaveChanges();
        }

        public void AuthorizeForm()
        {
            btnSave.Enabled = permissionManager.IsAuthorized(PermissionManager.HRM_APPLICATION,
                                                             hph.ItemName(
                                                                 HRMPermissionHelper.Operation.AddTrainingAttendee));
        }
    }
}