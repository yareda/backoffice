using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.ComponentModel;
using ClearOffice.Infrastructure;

namespace ClearOffice.Hrm.Business.Data
{
 public partial class TrainingRequest:IDataErrorInfo,IEntity
    {
        public string Error
        {
            get
            {
                var sb = new StringBuilder();
                sb.Append(this["TrainingTitle"]);
                sb.Append(this["RequestedDate"]);
                sb.Append(this["RequestedBy"]);
                 return sb.ToString();
            }
        }

        public string this[string columnName]
        {
            get
            {
                if (columnName == "TrainingTitle")
                {
                    if (string.IsNullOrEmpty(TrainingTitle))
                        return "Training title is required";
                }
                if (columnName == "RequestedDate")
                {
                    if (string.IsNullOrEmpty(RequestedDate.ToString()))
                        return "Requested date is required";
                }
                if (columnName == "RequestedBy")
                {
                    if (string.IsNullOrEmpty(RequestedBy))
                        return "Requested by is required";
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
