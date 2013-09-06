using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using ClearOffice.Infrastructure;
using ClearOffice.Security;
using ClearOffice.Wms.Business;
using DevExpress.XtraEditors;
using ClearOffice.Wms.Business;
using System.Linq;
namespace ClearOffice.Wms.Views
{
    public partial class WorkOrderListView : DevExpress.XtraEditors.XtraForm,IListForm
    {
        private WmsEntities _context;
        private WorkOrder _selectedWorkOrder;
        private PermissionManager _pm;
        private WorkshopPermissionHelper _wph;
        public WorkOrderListView()
        {
            InitializeComponent();
            _context = new WmsEntities();
            _pm = PermissionManager.GetPermissionManager();
            _wph = new WorkshopPermissionHelper();

            AuthorizeForm();
        }
        public void ShowList()
        {
            WorkorderInfoBindingSource.DataSource = LoadAllWorkOrdersInfos();
        }

        private IEnumerable<WorkOrderInfo> LoadAllWorkOrdersInfos()
        {
            _context = new WmsEntities();
            return _context.WorkOrderInfoes.ToList();
           // return _context.WorkOrderInfoes.ToList();hn
        }

        public void OpenSelectedItem()
        {
            if (_selectedWorkOrder != null)
            {
                var wov = new WorkOrderView();
                wov.WorkOrderListView = this;
                wov.ShowObject(_selectedWorkOrder.WorkOrderId);
                wov.MdiParent = this.MdiParent;
                wov.Show();
            }
        }

        public object GetSelectedItem()
        {
            WorkOrder workorder = new WorkOrder();
            if (WorkOrderListGridView.SelectedRowsCount > 0)
            {
                var selected = (WorkOrderInfo)WorkOrderListGridView.GetRow((int)WorkOrderListGridView.GetSelectedRows().GetValue(0));
                if (null != selected)
                {
                    workorder = _context.WorkOrders.FirstOrDefault(wo => wo.WorkOrderId == selected.WorkOrderId);
                }
            }
            return workorder;
        }

        public void RefreshList()
        {
            WorkorderInfoBindingSource.DataSource = LoadAllWorkOrdersInfos();
        }

        private void gridControl1_DoubleClick(object sender, EventArgs e)
        {
            _selectedWorkOrder = (WorkOrder) GetSelectedItem();
            OpenSelectedItem();
        }

        private void btnRefresh_Click(object sender, EventArgs e)
        {
            WorkorderInfoBindingSource.DataSource = LoadAllWorkOrdersInfos();
        }

        private void BtnDelete_Click(object sender, EventArgs e)
        {
            var result = ViewHelper.ShowConfirmDialog("Are you sure you want to delete this work order?");
            if (result == DialogResult.Yes)
            {
                try
                {
                    _context.WorkOrders.DeleteObject(_selectedWorkOrder);
                    _context.SaveChanges();
                    RefreshList();
                }
                catch (Exception)
                {
                    ViewHelper.ShowDeleteError();
                    return;
                }
            }
        }



        public void AuthorizeForm()
        {
            BtnDelete.Enabled = _pm.IsAuthorized(PermissionManager.WORKSHOP_APPLICATION,
                                                     _wph.ItemName(WorkshopPermissionHelper.Operation.DeleteWorkorder));

        }
    }
}