using System.Text;
using System.ComponentModel;

namespace ClearOffice.Inventory.DataAccess
{
    public partial class InventoryItem : IDataErrorInfo
    {
        public string Error
        {
            get
            {
                var sb = new StringBuilder();
                sb.Append(this["ItemNo"]);
                sb.Append(this["Description"]);
                return sb.ToString();
            }
        }

        public string this[string columnName]
        {
            get
            {
                if (columnName == "ItemNo")
                {
                    if (string.IsNullOrEmpty(ItemNo))
                        return "Item #/Name is required";
                }
                if (columnName == "Description")
                {
                    if (string.IsNullOrEmpty(Description))
                        return "Item Description is required";
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
