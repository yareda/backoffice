using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.ComponentModel;

namespace ClearOffice.Fleet.Business
{
    public partial class Coupon : IDataErrorInfo
    {
        public string Error
        {
            get
            {
                var sb = new StringBuilder();
                sb.Append(this["CouponLabel"]);
                sb.Append(this["PurchasedFrom"]);
                sb.Append(this["DatePurchased"]);
                sb.Append(this["CashValue"]);
                return sb.ToString();
            }
        }

        public string this[string columnName]
        {
            get
            {
                if (columnName == "CouponLabel")
                {
                    if (string.IsNullOrEmpty(CouponLabel))
                        return "CouponLabel is required";
                }

                if (columnName == "PurchasedFrom")
                {
                    if (string.IsNullOrEmpty(PurchasedFrom))
                        return "Purchased from is required";
                }

                if (columnName == "DatePurchased")
                {
                    if (null == DatePurchased || string.IsNullOrEmpty(DatePurchased.ToString()))
                        return "Purchased date is required";
                }

                if (columnName == "CashValue")
                {
                    if (null == CashValue || CashValue <= 0)
                        return "Coupon value is required and should be greater than zero";
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
