using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using ClearOffice.FixedAsset.DataAccess;
using ClearOffice.Infrastructure;
using ClearOffice.Security;
using DevExpress.XtraEditors;

namespace ClearOffice.FixedAsset.Views
{
    public partial class ApplicationSettingView : DevExpress.XtraEditors.XtraForm, IDetailForm
    {
        private FixedAssetEntities _context;
        private ApplicationSetting _applicationSetting;
        private PermissionManager permissionManager;
        private FixedAssetPermissionHelper faph;

        public ApplicationSettingView()
        {
            InitializeComponent();
            _context =new FixedAssetEntities();
            permissionManager = PermissionManager.GetPermissionManager();
            faph =new FixedAssetPermissionHelper();
            Loadapplicationsetting();
            AuthorizeForm();
            btnSetSave.Enabled = false;

        }
        private void Loadapplicationsetting()
        {
            var appsetting = _context.ApplicationSettings.FirstOrDefault(ass => ass.SettingId == 1);
            settingbindingSource.DataSource = appsetting;
              
        }
        private void btnchange_Click(object sender, EventArgs e)
        {
            btnSetSave.Enabled = true;
            dateEdit1.Enabled = true;
            dateEdit2.Enabled = true;
            defaultMethodLookUpEdit.Enabled = true;
            btnchange.Enabled = false;
        }

        public void ShowObject(object keyValue)
        {
            if (keyValue == null)
            {
                _applicationSetting = _context.ApplicationSettings.FirstOrDefault(li => li.SettingId ==1);
                settingbindingSource.DataSource = _applicationSetting;
                Loadlookup();
            }
        }

        private void Loadlookup()
        {
            var depreciationmethods = _context.LookupItems.Where(li => li.LookupId == (int)LookupItems.DepreciationMethods);
            depreciationbindingSource.DataSource = depreciationmethods.ToList();
        }


        public void SaveChanges()
        {
          if (!ValidateForm()) return;
            settingbindingSource.EndEdit();
            try
            {
              _context.SaveChanges();
               this.Close();
                return;
             }
            catch (Exception exception)
            {
                ViewHelper.ShowErrorMessage("Error occured while saving the current setting.", exception);
                return;
            }
        }

        public void DeleteObject()
        {
            throw new NotImplementedException();
        }

        public bool DataChanged()
        {
            throw new NotImplementedException();
        }

        public bool ValidateForm()
        {
            if (dateEdit1.Text == string.Empty)
            {
                errorProvider1.SetError(dateEdit1, "Fiscal Start Date is Required");
                return false;
            }
            if (dateEdit2.Text == string.Empty)
            {
                errorProvider1.SetError(dateEdit2, "Fiscal End Date is Required");
                return false;
            }
            return true;
        }

        private void btnSetSave_Click(object sender, EventArgs e)
        {
            SaveChanges();
        }


        public void AuthorizeForm()
        {
            btnSetSave.Enabled = permissionManager.IsAuthorized(PermissionManager.FIXED_ASSET_APPLICATION,
                                                                faph.ItemName(
                                                                    FixedAssetPermissionHelper.Operation.
                                                                        EditApplicationSetting));
        }
    }
}