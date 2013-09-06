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
    public partial class InsuranceEdit : DevExpress.XtraEditors.XtraForm,IDetailForm
    {
        private readonly FleetEntities context = new FleetEntities();
        private InsurancePolicy policy;
        private bool cancelChanges;
        public InsurancePolicy Current { get; set; }
        private PermissionManager _pm;
        private FleetPermissionHelper _fph;
        public InsuranceEdit()
        {
            InitializeComponent();

            _pm = PermissionManager.GetPermissionManager();
            _fph = new FleetPermissionHelper();

            AuthorizeForm();
        }

        public void ShowObject(object keyValue)
        {
            policy = keyValue as InsurancePolicy;            
            insuranceBindingSource.DataSource = policy;
            
            var companyList = from c in context.LookupItems where c.LookupId == 12 select c;
            insuranceCompanyBindingSource.DataSource = companyList.ToList();

            var policyTypeList = from p in context.LookupItems where p.LookupId == 11 select p;
            policyTypeBindingSource.DataSource = policyTypeList.ToList();

            var vehicle = context.VehicleInfoes.First(v => v.VehicleId == policy.VehicleId);
            vehicleDetailBindingSource.DataSource = vehicle;
        }

        public bool DataChanged()
        {
            throw new NotImplementedException();
        }

        public void SaveChanges()
        {
            this.insuranceBindingSource.EndEdit();
            this.Current = policy;
            this.DialogResult = DialogResult.OK;
        }

        public void DeleteObject()
        {
            throw new NotImplementedException();
        }

        public bool ValidateForm()
        {
            if (policyNoTextBox.Text == string.Empty)
            {
                errorProvider1.SetError(policyNoTextBox, "Policy Number is required");
                return false;
            }
            return true;
        }

        private void insuranceBindingSource_CurrentItemChanged(object sender, EventArgs e)
        {
            if (policy.DateInsured!= null)
            {                                
                var expireDate = policy.DateInsured.Value.AddYears(1);
                var difference = expireDate.Subtract(DateTime.Now);
                expiresOntextBox.Text = string.Format("{0} days [{1}]", difference.Days,expireDate.Date.ToShortDateString());
            }
            this.ValidateForm();

            AuthorizeForm();
        }

        private void SaveCommand_Click(object sender, EventArgs e)
        {
            this.SaveChanges();
        }

        private void CancelCommand_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.Cancel;
        }


        public void AuthorizeForm()
        {
            SaveCommand.Enabled = _pm.IsAuthorized(PermissionManager.FLEET_APPLICATION, _fph.ItemName(
                FleetPermissionHelper.Operation.UpdateVehicleInsurance)) ||
                                  _pm.IsAuthorized(PermissionManager.FLEET_APPLICATION, _fph.ItemName(
                                      FleetPermissionHelper.Operation.AddVehicleInsurance));
        }
    }
}