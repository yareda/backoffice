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
using ClearOffice.Infrastructure;
using ClearOffice.Wms.Business;
namespace ClearOffice.Wms.Views
{
    public partial class InsuranceView : DevExpress.XtraEditors.XtraForm,IDetailForm
    {
        private WmsEntities _context;
        private EquipmentInsurance _equipmentInsurance;
        private bool _newMode;
        public Equipment Equipment { get; set; }
        public EquipmentInsurance CurrentObject
        {
            get { return _equipmentInsurance; }
        }

        private bool SaveAndNew;
        private PermissionManager _pm;
        private WorkshopPermissionHelper _wph;
        public InsuranceView()
        {
            InitializeComponent();
            _context = new WmsEntities();
            _pm = PermissionManager.GetPermissionManager();
            _wph = new WorkshopPermissionHelper();

            AuthorizeForm();
        }
        public void ShowObject(object keyValue)
        {
            _equipmentInsurance = keyValue as EquipmentInsurance;
            InsuranceBindingSource.DataSource = _equipmentInsurance;
            LoadLookUps();
        }

        private void LoadLookUps()
        {
            CompaniesBindingSource.DataSource = _context.LookupItems.Where(li=>li.LookupId == (int)LookupItems.InsuranceCompany);
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
            InsuranceBindingSource.EndEdit();
            
            //if(_newMode)
            //    _context.EquipmentInsurances.AddObject(_equipmentInsurance);
            //_context.SaveChanges();

            //EquipmentDetail.ReloadInsurances();           
            if (SaveAndNew)
            {
                _equipmentInsurance = new EquipmentInsurance();
                InsuranceBindingSource.DataSource = _equipmentInsurance;
                LoadLookUps();
                this.DialogResult = DialogResult.OK;
            }
            else
                this.DialogResult = DialogResult.OK;
        }

        public void DeleteObject()
        {
            throw new NotImplementedException();
        }

        public bool ValidateForm()
        {
            var result = true;
            if (companyIdLookUpEdit.EditValue == DBNull.Value)
            {
                InsuranceErrorProvider.SetError(companyIdLookUpEdit,"Insurance Company Is Required.");
                result = false;
            }
            //if (companyIdLookUpEdit.EditValue!=DBNull.Value)
            //{
            //    if (InsurnaceCompanyExist())
            //    {
            //        InsuranceErrorProvider.SetError(companyIdLookUpEdit,"The Company Already Exists.");
            //        result = false;
            //    }
            //}
            if (policyNumberTextBox.Text == string.Empty)
            {
                InsuranceErrorProvider.SetError(policyNumberTextBox,"Policy Number Is Required.");
                result = false;
            }
            if (startDateDateEdit.EditValue != DBNull.Value && endDateDateEdit.EditValue == DBNull.Value)
            {
                InsuranceErrorProvider.SetError(endDateDateEdit,"End Date Is Required.");
                result = false;
            }
            if (startDateDateEdit.EditValue == DBNull.Value && endDateDateEdit.EditValue != DBNull.Value)
            {
                InsuranceErrorProvider.SetError(startDateDateEdit, "Strat Date Is Required.");
                result = false;
            }
            if (startDateDateEdit.EditValue != DBNull.Value && endDateDateEdit.EditValue != DBNull.Value)
            {
                var val = DateTime.Compare(Convert.ToDateTime(startDateDateEdit.EditValue),
                                           Convert.ToDateTime(endDateDateEdit.EditValue));
                if (val > 0)
                {
                    InsuranceErrorProvider.SetError(endDateDateEdit,"The end date is not valid.");
                    result = false;
                }
            }
            return result;
        }


        private void saveToolStripButton_Click(object sender, EventArgs e)
        {
            SaveAndNew = false;
            SaveChanges();
        }

        private void BtnSaveAndNew_Click(object sender, EventArgs e)
        {
            SaveAndNew = true;
            SaveChanges();
        }

        private void BtnDelete_Click(object sender, EventArgs e)
        {
            DialogResult result = ViewHelper.ShowConfirmDialog("Are you sure to delete this insurance information ?");
            if(result == DialogResult.Yes)
                DeleteObject();
        }

        public void AuthorizeForm()
        {
            saveToolStripButton.Enabled = _pm.IsAuthorized(PermissionManager.WORKSHOP_APPLICATION,
                                                           _wph.ItemName(
                                                               WorkshopPermissionHelper.Operation.AddEquipmentInsurance));
        }
    }
}