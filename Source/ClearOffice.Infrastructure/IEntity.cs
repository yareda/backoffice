using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ClearOffice.Infrastructure
{
    public interface IEntity
    {
        bool IsNew { get; set; }
        bool IsDirty { get; set; }
    }
}
