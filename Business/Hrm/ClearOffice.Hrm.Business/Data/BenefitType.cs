using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.ComponentModel;
namespace ClearOffice.Hrm.Business.Data
{
    public partial class BenefitType : IDataErrorInfo
    {
        public string Error
        {
            get
            {
                var sb = new StringBuilder();
                sb.Append(this["BenefitName"]);
                return sb.ToString();
            }
        }

        public string this[string columnName]
        {
            get
            {
                if (columnName == "BenefitName")
                {
                    if (string.IsNullOrEmpty(BenefitName))
                        return "Benefit name is required";
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
