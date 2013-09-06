using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using ClearOffice.Hrm.Business;
using ClearOffice.Hrm.Business.Data;
using ClearOffice.Infrastructure;
using System.Linq;
using ClearOffice.Security;
using DevExpress.XtraEditors;

namespace ClearOffice.Hrm.Lookup
{
    public partial class EthinicityType : DevExpress.XtraEditors.XtraForm ,IListForm
    {
        LookupProxy proxy=new LookupProxy();
        private PermissionManager permissionManager;
        private HRMPermissionHelper hph;

        public EthinicityType()
        {
            InitializeComponent();
            hph = new HRMPermissionHelper();
            permissionManager = PermissionManager.GetPermissionManager();
            AuthorizeForm();
            ShowList();
        }
       
        private void Save()
        {
           
            if (proxy.IsDirty())
            {
              
                try
                {
                    proxy.Save();
                              
                }
                catch (Exception ex)
                {
                    ViewHelper.ShowErrorMessage("Error occured while saving the given ethinicity.", ex);
                }
                
            }
            Close();
        }



        public void ShowList()
        {
            EthinicitybindingSource.DataSource = proxy.Context.Ethnicities;
        }

        public void OpenSelectedItem()
        {
            throw new NotImplementedException();
        }

        public object GetSelectedItem()
        {
            var obj = (Ethnicity)EthinicitybindingSource.Current;
            return obj;
          
        }

        public void RefreshList()
        {
            throw new NotImplementedException();
        }

        private void btnOk_Click(object sender, EventArgs e)
        {
            Save();
        }


        public void AuthorizeForm()
        {
            throw new NotImplementedException();
        }
    }
}
