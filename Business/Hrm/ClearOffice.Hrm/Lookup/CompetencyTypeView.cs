using System;
using ClearOffice.Hrm.Business;
using ClearOffice.Hrm.Business.Data;
using ClearOffice.Infrastructure;
using System.Windows.Forms;
using ClearOffice.Security;

namespace ClearOffice.Hrm.Lookup
{
    public partial class CompetencyTypeView : DevExpress.XtraEditors.XtraForm, IListForm
    {
        LookupProxy proxy = new LookupProxy();
        private PermissionManager permissionManager;
        private HRMPermissionHelper hph;
        public CompetencyTypeView()
        {
            InitializeComponent();
            hph = new HRMPermissionHelper();
            permissionManager = PermissionManager.GetPermissionManager();
            AuthorizeForm();
        }

        public void ShowList()
        {
            competencyTypebindingSource.DataSource = proxy.Context.CompetencyTypes;
        }

        public void OpenSelectedItem()
        {
            throw new NotImplementedException();
        }

        public object GetSelectedItem()
        {
            var obj = (CompetencyType) competencyTypebindingSource.Current;
            return obj;
        }

        public void RefreshList()
        {
            throw new NotImplementedException();
        }

        private void btnOk_Click(object sender, EventArgs e)
        {
            if (proxy.IsDirty())
            {
                try
                {
                    proxy.Save();
                    this.DialogResult = DialogResult.OK;

                }
                catch (Exception ex)
                {
                    ViewHelper.ShowErrorMessage("Error occured while saving the given competency type." ,ex);
                }
            }
            this.Close();
        }


        public void AuthorizeForm()
        {
            btnOk.Enabled = permissionManager.IsAuthorized(PermissionManager.HRM_APPLICATION,
                                                           hph.ItemName(HRMPermissionHelper.Operation.AddLookupItem));
        }
    }
}