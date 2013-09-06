using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.ComponentModel;
using ClearOffice.Infrastructure;

namespace ClearOffice.Hrm.Business.Data
{
    public partial class EmployeeLeave:IDataErrorInfo,IEntity
    {
        public string Error
        {
            get
            {
                var sb = new StringBuilder();
                sb.Append(this["From"]);
                sb.Append(this["To"]);
                sb.Append(this["NumDays"]);
                return sb.ToString();
            }
        }

        public string this[string columnName]
        {
            get
            {
                if (columnName == "From")
                {
                    if (From == null)
                        return "Request From is required";
                }
                if (columnName == "To")
                {
                    if (To == null)
                        return "Request to is required";
                }
                if (columnName == "NumDays")
                {
                    if (string.IsNullOrEmpty(NumDays.ToString()))
                    {
                        return "Number of days is required";
                    }
                }
                return string.Empty;
            }
        }

        public bool IsValid()
        {
            return Error == string.Empty;
        }

        public bool IsNew { get; set; }
        public bool IsDirty { get; set; }
    }
}
