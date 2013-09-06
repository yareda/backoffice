using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using ClearOffice.Infrastructure;

namespace ClearOffice.Hrm.Business.Data
{
    public partial class EmployeeAccident:IDataErrorInfo,IEntity
    {
        public string Error
        {
            get
            {
                var sb = new StringBuilder();
                sb.Append(this["AccidentDate"]);
                return sb.ToString();
            }
        }

        public string this[string columnName]
        {
            get
            {
                if (columnName == "AccidentDate")
                {
                    if (string.IsNullOrEmpty(AccidentDate.ToString()))
                        return "Date is required";
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
