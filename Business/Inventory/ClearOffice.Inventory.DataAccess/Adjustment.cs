using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;

namespace ClearOffice.Inventory.DataAccess
{
   public partial class Adjustment:IDataErrorInfo
    {
        public string Error
        {
            get
            {
                var sb = new StringBuilder();
                sb.Append(this["WarehouseId"]);
                return sb.ToString();
            }
        }

        public string this[string columnName]
        {
            get
            {
                if (columnName == "AdjustmentNo")
                {
                    if (string.IsNullOrEmpty(AdjustmentNo))
                        return "Adjustment # is required";
                }
               if (columnName == "WarehouseId")
                {
                    if (string.IsNullOrEmpty(WarehouseId.ToString()))
                        return "Warehouse required";
                }
                return string.Empty;
            }
        }
        public bool IsValid()
        {
            return Error == string.Empty;
        }

        public bool IsSavable()
        {
            return this.StatusId == InventoryHelper.STATUS_PENDING;
        }
    }
}
