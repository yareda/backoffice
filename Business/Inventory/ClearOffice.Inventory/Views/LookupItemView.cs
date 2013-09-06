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
    public partial class LookupItemView : DevExpress.XtraEditors.XtraForm,IDetailForm
    {
        private Lookup _category;
        private InventoryEntities _context;
        private LookupItem _item;
        private InventoryLookupListView _lookupView;
        private bool newMode;
        public LookupItemView()
        {
            InitializeComponent();
            _context =new InventoryEntities();
        }

        public void ShowObject(object keyValue)
        {

            if (keyValue == null)
            {
                _item = new LookupItem { LookupId = _category.LookupId };
                lookUpItemBindingSource.DataSource = _item;
                Text = string.Format("Look up item for Category: {0}", _category.LookupName);
                newMode = true;
            }
            else
            {
                newMode = false;
                var value = (LookupItem)keyValue;
                lookUpItemBindingSource.DataSource = _context.LookupItems.FirstOrDefault(li => li.LookupItemId == value.LookupItemId);
                Text = string.Format("Edit Look item for Category: {0}", value.ItemName);
            }
        }

        public bool DataChanged()
        {
            return _context.ObjectStateManager.GetObjectStateEntries(EntityState.Added | EntityState.Modified |
                                           EntityState.Deleted).Any();
        }

        public void SaveChanges()
        {
            if (!ValidateForm()) return;
            lookUpItemBindingSource.EndEdit();
            var Item = (LookupItem)lookUpItemBindingSource.DataSource;

            if (newMode)
            {
                var lr = (from l in _context.LookupItems select l).OrderByDescending(l => l.LookupItemId).FirstOrDefault();
                Item.LookupItemId = lr.LookupItemId + 1;
                _context.LookupItems.AddObject(Item);
            }

            try
            {
                _context.SaveChanges();
                Close();
                _lookupView.RefreshList();
            }
            catch (Exception e)
            {
                ViewHelper.ShowSaveError();
                return;
            }
        }

        public void DeleteObject()
        {
            throw new NotImplementedException();
        }

        public bool ValidateForm()
        {
            if (itemNameTextBox.Text == string.Empty)
            {
                lookupItemErrorProvider.SetError(itemNameTextBox, "Name is reqirde");
                return false;
            }
            return true;
        }
        internal void SetCatagory(Lookup category)
        {
            _category = category;
        }

        internal void SetLookUpView(InventoryLookupListView lookupView)
        {
            _lookupView = lookupView;
        }
        private void saveCommand_Click(object sender, EventArgs e)
        {
            SaveChanges();
        }

        private void cancelCommand_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.Cancel;
            this.Close();
        }
        public void AuthorizeForm()
        {
            throw new NotImplementedException();
        }
    }
}