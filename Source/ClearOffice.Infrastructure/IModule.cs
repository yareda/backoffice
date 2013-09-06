using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ClearOffice.Infrastructure
{
    public interface IModule
    {
        void Run();
        void AddServices();
        void AddViews();
        void ExtendRibbon();
        void ExtendStatusBar();
    }
}
