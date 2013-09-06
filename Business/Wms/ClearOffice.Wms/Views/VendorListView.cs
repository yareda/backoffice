using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;
using ClearOffice.Infrastructure;
using ClearOffice.Security;
using ClearOffice.Wms.Business;


namespace ClearOffice.Wms.Views
{
    public partial class VendorListView : DevExpress.XtraEditors.XtraForm, IListForm
    {
        private WmsEntities _context;
        private bool _listShown = false;
        private Vendor _venldor;
        private bool _newMode;
        private PermissionManager _pm;
        private WorkshopPermissionHelper _wph;

        public VendorListView()
        {
            InitializeComponent();
            _context = new WmsEntities();
            ShowList();
            _listShown = true;

            _pm = PermissionManager.GetPermissionManager();
            _wph = new WorkshopPermissionHelper();

            AuthorizeForm();
        }

        public object GetSelectedItem()
        {

            Vendor vendor = null;

            if (VendorGridView.SelectedRowsCount > 0)
            {
                var selected = (VendorInfo) VendorGridView.GetRow((int) VendorGridView.GetSelectedRows().GetValue(0));
                if (null != selected)
                {
                  _venldor = _context.Vendors.First(vn => vn.VendorId == selected.VendorId);
                }
            }
            return vendor;

        }

        public void ShowList()
        {
            var vendors = _context.VendorInfoes.ToList();
            VendorDateBindingSource.DataSource = vendors;
        }

        public void OpenSelectedItem()
        {
            if (_venldor != null)
            {
                var vendorDetailView = new VendorDetail();
                vendorDetailView.ShowObject(_venldor);
                vendorDetailView.Dock = DockStyle.Fill;
                vendorDetailView.Show();
            }
        }

        public void RefreshList()
        {
            VendorDateBindingSource.DataSource = LoadAllVendors();
        }

        private IEnumerable<VendorInfo> LoadAllVendors()
        {
            _context = new WmsEntities();
            return _context.VendorInfoes.ToList();
        }

        private void gridControl1_DoubleClick_1(object sender, EventArgs e)
        {
            if (VendorGridView.SelectedRowsCount > 0)
            {
                var selected = (VendorInfo) VendorGridView.GetRow((int) VendorGridView.GetSelectedRows().GetValue(0));
                if (selected != null)
                {
                    _venldor = _context.Vendors.First(ven => ven.VendorId == selected.VendorId);
                }
            }
            OpenSelectedItem();
        }

        private void newToolStripButton_Click_1(object sender, EventArgs e)
        {
            var editor = new NewVendor();
            editor.ShowObject(null);
            editor.Show();
        }

        private void gridControl1_Click(object sender, EventArgs e)
        {
            if (VendorGridView.SelectedRowsCount > 0)
            {
               var selected = (VendorInfo) VendorGridView.GetRow((int) VendorGridView.GetSelectedRows().GetValue(0));
                if (selected!=null)
                {
                    _venldor = _context.Vendors.FirstOrDefault(ven => ven.VendorId == selected.VendorId);
                    btnDelete.Enabled = true;
                }
            }
            AuthorizeForm();
        }

       

        private void toolStripButton2_Click(object sender, EventArgs e)
        {
            RefreshList();
            
        }

        private void toolStripButton3_Click(object sender, EventArgs e)
        {
            DialogResult result = ViewHelper.Conformation("Are you sure you want to delete this vendor information?");
            if (result == DialogResult.Yes)
            {
                if (_newMode) return;
                VendorDateBindingSource.EndEdit();

                try
                {

                    _context.Vendors.DeleteObject(_venldor);
                    _context.SaveChanges();
                    RefreshList();
                }
                catch (Exception ex)
                {
                    ViewHelper.ShowErrorMessage(@"Error deleteing this vendor information.");
                    ErrorLogger.LogError(this, ex);
                }
            }

        }


        public void OpenSelected()
        {
            throw new NotImplementedException();
        }


        public void AuthorizeForm()
        {
            newToolStripButton.Enabled = _pm.IsAuthorized(PermissionManager.WORKSHOP_APPLICATION,
                                                     _wph.ItemName(WorkshopPermissionHelper.Operation.AddVendors));
            btnDelete.Enabled = _pm.IsAuthorized(PermissionManager.WORKSHOP_APPLICATION,
                                                     _wph.ItemName(WorkshopPermissionHelper.Operation.DeleteVendors));
        }
    }

}