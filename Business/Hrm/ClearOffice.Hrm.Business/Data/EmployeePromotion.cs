using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using ClearOffice.Infrastructure;

namespace ClearOffice.Hrm.Business.Data
{
    public partial class EmployeePromotion:IDataErrorInfo,IEntity
    {
        public string Error
        {
            get
            {
                var sb = new StringBuilder();
                sb.Append(this["ActionDate"]);
                sb.Append(this["ActionReason"]);
                sb.Append(this["ActionBy"]);
                sb.Append(this["NewTitle"]);
                sb.Append(this["NewNode"]);
                sb.Append(this["Type"]);
                return sb.ToString();
            }
        }

        public string this[string columnName]
        {
            get
            {
                if (columnName == "ActionDate")
                {
                    if (string.IsNullOrEmpty(ActionDate.ToString()))
                        return "Action date is required";
                }
                if (columnName == "ActionReason")
                {
                    if (string.IsNullOrEmpty(ActionReason))
                        return "Action reason is required";
                }
                if (columnName == "ActionBy")
                {
                    if (string.IsNullOrEmpty(ActionBy))
                        return "Action by is required";
                }
                //if (columnName == "PreviousTitle")
                //{
                //    if (string.IsNullOrEmpty(PreviousTitle.ToString()))
                //        return "Previous title is required";
                //}
                //if (columnName == "PreviousNode")
                //{
                //    if (string.IsNullOrEmpty(PreviousNode.ToString()))
                //        return "Previous node is required";
                //}
                if (columnName == "NewTitle")
                {
                    if (string.IsNullOrEmpty(NewTitle.ToString()))
                        return "New title is required";
                }
                if (columnName == "NewNode")
                {
                    if (string.IsNullOrEmpty(NewNode.ToString()))
                        return "New node is required";
                }
                if (columnName == "Type")
                {
                    if (string.IsNullOrEmpty(Type.ToString()))
                        return "The Type either promotion or demotion is required";
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
