using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using ClearOffice.Infrastructure;
using ClearOffice.Wms.Business;
using DevExpress.XtraEditors;
using ClearOffice.Security;

namespace ClearOffice.Wms.Views
{
    public partial class CustomerDetailView : DevExpress.XtraEditors.XtraForm, IDetailForm
    {
        private WmsEntities _context;
        private Customer _customer;
        private bool newMode;
        private bool cancelChanges;
        private Contract _selectedContract;
        private Equipment _selectedEquipment;

        private WorkshopPermissionHelper _wph;
        private PermissionManager _pm;

        
        public CustomerDetailView()
        {
            InitializeComponent();
            _context = new WmsEntities();
            _wph = new WorkshopPermissionHelper();
            _pm = PermissionManager.GetPermissionManager();

            AuthorizeForm();
        }

        public void ShowObject(object keyValue)
        {
            if (keyValue == null) newMode = true;

            if (newMode)
            {
                _customer = new Customer();
                this.Text = @"Customer";
            }
            else
            {
                _customer = (Customer)keyValue;
                CustomerDataBindingSource.DataSource = _context.Customers.First(c => c.CustomerId == _customer.CustomerId);
                ContractRenewalListBindingSource.DataSource =
                    _context.ContractRenewalInfoes.Where(ct => ct.CustomerId == _customer.CustomerId);
                EquipmentListBindingSource.DataSource =
                    _context.EquipmentListInfoes.Where(el => el.CustomerId == _customer.CustomerId);
                LoadLookup();
            }
               
        }
        
