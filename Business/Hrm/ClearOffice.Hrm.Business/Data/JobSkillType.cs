using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;

namespace ClearOffice.Hrm.Business.Data
{
   public partial class JobSkillType:IDataErrorInfo
    {
        public string Error
        {
            get
            {
                var sb = new StringBuilder();
                sb.Append(this["SkillName"]);
                return sb.ToString();
            }
        }

        public string this[string columnName]
        {
            get
            {
                if (columnName == "SkillName")
                {
                    if (string.IsNullOrEmpty(SkillName))
                        return "Skill Name is required";
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
