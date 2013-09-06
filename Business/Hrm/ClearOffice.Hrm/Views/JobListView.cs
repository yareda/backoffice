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
using ClearOffice.Security;
using DevExpress.XtraBars.Ribbon;
using DevExpress.XtraEditors;
using ClearOffice.Infrastructure;
using DevExpress.XtraTreeList;

namespace ClearOffice.Hrm.Views
{
    public partial class JobListView : DevExpress.XtraEditors.XtraForm, IListForm
    {
        private JobProxy _proxy = new JobProxy(); 
        private PermissionManager permissionManager;
        private HRMPermissionHelper hph;
        public JobListView()
        {
            InitializeComponent();
            hph = new HRMPermissionHelper();
            permissionManager = PermissionManager.GetPermissionManager();
            AuthorizeForm();
        }

        public void ShowList()
        {
            jobListBindingSource.DataSource = _proxy.Context.JobInfoes.ToList();
            organizationBindingSource.DataSource = _proxy.Context.Organizations;
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
            _proxy = new JobProxy();
            jobListBindingSource.DataSource = _proxy.Context.JobInfoes.ToList();
        }

        private void JobListView_Activated(object sender, EventArgs e)
        {
            var p = this.MdiParent as RibbonForm;
            p.Ribbon.SelectedPage = p.Ribbon.Pages[Constants.HRM_RIBBON_NAME];
        }

        private void gridControl1_DoubleClick(object sender, EventArgs e)
        {
            var jinfo = (JobInfo)jobListBindingSource.Current;
            var data = _proxy.Context.Jobs.FirstOrDefault(j => j.JobId == jinfo.JobId);
            if (data != null)
            {
                var jv = new JobView();
                jv.ShowObject(data);
                jv.JobListView = this;
                jv.MdiParent = this.MdiParent;
                jv.Show();
            }
        }

        private void btnNewJob_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            var j = new JobView();
            j.MdiParent = this.MdiParent;
            j.ShowObject(null);
            j.Show();
        }

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

        private void profileBarButtonItem_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
         //
        }

        private void departmentsBarButtonItem_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            var nodeForm = new NodeEdit();
            nodeForm.ShowObject(null);
            var result = nodeForm.ShowDialog(this);
            if (result == DialogResult.OK)
            {
                _proxy = new JobProxy();
                ShowList();
            }
        }

        private void organizationTreeList_DoubleClick(object sender, EventArgs e)
        {
            var node = organizationBindingSource.Current as Organization;

            if (null == node) return;

            var list = from j in _proxy.Context.JobInfoes
                       where j.NodeId == node.NodeId
                       select j;

            jobListBindingSource.DataSource = list.ToList();
        }

        public void AuthorizeForm()
        {
            btnNewJob.Enabled = permissionManager.IsAuthorized(PermissionManager.HRM_APPLICATION,
                                                               hph.ItemName(HRMPermissionHelper.Operation.AddPosition));
            departmentsBarButtonItem.Enabled = permissionManager.IsAuthorized(PermissionManager.HRM_APPLICATION,
                                                                              hph.ItemName(
                                                                                  HRMPermissionHelper.Operation.
                                                                                      AddOrganizationHierarchy));

        }
    }
}