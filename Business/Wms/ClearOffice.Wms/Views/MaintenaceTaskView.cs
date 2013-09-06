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
    public partial class MaintenaceTaskView : DevExpress.XtraEditors.XtraForm, IDetailForm
    {
        private WmsEntities _context;
        private bool _newMode;
        private MaintenanceTask _maintenanceTask;
        private MaintenanceLabour _selectedLabour;
        private MaintenancePart _selectedPart;
        private bool _hasChange;
        private PermissionManager _pm;
        private WorkshopPermissionHelper _wph;
        public MaintenanceTask CurrentTask
        {
            get { return _maintenanceTask; }
        }

        public MaintenaceTaskView()
        {
            InitializeComponent();
            _context = new WmsEntities();
            _pm = PermissionManager.GetPermissionManager();
            _wph = new WorkshopPermissionHelper();

            AuthorizeForm();
        }

        public void ShowObject(object keyValue)
        {
            _maintenanceTask = keyValue as MaintenanceTask;
            maintenaceTaskBindingSource.DataSource = _maintenanceTask;
            partsBindingSource.DataSource = _maintenanceTask.Parts;
            labourBindingSource.DataSource = _maintenanceTask.Labours;
            _newMode = true;
            isItemizedCheckBox.Checked = true;
            LoadLookUps();
            BtnSave.Enabled = true;
            if (_maintenanceTask.TaskId != 0)
            {
                ServiceLookUp.Enabled = false;
                _newMode = false;
            }
        }
        private void LoadLookUps()
        {
            pmServiceBindingSource.DataSource = _context.PmServiceInfoes.ToList();
            partsLookupBindingSource.DataSource = _context.PartInfoes.ToList();
            performerNameBindingSource.DataSource = _context.WorkshopEmployeesAndVendors.ToList();
        }

        public bool DataChanged()
        {
            return _context.ObjectStateManager.GetObjectStateEntries(EntityState.Added | EntityState.Modified | EntityState.Deleted).Any();
        }

        public void SaveChanges()
        {
            if (!ValidateForm())
                return;
            maintenaceTaskBindingSource.EndEdit();
            partsBindingSource.EndEdit();
            labourBindingSource.EndEdit();
            _maintenanceTask = (MaintenanceTask)maintenaceTaskBindingSource.DataSource;
            _hasChange = false;
            this.DialogResult = DialogResult.OK;
        }
        public void DeleteObject()
        {
            throw new NotImplementedException();
        }
        public bool ValidateForm()
        {
            var result = true;
            if (ServiceLookUp.EditValue == DBNull.Value)
            {
                maintenaceTaskErrorProvider.SetError(ServiceLookUp, "Service Is Required.");
                result = false;
            }
            return result;
        }
        private void ServiceLookUp_EditValueChanged(object sender, EventArgs e)
        {
            var selected = Convert.ToInt32(ServiceLookUp.EditValue);
            if (selected == 0)
                return;
            // From the currently selected PM Serice object, fetch all parts/labor units available and associate them with\
            // the current mTask object. 

            if (_newMode)//Do this only in a new mode b/c in edit/detail mode the service lookup is always disabled.
            {
                var sId = (int)ServiceLookUp.EditValue;

                var parts = from pms in _context.PmServiceParts
                            where pms.ServiceId == sId
                            select pms;

                foreach (var p in parts)
                {
                    var part = new MaintenancePart();
                    part.PartId = p.PartId.Value;
                    part.Quantity = p.Quantity;
                    _maintenanceTask.Parts.Add(part);
                }
            }

        }

        private void saveToolStripButton_Click(object sender, EventArgs e)
        {
            SaveChanges();
        }

        private void gridControl2_Click(object sender, EventArgs e)
        {
            btnDeleteLabour.Enabled = true;
            _selectedLabour = (MaintenanceLabour)labourBindingSource.Current;

            AuthorizeForm();
        }
        private void MaintenaceTaskBindingSource_CurrentItemChanged(object sender, EventArgs e)
        {
            BtnSave.Enabled = _hasChange;

            AuthorizeForm();
        }
        private void partsBindingSource_CurrentItemChanged(object sender, EventArgs e)
        {
            _hasChange = true;
            BtnSave.Enabled = true;
            CalculatePartCost();

            AuthorizeForm();
        }
        public void LabourAdded(MaintenanceLabour labour)
        {
            _maintenanceTask.Labours.Add(labour);
            CalculateLabourCost();
        }
        private void newLabour_Click(object sender, EventArgs e)
        {
            var mlv = new MaintainceLabourView();
            var ml = new MaintenanceLabour();
            mlv.ShowObject(ml);
            var result = mlv.ShowDialog();
            if (result == DialogResult.OK)
            {
                _maintenanceTask.Labours.Add(mlv.CurrentObject);
            }
        }

        private void labourBindingSource_CurrentItemChanged(object sender, EventArgs e)
        {
            _hasChange = true;
            BtnSave.Enabled = true;
            CalculateLabourCost();

            AuthorizeForm();
        }
        private void CalculatePartCost()
        {
            var total = _maintenanceTask.Parts.Sum(p => p.UnitCost * p.Quantity);
            partsCostTextBox.Text = total.ToString();
        }

        private void CalculateLabourCost()
        {
            var total = _maintenanceTask.Labours.Sum(l => l.LabourRate * l.Hour);
            labourCostTextBox.Text = total.ToString();
        }

        private void btnDeleteLabour_Click(object sender, EventArgs e)
        {
            if (_selectedLabour != null)
            {
                var result = ViewHelper.ShowConfirmDialog("Are you sure you want to delete this labour?");
                if (result == DialogResult.Yes)
                {
                    //_selectedLabour.WorkOrderId = null;
                    _maintenanceTask.Labours.Remove(_selectedLabour);
                    btnDeleteLabour.Enabled = false;
                    _hasChange = true;
                }
                return;
            }
        }

        private void MaintenaceTaskView_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (_hasChange)
            {
                DialogResult result = ViewHelper.ShowConfirmDialog("You haven't saved changes. Do you want to save changes ?");

                if (result == DialogResult.Yes)
                {
                    SaveChanges();
                    Close();
                }
                else if (result == DialogResult.Cancel)
                    e.Cancel = true;
            }
        }

        private void btnDeletePart_Click(object sender, EventArgs e)
        {
            if (_selectedPart != null)
            {
                var result = ViewHelper.ShowConfirmDialog("Are you sure you want to delete this part?");
                if (result == DialogResult.Yes)
                {
                    //_selectedPart.WorkOrderId = null;
                    _maintenanceTask.Parts.Remove(_selectedPart);
                     btnDeletePart.Enabled = false;
                    _hasChange = true;
                }
                return;
            }
        }

        private void gridControl1_Click(object sender, EventArgs e)
        {
            btnDeletePart.Enabled = true;
            _selectedPart = (MaintenancePart)partsBindingSource.Current;

            AuthorizeForm();
        }

        private void gridControl2_DoubleClick(object sender, EventArgs e)
        {
            btnDeleteLabour.Enabled = true;
            _selectedLabour = (MaintenanceLabour)labourBindingSource.Current;
            var mlv = new MaintainceLabourView();
            mlv.ShowObject(_selectedLabour);
            var result = mlv.ShowDialog();
            if (result == DialogResult.OK)
            {
                _maintenanceTask.Labours.Add(mlv.CurrentObject);
            }
        }

        internal void LabourDeleted(MaintenanceLabour ml)
        {
            _maintenanceTask.Labours.Remove(ml);
            btnDeleteLabour.Enabled = false;
            _hasChange = true;
        }

        private void BtnDelete_Click(object sender, EventArgs e)
        {
            var result = ViewHelper.ShowConfirmDialog("Are you sure you want to delete this task?");
            if (result == DialogResult.Yes)
            {
                DeleteObject();
            }
        }


        public void AuthorizeForm()
        {
            BtnSave.Enabled = _pm.IsAuthorized(PermissionManager.WORKSHOP_APPLICATION,
                                                       _wph.ItemName(WorkshopPermissionHelper.Operation.UpdateMaintenanceTask));
            PartsGridView.OptionsBehavior.Editable = _pm.IsAuthorized(PermissionManager.WORKSHOP_APPLICATION,
                                                       _wph.ItemName(WorkshopPermissionHelper.Operation.AddPart));
            newLabour.Enabled = _pm.IsAuthorized(PermissionManager.WORKSHOP_APPLICATION,
                                                        _wph.ItemName(WorkshopPermissionHelper.Operation.AddLaborUnit));
            btnDeleteLabour.Enabled = _pm.IsAuthorized(PermissionManager.WORKSHOP_APPLICATION,
                                                       _wph.ItemName(WorkshopPermissionHelper.Operation.DeleteLaborUnit));
            btnDeletePart.Enabled = _pm.IsAuthorized(PermissionManager.WORKSHOP_APPLICATION,
                                                       _wph.ItemName(WorkshopPermissionHelper.Operation.DeletePart));
        }
    }
}