using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.ComponentModel;

namespace ClearOffice.Fleet.Business
{
    public partial class CouponTransaction:IDataErrorInfo
    {            
        public string Error
        {
            get
            {
                var sb = new StringBuilder();
                sb.Append(this["Vehicle"]);
                sb.Append(this["DriverName"]);
                sb.Append(this["TransactionDate"]);
                sb.Append(this["CashAmount"]);
                sb.Append(this["ValueAmount"]);
                sb.Append(this["LeafNo"]);
                return sb.ToString();
            }
        }

        public string this[string columnName]
        {
            get
            {
                if (columnName == "VehicleId")
                {
                    if (null==VehicleId || VehicleId==0)
                        return "Vehicle is required";
                }

                if(columnName=="DriverName")
                {
                    if(string.IsNullOrEmpty(DriverName))
                        return "Driver is required";
                }

                if (columnName == "TransactionDate")
                {
                    if (null == TransactionDate || string.IsNullOrEmpty(TransactionDate.ToString()))
                        return "Filled date is required";
                }

                if(columnName=="CashAmount")
                {
                    if (null == CashAmount || CashAmount <= 0)
                        return "Cash amount is required";
                }

                if(columnName=="ValueAmount")
                {
                    if (null == ValueAmount || ValueAmount <= 0)
                        return "Value amount is required";
                }

                if (columnName == "LeafNo")
                {
                    if (string.IsNullOrEmpty(LeafNo))
                        return "Leaf# is required";
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
