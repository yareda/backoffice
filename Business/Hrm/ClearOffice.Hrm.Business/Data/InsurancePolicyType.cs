using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;

namespace ClearOffice.Hrm.Business.Data
{
    public partial class InsurancePolicyType:IDataErrorInfo 
    {
        public string Error
        {
            get
            {
                var sb = new StringBuilder();
                sb.Append(this["PolicyTypeName"]);
                return sb.ToString();
            }
        }

        public string this[string columnName]
        {
            get
            {
                if (columnName == "PolicyTypeName")
                {
                    if (string.IsNullOrEmpty(PolicyTypeName))
                        return "Policy Type Name is required";
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
