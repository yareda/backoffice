using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ClearOffice.Hrm.Business.Data
{
    public partial class EmployeeWarning
    {
        public string Error
        {
            get
            {
                var sb = new StringBuilder();
                sb.Append(this["WarningTypeId"]);
                sb.Append(this["WarningDate"]);
                sb.Append(this["WarningReason"]);
                sb.Append(this["WarningGivenBy"]);
                return sb.ToString();
            }
        }

        public string this[string columnName]
        {
            get
            {
                if (columnName == "WarningTypeId")
                {
                    if (WarningTypeId == null)
                        return "Warning type is required";
                }
                if (columnName == "WarningDate")
                {
                    if (WarningDate == null)
                        return "Warning date is required";
                }
                if (columnName == "WarningReason")
                {
                    if (WarningReason == null)
                        return "Warning reason is required";
                }
                if (columnName == "WarningGivenBy")
                {
                    if (WarningGivenBy == null)
                        return "Warning given by is required";
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
