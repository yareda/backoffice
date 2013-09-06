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
    public partial class InventoryLookupListView : DevExpress.XtraEditors.XtraForm ,IListForm
    {
        private InventoryEntities _context;
        private LookupItem lookupItem;
        private Lookup _selectedItem;
        public InventoryLookupListView()
        {
            InitializeComponent();
            _context =new InventoryEntities();
        }

        public void ShowList()
        {
            if (inventorycategorylist.SelectedItems.Count == 0)
                return;
            var lookupInfo = _context.LookupItems.ToList();
            lookupItembindingSource.DataSource = lookupInfo;
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
                var listItem = new ListViewItem(item.LookupName);
                listItem.SubItems.Add(item.LookupName);
                listItem.Tag = item;
                listItem.Group = inventorycategorylist.Groups[0];
                inventorycategorylist.Items.Add(listItem);
            }
        }

        private IEnumerable<Lookup> LoadLookups()
        {
            return _context.Lookups.ToList();
        }

        private IEnumerable<LookupItem> LoadItemInfo()
        {
            _context = new InventoryEntities();
            return _context.LookupItems.ToList();
        }

        private object GetLookupItems(int p)
        {
            var result = GetLookupItemsByCategoryId((InventoryLookups)p);
            return result;
        }
        public IEnumerable<LookupItem> GetLookupItemsByCategoryId(InventoryLookups cId)
        {
            return GetAllLookupItems(lc => lc.LookupId == (int)cId);
        }
        public IEnumerable<LookupItem> GetAllLookupItems(Func<LookupItem, Boolean> where)
        {
            _context = new InventoryEntities();
            return _context.LookupItems.Where(where).ToList();
        }

        private void ShowItems()
        {
            var items = GetLookupItems(_selectedItem.LookupId);

            if (items != null)
                lookupItembindingSource.DataSource = items;
        }

        public void OpenSelectedItem()
        {
          if (lookupItem != null)
            {
                var LookupView = new LookupItemView();
                LookupView.ShowObject(lookupItem);
                LookupView.SetLookUpView(this);
                LookupView.ShowDialog();
            }
        }

        public object GetSelectedItem()
        {
            throw new NotImplementedException();
        }

        public void RefreshList()
        {
            if (_selectedItem == null)
            {
                lookupItembindingSource.DataSource = LoadItemInfo();
            }
            else
            {
                ShowItems();
            }
        }

        

        public void AuthorizeForm()
        {
            throw new NotImplementedException();
        }

        private void inventorycategorylist_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (inventorycategorylist.SelectedItems.Count == 0)
                return;
            var selected = inventorycategorylist.SelectedItems[0];
            _selectedItem = (Lookup)selected.Tag;
            ShowItems();
            btnNewtoolstrip.Enabled = true;
        }

        private void btnNewtoolstrip_Click(object sender, EventArgs e)
        {
            if (inventorycategorylist.SelectedItems.Count == 0)
                return;
            if (_selectedItem == null)
                return;
            var editor = new LookupItemView();
            editor.SetLookUpView(this);
            editor.SetCatagory(_selectedItem);
            editor.ShowObject(null);
            editor.Show();
        }

        private void btndelete_Click(object sender, EventArgs e)
        {
            DialogResult result = ViewHelper.Conformation("Are you sure you want to delete this lookup information?");
            if (result == DialogResult.Yes)
            {
                lookupItembindingSource.EndEdit();
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
        }

        private void gridControl1_Click(object sender, EventArgs e)
        {
            if (gridView1.SelectedRowsCount > 0)
            {

                var selected = (LookupItem)gridView1.GetRow((int)gridView1.GetSelectedRows().GetValue(0));
                if (selected != null)
                {
                    lookupItem = _context.LookupItems.FirstOrDefault(lo => lo.LookupItemId == selected.LookupItemId);
                    btndelete.Enabled = true;
                }
            }
        }
    }
}