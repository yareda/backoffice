using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;

namespace ClearOffice.Inventory.DataAccess
{
  public partial class SubCategory:IDataErrorInfo
    {
      public string Error
        {
            get
            {
                var sb = new StringBuilder();
                sb.Append(this["CategoryId"]);
                sb.Append(this["Name"]);
                return sb.ToString();
            }
        }
        public string this[string columnName]
        {
            get
            {
                if (columnName == "CategoryId")
                {
                    if (null == CategoryId || CategoryId <= 0)
                        return "Category type is required";
                }

                if (columnName == "Name")
                {
                    if (string.IsNullOrEmpty(Name))
                        return "Sub category name is required";
                }
              
                return string.Empty;
            }
        }
     }
    }

