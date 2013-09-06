using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using ClearOffice.Infrastructure;
using ClearOffice.Inventory.DataAccess;
using DevExpress.XtraEditors;

namespace ClearOffice.Inventory.Views
{
    public partial class CategoryView : DevExpress.XtraEditors.XtraForm,IListForm
    {
        private LookupProxy proxy = new LookupProxy();
        public CategoryView()
        {
            InitializeComponent();
            ShowList();
           
        }
        public void ShowList()
        {
            categorybindingSource.DataSource = proxy.Context.Categories;
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
                    ViewHelper.ShowErrorMessage("Error occured while saving the given category.", ex);
                }
            }
            this.Close();
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            Save();
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.Cancel;
            Close();
        }

        public void AuthorizeForm()
        {
            throw new NotImplementedException();
        }

        #region list operations
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

       
    }
}