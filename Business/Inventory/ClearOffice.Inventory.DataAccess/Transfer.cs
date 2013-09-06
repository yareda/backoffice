using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.ComponentModel;

namespace ClearOffice.Inventory.DataAccess
{
    public partial class Transfer:IDataErrorInfo
    {
        public string Error
        {
            get
            {
                var sb = new StringBuilder();
                sb.Append(this["TransferNo"]);
                sb.Append(this["WarehouseFrom"]);
                sb.Append(this["WarehouseTo"]);
                return sb.ToString();
            }
        }

        public string this[string columnName]
        {
            get
            {
                if (columnName == "TransferNo")
                {
                    if (string.IsNullOrEmpty(TransferNo))
                        return "Return# required";
                }
                if (columnName == "WarehouseFrom")
                {
                    if (null == WarehouseFrom || WarehouseFrom <= 0)
                        return "Source Warehouse is required";
                }

                if (columnName == "WarehouseTo")
                {
                    if (null == WarehouseTo || WarehouseTo <= 0)
                        return "Destination Warehouse is required";
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
