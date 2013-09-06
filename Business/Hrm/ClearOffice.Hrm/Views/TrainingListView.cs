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
using DevExpress.XtraEditors;

namespace ClearOffice.Hrm.Views
{
    public partial class TrainingListView : DevExpress.XtraEditors.XtraForm ,IListForm
    {
        private TrainingProxy _proxy;
        public TrainingListView()
        {
            InitializeComponent();
            _proxy =new TrainingProxy();
        }

        public void ShowList()
        {
            var availabletrainings = _proxy.Context.TrainingInfoes.ToList();
            trainingInfoBindingSource.DataSource = availabletrainings;
        }

        public void OpenSelectedItem()
        {
            throw new NotImplementedException();
        }

        public object GetSelectedItem()
        {
            throw new NotImplementedException();
        }

        public void RefreshList()
        {
            throw new NotImplementedException();
        }



        private void gridControl1_DoubleClick(object sender, EventArgs e)
        {
            var obj = (TrainingInfo)trainingInfoBindingSource.Current;
            var training = _proxy.Context.Trainings.FirstOrDefault(tr => tr.TrainingId == obj.TrainingId);
            if (training != null)
            {
                var tdv = new TrainingDetailView();
                tdv.ShowObject(Convert.ToInt32(training.TrainingId));
                tdv.MdiParent = this.MdiParent;
                tdv.Show();
            }
        }

        private void newTrainingRequest_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            NewTrainingRequest();
        }

        private void NewTrainingRequest()
        {
            var newtraining = new NewTrainingRequestView();
            newtraining.ShowObject(null);
            var result = newtraining.ShowDialog();
            if(result ==DialogResult.OK)
                ShowList();
        }

        private void showAllbarButtonItem_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            ShowList();
        }



        public void AuthorizeForm()
        {
            throw new NotImplementedException();
        }
    }
}