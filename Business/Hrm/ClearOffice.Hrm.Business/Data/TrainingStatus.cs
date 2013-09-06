using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ClearOffice.Hrm.Business.Data
{
    public class TrainingStatus
    {
        public int  Value { get; set; }
        public string Name { get; set; }

        public TrainingStatus(int v,string n)
        {
            Name = n;
            Value = v;
        }
    }
}
