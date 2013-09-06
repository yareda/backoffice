// --------------------------------------------------------------------------------------------------------------------
// <copyright file="VehicleList.cs" company="">
//   
// </copyright>
// <summary>
//   Defines the VehicleList type.
// </summary>
// --------------------------------------------------------------------------------------------------------------------

using System.Linq;
using ClearOffice.Security;

namespace ClearOffice.Fleet.Views
{
    using System;
    using ClearOffice.Fleet.Business;
    using ClearOffice.Infrastructure;
    using System.Windows.Forms;
    using DevExpress.XtraBars.Ribbon;
    public partial class VehicleList : DevExpress.XtraEditors.XtraForm, IListForm
    {
        private FleetEntities context;
        private PermissionManager _pm;
        private FleetPermissionHelper _fph;
        public VehicleList()
        {
            InitializeComponent();
            this.gridControl1.Dock = DockStyle.Fill;

            _pm = PermissionManager.GetPermissionManager();
            _fph = new FleetPermissionHelper();
            context =new FleetEntities();

            AuthorizeForm();
        }

        public void ShowList()
        {
            LoadData();            
        }

        private void LoadData()
        {
            context = new FleetEntities();
            this.vehicleListBindingSource.DataSource = context.VehicleInfoes;
        }

        public void OpenSelectedItem()
        {
            var detailForm = new VehicleDetail();
            detailForm.MdiParent = this.MdiParent;
            detailForm.ShowObject(this.GetSelectedItem());
            detailForm.Show();

        }

        public object GetSelectedItem()
        {
            return vehicleListBindingSource.Current;
         
        }

        public void RefreshList()
        {
            this.LoadData();
        }

        private void gridControl1_DoubleClick(object sender, EventArgs e)
        {
            this.OpenSelectedItem();
        }

        private void viewDetailToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.OpenSelectedItem();
        }

        private void AddFuelLog()
        {
            var selected = (VehicleInfo)vehicleListBindingSource.Current;
            var record = new FuelLog { VehicleId = selected.VehicleId };
            var dialog = new FuelLogEdit();
            dialog.ShowObject(record);
            var result = dialog.ShowDialog();

            if (result == DialogResult.OK)
            {
                using (var ctx = new FleetEntities())
                {
                    ctx.FuelLogs.AddObject(record);
                    ctx.SaveChanges();
                }
            }
        }

        private void addFuelLogToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.AddFuelLog();
        }

        private void AddExpenseRecord()
        {
            var selected = (VehicleInfo)vehicleListBindingSource.Current;
            var record = new Expense() { VehicleId = selected.VehicleId };
            var dialog = new ExpenseEdit();
            dialog.ShowObject(record);
            var result = dialog.ShowDialog();
            if (result == DialogResult.OK)
            {
                using (var ctx = new FleetEntities())
                {
                    ctx.Expenses1.AddObject(record);
                    ctx.SaveChanges();
                }
            }
        }

        private void addExpenseToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.AddExpenseRecord();
        }

        private void AddMaintenanceRecord()
        {
            var selected = (VehicleInfo)vehicleListBindingSource.Current;
            var dialog = new MaintenanceEdit();
            dialog.ShowObject(selected);
            dialog.ShowDialog();
        }

        private void newMaintenanceToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.AddMaintenanceRecord();
        }

        private void AddNewVehicle()
        {
            var newVehicle = new NewVehicle();
            newVehicle.ShowObject(null);
            newVehicle.ShowDialog();
        }

        private void newVehicleToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.AddNewVehicle();
        }

        private void VehicleList_Activated(object sender, EventArgs e)
        {
            var p = this.MdiParent as RibbonForm;
            p.Ribbon.SelectedPage = p.Ribbon.Pages[Constants.FLEET_RIBBON_NAME];
        }

        private void refreshBarButtonItem_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            RefreshList();
        }
        

        private void newVehicleBarButtonItem_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            var dialog = new NewVehicle();
            dialog.ShowObject(null);
            var result = dialog.ShowDialog();
            if(result==DialogResult.OK)
                RefreshList();
        }


        public void AuthorizeForm()
        {
            newVehicleBarButtonItem.Enabled = _pm.IsAuthorized(PermissionManager.FLEET_APPLICATION, _fph.ItemName(
                FleetPermissionHelper.Operation.AddNewVehicle));
        }
    }
}