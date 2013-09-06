using System.ComponentModel;
using System.Text;

namespace ClearOffice.Hrm.Business.Data
{
    public partial class Ethnicity:IDataErrorInfo
    {
        public string Error
        {
            get
            {
                var sb = new StringBuilder();
                sb.Append(this["EthnicityName"]);
                return sb.ToString();
            }
        }

        public string this[string columnName]
        {
            get
            {
                if (columnName == "EthnicityName")
                {
                    if (string.IsNullOrEmpty(EthnicityName))
                        return "Ethnicity Name required";
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
