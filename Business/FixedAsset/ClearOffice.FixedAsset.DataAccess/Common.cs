using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ClearOffice.FixedAsset.DataAccess
{
    public enum LookupItems
    {
        DepreciationMethods = 1,
        AssetGroup = 2,
        Location = 3,
        CostCenter = 4,
        AssetCatagory = 5,
        AdjustementType = 6,
        CustodyStatus = 7,
        Departement = 8,
        DisposalType = 9,
        FiscalPeriodStatus = 10,
        PhysicalCondition = 11,
        CustodyAssignmentStatus =12,
        AssetStatus = 13,
        AdjustementStatus = 14,
        Vendor = 15
    }

    public enum DepreciationMethods
    {
        StraightLine = 1,
        DecliningBalance = 2
    }

    public enum AssetStatuses
    {
        Active = 16,
        Sold = 17,
        Disposed = 18
    }

    public enum AdjustemntStatus
    {
        Pending = 22,
        Posted = 23
    }

    //public class Common
    //{
    //}

   public enum Departement
   {
       Finance =4,
       HRM =5,
       GeneralService=6,
       President =7

   }
    public enum CustodyStatus
    {
        Active=8,
        Inactive=9
    }
    public enum CustodyAssignmentStatus
    {
        Assigned =10,
        Returned =11,
        Transfered =12
    }

    public enum DisposalTypes
    {
        Distroyed = 24,
        Sold = 25
    }
    public enum Vendors
    {
        Vendor1 = 26,
        Vendor2 = 27
    }
}
