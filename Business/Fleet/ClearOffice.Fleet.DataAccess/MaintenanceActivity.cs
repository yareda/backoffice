using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.ComponentModel;

namespace ClearOffice.Fleet.Business
{
    public partial class MaintenanceActivity : IDataErrorInfo
    {
        public string Error
        {
            get
            {
                var sb = new StringBuilder();
                sb.Append(this["ActivityTypeId"]);                
                sb.Append(this["Performer"]);
                sb.Append(this["UnitCost"]);
                sb.Append(this["LaborUnits"]);
                return sb.ToString();
            }
        }

        public string this[string columnName]
        {
            get
            {
                if (columnName == "ActivityTypeId")
                {
                    if (ActivityTypeId <= 0)
                        return "ActivityTypeId is required";
                }

                if (columnName == "Performer")
                {
                    if (string.IsNullOrEmpty(Performer))
                        return "Performer is required";
                }
                if (columnName == "UnitCost")
                {
                    if (UnitCost <= 0 || UnitCost == null)
                        return "Unit cost is required";
                }
                if (columnName == "LaborUnits")
                {
                    if (LaborUnits <= 0 || LaborUnits == null)
                        return "LaborUnit is required";
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
