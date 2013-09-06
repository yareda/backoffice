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
using System;

namespace ClearOffice.Wms.Views
{
    public partial class PaymentsView : DevExpress.XtraEditors.XtraForm, IDetailForm
    {
        private WmsEntities _context;
        public PaymentRecord PaymentRecord { get; set; }
        public PaymentRecord Payment;
        private double _invoiceTotal;
        private double _paymenttotal;
        private PermissionManager _pm;
        private WorkshopPermissionHelper _wph;
        public PaymentRecord CurrentObject
        {
            get { return Payment; }
        }

        public PaymentsView()
        {
            InitializeComponent();
            _context = new WmsEntities();
            _pm = PermissionManager.GetPermissionManager();
            _wph = new WorkshopPermissionHelper();

            AuthorizeForm();
        }

        public double InvoiceTotal
        {
            set { this._invoiceTotal = value; }
        }

        public double PaymentTotal
        {
            set { this._paymenttotal = value; }
            get { return _paymenttotal; }
        }

        public void ShowObject(object keyValue)
        {
            Payment = keyValue as PaymentRecord;
            PaymentbindingSource.DataSource = Payment;
            if (Payment != null && (Payment.PaymentId == 0 && Payment.PaymentMethod == null))
            {
                Text = @"New Payment Records";
                Payment.PaymentMethod = Convert.ToInt32(PaymentMethods.Cash);
            }
            if (Payment != null && Payment.PaymentId != 0)
            {
                Text = @"Edit Payment Records";
                switch (Payment.PaymentMethod)
                {
                    case (int) PaymentMethods.Cheque:
                        checkNoTextBox.Text = Payment.Reference;
                        break;
                    case (int) PaymentMethods.BankTransfer:
                        bankTransferTextBox.Text = Payment.Reference;
                        break;
                    case (int) PaymentMethods.Other:
                        othersTextBox.Text = Payment.Reference;
                        break;
                }
                //PaymentTotal = PaymentTotal - Convert.ToDouble(Payment.AmountReceived);
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
            PaymentbindingSource.EndEdit();
            Payment = (PaymentRecord)PaymentbindingSource.DataSource;
            if (Payment != null)
            {
                switch (Payment.PaymentMethod)
                {
                    case 5:
                        Payment.Reference = null;
                        break;
                    case 6:
                        Payment.Reference = checkNoTextBox.Text;
                        break;
                    case 7:
                        Payment.Reference = bankTransferTextBox.Text;
                        break;
                    case 8:
                        Payment.Reference = othersTextBox.Text;
                        break;
                }           
            }
            DialogResult = DialogResult.OK;
        }



        public bool ValidateForm()
        {       
            var c1 = Convert.ToDouble(Payment.AmountReceived);
            var c2 = _paymenttotal;
            double val = c1 + c2;
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

            if (_invoiceTotal < val)
            {
                ViewHelper.ShowErrorMessage(
                    "You cannot add payment! The Amount of payment recieved has exceded the amount of invoice total");
                DialogResult = DialogResult.Cancel;
                return false;
            }
            return true;
        }

        private void btnpySave_Click(object sender, EventArgs e)
        {
            SaveChanges();
        }

        private void radioGroup1_SelectedIndexChanged(object sender, System.EventArgs e)
        {
            var selected = radioGroup1.EditValue;

            try
            {
                checkNoTextBox.Enabled = Payment.PaymentMethod == Convert.ToInt32(PaymentMethods.Cheque);
                bankTransferTextBox.Enabled = Payment.PaymentMethod == Convert.ToInt32(PaymentMethods.BankTransfer);
                othersTextBox.Enabled = Payment.PaymentMethod == Convert.ToInt32(PaymentMethods.Other);
            }
            catch (Exception) { }

            if (!selected.Equals(DBNull.Value))
            {
                switch (Payment.PaymentMethod)
                {
                    case (int)PaymentMethods.Cash:
                        checkNoTextBox.Enabled = false;
                        bankTransferTextBox.Enabled = false;
                        othersTextBox.Enabled = false;
                        break;
                    case (int)PaymentMethods.Cheque:
                        checkNoTextBox.Enabled = true;
                        checkNoTextBox.Text = Payment.Reference;
                        bankTransferTextBox.Enabled = false;
                        othersTextBox.Enabled = false;
                        break;
                    case (int)PaymentMethods.BankTransfer:
                        bankTransferTextBox.Enabled = true;
                        bankTransferTextBox.Text = Payment.Reference;
                        checkNoTextBox.Enabled = false;
                        othersTextBox.Enabled = false;
                        break;
                    case (int)PaymentMethods.Other:
                        othersTextBox.Enabled = true;
                        othersTextBox.Text = Payment.Reference;
                        checkNoTextBox.Enabled = false;
                        bankTransferTextBox.Enabled = false;

                        break;
                }
            }
        }



        public void DeleteObject()
        {
            throw new NotImplementedException();
        }


        public void AuthorizeForm()
        {
            btnpySave.Enabled = _pm.IsAuthorized(PermissionManager.WORKSHOP_APPLICATION,
                                                             _wph.ItemName(
                                                                 WorkshopPermissionHelper.Operation.UpdateRecordPayment));
        }

        private void btnCancel_Click(object sender, System.EventArgs e)
        {
            this.Close();
        }
    }

}