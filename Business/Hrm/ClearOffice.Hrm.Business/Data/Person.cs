using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.ComponentModel;

namespace ClearOffice.Hrm.Business.Data
{
    public partial class Person:IDataErrorInfo
    {
        public string Error
        {
            get
            {
                var sb = new StringBuilder();
                sb.Append(this["FirstName"]);
                sb.Append(this["LastName"]);
                sb.Append(this["GrandFatherName"]);
                sb.Append(this["Dob"]);
                return sb.ToString();
            }
        }

        public string this[string columnName]
        {
            get
            {
                if (columnName == "FirstName")
                {
                    if (string.IsNullOrEmpty(FirstName))
                        return "First Name is required";
                }
                if (columnName == "LastName")
                {
                    if (string.IsNullOrEmpty(LastName))
                        return "Last Name is required";
                }
                if (columnName == "GrandFatherName")
                {
                    if (string.IsNullOrEmpty(GrandFatherName))
                        return "Grand Father Name is required";
                }
                if(columnName == "Dob")
                {
                    if (string.IsNullOrEmpty(Dob.ToString()))
                        return "Date of birth is required";
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
