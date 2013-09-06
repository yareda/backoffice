using System;
using System.Data;
using System.Linq;
using ClearOffice.Infrastructure;
using ClearOffice.Security;
using ClearOffice.Wms.Business;

namespace ClearOffice.Wms.Views
{
    public partial class LookupEdit : DevExpress.XtraEditors.XtraForm, IDetailForm
    {
        private WmsEntities _context;
        private bool newMode;
        private Lookup _category;
        private LookupItem _item;
        private LookupView _lookupView;
        private PermissionManager _pm;
        private WorkshopPermissionHelper _wph;
        public LookupEdit()
        {
            InitializeComponent();
            _context=new WmsEntities();
            _pm = PermissionManager.GetPermissionManager();
            _wph = new WorkshopPermissionHelper();

            AuthorizeForm();
        }

        public void ShowObject(object keyValue)
        {
            if (keyValue == null)
            {
                _item = new LookupItem { LookupId = _category.LookupId };
                this.lookupItemBindingSource.DataSource = _item;
                newMode = true;
            }
            else
            {
                newMode = false;
                var item = _context.LookupItems.FirstOrDefault(li => li.ItemId == (int) keyValue);
                lookupItemBindingSource.DataSource = item;
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
            var Item = (LookupItem) lookupItemBindingSource.DataSource;
            if (newMode)
            {
                var lr = (from l in _context.LookupItems
                          select l).OrderByDescending(l => l.ItemId).FirstOrDefault();
                Item.ItemId = lr.ItemId + 1;
                _context.LookupItems.AddObject(Item);
            }
            try
            {
               _context.SaveChanges();
                this.Close();
                _lookupView.RefreshList();
            }
            catch(Exception e)
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
          bool result = true;
           if(nameTextBox.Text==string.Empty)
           {
               errorProvider.SetError(nameTextBox,"Name is reqirde");
               return false;
           }

           if (result) return true;
           return false;
        }

        private void saveToolStripButton_Click(object sender, EventArgs e)
        {
            SaveChanges();
        }

        private void lookupItemBindingSource_CurrentChanged(object sender, EventArgs e)
        {

        }

        internal void NewItem(Lookup category)
        {
            _category = category;
            _item = new LookupItem { LookupId = _category.LookupId };
            this.lookupItemBindingSource.DataSource = _item;
            newMode= true;
        }

        internal void SetCatagory(Lookup category)
        {
            _category = category;
        }

        internal void SetLookUpView(LookupView lookupView)
        {
            _lookupView = lookupView;
        }

        private void panelControl1_Paint(object sender, System.Windows.Forms.PaintEventArgs e)
        {

        }

        private void codeLabel_Click(object sender, EventArgs e)
        {

        }

        private void descriptionLabel_Click(object sender, EventArgs e)
        {

        }

        private void nameTextBox_TextChanged(object sender, EventArgs e)
        {

        }

        private void nameLabel_Click(object sender, EventArgs e)
        {

        }

        private void codeTextBox_TextChanged(object sender, EventArgs e)
        {

        }

        private void descriptionTextBox_TextChanged(object sender, EventArgs e)
        {

        }


        public void AuthorizeForm()
        {
            saveToolStripButton.Enabled = _pm.IsAuthorized(PermissionManager.WORKSHOP_APPLICATION,
                                                 _wph.ItemName(WorkshopPermissionHelper.Operation.AddLookUpItem));
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}