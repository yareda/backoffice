using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using ClearOffice.Security;
using DevExpress.XtraEditors;
using ClearOffice.Wms.Business;
using ClearOffice.Infrastructure;

namespace ClearOffice.Wms.Views
{
    public partial class NewEquipment : DevExpress.XtraEditors.XtraForm, IDetailForm
    {
        private WmsEntities _context;
        private Equipment _equipment = new Equipment();
        private Customer _customer;
        private Contract _contract;
        private bool _saveAndNew;
        public Form Mdip { get; set; }
        public CustomerDetailView CustomerView { get; set; }
        public ContractDetailView ContractView { get; set; }
        public Form MainParent { get; set; }
        private PermissionManager _pm;
        private WorkshopPermissionHelper _wph;
        public NewEquipment()
        {
            InitializeComponent();
            _context = new WmsEntities();
            _pm = PermissionManager.GetPermissionManager();
            _wph = new WorkshopPermissionHelper();

            AuthorizeForm();
        }
        public void SetContract(Contract c)
        {
            _contract = c;
        }
        public void SetCustomer(Customer c)
        {
            _customer = c;
        }

        public void ShowObject(object keyValue)
        {
            _equipment = new Equipment();
            if (keyValue != null)
            {
                _equipment = (Equipment) keyValue;
            }
            equipmentBindingSource.DataSource = _equipment;
            BaseHoureRadioButton.Select();
            LoadLookUp();
        }

        private ContractRenewal GetActiveRenewal(Contract _con)
        {
            var renewal = _context.ContractRenewals.First(ct => ct.ContractId == _con.ContractId && ct.Status == 1);
            return renewal;
        }
        /// <summary>
        /// returns customer default contract.
        /// </summary>
        /// <param name="_customer"></param>
        /// <returns></returns>
        private Contract GetDefaultContract(Customer _customer)
        {
            return _context.Contracts.First(ct => ct.CustomerId == _customer.CustomerId && ct.IsDefaultContract == 1);
        }
        private void LoadLookUp()
        {
            MakeBindingSource.DataSource = _context.LookupItems.Where(li => li.LookupId == (int) LookupItems.Make);
            ModelBindingSource.DataSource = _context.LookupItems.Where(li => li.LookupId == (int) LookupItems.Model);
            CatagoryBindingSource.DataSource =
                _context.LookupItems.Where(li => li.LookupId == (int) LookupItems.EquipmentCatagory);
        }

        public bool DataChanged()
        {
            return _context.ObjectStateManager.GetObjectStateEntries(EntityState.Added | EntityState.Modified |
                                                         EntityState.Deleted).Any();
        }

        public void SaveChanges()
        {
            if (!ValidateForm()) return;
            equipmentBindingSource.EndEdit();
                    
            try
            {
                var equipment = (Equipment) equipmentBindingSource.DataSource;
                _context.Equipments.AddObject(equipment);
                _context.SaveChanges();
                _equipment = equipment;
                if (_saveAndNew)
                {
                    equipmentBindingSource.DataSource = new Equipment();
                    LoadLookUp();
                    if (CustomerView != null)
                    {
                        CustomerView.ReloadEquipments();
                    }
                    if (ContractView != null)
                    {
                        //ContractView.ReloadEquipments();
                    }
                }
                else
                {
                    this.Close();
                    // Redirect to Equipment Detail.
                    ShowEquipmentDetail();
                }
            }
            catch (Exception)
            {
                ViewHelper.ShowErrorMessage(@"Error saving new equipment.");
            }
        }

        private void ShowEquipmentDetail()
        {
            var eq = new EquipmentDetail();
            eq.ShowObject(_equipment.EquipmentId);
            //if (CustomerView != null)
            //{
            //    eq.MdiParent = CustomerView.MdiParent;
            //}
            //if (ContractView != null)
            //{
            //    eq.MdiParent = ContractView.MdiParent;
            //}
            eq.MdiParent = MainParent;
            eq.Show();
        }
        public void DeleteObject()
        {
            _context.Equipments.DeleteObject(_equipment);
        }

        public bool ValidateForm()
        {
            var result = true;
            if (serialTextBox.Text == string.Empty)
            {
                NewEquiErrorProvider.SetError(serialTextBox, "Serial# is required");
                result = false;
            }
            return result;
        }

        private void equipmentBindingSource_CurrentItemChanged(object sender, EventArgs e)
        {
            //saveToolStripButton.Enabled = DataChanged();
        }

        private void saveToolStripButton_Click(object sender, EventArgs e)
        {
            _saveAndNew = false;
            SaveChanges();

        }

        private void BtnSaveAndNew_Click(object sender, EventArgs e)
        {
            _saveAndNew = true;
            SaveChanges();
        }

        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {
            bool val = BaseHoureRadioButton.Checked;
            if (val)
            {
                baseHoursTextBox.Enabled = true;
                baseMileageTextBox.Enabled = false;
                baseMileageTextBox.Text = null;
                MileageRadioButton.Checked = false;
            }
        }

        private void radioButton2_CheckedChanged(object sender, EventArgs e)
        {
            bool val = MileageRadioButton.Checked;
            if (val)
            {
                baseHoursTextBox.Enabled = false;
                baseMileageTextBox.Enabled = true;
                BaseHoureRadioButton.Checked = false;
                baseHoursTextBox.Text = null;
            }
        }

        public void AuthorizeForm()
        {
            BtnSaveAndNew.Enabled = _pm.IsAuthorized(PermissionManager.WORKSHOP_APPLICATION,
                                                     _wph.ItemName(WorkshopPermissionHelper.Operation.AddEquipment));
            saveToolStripButton.Enabled = _pm.IsAuthorized(PermissionManager.WORKSHOP_APPLICATION,
                                                           _wph.ItemName(
                                                               WorkshopPermissionHelper.Operation.AddEquipment));
        }
    }
}