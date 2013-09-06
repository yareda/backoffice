using System;
using System.Data;
using System.Windows.Forms;
using ClearOffice.Security;
using DevExpress.XtraBars.Ribbon;
using DevExpress.XtraEditors;
using ClearOffice.Infrastructure;
using ClearOffice.Fleet.Business;
using System.Linq;
using ClearOffice.Fleet.Properties;
namespace ClearOffice.Fleet.Views
{
    public partial class MaintenanceEdit : XtraForm, IDetailForm
    {
        private FleetEntities context= new FleetEntities();
        private Maintanance maintenance;
        private bool cancelChanges;
        private PermissionManager _pm;
        private FleetPermissionHelper _fph;
        public MaintenanceEdit()
        {
            InitializeComponent();
            LoadLookupData();
            
            
            var margin = 10;
            this.Top = ViewHelper.TopPositionForForm(margin);
            this.Left = ViewHelper.TopPositionForForm(margin);
            this.Height = ViewHelper.GetHeightForForm(margin);
            this.Width = ViewHelper.GetWidthForForm(margin);

            _pm = PermissionManager.GetPermissionManager();
            _fph = new FleetPermissionHelper();

            AuthorizeForm();
        }

        private void LoadLookupData()
        {
            var serviceProviders = from sp in context.LookupItems where sp.LookupId == 5 select sp;
            serviceTypeBindingSource.DataSource = serviceProviders.ToList();

            var activityTypes = from at in context.LookupItems where at.LookupId == 3 select at;
            activityTypesBindingSource.DataSource = activityTypes.ToList();

            var paymentTypes = from pt in context.LookupItems where pt.LookupId == 4 select pt;
            paymentTypesBindingSource.DataSource = paymentTypes.ToList();
        }

        public void ShowObject(object keyValue)
        {
            // If the incoming parameter is null then we must short circuit and exit the method.
            if(null==keyValue) return;

            // If the type of keyValue parameter is VehicleInfo then we are adding a new Maintenance record. This
            // could happen when the user clicks 'New Maintenance' button from the ribbon form. Other wise it it
            // should be of type 'Maintenance'.
            try
            {
                if (keyValue.GetType() == typeof(VehicleInfo))
                {
                    var vehicle = keyValue as VehicleInfo;
                    maintenance = new Maintanance { VehicleId = vehicle.VehicleId };
                }
                else
                {
                    var info = keyValue as MaintenanceInfo;
                    maintenance = context.Maintanances.Single(m=>m.MaintenanceId==info.MaintenanceId);
                }
                this.maintenanceBindingSource.DataSource = maintenance;
                this.maintenancePartsBindingSource.DataSource = maintenance.MaintenanceParts;
                this.activitiesBindingSource.DataSource = maintenance.MaintenanceActivities;
                this.expenseBindingSource.DataSource = maintenance.Expenses;
            }
            catch (Exception e)
            {
                ViewHelper.ShowErrorMessage("Error loading Maintenance record.");
                ErrorLogger.LogError(this,e);
                return;
            }
        }

        public bool DataChanged()
        {
            return context.ObjectStateManager.GetObjectStateEntries(EntityState.Added | EntityState.Modified | EntityState.Deleted).Any();
        }

        public void SaveChanges()
        {
            if (!ValidateForm())
                return;

            maintenanceBindingSource.EndEdit();
            maintenancePartsBindingSource.EndEdit();
            activitiesBindingSource.EndEdit();
            expenseBindingSource.EndEdit();

            try
            {
                //Save the changes to the database through the context
                context.SaveChanges();
            }
            catch (Exception e)
            {
                ViewHelper.ShowErrorMessage(@"Error saving Maintenance information.");
                ErrorLogger.LogError(this, e);
            }
        }

