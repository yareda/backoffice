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
    public partial class NewVehicle : DevExpress.XtraEditors.XtraForm, IDetailForm
    {
        private Vehicle vehicle;
        private FleetEntities context;
        private PermissionManager _pm;
        private FleetPermissionHelper _fph;
        public NewVehicle()
        {
            InitializeComponent();            
            context = new FleetEntities();

            _pm = PermissionManager.GetPermissionManager();
            _fph = new FleetPermissionHelper();

            AuthorizeForm();
        }

        public void ShowObject(object keyValue)
        {
            vehicle = new Vehicle();
            LoadLookupItems();
            this.vehicleBindingSource.DataSource = vehicle;            
        }

        private void LoadLookupItems()
        {
            var makeList = from m in context.LookupItems where m.LookupId == 7 select m;
            this.makeBindingSource.DataSource = makeList.ToList();

            var modelList = from model in context.LookupItems where model.LookupId == 6 select model;
            this.modelBindingSource.DataSource = modelList.ToList();

            var ownershipList = from o in context.LookupItems where o.LookupId == 8 select o;
            this.ownershipBindingSource.DataSource = ownershipList.ToList();
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
                //If we are in new mode then we need to add the new object to the context                
                context.Vehicles.AddObject(vehicle);
                //Save the changes to the database through the context
                context.SaveChanges();
                this.DialogResult = DialogResult.OK;
            }
            catch (Exception e)
            {
                this.DialogResult = DialogResult.Cancel;
                ViewHelper.ShowErrorMessage(@"Error saving vehicle information.");
                ErrorLogger.LogError(this, e);
            }
        }

        public void DeleteObject()
        {
            throw new NotImplementedException();
        }

        public bool ValidateForm()
        {
            //Check Vendor Name property
            if (plateNumberTextBox.Text == string.Empty)
            {
                errorProvider1.SetError(plateNumberTextBox, "Plate No is required");
                return false;
            }

            return true;
        }

        private void SaveCommand_Click(object sender, EventArgs e)
        {
            this.SaveChanges();
        }

        private void CancelCommand_Click(object sender, EventArgs e)
        {
            this.Close();
        }



        public void AuthorizeForm()
        {
            SaveCommand.Enabled = _pm.IsAuthorized(PermissionManager.FLEET_APPLICATION, _fph.ItemName(
                FleetPermissionHelper.Operation.AddNewVehicle));
        }
    }
}