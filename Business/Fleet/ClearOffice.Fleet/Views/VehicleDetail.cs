using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using ClearOffice.Security;
using DevExpress.XtraBars.Ribbon;
using DevExpress.XtraEditors;
using ClearOffice.Infrastructure;
using ClearOffice.Fleet.Business;
using System.Linq;
using ClearOffice.Fleet.Properties;

namespace ClearOffice.Fleet.Views
{
    public partial class VehicleDetail : DevExpress.XtraEditors.XtraForm, IDetailForm
    {
        private FleetEntities context;
        private Vehicle vehicle;
        private bool cancelChanges;
        private PermissionManager _pm;
        private FleetPermissionHelper _fph;
        public VehicleDetail()
        {
            InitializeComponent();
            context = new FleetEntities();
            LoadLookupData();
            _pm = PermissionManager.GetPermissionManager();
            _fph = new FleetPermissionHelper();

            AuthorizeForm();
            //var margin = 10;
            //this.Top = ViewHelper.TopPositionForForm(margin);
            //this.Left = ViewHelper.TopPositionForForm(margin);
            //this.Height = ViewHelper.GetHeightForForm(margin);
            //this.Width = ViewHelper.GetWidthForForm(margin);
        }

        private void LoadLookupData()
        {
            var makeList = from m in context.LookupItems where m.LookupId == 7 select m;
            this.makeBindingSource.DataSource = makeList.ToList();

            var modelList = from model in context.LookupItems where model.LookupId == 6 select model;
            this.modelBindingSource.DataSource = modelList.ToList();

            var ownershipList = from o in context.LookupItems where o.LookupId == 8 select o;
            this.ownershipBindingSource.DataSource = ownershipList.ToList();

            var vendors = from v in context.LookupItems where v.LookupId == 13 select v;
            this.vendorBindingSource.DataSource = vendors;

            var fuelTypes = from f in context.LookupItems where f.LookupId == 2 select f;
            this.fuelTypeBindingSource.DataSource = fuelTypes.ToList();
        }

        public void ShowObject(object keyValue)
        {
            // Load main vehicle data
            var item = keyValue as VehicleInfo;
            vehicle = context.Vehicles.FirstOrDefault(v => v.VehicleId == item.VehicleId);
            vehicleBindingSource.DataSource = vehicle;
            this.Text = string.Format("Vehicle Detail for: {0}", vehicle.PlateNumber);

            // Load navigation properties for the current vehicle.
            this.fuelLogBindingSource.DataSource = vehicle.FuelLogs;
            this.expenseBindingSource.DataSource = vehicle.Expenses;
            this.insuranceHistoryBindingSource.DataSource = vehicle.InsuranceHistory;
            this.maintenanceBindingSource.DataSource = vehicle.Maintanances;
            this.tireBindingSource.DataSource = vehicle.TireUsage;
        }

        public bool DataChanged()
        {
            return context.ObjectStateManager.GetObjectStateEntries(EntityState.Added | EntityState.Modified |
                      EntityState.Deleted).Any();
        }

        public void SaveChanges()
        {
            if (!ValidateForm())
                return;

            vehicleBindingSource.EndEdit();

            try
            {
                //Save the changes to the database through the context
                context.SaveChanges();
            }
            catch (Exception e)
            {
                ViewHelper.ShowErrorMessage(@"Error saving vehicle information.");
                ErrorLogger.LogError(this, e);
            }
        }

        public void DeleteObject()
        {
            var confirm = MessageBox.Show(@"Deleting the current vehicle will remove records all associated with it. Do you want to continue?", Resources.DELETE_TITLE,
                              MessageBoxButtons.YesNoCancel, MessageBoxIcon.Warning);

            if (confirm == DialogResult.Yes)
            {
                var vhc = context.Vehicles.FirstOrDefault(vh => vh.VehicleId == vehicle.VehicleId);
                if(vhc!=null)
                {
                    try
                    {
                        context.Vehicles.DeleteObject(vhc);
                        context.SaveChanges();
                        this.Close();
                    }
                    catch (Exception exception)
                    {

                        ViewHelper.ShowErrorMessage("Unable to delete the selected vehicle.",exception);
                    }
                }
            }
        }

        public bool ValidateForm()
        {
            return true;
        }

        private void gridControl1_DoubleClick(object sender, EventArgs e)
        {
            var record = fuelLogBindingSource.Current as FuelLog;
            var dialog = new FuelLogEdit();
            dialog.ShowObject(record);
            dialog.ShowDialog();
        }

        private void AddFuelLogRecord()
        {
            var record = new FuelLog { VehicleId = this.vehicle.VehicleId };
            var dialog = new FuelLogEdit();
            dialog.ShowObject(record);
            var result = dialog.ShowDialog();
            if (result == DialogResult.OK)
            {
                this.vehicle.FuelLogs.Add(dialog.Current);
            }
        }