        public void DeleteObject()
        {
            var confirm = MessageBox.Show(@"Deleting the current Maintenance will remove records all associated with it. Do you want to continue?", Resources.DELETE_TITLE,
                  MessageBoxButtons.YesNoCancel, MessageBoxIcon.Warning);

            if (confirm == DialogResult.Yes)
                if (FleetHelper.DeleteMaintenance(maintenance.MaintenanceId))
                    this.Close();
        }

        public bool ValidateForm()
        {
            return maintenance.IsValid();
        }

        private void MaintenanceEdit_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (!cancelChanges)
            {
                if (this.DataChanged())
                {
                    var response = MessageBox.Show(Resources.DATA_CHANGE_MESSAGE, Resources.DATA_CHANGE_TITLE,
                                                   MessageBoxButtons.YesNoCancel, MessageBoxIcon.Exclamation);

                    switch (response)
                    {
                        case DialogResult.Yes:
                            SaveChanges();
                            break;
                        case DialogResult.Cancel:
                            e.Cancel = true;
                            break;
                    }
                }
            }
        }

        private void maintenanceBindingSource_CurrentItemChanged(object sender, EventArgs e)
        {
            saveBarButtonItem.Enabled = this.DataChanged();

            AuthorizeForm();
        }

        public void AuthorizeForm()
        {
            saveBarButtonItem.Enabled = _pm.IsAuthorized(PermissionManager.FLEET_APPLICATION, _fph.ItemName(
                FleetPermissionHelper.Operation.UpdateMaintenanceRecord));
            deleteBarButtonItem.Enabled = _pm.IsAuthorized(PermissionManager.FLEET_APPLICATION, _fph.ItemName(
                FleetPermissionHelper.Operation.DeleteMaintenance));
        }

        private void MaintenanceEdit_Activated(object sender, EventArgs e)
        {
            var p = this.MdiParent as RibbonForm;
            if (p != null)
            {
                p.Ribbon.SelectedPage = p.Ribbon.Pages[Constants.FLEET_RIBBON_NAME];
            }
        }

        private void saveBarButtonItem_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            SaveChanges();
        }

        private void deleteBarButtonItem_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            DeleteObject();
        }

        private void partsGridControl_DoubleClick(object sender, EventArgs e)
        {
            var selected = maintenancePartsBindingSource.Current as MaintenancePart;
            var dialog = new MaintenancePartEdit();
            dialog.ShowObject(selected);
            dialog.ShowDialog(this);            
        }

        private void addPartBarButtonItem_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {            
            var dialog = new MaintenancePartEdit();
            dialog.ShowObject(null);
            var result = dialog.ShowDialog(this);
            if(result==DialogResult.OK)
            {
                var item = dialog.GetCurrentObject();
                this.maintenance.MaintenanceParts.Add(item);
            }
        }

        private void activityGridControl_DoubleClick(object sender, EventArgs e)
        {
            var selected = activitiesBindingSource.Current as MaintenanceActivity;
            var dialog = new MaintenanceActivityEdit();
            dialog.ShowObject(selected);
            dialog.ShowDialog(this);
        }

        private void addActivityBarButtonItem_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            var dialog = new MaintenanceActivityEdit();
            dialog.ShowObject(null);
            var result = dialog.ShowDialog(this);
            if (result == DialogResult.OK)
            {
                var item = dialog.GetCurrentObject();
                this.maintenance.MaintenanceActivities.Add(item);
            }
        }

        private void expenseGridControl_DoubleClick(object sender, EventArgs e)
        {
            var selected = expenseBindingSource.Current as Expense;
            var dialog = new ExpenseEdit();
            dialog.ShowObject(selected);
            dialog.ShowDialog(this);
        }

        private void addExpenseBarButtonItem_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            var dialog = new ExpenseEdit();
            var expense = new Expense();
            expense.VehicleId = maintenance.VehicleId;

            dialog.ShowObject(expense);
            var result = dialog.ShowDialog(this);
            if (result == DialogResult.OK)
            {                
                this.maintenance.Expenses.Add(expense);
            }
        }
    }
}