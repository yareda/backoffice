using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ClearOffice.Wms.Business
{
    public enum LookupItems
    {
        CustomerType = 1,
        ContractType = 2,
        EquipmentCatagory = 3,
        EquipmentStatus = 4,
        Company = 5,
        Make = 6,
        Model = 7,
        InsuranceCompany = 8,
        Schedule = 9,
        ExpirationType = 10,
        WorkorderStatus = 11,
        WorkorderPriority = 12,
        Services = 13,
        PmServiceType = 14,
        PaymentTerms = 15,
        VendorType = 16,
        Country = 17,
        Priorities = 18,
        PaymentMethod = 20,
        InvoiceStatus=21

    }

    public enum PaymentMethods
    {
        Cash=5,
        Cheque=6,
        BankTransfer=7,
        Other=8        
    }
    public enum InvoiceStatuses
    {
       OutStanding=13,
       PaidInFull=14
    }

    public class Common{}
}