        private void VehicleDetail_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (!cancelChanges)
            {
                if (this.DataChanged())
                {
                    var response = MessageBox.Show(Resources.DATA_CHANGE_MESSAGE, Resources.DATA_CHANGE_TITLE,
                                                   MessageBoxButtons.YesNoCancel, MessageBoxIcon.Exclamation);

                    switch (response)
                    {
                        case DialogResult.Yes:
                            SaveChanges();
                            break;
                        case DialogResult.Cancel:
                            e.Cancel = true;
                            break;
                    }
                }
            }
        }

        private void AddExpenseRecord()
        {
            var record = new Expense() { VehicleId = this.vehicle.VehicleId };
            var dialog = new ExpenseEdit();
            dialog.ShowObject(record);
            var result = dialog.ShowDialog();
            if (result == DialogResult.OK)
            {
                this.vehicle.Expenses.Add(dialog.Current);
            }
        }

        private void gridControl2_DoubleClick(object sender, EventArgs e)
        {
            var record = expenseBindingSource.Current as Expense;
            var dialog = new ExpenseEdit();
            dialog.ShowObject(record);
            dialog.ShowDialog();
        }

        private void vehicleBindingSource_CurrentItemChanged(object sender, EventArgs e)
        {
            this.saveBarButtonItem.Enabled = this.DataChanged();

            AuthorizeForm();
        }

        private void AddInsuranceRecord()
        {
            var record = new InsurancePolicy() { VehicleId = this.vehicle.VehicleId };
            var dialog = new InsuranceEdit();
            dialog.ShowObject(record);
            var result = dialog.ShowDialog();
            if (result == DialogResult.OK)
            {
                this.vehicle.InsuranceHistory.Add(dialog.Current);
            }
        }

        private void gridControl3_DoubleClick(object sender, EventArgs e)
        {
            var record = insuranceHistoryBindingSource.Current as InsurancePolicy;
            var dialog = new InsuranceEdit();
            dialog.ShowObject(record);
            dialog.ShowDialog();
        }

        private void fuelLogBindingSource_CurrentItemChanged(object sender, EventArgs e)
        {
            this.saveBarButtonItem.Enabled = this.DataChanged();

            AuthorizeForm();
        }

        private void expenseBindingSource_CurrentItemChanged(object sender, EventArgs e)
        {
            this.saveBarButtonItem.Enabled = this.DataChanged();

            AuthorizeForm();
        }

        private void insuranceHistoryBindingSource_CurrentItemChanged(object sender, EventArgs e)
        {
            this.saveBarButtonItem.Enabled = this.DataChanged();

            AuthorizeForm();
        }

        private void AddMaintenance()
        {
            var record = new Maintanance() { VehicleId = this.vehicle.VehicleId };
            var dialog = new MaintenanceEdit();            
            var result = dialog.ShowDialog();
            //if (result == DialogResult.OK)
            //{
            //    this.vehicle.InsuranceHistory.Add(dialog.Current);
            //}
        }

        private void saveBarButtonItem_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            SaveChanges();
        }

        private void deleteBarButtonItem_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            DeleteObject();
        }

        private void addFuelLogBarButtonItem_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            AddFuelLogRecord();
        }

        private void addExpenseBarButtonItem_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            AddExpenseRecord();
        }

        private void insuranceBarButtonItem_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            AddInsuranceRecord();
        }




        public void AuthorizeForm()
        {
            saveBarButtonItem.Enabled = _pm.IsAuthorized(PermissionManager.FLEET_APPLICATION, _fph.ItemName(
                 FleetPermissionHelper.Operation.UpdateVehicle));
            deleteBarButtonItem.Enabled = _pm.IsAuthorized(PermissionManager.FLEET_APPLICATION, _fph.ItemName(
                FleetPermissionHelper.Operation.DeleteVehicle));
            addFuelLogBarButtonItem.Enabled = _pm.IsAuthorized(PermissionManager.FLEET_APPLICATION, _fph.ItemName(
                FleetPermissionHelper.Operation.AddNewFuelLog));
            addExpenseBarButtonItem.Enabled = _pm.IsAuthorized(PermissionManager.FLEET_APPLICATION, _fph.ItemName(
                FleetPermissionHelper.Operation.AddNewVehicleExpense));
            insuranceBarButtonItem.Enabled = _pm.IsAuthorized(PermissionManager.FLEET_APPLICATION, _fph.ItemName(
                FleetPermissionHelper.Operation.AddVehicleInsurance));
        }

        private void VehicleDetail_Activated(object sender, EventArgs e)
        {
            var p = this.MdiParent as RibbonForm;
            if (p != null)
            {
                p.Ribbon.SelectedPage = p.Ribbon.Pages[Constants.FLEET_RIBBON_NAME];
            }
        }
    }
}