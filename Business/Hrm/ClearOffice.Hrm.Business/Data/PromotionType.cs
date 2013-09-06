using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ClearOffice.Hrm.Business.Data
{
    public class PromotionType
    {
        public int Value { get; set; }
        public string Name { get; set; }

        public PromotionType(string n,int v)
        {
            Name = n;
            Value = v;
        }
    }
}
