using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using ClearOffice.Infrastructure;

namespace ClearOffice.Hrm.Business.Data
{
    public partial class EmployeeDependant:IDataErrorInfo,IEntity
    {
        public string Error
        {
            get
            {
                var sb = new StringBuilder();
                sb.Append(this["DependantTypeId"]);
                sb.Append(this["FirstName"]);
                sb.Append(this["FatherName"]);
                return sb.ToString();
            }
        }

        public string this[string columnName]
        {
            get
            {
                if (columnName == "DependantTypeId")
                {
                    if (DependantTypeId == null)
                        return "Dependant type is required";
                }
                if (columnName == "FirstName")
                {
                    if (FirstName == null)
                        return "FirstName is required";
                }
                if (columnName == "FatherName")
                {
                    if (FatherName == null)
                        return "FatherName is required";
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
