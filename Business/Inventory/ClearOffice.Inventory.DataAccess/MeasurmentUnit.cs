using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;

namespace ClearOffice.Inventory.DataAccess
{
 public partial class MeasurementUnit:IDataErrorInfo
    {
        public string Error
        {
            get
            {
                var sb = new StringBuilder();
                sb.Append(this["Name"]);
                return sb.ToString();
            }
        }
        public string this[string columnName]
        {
            get
            {
                if (columnName == "Name")
                {
                    if (string.IsNullOrEmpty(Name))
                        return "Measurment name is required";
                }
                return string.Empty;
            }
        }
    }
}
