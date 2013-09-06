using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using DevExpress.XtraEditors;
using ClearOffice.Infrastructure;
using ClearOffice.Fleet.Business;

namespace ClearOffice.Fleet.Views
{
    public partial class MaintenanceActivityEdit : DevExpress.XtraEditors.XtraForm, IDetailForm
    {
        private MaintenanceActivity activity;
        private FleetEntities context = new FleetEntities();

        public MaintenanceActivityEdit()
        {
            InitializeComponent();
            activity = new MaintenanceActivity();
            var activityTypes = from at in context.LookupItems where at.LookupId == 3 select at;
            activityTypesBindingSource.DataSource = activityTypes.ToList();
        }

        public void ShowObject(object keyValue)
        {
            if (null != keyValue)
            {
                activity = keyValue as MaintenanceActivity;
            }
            
            activityBindingSource.DataSource = activity;
        }

        public bool DataChanged()
        {
            throw new NotImplementedException();
        }

        public void SaveChanges()
        {
            if (!ValidateForm())
                return;
            this.activityBindingSource.EndEdit();
            this.DialogResult = DialogResult.OK;
        }

        public MaintenanceActivity GetCurrentObject()
        {
            return activity;
        }
        public void DeleteObject()
        {
            throw new NotImplementedException();
        }

        public bool ValidateForm()
        {
            return activity.IsValid();
        }

        public void AuthorizeForm()
        {
            throw new NotImplementedException();
        }

        private void activityBindingSource_CurrentItemChanged(object sender, EventArgs e)
        {
            okCommand.Enabled = activity.IsValid();
        }

        private void cancelCommand_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.Cancel;
        }

        private void okCommand_Click(object sender, EventArgs e)
        {
            SaveChanges();
        }
    }
}