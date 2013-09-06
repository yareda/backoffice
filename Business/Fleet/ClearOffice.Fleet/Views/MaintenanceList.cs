using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using ClearOffice.Security;
using DevExpress.XtraBars.Ribbon;
using DevExpress.XtraEditors;
using ClearOffice.Infrastructure;
using ClearOffice.Fleet.Business;

namespace ClearOffice.Fleet.Views
{
    public partial class MaintenanceList : DevExpress.XtraEditors.XtraForm, IListForm
    {
        private FleetEntities context = new FleetEntities();
        private PermissionManager _pm;
        private FleetPermissionHelper _fph;
        public MaintenanceList()
        {
            InitializeComponent();
            gridControl1.Dock = DockStyle.Fill;

            _pm = PermissionManager.GetPermissionManager();
            _fph = new FleetPermissionHelper();

            AuthorizeForm();
        }

        public void ShowList()
        {
            maintenanceListBindingSource.DataSource = context.MaintenanceInfoes;
        }

        public void OpenSelectedItem()
        {
            var selected = maintenanceListBindingSource.Current as MaintenanceInfo;
            if (null != selected)
            {
                var form = new MaintenanceEdit();
                form.MdiParent = this.MdiParent;
                form.ShowObject(selected);
                form.Show();
            }
        }

        public object GetSelectedItem()
        {
            return maintenanceListBindingSource.Current as MaintenanceInfo;
        }

        public void RefreshList()
        {
            context = new FleetEntities();
            maintenanceListBindingSource.DataSource = context.MaintenanceInfoes;
        }

        private void gridControl1_DoubleClick(object sender, EventArgs e)
        {
            this.OpenSelectedItem();
        }

        private void MaintenanceList_Activated(object sender, EventArgs e)
        {
            var p = this.MdiParent as RibbonForm;
            p.Ribbon.SelectedPage = p.Ribbon.Pages["Fleet"];
        }

        public void AuthorizeForm()
        {
            this.newMaintenanceBarButtonItem.Enabled = _pm.IsAuthorized(PermissionManager.FLEET_APPLICATION, _fph.ItemName(FleetPermissionHelper.Operation.UpdateMaintenanceRecord));
        }

        private void newMaintenanceBarButtonItem_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            var form = new NewMaintenance();
            form.ShowObject(null);
            var result = form.ShowDialog(this);
            if (result == DialogResult.OK)
            {
                this.RefreshList();
                var item = form.GetCurrentObject();
                OpenRecord(item);
            }
        }

        private void OpenRecord(Maintanance item)
        {
            var form = new MaintenanceEdit();
            var obj = context.MaintenanceInfoes.FirstOrDefault(i => i.MaintenanceId == item.MaintenanceId);
            form.MdiParent = this.MdiParent;
            form.ShowObject(obj);
            form.Show();
        }

        private void refreshListBarButtonItem_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            RefreshList();
        }
    }
}