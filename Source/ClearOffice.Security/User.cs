using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.ComponentModel;
using ClearOffice.Infrastructure;

namespace ClearOffice.Security.Data
{
    public partial class User:IDataErrorInfo
    {
        public string Error
        {
            get
            {
                var sb = new StringBuilder();
                sb.Append(this["UserName"]);
                sb.Append(this["FullName"]);
                return sb.ToString();
            }
        }

        public string this[string columnName]
        {
            get
            {
                if (columnName == "UserName")
                {
                    if (string.IsNullOrEmpty(UserName))
                        return "User name is required";
                }

                if (columnName == "FullName")
                {
                    if (string.IsNullOrEmpty(FullName))
                        return "Full name is required";
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
