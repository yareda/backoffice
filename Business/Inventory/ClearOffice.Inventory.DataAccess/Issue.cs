using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.ComponentModel;

namespace ClearOffice.Inventory.DataAccess
{
    public partial class Issue : IDataErrorInfo
    {
        public string Error
        {
            get
            {
                var sb = new StringBuilder();
                sb.Append(this["IssueNo"]);
                sb.Append(this["WarehouseId"]);
                return sb.ToString();
            }
        }

        public string this[string columnName]
        {
            get
            {
                if (columnName == "IssueNo")
                {
                    if (string.IsNullOrEmpty(IssueNo))
                        return "IssueNo is required";
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
