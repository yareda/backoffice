using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Security;
using System.Text;
using System.Windows.Forms;
using DevExpress.XtraEditors;
using ClearOffice.Security;

namespace ClearOffice.Infrastructure.Shell
{
    public partial class LogIn : Form
    {
        private int retryCount = 0;

        public LogIn()
        {
            InitializeComponent();
        }

        private void okCommand_Click(object sender, EventArgs e)
        {
            retryCount += 1;

            // If the user tries more than three times then they must restart the app
            if (retryCount > 3) Application.Exit();


            if (userTextEdit.Text == string.Empty)
            {
                errorProvider1.SetError(userTextEdit, "User name is required");
                return;
            }

            var user = userTextEdit.Text;
            var password = passwordTextEdit.Text;

            try
            {
                if (SecurityHelper.Authenticate(user, password))
                {
                    var shell = new MainForm();
                    shell.Show();                    
                    this.Hide();
                }
            }
            catch (ApplicationException exception)
            {
                ViewHelper.ShowErrorMessage(exception.Message);
            }
        }

        private void cancelCommand_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}