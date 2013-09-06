using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using DevExpress.XtraEditors;
using ClearOffice.Infrastructure;
using ClearOffice.Security.Data;

namespace ClearOffice.Security.Views
{
    public partial class CreateUserView : DevExpress.XtraEditors.XtraForm, IDetailForm
    {
        private ClearOfficeEntities context;
        private PermissionManager permissionManager;
        private AdministrationPermissionHelper aph;


        public CreateUserView()
        {
            InitializeComponent();
            context = new ClearOfficeEntities();
            permissionManager = PermissionManager.GetPermissionManager();
            aph = new AdministrationPermissionHelper();
            AuthorizeForm();
        }

        public void ShowObject(object keyValue)
        {
            var user = new User();
            userDetailBindingSource.DataSource = user;
        }

        public bool DataChanged()
        {
            throw new NotImplementedException();
        }

        public void SaveChanges()
        {
            try
            {
                userDetailBindingSource.EndEdit();
                var user = userDetailBindingSource.Current as User;
                context.Users.AddObject(user);
                context.SaveChanges();
                this.DialogResult = DialogResult.OK;
            }
            catch (Exception exception)
            {
                ViewHelper.ShowErrorMessage("Error adding new record", exception);
            }

            this.Close();
        }

        public void DeleteObject()
        {
            throw new NotImplementedException();
        }

        public bool ValidateForm()
        {
            throw new NotImplementedException();
        }

        private void createCommand_Click(object sender, EventArgs e)
        {
            if(!passwordTextEdit.Text.Equals(confirmPasswordTextEdit.Text))
            {
                ViewHelper.ShowErrorMessage("The password was not correctly confirmed. Please ensure that the password and confirmation match exactly.");
                return;
            }
            
            SaveChanges();

        }

        private void closeCommand_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.Cancel;
            this.Close();
        }

        private void userDetailBindingSource_CurrentItemChanged(object sender, EventArgs e)
        {
            var user = userDetailBindingSource.DataSource as User;
            createCommand.Enabled = user.IsValid();
        }


        public void AuthorizeForm()
        {
            createCommand.Enabled = permissionManager.IsAuthorized(PermissionManager.ADMINISTRATION_APPLICATION,aph.ItemName(AdministrationPermissionHelper.Operation.AddNewUser));

        }
    }
}