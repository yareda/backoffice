using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.ComponentModel;

namespace ClearOffice.Fleet.Business
{
    public partial class VehicleTire : IDataErrorInfo
    {
        public string Error
        {
            get
            {
                var sb = new StringBuilder();
                sb.Append(this["Position"]);
                sb.Append(this["MountedDate"]);
                sb.Append(this["MountedMilage"]);
                return sb.ToString();
            }
        }

        public string this[string columnName]
        {
            get
            {
                if (columnName == "Position")
                {
                    if (string.IsNullOrEmpty(Position))
                        return "Mounted position is required";
                }

                if (columnName == "MountedDate")
                {
                    if (MountedDate == null)
                        return "Mounted date is required";
                }

                if (columnName == "MountedMilage")
                {
                    if (MountedMilage == null || MountedMilage <= 0)
                        return "Mounted Milage is required";
                }

                if (columnName == "VehicleId")
                {
                    if (VehicleId <= 0)
                        return "You must select a vehicle";
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
