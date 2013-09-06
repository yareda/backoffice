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
    public partial class SetPasswordView : DevExpress.XtraEditors.XtraForm,IDetailForm
    {
        private User user;
        private PermissionManager permissionManager;
        private AdministrationPermissionHelper aph;
        public SetPasswordView()
        {
            InitializeComponent();
            permissionManager = PermissionManager.GetPermissionManager();
            aph = new AdministrationPermissionHelper();
            AuthorizeForm();
        }

        public void ShowObject(object keyValue)
        {
            try
            {
                user = keyValue as User;
                this.Text = string.Format("Set Password for {0}", user.FullName);
            }
            catch (Exception exception)
            {
                ViewHelper.ShowErrorMessage("User information is invalid.", exception);                
            }
        }

        public bool DataChanged()
        {
            throw new NotImplementedException();
        }

        public void SaveChanges()
        {
            throw new NotImplementedException();
        }

        public void DeleteObject()
        {
            throw new NotImplementedException();
        }

        public bool ValidateForm()
        {
            throw new NotImplementedException();
        }

        private void okCommand_Click(object sender, EventArgs e)
        {
            if (!passwordTextEdit.Text.Equals(confirmPasswordTextEdit.Text))
            {
                ViewHelper.ShowErrorMessage("The password was not correctly confirmed. Please ensure that the password and confirmation match exactly.");
                return;
            }

            try
            {
                SecurityHelper.ChangePassword(user.UserId, passwordTextEdit.Text);
                ViewHelper.ShowSuccessMessage("The password has been set.");
                this.DialogResult = DialogResult.OK;
                this.Close();
            }
            catch (Exception exception)
            {
                ViewHelper.ShowErrorMessage("Error occured while setting new password.",exception);                
            }
        }

        private void cancelCommand_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.Cancel;
            this.Close();
        }


        public void AuthorizeForm()
        {
            okCommand.Enabled = permissionManager.IsAuthorized(PermissionManager.ADMINISTRATION_APPLICATION,
                                                               aph.ItemName(
                                                                   AdministrationPermissionHelper.Operation.
                                                                       SetUserPassword));

        }
    }
}