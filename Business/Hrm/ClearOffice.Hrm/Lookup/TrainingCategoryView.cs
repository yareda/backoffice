﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using ClearOffice.Hrm.Business;
using ClearOffice.Hrm.Business.Data;
using ClearOffice.Infrastructure;
using ClearOffice.Security;
using DevExpress.XtraEditors;

namespace ClearOffice.Hrm.Lookup
{
    public partial class TrainingCategoryView : DevExpress.XtraEditors.XtraForm,IListForm
    {
        private LookupProxy _proxy = new LookupProxy();
        private PermissionManager permissionManager;
        private HRMPermissionHelper hph;
        public TrainingCategoryView()
        {
            InitializeComponent();
            hph = new HRMPermissionHelper();
            permissionManager = PermissionManager.GetPermissionManager();
            AuthorizeForm();
            ShowList();
         }
        public void ShowList()
        {
            trainingCategoryBindingSource.DataSource = _proxy.Context.TrainingCategories;
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
            throw new NotImplementedException();
        }

        private void btnOk_Click(object sender, EventArgs e)
        {
            if (_proxy.IsDirty())
            {
                try
                {
                   _proxy.Save();
                    this.DialogResult = DialogResult.OK;
                }
                catch (Exception ex)
                {
                    ViewHelper.ShowErrorMessage("Error occured while saving the given training category.", ex);
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