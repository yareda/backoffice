using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.ComponentModel;
namespace ClearOffice.Hrm.Business.Data
{
    public partial class BankBranch : IDataErrorInfo
    {

        public string Error
        {
            get
            {
                var sb = new StringBuilder();
                sb.Append(this["BranchName"]);
                return sb.ToString();
            }
        }

        public string this[string columnName]
        {
            get
            {
                if (columnName == "BranchName")
                {
                    if (string.IsNullOrEmpty(BranchName))
                        return "Branch Name is required";
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
