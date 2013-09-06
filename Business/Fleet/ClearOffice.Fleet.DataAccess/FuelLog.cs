using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.ComponentModel;

namespace ClearOffice.Fleet.Business
{
    public partial class FuelLog : IDataErrorInfo
    {
        public string Error
        {
            get
            {
                var sb = new StringBuilder();
                sb.Append(this["FilledDate"]);
                sb.Append(this["LastOdometer"]);
                sb.Append(this["CurrentOdometer"]);
                sb.Append(this["DistanceCovered"]);
                sb.Append(this["FuelAmount"]);
                return sb.ToString();
            }
        }

        public string this[string columnName]
        {
            get
            {
                if (columnName == "FilledDate")
                {
                    if (FilledDate == null)
                        return "Filled date is required";
                }
                if (columnName == "LastOdometer")
                {
                    if (LastOdometer == null || LastOdometer <=0)
                        return "Last odometer reading should be greater than zero";
                }
                if (columnName == "CurrentOdometer")
                {
                    if (CurrentOdometer == null || CurrentOdometer <= 0)
                        return "Current odometer reading should be greater than zero";
                }
                if (columnName == "DistanceCovered")
                {
                    if (DistanceCovered <= 0)
                        return "Distance covered should be greater than zero";
                }
                if (columnName == "FuelAmount")
                {
                    if (FuelAmount <= 0)
                        return "Fuel amount should be greater than zero";
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
