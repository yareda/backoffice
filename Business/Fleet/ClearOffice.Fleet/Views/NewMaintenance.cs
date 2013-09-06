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
    public partial class NewMaintenance : DevExpress.XtraEditors.XtraForm, IDetailForm
    {
        private FleetEntities context = new FleetEntities();
        private Maintanance maintenance;
        public NewMaintenance()
        {
            InitializeComponent();
            LoadLookup();
        }

        private void LoadLookup()
        {
            vehicleBindingSource.DataSource = context.VehicleInfoes.ToList();
        }

        public void ShowObject(object keyValue)
        {
            maintenance = new Maintanance();
            maintenanceBindingSource.DataSource = maintenance;
        }

        public bool DataChanged()
        {
            throw new NotImplementedException();
        }

        public void SaveChanges()
        {
            try
            {
                maintenanceBindingSource.EndEdit();
                context.Maintanances.AddObject(maintenance);
                context.SaveChanges();
                this.DialogResult = DialogResult.OK;
                this.Close();
            }
            catch (Exception exception)
            {
                ViewHelper.ShowErrorMessage("Error occured while creating Maintenance record", exception);
            }
        }

        public Maintanance GetCurrentObject()
        {
            return maintenance;
        }
        public void DeleteObject()
        {
            throw new NotImplementedException();
        }

        public bool ValidateForm()
        {
            throw new NotImplementedException();
        }

        public void AuthorizeForm()
        {
            throw new NotImplementedException();
        }

        private void cancelCommand_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.Cancel;
        }

        private void okCommand_Click(object sender, EventArgs e)
        {
            SaveChanges();
        }
    }
}