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
    public partial class TrainingDetailView : DevExpress.XtraEditors.XtraForm, IDetailForm
    {
        private TrainingProxy _proxy = new TrainingProxy();
        private Training _training { get; set; }
        private TrainingRequest _request { get; set; }
        private HRMPermissionHelper hph;
        private PermissionManager permissionManager;
        public TrainingDetailView()
        {
            InitializeComponent();
            hph = new HRMPermissionHelper();
            permissionManager = PermissionManager.GetPermissionManager();
            AuthorizeForm();
        }

        public void ShowObject(object keyValue)
        {
            if (keyValue != null)
            {
                var tid = Convert.ToInt32(keyValue);
                var training = _proxy.Context.Trainings.FirstOrDefault(tr => tr.TrainingId == tid);
                if (training != null)
                {
                    _training = training;
                    trainingBindingSource.DataSource = _training;

                    _request = _proxy.Context.TrainingRequests.FirstOrDefault(
                            tr => tr.TrainingRequestId == training.TrainingRequestId);


                    trainingRequestBindingSource.DataSource = _request;

                    atendeeBindingSource.DataSource =
                        _proxy.Context.TrainingAttendanceInfoes.Where(ta => ta.TrainingId == training.TrainingId);

                    feedBackListBindingSource.DataSource = _training.TrainingFeedback;

                    LoadLookup();
                }
            }
        }

        private void LoadLookup()
        {
            trainingCategoryBindingSource.DataSource = _proxy.Context.TrainingCategories.ToList();
            var status = new List<TrainingStatus>();
            status.Add(new TrainingStatus(0, "Pending"));
            status.Add(new TrainingStatus(1, "Approved"));
            status.Add(new TrainingStatus(2, "Conducted"));
            trainStatusBindingSource.DataSource = status;
        }

        public bool DataChanged()
        {
            throw new NotImplementedException();
        }

        public void SaveChanges()
        {
            trainingBindingSource.EndEdit();
            try
            {
                _proxy.Save();
                //saveBarButton.Enabled = false;
            }
            catch (Exception exception)
            {
                ViewHelper.ShowErrorMessage("Error has occured while saving the training information.", exception);
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

        private void trainingBindingSource_CurrentItemChanged(object sender, EventArgs e)
        {
            saveBarButton.Enabled = _proxy.EntityStateChanged(_training);
            AuthorizeForm();
        }

        private void approveBarButton_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            var result = ViewHelper.ShowConfirmDialog("Are you sure you want to approve this training?");
            if (result == DialogResult.Yes)
            {
                try
                {
                    _request.Status = Training.StatusApproved;
                    _training.ApprovedDate = DateTime.Today;
                    _training.ApprovedBy = "#####";
                    _proxy.Save();
                }
                catch (Exception exception)
                {
                    ViewHelper.ShowErrorMessage("Error has occured while approving the current training.", exception);
                }
            }
        }

        private void addFeedBackBarButton_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            var fv = new TrainingFeedbackView();
            fv.ShowObject(null);
            var result = fv.ShowDialog();
            if (result == DialogResult.OK)
            {
                _training.TrainingFeedback.Add(fv.FeedBack);
            }
        }

        private void selectAttendeeBarButton_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            var av = new TrainingAttendanceView();
            av.ShowObject(_training.TrainingId);
            var result = av.ShowDialog();
            if (result == DialogResult.OK)
            {
                var p = new TrainingProxy();
                atendeeBindingSource.DataSource =
                p.Context.TrainingAttendanceInfoes.Where(ta => ta.TrainingId == _training.TrainingId);
            }
        }

        private void saveBarButton_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            SaveChanges();
        }

        private void gridControl2_DoubleClick(object sender, EventArgs e)
        {
            var obj = (TrainingFeedback)feedBackListBindingSource.Current;
            var fv = new TrainingFeedbackView();
            fv.ShowObject(obj);
            fv.ShowDialog();
            AuthorizeForm();
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            var obj = (TrainingFeedback)feedBackListBindingSource.Current;
            if (obj != null)
            {
                _training.TrainingFeedback.Remove(obj);
            }
        }

        private void trainingRequestBindingSource_CurrentItemChanged(object sender, EventArgs e)
        {
            saveBarButton.Enabled = _proxy.EntityStateChanged(_request);
            approveBarButton.Enabled = _request.Status == Training.StatusPending;
            approvalRemarkMemoEdit.Enabled = _request.Status == Training.StatusApproved;
            conductedByTextEdit.Enabled = _request.Status == Training.StatusApproved;
            conductedFromDateEdit.Enabled = _request.Status == Training.StatusApproved;
            conductedToDateEdit.Enabled = _request.Status == Training.StatusApproved;
            AuthorizeForm();
        }

        private void feedBackListBindingSource_ListChanged(object sender, ListChangedEventArgs e)
        {
            saveBarButton.Enabled = true;
        }

        private void deleteBarButton_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            var result = ViewHelper.ShowConfirmDialog("Are you sure you want to delete this training.");
            if(result == DialogResult.Yes)
            {
                try
                {
                    var obj = _proxy.Context.Trainings.FirstOrDefault(tr => tr.TrainingId == _training.TrainingId);
                    _proxy.Context.Trainings.DeleteObject(obj);
                    _proxy.Save();  
                    this.Close();
                }
                catch(Exception exception)
                {
                    ViewHelper.ShowErrorMessage("Error has occured while deleting the selected training information.",exception);
                }
            }
        }

        private void addNewCategoryhyperLinkEdit_Click(object sender, EventArgs e)
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
            saveBarButton.Enabled = permissionManager.IsAuthorized(PermissionManager.HRM_APPLICATION,
                                                                   hph.ItemName(
                                                                       HRMPermissionHelper.Operation.UpdateTraining));
            deleteBarButton.Enabled = permissionManager.IsAuthorized(PermissionManager.HRM_APPLICATION,
                                                                     hph.ItemName(
                                                                         HRMPermissionHelper.Operation.
                                                                             DeleteTrainingRequest));
            approveBarButton.Enabled = permissionManager.IsAuthorized(PermissionManager.HRM_APPLICATION,
                                                                      hph.ItemName(
                                                                          HRMPermissionHelper.Operation.ApproveTraining));
            addFeedBackBarButton.Enabled = permissionManager.IsAuthorized(PermissionManager.HRM_APPLICATION,
                                                                          hph.ItemName(
                                                                              HRMPermissionHelper.Operation.
                                                                                  AddTrainingFeedback));
            addNewCategoryhyperLinkEdit.Enabled = permissionManager.IsAuthorized(PermissionManager.HRM_APPLICATION,
                                                                                 hph.ItemName(
                                                                                     HRMPermissionHelper.Operation.
                                                                                         AddLookupItem));
            selectAttendeeBarButton.Enabled = permissionManager.IsAuthorized(PermissionManager.HRM_APPLICATION,
                                                                             hph.ItemName(
                                                                                 HRMPermissionHelper.Operation.
                                                                                     AddTrainingAttendee));

        }
    }
}