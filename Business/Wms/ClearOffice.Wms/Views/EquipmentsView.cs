using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using ClearOffice.Security;
using ClearOffice.Wms.Business;
using DevExpress.XtraEditors;
using ClearOffice.Infrastructure;
using System.Linq;

namespace ClearOffice.Wms.Views
{
    public partial class EquipmentsView : DevExpress.XtraEditors.XtraForm, IListForm
    {
        private WmsEntities _context;
        private bool _listShown = false;
        private Equipment _selectEquipment;
        private PermissionManager _pm;
        private WorkshopPermissionHelper _wph;
        public EquipmentsView()
        {
            InitializeComponent();
            _context = new WmsEntities();
            ShowList();
            _listShown = true;
            _pm = PermissionManager.GetPermissionManager();
            _wph = new WorkshopPermissionHelper();

            AuthorizeForm();
        }
        public void ShowList()
        {
            if (!_listShown)
            {
                var equipments = _context.EquipmentListInfoes.ToList();
                equipmentsBindingSource.DataSource = equipments;
            }
        }

        public void OpenSelectedItem()
        {
            throw new NotImplementedException();
        }

        public object GetSelectedItem()
        {
            if (equipmentsGridView.SelectedRowsCount > 0)
            {
                var selected = (EquipmentListInfo)equipmentsGridView.GetRow((int)equipmentsGridView.GetSelectedRows().GetValue(0));
                if (null != selected)
                {
                    _selectEquipment = _context.Equipments.FirstOrDefault(eq => eq.EquipmentId == selected.EquipmentId);
                }
            }
            return _selectEquipment;
        }

        public void RefreshList()
        {
            var equipments = _context.EquipmentListInfoes.ToList();
            equipmentsBindingSource.DataSource = equipments;
        }

        private void gridControl1_DoubleClick(object sender, EventArgs e)
        {
            var selected = GetSelectedItem() as Equipment;
            var editor = new EquipmentDetail();
            editor.ShowObject(selected.EquipmentId);
            editor.MdiParent = this.MdiParent;
            editor.Show();
        }

        private void gridControl1_Click(object sender, EventArgs e)
        {
            if (equipmentsGridView.SelectedRowsCount > 0)
            {
                var selected = (EquipmentListInfo)equipmentsGridView.GetRow((int)equipmentsGridView.GetSelectedRows().GetValue(0));
                if (null != selected)
                {
                    _selectEquipment = _context.Equipments.FirstOrDefault(eq => eq.EquipmentId == selected.EquipmentId);
                    BtnDelete.Enabled = true;
                    //BtnIssueWorkorder.Enabled = true;
                    BtnRefresh.Enabled = true;
                }
            }
            AuthorizeForm();
        }

        private void BtnRefresh_Click(object sender, EventArgs e)
        {
            var equipments = _context.EquipmentListInfoes.ToList();
            equipmentsBindingSource.DataSource = equipments;
        }


        public void OpenSelected()
        {
            throw new NotImplementedException();
        }




        private void BtnIssueWorkorder_Click(object sender, EventArgs e)
        {
            if (_selectEquipment != null)
            {
                var wov = new WorkOrderView();
                wov.Equipment = _selectEquipment;
                wov.ShowObject(null);
                wov.MdiParent = this.MdiParent;
                wov.Show();
            }
        }

        private void BtnDelete_Click(object sender, EventArgs ev)
        {
            DialogResult result = ViewHelper.ShowConfirmDialog("Are you sure you want to delete this equipment.");
            if (result == DialogResult.Yes)
            {
                _context = new WmsEntities();
                var eq = _context.Equipments.FirstOrDefault(e => e.EquipmentId == _selectEquipment.EquipmentId);
                _context.DeleteObject(eq);
                _context.SaveChanges();
                RefreshList();
            }
        }



        public void AuthorizeForm()
        {
            BtnDelete.Enabled = _pm.IsAuthorized(PermissionManager.WORKSHOP_APPLICATION,
                                                 _wph.ItemName(WorkshopPermissionHelper.Operation.DeleteEquipment));
        }
    }
}