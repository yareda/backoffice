using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using ClearOffice.Infrastructure;

namespace ClearOffice.Hrm.Business.Data
{
    public partial class EmployeeMedicalRecord:IDataErrorInfo,IEntity
    {
        public string Error
        {
            get
            {
                var sb = new StringBuilder();
                sb.Append(this["Cost"]);
                sb.Append(this["Sickness"]);
                sb.Append(this["ReceiptNo"]);
                sb.Append(this["Referal"]);
                return sb.ToString();
            }
        }

        public string this[string columnName]
        {
            get
            {
                if (columnName == "Cost")
                {
                    if (string.IsNullOrEmpty(Cost.ToString()))
                        return "Cost is required";
                }
                if (columnName == "Sickness")
                {
                    if (string.IsNullOrEmpty(Sickness))
                        return "Sikness is required";
                }
                if (columnName == "ReceiptNo")
                {
                    if (string.IsNullOrEmpty(ReceiptNo))
                        return "Receipt number is required";
                }
                if (columnName == "Referal")
                {
                    if (string.IsNullOrEmpty(Referal))
                        return "Receipt number is required";
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
