using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.ComponentModel;
using ClearOffice.Infrastructure;

namespace ClearOffice.Hrm.Business.Data
{
    public partial class Organization : IDataErrorInfo, IEntity
    {
        public string Error
        {
            get
            {
                var sb = new StringBuilder();
                sb.Append(this["NodeName"]);
                sb.Append(this["ParentId"]);
                sb.Append(this["NodeTypeId"]);
                return sb.ToString();
            }
        }

        public string this[string columnName]
        {
            get
            {
                if (columnName == "NodeName")
                {
                    if (string.IsNullOrEmpty(NodeName))
                        return "Unit Name is required";
                }

                if (columnName == "ParentId")
                {
                    if (null==ParentId || ParentId <= 0)
                        return "Parent required";
                }

                if (columnName == "NodeTypeId")
                {
                    if (null == NodeTypeId || NodeTypeId <= 0)
                        return "Organizaton Unit Type is required";
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