        private void LoadLookup()
        {
            CustomerTypeBindingSource.DataSource = GetAllCustomerTypes();
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
            if (!ValidateForm()) return;
            CustomerDataBindingSource.EndEdit();
            try
            {
               
                if (newMode)
                    _context.Customers.AddObject(_customer);
                _context.SaveChanges();
                btnSave.Enabled = false;
            }
            catch (Exception ex)
            {
                ViewHelper.ShowErrorMessage("Error occured while saving the current customer.", ex);
                ErrorLogger.LogError(this, ex);
            }
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

        private void saveToolStripButton_Click(object sender, EventArgs e)
        {
            SaveChanges();
        }

        private void CustomerDetailView_FormClosed(object sender, FormClosedEventArgs e)
        {
            if (!cancelChanges)
            {
                if (DataChanged())
                {
                    var response = ViewHelper.ShowConfirmDialog("You haven't saved changes.Do You want to save changes?");
                    switch (response)
                    {
                        case DialogResult.Yes:
                            SaveChanges();
                            break;
                        case DialogResult.No:
                            break;
                        case DialogResult.Cancel:
                           break;
                    }
                }
            }
        }

        private void newToolStripButton_Click(object sender, EventArgs e)
        {
            var nct = new NewContractView();
            nct.CustomerView = this;
            nct.Customer = _customer;
            nct.ShowObject(null);
            nct.ShowDialog();
        }

        internal void ReloadContracts()
        {
            ContractRenewalListBindingSource.DataSource =
                _context.ContractRenewalInfoes.Where(cd => cd.CustomerId == _customer.CustomerId);
        }

        private void gridControl1_Click(object sender, EventArgs e)
        {
            var ctrnewal = (ContractRenewalInfo) ContractRenewalListBindingSource.Current;
            if(ctrnewal!=null)
            _selectedContract = _context.Contracts.FirstOrDefault(ct => ct.ContractId == ctrnewal.ContractId);
            btnDeleteContract.Enabled = true;

            AuthorizeForm();
        }

        private void gridControl1_DoubleClick(object sender, EventArgs e)
        {
            var ctrnewal = (ContractRenewalInfo)ContractRenewalListBindingSource.Current;
            if(null==ctrnewal) return;
            _selectedContract = _context.Contracts.FirstOrDefault(ct => ct.ContractId == ctrnewal.ContractId);

            var ctdev = new ContractDetailView();
            ctdev.MdiParent = this.MdiParent;
            ctdev.ShowObject(_selectedContract);
            ctdev.Show();

            AuthorizeForm();
        }

        private void btnDeleteContract_Click(object sender, EventArgs e)
        {
            var result = ViewHelper.ShowConfirmDialog("Are you sure you want to delete this contract?");
            if (result == DialogResult.Yes)
            {
                try
                {
                    _context.Contracts.DeleteObject(_selectedContract);
                    _context.SaveChanges();
                    ReloadContracts();
                }
                catch (Exception)
                {
                    ViewHelper.ShowDeleteError();
                    return;
                }
            }
        }

        private void newToolStripButton2_Click(object sender, EventArgs e)
        {
            var equipment = new Equipment() {ContractId = GetDefaultContract(_customer).ContractId};
           
                var nev = new NewEquipment();
                nev.CustomerView = this;
                //nev.SetCustomer(_customer);
                nev.MainParent = this.MdiParent;
                nev.ShowObject(equipment);
                nev.ShowDialog();
            
        }
        private Contract GetDefaultContract(Customer cid)
        {
            return _context.Contracts.FirstOrDefault(ct => ct.CustomerId == cid.CustomerId && ct.IsDefaultContract == 1);
        }
        internal void ReloadEquipments()
        {
            EquipmentListBindingSource.DataSource =
                _context.EquipmentListInfoes.Where(e => e.CustomerId == _customer.CustomerId);
        }

        private void btnRefresh_Click(object sender, EventArgs e)
        {
            ReloadEquipments();
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            var result = ViewHelper.ShowConfirmDialog("Are you sure you want to delete this equipment?");
            if (result == DialogResult.Yes)
            {
                _context.Equipments.DeleteObject(_selectedEquipment);
                try
                {
                    _context.SaveChanges();
                    ReloadEquipments();
                }
                catch (Exception)
                {
                    ViewHelper.ShowDeleteError();
                }
            }
        }

        private void gridControl2_Click(object sender, EventArgs e)
        {
            var einfo = (EquipmentListInfo) EquipmentListBindingSource.Current;
            if (einfo != null)
            {
                _selectedEquipment = _context.Equipments.FirstOrDefault(eq => eq.EquipmentId == einfo.EquipmentId);
                btnDeleteEqu.Enabled = true;
                btnIssueWorkorder.Enabled = true;
            }
            AuthorizeForm();
        }

        private void gridControl2_DoubleClick(object sender, EventArgs e)
        {
            var einfo = (EquipmentListInfo)EquipmentListBindingSource.Current;
            if (null == einfo) return;
            _selectedEquipment = _context.Equipments.FirstOrDefault(eq => eq.EquipmentId == einfo.EquipmentId);

            var editor = new EquipmentDetail();
            editor.ShowObject(_selectedEquipment.EquipmentId);
            editor.MdiParent = this.MdiParent;
            editor.Show();

            AuthorizeForm();
        }
        public object GetSelectedEquipment()
        {
            return _selectedEquipment;
        }

        private void toolStripButton2_Click(object sender, EventArgs e)
        {
            var wo = new WorkOrderView();
            wo.Equipment = _selectedEquipment;
            wo.ShowObject(null);
            wo.MdiParent = this.MdiParent;
            wo.Show();
        }

        private void toolStripButton1_Click(object sender, EventArgs e)
        {
            ContractRenewalListBindingSource.DataSource =
               _context.ContractRenewalInfoes.Where(cd => cd.CustomerId == _customer.CustomerId);
        }

        private void CustomerDataBindingSource_CurrentItemChanged(object sender, EventArgs e)
        {
            btnSave.Enabled = DataChanged();

            AuthorizeForm();
        }


        public void AuthorizeForm()
        {
            btnSave.Enabled = _pm.IsAuthorized(PermissionManager.WORKSHOP_APPLICATION,
                                               _wph.ItemName(WorkshopPermissionHelper.Operation.UpdateCustomer));
            btnNewContract.Enabled = _pm.IsAuthorized(PermissionManager.WORKSHOP_APPLICATION,
                                                      _wph.ItemName(WorkshopPermissionHelper.Operation.AddContract));
            btnDeleteContract.Enabled = _pm.IsAuthorized(PermissionManager.WORKSHOP_APPLICATION,
                                                         _wph.ItemName(WorkshopPermissionHelper.Operation.DeleteContract));

            btnNewEqu.Enabled = _pm.IsAuthorized(PermissionManager.WORKSHOP_APPLICATION,
                                                 _wph.ItemName(WorkshopPermissionHelper.Operation.AddEquipment));
            btnDeleteEqu.Enabled = _pm.IsAuthorized(PermissionManager.WORKSHOP_APPLICATION,
                                                    _wph.ItemName(WorkshopPermissionHelper.Operation.DeleteEquipment));
            btnIssueWorkorder.Enabled = _pm.IsAuthorized(PermissionManager.WORKSHOP_APPLICATION,
                                                         _wph.ItemName(WorkshopPermissionHelper.Operation.IssueWorkorder));
        }
    }
}