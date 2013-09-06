using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using ClearOffice.Infrastructure;
using System.ComponentModel;

namespace ClearOffice.Hrm.Business.Data
{
    public partial  class EmployeeTransfer:IDataErrorInfo,IEntity
    {
        public string Error
        {
            get
            {
                var sb = new StringBuilder();
                sb.Append(this["NewTitle"]);
                sb.Append(this["NewLocation"]);
                sb.Append(this["EffectiveDate"]);
                sb.Append(this["ApprovedBy"]);
                sb.Append(this["TransferDate"]);
                sb.Append(this["TransferReason"]);
                return sb.ToString();
            }
        }

        public string this[string columnName]
        {
            get
            {
                if (columnName == "NewTitle")
                {
                    if (string.IsNullOrEmpty(NewTitle.ToString()))
                        return "New title is required";
                }
                if (columnName == "NewLocation")
                {
                    if (string.IsNullOrEmpty(NewLocation.ToString()))
                        return "New location is required";
                }

                if (columnName == "EffectiveDate")
                {
                    if (string.IsNullOrEmpty(EffectiveDate.ToString()))
                        return "Effective date is required";
                }

                if (columnName == "ApprovedBy")
                {
                    if (string.IsNullOrEmpty(ApprovedBy))
                        return "Approved by is required";
                }

                if (columnName == "TransferDate")
                {
                    if (string.IsNullOrEmpty(TransferDate.ToString()))
                        return "Transfer date is required";
                }
                if (columnName == "TransferReason")
                {
                    if (string.IsNullOrEmpty(TransferReason))
                        return "Transfer reason is required";
                }
                return string.Empty;
            }
        }

        public bool IsNew { get; set; }
        public bool IsDirty { get; set; }
       
        public bool IsValid()
        {
            return Error == string.Empty;
        }

      
    }
}
