using System.Text;
using System.ComponentModel;

namespace ClearOffice.Hrm.Business.Data
{
    public partial class EmployeeType : IDataErrorInfo
    {
        public string Error
        {
            get
            {
                var sb = new StringBuilder();
                sb.Append(this["EmploymentType"]);
                return sb.ToString();
            }
        }

        public string this[string columnName]
        {
            get
            {
                if (columnName == "EmploymentType")
                {
                    if (string.IsNullOrEmpty(EmploymentType))
                        return "Employment Type is required";
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

