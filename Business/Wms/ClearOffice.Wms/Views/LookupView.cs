using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;
using ClearOffice.Infrastructure;
using ClearOffice.Security;
using ClearOffice.Wms.Business;

namespace ClearOffice.Wms.Views
{
    public partial class LookupView : DevExpress.XtraEditors.XtraForm,IListForm
    {
        private WmsEntities _context;
        private bool _listShown = false;
        private LookupItem lookupItem;
        private bool _newMode;
        private Lookup _selectedItem;
        private PermissionManager _pm;
        private WorkshopPermissionHelper _wph;
        public LookupView()
        {
            InitializeComponent();
            _context=new WmsEntities();
             ShowList();
            _listShown = true;

            _pm = PermissionManager.GetPermissionManager();
            _wph = new WorkshopPermissionHelper();

            AuthorizeForm();
        }
       
        private void newToolStripButton_Click(object sender, EventArgs e)
        {
            if (categoryList.SelectedItems.Count == 0)
                return;
            if(_selectedItem == null)
                return;
            var editor = new LookupEdit();
            editor.SetLookUpView(this);
            editor.SetCatagory(_selectedItem);
            editor.ShowObject(null);
            editor.Show();
        }


        public void ShowList()
        {
            if (categoryList.SelectedItems.Count == 0)
                return;

            var lookupInfo = _context.LookupItems.ToList();
            ItemBindingSource.DataSource = lookupInfo;
        }

        public void OpenSelectedItem()
        {
            if (lookupItem != null)
            {
                var LookupView = new LookupEdit();
                LookupView.ShowObject(lookupItem.ItemId);
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
            if(_selectedItem == null)
            {
                ItemBindingSource.DataSource = LoadItemInfo();
            }
            else
            {
                ShowItems();   
            }
        }

        private IEnumerable<LookupItem> LoadItemInfo()
        {
            _context=new WmsEntities();
            return _context.LookupItems.ToList();
        }

        private void deleteToolStripButton_Click(object sender, EventArgs e)
        {
             DialogResult result = ViewHelper.Conformation("Are you sure you want to delete this lookup information?");
             if (result == DialogResult.Yes)
             {
                 if (_newMode) return;
                 ItemBindingSource.EndEdit();

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
                    lookupItem = _context.LookupItems.First(lo => lo.ItemId == selected.ItemId);
                }
            }
            OpenSelectedItem();
        }

        private void toolStripButton1_Click(object sender, EventArgs e)
        {
            RefreshList();
        }

        private void openToolStripButton_Click(object sender, EventArgs e)
        {
            OpenSelectedItem();
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
                listItem.Group = categoryList.Groups[0];
                categoryList.Items.Add(listItem);
            }
        }

        private IEnumerable<Lookup> LoadLookups()
        {
         return _context.Lookups.ToList();
         }
        private void categoryList_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (categoryList.SelectedItems.Count == 0)
                return;
            var selected = categoryList.SelectedItems[0];
            _selectedItem = (Lookup)selected.Tag;
            ShowItems();
            btnNew.Enabled = true;
        }

        private void ShowItems()
        {
            var items = GetLookupItems(_selectedItem.LookupId);

            if (items!=null)
                ItemBindingSource.DataSource = items;
        }
        private object GetLookupItems(int p)
        {
            var result = GetLookupItemsByCategoryId((LookupItems)p);
            return result;
        }

        public IEnumerable<LookupItem> GetAllLookupItems(Func<LookupItem, Boolean> where)
        {
            _context = new WmsEntities();
            return _context.LookupItems.Where(where).ToList();
        }

        public IEnumerable<LookupItem> GetLookupItemsByCategoryId(LookupItems cId)
        {
            return GetAllLookupItems(lc => lc.LookupId == (int)cId);
        }

        private void gridControl1_Click(object sender, EventArgs e)
        {
            if (gridView1.SelectedRowsCount > 0)
            {

                var selected = (LookupItem)gridView1.GetRow((int)gridView1.GetSelectedRows().GetValue(0));
                if (selected != null)
                {
                   lookupItem = _context.LookupItems.FirstOrDefault(lo => lo.ItemId == selected.ItemId);
                    btnDelete.Enabled = true;
                }
            }
        }

        public void OpenSelected()
        {
            throw new NotImplementedException();
        }


        public void AuthorizeForm()
        {
            btnNew.Enabled = _pm.IsAuthorized(PermissionManager.WORKSHOP_APPLICATION,
                                                 _wph.ItemName(WorkshopPermissionHelper.Operation.AddLookUpItem));
            btnDelete.Enabled = _pm.IsAuthorized(PermissionManager.WORKSHOP_APPLICATION,
                                                 _wph.ItemName(WorkshopPermissionHelper.Operation.DeleteLookupItem));
        }
    }
}