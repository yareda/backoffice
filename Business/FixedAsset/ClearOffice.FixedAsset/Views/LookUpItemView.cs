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
    public partial class LookUpItemView : DevExpress.XtraEditors.XtraForm ,IDetailForm
    {
        private Lookup _category;
        private FixedAssetEntities _context;
        private LookupItem _item;
        private LookUpList _lookupView;
        private PermissionManager permissionManager;
        private FixedAssetPermissionHelper faph;
        private bool newMode;
        public LookUpItemView()
        {
            InitializeComponent();
            _context =new FixedAssetEntities();
            permissionManager = PermissionManager.GetPermissionManager();
            faph = new FixedAssetPermissionHelper();  
            AuthorizeForm();
        }

        public void ShowObject(object keyValue)
        {
            if (keyValue == null)
            {
                _item = new LookupItem {LookupId = _category.LookupId};
                lookupItemBindingSource.DataSource = _item;
                Text = string.Format("Look up item for Category: {0}", _category.Name);
                newMode = true;
            }
            else
            {
                newMode = false;
                var value = (LookupItem) keyValue;
                lookupItemBindingSource.DataSource = _context.LookupItems.FirstOrDefault(li => li.LookupItemId == value.LookupItemId);
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
            lookupItemBindingSource.EndEdit();
            var Item = (LookupItem)lookupItemBindingSource.DataSource;
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



        public bool ValidateForm()
        {
            if (nameTextBox.Text == string.Empty)
            {
                errorProvider1.SetError(nameTextBox, "Name is reqirde");
                return false;
            }
            return true;
        }
        internal void SetCatagory(Lookup category)
        {
            _category = category;
        }

        internal void SetLookUpView(LookUpList lookupView)
        {
            _lookupView = lookupView;
        }

        private void btnItemSave_Click(object sender, EventArgs e)
        {
            SaveChanges();
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.Cancel;
            this.Close();
        }

        public void DeleteObject()
        {
            throw new NotImplementedException();
        }


        public void AuthorizeForm()
        {
            btnItemSave.Enabled = permissionManager.IsAuthorized(PermissionManager.FIXED_ASSET_APPLICATION,
                                                                 faph.ItemName(
                                                                     FixedAssetPermissionHelper.Operation.AddLookupItem));
         }


    }
}