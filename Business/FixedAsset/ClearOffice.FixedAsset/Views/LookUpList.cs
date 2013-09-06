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
    public partial class LookUpList : DevExpress.XtraEditors.XtraForm ,IListForm
    {
        private FixedAssetEntities _context;
        private LookupItem lookupItem;
        private Lookup _selectedItem;
        private PermissionManager permissionManager;
        private FixedAssetPermissionHelper faph;
        private bool _newMode;
        public LookUpList()
        {
            InitializeComponent();
            _context =new FixedAssetEntities();
            permissionManager = PermissionManager.GetPermissionManager();
            faph = new FixedAssetPermissionHelper();    
            AuthorizeForm();
            ShowList();
        }

        public void ShowList()
        {
            if (Categorylist.SelectedItems.Count == 0)
                return;
            var lookupInfo = _context.LookupItems.ToList();
            ItembindingSource.DataSource = lookupInfo;
        }

        protected override void OnLoad(EventArgs e)
        {
            base.OnLoad(e);
            ShowLookupCategories();
        }

        private void ShowLookupCategories()
        {
            var list = LoadLookups();
            foreach (var item in list)
            {
                var listItem = new ListViewItem(item.Name);
                listItem.SubItems.Add(item.Name);
                listItem.Tag = item;
                listItem.Group = Categorylist.Groups[0];
                Categorylist.Items.Add(listItem);
            }
        }
        public void RefreshList()
        {
            if (_selectedItem == null)
            {
                ItembindingSource.DataSource = LoadItemInfo();
            }
            else
            {
                ShowItems();
            }
        }
        public void OpenSelectedItem()
        {
            if (lookupItem != null)
            {
                var LookupView = new LookUpItemView();
                LookupView.ShowObject(lookupItem);
                LookupView.SetLookUpView(this);
                LookupView.ShowDialog();
            }
        }

        private IEnumerable<Lookup> LoadLookups()
        {
            return _context.Lookups.Where(lu=>lu.Visible ==true).ToList();
        }
        private IEnumerable<LookupItem> LoadItemInfo()
        {
            _context = new FixedAssetEntities();
            return _context.LookupItems.ToList();
        }
        private void ShowItems()
        {
            var items = GetLookupItems(_selectedItem.LookupId);

            if (items != null)
                ItembindingSource.DataSource = items;
        }
        private object GetLookupItems(int p)
        {
            var result = GetLookupItemsByCategoryId((LookupItems)p);
            return result;
        }
        public IEnumerable<LookupItem> GetLookupItemsByCategoryId(LookupItems cId)
        {
            return GetAllLookupItems(lc => lc.LookupId == (int)cId);
        }
        public IEnumerable<LookupItem> GetAllLookupItems(Func<LookupItem, Boolean> where)
        {
            _context = new FixedAssetEntities();
            return _context.LookupItems.Where(where).ToList();
        }

        private void deleteItem_Click(object sender, EventArgs e)
        {
            DialogResult result = ViewHelper.Conformation("Are you sure you want to delete this lookup information?");
            if (result == DialogResult.Yes)
            {
                if (_newMode) return;
                ItembindingSource.EndEdit();

                try
                {
                    _context.LookupItems.DeleteObject(lookupItem);
                    _context.SaveChanges();
                    ShowItems();
                }
                catch (Exception ex)
                {
                    ViewHelper.ShowErrorMessage(@"Error deleting lookup item information.");
                    ErrorLogger.LogError(this, ex);
                }
            }
        }

        private void gridControl1_Click(object sender, EventArgs e)
        {
            if (gridView1.SelectedRowsCount > 0)
            {

                var selected = (LookupItem)gridView1.GetRow((int)gridView1.GetSelectedRows().GetValue(0));
                if (selected != null)
                {
                    lookupItem = _context.LookupItems.FirstOrDefault(lo => lo.LookupItemId == selected.LookupItemId);
                    btndeleteItem.Enabled = true;
                }
            }
        }

        private void gridControl1_DoubleClick(object sender, EventArgs e)
        {
            if (gridView1.SelectedRowsCount > 0)
            {
                var selected = (LookupItem)gridView1.GetRow((int)gridView1.GetSelectedRows().GetValue(0));
                if (selected != null)
                {
                    lookupItem = _context.LookupItems.First(lo => lo.LookupItemId == selected.LookupItemId);
                }
            }
            OpenSelectedItem();
            AuthorizeForm();
        }

        private void Categorylist_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (Categorylist.SelectedItems.Count == 0)
                return;
            var selected = Categorylist.SelectedItems[0];
            _selectedItem = (Lookup)selected.Tag;
            ShowItems();
            btnnewItem.Enabled = true;
        }

        private void newItem_Click(object sender, EventArgs e)
        {
            if (Categorylist.SelectedItems.Count == 0)
                return;
            if (_selectedItem == null)
                return;
            var editor = new LookUpItemView();
            editor.SetLookUpView(this);
            editor.SetCatagory(_selectedItem);
            editor.ShowObject(null);
            editor.Show();
        }

        public object GetSelectedItem()
        {
            throw new NotImplementedException();
        }


        public void AuthorizeForm()
        {
            btnnewItem.Enabled = permissionManager.IsAuthorized(PermissionManager.FIXED_ASSET_APPLICATION,
                                                                faph.ItemName(
                                                                    FixedAssetPermissionHelper.Operation.AddLookupItem));
            btndeleteItem.Enabled = permissionManager.IsAuthorized(PermissionManager.FIXED_ASSET_APPLICATION,
                                                                   faph.ItemName(
                                                                       FixedAssetPermissionHelper.Operation.
                                                                           DeleteLookupItem));
        }
    }
}