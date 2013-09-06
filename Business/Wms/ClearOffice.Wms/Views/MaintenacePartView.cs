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
    public partial class MaintenacePartView : DevExpress.XtraEditors.XtraForm,IDetailForm
    {
        private WmsEntities _context;
        private MaintenancePart _maintenancePart;
        public WorkOrder WorkOrder { get; set; }
        public MaintenanceTask MaintenanceTask { get; set; }
        public MaintenaceTaskView MaintenaceTaskViewp { get; set; }
        public WorkOrderView WorkOrderViewp { get; set; }
        private bool _newMode;
        private PermissionManager _pm;
        private WorkshopPermissionHelper _wph;
        public MaintenacePartView()
        {
            InitializeComponent();
            _context = new WmsEntities();

            AuthorizeForm();
        }

        public void ShowObject(object keyValue)
        {
            if (keyValue == null)
            {
                if (MaintenanceTask != null)
                {
                    _maintenancePart = new MaintenancePart(){WorkOrderId = this.WorkOrder.WorkOrderId,TaskId = this.MaintenanceTask.TaskId};
                    _newMode = true;
                }
                else
                {
                    _maintenancePart = new MaintenancePart() { WorkOrderId = this.WorkOrder.WorkOrderId};
                    _newMode = true;
                }
                
            }
            else
            {
                _maintenancePart = _context.MaintenanceParts.FirstOrDefault(mp => mp.MaintainedPartId == (int) keyValue);
                _newMode = false;
            }
            MaintaincePartBindingSource.DataSource = _maintenancePart;
            LoadLookup();
        }

        private void LoadLookup()
        {
            PartInfoBindingSource.DataSource = _context.PartListInfoes.ToList();
        }

        public bool DataChanged()
        {
            throw new NotImplementedException();
        }

        public void SaveChanges()
        {
            if(!ValidateForm())
                return;
            MaintaincePartBindingSource.EndEdit();
           _maintenancePart = (MaintenancePart) MaintaincePartBindingSource.DataSource;
            if(_newMode)
                _context.MaintenanceParts.AddObject(_maintenancePart);
            try
            {
                _context.SaveChanges();
                if (MaintenanceTask != null)
                {
                    var maintenaceTaskViewp = this.MaintenaceTaskViewp;
                    if (maintenaceTaskViewp != null)
                    {
                       // maintenaceTaskViewp.AddPart(_maintenancePart);
                        //MaintenaceTaskViewp.PartAdded(true);
                    }
                    var workOrderViewp = this.WorkOrderViewp;
                    if (workOrderViewp != null)
                    {
                        //workOrderViewp.ReloadParts();
                    }
                    Close();
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
            throw new NotImplementedException();
        }

        public bool ValidateForm()
        {
            bool result = true;
            if (partIdLookUpEdit.EditValue == DBNull.Value)
            {
                result = false;
                MaintaincePartErrorProvider.SetError(partIdLookUpEdit,"Part Is Required.");
            }
            return result;
        }

        private void partIdLookUpEdit_EditValueChanged(object sender, EventArgs e)
        {
            if (partIdLookUpEdit.EditValue != DBNull.Value)
            {
                var pid = partIdLookUpEdit.EditValue;
                var firstOrDefault = _context.PartInfoes.FirstOrDefault(p => p.PartId == (int) pid);
                if (firstOrDefault != null)
                    unitCostTextBox.Text = firstOrDefault.UnitCost.ToString();
            }
        }

        private void BtnSave_Click(object sender, EventArgs e)
        {
            SaveChanges();
        }


        public void AuthorizeForm()
        {
            BtnSave.Enabled = _pm.IsAuthorized(PermissionManager.WORKSHOP_APPLICATION,
                                                       _wph.ItemName(WorkshopPermissionHelper.Operation.AddPart));
        }
    }
}