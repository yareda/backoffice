using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using ClearOffice.Infrastructure;
using ClearOffice.Security;
using DevExpress.XtraEditors;
using ClearOffice.Fleet.Business;
using System.Linq;
namespace ClearOffice.Fleet.Views
{
    public partial class FleetLookUpListView : DevExpress.XtraEditors.XtraForm, IListForm
    {
        private FleetEntities _context;
        private LookupItem lookupItem;
        private Lookup _selectedItem;
        private PermissionManager _pm;
        private FleetPermissionHelper _fph;
        public FleetLookUpListView()
        {
            InitializeComponent();
            _context = new FleetEntities();


            _pm = PermissionManager.GetPermissionManager();
            _fph = new FleetPermissionHelper();

            AuthorizeForm();
        }
        public void ShowList()
        {
            if (FleetCategorylist.SelectedItems.Count == 0)
                return;
            var lookupInfo = _context.LookupItems.ToList();
            itemListBindingSource.DataSource = lookupInfo;
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
                listItem.Group = FleetCategorylist.Groups[0];
                FleetCategorylist.Items.Add(listItem);
            }
        }

        private IEnumerable<Lookup> LoadLookups()
        {
            return _context.Lookups.ToList();
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

        public object GetSelectedItem()
        {
            throw new NotImplementedException();
        }

        public void RefreshList()
        {
            if (_selectedItem == null)
            {
                itemListBindingSource.DataSource = LoadItemInfo();
            }
            else
            {
                ShowItems();
            }
        }

        private void BtnNew_Click(object sender, EventArgs e)
        {
            if (FleetCategorylist.SelectedItems.Count == 0)
                return;
            if (_selectedItem == null)
                return;
            var editor = new LookUpItemView();
            editor.SetLookUpView(this);
            editor.SetCatagory(_selectedItem);
            editor.ShowObject(null);
            editor.Show();
        }
        private void ShowItems()
        {
            var items = GetLookupItems(_selectedItem.LookupId);

            if (items != null)
                itemListBindingSource.DataSource = items;
        }
        private IEnumerable<LookupItem> LoadItemInfo()
        {
            _context = new FleetEntities();
            return _context.LookupItems.ToList();
        }
        private object GetLookupItems(int p)
        {
            var result = GetLookupItemsByCategoryId((FleetLookups)p);
            return result;
        }
        public IEnumerable<LookupItem> GetLookupItemsByCategoryId(FleetLookups cId)
        {
            return GetAllLookupItems(lc => lc.LookupId == (int)cId);
        }
        public IEnumerable<LookupItem> GetAllLookupItems(Func<LookupItem, Boolean> where)
        {
            _context = new FleetEntities();
            return _context.LookupItems.Where(where).ToList();
        }

        private void FleetCategorylist_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (FleetCategorylist.SelectedItems.Count == 0)
                return;
            var selected = FleetCategorylist.SelectedItems[0];
            _selectedItem = (Lookup)selected.Tag;
            ShowItems();
            BtnNew.Enabled = true;
        }

        private void gridControl1_Click(object sender, EventArgs e)
        {
            if (gridView1.SelectedRowsCount > 0)
            {

                var selected = (LookupItem)gridView1.GetRow((int)gridView1.GetSelectedRows().GetValue(0));
                if (selected != null)
                {
                    lookupItem = _context.LookupItems.FirstOrDefault(lo => lo.LookupItemId == selected.LookupItemId);
                    btnDelete.Enabled = true;
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

        private void btnDelete_Click(object sender, EventArgs e)
        {
            DialogResult result = ViewHelper.Conformation("Are you sure you want to delete this lookup information?");
            if (result == DialogResult.Yes)
            {
                itemListBindingSource.EndEdit();
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


        public void AuthorizeForm()
        {
            BtnNew.Enabled = _pm.IsAuthorized(PermissionManager.FLEET_APPLICATION, _fph.ItemName(
                FleetPermissionHelper.Operation.AddLookupItem));
            btnDelete.Enabled = _pm.IsAuthorized(PermissionManager.FLEET_APPLICATION, _fph.ItemName(
                FleetPermissionHelper.Operation.DeleteLookupItem));
        }
    }
}