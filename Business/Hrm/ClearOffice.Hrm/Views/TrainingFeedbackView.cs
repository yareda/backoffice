using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using ClearOffice.Hrm.Business.Data;
using ClearOffice.Infrastructure;
using ClearOffice.Security;
using DevExpress.XtraEditors;

namespace ClearOffice.Hrm.Views
{
    public partial class TrainingFeedbackView : DevExpress.XtraEditors.XtraForm,IDetailForm
    {
        public TrainingFeedback FeedBack { get; set; }
        private HRMPermissionHelper hph;
        private PermissionManager permissionManager;
        public TrainingFeedbackView()
        {
            InitializeComponent();
            hph = new HRMPermissionHelper();
            permissionManager = PermissionManager.GetPermissionManager();
            AuthorizeForm();
        }

        public void ShowObject(object keyValue)
        {
            if(keyValue == null)
                FeedBack = new TrainingFeedback();
            else
                FeedBack = (TrainingFeedback) keyValue;

            feedBackBindingSource.DataSource = FeedBack;
        }

        public bool DataChanged()
        {
            throw new NotImplementedException();
        }

        public void SaveChanges()
        {
            feedBackBindingSource.EndEdit();
            FeedBack = (TrainingFeedback) feedBackBindingSource.Current;
            this.DialogResult = DialogResult.OK;
        }

        public void DeleteObject()
        {
            throw new NotImplementedException();
        }

        public bool ValidateForm()
        {
            throw new NotImplementedException();
        }

        private void simpleButton1_Click(object sender, EventArgs e)
        {
            SaveChanges();
        }

        private void simpleButton2_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.Cancel;
            Close();
        }


        public void AuthorizeForm()
        {
            simpleButton1.Enabled = permissionManager.IsAuthorized(PermissionManager.HRM_APPLICATION,
                                                                   hph.ItemName(
                                                                       HRMPermissionHelper.Operation.AddTrainingFeedback));

        }
    }
}