using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using ClearOffice.Infrastructure;
using ClearOffice.Security;
using DevExpress.XtraEditors;
using System.Linq;
using ClearOffice.Wms.Business;
namespace ClearOffice.Wms.Views
{
    public partial class WorkOrderView : DevExpress.XtraEditors.XtraForm, IDetailForm
    {
        private WmsEntities _context;
        private WorkOrder _workOrder;
        private MaintenanceTask _selectedTask;
        private MaintenancePart _selectedPart;
        private MaintenanceLabour _selectedLabour;
        private bool _newMode = true;
        private PermissionManager _pm;
        private WorkshopPermissionHelper _wph;
        public WorkOrderListView WorkOrderListView { get; set; }
        public object Equipment { get; set; }

        public WorkOrderView()
        {
            InitializeComponent();
            _context = new WmsEntities();

            _pm = PermissionManager.GetPermissionManager();
            _wph = new WorkshopPermissionHelper();

            AuthorizeForm();
        }

        public void ShowObject(object keyValue)
        {
            var eq = (Equipment)Equipment;
            if (keyValue == null)
            {
                var cont = _context.Contracts.FirstOrDefault(c => c.ContractId == eq.ContractId);
                var cust = _context.Customers.FirstOrDefault(ct => ct.CustomerId == cont.CustomerId);
                _workOrder = new WorkOrder() { StartDate = DateTime.Today, IssueDate = DateTime.Today, EquipmentId = eq.EquipmentId, ContractId = cont.ContractId, CustomerId = cust.CustomerId };
                LoadCommonData();
                LoadLookUps();
                WorkOrderBindingSource.DataSource = _workOrder;
                _newMode = true;
                BtnSave.Enabled = true;
            }
            else
            {
                _workOrder = _context.WorkOrders.FirstOrDefault(wo => wo.WorkOrderId == (int)keyValue);
                LoadCommonData();
                LoadLookUps();
                WorkOrderBindingSource.DataSource = _workOrder;
                btnDelete.Enabled = true;
                _newMode = false;
                if (_workOrder.Discount != null)
                    DiscountCheckBox.Checked = true;
                if (_workOrder.Tax != null)
                    TaxCheckBox.Checked = true;

                CalculateTotal();
            }
        }

        private void LoadCommonData()
        {
            TasksBindingSource.DataSource = _workOrder.Tasks;
            partsBindingSource.DataSource = _workOrder.Parts;
            laboursBindingSource.DataSource = _workOrder.LaborUnits;
        }

        private void LoadLookUps()
        {
            StatusBindingSource.DataSource =
                _context.LookupItems.Where(s => s.LookupId == (int)LookupItems.WorkorderStatus);
            PriorityBindingSource.DataSource =
                _context.LookupItems.Where(p => p.LookupId == (int)LookupItems.WorkorderPriority);
            EmployeesBindingSource.DataSource = _context.WorkshopEmployeesInfoes.ToList();

            vendorAndEmployeesBindingSource.DataSource = _context.WorkshopEmployeesAndVendors.ToList();
            partInfoBindingSource.DataSource = _context.PartInfoes.ToList();
            pmServiceListBindingSource.DataSource = _context.PmServices.ToList();

        }

        public bool DataChanged()
        {
            return _context.ObjectStateManager.GetObjectStateEntries(EntityState.Added | EntityState.Modified | EntityState.Deleted).Any();
        }

        public void SaveChanges()
        {
            if (!ValidateForm())return;
            WorkOrderBindingSource.EndEdit();
            _workOrder = (WorkOrder)WorkOrderBindingSource.DataSource;
            foreach (var t in _workOrder.Tasks)
            {
                foreach(var p in t.Parts)
                {
                    //p.WorkOrderId = _workOrder.WorkOrderId;
                    _workOrder.Parts.Add(p);
                }
                foreach (var l in t.Labours)
                {
                    //l.WorkOrderId = _workOrder.WorkOrderId;
                    _workOrder.LaborUnits.Add(l);
                }
            }
            if (_newMode)
            {
               
                double pt = 0;
                double lt = 0;
                foreach (var p in _workOrder.Parts)
                {
                    pt += Convert.ToDouble(p.UnitCost*p.Quantity);
                }
                foreach (var l in _workOrder.LaborUnits)
                {
                    lt = Convert.ToDouble(l.LabourRate*l.Hour);
                }
                double t = _workOrder.Tax == null ? 0 : Convert.ToDouble(_workOrder.Tax)/100;
                double d = _workOrder.Discount == null ? 0 : Convert.ToDouble(_workOrder.Discount)/100;
                var tc = (double) (pt + lt);
                _workOrder.TotalCost = Convert.ToDecimal(tc + (t*tc) - (d*tc));
                _context.WorkOrders.AddObject(_workOrder);
            }
            try
            {
                _context.SaveChanges();
                //ShowObject(_workOrder.WorkOrderId);
                if (_newMode)
                {
                    _context.SaveChanges();
                    _newMode = false;
                }
            }
            catch (Exception)
            {
                ViewHelper.ShowSaveError();
                return;
            }
        }

