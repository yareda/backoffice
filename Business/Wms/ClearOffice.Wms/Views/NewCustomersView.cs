using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Windows.Forms;
using ClearOffice.Infrastructure;
using ClearOffice.Security;
using ClearOffice.Wms.Business;
using DevExpress.XtraEditors;

namespace ClearOffice.Wms.Views
{
    public partial class NewCustomersView : DevExpress.XtraEditors.XtraForm, IDetailForm
    {
        private WmsEntities _context;
        private bool _newMode;
        private Customer _customer;
        private bool _saveAndNew;
        public XtraForm MainForm { get;  set; }
        private PermissionManager _pm;
        private WorkshopPermissionHelper _wph;
        public NewCustomersView()
        {
            InitializeComponent();
            _context = new WmsEntities();
            _pm = PermissionManager.GetPermissionManager();
            _wph = new WorkshopPermissionHelper();

            AuthorizeForm();
        }

        public void ShowObject(object keyValue)
        {
            _customer = new Customer();
            CustomerDataBindingSource.DataSource = _customer;
            LoadLookups();
        }

        private void LoadLookups()
        {
            customerTypeBindingSource.DataSource = GetAllCustomerTypes();
        }

        private IEnumerable<LookupItem> GetAllCustomerTypes()
        {
            int cId = Convert.ToInt32(LookupItems.CustomerType);
            return _context.LookupItems.Where(li => li.LookupId == cId);
        }

        public bool DataChanged()
        {
            return _context.ObjectStateManager.GetObjectStateEntries(EntityState.Added | EntityState.Modified |
                                             EntityState.Deleted).Any();
        }

        public void SaveChanges()
        {
            if (!ValidateForm()) 
                return;

            CustomerDataBindingSource.EndEdit();
            _customer = (Customer)CustomerDataBindingSource.DataSource;
            AddDefaultContract();
            try
            {
                _context.Customers.AddObject(_customer);
                _context.SaveChanges();
            }
            catch (Exception e)
            {
                ViewHelper.ShowSaveError();
                ErrorLogger.LogError(this, e);
            }
            if (_saveAndNew)
            {
                _customer = new Customer();
                CustomerDataBindingSource.DataSource = _customer;
                LoadLookups();
            }
            else
            {
                var cdv = new CustomerDetailView();
                cdv.ShowObject(_customer);
                cdv.MdiParent = this.MainForm;
                cdv.Show();
                this.Close();
            }
        }
        private void AddDefaultContract()
        {
            var contract = new Contract();
            contract.IsDefaultContract = 1;
            contract.ContractDate = DateTime.Today;
            _customer.Contracts.Add(contract);
        }
        public void DeleteObject()
        {
            throw new NotImplementedException();
        }

        public bool ValidateForm()
        {
            bool result = true;
            if (nameTextBox.Text == string.Empty)
            {
                errorProvider.SetError(nameTextBox, "Customer Name is required");
                result = false;
            }

            if (typeLookUpEdit.Text == string.Empty)
            {
                errorProvider.SetError(typeLookUpEdit, "Customer type is required");
                result = false;
            }
            if (result) return true;
            return false;
        }
        private void CustomerDataBindingSource_CurrentChanged(object sender, EventArgs e)
        {

        }

        private void saveToolStripButton_Click_1(object sender, EventArgs e)
        {
            _saveAndNew = false;
            SaveChanges();
        }

        private void toolStripButton1_Click(object sender, EventArgs e)
        {
            _saveAndNew = true;
            SaveChanges();
        }

        public void AuthorizeForm()
        {
            btnSaveAndNew.Enabled = _pm.IsAuthorized(PermissionManager.WORKSHOP_APPLICATION,
                                                     _wph.ItemName(
                                                         WorkshopPermissionHelper.Operation.AddCustomer));
            saveToolStripButton.Enabled = _pm.IsAuthorized(PermissionManager.WORKSHOP_APPLICATION,
                                                           _wph.ItemName(
                                                               WorkshopPermissionHelper.Operation.AddCustomer));
        }
    }
}