using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.ComponentModel;
namespace ClearOffice.Hrm.Business.Data
{
    public partial class DeductionCondition:IDataErrorInfo
    {
         public string Error
        {
            get
            {
                var sb = new StringBuilder();
                sb.Append(this["ConditionName"]);
                return sb.ToString();
            }
        }

        public string this[string columnName]
        {
            get
            {
                if (columnName == "ConditionName")
                {
                    if (string.IsNullOrEmpty(ConditionName))
                        return "Condition Name required";
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
