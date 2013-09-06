using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.ComponentModel;

namespace ClearOffice.Fleet.Business
{
    public partial class Tire:IDataErrorInfo
    {            
        public string Error
        {
            get
            {
                var sb = new StringBuilder();
                sb.Append(this["SerialNo"]);
                sb.Append(this["PurchasedDate"]);
                return sb.ToString();
            }
        }

        public string this[string columnName]
        {
            get
            {
                if (columnName == "SerialNo")
                {
                    if (string.IsNullOrEmpty(SerialNo))
                        return "SerialNo is required";
                }

                if (columnName == "PurchasedDate")
                {
                    if (PurchasedDate==null)
                        return "Purchase date is required";
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
