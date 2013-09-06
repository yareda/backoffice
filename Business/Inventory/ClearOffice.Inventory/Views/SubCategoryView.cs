using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using ClearOffice.Infrastructure;
using ClearOffice.Inventory.DataAccess;
using DevExpress.XtraEditors;

namespace ClearOffice.Inventory.Views
{
    public partial class SubCategoryView : DevExpress.XtraEditors.XtraForm,IListForm
    {
        private LookupProxy proxy =new LookupProxy();
        public SubCategoryView()
        {
            InitializeComponent();
            ShowList();
        }

        public void ShowList()
        {
            subcategorybindingSource.DataSource = proxy.Context.SubCategories;
            var category = proxy.Context.Categories;
            categorybindingSource.DataSource = category;
        }

        public void Save()
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
                    ViewHelper.ShowErrorMessage("Error occured while saving the given sub category.", ex);
                }
            }
            this.Close();
        }
        #region listoperations
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
        #endregion
        public void AuthorizeForm()
        {
            throw new NotImplementedException();
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            Save();
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.Cancel;
            this.Close();
        }
    }
}