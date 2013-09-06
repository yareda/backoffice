using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using ClearOffice.Infrastructure;

namespace ClearOffice.Hrm.Business.Data
{
 public partial class EmployeeTermination:IDataErrorInfo,IEntity
    {
        public string Error
        {
            get
            {
                var sb = new StringBuilder();

                sb.Append(this["TerminationReason"]);
                sb.Append(this["TerminationDate"]);
                sb.Append(this["EffectiveDate"]);
                sb.Append(this["ActionTakenBy"]);
                return sb.ToString();
            }
        }

        public string this[string columnName]
        {
            get
            {
                if (columnName == "TerminationReason")
                {
                    if (string.IsNullOrEmpty(TerminationReason))
                        return "Termination reason is required";
                }
                if (columnName == "TerminationDate")
                {
                    if (string.IsNullOrEmpty(TerminationDate.ToString()))
                        return "Termination date is required";
                }
                if (columnName == "EffectiveDate")
                {
                    if (string.IsNullOrEmpty(EffectiveDate.ToString()))
                        return "Effective date is required";
                }
                if (columnName == "ActionTakenBy")
                {
                    if (string.IsNullOrEmpty(ActionTakenBy))
                        return "Action taken by is required";
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
