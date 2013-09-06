using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using ClearOffice.Inventory.DataAccess;
using ClearOffice.Inventory.Properties;
using DevExpress.XtraEditors;
using ClearOffice.Infrastructure;

namespace ClearOffice.Inventory.Views
{
    public partial class ItemDetail : DevExpress.XtraEditors.XtraForm, IDetailForm
    {
        private InventoryEntities context;
        private InventoryItem item;
        private bool cancelChanges;
        private bool newMode;
        public ItemDetail()
        {
            InitializeComponent();
            context = new InventoryEntities();
            LoadLookups();
        }

        private void LoadLookups()
        {
            var categories = context.Categories.ToList();
            categoryBindingSource.DataSource = categories;

            var units = context.MeasurementUnits.ToList();
            unitBindingSource.DataSource = units;

        }

        public void ShowObject(object keyValue)
        {
            if (keyValue == null)
            {
                item = new InventoryItem();
                newMode = true;
            }
            else
            {
                try
                {
                    var info = keyValue as ItemInfo;
                    item = context.InventoryItems.FirstOrDefault(i => i.ItemId == info.ItemId);
                    newMode = false;
                }
                catch (Exception exception)
                {
                    ViewHelper.ShowErrorMessage("Error loading Item information", exception);
                }
            }

            itemBindingSource.DataSource = item;
        }

        public bool DataChanged()
        {
            return context.ObjectStateManager.GetObjectStateEntries(EntityState.Added | EntityState.Modified | EntityState.Deleted).Any();
        }

        public void SaveChanges()
        {
            itemBindingSource.EndEdit();
            try
            {
                if (newMode)
                    context.InventoryItems.AddObject(item);
                context.SaveChanges();
                this.DialogResult = DialogResult.OK;
            }
            catch (Exception exception)
            {
                ViewHelper.ShowErrorMessage("Error saving Item information", exception);
            }
        }

        public void DeleteObject()
        {
            throw new NotImplementedException();
        }

        public bool ValidateForm()
        {
            return item.IsValid();
        }

        public void AuthorizeForm()
        {
            throw new NotImplementedException();
        }

        private void ItemDetail_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (!cancelChanges && item.IsValid())
            {
                if (this.DataChanged())
                {
                    var response = MessageBox.Show(Resources.DATA_CHANGE_MESSAGE, Resources.DATA_CHANGE_TITLE,
                                                   MessageBoxButtons.YesNoCancel, MessageBoxIcon.Exclamation);

                    switch (response)
                    {
                        case DialogResult.Yes:
                            SaveChanges();
                            break;
                        case DialogResult.Cancel:
                            e.Cancel = true;
                            break;
                    }
                }
            }
        }

        private void cancelCommand_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.Cancel;
        }

        private void itemBindingSource_CurrentItemChanged(object sender, EventArgs e)
        {
            saveCommand.Enabled = item.IsValid();
        }

        private void categoryIdLookUpEdit_EditValueChanged(object sender, EventArgs e)
        {
            try
            {
                var ev = Convert.ToInt32(categoryIdLookUpEdit.EditValue);
                if (null != ev)
                {
                    var category = context.Categories.SingleOrDefault(c => c.CategoryId == ev);
                    subCategoryBindingSource.DataSource = category.SubCategories;
                }

            }
            catch (Exception)
            {

            }
        }

        private void saveCommand_Click(object sender, EventArgs e)
        {
            SaveChanges();
        }

        private void addCategoryHyperLinkEdit_Click(object sender, EventArgs e)
        {
            var picker = new CategoryView();
            picker.ShowList();
            var result = picker.ShowDialog(this);
            if (result == DialogResult.OK)
            {
                var store = new LookupProxy();
                this.categoryBindingSource.DataSource = store.Context.Categories.ToList();
            }
        }

        private void addsubCategoryHyperLinkEdit_Click(object sender, EventArgs e)
        {
            var picker = new SubCategoryView();
            picker.ShowList();
            var result = picker.ShowDialog(this);
            if (result == DialogResult.OK)
            {
                var store = new LookupProxy();
                this.subCategoryBindingSource.DataSource = store.Context.SubCategories.ToList();
            }
        }
    }
}