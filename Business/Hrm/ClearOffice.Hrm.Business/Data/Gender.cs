using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ClearOffice.Hrm.Business.Data
{
    public class Gender
    {
        public string Name { get; set; }
        public int Value { get; set; }

        public Gender(string n,int v)
        {
            Name = n;
            Value = v;
        }
    }
}
