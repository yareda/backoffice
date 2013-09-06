using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using ClearOffice.Infrastructure;
using ClearOffice.Security;
using ClearOffice.Wms.Business;
using DevExpress.XtraEditors;
using System.Linq;
namespace ClearOffice.Wms.Views
{
    public partial class ContractRenewView : DevExpress.XtraEditors.XtraForm,IDetailForm
    {
        private WmsEntities _context;
        private ContractRenewal _contractRenewal;
        private Contract _contract;
        private ContractDetailView _contractDetailView;
        private PermissionManager _pm;
        private WorkshopPermissionHelper _wph;
        public ContractRenewView()
        {
            InitializeComponent();
            _context = new WmsEntities();
            _pm = PermissionManager.GetPermissionManager();
            _wph = new WorkshopPermissionHelper();

            AuthorizeForm();
        }

        private void saveToolStripButton_Click(object sender, EventArgs e)
        {
            SaveChanges();
        }

        public void ShowObject(object keyValue)
        {
            _contract = (Contract) keyValue;
            RenewalBindingSource.DataSource = new ContractRenewal() { ContractId = _contract.ContractId, DateRenewed = DateTime.Today };
            LoadLookUp();
        }
        public void ShowObject(object keyValue,ContractDetailView parent)
        {
            _contract = (Contract)keyValue;
            RenewalBindingSource.DataSource = new ContractRenewal() { ContractId = _contract.ContractId, DateRenewed = DateTime.Today };
            LoadLookUp();
            _contractDetailView = parent;
        }
        private void LoadLookUp()
        {
            PaymentTypeBindingSource.DataSource = _context.LookupItems.Where(li=>li.LookupId == (int)LookupItems.PaymentTerms);
            var dt = new List<DurationType>();
            dt.Add(new DurationType(1,"month"));
            dt.Add(new DurationType(2,"year"));
            DurationTypesBindingSource.DataSource = dt;
        }

        public bool DataChanged()
        {
            return _context.ObjectStateManager.GetObjectStateEntries(EntityState.Added | EntityState.Modified |
                                 EntityState.Deleted).Any();
        }

        public void SaveChanges()
        {
            if(!ValidateForm())
                return;
            RenewalBindingSource.EndEdit();
            _contractRenewal = (ContractRenewal)RenewalBindingSource.DataSource;
            int month = 0;
            month = Convert.ToInt32(CmbDuration.SelectedValue) == 1 ? (_contractRenewal.Duration ?? 0) : (_contractRenewal.Duration * 12 ?? 0);
            _contractRenewal.Duration = month;
            _contractRenewal.Status = 1;
            var activeContract = GetActiveContract(_contract);
            activeContract.Status = 0;
            try
            {
                _context.ContractRenewals.AddObject(_contractRenewal);
                _context.SaveChanges();
                this.Close();
                _contractDetailView.ReloadRenewals();
            }
            catch (Exception ex)
            {
                ViewHelper.ShowErrorMessage("Error occured while saving the current contract renewal.", ex);
            }
        }

        private ContractRenewal GetActiveContract(Contract cont)
        {
            var ac = _context.ContractRenewals.Where(c => c.ContractId == cont.ContractId && c.Status == 1).FirstOrDefault();
            return ac;
        }

        public void DeleteObject()
        {
            throw new NotImplementedException();
        }

        public bool ValidateForm()
        {
            bool result = true;
            if (startDateDateEdit.EditValue == DBNull.Value)
            {
                RenewErrorProvider.SetError(startDateDateEdit,"Start date is required.");
                result = false;
            }
            if (durationTextBox.Text == string.Empty)
            {
                RenewErrorProvider.SetError(durationTextBox, "Duration can't be empty");
                result = false;
            }
            return result;
        }


        public void AuthorizeForm()
        {
            saveToolStripButton.Enabled = _pm.IsAuthorized(PermissionManager.WORKSHOP_APPLICATION,
                                                           _wph.ItemName(
                                                               WorkshopPermissionHelper.Operation.RenewContract));
        }
    }

}