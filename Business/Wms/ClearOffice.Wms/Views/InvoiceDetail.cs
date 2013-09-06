using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using ClearOffice.Wms.Business;
using DevExpress.XtraEditors;
using ClearOffice.Infrastructure;
using System.Windows.Forms;

namespace ClearOffice.Wms.Views
{
    public partial class InvoiceDetail : DevExpress.XtraEditors.XtraForm, IDetailForm, IListForm
    {
        private WmsEntities _context;
        private bool _newMode;
        private Invoice _invoice;
        private MiscellaneousItems   _miscellaneous;
        private PaymentRecord _paymentRecord;
        public Invoice Invoice { get; set; }
        private MiscellaneousItems miscellaneousItems { get; set; }
        private PaymentRecord paymentRecord { get; set; }
      

        public InvoiceDetail()
        {
            InitializeComponent();
            _context = new WmsEntities();
          
           
        }
        public void ShowObject(object keyValue)
        {
           var invo = (Invoice)keyValue;
                if (invo != null)
                {
                   InvoiceDetailbindingSource.DataSource = _invoice;
                   _invoice = _context.Invoices.FirstOrDefault(iv => iv.Id == invo.Id);
                    InvoiceDetailbindingSource.DataSource = _invoice;
                    miscinfoBindingSource.DataSource = _invoice.MiscellaneousItems;
                    paymentinfobindingSource.DataSource = _invoice.PaymentRecord;
                    txtMiscTotal.Text = CalculateMiscilaneousTotal(invo.Id).ToString("#,##0.00");
                    txtpayment.Text = CalculatePaymentTotal(invo.Id).ToString("#,##0.00");
                    CalculateInvoiceTotal();
                    LoadLookups();
                }
            }
   
        private void LoadLookups()
        {
            workorderBindingSource.DataSource = _context.WorkOrderValueTotals.ToList();
        }

        public bool DataChanged()
        {
            return _context.ObjectStateManager.GetObjectStateEntries(EntityState.Added | EntityState.Modified |
                                             EntityState.Deleted).Any();
           
        }

        public void SaveChanges()
        {
            InvoiceDetailbindingSource.EndEdit();
            _invoice = (Invoice)InvoiceDetailbindingSource.DataSource;
            try
            {
                _context.SaveChanges();
                
            }

            catch (Exception)
            {
                ViewHelper.ShowSaveError();
                return;
            }
        }

        public void DeleteObject()
        {
            if (_newMode) return;
            InvoiceDetailbindingSource.EndEdit();
            var invoice = (Invoice) InvoiceDetailbindingSource.DataSource;
           try
            {
               //_context.Invoices.DeleteObject(invoice);
               _context.SaveChanges();
               Close();
            }
            catch (Exception e)
            {
                ViewHelper.ShowDeleteError();
                ErrorLogger.LogError(this, e);
            }            
        }

        public bool ValidateForm()
        {     
            
            if (leWorkorder.Text == string.Empty)
            {
                errorProvider1.SetError(leWorkorder, "Workorder should be selected");
                return false;
            }
            if (txtInvoiceNo.Text == string.Empty)
            {
                errorProvider1.SetError(txtInvoiceNo, "Invoice Number is required");
                return false;
            }

       
            return true;
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            SaveChanges();
            
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            if (_invoice != null)
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
        }

        private void btnMiNew_Click(object sender, EventArgs e)
        {
            var misceditor = new MicilaneousView();
            misceditor.NewInvoice= this;
            misceditor.ShowObject(null);
            misceditor.ShowDialog();
            
        }

        private void btnPyNew_Click(object sender, EventArgs e)
        {
            var editor = new PaymentsView();
            editor.Invoicedetail = this;
            editor.ShowObject(null);
            editor.ShowDialog();
        }

        private void leWorkorder_EditValueChanged(object sender, EventArgs e)
        {
            if (leWorkorder.EditValue != DBNull.Value)
            {
                var workorder =
                    _context.WorkOrderValueTotals.FirstOrDefault(woc => woc.WorkOrderId == (int)leWorkorder.EditValue);
                if (workorder != null)
                {
                    string customerName = workorder.Name;
                    double quantity = Convert.ToDouble(workorder.PartTotal);
                    double unitcost = Convert.ToDouble(workorder.LaborTotal);
                    string address = workorder.Address;
                    string city = workorder.City;
                    string contact = workorder.Contact;
                    txtBillTo.Text = customerName + Environment.NewLine + address + Environment.NewLine + city +
                                     Environment.NewLine + contact + Environment.NewLine;

                    txtamount.Text = (quantity + unitcost).ToString("#,##0.00");
                    CalculateInvoiceTotal();
                    
                }
            }
           }