        public void DeleteObject()
        {
            if (_workOrder != null)
            {
                foreach (var t in _workOrder.Tasks.ToList())
                {
                    DeleteTask(t);
                }
                foreach (var l in _workOrder.LaborUnits.ToList())
                {
                    if (l.LabourId != 0)
                    {
                        _context.MaintenanceLabours.DeleteObject(l);
                    }
                }
                foreach (var p in _workOrder.Parts.ToList())
                {
                    if (p.PartId != 0)
                    {
                        _context.MaintenanceParts.DeleteObject(p);
                    }
                }
                _context.WorkOrders.DeleteObject(_workOrder);
                _context.SaveChanges();
            }
        }

        public bool ValidateForm()
        {
            bool result = true;
            if (workOrderNoTextBox.Text == string.Empty)
            {
                WorkorderErrorProvider.SetError(workOrderNoTextBox, "Workorder Number Is Required.");
                result = true;
            }
            if (startDateDateEdit.EditValue != DBNull.Value && endDateDateEdit.EditValue == DBNull.Value)
            {
                WorkorderErrorProvider.SetError(endDateDateEdit, "End Date Is Required.");
                result = false;
            }
            if (startDateDateEdit.EditValue == DBNull.Value && endDateDateEdit.EditValue != DBNull.Value)
            {
                WorkorderErrorProvider.SetError(startDateDateEdit, "Start Date Is Required.");
                result = false;
            }
            if (startDateDateEdit.EditValue != DBNull.Value && endDateDateEdit.EditValue != DBNull.Value)
            {
                var res = DateTime.Compare((DateTime)startDateDateEdit.EditValue, (DateTime)endDateDateEdit.EditValue);
                if (res > 0)
                {
                    WorkorderErrorProvider.SetError(endDateDateEdit, "End Date Is Not Valid");
                    result = false;
                }
            }
            return result;
        }

        private void DiscountCheckBox_CheckedChanged(object sender, EventArgs e)
        {
            TxtDiscount.Enabled = DiscountCheckBox.Checked;
        }

        private void TaxCheckBox_CheckedChanged(object sender, EventArgs e)
        {
            TxtTaxes.Enabled = TaxCheckBox.Checked;
        }

        private void BtnSave_Click(object sender, EventArgs e)
        {
            SaveChanges();
            BtnSave.Enabled = false;
            btnDelete.Enabled = true;
            CalculateLabour();
            CalculateParts();
            CalculateTotal();
        }
        private void WorkOrderBindingSource_CurrentItemChanged(object sender, EventArgs e)
        {
            CalculateTotal();
            if(!_newMode)
                BtnSave.Enabled = DataChanged();

            AuthorizeForm();
        }

        private void BtnNewTask_Click(object sender, EventArgs e)
        {
            var mtv = new MaintenaceTaskView();
            var mt = new MaintenanceTask();
            mtv.ShowObject(mt);
            var result = mtv.ShowDialog();
            if (result == DialogResult.OK)
            {
                _workOrder.Tasks.Add(mtv.CurrentTask);
            }
        }

        internal void TaskAdded(MaintenanceTask _maintenanceTask)
        {
            _workOrder.Tasks.Add(_maintenanceTask);
            BtnSave.Enabled = true;
            CalculateLabour();
            CalculateParts();
            CalculateTotal();
        }

        private void gridControl1_Click(object sender, EventArgs e)
        {
            _selectedTask = (MaintenanceTask)TasksBindingSource.Current;
            btnDeleteTask.Enabled = true;

            AuthorizeForm();
        }

