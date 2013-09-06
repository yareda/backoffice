using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ClearOffice.Fleet
{
    public class FleetHelper
    {
        public const int TIRE_STATUS_MOUNTED = 1;
        public const int TIRE_STATUS_UNMOUNTED = 2;
        public const int TIRE_STATUS_DISPOSED = 3;
        public const int TIRE_STATUS_UNKNOWN = 4;

        public static bool DeleteVehicle(int vehicleId)
        {
            return false;
        }

        internal static bool DeleteMaintenance(int p)
        {
            return false;

        }
    }
}
