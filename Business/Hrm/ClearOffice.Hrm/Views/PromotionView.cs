using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using ClearOffice.Hrm.Business;
using ClearOffice.Hrm.Business.Data;
using ClearOffice.Infrastructure;
using ClearOffice.Security;
using DevExpress.XtraEditors;

namespace ClearOffice.Hrm.Views
{
    public partial class PromotionView : DevExpress.XtraEditors.XtraForm, IDetailForm
    {
        private ProfileProxy _proxy = new ProfileProxy();
        private Employee _employee { get; set; }
        private EmployeePromotion _promotion;
        private HRMPermissionHelper hph;
        private PermissionManager permissionManager;
        public PromotionView()
        {
            InitializeComponent();
            hph = new HRMPermissionHelper();
            permissionManager = PermissionManager.GetPermissionManager();
            AuthorizeForm();
        }

        public void ShowObject(object keyValue)
        {
            var eid = Convert.ToInt32(keyValue);
            var empl = _proxy.Context.Employees.FirstOrDefault(e => e.EmployeeId == eid);
            if (empl != null)
            {
                _employee = empl;
                employeeBindingSource.DataSource =
                    _proxy.Context.EmployeeInfoes.FirstOrDefault(ei => ei.EmployeeId == eid);

                prevDepartementBindingSource.DataSource = _proxy.Context.Organizations.ToList();
                prevJobBindingSource.DataSource = _proxy.Context.Jobs.ToList();

                prevLocationLookUpEdit.EditValue = empl.NodeId;
                prevJobTitleLookUpEdit.EditValue = empl.JobId;

                newDepartementBindingSource.DataSource = _proxy.Context.Organizations.ToList();
                newTitleBindingSource.DataSource = _proxy.Context.Jobs.ToList();

                var pt = new List<PromotionType>();
                pt.Add(new PromotionType("Promotion", 1));
                pt.Add(new PromotionType("Demotion", 2));
                promoTypeBindingSource.DataSource = pt;
                _promotion = new EmployeePromotion() { IsNew = true, EmployeeId = eid, NewTitle = empl.JobId, NewNode = empl.NodeId, Type = 1 };
                promotionBindingSource.DataSource = _promotion;

            }
        }

        public bool DataChanged()
        {
            return _proxy.IsDirty();
        }

        public void SaveChanges()
        {
            try
            {
                promotionBindingSource.EndEdit();
                var obj = (EmployeePromotion)promotionBindingSource.Current;
                if (obj != null)
                {
                    obj.PreviousNode = _employee.NodeId;
                    obj.PreviousTitle = _employee.JobId;
                    _employee.NodeId = obj.NewNode;
                    _employee.JobId = obj.NewTitle;
                    _proxy.Context.EmployeePromotions.AddObject(obj);
                    _proxy.Save();
                    this.DialogResult = DialogResult.OK;
                }
            }
            catch (Exception exception)
            {
                ViewHelper.ShowErrorMessage("Error occured while adding new employee.", exception);
                this.DialogResult = DialogResult.No;
            }
        }

        public void DeleteObject()
        {
            throw new NotImplementedException();
        }

        public bool ValidateForm()
        {
            throw new NotImplementedException();
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            SaveChanges();
        }

        private void promotionBindingSource_CurrentItemChanged(object sender, EventArgs e)
        {
            var obj = (EmployeePromotion)promotionBindingSource.Current;
            btnSave.Enabled = obj.IsValid();
            AuthorizeForm();
        }


        public void AuthorizeForm()
        {
            btnSave.Enabled = permissionManager.IsAuthorized(PermissionManager.HRM_APPLICATION,
                                                             hph.ItemName(HRMPermissionHelper.Operation.PromoteEmployee));

        }
    }
}