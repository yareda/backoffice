using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;

namespace ClearOffice.Inventory.DataAccess
{
  public partial class AdjustmentDetail:IDataErrorInfo
    {

        public string Error
        {
            get
            {
                var sb = new StringBuilder();
                sb.Append(this["ItemId"]);
                sb.Append(this["AdjustedQuantity"]);
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
                if (columnName == "AdjustedQuantity")
                {
                    if (string.IsNullOrEmpty(AdjustedQuantity.ToString()))
                        return "Adjusted Quantity is required";
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
