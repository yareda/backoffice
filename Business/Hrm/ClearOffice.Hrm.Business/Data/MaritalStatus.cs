using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.ComponentModel;

namespace ClearOffice.Hrm.Business.Data
{
    public partial class MaritalStatus:IDataErrorInfo
    {
            public string Error
            {
                get
                {
                    var sb = new StringBuilder();
                    sb.Append(this["MaritalStatusType"]);
                    return sb.ToString();
                }
            }

            public string this[string columnName]
            {
                get
                {
                    if (columnName == "MaritalStatusType")
                    {
                        if (string.IsNullOrEmpty(MaritalStatusType))
                            return "Marital Status Type is required";
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

