using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using ClearOffice.Infrastructure;

namespace ClearOffice.Fleet
{
    using ClearOffice.Fleet.Views;

    public class FleetModuleManager : IModule
    {
        #region IModule Members

        public void Run()
        {
            throw new NotImplementedException();
        }

        public void AddServices()
        {
            throw new NotImplementedException();
        }

        public void AddViews()
        {
            throw new NotImplementedException();
        }

        public void ExtendRibbon()
        {
            throw new NotImplementedException();
        }

        public void ExtendStatusBar()
        {
            throw new NotImplementedException();
        }

        #endregion

        public VehicleList GetVehicleList()
        {
            return new VehicleList();
        }

        public NewVehicle NewVehicleRecord()
        {
            return new NewVehicle();
        }

        public VehicleDetail ShowVehicleDetail()
        {
            return new VehicleDetail();
        }

        public MaintenanceList ShowMaintenanceList()
        {
            return new MaintenanceList();
        }

        public CouponList ShowCouponList()
        {
            return new CouponList();
        }

        public TireListView ShowTireInventory()
        {
            return new TireListView();
        }
    }
}
