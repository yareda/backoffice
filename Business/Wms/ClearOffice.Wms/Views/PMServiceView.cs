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
    public partial class PMServiceView : DevExpress.XtraEditors.XtraForm,IDetailForm
    {
        private WmsEntities _context;
        private PmService _pmService;
        private bool _newMode = true;
        public PMServiceListView ListView;
        private PermissionManager _pm;
        private WorkshopPermissionHelper _wph;
        public PMServiceView()
        {
            InitializeComponent();
            _context = new WmsEntities();
            _pm = PermissionManager.GetPermissionManager();
            _wph = new WorkshopPermissionHelper();

            AuthorizeForm();
        }

        public void ShowObject(object keyValue)
        {
            if (keyValue == null)
            {
                _pmService = new PmService();
                pmserviceBindingSource.DataSource = _pmService;
                pmPartsBindingSource.DataSource = _pmService.Parts;
                _newMode = true;
            }
            else
            {
                _pmService = _context.PmServices.FirstOrDefault(p=>p.PmServiceId ==((PmService) keyValue).PmServiceId);
                pmserviceBindingSource.DataSource = _pmService;
                pmPartsBindingSource.DataSource = _pmService.Parts;

                if (_pmService.RecurringDate != null || _pmService.FixedDate != null)
                {
                    rgTrackingMode.EditValue = 1;
                    if (_pmService.RecurringDate != null)
                    {
                        RGDateTracking.EditValue = 1;
                    }
                    else
                    {
                        RGDateTracking.EditValue = 2;
                    }
                }
                else if (_pmService.RecurringHour != null || _pmService.FixedHour != null)
                {
                    rgTrackingMode.EditValue = 2;
                    if (_pmService.RecurringHour != null)
                    {
                        RGMileageTracking.EditValue = 1;
                    }
                    else
                    {
                        RGMileageTracking.EditValue = 2;
                    }
                }

                _newMode = false;
                btnDelete.Enabled = true;
            }
            LoadLookups();
        }

        private void LoadLookups()
        {
            catagoryBindingSource.DataSource =
                _context.LookupItems.Where(l => l.LookupId == (int) LookupItems.PmServiceType);
            var pr = from v in _context.LookupItems where v.LookupId == 12 select v;
            priorityBindingSource.DataSource = pr.ToList();
               
            partInfoBindingSource.DataSource = _context.PartInfoes.ToList();

            var dt = new List<DurationType>();
            dt.Add(new DurationType(1,"Day"));
            dt.Add(new DurationType(2,"Month"));
            dt.Add(new DurationType(3,"Year"));
            durationTypeBindingSource.DataSource = dt;
            LERecurringType.SelectedValue = 1;
        }

        public bool DataChanged()
        {
            return _context.ObjectStateManager.GetObjectStateEntries(EntityState.Added | EntityState.Modified | EntityState.Deleted).Any();
        }

        public void SaveChanges()
        {
            if(!ValidateForm())
                return;
            pmserviceBindingSource.EndEdit();
            pmPartsBindingSource.EndEdit();

            if (Convert.ToInt32(rgTrackingMode.EditValue) == 1)
            {
                if (!RGDateTracking.EditValue.Equals(DBNull.Value))
                {
                    if (Convert.ToInt32(RGDateTracking.EditValue) == 1)
                    {

                        //calculate the date
                        _pmService.RecurringDate = CalculateDate(_pmService.RecurringDate, (int)LERecurringType.SelectedValue);
                        _pmService.FixedDate = null;
                    }
                    else
                    {
                        _pmService.RecurringDate = null;
                    }
                    _pmService.RecurringHour = null;
                    _pmService.FixedHour = null;
                }
            }
            //if it's houre tracked.
            else if (Convert.ToInt32(rgTrackingMode.EditValue) == 2)
            {
                if (!RGMileageTracking.EditValue.Equals(DBNull.Value))
                {
                    if (Convert.ToInt32(RGMileageTracking.EditValue) == 1)
                    {
                        _pmService.FixedHour = null;
                    }
                    else
                    {
                        _pmService.RecurringHour = null;
                    }
                    _pmService.RecurringDate = null;
                    _pmService.FixedDate = null;
                }
            }

            if(_newMode)
                _context.PmServices.AddObject(_pmService);
            try
            {
                _context.SaveChanges();
                btnSave.Enabled = false;
                ShowObject(_pmService);
                ListView.RefreshList();

            }
            catch (Exception)
            {
                ViewHelper.ShowSaveError();
                return;
            }    
        }

        public void DeleteObject()
        {
            try
            {
                _context.PmServices.DeleteObject(_pmService);
                _context.SaveChanges();
                Close();
                ListView.RefreshList();
            }
            catch (Exception)
            {
                ViewHelper.ShowDeleteError();
                return;
            }
        }

        public bool ValidateForm()
        {
            bool result = true;
            if (taskNameTextBox.Text == string.Empty)
            {
                pmserviceErrorProvider.SetError(taskNameTextBox,"Service Is Required.");
                result = false;
            }
            return result;
        }
        private void EnableFixedDateTxtBox()
        {
            recurringDateTextBox.Enabled = false;
            recurringDateTextBox.Text = string.Empty;
            LERecurringType.Enabled = false;
            fixedDateDateEdit.Enabled = true;
            fixedDateDateEdit.EditValue = _pmService.FixedDate;
        }

        private void EnableRecurringDateTxtBox()
        {
            recurringDateTextBox.Enabled = true;
            recurringDateTextBox.Text = _pmService.RecurringDate.ToString();
            LERecurringType.Enabled = true;
            fixedDateDateEdit.Enabled = false;
            fixedDateDateEdit.Text = string.Empty;
        }

        private void EnableFixedHoursTxtBox()
        {
            recurringHourTextBox.Enabled = false;
            recurringDateTextBox.Text = string.Empty;
            fixedHourTextBox.Enabled = true;
        }

        private void EnableRecurringHourTxtBox()
        {
            recurringHourTextBox.Enabled = true;
            fixedHourTextBox.Enabled = false;
            fixedHourTextBox.Text = string.Empty;
        }

        private void saveToolStripButton_Click(object sender, EventArgs e)
        {
            SaveChanges();
        }

        internal int CalculateDate(int? value, int recurringType)
        {
            var v = value ?? 0;
            if (recurringType == 1)//if it is in date.
                return v;
            if (recurringType == 2)//if it is in month.
                return v * 30;
            else
                //if it is in year.
                return v * 365;
        }

        private void RGDateTracking_EditValueChanged(object sender, EventArgs e)
        {
            var value = RGDateTracking.EditValue;
            if (value != DBNull.Value)
            {
                if (Convert.ToInt32(value) == 1)
                {
                    EnableRecurringDateTxtBox();
                }
                else if (Convert.ToInt32(value) == 2)
                {
                    EnableFixedDateTxtBox();
                }
            }
        }

        private void RGMileageTracking_EditValueChanged(object sender, EventArgs e)
        {
            var value = RGMileageTracking.EditValue;
            if (value != DBNull.Value)
            {
                if (Convert.ToInt32(value) == 1)
                {
                    EnableRecurringHourTxtBox();
                }
                if (Convert.ToInt32(value) == 2)
                {
                    EnableFixedHoursTxtBox();
                }
            }
        }

        private void rgTrackingMode_EditValueChanged(object sender, EventArgs e)
        {
            if (rgTrackingMode.EditValue != DBNull.Value)
            {
                if (Convert.ToInt32(rgTrackingMode.EditValue) == 1)
                {
                    GBDateTracking.Enabled = true;
                    recurringDateTextBox.Text = _pmService.RecurringDate.ToString();
                    fixedDateDateEdit.EditValue = _pmService.FixedDate;
                    GBHoursTracking.Enabled = false;
                    recurringHourTextBox.Text = string.Empty;
                    fixedHourTextBox.Text = string.Empty;
                }
                else
                {
                    GBDateTracking.Enabled = false;
                    recurringDateTextBox.Text = string.Empty;
                    fixedDateDateEdit.EditValue = string.Empty;
                    GBHoursTracking.Enabled = true;
                    recurringHourTextBox.Text = _pmService.RecurringHour;
                    fixedHourTextBox.Text = _pmService.FixedHour;
                }
            }
        }

        private void pmserviceBindingSource_CurrentItemChanged(object sender, EventArgs e)
        {
            if (!_newMode)
            {
                btnSave.Enabled = DataChanged();
            }
            AuthorizeForm();
        }
        private void btnDelete_Click(object sender, EventArgs e)
        {
            var result = ViewHelper.ShowConfirmDialog("Are you sure you want to delete this PM service ?");
            if (result == DialogResult.Yes)
            {
                DeleteObject();

            }
        }

        public void AuthorizeForm()
        {
            btnSave.Enabled = _pm.IsAuthorized(PermissionManager.WORKSHOP_APPLICATION,
                                                      _wph.ItemName(WorkshopPermissionHelper.Operation.UpdatePMService));
            btnDelete.Enabled = _pm.IsAuthorized(PermissionManager.WORKSHOP_APPLICATION,
                                                     _wph.ItemName(WorkshopPermissionHelper.Operation.DeletePMService));
        }
    }
}