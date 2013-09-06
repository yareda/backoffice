using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using ClearOffice.Fleet.Business;
using DevExpress.XtraEditors;
using ClearOffice.Infrastructure;

namespace ClearOffice.Fleet.Views
{
    public partial class NewTire : DevExpress.XtraEditors.XtraForm,IDetailForm
    {
        private Tire tire;
        private FleetEntities context;

        public NewTire()
        {
            InitializeComponent();
            context = new FleetEntities();            
        }

        public void ShowObject(object keyValue)
        {
            LoadLookupData();
            tire = new Tire();
            tireBindingSource.DataSource = tire;
        }

        private void LoadLookupData()
        {
            var tireBrands = context.TireBrandInfoes.ToList();
            tireBrandBindingSource.DataSource = tireBrands.ToList();

            var tireSizes = context.TireSizeInfoes.ToList();
            tireSizeBindingSource.DataSource = tireSizes.ToList();

            var tireTypes = context.TireTypeInfoes.ToList();
            tireTypeBindingSource.DataSource = tireTypes.ToList();

            var vendors = from v in context.LookupItems where v.LookupId == 13 select v;
            this.vendorBindingSource.DataSource = vendors.ToList();
        }

        public bool DataChanged()
        {
            throw new NotImplementedException();
        }

        public void SaveChanges()
        {
            this.tireBindingSource.EndEdit();
            try
            {
                // Set the status of the tire to unmounted
                tire.Status = 2;
                context.Tires.AddObject(tire);
                context.SaveChanges();
                this.DialogResult= DialogResult.OK;
            }
            catch (Exception exception)
            {
                ViewHelper.ShowErrorMessage("Error occured while adding new tire record",exception);
                throw;
            }
        }

        public void DeleteObject()
        {
            throw new NotImplementedException();
        }

        public bool ValidateForm()
        {
            return tire.IsValid();
        }

        public void AuthorizeForm()
        {            
        }

        public Tire GetCurrentObject()
        {
            return tire;
        }

        private void addCommand_Click(object sender, EventArgs e)
        {
            SaveChanges();
        }

        private void canceCommand_Click(object sender, EventArgs e)
        {
            this.DialogResult= DialogResult.Cancel;
        }
    }
}