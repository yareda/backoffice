using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using ClearOffice.Infrastructure;

namespace ClearOffice.Hrm.Business.Data
{
    public partial class EmployeeSkill:IDataErrorInfo,IEntity
    {
        public string Error
        {
            get
            {
                var sb = new StringBuilder();
                sb.Append(this["SkillId"]);
                return sb.ToString();
            }
        }

        public string this[string columnName]
        {
            get
            {
                if (columnName == "SkillId")
                {
                    if (SkillId == null)
                        return "Skill type is required";
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
