using System;
using System.Windows.Forms;

using ClearOffice.Infrastructure;
using ClearOffice.Fleet.Business;
using System.Linq;
using ClearOffice.Security;

namespace ClearOffice.Fleet.Views
{
    public partial class ExpenseEdit : DevExpress.XtraEditors.XtraForm, IDetailForm
    {
        private Expense expense;
        private FleetEntities context = new FleetEntities();
        public Expense Current { get; private set; }
        private PermissionManager _pm;
        private FleetPermissionHelper _fph;
        public ExpenseEdit()
        {
            InitializeComponent();

            _pm = PermissionManager.GetPermissionManager();
            _fph = new FleetPermissionHelper();

            AuthorizeForm();
        }

        public void ShowObject(object keyValue)
        {
            expense = keyValue as Expense;
            expenseBindingSource.DataSource = expense;
            var vehicle = context.VehicleInfoes.First(v => v.VehicleId == expense.VehicleId);
            plateNoTextBox.Text = vehicle.PlateNumber;
            var paymentTypeList = from p in context.LookupItems where p.LookupId == 4 select p;
            paymentTypeBindingSource.DataSource = paymentTypeList.ToList();
        }

        public bool DataChanged()
        {
            throw new NotImplementedException();
        }

        public void SaveChanges()
        {
            if (!this.ValidateForm()) return;
            this.expenseBindingSource.EndEdit();
            this.Current = expense;
            this.DialogResult = DialogResult.OK;
        }

        public Expense GetCurrentObject()
        {
            return expense;
        }

        public void DeleteObject()
        {
            throw new NotImplementedException();
        }

        public bool ValidateForm()
        {
            return expense.IsValid();
        }

        private void SaveCommand_Click(object sender, EventArgs e)
        {
            this.SaveChanges();
            this.Close();
        }

        private void CancelCommand_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.Cancel;
        }

        private void expenseBindingSource_CurrentItemChanged(object sender, EventArgs e)
        {
            AuthorizeForm();
            if (SaveCommand.Enabled)
                this.SaveCommand.Enabled = expense.IsValid();
        }


        public void AuthorizeForm()
        {
            SaveCommand.Enabled = _pm.IsAuthorized(PermissionManager.FLEET_APPLICATION, _fph.ItemName(
                 FleetPermissionHelper.Operation.AddNewVehicleExpense));

        }
    }
}