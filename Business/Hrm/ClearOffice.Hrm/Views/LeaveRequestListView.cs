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
    public partial class LeaveRequestListView : DevExpress.XtraEditors.XtraForm, IListForm
    {
        private LeaveProxy _proxy = new LeaveProxy();
        private PermissionManager permissionManager;
        private HRMPermissionHelper hph;
        public LeaveRequestListView()
        {
            InitializeComponent();
            hph = new HRMPermissionHelper();
            permissionManager = PermissionManager.GetPermissionManager();
            AuthorizeForm();
        }
        public void ShowList()
        {
            leaveRequestsBindingSource.DataSource = _proxy.Context.EmployeePtoInfoes.Where(ep => ep.Status == EmployeePto.StatusPending);
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
            var proxy = new LeaveProxy();
            leaveRequestsBindingSource.DataSource = proxy.Context.EmployeePtoInfoes.Where(ep => ep.Status == EmployeePto.StatusPending);
        }

        private void approveBarButtonItem_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            var empPtoInfo = (EmployeePtoInfo)leaveRequestsBindingSource.Current;
            if (empPtoInfo != null)
            {
                var result = ViewHelper.ShowConfirmDialog("Are you sure to approve this leave request.");
                if (result == DialogResult.Yes)
                {

                    //do the calculation and affect the transaction table.
                    try
                    {

                        LeaveCalculationHelper.ApproveLeaveRequest(empPtoInfo.EmployeeId, empPtoInfo.NumDays, Convert.ToDateTime(empPtoInfo.From));
                        var pto = _proxy.Context.EmployeePtoes.FirstOrDefault(p => p.PtoId == empPtoInfo.PtoId);
                        pto.Status = EmployeePto.StatusApproved;
                        _proxy.Save();
                        RefreshList();
                    }
                    catch (Exception exception)
                    {
                        ViewHelper.ShowErrorMessage("Error occured while calculating the leave.", exception);
                    }
                }
            }
            else
            {
                ViewHelper.ShowErrorMessage("You must first select a leave request to approve.");
            }

        }

        private void gridControl1_DoubleClick(object sender, EventArgs e)
        {
            var obj = (EmployeePtoInfo)leaveRequestsBindingSource.Current;
            if (obj != null)
            {
                var rq = _proxy.Context.EmployeePtoes.FirstOrDefault(ep => ep.PtoId == obj.PtoId);
                var rv = new LeaveRequestView();
                rv.ShowObject(rq);
                rv.ShowDialog();
            }
        }

        private void refereshBarButtonItem_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            RefreshList();
        }

        private void deleteBarButtonItem_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            var empPtoInfo = (EmployeePtoInfo)leaveRequestsBindingSource.Current;
            if (empPtoInfo != null)
            {
                var result = ViewHelper.ShowConfirmDialog("Are you sure to delete the selected leave request.");
                if(result == DialogResult.Yes)
                {
                    try
                    {
                        var obj = _proxy.Context.EmployeePtoes.FirstOrDefault(ep => ep.PtoId == empPtoInfo.PtoId);
                        _proxy.Context.EmployeePtoes.DeleteObject(obj);
                        _proxy.Save();
                        RefreshList();
                    }
                    catch (Exception exception)
                    {
                        ViewHelper.ShowErrorMessage("Error has occured while deleting the selected leave request.", exception);
                    }
                }
            }
            else
            {
                ViewHelper.ShowErrorMessage("You must first select a leave request to delete.");
            }
        }


        public void AuthorizeForm()
        {
            deleteBarButtonItem.Enabled = permissionManager.IsAuthorized(PermissionManager.HRM_APPLICATION,
                                                                         hph.ItemName(
                                                                             HRMPermissionHelper.Operation.
                                                                                 DeleteLeaveRequest));
            approveBarButtonItem.Enabled = permissionManager.IsAuthorized(PermissionManager.HRM_APPLICATION,
                                                                          hph.ItemName(
                                                                              HRMPermissionHelper.Operation.
                                                                                  ApproveLeaveRequest));

        }
    }
}