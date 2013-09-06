using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using ClearOffice.Infrastructure;
using ClearOffice.Security;
using ClearOffice.Wms.Business;
using DevExpress.XtraEditors;

namespace ClearOffice.Wms.Views
{
    public partial class CustomerListView : DevExpress.XtraEditors.XtraForm, IListForm
    {
        private WmsEntities _context;
        private bool _listShown = false;
        private Customer _customer;
        private bool _newMode;
        private PermissionManager _pm;
        private WorkshopPermissionHelper _wph;
        public CustomerListView()
        {
            InitializeComponent();
            _context = new WmsEntities();
             ShowList();
            _listShown = true;
            _pm = PermissionManager.GetPermissionManager();
            _wph = new WorkshopPermissionHelper();

            AuthorizeForm();
        }

        private void newToolStripButton_Click_1(object sender, EventArgs e)
        {
            var editor = new NewCustomersView();
            editor.ShowObject(null);
            editor.Show();
        }

        public void ShowList()
        {
            //var customers = _context.CustomerInfoes.OrderByDescending(c => c.CustomerId).Distinct().ToList();
            var customers = _context.CustomerListInfoes.OrderByDescending(c => c.Name).ToList();
            CustomerBindingSource.DataSource = customers;
        }

        public void OpenSelectedItem()
        {
            if (_customer != null)
            {
                var customerDetailView = new CustomerDetailView();
                customerDetailView.ShowObject(_customer);
                customerDetailView.MdiParent = this.MdiParent;
                customerDetailView.Show();
            }
        }

        public object GetSelectedItem()
        {
            throw new NotImplementedException();
        }

        public void RefreshList()
        {
            CustomerBindingSource.DataSource = LoadAllCustomers();
        }

        private IEnumerable<CustomerListInfo> LoadAllCustomers()
        {
            _context=new WmsEntities();
            //return _context.CustomerInfoes.Distinct().ToList();
            return _context.CustomerListInfoes.ToList();
        }

        private void gridControl1_Click(object sender, EventArgs e)
        {
            if (CustomersGridView.SelectedRowsCount > 0)
            {

                var selected = (CustomerListInfo)CustomersGridView.GetRow((int)CustomersGridView.GetSelectedRows().GetValue(0));
                if (selected != null)
                {
                    _customer = _context.Customers.FirstOrDefault(cus => cus.CustomerId == selected.CustomerId);
                }
            }
            AuthorizeForm();
        }

        private void gridControl1_DoubleClick_1(object sender, EventArgs e)
        {
            var cinfo = (CustomerListInfo) CustomerBindingSource.Current;
            _customer = _context.Customers.FirstOrDefault(ct => ct.CustomerId == cinfo.CustomerId);
            OpenSelectedItem();
        }

        private void toolStripButton2_Click(object sender, EventArgs e)
        {
            RefreshList();
        }

        private void toolStripButton3_Click(object sender, EventArgs e)
        {
            DialogResult result = ViewHelper.Conformation("Are you sure you want to delete this customer information?");
            if (result == DialogResult.Yes)
            {
                if (_newMode) return;
                CustomerBindingSource.EndEdit();

                try
                {
                    _context.Customers.DeleteObject(_customer);
                    _context.SaveChanges();
                    RefreshList();
                }
                catch (Exception ex)
                {
                    ViewHelper.ShowDeleteError();
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
                                                          _wph.ItemName(WorkshopPermissionHelper.Operation.AddCustomer));
            deleteToolStripButton.Enabled = _pm.IsAuthorized(PermissionManager.WORKSHOP_APPLICATION,
                                                             _wph.ItemName(
                                                                 WorkshopPermissionHelper.Operation.DeleteCustomer));
        }
    }
}