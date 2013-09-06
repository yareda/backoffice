using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.ComponentModel;

namespace ClearOffice.Fleet.Business
{
    public partial class Expense : IDataErrorInfo
    {
        public string Error
        {
            get
            {
                var sb = new StringBuilder();
                sb.Append(this["PaymentTypeId"]);
                sb.Append(this["Amount"]);
                sb.Append(this["Invoice"]);
                return sb.ToString();
            }
        }

        public string this[string columnName]
        {
            get
            {
                if (columnName == "PaymentTypeId")
                {
                    if (PaymentTypeId <= 0)
                        return "Payment type is required";
                }
                if (columnName == "Amount")
                {
                    if (Amount == null)
                        return "Amount is required";
                }
                if (columnName == "Invoice")
                {
                    if (Invoice == null)
                        return "Invoice is required";
                }
                return string.Empty;
            }
        }

        public bool IsValid()
        {
            return Error == string.Empty;
        }
    }
}
