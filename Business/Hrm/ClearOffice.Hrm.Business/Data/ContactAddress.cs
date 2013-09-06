using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.ComponentModel;
using ClearOffice.Infrastructure;
namespace ClearOffice.Hrm.Business.Data
{
    public partial class ContactAddress: IDataErrorInfo,IEntity
    {
        public string Error
        {
            get
            {
                var sb = new StringBuilder();
                sb.Append(this["MobileNumber"]);
                return sb.ToString();
            }
        }

        public string this[string columnName]
        {
            get
            {
                if (columnName == "MobileNumber")
                {
                    if (string.IsNullOrEmpty(MobileNumber))
                        return "Mobile Number Name required";
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
