using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.ComponentModel;
namespace ClearOffice.Hrm.Business.Data
{
    public partial class EmployeeStatus : IDataErrorInfo
    {
        public string Error
        {
            get
            {
                var sb = new StringBuilder();
                sb.Append(this["Status"]);
                return sb.ToString();
            }
        }

        public string this[string columnName]
        {
            get
            {
                if (columnName == "Status")
                {
                    if (string.IsNullOrEmpty(Status))
                        return "Status is required";
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
