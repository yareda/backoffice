using System.Text;
using System.ComponentModel;

namespace ClearOffice.Hrm.Business.Data
{
    public partial class Job:IDataErrorInfo
    {            
        public string Error
        {
            get
            {
                var sb = new StringBuilder();
                sb.Append(this["JobTitle"]);
                sb.Append(this["NodeId"]);
                sb.Append(this["InitialLeaveAmount"]);
                return sb.ToString();
            }
        }

        public string this[string columnName]
        {
            get
            {
                if (columnName == "JobTitle")
                {
                    if (string.IsNullOrEmpty(JobTitle))
                        return "Job Title is required";
                }
                if(columnName == "NodeId")
                {
                    if (NodeId == null)
                        return "Departement is required.";
                }
                if (columnName == "InitialLeaveAmount")
                {
                    if (InitialLeaveAmount == null)
                        return "Initial leave amount is required.";
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
