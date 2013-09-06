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
    public partial class NewPayment : DevExpress.XtraEditors.XtraForm, IDetailForm, IListForm
    {
        private WmsEntities _context;
        private bool _newMode;
        public PaymentRecord _paymentRecord;
        public Invoice Invoice { get; set; }
        public PaymentRecord CurrentObject
        {
            get { return _paymentRecord; }
        }
        private InvoiceInfo _invoiceListInfo;
        private PermissionManager _pm;
        private WorkshopPermissionHelper _wph;
        public NewPayment()
        {
            InitializeComponent();
            _context = new WmsEntities();
            _pm = PermissionManager.GetPermissionManager();
            _wph = new WorkshopPermissionHelper();

            AuthorizeForm();
        }

        public void ShowObject(object keyValue)
        {
            var value = (InvoiceInfo)keyValue;
            _invoiceListInfo = value;
            _paymentRecord = new PaymentRecord {InvoiceId = value.Id};
            PaymentbindingSource.DataSource = _paymentRecord;
           if (keyValue != null) _newMode = true;
            if (_newMode &&(_paymentRecord.PaymentId ==0 && _paymentRecord.PaymentMethod==null))
            {
                Text = string.Format("Payment for Invoice#: {0}", value.InvoiceNo);
                _paymentRecord.PaymentMethod = Convert.ToInt32(PaymentMethods.Cash);
                // LoadPayment();
            }

        }

        private void LoadPayment()
        {
            if (_newMode)
            {
                radioGroup1.EditValue = 5;
                checkNoTextBox.Enabled = false;
                bankTransferTextBox.Enabled = false;
                othersTextBox.Enabled = false;
            }
        }

        public bool DataChanged()
        {
            return _context.ObjectStateManager.GetObjectStateEntries(EntityState.Added | EntityState.Modified |
                                                                     EntityState.Deleted).Any();
        }

        public void SaveChanges()
        {
            var iv = _context.Invoices.FirstOrDefault(i=>i.Id == _paymentRecord.InvoiceId);
            if (!ValidateForm()) return;
            var rt = (Convert.ToDouble(_invoiceListInfo.RecievedTotal) + Convert.ToDouble(_paymentRecord.AmountReceived));
            if(rt>Convert.ToDouble(_invoiceListInfo.InvoiceTotal))
            {
                ViewHelper.ShowErrorMessage("the amount of recieved total has exceeded the amount of invoice total?");
                Close();
                return;
            }
            PaymentbindingSource.EndEdit();
            _paymentRecord = (PaymentRecord) PaymentbindingSource.DataSource;
            if (_newMode)
                _context.PaymentRecords.AddObject(_paymentRecord);
            if (rt == Convert.ToDouble(_invoiceListInfo.InvoiceTotal))
                iv.Status = (int)InvoiceStatuses.PaidInFull;
            try
            {
                switch (_paymentRecord.PaymentMethod)
                {
                    case 5:
                        _paymentRecord.Reference = null;
                        break;
                    case 6:
                        _paymentRecord.Reference = checkNoTextBox.Text;
                        break;
                    case 7:
                        _paymentRecord.Reference = bankTransferTextBox.Text;
                        break;
                    case 8:
                        _paymentRecord.Reference = othersTextBox.Text;
                        break;
                }
                _context.SaveChanges();
                 Close();
            }

            catch (Exception)
            {
                ViewHelper.ShowSaveError();
                return;
            }


        }


        public bool ValidateForm()
        {
            if (amountReceivedTextBox.Text == string.Empty)
            {
                errorProvider1.SetError(amountReceivedTextBox, "Amount Recieved is required");
                return false;
            }
            if (paymentDateEdit.Text == string.Empty)
            {
                errorProvider1.SetError(paymentDateEdit, "Payment Date is required");
                return false;
            }
            return true;
        }

        private void btnpySave_Click(object sender, EventArgs e)
        {
            SaveChanges();
        }



        private void radioGroup1_SelectedIndexChanged(object sender, EventArgs e)
        {
          var selected = radioGroup1.EditValue;

            try
            {
                checkNoTextBox.Enabled = _paymentRecord.PaymentMethod == Convert.ToInt32(PaymentMethods.Cheque);
                bankTransferTextBox.Enabled = _paymentRecord.PaymentMethod == Convert.ToInt32(PaymentMethods.BankTransfer);
                othersTextBox.Enabled = _paymentRecord.PaymentMethod == Convert.ToInt32(PaymentMethods.Other);
            }
            catch (Exception) { }

            if (!selected.Equals(DBNull.Value))
            {
                switch ((int)selected)
                    {
                        case 5:
                            checkNoTextBox.Enabled = false;
                            bankTransferTextBox.Enabled = false;
                            othersTextBox.Enabled = false;
                            break;
                        case 6:
                            checkNoTextBox.Enabled = true;
                            checkNoTextBox.Text = _paymentRecord.Reference;
                            bankTransferTextBox.Enabled = false;
                            othersTextBox.Enabled = false;
                            break;
                        case 7:
                            bankTransferTextBox.Enabled = true;
                            bankTransferTextBox.Text = _paymentRecord.Reference;
                            checkNoTextBox.Enabled = false;
                            othersTextBox.Enabled =false;
                            break;
                        case 8:
                            othersTextBox.Enabled = true;
                            othersTextBox.Text = _paymentRecord.Reference;
                            checkNoTextBox.Enabled = false;
                            bankTransferTextBox.Enabled = false;
                            break;
                    }
            }
        }
         
        public void ShowList()
        {
            throw new NotImplementedException();
        }

        public void OpenSelectedItem()
        {
            throw new NotImplementedException();
        }

        public object GetSelectedItem()
        {
            throw new NotImplementedException();
        }

        public void RefreshList()
        {
            throw new NotImplementedException();
        }

        public void DeleteObject()
        {
            throw new NotImplementedException();
        }

        public void AuthorizeForm()
        {
            btnpySave.Enabled = _pm.IsAuthorized(PermissionManager.WORKSHOP_APPLICATION,
                                                 _wph.ItemName(WorkshopPermissionHelper.Operation.RecordPayment));
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }

    }
 }
