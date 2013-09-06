using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.ComponentModel;

namespace ClearOffice.Fleet.Business
{
    public partial class MaintenancePart:IDataErrorInfo
    {
        public string Error
        {
            get
            {
                var sb = new StringBuilder();
                sb.Append(this["PartNo"]);
                sb.Append(this["UnitPrice"]);
                sb.Append(this["Quantity"]);
                return sb.ToString();
            }
        }

        public string this[string columnName]
        {
            get
            {
                if (columnName == "PartNo")
                {
                    if (string.IsNullOrEmpty(PartNo))
                        return "PartNo required";
                }

                if (columnName == "UnitPrice")
                {
                    if (UnitPrice <=0 )
                        return "Unite price is required";
                }

                if (columnName == "Quantity")
                {
                    if (Quantity<= 0)
                        return "Quantity is required";
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
