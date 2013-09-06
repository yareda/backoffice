using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using DevExpress.XtraEditors;
using ClearOffice.Infrastructure;
using ClearOffice.Fleet.Business;

namespace ClearOffice.Fleet.Views
{
    public partial class UnMountTireView : DevExpress.XtraEditors.XtraForm, IDetailForm
    {
        public enum TireTask
        {
            Mount = 1,
            Unmount = 2
        }

        private FleetEntities context;
        private VehicleTire transaction;

        public TireTask CurrentTask { get; set; }

        public UnMountTireView()
        {
            InitializeComponent();
            context = new FleetEntities();
            LoadLookup();
        }

        private void LoadLookup()
        {
            var vehicles = context.VehicleInfoes.ToList();
            vehicleInfoBindingSource.DataSource = vehicles;
        }

        public void ShowObject(object keyValue)
        {
            transaction = keyValue as VehicleTire;

            if (null != transaction)
            {
                tireUsageBindingSource.DataSource = transaction;
            }

        }

        public bool DataChanged()
        {
            throw new NotImplementedException();
        }

        public void SaveChanges()
        {
            tireUsageBindingSource.EndEdit();
            var tireId = transaction.TireId;
            var tire = context.Tires.FirstOrDefault(t => t.TireId == tireId);

            if (this.CurrentTask == TireTask.Mount)
            {
                tire.Status = FleetHelper.TIRE_STATUS_MOUNTED;
                transaction.Status = FleetHelper.TIRE_STATUS_MOUNTED;
            }
            else if (CurrentTask == TireTask.Unmount)
            {
                tire.Status = FleetHelper.TIRE_STATUS_UNMOUNTED;
                transaction.Status = FleetHelper.TIRE_STATUS_UNMOUNTED;
            }

            try
            {
                context.SaveChanges();
            }
            catch (Exception exception)
            {
                ViewHelper.ShowErrorMessage("Error saving record", exception);
            }

        }

        public void DeleteObject()
        {
            throw new NotImplementedException();
        }

        public bool ValidateForm()
        {
            return transaction.IsValid();
        }

        public void AuthorizeForm()
        {
            throw new NotImplementedException();
        }

        private void tireUsageBindingSource_CurrentItemChanged(object sender, EventArgs e)
        {
            okCommand.Enabled = transaction.IsValid();
        }

        private void okCommand_Click(object sender, EventArgs e)
        {
            try
            {
                SaveChanges();
                this.DialogResult = DialogResult.OK;
            }
            catch (Exception exception)
            {
                ViewHelper.ShowErrorMessage("Error saving record.",exception);
            }
        }

        private void cancelCommand_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.Cancel;
        }
    }
}