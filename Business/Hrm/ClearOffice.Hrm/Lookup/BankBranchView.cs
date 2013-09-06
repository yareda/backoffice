using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using ClearOffice.Hrm.Business.Data;
using ClearOffice.Security;
using DevExpress.XtraEditors;
using ClearOffice.Infrastructure;
using ClearOffice.Hrm.Business;
using System.Linq;
namespace ClearOffice.Hrm.Lookup
{
    public partial class BankBranchView : DevExpress.XtraEditors.XtraForm,IListForm
    {

        private LookupProxy _proxy =new LookupProxy();
        private PermissionManager permissionManager;
        private HRMPermissionHelper hph;
        public BankBranchView()
        {
            InitializeComponent();
            hph = new HRMPermissionHelper();
            permissionManager = PermissionManager.GetPermissionManager();
            AuthorizeForm();
        }

        public void ShowList()
        {
            bankBranchBindingSource.DataSource = _proxy.Context.BankBranches;
        }

        public void OpenSelectedItem()
        {
            throw new NotImplementedException();
        }

        public object GetSelectedItem()
        {
            var obj = (BankBranch) bankBranchBindingSource.Current;
            return obj;
        }

        public void RefreshList()
        {
            throw new NotImplementedException();
        }

        public void Save()
        {
            if (_proxy.IsDirty())
            {
                try
                {
                    _proxy.Save();
                    this.DialogResult = DialogResult.OK;
                        Close();
                }
                catch (Exception ex)
                {
                    ViewHelper.ShowErrorMessage("Error occured while saving the given branch.", ex);
                }
            }
            //this.Close();
        }

        private void simpleButton1_Click(object sender, EventArgs e)
        {
            Save();
        }


        public void AuthorizeForm()
        {
            btnOk.Enabled = permissionManager.IsAuthorized(PermissionManager.HRM_APPLICATION,
                                                           hph.ItemName(HRMPermissionHelper.Operation.AddLookupItem));
            
        }
    }
}