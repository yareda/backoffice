using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using System.Linq;
using ClearOffice.Infrastructure;
using DevExpress.XtraEditors;
using ClearOffice.FixedAsset.DataAccess;
using ClearOffice.Security;
using System.Linq;
namespace ClearOffice.FixedAsset.Views
{
    public partial class AdjustementEdit : DevExpress.XtraEditors.XtraForm,IDetailForm
    {
        private FixedAssetEntities _context;
        private bool _newMode;
        private Adjustment _adjustment;
        private FixedAssetPermissionHelper faph;
        private PermissionManager permissionManager;
        public Adjustment CurrentObject
        {
            get { return _adjustment; }
            set { _adjustment = value; }
        }

        public AdjustementEdit()
        {
            InitializeComponent();
            _context = new FixedAssetEntities();
            faph = new FixedAssetPermissionHelper();
            permissionManager = PermissionManager.GetPermissionManager();
            AuthorizeForm();
        }

        public void ShowObject(object keyValue)
        {
            var adj = (Adjustment)keyValue;
            if (adj.AdjustmentId == 0)
            {
                _newMode = true;
                _adjustment = (Adjustment) keyValue;
            }
            else if (adj.AdjustmentId != 0)
            {
                _newMode = false;
                _adjustment = _context.Adjustments.FirstOrDefault(a => a.AdjustmentId == adj.AdjustmentId);
            }
            adjustementBindingSource.DataSource = _adjustment;
            LoadLookups();
            btnSave.Enabled = _adjustment.Status != (int) AdjustemntStatus.Posted;
        }

        private void LoadLookups()
        {
           var types = _context.LookupItems.Where(li => li.LookupId == 6);
            adjustementTypeBindingSource.DataSource =
                types.ToList();
        }

        public bool DataChanged()
        {
            throw new NotImplementedException();
        }

        public void SaveChanges()
        {
            if (!ValidateForm())
            {
               return;
            }
            _adjustment = (Adjustment) adjustementBindingSource.DataSource;
            _adjustment.Status = (int) AdjustemntStatus.Pending;
            if(_newMode)
                _context.Adjustments.AddObject(_adjustment);
            try
            {
                _context.SaveChanges();
                this.DialogResult = DialogResult.OK;
                return;
            }
            catch(Exception ex)
            {
                ViewHelper.ShowErrorMessage("Error occured while saving the given asset adjustment.", ex);
                return;
            }
            
        }

        public void DeleteObject()
        {
            throw new NotImplementedException();
        }

        public bool ValidateForm()
        {
            bool result = true;
            adjustementErrorProvider.Clear();
            if (adjustmentTypeLookUpEdit.EditValue == DBNull.Value)
            {
                adjustementErrorProvider.SetError(adjustmentTypeLookUpEdit,"Adjustement Type Is Required.");
                result = false;
            }
            if (fiscalPeriodTextBox.Text == string.Empty)
            {
                result = false;
                adjustementErrorProvider.SetError(fiscalPeriodTextBox,"Fiscal Period  Is Required.");
            }
            if (fiscalPeriodTextBox.Text != string.Empty)
            {
                var val = Convert.ToInt32(fiscalPeriodTextBox.Text);
                if (val <= 0 || val > 12)
                {
                    result = false;
                    adjustementErrorProvider.SetError(fiscalPeriodTextBox,"Fiscal Period Is Not Valid");
                }
            }
            if (fiscalYearTextBox.Text == string.Empty)
            {
                result = false;
                adjustementErrorProvider.SetError(fiscalYearTextBox,"Fiscal Year Is Required.");
            }
            if (fiscalYearTextBox.Text != string.Empty)
            {
                var val = Convert.ToInt32(fiscalYearTextBox.Text);
                if (val < 1960 || val > 2020)
                {
                    result = false;
                    adjustementErrorProvider.SetError(fiscalYearTextBox, "Fiscal Year Is Not Valid");
                }
            }
            return result;
        }

        private void saveToolStripButton_Click(object sender, EventArgs e)
        {
            SaveChanges();
        }


        public void AuthorizeForm()
        {
            btnSave.Enabled = permissionManager.IsAuthorized(PermissionManager.INVENTORY_APPLICATION,
                                                             faph.ItemName(
                                                                 FixedAssetPermissionHelper.Operation.AdjustAsset));
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }

        public class Period
        {
            public int Value { get; set; }
            public string Name { get; set; }
            public Period(int v,string n)
            {
                Value = v;
                Name = n;
            }
        }
}