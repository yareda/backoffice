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
    public partial class NewTrainingRequestView : DevExpress.XtraEditors.XtraForm ,IDetailForm  
    {
        private TrainingProxy _proxy;
        private TrainingRequest trainingRequest;
        private PermissionManager permissionManager;
        private HRMPermissionHelper hph;
        public NewTrainingRequestView()
        {
            InitializeComponent();
            _proxy = new TrainingProxy();
            hph = new HRMPermissionHelper();
            permissionManager = PermissionManager.GetPermissionManager();
            AuthorizeForm();
        }

        public void ShowObject(object keyValue)
        {
            trainingRequest =new TrainingRequest();
            trainingRequestBindingSource.DataSource = trainingRequest;
            trainingCategoryBindingSource.DataSource = _proxy.Context.TrainingCategories.ToList();
        }

        public bool DataChanged()
        {
            throw new NotImplementedException();
        }

        public void SaveChanges()
        {
            trainingRequestBindingSource.EndEdit();
            trainingRequest = (TrainingRequest) trainingRequestBindingSource.Current;
            try
            {
                 var t = new Training();
                 trainingRequest.trainings.Add(t);
                 trainingRequest.Status = Training.StatusPending;
                _proxy.Context.TrainingRequests.AddObject(trainingRequest);
                _proxy.Save();
                this.DialogResult = DialogResult.OK;
                Close();
            }
            catch (Exception exception)
            {
              ViewHelper.ShowErrorMessage("Error occured when savind training request",exception);
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

        private void btnSaveTrainingRequest_Click(object sender, EventArgs e)
        {
            SaveChanges();
        }

        private void btnCancelRequest_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.Cancel;
            this.Close();
        }

        private void trainingRequestBindingSource_CurrentItemChanged(object sender, EventArgs e)
        {
            var trainingreq = (TrainingRequest)trainingRequestBindingSource.Current;
            this.btnSaveTrainingRequest.Enabled = trainingreq.IsValid();
            AuthorizeForm();
        }

        private void addTrainingCategoryHyperLinkEdit_Click(object sender, EventArgs e)
        {
            var picker = new Lookup.TrainingCategoryView();
            picker.ShowList();
            var result = picker.ShowDialog(this);
            if (result == DialogResult.OK)
            {
                var store = new LookupProxy();
                this.trainingCategoryBindingSource.DataSource = store.Context.TrainingCategories.ToList();
            }
        }


        public void AuthorizeForm()
        {
            btnSaveTrainingRequest.Enabled = permissionManager.IsAuthorized(PermissionManager.HRM_APPLICATION,
                                                                            hph.ItemName(
                                                                                HRMPermissionHelper.Operation.
                                                                                    AddTrainingRequest));
            addTrainingCategoryHyperLinkEdit.Enabled = permissionManager.IsAuthorized(
                PermissionManager.HRM_APPLICATION, hph.ItemName(HRMPermissionHelper.Operation.AddLookupItem));
        }
    }
}