        private void gridControl1_DoubleClick(object sender, EventArgs e)
        {
            TasksBindingSource.EndEdit();
            _selectedTask = (MaintenanceTask) TasksBindingSource.Current;
              var mtv = new MaintenaceTaskView();
              mtv.ShowObject(_selectedTask);
             var result = mtv.ShowDialog();
             if (result == DialogResult.OK)
             {
                 _workOrder.Tasks.Add(mtv.CurrentTask);
                 BtnSave.Enabled = true;
             }
        }

        private void gridControl2_Click(object sender, EventArgs e)
        {
            _selectedPart = (MaintenancePart)partsBindingSource.Current;
            btnDeleteParts.Enabled = true;

            AuthorizeForm();
        }

        private void btnNewLabour_Click(object sender, EventArgs e)
        {
            var mlv = new MaintainceLabourView();
            var ml = new MaintenanceLabour();
            mlv.ShowObject(ml);
            var result = mlv.ShowDialog();
            if (result == DialogResult.OK)
            {
                _workOrder.LaborUnits.Add(mlv.CurrentObject);
            }
        }

        internal void LabourAdded(MaintenanceLabour ml)
        {
            try
            {
                _workOrder.LaborUnits.Add(ml);
                CalculateLabour();
                BtnSave.Enabled = true;
            }
            catch (Exception)
            {
                ViewHelper.ShowSaveError();
            }
        }

        private void partsBindingSource_CurrentItemChanged(object sender, EventArgs e)
        {
            BtnSave.Enabled = true;
            CalculateParts();
            CalculateTotal();

            AuthorizeForm();
        }
        private void CalculateParts()
        {
            var total = _workOrder.Parts.Sum(p => p.UnitCost * p.Quantity);
            TxtPartTotal.Text = total.ToString();
        }

        private void laboursBindingSource_CurrentItemChanged(object sender, EventArgs e)
        {
            BtnSave.Enabled = true;
            CalculateLabour();
            CalculateTotal();

            AuthorizeForm();
        }
        private void CalculateLabour()
        {
            var total = _workOrder.LaborUnits.Sum(l => l.LabourRate * l.Hour);
            TxtLabourTotal.Text = total.ToString();
        }
        /// <summary>
        /// Sets the workorder totalCost property to the calculated value.
        /// </summary>
        private void CalculateTotal()
        {
            var pt = Convert.ToDecimal(_workOrder.Parts.Sum(p => p.UnitCost * p.Quantity));
            var lt = Convert.ToDecimal(_workOrder.LaborUnits.Sum(l => l.LabourRate * l.Hour));
            var disc = _workOrder.Discount;
            var tax = _workOrder.Tax;
            var d = disc / 100;
            var t = tax / 100;
            if (tax != null && disc != null)
                _workOrder.TotalCost = (((pt + lt) - d * (pt + lt)) + (pt + lt) * t);
            else if (tax != null && disc == null)
                _workOrder.TotalCost = (pt + lt) + (pt + lt)*t;
            else if(tax==null && disc!=null)
                _workOrder.TotalCost = (pt + lt) - d;
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            var result = ViewHelper.ShowConfirmDialog("Are you sure you want to delete this workorder?");
            if (result == DialogResult.Yes)
            {
                try
                {
                    DeleteObject();
                    Close();
                    if (WorkOrderListView != null)
                    {
                        WorkOrderListView.RefreshList();
                    }
                }
                catch (Exception)
                {
                    ViewHelper.ShowDeleteError();
                    return;
                }
            }
        }

        private void btnDeleteTask_Click(object sender, EventArgs e)
        {
            var result = ViewHelper.ShowConfirmDialog("Are you sure you want to delete this task?");
            if (result == DialogResult.Yes)
            {
                DeleteTask(_selectedTask);
                BtnSave.Enabled = true;
            }
        }

        private void DeleteTask(MaintenanceTask task)
        {
            if (task.TaskId == 0)
                _workOrder.Tasks.Remove(task);
            else
            {
                foreach (var l in task.Labours.ToList())
                {
                    _context.MaintenanceLabours.DeleteObject(l);
                }
                foreach (var p in task.Parts.ToList())
                {
                    _context.MaintenanceParts.DeleteObject(p);
                }
                _context.MaintenanceTasks.DeleteObject(task);
            }
        }

