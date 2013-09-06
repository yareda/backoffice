using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using ClearOffice.Hrm.Business;
using ClearOffice.Hrm.Business.Data;
using ClearOffice.Infrastructure;
using ClearOffice.Security;
using DevExpress.XtraEditors;
using System.Linq;
namespace ClearOffice.Hrm.Views
{
    public partial class JobView : DevExpress.XtraEditors.XtraForm, IDetailForm
    {
        private JobProxy _proxy = new JobProxy();
        private Job _job { get; set; }
        private bool _newMode;
        private PermissionManager permissionManager;
        private HRMPermissionHelper hph;
        public JobListView JobListView { get; set; }
        public JobView()
        {
            InitializeComponent();
            hph = new HRMPermissionHelper();
            permissionManager = PermissionManager.GetPermissionManager();
            AuthorizeForm();
        }

        public void ShowObject(object keyValue)
        {
            if (keyValue == null)
            {
                //if it is a new mode
                _job = new Job();
                _newMode = true;
                btnSave.Enabled = true;
                btnDelete.Enabled = false;
            }
            else
            {
                var obj = (Job)keyValue;
                _job = _proxy.Context.Jobs.FirstOrDefault(j => j.JobId == obj.JobId);
                _newMode = false;
                //btnSave.Enabled = true;
                btnDelete.Enabled = true;
            }

            LoadData();
        }

        private void LoadData()
        {
            jobBindingSource.DataSource = _job;
            competencyBindingSource.DataSource = _job.JobCompetencies;
            jobFunctionsBindingSource.DataSource = _job.JobFunctions;
            jobSkillsBindingSource.DataSource = _job.JobSkills;

            cometencyTypeListBindingSource.DataSource = _proxy.Context.CompetencyTypes;
            skillTypeBindingSource.DataSource = _proxy.Context.EmployeeSkillTypes.ToList();
            departementsBindingSource.DataSource = _proxy.Context.Organizations.ToList();
        }

        public bool DataChanged()
        {
            return _proxy.IsDirty();
        }

        public void SaveChanges()
        {
            jobBindingSource.EndEdit();
            jobFunctionsBindingSource.EndEdit();
            competencyBindingSource.EndEdit();
            jobSkillsBindingSource.EndEdit();
            if (_newMode)
               _proxy.Context.Jobs.AddObject(_job);
                try
                {

                   _proxy.Save();

                   if (JobListView != null)
                       JobListView.RefreshList();
                   _newMode = false;
                   btnDelete.Enabled = true;
                   btnSave.Enabled = false;
               }
               catch (Exception exception)
               {
                   ViewHelper.ShowErrorMessage("Error occured while saving the given job." ,exception);
               }
        }

        public void DeleteObject()
        {
            var obj = _proxy.Context.Jobs.FirstOrDefault(j => j.JobId == _job.JobId);
            _proxy.Context.Jobs.DeleteObject(obj);
            _proxy.Save();
        }

        public bool ValidateForm()
        {
            throw new NotImplementedException();
        }

        private void btnSave_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            SaveChanges();
        }

        private void btnDeleteComp_Click(object sender, EventArgs e)
        {
            var comp = (JobCompetency)competencyBindingSource.Current;
            _job.JobCompetencies.Remove(comp);
        }

        private void btnDeleteJobFun_Click(object sender, EventArgs e)
        {
            var jfun = (JobFunction)jobFunctionsBindingSource.Current;
            _job.JobFunctions.Remove(jfun);
        }

        private void btnDeleteJobSkill_Click(object sender, EventArgs e)
        {
            var jS = (JobSkill)jobSkillsBindingSource.Current;
            _job.JobSkills.Remove(jS);
        }

        private void jobBindingSource_CurrentItemChanged(object sender, EventArgs e)
        {
            if (!_newMode)
                btnSave.Enabled = DataChanged();
            btnSave.Enabled = true;
        }

        private void btnDelete_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            var result = ViewHelper.ShowConfirmDialog("Are you sure you want to delete this Job?");
            if (result == DialogResult.Yes)
            {
                try
                {
                    DeleteObject();
                    Close();
                    JobListView.RefreshList();
                }
                catch (Exception)
                {
                    ViewHelper.ShowDeleteError();
                    return;
                }
            }
        }

        private void JobView_FormClosing(object sender, FormClosingEventArgs e)
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
                        ViewHelper.ShowErrorMessage("Error occured while saving the given job");
                    }
                    JobListView.RefreshList();
                    this.Close();
                }
                else if (result == DialogResult.Cancel)
                    e.Cancel = true;
            }
        }

        private void addNewCompetencyType_Click(object sender, EventArgs e)
        {
            var comptype = new Lookup.CompetencyTypeView();
            comptype.ShowList();
            var result = comptype.ShowDialog(this);

            if (result == DialogResult.OK)
            {
                var store = new LookupProxy();
                this.cometencyTypeListBindingSource.DataSource = store.Context.CompetencyTypes.ToList();
            }

        }

        private void addNewSkillType_Click(object sender, EventArgs e)
        {
            var skilltype = new Lookup.EmployeeSkillTypeView();
            skilltype.ShowList();
            var result = skilltype.ShowDialog(this);
            if (result == DialogResult.OK)
            {
                var store = new LookupProxy();
                this.skillTypeBindingSource.DataSource = store.Context.EmployeeSkillTypes.ToList();
            }
        }


        public void AuthorizeForm()
        {
            btnSave.Enabled = permissionManager.IsAuthorized(PermissionManager.HRM_APPLICATION,
                                                             hph.ItemName(HRMPermissionHelper.Operation.UpdatePosition));
            btnDelete.Enabled = permissionManager.IsAuthorized(PermissionManager.HRM_APPLICATION,
                                                               hph.ItemName(HRMPermissionHelper.Operation.DeletePosition));
            addNewSkillType.Enabled = permissionManager.IsAuthorized(PermissionManager.HRM_APPLICATION,
                                                                     hph.ItemName(
                                                                         HRMPermissionHelper.Operation.AddLookupItem));
            addNewCompetencyType.Enabled = permissionManager.IsAuthorized(PermissionManager.HRM_APPLICATION,
                                                                          hph.ItemName(
                                                                              HRMPermissionHelper.Operation.
                                                                                  AddLookupItem));

        }
    }
}