using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.ComponentModel;

namespace ClearOffice.Inventory.DataAccess
{
    public partial class ReturnDetail: IDataErrorInfo
    {
        public string Error
        {
            get
            {
                var sb = new StringBuilder();
                sb.Append(this["ItemId"]);
                sb.Append(this["Quantity"]);
                return sb.ToString();
            }
        }

        public string this[string columnName]
        {
            get
            {
                if (columnName == "ItemId")
                {
                    if (ItemId == null || ItemId <= 0)
                        return "You must select an item";
                }

                if (columnName == "Quantity")
                {
                    if (Quantity <= 0)
                        return "Quantity must be greater than zero";
                }

                return string.Empty;
            }
        }

        public bool IsValid()
        {
            return Error == string.Empty;
        }

        public decimal? LineTotal
        {
            get { return UnitPrice * Quantity; }
        }
    }
}
