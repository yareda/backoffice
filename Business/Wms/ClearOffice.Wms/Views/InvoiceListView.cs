using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using ClearOffice.Infrastructure;
using ClearOffice.Security;
using ClearOffice.Wms.Business;
using DevExpress.XtraEditors;
using System.Linq;

namespace ClearOffice.Wms.Views
{
    public partial class FrmInvoiceListView : DevExpress.XtraEditors.XtraForm, IListForm,IDetailForm
    {
        private WmsEntities _context;
        private Invoice _invoice;
        public InvoiceInfo InvoiceListInfo { get; set; }
        private WorkOrder _selectedinvoice;
        private PermissionManager _pm;
        private WorkshopPermissionHelper _wph;
        public FrmInvoiceListView()
        {
            InitializeComponent();
            _pm = PermissionManager.GetPermissionManager();
            _wph = new WorkshopPermissionHelper();
            _context =new WmsEntities();
            _invoice =new Invoice();
            ShowList();

            AuthorizeForm();
        }

        public void ShowList()
        {
          var invoice = _context.InvoiceInfoes.ToList();
            invoicebindingSource.DataSource = invoice;
        }
        
        public void OpenSelectedItem()
        {
            if (_invoice != null)
            {
                var inv = new InvoiceView();
                inv.ShowObject(_invoice);
                inv.MdiParent = this.MdiParent;
                inv.Show();
            }
        }

        public object GetSelectedItem()
        {  
           return invoicebindingSource.Current;
           
        }

        public void RefreshList()
        {
         _context =new WmsEntities();
         invoicebindingSource.DataSource = _context.InvoiceInfoes.ToList();
     
        }

        private void gridControl1_DoubleClick(object sender, EventArgs e)
        {
            if (InvoicegridView.SelectedRowsCount > 0)
            {
                var selected = (InvoiceInfo)InvoicegridView.GetRow((int)InvoicegridView.GetSelectedRows().GetValue(0));
                if (null != selected)
                {
                    _invoice = _context.Invoices.FirstOrDefault(ct => ct.Id == selected.Id);
                }
                OpenSelectedItem();
            }
           
        }

        private void btnRefresh_Click(object sender, EventArgs e)
        {
           RefreshList();
        }

        private void gridControl1_Click(object sender, EventArgs e)
        {
            if (InvoicegridView.SelectedRowsCount > 0)
            {
                var selected = (InvoiceInfo)InvoicegridView.GetRow((int)InvoicegridView.GetSelectedRows().GetValue(0));
                if (null != selected)
                {
                    _invoice = _context.Invoices.FirstOrDefault(ct => ct.Id == selected.Id);

                }
            }
             GetSelectedItem();
             
        }
       
        private void btninvoicedelete_Click(object sender, EventArgs e)
        {
           var result = ViewHelper.ShowConfirmDialog("Are you sure you want to delete the current record?");
            if (result == DialogResult.Yes)
                {
                    try
                    {
                        DeleteObject();
                    }
                    catch (Exception)
                    {
                        ViewHelper.ShowDeleteError();
                    }
                }
                return;
            
        }




        public void DeleteObject()
        {
           try
            {
                _context = new WmsEntities();
                var d = _context.Invoices.First(ct => ct.Id == _invoice.Id);
                _context.DeleteObject(d);
                _context.SaveChanges();
                RefreshList();
               
            }
            catch (Exception)
            {
                throw;
            }
           
        }

        #region Unused
        public void ShowObject(object keyValue)
        {
            throw new NotImplementedException();
        }

        public bool DataChanged()
        {
            throw new NotImplementedException();
        }

        public void SaveChanges()
        {
            throw new NotImplementedException();
        }

        public bool ValidateForm()
        {
            throw new NotImplementedException();
        }
      #endregion Unused

        public void AuthorizeForm()
        {
            btninvoicedelete.Enabled = _pm.IsAuthorized(PermissionManager.WORKSHOP_APPLICATION,
                                                        _wph.ItemName(WorkshopPermissionHelper.Operation.DeleteInvoice));

        }
    }
}