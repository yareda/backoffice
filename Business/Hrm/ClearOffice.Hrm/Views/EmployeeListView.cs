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
using DevExpress.XtraTreeList;

namespace ClearOffice.Hrm.Views
{
    public partial class EmployeeListView : DevExpress.XtraEditors.XtraForm, IListForm
    {
        private ProfileProxy proxy = new ProfileProxy();
        private PermissionManager permissionManager;
        private HRMPermissionHelper hph;

        public EmployeeListView()
        {
            InitializeComponent();
            hph = new HRMPermissionHelper();
            permissionManager = PermissionManager.GetPermissionManager();
            AuthorizeForm();
            organizationBindingSource.DataSource = proxy.Context.Organizations.ToList();
        }

        private void newEmployeeBarButtonItem_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            NewEmployee();
        }

        private void NewEmployee()
        {
            var newemployee = new NewPersonView();
            newemployee.ShowObject(null);
            var result = newemployee.ShowDialog();
            if (result == DialogResult.OK)
                ShowList();
        }

        private void gridControl1_DoubleClick(object sender, EventArgs e)
        {
            ShowEmployeeDetail();
            AuthorizeForm();
        }

        private void ShowEmployeeDetail()
        {
            var info = (EmployeeInfo)employeeBindingSource.Current;
            var obj = proxy.Context.Employees.FirstOrDefault(ei => ei.EmployeeId == info.EmployeeId);
            if (obj != null)
            {
                var ed = new EmployeeDetailView();
                ed.ShowObject(obj.EmployeeId);
                ed.MdiParent = this.MdiParent;
                ed.Show();
            }
        }

        #region IListForm Members

        public void ShowList()
        {
            employeeBindingSource.DataSource = proxy.Context.EmployeeInfoes.Where(em => em.StatusId != Employee.StatusArchived);
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
            proxy = new ProfileProxy();
            LoadNodeEmployees();
        }

        #endregion

        private void organizationTreeList_DoubleClick(object sender, EventArgs e)
        {
            LoadNodeEmployees();
        }

        private void LoadNodeEmployees()
        {
            var node = (Organization)organizationBindingSource.Current;

            if (null != node)
            {
                employeeBindingSource.DataSource = (null == node.ParentId)
                                                       ? proxy.Context.EmployeeInfoes
                                                       : proxy.Context.EmployeeInfoes.Where(
                                                           employee => employee.NodeId == node.NodeId);
            }
        }

        private void showAllBarButtonItem_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            ShowList();
        }

        private void refreshBarButtonItem_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            RefreshList();
        }


        /// <summary>
        /// This method is used to give the TreeList view control a native TreeView control
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void organizationTreeList_CustomDrawNodeCell(object sender, DevExpress.XtraTreeList.CustomDrawNodeCellEventArgs e)
        {
            var tree = sender as TreeList;
            if (e.Node == tree.FocusedNode)
            {
                e.Graphics.FillRectangle(SystemBrushes.Window, e.Bounds);
                var rect = new Rectangle(e.EditViewInfo.ContentRect.Left, e.EditViewInfo.ContentRect.Top,
                    Convert.ToInt32(e.Graphics.MeasureString(e.CellText, organizationTreeList.Font).Width + 1),
                Convert.ToInt32(e.Graphics.MeasureString(e.CellText, organizationTreeList.Font).Height));

                e.Graphics.FillRectangle(SystemBrushes.Highlight, rect);
                e.Graphics.DrawString(e.CellText, organizationTreeList.Font, SystemBrushes.HighlightText, rect);
                e.Handled = true;
            }
        }

        private void requestLeaveBarButtonItem_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            var emp = (EmployeeInfo)employeeBindingSource.Current;
            if (emp != null)
            {
                if (emp.StatusId != Employee.StatusTerminated)
                {
                    var lr = new LeaveRequestView();
                    lr.EmployeeId = emp.EmployeeId;
                    lr.ShowObject(null);
                    lr.ShowDialog();
                }
                else
                {
                    ViewHelper.ShowErrorMessage("you can't request a leave for a terminated employee.");
                }
            }
            else
            {
                ViewHelper.ShowErrorMessage("You must first select an employee.");
            }
        }




        public void AuthorizeForm()
        {
            newEmployeeBarBarButtonItem.Enabled = permissionManager.IsAuthorized(PermissionManager.HRM_APPLICATION,
                                                                                 hph.ItemName(
                                                                                     HRMPermissionHelper.Operation.
                                                                                         AddEmployee));
            requestLeaveBarButtonItem.Enabled = permissionManager.IsAuthorized(PermissionManager.HRM_APPLICATION,
                                                                               hph.ItemName(
                                                                                   HRMPermissionHelper.Operation.
                                                                                       AddLeaveRequest));

        }
    }
}