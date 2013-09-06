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
    public partial class InvoiceView : DevExpress.XtraEditors.XtraForm, IDetailForm,IListForm
    {
        private WmsEntities _context;
        private static Invoice _invoice;
        private bool _newMode;
        public Invoice Invoice { get; set; }
        public MiscellaneousItems MiscellaneousItems { get; set; }
        public PaymentRecord PaymentRecord { get; set; }
        private PermissionManager _pm;
        private WorkshopPermissionHelper _wph;
        public InvoiceView()
        {
            InitializeComponent();
           _context = new WmsEntities();
            _pm = PermissionManager.GetPermissionManager();
            _wph = new WorkshopPermissionHelper();

            AuthorizeForm();
        }

        public void ShowObject(object keyValue)
        {
         if (keyValue == null) 
         {
                _newMode = true;
                _invoice =new Invoice();
                 InvoicebindingSource.DataSource = _invoice;
                LoadLookups();
                miscelaneousbindingSource.DataSource = _invoice.MiscellaneousItem;
                paymentbindingSource.DataSource = _invoice.PaymentRecord;                    
                txtamount.Text = 0.ToString("#,##0.00");
                txtMiscTotal.Text = 0.ToString("#,##0.00");
                txtpayment.Text = 0.ToString("#,##0.00");
                txtInvoiceTotal.Text = 0.ToString("#,##0.00");
                btnInvoicDelete.Enabled = false;
                Text = @"New Invoice";
            }
            else 
            {
                 var invo = (Invoice)keyValue;
                 _newMode = false;
                _invoice = _context.Invoices.FirstOrDefault(il => il.Id == invo.Id);
                InvoicebindingSource.DataSource = _invoice;
                if (_invoice != null)
                {
                    miscelaneousbindingSource.DataSource = _invoice.MiscellaneousItem;
                    paymentbindingSource.DataSource = _invoice.PaymentRecord;
                }
                txtMiscTotal.Text = CalculateMiscilaneousTotal(invo.Id).ToString("#,##0.00");
                txtpayment.Text = CalculatePaymentTotal(invo.Id).ToString("#,##0.00");
                CalculateInvoiceTotal();
                LoadLookups();
                Text = @"Edit Invoice";
                
            }
            
           
            
        }

        private void LoadLookups()
        {
            workorderbindingSource.DataSource = _context.WorkOrderValueTotals.ToList();
            var methodList = _context.LookupItems.Where(li => li.LookupId == (int)LookupItems.PaymentMethod);
            paymentMethodBindingSource.DataSource = methodList.ToList();

        }

        public bool DataChanged()
        {
            return _context.ObjectStateManager.GetObjectStateEntries(EntityState.Added | EntityState.Modified |
                                                                     EntityState.Deleted).Any();
        }

        public void SaveChanges()
        {
            if(!ValidateForm())return;
            InvoicebindingSource.EndEdit();
            _invoice = (Invoice)InvoicebindingSource.DataSource;

            var rt = GetPaymentTotal();
            var it = GetInvoiceTotal();
            if (rt == it)
            {
                _invoice.Status = (int)InvoiceStatuses.PaidInFull;
            }
            else if(rt<it)
            {
                _invoice.Status = (int) InvoiceStatuses.OutStanding;
            }
            if (_newMode)
            {
                _context.Invoices.AddObject(_invoice);
            }
            try
            {
             _context.SaveChanges();
              _newMode = false;
            }

            catch (Exception ex)
            {
                ViewHelper.ShowErrorMessage("Error occured while saving the current invoice.", ex);
                return;
            }
        }

        public void DeleteObject()
        {
            if (_invoice != null)
            {
                InvoicebindingSource.EndEdit();
                _invoice = (Invoice) InvoicebindingSource.DataSource;
                try
                {
                    foreach(var p in _invoice.MiscellaneousItem.ToList())
                    {
                        if (p.MisPartId == 0)
                            _invoice.MiscellaneousItem.Remove(p);
                        else
                            _context.MiscellaneousItems.DeleteObject(p);
                    }
                    foreach (var pr in _invoice.PaymentRecord.ToList())
                    {
                        if (pr.PaymentId == 0)
                            _invoice.PaymentRecord.Remove(pr);
                        else
                            _context.PaymentRecords.DeleteObject(pr);
                    }
                    _context.DeleteObject(_invoice);
                    _context.SaveChanges();
                    Close();
                }
                catch (Exception e)
                {
                    ViewHelper.ShowDeleteError();
                    ErrorLogger.LogError(this, e);
                }
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



        private void btnInvoiceSave_Click(object sender, EventArgs e)
        {
            SaveChanges();
            btnInvoicDelete.Enabled = true;
            txtMiscTotal.Text = CalculateMiscilaneousTotal(_invoice.Id).ToString("#,##0.00");
            txtpayment.Text = CalculatePaymentTotal(_invoice.Id).ToString("#,##0.00");
            CalculateInvoiceTotal();
           
        }

        private void btnInvoicDelete_Click(object sender, EventArgs e)
        {
            var result = ViewHelper.ShowConfirmDialog("Are you sure, you want to delete the current record?");
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
            else
            {
                return;
            }
            return;
        }

        private void leWorkorder_EditValueChanged(object sender, EventArgs e)
        {
            if (leWorkorder.EditValue != DBNull.Value)
            {
                var workorderValueTotal =_context.WorkOrderValueTotals.Where(woc => woc.WorkOrderId == (int) leWorkorder.EditValue).FirstOrDefault();
                var workOrder = _context.WorkOrders.FirstOrDefault(wo => wo.WorkOrderId == (int) leWorkorder.EditValue);
                if (workOrder != null)
                {
                    if (workorderValueTotal != null)
                    {
                        string customerName = workorderValueTotal.Name;
                        string address = workorderValueTotal.Address;
                        string city = workorderValueTotal.City;
                        string contact = workorderValueTotal.Contact;
                        txtBillTo.Text = customerName + Environment.NewLine + address + Environment.NewLine + city +
                                         Environment.NewLine + contact + Environment.NewLine;
                       
                    }

                    txtamount.Text = Convert.ToDouble(workOrder.TotalCost).ToString("#,##0.00");
                    CalculateInvoiceTotal();
                }
            }
        }

        private void btnPyNew_Click(object sender, EventArgs e)
        {
            var paymenteditor = new PaymentsView();
            var pmt = new PaymentRecord();
            paymenteditor.ShowObject(pmt);
            paymenteditor.InvoiceTotal = GetInvoiceTotal();
            paymenteditor.PaymentTotal = GetPaymentTotal();
             var result = paymenteditor.ShowDialog();
            if(result == DialogResult.OK)
            {
                _invoice.PaymentRecord.Add(paymenteditor.CurrentObject);
            }
        }

        private void btnMiNew_Click(object sender, EventArgs e)
        {
            var misceditor = new MicilaneousView();
            var misc = new MiscellaneousItems();
            misceditor.ShowObject(misc);
            var result= misceditor.ShowDialog();
            if (result == DialogResult.OK)
             {
                _invoice.MiscellaneousItem.Add(misceditor.CurrentObject);
             }          
        }

        private void btnMiRefresh_Click(object sender, EventArgs e)
        {
            RefreshList();
        }

       private void btnPyRefresh_Click(object sender, EventArgs e)
        {
            RefreshList();
        }


        private double CalculateMiscilaneousTotal(int pt)
        {
            var miscellaneousItemses = _context.MiscellaneousItems.Where(m => m.InvoiceId == pt).ToList();
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
            var paymentnfos = _context.PaymentRecords.Where(pi => pi.InvoiceId == p).ToList();
            double paymentrecieved = 0;
            foreach (var pr in paymentnfos)
            {
                if (pr.AmountReceived != null)
                    paymentrecieved += Convert.ToDouble(pr.AmountReceived);

            }
            return paymentrecieved;
        }
        private double GetInvoiceTotal()
        {
            double total = 0;
            if (txtamount.Text != "")
            {
                var c1 = Convert.ToDouble(txtamount.Text);
                if (txtMiscTotal.Text != "")
                {
                    var c2 = Convert.ToDouble(_invoice.MiscellaneousItem.Sum(m=>m.UnitPrice*m.Quantity));
                    try
                    {
                        total = c1 + c2;
                    }
                    catch
                    {
                        throw;
                    }
                }
            }
            return total;
        }
        public double GetPaymentTotal()
        {
            var result = Convert.ToDouble(_invoice.PaymentRecord.Sum(p => p.AmountReceived));
            return result;
        }
        public void CalculateInvoiceTotal()
        {
          if (txtamount.Text != "")
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
          }


        private void gridControl1_DoubleClick(object sender, EventArgs e)
        {
            var selectedmiscelaneous= miscelaneousbindingSource.Current as MiscellaneousItems;
            var editmisc = new MicilaneousView ();
            editmisc.ShowObject(selectedmiscelaneous);
            var result = editmisc.ShowDialog();
            if(result ==DialogResult.OK)
            {
                _invoice.MiscellaneousItem.Add(editmisc.CurrentObject);
            }
            
         }

        private void gridControl2_DoubleClick(object sender, EventArgs e)
        {
            var selectedpayment = paymentbindingSource.Current as PaymentRecord;
            var editpayment = new PaymentsView();
            //var pay = _context.PaymentRecords.FirstOrDefault(pr => pr.PaymentId == selectedpayment.PaymentId);
            editpayment.InvoiceTotal = GetInvoiceTotal();
            editpayment.PaymentTotal = GetPaymentTotal();
            editpayment.ShowObject(selectedpayment);
            var result = editpayment.ShowDialog();
            if(result == DialogResult.Cancel)return;
            if(result == DialogResult.OK)
            {
                _invoice.PaymentRecord.Add(editpayment.CurrentObject);
            }
        }


        private void btnDeleteMISC_Click(object sender, EventArgs e)
        {
            var selected = miscelaneousbindingSource.Current as MiscellaneousItems;
            if(selected!=null)
            {
                var result = ViewHelper.ShowConfirmDialog("Are you sure you want to delete this miscellaneous?");
                if (result == DialogResult.Yes)
                {
                    if(selected.MisPartId == 0)
                        _invoice.MiscellaneousItem.Remove(selected);
                    else
                        _context.MiscellaneousItems.DeleteObject(selected);
                }
            }
        }

        private void btnDeletePayment_Click(object sender, EventArgs e)
        {
            var selected = paymentbindingSource.Current as PaymentRecord;
            if (selected != null)
            {
                var result = ViewHelper.ShowConfirmDialog("Are you sure you want to delete this payament ?");
                if (result == DialogResult.Yes)
                {
                    if(selected.PaymentId == 0)
                        _invoice.PaymentRecord.Remove(selected);
                    else
                        _context.PaymentRecords.DeleteObject(selected);
                }
            }
        }

        private void gridControl1_Click(object sender, EventArgs e)
        {
            var data = miscelaneousbindingSource.Current as MiscellaneousItems;
            if (data != null)
            {
                btnDeleteMISC.Enabled = true;
            }
            AuthorizeForm();
        }

        private void gridControl2_Click(object sender, EventArgs e)
        {
            var data = paymentbindingSource.Current as PaymentRecord;
            if (data != null)
            {
                btnDeletePayment.Enabled = true;
            }
            AuthorizeForm();
        }

        public void RefreshList()
        {
            if (Invoice != null)
            {
                _invoice = new Invoice();
                paymentbindingSource.DataSource = _context.PaymentRecords.Where(p => p.InvoiceId == Invoice.Id);
                miscelaneousbindingSource.DataSource = _context.MiscellaneousItems.Where(m => m.InvoiceId == Invoice.Id);
            }

        }
        public void ShowList()
        {
            throw new NotImplementedException();
        }

        public object GetSelectedItem()
        {
            throw new NotImplementedException();
        }
        public void OpenSelectedItem()
        {
            throw new NotImplementedException();
        }

        public void AuthorizeForm()
        {
            btnInvoiceSave.Enabled = _pm.IsAuthorized(PermissionManager.WORKSHOP_APPLICATION,
                                                      _wph.ItemName(WorkshopPermissionHelper.Operation.GenerateInvoice));
            btnInvoicDelete.Enabled = _pm.IsAuthorized(PermissionManager.WORKSHOP_APPLICATION,
                                                       _wph.ItemName(WorkshopPermissionHelper.Operation.DeleteInvoice));
            btnMiNew.Enabled = _pm.IsAuthorized(PermissionManager.WORKSHOP_APPLICATION,
                                                _wph.ItemName(WorkshopPermissionHelper.Operation.AddNewMicelaneousItem));
            btnDeleteMISC.Enabled = _pm.IsAuthorized(PermissionManager.WORKSHOP_APPLICATION,
                                                     _wph.ItemName(
                                                         WorkshopPermissionHelper.Operation.DeleteMicelaneousItem));
            btnPyNew.Enabled = _pm.IsAuthorized(PermissionManager.WORKSHOP_APPLICATION,
                                                _wph.ItemName(WorkshopPermissionHelper.Operation.RecordPayment));
            btnDeletePayment.Enabled = _pm.IsAuthorized(PermissionManager.WORKSHOP_APPLICATION,
                                                        _wph.ItemName(
                                                            WorkshopPermissionHelper.Operation.DeletePaymentRecord));

        }
    }


}

