using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.ComponentModel;

namespace ClearOffice.Hrm.Business.Data
{

    public partial class Employee: IDataErrorInfo
    {
        public const int StatusPending = 0;
        public const int StatusActive = 1;
        public const int StatusSuspended = 2;
        public const int StatusTerminated = 3;
        public const int StatusDeceased = 4;
        public const int StatusArchived = 5;

        public string Error
        {
            get
            {
                var sb = new StringBuilder();
                sb.Append(this["EmployeeNo"]);
                sb.Append(this["StatusId"]);
                return sb.ToString();
            }
        }

        public string this[string columnName]
        {
            get
            {
                if (columnName == "EmployeeNo")
                {
                    if (string.IsNullOrEmpty(EmployeeNo))
                        return "Employee# is required";
                }

                if(columnName=="StatusId")
                {
                    if(StatusId==null||StatusId==0)
                    {
                        return "Employment Status is required";
                    }
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
