using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.ComponentModel;

namespace ClearOffice.Inventory.DataAccess
{
    public partial class ItemReturn: IDataErrorInfo
    {
        public string Error
        {
            get
            {
                var sb = new StringBuilder();
                sb.Append(this["ReturnNo"]);
                sb.Append(this["WarehouseId"]);
                return sb.ToString();
            }
        }

        public string this[string columnName]
        {
            get
            {
                if (columnName == "ReturnNo")
                {
                    if (string.IsNullOrEmpty(ReturnNo))
                        return "Return# required";
                }
                if (columnName == "WarehouseId")
                {
                    if (null == WarehouseId || WarehouseId <= 0)
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
