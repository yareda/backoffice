using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using ClearOffice.Infrastructure;

namespace ClearOffice.Hrm.Business.Data
{
    public partial class EmployeeEducationalHistory : IDataErrorInfo, IEntity 
    {
        public string Error
        {
            get
            {
                var sb = new StringBuilder();
                sb.Append(this["EducationTypeId"]);
                sb.Append(this["EducationLevelId"]);
                sb.Append(this["Institution"]);
                return sb.ToString();
            }
        }

        public string this[string columnName]
        {
            get
            {
                if (columnName == "EducationTypeId")
                {
                    if (EducationTypeId == null)
                        return "Education type is required";
                }
                if (columnName == "EducationLevelId")
                {
                    if (EducationLevelId == null)
                        return "Education level is required";
                }
                if (columnName == "Institution")
                {
                    if (Institution == null)
                        return "Educational institute is required";
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
