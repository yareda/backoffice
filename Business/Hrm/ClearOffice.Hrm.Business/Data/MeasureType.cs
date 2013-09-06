using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using DevExpress.XtraEditors;

namespace ClearOffice.Hrm.Business.Data
{
    public partial class MeasureType : IDataErrorInfo
    {
        public string Error
        {
            get
            {
                var sb = new StringBuilder();
                sb.Append(this["MeasureTypeName"]);
                return sb.ToString();
            }
        }

        public string this[string columnName]
        {
            get
            {
                if (columnName == "MeasureTypeName")
                {
                    if (string.IsNullOrEmpty(MeasureTypeName))
                        return "Measure Type is required";
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