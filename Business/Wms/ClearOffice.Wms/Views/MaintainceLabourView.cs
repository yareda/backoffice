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
using DevExpress.XtraEditors.Controls;
using System.Linq;
namespace ClearOffice.Wms.Views
{
    public partial class MaintainceLabourView : DevExpress.XtraEditors.XtraForm, IDetailForm
    {
        private WmsEntities _context;
        public WorkOrderView WorkOrderView { get; set; }
        private bool _saveAndNew;
        private MaintenanceLabour _maintenanceLabour;

        private PermissionManager _pm;
        private WorkshopPermissionHelper _wph;

        public MaintenanceLabour CurrentObject
        {
            get { return _maintenanceLabour; }
        }

        public MaintainceLabourView()
        {
            InitializeComponent();
            _context = new WmsEntities();
            _pm = PermissionManager.GetPermissionManager();
            _wph = new WorkshopPermissionHelper();
        }
        public void ShowObject(object keyValue)
        {
            _maintenanceLabour = keyValue as MaintenanceLabour;
            labourBindingSource.DataSource = _maintenanceLabour;
            if (_maintenanceLabour.PerformedBy == null)
            {
                performedByRadioGroup.EditValue = 1;
                LoadEmployees();
            }
            else
            {
                performedByRadioGroup.EditValue = _maintenanceLabour.PerformedBy;
                if(_maintenanceLabour.PerformedBy == 1)
                    LoadEmployees();
                else
                    LoadVendors();
            }
        }

        public bool DataChanged()
        {
            throw new NotImplementedException();
        }

        public void SaveChanges()
        {
            if (!ValidateForm())
                return;
            labourBindingSource.EndEdit();
            _maintenanceLabour = (MaintenanceLabour)labourBindingSource.DataSource;
            if (!_saveAndNew)
            {
                this.DialogResult = DialogResult.OK;
                return;
            }
            else
            {
                _maintenanceLabour = new MaintenanceLabour();
                labourBindingSource.DataSource = _maintenanceLabour;
                this.DialogResult = DialogResult.OK;
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
            if (performerLookUpEdit.EditValue == DBNull.Value)
            {
                labourErrorProvider.SetError(performerLookUpEdit, "Vendor Or Employee Is Required.");
                result = false;
            }
            return result;
        }

        private void LoadVendors()
        {
            performerLookUpEdit.Properties.Columns.Clear();
            performerLookUpEdit.Properties.DataSource = _context.Vendors.ToList();
            performerLookUpEdit.Properties.DisplayMember = "Name";
            performerLookUpEdit.Properties.ValueMember = "VendorId";
            performerLookUpEdit.Properties.Columns.Add(new LookUpColumnInfo("Name"));
        }

        private void LoadEmployees()
        {
            performerLookUpEdit.Properties.Columns.Clear();
            performerLookUpEdit.Properties.DataSource = _context.WorkshopEmployeesInfoes.ToList();
            performerLookUpEdit.Properties.DisplayMember = "FullName";
            performerLookUpEdit.Properties.ValueMember = "EmployeeId";
            performerLookUpEdit.Properties.Columns.Add(new LookUpColumnInfo("FullName"));
            performerLookUpEdit.Properties.Columns.Add(new LookUpColumnInfo("EmployeeNo"));
        }
        private void saveToolStripButton_Click(object sender, EventArgs e)
        {
            _saveAndNew = false;
            SaveChanges();
        }

        private void hourTextBox_TextChanged(object sender, EventArgs e)
        {
            var rate = labourRateTextBox.Text == string.Empty ? 0 : Convert.ToInt32(labourRateTextBox.Text);
            var hour = hourTextBox.Text == string.Empty ? 0 : Convert.ToInt32(hourTextBox.Text);
            totalCostTextBox.Text = (rate * hour).ToString();
        }

        private void btnSaveNew_Click(object sender, EventArgs e)
        {
            _saveAndNew = true;
            SaveChanges();
        }

        private void performedByRadioGroup_EditValueChanged(object sender, EventArgs e)
        {
            var selected = performedByRadioGroup.EditValue;
            if (!selected.Equals(DBNull.Value))
            {
                if (Convert.ToInt32(selected) == 1)
                {
                    LoadEmployees();
                    _maintenanceLabour.PerformedBy = 1;
                }
                else if (Convert.ToInt32(selected) == 2)
                {
                    LoadVendors();
                    _maintenanceLabour.PerformedBy = 2;
                }
            }
        }


        public void AuthorizeForm()
        {
            saveToolStripButton.Enabled = _pm.IsAuthorized(PermissionManager.WORKSHOP_APPLICATION,
                                                       _wph.ItemName(WorkshopPermissionHelper.Operation.AddLaborUnit));
        }
    }
}