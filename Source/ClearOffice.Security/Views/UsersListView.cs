using System;
using System.Linq;
using System.Windows.Forms;
using DevExpress.XtraBars.Ribbon;
using DevExpress.XtraEditors;
using ClearOffice.Infrastructure;
using ClearOffice.Security.Data;

namespace ClearOffice.Security.Views
{
    public partial class UsersListView : XtraForm, IListForm
    {
        private ClearOfficeEntities context;

        public UsersListView()
        {
            InitializeComponent();
            context = new ClearOfficeEntities();
            ShowList();
        }

        #region IListForm members

        public void ShowList()
        {
            this.usersBindingSource.DataSource = context.Users.ToList();
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
            context = new ClearOfficeEntities();
            ShowList();
        }

        #endregion

        private void UsersListView_Activated(object sender, EventArgs e)
        {
            var p = this.MdiParent as RibbonForm;
            p.Ribbon.SelectedPage = p.Ribbon.Pages[Constants.ADMIN_RIBBON_NAME];
        }

        private void refreshBarButtonItem_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            RefreshList();
        }

        private void addUserBarButtonItem_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            var cuv = new CreateUserView();
            cuv.ShowObject(null);
            var result = cuv.ShowDialog(this);

            if (result == DialogResult.OK)
            {
                RefreshList();
            }
        }

        private void disableBarButtonItem_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            string verb, question;
            try
            {
                var user = usersBindingSource.Current as User;
                if (null == user.Disabled)
                {
                    verb = "in unknown state";
                    question = "disable";
                }
                else
                {
                    verb = user.Disabled.Value ? "disabled" : "active";
                    question = user.Disabled.Value ? "enable" : "disable";
                }
                
                var msg = string.Format("The user account is currently {0}. Do you want to {1} it?", verb, question);

                if (ViewHelper.ShowConfirmDialog(msg) == DialogResult.Yes)
                {
                    SecurityHelper.DisableUserAccount(user.UserId);
                    ViewHelper.ShowSuccessMessage("Action performed successfuly.");
                    RefreshList();
                }
            }
            catch (Exception exception)
            {
                ViewHelper.ShowErrorMessage("Error disabling user account.", exception);
            }
        }

        private void resetPasswordBarButtonItem_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            try
            {
                var user = usersBindingSource.Current as User;
                var resetDialog = new SetPasswordView();
                resetDialog.ShowObject(user);
                resetDialog.ShowDialog(this);
            }
            catch (Exception exception)
            {
                ViewHelper.ShowErrorMessage("Error resetting password.", exception);
            }
        }




        public void AuthorizeForm()
        {
            throw new NotImplementedException();
        }
    }
}