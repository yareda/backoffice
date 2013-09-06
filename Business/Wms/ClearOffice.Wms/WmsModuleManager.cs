using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using ClearOffice.Infrastructure;
using ClearOffice.Wms.Views;
using DevExpress.XtraEditors;

namespace ClearOffice.Wms
{
    public class WmsModuleManager:IModule
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

        #region Equipment Management

        public EquipmentsView ShowEquipmentList()
        {
            return new EquipmentsView();
        }

        public NewEquipment ShowNewEquipment()
        {
            return new NewEquipment();
        }

        public EquipmentDetail ShowEquipment(int equipmentId)
        {
            var form = new EquipmentDetail();
            form.ShowObject(equipmentId);
            return form;
        }
        #endregion

        #region Customer Management

        public CustomersView ShowCustomers()
        {
            return new CustomersView();
        }

        #endregion

        #region Contract Management
        public NewContractView ShowNewContractView()
        {
            return new NewContractView();
        }
        public ContractListView ShowContractListView()
        {
            return new ContractListView();
        }
        #endregion

        #region Invoice Management
        public FrmInvoiceListView ShowInvoiceList()
        {
            return new FrmInvoiceListView();
        }
        public InvoiceView ShowNewInvoice()
        {
            return new InvoiceView();
        }
        //public ContractListView ShowContractListView()
        //{
        //    return new ContractListView();
        //}
        #endregion Invoice management

        #region WorkOrder Management
        public WorkOrderListView ShowWorkOrderList()
        {
            return new WorkOrderListView();
        }

        #endregion

        #region Vendor Management

        public VendorListView ShowVendorList()
        {
            return new VendorListView();
        }

        public VendorDetail ShowVendor(int vendorId)
        {
            var form = new VendorDetail();
            form.ShowObject(vendorId);
            return form;
        }
        #endregion

        #region Customer Management

        public CustomerListView ShowCustomersList()
        {
            return new CustomerListView();
        }

        public NewCustomersView ShowNewCustomer()
        {
            return new NewCustomersView();
        }


        #endregion

        #region Lookup Item Management
        public LookupView showLookupList()
        {

            return new LookupView();
        }
        #endregion

        #region Pmservice Managemenet
        public PMServiceListView ShowPmservices()
        {
            return new PMServiceListView();
        }

        #endregion
    }
}
