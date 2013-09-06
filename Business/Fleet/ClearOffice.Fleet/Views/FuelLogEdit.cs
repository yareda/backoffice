using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using ClearOffice.Security;
using DevExpress.XtraEditors;
using ClearOffice.Infrastructure;
using ClearOffice.Fleet.Business;
using System.Linq;

namespace ClearOffice.Fleet.Views
{
    public partial class FuelLogEdit : DevExpress.XtraEditors.XtraForm, IDetailForm
    {
        private FuelLog fuelLog;
        private FleetEntities context = new FleetEntities();
        public FuelLog Current { get; private set; }
        private PermissionManager _pm;
        private FleetPermissionHelper _fph;
        public FuelLogEdit()
        {
            InitializeComponent();
            _pm = PermissionManager.GetPermissionManager();
            _fph = new FleetPermissionHelper();

            AuthorizeForm();
        }

        public void ShowObject(object keyValue)
        {
            fuelLog = keyValue as FuelLog;
            fuelLogBindingSource.DataSource = fuelLog;
            var vehicle = context.VehicleInfoes.First(v => v.VehicleId == fuelLog.VehicleId);
            plateNoTextBox.Text = vehicle.PlateNumber;
        }

        public bool DataChanged()
        {
            throw new NotImplementedException();
        }

        public void SaveChanges()
        {
            this.fuelLogBindingSource.EndEdit();
            this.Current = fuelLog;
            this.DialogResult = DialogResult.OK;
        }

        public void DeleteObject()
        {
            throw new NotImplementedException();
        }

        public bool ValidateForm()
        {
            return fuelLog.IsValid();
        }

        private void SaveCommand_Click(object sender, EventArgs e)
        {
            this.ValidateForm();
            this.SaveChanges();
            this.Close();
        }

        private void CancelCommand_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.Cancel;
        }

        private void fuelLogBindingSource_CurrentItemChanged(object sender, EventArgs e)
        {
            if (fuelLog.CurrentOdometer != null && fuelLog.LastOdometer != null)
            {
                var distance = fuelLog.CurrentOdometer.Value - fuelLog.LastOdometer.Value;
                fuelLog.DistanceCovered = Convert.ToInt32(distance);
            }

            // Check user authorization
            AuthorizeForm();

            // If the user is not authorized then it will already be disabled so we dont need to disable it
            // again. But if the button is enabled then we need to check the state of the object.
            if (SaveCommand.Enabled)
                SaveCommand.Enabled = fuelLog.IsValid();

        }


        public void AuthorizeForm()
        {
            SaveCommand.Enabled = _pm.IsAuthorized(PermissionManager.FLEET_APPLICATION, _fph.ItemName(
                FleetPermissionHelper.Operation.UpdateFuelLog)) || _pm.IsAuthorized(PermissionManager.FLEET_APPLICATION, _fph.ItemName(
                FleetPermissionHelper.Operation.AddNewFuelLog));
        }
    }
}