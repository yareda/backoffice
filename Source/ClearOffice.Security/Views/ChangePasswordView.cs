using System;
using System.Linq;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using DevExpress.XtraEditors;
using ClearOffice.Security.Data;
using ClearOffice.Infrastructure;

namespace ClearOffice.Security.Views
{
    public partial class ChangePasswordView : DevExpress.XtraEditors.XtraForm, IDetailForm
    {
        private ClearOfficeEntities context;
        private User user;
        private string userName;
        private PermissionManager permissionManager;
        private AdministrationPermissionHelper aph;

        public ChangePasswordView()
        {
            InitializeComponent();
            context = new ClearOfficeEntities();
            permissionManager = PermissionManager.GetPermissionManager();
            aph = new AdministrationPermissionHelper();
            AuthorizeForm();
        }

        private void cancelCommand_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void simpleButton1_Click(object sender, EventArgs e)
        {
            DoChangePassword();
        }

        private void DoChangePassword()
        {
            if(!ValidateForm()) return;

            user = context.Users.First(u => u.UserName == userName);
            // Check if the current password and the supplied one are the same
            if (user.Password != SecurityHelper.HashPassword(oldPasswordTextEdit.Text))
            {
                ViewHelper.ShowErrorMessage("The OLD password was not correctly confirmed. Please ensure that the password and confirmation match exactly.");
                return;
            }

            // Check if the newly supplied passwords match
            if (newPasswordTextEdit.Text != confirmTextEdit.Text)
            {
                ViewHelper.ShowErrorMessage("The NEW password was not correctly confirmed. Please ensure that the password and confirmation match exactly.");
                return;
            }

            // Save the changes to the database
            try
            {
                if (SecurityHelper.ChangePassword(user.UserId, newPasswordTextEdit.Text))
                    ViewHelper.ShowSuccessMessage("Password changed successfully.");
                this.DialogResult = DialogResult.OK;
            }
            catch (Exception exception)
            {
                ViewHelper.ShowErrorMessage("Error occured while changing password",exception);
            }

        }

        public void ShowObject(object keyValue)
        {
            userName = keyValue as string;
            this.userNameTextEdit.Text = userName;
            this.Text = string.Format("Change password for : {0}", userName);
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
            if(newPasswordTextEdit.Text != confirmTextEdit.Text)
            {
                errorProvider1.SetError(confirmTextEdit,"Passwords do not match");
                return false;                
            }

            return true;
        }


        public void AuthorizeForm()
        {
            simpleButton1.Enabled = permissionManager.IsAuthorized(PermissionManager.ADMINISTRATION_APPLICATION,
                                                                   aph.ItemName(
                                                                       AdministrationPermissionHelper.Operation.
                                                                           ChangePassword));

        }
    }
}