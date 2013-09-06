using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using ClearOffice.Infrastructure;

namespace ClearOffice.Hrm.Business.Data
{
    public partial class Training : IDataErrorInfo
    {
        public const int StatusPending = 0;
        public const int StatusApproved = 1;
        public const int StatusConducted = 2;
        public string Error
        {
            get
            {
                var sb = new StringBuilder();
                return sb.ToString();
            }
        }

        public string this[string columnName]
        {
            get
            {
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
