using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.ComponentModel;

namespace ClearOffice.Fleet.Business
{
    public partial class Maintanance: IDataErrorInfo
    {
        public string Error
        {
            get
            {
                var sb = new StringBuilder();
                sb.Append(this["VehicleId"]);
                sb.Append(this["ServiceRequestNo"]);
                return sb.ToString();
            }
        }

        public string this[string columnName]
        {
            get
            {
                if (columnName == "ServiceRequestNo")
                {
                    if (string.IsNullOrEmpty(ServiceRequestNo))
                        return "Service Request No required";
                }

                if (columnName == "VehicleId")
                {
                    if (VehicleId <=0)
                        return "VehicleId is required";
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
