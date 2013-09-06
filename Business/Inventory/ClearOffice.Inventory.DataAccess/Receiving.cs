using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.ComponentModel;

namespace ClearOffice.Inventory.DataAccess
{
    public partial class Receiving : IDataErrorInfo
    {
        public string Error
        {
            get
            {
                var sb = new StringBuilder();
                sb.Append(this["GRN"]);
                sb.Append(this["WarehouseId"]);
                return sb.ToString();
            }
        }

        public string this[string columnName]
        {
            get
            {
                if (columnName == "GRN")
                {
                    if (string.IsNullOrEmpty(GRN))
                        return "GRN required";
                }
                if (columnName == "WarehouseId")
                {
                    if (null==WarehouseId || WarehouseId <= 0)
                        return "Warehouse is required";
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
