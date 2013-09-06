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
    public partial class ContractDetailView : DevExpress.XtraEditors.XtraForm,IDetailForm
    {
        private WmsEntities _context;
        private Contract _contract;
        private ContractRenewal _contractRenewal;
        private Equipment _equipment;
        private WorkshopPermissionHelper _wph;
        private PermissionManager _pm;
        public ContractDetailView()
        {
            InitializeComponent();
            _context = new WmsEntities();
            _pm = PermissionManager.GetPermissionManager();
            _wph = new WorkshopPermissionHelper();
            AuthorizeForm();
        }
        public void ShowObject(object keyValue)
        {
            var cont = (Contract) keyValue;
            _contract = _context.Contracts.First(c => c.ContractId == cont.ContractId);
            ContractBindingSource.DataSource = _context.Contracts.First(c => c.ContractId == cont.ContractId);
            CustomerInfoBindingSource.DataSource =
                _context.ContractInfoes.First(ct=>ct.ContractId == _contract.ContractId);
            EquipmentListBindingSource.DataSource =
                _context.EquipmentListInfoes.Where(e => e.ContractId == _contract.ContractId);
            ContractRenewalListBindingSource.DataSource =
                _context.ContractRenewalInfoes.Where(c =>c.ContractId == _contract.ContractId);

            LoadLookUps();
            ManageControles();
        }

        private void ManageControles()
        {
            if (_contract.Status == 0)//if the contract is canceld.
            {
                BtnSaveContract.Enabled = false;
                BtnCancelContract.Enabled = false;
                BtnDeleteContract.Enabled = false;
                BtnRenew.Enabled = false;
            }
            else
            {
                // The Renewal Button is only enabled if and ony if the contract expiration date has reached. else it will be disabled.
                var activeRenewal = GetActiveRenewal();
                BtnRenew.Enabled = DateTime.Compare(Convert.ToDateTime(activeRenewal.ExpirationDate), DateTime.Today) <=
                                   0;
            }
        }

        private ContractRenewalInfo GetActiveRenewal()
        {
            return _context.ContractRenewalInfoes.FirstOrDefault(ct => ct.ContractId == _contract.ContractId && ct.Status == 1);
        }

        private void LoadLookUps()
        {
            CustomerListBindingSource.DataSource = GetAllCustomers();
            ContractTypeBindingSource.DataSource = GetAllContractTypes();
        }
        private IEnumerable<CustomerInfo> GetAllCustomers()
        {
            return _context.CustomerInfoes.ToList();
        }
        private IEnumerable<LookupItem> GetAllContractTypes()
        {
            int itemId = Convert.ToInt32(LookupItems.ContractType);
            return _context.LookupItems.Where(li => li.LookupId == itemId);
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
            ContractBindingSource.EndEdit();
            try
            {
                _context.SaveChanges();
                BtnSaveContract.Enabled = false;
                ReloadContract(_contract.ContractId);
            }
            catch (Exception ex)
            {
                ViewHelper.ShowErrorMessage("Error occured while saving the current contract.", ex);
            }
        }

        public void DeleteObject()
        {
            try
            {
                _context = new WmsEntities();
                var cont = _context.Contracts.First(ct => ct.ContractId == _contract.ContractId);
                _context.Contracts.DeleteObject(cont);
                _context.SaveChanges();
                this.Close();
            }
            catch (Exception e)
            {
                ViewHelper.ShowDeleteError();
            }
        }

        public bool ValidateForm()
        {
            bool result = true;
            if (contractNoTextBox.Text == string.Empty)
            {
                ContractDetailErrorProvider.SetError(contractNoTextBox, "Contract number is required.");
                result = false;
            }
            if (contractTypeLookUpEdit.EditValue == DBNull.Value)
            {
                ContractDetailErrorProvider.SetError(contractTypeLookUpEdit, "Contract type is required.");
                result = false;
            }
            if (customerIdGridLookUpEdit.Visible == true && customerIdGridLookUpEdit.EditValue == DBNull.Value)
            {
                ContractDetailErrorProvider.SetError(customerIdGridLookUpEdit, "Customer is required.");
                result = false;
            }
            if (result) return true;
            return false;
        }

        private void ContractBindingSource_CurrentItemChanged(object sender, EventArgs e)
        {
            BtnSaveContract.Enabled = DataChanged() && _contract.Status==1;

            AuthorizeForm();
        }

        private void BtnSaveContract_Click(object sender, EventArgs e)
        {
            SaveChanges();
        }

        private void gridControl1_Click(object sender, EventArgs e)
        {
            if (RenewalListGridView.SelectedRowsCount > 0)
            {
                var selected = (ContractRenewalInfo)RenewalListGridView.GetRow((int)RenewalListGridView.GetSelectedRows().GetValue(0));
                if (null != selected)
                {
                    _contractRenewal = _context.ContractRenewals.First(cr=>cr.RenewalId == selected.RenewalId);
                }
            }
            AuthorizeForm();
        }
        private  void ControleEquipmentToolstripButtons()
        {
            if (_equipment != null && _contract.Status == 1)
            {
                BtnNewEqu.Enabled = true;
                BtnDeleteEqu.Enabled = true;
                BtnIssueWorkOrder.Enabled = true;
            }
            else
            {
                BtnNewEqu.Enabled = false;
                BtnDeleteEqu.Enabled = false;
                BtnIssueWorkOrder.Enabled = false;
            }
        }

        private void gridControl2_Click(object sender, EventArgs e)
        {
            if (EquipmentListGridView.SelectedRowsCount > 0)
            {
                var selected = (EquipmentListInfo)EquipmentListGridView.GetRow((int)EquipmentListGridView.GetSelectedRows().GetValue(0));
                if (null != selected)
                {
                    _equipment = _context.Equipments.First(eq => eq.EquipmentId == selected.EquipmentId);
                    ControleEquipmentToolstripButtons();
                }
            }

            AuthorizeForm();
        }
        private void ReloadContract(int cid)
        {
            ContractBindingSource.DataSource = _context.Contracts.First(c => c.ContractId == cid);
            CustomerInfoBindingSource.DataSource = _context.ContractInfoes.First(ct => ct.ContractId == cid);
            ManageControles();
        }

        private void BtnDeleteContract_Click(object sender, EventArgs e)
        {
            DialogResult result = ViewHelper.ShowConfirmDialog("Are you sure you want to delete this contract?");
            if (result == DialogResult.Yes)
                DeleteObject();
            return;
        }

        private void BtnRenew_Click(object sender, EventArgs e)
        {
            var reNewView = new ContractRenewView();
            reNewView.ShowObject(_contract,this);
            reNewView.ShowDialog();
        }

        private void ContractDetailView_FormClosing(object sender, FormClosingEventArgs e)
        {
            // if the save button is enabled then it means there is an unsaved changes.
            if (BtnSaveContract.Enabled)
            {
                DialogResult result =
                    ViewHelper.ShowConfirmDialog("You haven't saved changes. Do you want to save changes ?");
                if (result == DialogResult.Yes)
                {
                    SaveChanges();
                    Close();
                }
                else if (result == DialogResult.Cancel)
                    e.Cancel = true;
            }
        }
        public void ReloadRenewals()
        {
            ContractRenewalListBindingSource.DataSource =  _context.ContractRenewalInfoes.Where(c => c.ContractId == _contract.ContractId);
            ReloadContract(_contract.ContractId);
            
        }

        private void BtnCancelContract_Click(object sender, EventArgs e)
        {
            var result = ViewHelper.ShowConfirmDialog("Are you sure you want to cancel this contract.");
            if (result == DialogResult.Yes)
            {
                CancelContract(_contract);
            }
            return;
        }

        private void CancelContract(Contract _c)
        {
            var cont = _context.Contracts.First(ct => ct.ContractId == _c.ContractId);
            cont.Status = 0;
            try
            {
                _context.SaveChanges();
                this.Close();
            }
            catch (Exception)
            {
                ViewHelper.ShowErrorMessage("Unable to cancel the contract.");
                return;
            }
        }

        private void BtnNewEqu_Click(object sender, EventArgs e)
        {
            var equipment = new Equipment() { ContractId = _contract.ContractId,RenewalId = GetActiveRenewal().RenewalId};
            var nev = new NewEquipment();
            nev.ContractView = this;
            //nev.SetCustomer(_customer);
            nev.MainParent = this.MdiParent;
            nev.ShowObject(equipment);
            nev.ShowDialog();
        }

        private void BtnRefresh_Click(object sender, EventArgs ev)
        {
            _context = new WmsEntities();
            EquipmentListBindingSource.DataSource = _context.EquipmentListInfoes.Where(e => e.ContractId == _contract.ContractId);
        }

        private void gridControl2_DoubleClick(object sender, EventArgs e)
        {
            if (EquipmentListGridView.SelectedRowsCount > 0)
            {
                var selected = (EquipmentListInfo)EquipmentListGridView.GetRow((int)EquipmentListGridView.GetSelectedRows().GetValue(0));
                if (null != selected)
                {
                    _equipment = _context.Equipments.First(eq => eq.EquipmentId == selected.EquipmentId);
                    OpenSelectedEquipment();
                }
            }
        }
        public object GetSelectedEquipment()
        {
            return _equipment;
        }
        private void OpenSelectedEquipment()
        {
            var eq = new EquipmentDetail();
            eq.ShowObject(_equipment.EquipmentId);
            eq.ContractDetailView = this;
            eq.MdiParent = this.MdiParent;
            eq.Dock = DockStyle.Fill;
            eq.Show();
        }

        public void RefreshEquipmentList()
        {
            _context = new WmsEntities();
            EquipmentListBindingSource.DataSource = _context.EquipmentListInfoes.Where(e => e.ContractId == _contract.ContractId);
        }

        private void BtnDeleteEqu_Click(object sender, EventArgs e)
        {
            DialogResult result = ViewHelper.ShowConfirmDialog("Are you sure you want to delete this equipment.");
            if (result == DialogResult.Yes)
                DeleteSelectedEquipment();
        }

        private void DeleteSelectedEquipment()
        {
            _context = new WmsEntities();
            var eq = _context.Equipments.FirstOrDefault(e => e.EquipmentId == _equipment.EquipmentId);
            _context.DeleteObject(eq);
            _context.SaveChanges();
            RefreshEquipmentList();
        }

        private void BtnIssueWorkOrder_Click(object sender, EventArgs e)
        {
            if (_equipment != null)
            {
                var wov = new WorkOrderView();
                wov.Equipment = _equipment;
                wov.ShowObject(null);
                wov.MdiParent = this.MdiParent;
                wov.Show();
            }
        }

        public void AuthorizeForm()
        {
            BtnCancelContract.Enabled = _pm.IsAuthorized(PermissionManager.WORKSHOP_APPLICATION,
                                                         _wph.ItemName(WorkshopPermissionHelper.Operation.CancelContract));
            BtnRenew.Enabled = _pm.IsAuthorized(PermissionManager.WORKSHOP_APPLICATION,
                                                _wph.ItemName(WorkshopPermissionHelper.Operation.RenewContract));

            BtnSaveContract.Enabled = _pm.IsAuthorized(PermissionManager.WORKSHOP_APPLICATION,
                                                       _wph.ItemName(WorkshopPermissionHelper.Operation.UpdateContract));

            BtnDeleteContract.Enabled = _pm.IsAuthorized(PermissionManager.WORKSHOP_APPLICATION,
                                                         _wph.ItemName(WorkshopPermissionHelper.Operation.DeleteContract));
            BtnPrint.Enabled = _pm.IsAuthorized(PermissionManager.WORKSHOP_APPLICATION,
                                                _wph.ItemName(WorkshopPermissionHelper.Operation.PrintContract));

            BtnNewEqu.Enabled = _pm.IsAuthorized(PermissionManager.WORKSHOP_APPLICATION,
                                                 _wph.ItemName(WorkshopPermissionHelper.Operation.AddEquipment));
            BtnDeleteEqu.Enabled = _pm.IsAuthorized(PermissionManager.WORKSHOP_APPLICATION,
                                                    _wph.ItemName(WorkshopPermissionHelper.Operation.DeleteEquipment));
            BtnIssueWorkOrder.Enabled = _pm.IsAuthorized(PermissionManager.WORKSHOP_APPLICATION,
                                                         _wph.ItemName(WorkshopPermissionHelper.Operation.IssueWorkorder));

        }
    }
}