        public void CalculateInvoiceTotal()
        {
            if (txtamount.Text != "")
                //if the workorder amount is from the edit value changed // if (txtamount.Text != null)
            {
                var c1 = Convert.ToDouble(txtamount.Text);
                if (txtMiscTotal.Text != "")
                {
                    var c2 = Convert.ToDouble(txtMiscTotal.Text);
                    try
                    {
                        double val = c1 + c2;
                        txtInvoiceTotal.Text = val.ToString("#,##0.00");
                    }
                    catch (Exception e)
                    {

                        throw;
                    }
                }
            }
            //if (txtpayment.Text != string.Empty)
            //{
            //    var py = Convert.ToDouble(txtpayment.Text);
            //    if (txtInvoiceTotal.Text != string.Empty)
            //    {
            //        var it = Convert.ToDouble(txtInvoiceTotal.Text);
            //        if (py >= it)
            //        {
            //            var result =
            //                ViewHelper.ShowConfirmDialog("You can'not add new payment! the amount of payment recieved has exceded the amount of invoice total ");
            //            if (result == DialogResult.Yes) 
            //            {
            //                btnPyNew.Enabled = false;
            //            }
            //            else
            //            {
            //                btnPyNew.Enabled = false;
            //            }

            //        }
            //    }
            //}
            
        }
        private double CalculateMiscilaneousTotal(int pt)
        {
          
            var miscellaneousItemses = _context.MiscellaneousItemsInfoes.Where(m => m.InvoiceId == pt).ToList();
            double miscitemstotal = 0;
            foreach (var p in miscellaneousItemses)
            {
                if (p.Quantity != null)
                    if (p.UnitPrice != null)
                        miscitemstotal += Convert.ToDouble(p.Quantity.Value * p.UnitPrice.Value);
            }
            return miscitemstotal;


        }

        private double CalculatePaymentTotal(int p)
        {
            var paymentinfos = _context.PaymentListInfoes.Where(pi => pi.InvoiceId == p).ToList();
            double paymentrecieved = 0;
            foreach (var pr in paymentinfos)
            {
                if (pr.AmountReceived != null)
                    paymentrecieved += Convert.ToDouble(pr.AmountReceived);

            }
            return paymentrecieved;
         }

        public void ShowList()
        {
          //  var pl =_context.PaymentListInfoes.Where(p => p.InvoiceId == _invoice.Id);
           
        }

        public void OpenSelectedItem()
        {
            if (miscellaneousItems != null)
            {
                var miscdetail = new MicilaneousView();
                miscdetail.ShowObject(_miscellaneous);
                miscdetail.Dock = DockStyle.Fill;
                miscdetail.ShowDialog();
            }
       }

        public void OpenSelected()
        {
            if (_paymentRecord != null)
            {
                var paymentdetail = new PaymentsView();
                paymentdetail.ShowObject(_paymentRecord);
                paymentdetail.Dock = DockStyle.Fill;
                paymentdetail.ShowDialog();
            }
        }

        public object GetSelectedItem()
        {
            throw new NotImplementedException();
        }

        public void RefreshList()
        {
            _context =new WmsEntities();
            miscinfoBindingSource.DataSource = _context.MiscellaneousItemsInfoes.Where(m => m.InvoiceId == _invoice.Id);
            paymentinfobindingSource.DataSource = _context.PaymentListInfoes.Where(p => p.InvoiceId == _invoice.Id);
         }

        private void btnMiRefresh_Click(object sender, EventArgs e)
        {
            RefreshList();
        }

        private void btnPyRefresh_Click(object sender, EventArgs e)
        {
            RefreshList();
        }

        private void gridControl1_DoubleClick(object sender, EventArgs e)
        {
            if (MiscellaneousgridView.SelectedRowsCount > 0)
            {
                var selected = (MiscellaneousItemsInfo)MiscellaneousgridView.GetRow((int)MiscellaneousgridView.GetSelectedRows().GetValue(0));
                if (selected != null)
                {
                    _miscellaneous = _context.MiscellaneousItems.FirstOrDefault(mi => mi.MisPartId == selected.PartId);
                }
                OpenSelectedItem();
            }
        }

        private void gridControl2_DoubleClick(object sender, EventArgs e)
        {
            if (paymentgridView.SelectedRowsCount > 0)
            {
                var selected = (PaymentListInfo)paymentgridView.GetRow((int)paymentgridView.GetSelectedRows().GetValue(0));
                if (selected != null)
                {
                    _paymentRecord = _context.PaymentRecords.FirstOrDefault(pr => pr.PaymentId == selected.PaymentId);
                }
              OpenSelected();
            }
            
        }

        private void miscinfoBindingSource_CurrentItemChanged(object sender, EventArgs e)
        {
          txtMiscTotal.Text = CalculateMiscilaneousTotal(_invoice.Id).ToString("#,##0.00");
          CalculateInvoiceTotal();
       
        }

        private void paymentinfobindingSource_CurrentItemChanged(object sender, EventArgs e)
        {

            txtpayment.Text = CalculatePaymentTotal(_invoice.Id).ToString("#,##0.00");
            if (txtpayment.Text != string.Empty)
            {
                var py = Convert.ToDouble(txtpayment.Text);
                if (txtInvoiceTotal.Text != string.Empty)
                {
                    var it = Convert.ToDouble(txtInvoiceTotal.Text);
                    if (py >= it)
                    {
                        var result = ViewHelper.ShowConfirmDialog("You cannot add new payment! The " +
                                                                 "Amount of payment recieved has exceded the amount of invoice total ");
                        if (result == DialogResult.Yes)
                        {
                            btnPyNew.Enabled = false;
                        }
                        else
                        {
                            btnPyNew.Enabled = false;
                        }

                    }
                    else if(py<=it)
                    {
                        btnPyNew.Enabled = true;
                    }
                }
            }
           
        }

        private void InvoiceDetailbindingSource_CurrentItemChanged(object sender, EventArgs e)
        {
            CalculateInvoiceTotal();
        }




        internal void AddPayment(PaymentRecord paymentrecord)
        {
            _invoice.PaymentRecord.Add(paymentrecord);
        }

        internal void AddmiscItem(MiscellaneousItems micellaneous)
        {
            _invoice.MiscellaneousItems.Add(micellaneous);
        }
    }
}