using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using ClearOffice.Infrastructure;
using DevExpress.XtraEditors;
using ClearOffice.Fleet.Business;

namespace ClearOffice.Fleet.Views
{
    public partial class MaintenancePartEdit : DevExpress.XtraEditors.XtraForm, IDetailForm
    {
        private MaintenancePart part;
        public MaintenancePartEdit()
        {
            InitializeComponent();
            part = new MaintenancePart();
        }

        public void ShowObject(object keyValue)
        {
            if (null != keyValue)
            {
                part = keyValue as MaintenancePart;
            }

            partBindingSource.DataSource = part;
        }

        public bool DataChanged()
        {
            throw new NotImplementedException();
        }

        public void SaveChanges()
        {
            if (!ValidateForm())
                return;
            this.partBindingSource.EndEdit();
            this.DialogResult = DialogResult.OK;
        }

        public MaintenancePart GetCurrentObject()
        {
            return part;
        }
        public void DeleteObject()
        {
            throw new NotImplementedException();
        }

        public bool ValidateForm()
        {
            return part.IsValid();
        }

        public void AuthorizeForm()
        {
            throw new NotImplementedException();
        }

        private void partBindingSource_CurrentItemChanged(object sender, EventArgs e)
        {
            saveCommand.Enabled = part.IsValid();
        }

        private void saveCommand_Click(object sender, EventArgs e)
        {
            SaveChanges();
        }

        private void cancelCommand_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.Cancel;
        }
    }
}