using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ClearOffice.Hrm.Business.Data
{
    public class Sex
    {
        public int RecordId { get; set; }
        public string Name { get; set; }

        /// <summary>
        /// Returns list of possible sex values for binding using BindingSource controls.
        /// </summary>
        /// <returns>Enumerable lis to Sex (Male and Female values)</returns>
        public static List<Sex> GetSexLookup()
        {
            return new List<Sex> {new Sex {RecordId = 1, Name = "Male"}, new Sex {RecordId = 2, Name = "Female"}};
        }
    }
}