        private void btnDeleteParts_Click(object sender, EventArgs e)
        {
            var result = ViewHelper.ShowConfirmDialog("Are you sure you want to delete this part?");
            if (result == DialogResult.Yes)
            {
                   _selectedPart.TaskId = null;
                   if (_selectedPart.MaintainedPartId != 0)//if the context have saved
                       _context.MaintenanceParts.DeleteObject(_selectedPart);
                   else//if the context hasn't saved yet.
                       _workOrder.Parts.Remove(_selectedPart);
                BtnSave.Enabled = true;
            }
        }

        private void TasksBindingSource_CurrentItemChanged(object sender, EventArgs e)
        {
            CalculateLabour();
            CalculateParts();
            CalculateTotal();
            BtnSave.Enabled = true;

            AuthorizeForm();
        }

        private void gridControl3_Click(object sender, EventArgs e)
        {
            _selectedLabour = (MaintenanceLabour)laboursBindingSource.Current;
            btnDeleteLabour.Enabled = true;

            AuthorizeForm();
        }

        private void gridControl3_DoubleClick(object sender, EventArgs e)
        {
            _selectedLabour = (MaintenanceLabour)laboursBindingSource.Current;
            if (_selectedLabour != null)
            {
                var mlv = new MaintainceLabourView();
                mlv.ShowObject(_selectedLabour);
                var result = mlv.ShowDialog();
                if (result == DialogResult.OK)
                {
                    _workOrder.LaborUnits.Add(mlv.CurrentObject);
                }
            }
        }
        private void btnDeleteLabour_Click(object sender, EventArgs e)
        {
            if (_selectedLabour != null)
            {
                var result = ViewHelper.ShowConfirmDialog("Are you sure you want to delete this labour?");
                if (result == DialogResult.Yes)
                {
                   _selectedLabour.TaskId = null;
                    _workOrder.LaborUnits.Remove(_selectedLabour);
                }
            }
        }
        internal void LabourDeleted(MaintenanceLabour lb)
        {
            try
            {
                _workOrder.LaborUnits.Remove(lb);
            }
            catch (Exception)
            {
                ViewHelper.ShowDeleteError();
                return;
            }
        }

        internal void TaskDeleted(MaintenanceTask _maintenanceTask)
        {
            _workOrder.Tasks.Remove(_maintenanceTask);
        }

        private void WorkOrderView_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (DataChanged())
            {
                DialogResult result = ViewHelper.ShowConfirmDialog("You haven't saved changes. Do you want to save changes ?");
                if (result == DialogResult.Yes)
                {
                    try
                    {
                        SaveChanges();
                    }
                    catch (Exception ex)
                    {
                        ViewHelper.ShowErrorMessage("Error occured while saving the workorder");
                        ErrorLogger.LogError(this,ex);
                    }
                    WorkOrderListView.RefreshList();
                    this.Close();
                }
                else if (result == DialogResult.Cancel)
                    e.Cancel = true;
            }
        }



        public void AuthorizeForm()
        {
            BtnSave.Enabled = _pm.IsAuthorized(PermissionManager.WORKSHOP_APPLICATION,
                                                     _wph.ItemName(WorkshopPermissionHelper.Operation.UpdateWorkorder));
            btnNewTask.Enabled = _pm.IsAuthorized(PermissionManager.WORKSHOP_APPLICATION,
                                                     _wph.ItemName(WorkshopPermissionHelper.Operation.AddMaintenanceTask));
            btnDeleteTask.Enabled = _pm.IsAuthorized(PermissionManager.WORKSHOP_APPLICATION,
                                                     _wph.ItemName(WorkshopPermissionHelper.Operation.DeleteMaintenanceTask));
            btnNewLabour.Enabled = _pm.IsAuthorized(PermissionManager.WORKSHOP_APPLICATION,
                                                     _wph.ItemName(WorkshopPermissionHelper.Operation.AddLaborUnit));
            btnDeleteLabour.Enabled = _pm.IsAuthorized(PermissionManager.WORKSHOP_APPLICATION,
                                                     _wph.ItemName(WorkshopPermissionHelper.Operation.DeleteLaborUnit));
            PartsGridView.OptionsBehavior.Editable = _pm.IsAuthorized(PermissionManager.WORKSHOP_APPLICATION,
                                                     _wph.ItemName(WorkshopPermissionHelper.Operation.AddPart));
            btnDeleteParts.Enabled = _pm.IsAuthorized(PermissionManager.WORKSHOP_APPLICATION,
                                                     _wph.ItemName(WorkshopPermissionHelper.Operation.DeletePart));

        }
    }
}