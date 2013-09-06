using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using ClearOffice.Security;
using ClearOffice.Wms.Business;
using DevExpress.XtraEditors;
using ClearOffice.Infrastructure;
namespace ClearOffice.Wms.Views
{
    public partial class NewContractView : DevExpress.XtraEditors.XtraForm,IDetailForm 
    {
        private WmsEntities _context;
        private bool _newMode;
        private bool _saveAndNew = false;
        public Customer Customer { get; set; }
        public CustomerDetailView CustomerView { get; set; }
        private Contract _contract { get; set; }
        public XtraForm MainParent { get; set; }
        private PermissionManager _pm;
        private WorkshopPermissionHelper _wph;
        public NewContractView()
        {
            InitializeComponent();
            _context = new WmsEntities();
            _pm = PermissionManager.GetPermissionManager();
            _wph = new WorkshopPermissionHelper();

            AuthorizeForm();
        }
        /// <summary>
        /// Prepare new contract view.
        /// Bind new contract and new renewal binding sources.
        /// </summary>
        /// <param name="keyValue"></param>
        public void ShowObject(object keyValue)
        {
            if (keyValue == null) _newMode = true; else _newMode = false;
            if (_newMode)
            {
                if (this.CustomerView == null)
                {
                    _contract = new Contract();
                    ContractBindingSource.DataSource = _contract;
                    RenewalBindingSource.DataSource = new ContractRenewal();
                    LoadLookups();
                }
                else
                {
                    _contract = new Contract(){CustomerId = this.Customer.CustomerId};
                    ContractBindingSource.DataSource = _contract;
                    RenewalBindingSource.DataSource = new ContractRenewal();
                    customerIdGridLookUpEdit.Visible = false;
                    customerIdLabel.Visible = false;
                    LoadLookups();
                }
            }
        }

        private void LoadLookups()
        {
            PaymentTermsBindingSource.DataSource = GetAllPaymentTerms();
            CustomerListBindingSource.DataSource = GetAllCustomers();
            ContractTypeBindingSource.DataSource = GetAllContractTypes();
            LoadDurationType();
        }

        private void LoadDurationType()
        {
            var dt = new List<DurationType>();
            dt.Add(new DurationType(1, "Month"));
            dt.Add(new DurationType(2, "Year"));
            DurationBindingSource.DataSource = dt;
            CmboDuration.SelectedValue = 1;
        }

        private IEnumerable<LookupItem> GetAllContractTypes()
        {
            int itemId = Convert.ToInt32(LookupItems.ContractType);
            return _context.LookupItems.Where(li => li.LookupId == itemId );
        }

        private IEnumerable<CustomerInfo> GetAllCustomers()
        {
            return this._context.CustomerInfoes.ToList();
        }

        private IEnumerable<LookupItem> GetAllPaymentTerms()
        {
            int itemId = Convert.ToInt32(LookupItems.PaymentTerms);
            return _context.LookupItems.Where(li => li.LookupId == itemId);
        }

        public bool DataChanged()
        {
            return _context.ObjectStateManager.GetObjectStateEntries(EntityState.Added | EntityState.Modified |
                                             EntityState.Deleted).Any();
        }

        public void SaveChanges()
        {
            if(!ValidateForm()) return;
            ContractBindingSource.EndEdit();
            RenewalBindingSource.EndEdit();
            _contract = (Contract)ContractBindingSource.DataSource;
            var renewal = (ContractRenewal)RenewalBindingSource.DataSource;
            int month = 0;
            month = Convert.ToInt32(CmboDuration.SelectedValue) == 1 ? (renewal.Duration ?? 0) : (renewal.Duration * 12 ?? 0);
            renewal.Duration = month;
            renewal.Status = 1;
            _contract.Status = 1;
            try
            {
                 InsertRenewal(renewal);
                 _context.Contracts.AddObject(_contract);
                 _context.SaveChanges();
                 if (CustomerView == null)
                 {
                     if (_saveAndNew)
                     {
                         ContractBindingSource.DataSource = new Contract();
                         RenewalBindingSource.DataSource = new ContractRenewal();
                     }
                     else
                     {
                         this.Close();
                         var ct = new ContractDetailView();
                         var contractDetailView = new ContractDetailView();
                         contractDetailView.ShowObject(_contract);
                         contractDetailView.MdiParent = this.MainParent;
                         contractDetailView.Show();
                     }
                 }
                 else
                 {
                     this.Close();
                     CustomerView.ReloadContracts();
                 }

            }
            catch (Exception e)
            {

                ViewHelper.ShowSaveError();
                ErrorLogger.LogError(this, e);
            }
            
        }

        private void InsertRenewal(ContractRenewal renewal)
        {
            _contract.ContractRenewal.Add(renewal);
        }

        public void DeleteObject()
        {
            throw new NotImplementedException();
        }

        public bool ValidateForm()
        {
            bool result = true;
            if (contractNoTextBox.Text == string.Empty)
            {
                NewContractErrorProvider.SetError(contractNoTextBox,"Contract number is required.");
                result = false;
            }
            if (contractTypeLookUpEdit.EditValue == DBNull.Value)
            {
                NewContractErrorProvider.SetError(contractTypeLookUpEdit, "Contract type is required.");
                result = false;
            }
            if (customerIdGridLookUpEdit.Visible == true && customerIdGridLookUpEdit.EditValue == DBNull.Value)
            {
                NewContractErrorProvider.SetError(customerIdGridLookUpEdit, "Customer is required.");
                result = false;
            }
            if (result) return true;
            return false;
        }

        private void BtnSave_Click(object sender, EventArgs e)
        {
            this._saveAndNew = false;
            SaveChanges();
        }

        private void BtnSaveNew_Click(object sender, EventArgs e)
        {
            this._saveAndNew = true;
            SaveChanges();
        }


        public void AuthorizeForm()
        {
            BtnSave.Enabled = _pm.IsAuthorized(PermissionManager.WORKSHOP_APPLICATION,
                                               _wph.ItemName(WorkshopPermissionHelper.Operation.AddContract));
            BtnSaveNew.Enabled = _pm.IsAuthorized(PermissionManager.WORKSHOP_APPLICATION,
                                                  _wph.ItemName(WorkshopPermissionHelper.Operation.AddNewMicelaneousItem));
        }
    }

    public class DurationType
    {
        public int Value { get; set; }
        public string Name { get; set; }
        public DurationType(int v,string n)
        {
            this.Value = v;
            this.Name = n;
        }
    }
}