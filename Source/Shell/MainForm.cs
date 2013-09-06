using System;
using System.Windows.Forms;
using ClearOffice.FixedAsset;
using ClearOffice.FixedAsset.Views;
using ClearOffice.Fleet;
using ClearOffice.Fleet.Views;
using ClearOffice.Hrm;
using ClearOffice.Hrm.Views;
using ClearOffice.Inventory;
using ClearOffice.Security;
using ClearOffice.Security.Views;
using ClearOffice.Wms;
using ClearOffice.Wms.Views;
using DevExpress.XtraBars;
using DevExpress.XtraEditors;
using System.Threading;
using LookUpList = ClearOffice.Fleet.Views.FleetLookUpListView;
using ClearOffice.Inventory.Views;

namespace ClearOffice.Infrastructure.Shell
{
    public partial class MainForm : DevExpress.XtraBars.Ribbon.RibbonForm
    {
        private WmsModuleManager _wmsModule;
        private FleetModuleManager _fleetModule;
        private FixedAssetModuleManager _fixedAssetModule;
        private HrmModuleManager _hrmModule;
        private InventoryModuleManager _inventoryModule;

        private WorkshopPermissionHelper wph;
        private FleetPermissionHelper _flph;
        private FixedAssetPermissionHelper faph;
        private HRMPermissionHelper hph;
        private AdministrationPermissionHelper aph;
        private PermissionManager permission;
        private InventoryPermissionHelper iph;

        public MainForm()
        {
            InitializeComponent();
            permission = PermissionManager.GetPermissionManager();
            wph = new WorkshopPermissionHelper();
            flph = new FleetPermissionHelper();
            faph = new FixedAssetPermissionHelper();
            hph = new HRMPermissionHelper();
            aph = new AdministrationPermissionHelper();
            iph =new InventoryPermissionHelper();

          // Load application modules
            LoadModules();
            // Load startup screen/dashboard for user
            //LoadStartupScreen();

            // If there is no user preference to set the startup ribbon, set it to Home ribbon page
            this.ribbon.SelectedPage = ribbon.Pages[Constants.HOME_RIBBON_NAME];

            // Display security information on the status bar.

            UserIdentity ui = Thread.CurrentPrincipal.Identity as UserIdentity;

            userInfoBarStaticItem.Caption = string.Format("Logged in user: {0} ({1})", ui.FullName, ui.Name);
            loginTimeBarStaticItem.Caption = string.Format("Logged in at: {0}", DateTime.Now.ToString());
        }

        /// <summary>
        /// Check user security information and load/unload requested modules
        /// </summary>
        private void LoadModules()
        {
            var loadWorkshop = permission.IsAuthorized(PermissionManager.WORKSHOP_APPLICATION, wph.ItemName(WorkshopPermissionHelper.Task.LoadModule));
            var loadFleet = permission.IsAuthorized(PermissionManager.FLEET_APPLICATION, flph.ItemName(FleetPermissionHelper.Task.LoadModule));
            var loadfixedasset = permission.IsAuthorized(PermissionManager.FIXED_ASSET_APPLICATION, faph.ItemName(FixedAssetPermissionHelper.Task.LoadModule));
            var loadhrm = permission.IsAuthorized(PermissionManager.HRM_APPLICATION, hph.ItemName(HRMPermissionHelper.Task.LoadModule));
            var loadadmin = permission.IsAuthorized(PermissionManager.ADMINISTRATION_APPLICATION, aph.ItemName(AdministrationPermissionHelper.Task.LoadModule));
            var loadinventory = permission.IsAuthorized(PermissionManager.INVENTORY_APPLICATION,iph.ItemName(InventoryPermissionHelper.Task.LoadModule));

            if (loadWorkshop)
            {
                _wmsModule = new WmsModuleManager();
                AuthorizeWorkshop();
            }
            if (loadFleet)
            {
                _fleetModule = new FleetModuleManager();
                AuthorizeFleet();
            }
            if (loadfixedasset)
            {
                _fixedAssetModule = new FixedAssetModuleManager();
                AuthorizeFixedasset();
            }
            if (loadhrm)
            {
                _hrmModule = new HrmModuleManager();
                AuthorizeHrm();
            }
            if (loadadmin)
            {
                AuthorizeAdministration();
            }
            if (loadinventory)
            {
                _inventoryModule = new InventoryModuleManager();
                AuthorizeInventory();
            }


            //Hide/Show appropriate ribbon tab
            workshopRibbonPage.Visible = loadWorkshop;
            faRibbonPage.Visible = loadfixedasset;
            hrmRibbonPage.Visible = loadhrm;
            fleetRibbonPage.Visible = loadFleet;
            ribbonPage1.Visible = loadadmin;
            inventoryRibbonPage.Visible = loadinventory;
        }

        private void AuthorizeInventory()
        {
            itemsBarButtonItem.Enabled = permission.IsAuthorized(PermissionManager.INVENTORY_APPLICATION,
                                                                 iph.ItemName(
                                                                     InventoryPermissionHelper.Role.StockManager));
            stockStatusBarButtonItem.Enabled = permission.IsAuthorized(PermissionManager.INVENTORY_APPLICATION,
                                                                iph.ItemName(
                                                                    InventoryPermissionHelper.Role.StockManager));
            receivingBarButtonItem.Enabled = permission.IsAuthorized(PermissionManager.INVENTORY_APPLICATION,
                                                                iph.ItemName(
                                                                    InventoryPermissionHelper.Role.StockManager));
            transferBarButtonItem.Enabled = permission.IsAuthorized(PermissionManager.INVENTORY_APPLICATION,
                                                                iph.ItemName(
                                                                    InventoryPermissionHelper.Role.StockManager));
            adjustmentBarButtonItem.Enabled = permission.IsAuthorized(PermissionManager.INVENTORY_APPLICATION,
                                                                iph.ItemName(
                                                                    InventoryPermissionHelper.Role.StockManager));
            inventorySettingBarButtonItem.Enabled = permission.IsAuthorized(PermissionManager.INVENTORY_APPLICATION,
                                                                iph.ItemName(
                                                                    InventoryPermissionHelper.Role.StockManager));
            warehousebarButtonItem.Enabled = permission.IsAuthorized(PermissionManager.INVENTORY_APPLICATION,
                                                                iph.ItemName(
                                                                    InventoryPermissionHelper.Role.StockManager));
            supplierbarButtonItem.Enabled = permission.IsAuthorized(PermissionManager.INVENTORY_APPLICATION,
                                                              iph.ItemName(
                                                                  InventoryPermissionHelper.Role.StockManager));
            measurementbarButtonItem.Enabled = permission.IsAuthorized(PermissionManager.INVENTORY_APPLICATION,
                                                       iph.ItemName(
                                                           InventoryPermissionHelper.Role.StockManager));

        }

        private void AuthorizeAdministration()
        {

            usersBarButtonItem.Enabled = permission.IsAuthorized(PermissionManager.ADMINISTRATION_APPLICATION,
                                                                 aph.ItemName(
                                                                     AdministrationPermissionHelper.Role.SystemAdmin));
        }

        private void AuthorizeFixedasset()
        {
            //Operation Authorization

            //Role Authorization
            assetsBarButtonItem.Enabled = permission.IsAuthorized(PermissionManager.FIXED_ASSET_APPLICATION,
                                                                  faph.ItemName(
                                                                      FixedAssetPermissionHelper.Role.AssetManger));
            custodiansBarButtonItem.Enabled = permission.IsAuthorized(PermissionManager.FIXED_ASSET_APPLICATION,
                                                                      faph.ItemName(
                                                                          FixedAssetPermissionHelper.Role.
                                                                              CustodianManager));
            faSettingsBarButtonItem.Enabled = permission.IsAuthorized(PermissionManager.FIXED_ASSET_APPLICATION,
                                                                      faph.ItemName(
                                                                          FixedAssetPermissionHelper.Role.AssetManger));
            barButtonItem1.Enabled = permission.IsAuthorized(PermissionManager.FIXED_ASSET_APPLICATION,
                                                             faph.ItemName(FixedAssetPermissionHelper.Role.AssetManger));
            newAssetBarButtonItem.Enabled = permission.IsAuthorized(PermissionManager.FIXED_ASSET_APPLICATION,
                                                                    faph.ItemName(
                                                                        FixedAssetPermissionHelper.Role.AssetManger));
            barButtonItem6.Enabled = permission.IsAuthorized(PermissionManager.FIXED_ASSET_APPLICATION,
                                                             faph.ItemName(FixedAssetPermissionHelper.Role.AssetManger));



        }

        private void AuthorizeHrm()
        {

            //Operation Authorization

            //Role Authorization

            barButtonItem17.Enabled = permission.IsAuthorized(PermissionManager.HRM_APPLICATION,
                                                             hph.ItemName(
                                                                 HRMPermissionHelper.Role.HRMManager));

            intialLeaveBarButtonItem.Enabled = permission.IsAuthorized(PermissionManager.HRM_APPLICATION,
                                                                       hph.ItemName(
                                                                           HRMPermissionHelper.Role.
                                                                               HRMManager));
            barButtonItem26.Enabled = permission.IsAuthorized(PermissionManager.HRM_APPLICATION,
                                                              hph.ItemName(
                                                                  HRMPermissionHelper.Role.HRMManager));
            barButtonItem23.Enabled = permission.IsAuthorized(PermissionManager.HRM_APPLICATION,
                                                              hph.ItemName(
                                                                  HRMPermissionHelper.Role.HRMManager));
            organizationBarButtonItem.Enabled = permission.IsAuthorized(PermissionManager.HRM_APPLICATION,
                                                              hph.ItemName(
                                                                  HRMPermissionHelper.Role.HRMManager));
            barButtonItem24.Enabled = permission.IsAuthorized(PermissionManager.HRM_APPLICATION,
                                                              hph.ItemName(
                                                                  HRMPermissionHelper.Role.HRMManager));

            calculateLeaveBarButtonItem.Enabled = permission.IsAuthorized(PermissionManager.HRM_APPLICATION,
                                                              hph.ItemName(
                                                                  HRMPermissionHelper.Role.HRMManager));

            barButtonItem25.Enabled = permission.IsAuthorized(PermissionManager.HRM_APPLICATION,
                                                              hph.ItemName(
                                                                  HRMPermissionHelper.Role.HRMManager));


        }

        private void AuthorizeFleet()
        {
            //Operation Authorization

            //Role Authorization

            vehiclesBarButtonItem.Enabled = permission.IsAuthorized(PermissionManager.FLEET_APPLICATION,
                                                                  flph.ItemName(
                                                                      FleetPermissionHelper.Role.VehicleManager));
            maintenanceHistoryBarButtonItem.Enabled = permission.IsAuthorized(PermissionManager.FLEET_APPLICATION,
                                                                    flph.ItemName(
                                                                        FleetPermissionHelper.Role.VehicleManager));
            couponBarButtonItem.Enabled = permission.IsAuthorized(PermissionManager.FLEET_APPLICATION,
                                                                    flph.ItemName(
                                                                        FleetPermissionHelper.Role.VehicleManager));
            fleetSettingBarButtonItem.Enabled = permission.IsAuthorized(PermissionManager.FLEET_APPLICATION,
                                                                    flph.ItemName(
                                                                       FleetPermissionHelper.Role.VehicleManager));
            tireBarButtonItem.Enabled = permission.IsAuthorized(PermissionManager.FLEET_APPLICATION,
                                                                    flph.ItemName(
                                                                        FleetPermissionHelper.Role.VehicleManager));
        }

        private void AuthorizeWorkshop()
        {

            //Operation Authorization

            //Role Authorization

            newCustomerBarButtonItem.Enabled = permission.IsAuthorized(PermissionManager.WORKSHOP_APPLICATION,
                                                                    wph.ItemName(
                                                                        WorkshopPermissionHelper.Role.WorkshopManager));
            contractsBarButtonItem.Enabled = permission.IsAuthorized(PermissionManager.WORKSHOP_APPLICATION,
                                                                    wph.ItemName(
                                                                        WorkshopPermissionHelper.Role.WorkshopManager));
            equipmentsBarButtonItem.Enabled = permission.IsAuthorized(PermissionManager.WORKSHOP_APPLICATION,
                                                                    wph.ItemName(
                                                                        WorkshopPermissionHelper.Role.WorkshopManager));
            newContractBarButtonItem.Enabled = permission.IsAuthorized(PermissionManager.WORKSHOP_APPLICATION,
                                                                    wph.ItemName(
                                                                        WorkshopPermissionHelper.Role.WorkshopManager));
            workOrdersBarButtonItem.Enabled = permission.IsAuthorized(PermissionManager.WORKSHOP_APPLICATION,
                                                                    wph.ItemName(
                                                                        WorkshopPermissionHelper.Role.WorkshopManager));
            issueWorkOrderBarButtonItem.Enabled = permission.IsAuthorized(PermissionManager.WORKSHOP_APPLICATION,
                                                                    wph.ItemName(
                                                                        WorkshopPermissionHelper.Role.WorkshopManager));
            pmServicesBarButtonItem.Enabled = permission.IsAuthorized(PermissionManager.WORKSHOP_APPLICATION,
                                                                    wph.ItemName(
                                                                        WorkshopPermissionHelper.Role.WorkshopManager));
            invoicesBarButtonItem.Enabled = permission.IsAuthorized(PermissionManager.WORKSHOP_APPLICATION,
                                                                    wph.ItemName(
                                                                        WorkshopPermissionHelper.Role.WorkshopManager));
            generateInvoiceBarButtonIte.Enabled = permission.IsAuthorized(PermissionManager.WORKSHOP_APPLICATION,
                                                                    wph.ItemName(
                                                                        WorkshopPermissionHelper.Role.WorkshopManager));
            recordPaymentBarButtonItem.Enabled = permission.IsAuthorized(PermissionManager.WORKSHOP_APPLICATION,
                                                                    wph.ItemName(
                                                                        WorkshopPermissionHelper.Role.WorkshopManager));
            vendorsBarButtonItem.Enabled = permission.IsAuthorized(PermissionManager.WORKSHOP_APPLICATION,
                                                                    wph.ItemName(
                                                                        WorkshopPermissionHelper.Role.WorkshopManager));
            generalSettingBarButtonItem.Enabled = permission.IsAuthorized(PermissionManager.WORKSHOP_APPLICATION,
                                                                    wph.ItemName(
                                                                        WorkshopPermissionHelper.Role.WorkshopManager));
            customersBarButtonItem.Enabled = permission.IsAuthorized(PermissionManager.WORKSHOP_APPLICATION,
                                                                    wph.ItemName(
                                                                        WorkshopPermissionHelper.Role.WorkshopManager));
            printCustomersBarButtonItem.Enabled = permission.IsAuthorized(PermissionManager.WORKSHOP_APPLICATION,
                                                                    wph.ItemName(
                                                                        WorkshopPermissionHelper.Role.WorkshopManager));
        }

        /// <summary>
        /// Loads the startup screen for ClearOffice.
        /// </summary>
        private void LoadStartupScreen()
        {
            var ch = this.MdiChildren;
            foreach (var form in ch)
            {
                if (form.GetType() == typeof(HomeView))
                {
                    form.Activate();
                    return;
                }
            }
            var dashboard = new HomeView();
            dashboard.MdiParent = this;
            dashboard.WindowState = FormWindowState.Maximized;
            dashboard.Show();
        }

        private void newContractBarButtonItem_ItemClick(object sender, ItemClickEventArgs e)
        {
            var newContractView = _wmsModule.ShowNewContractView();
            newContractView.ShowObject(null);
            newContractView.MainParent = this;
            newContractView.ShowDialog();
        }

        private void contractsBarButtonItem_ItemClick(object sender, ItemClickEventArgs e)
        {
            var ch = this.MdiChildren;
            foreach (var form in ch)
            {
                if (form.GetType() == typeof(ContractListView))
                {
                    return;
                }
            }
            var contractListView = _wmsModule.ShowContractListView();
            contractListView.MdiParent = this;
            contractListView.Dock = DockStyle.Fill;
            contractListView.ShowList();
            contractListView.Show();
        }

        private void equipmentsBarButtonItem_ItemClick_1(object sender, ItemClickEventArgs e)
        {
            var ch = this.MdiChildren;
            foreach (var form in ch)
            {
                if (form.GetType() == typeof(EquipmentsView))
                {
                    return;
                }
            }
            var equipmentsView = _wmsModule.ShowEquipmentList();
            equipmentsView.ShowList();
            equipmentsView.MdiParent = this;
            equipmentsView.Show();
        }

        private void workOrdersBarButtonItem_ItemClick(object sender, ItemClickEventArgs e)
        {
            var ch = this.MdiChildren;
            foreach (var form in ch)
            {
                if (form.GetType() == typeof(WorkOrderListView))
                {
                    return;
                }
            }
            var wolv = _wmsModule.ShowWorkOrderList();
            wolv.ShowList();
            wolv.MdiParent = this;
            wolv.Show();
        }

        private void issueWorkOrderBarButtonItem_ItemClick(object sender, ItemClickEventArgs e)
        {
            try
            {
                if (this.ActiveMdiChild == null)
                    return;
                if (this.ActiveMdiChild.GetType() == typeof(EquipmentsView))
                {
                    var list = this.ActiveMdiChild as EquipmentsView;
                    var wo = new WorkOrderView();
                    if (list.GetSelectedItem() == null)
                        return;
                    wo.Equipment = list.GetSelectedItem();
                    wo.ShowObject(null);
                    wo.MdiParent = this;
                    wo.Show();
                }
                if (this.ActiveMdiChild.GetType() == typeof(EquipmentDetail))
                {
                    var ed = this.ActiveMdiChild as EquipmentDetail;
                    var wo = new WorkOrderView();
                    wo.Equipment = ed.GetEquipment();
                    wo.ShowObject(null);
                    wo.MdiParent = this;
                    wo.Show();
                }
            }
            catch (Exception exception)
            {
                if (exception.InnerException != null)
                    ViewHelper.ShowErrorMessage(exception.InnerException.Message);
            }
        }

        private void customersBarButtonItem_ItemClick(object sender, ItemClickEventArgs e)
        {
            var ch = this.MdiChildren;
            foreach (var form in ch)
            {
                if (form.GetType() == typeof(CustomerListView))
                {
                    return;
                }
            }
            var vendorList = _wmsModule.ShowCustomersList();
            vendorList.MdiParent = this;
            vendorList.Show();
        }

        private void newCustomerBarButtonItem_ItemClick(object sender, ItemClickEventArgs e)
        {
            var newCustomerView = _wmsModule.ShowNewCustomer();
            newCustomerView.MainForm = this;
            newCustomerView.ShowObject(null);
            newCustomerView.ShowDialog();
        }

        private void vendorsBarButtonItem_ItemClick(object sender, ItemClickEventArgs e)
        {
            var ch = this.MdiChildren;
            foreach (var form in ch)
            {
                if (form.GetType() == typeof(VendorListView))
                {
                    return;
                }
            }
            var vendorList = _wmsModule.ShowVendorList();
            vendorList.MdiParent = this;
            vendorList.Show();
        }

        private void generalSettingBarButtonItem_ItemClick(object sender, ItemClickEventArgs e)
        {
            var ch = this.MdiChildren;
            foreach (var form in ch)
            {
                if (form.GetType() == typeof(LookupView))
                {
                    return;
                }
            }
            var lookuplist = _wmsModule.showLookupList();
            lookuplist.MdiParent = this;
            lookuplist.Show();
        }

        private void invoicesBarButtonItem_ItemClick(object sender, ItemClickEventArgs e)
        {
            var ch = this.MdiChildren;
            foreach (var form in ch)
            {
                if (form.GetType() == typeof(FrmInvoiceListView))
                {
                    return;
                }
            }
            var invoicelist = _wmsModule.ShowInvoiceList();
            invoicelist.MdiParent = this;
            invoicelist.Show();

        }

        private void generateInvoiceBarButtonIte_ItemClick(object sender, ItemClickEventArgs e)
        {
            var newinvoice = _wmsModule.ShowNewInvoice();
            newinvoice.MdiParent = this;
            newinvoice.ShowObject(null);
            newinvoice.Show();

        }

        private void recordPaymentBarButtonItem_ItemClick(object sender, ItemClickEventArgs e)
        {
            if (this.ActiveMdiChild == null) return;
            if (this.ActiveMdiChild.GetType() == typeof(FrmInvoiceListView))
            {
                var list = this.ActiveMdiChild as FrmInvoiceListView;
                var newpayment = new NewPayment();
                newpayment.ShowObject(list.GetSelectedItem());
                newpayment.ShowDialog();
            }

        }

        private void pmServicesBarButtonItem_ItemClick(object sender, ItemClickEventArgs e)
        {
            var ch = this.MdiChildren;
            foreach (var form in ch)
            {
                if (form.GetType() == typeof(PMServiceListView))
                {
                    return;
                }
            }
            var pmslv = _wmsModule.ShowPmservices();
            pmslv.MdiParent = this;
            pmslv.ShowList();
            pmslv.Show();
        }

        private void workOrdersBarButtonItem_ItemClick_1(object sender, ItemClickEventArgs e)
        {
            var ch = this.MdiChildren;
            foreach (var form in ch)
            {
                if (form.GetType() == typeof(WorkOrderListView))
                {
                    return;
                }
            }
            var wov = new WorkOrderListView();
            wov.ShowList();
            wov.MdiParent = this;
            wov.Show();
        }

        private void vehiclesBarButtonItem_ItemClick(object sender, ItemClickEventArgs e)
        {
            foreach (var mdiChild in this.MdiChildren)
            {
                if (mdiChild.GetType() == typeof(VehicleList))
                {
                    mdiChild.Activate();
                    return;
                }
            }
            var vehicleList = _fleetModule.GetVehicleList();
            vehicleList.ShowList();
            vehicleList.MdiParent = this;
            vehicleList.Show();
        }

        private void newVehicleBarButtonItem_ItemClick(object sender, ItemClickEventArgs e)
        {
            var newVehicle = _fleetModule.NewVehicleRecord();
            newVehicle.ShowObject(null);
            newVehicle.ShowDialog();
        }

        private XtraForm CurrentMdiChild()
        {
            if (this.MdiChildren.Length > 0) return this.ActiveMdiChild as XtraForm;
            return null;
        }

        private void newMaintenanceBarButtonItem_ItemClick(object sender, ItemClickEventArgs e)
        {
            AddMaintenance();
        }

        private void AddMaintenance()
        {
            var form = this.CurrentMdiChild();

            // Check if there is a current MDI child before invoking the new process.
            if (null == form || form.GetType() != typeof(VehicleList))
            {
                ViewHelper.ShowErrorMessage("You must select a Vehicle record before adding new maintenance.");
                return;
            }

            var vehicleList = (IListForm)form;
            var vehicleInfo = vehicleList.GetSelectedItem();

            if (null != vehicleInfo)
            {
                var dialog = new MaintenanceEdit();
                // Invoke ShowObject method by passing the current VehicleInfo object.
                // Make sure that the dialog respondes as expected (i.e. it should check the type of the parameter).
                // You might be tempted to instantiate a new instance of Maintenance object but we DO NOT NEED to 
                // refrenece the business layer from the shell.
                dialog.ShowObject(vehicleInfo);
                dialog.ShowDialog();
            }

        }

        private void maintenanceHistoryBarButtonItem_ItemClick(object sender, ItemClickEventArgs e)
        {
            foreach (var mdiChild in this.MdiChildren)
            {
                if (mdiChild.GetType() == typeof(MaintenanceList))
                {
                    mdiChild.Activate();
                    return;
                }
            }
            var maintenanceList = _fleetModule.ShowMaintenanceList();
            maintenanceList.ShowList();
            maintenanceList.MdiParent = this;
            maintenanceList.Show();
        }

        private void newAssetBarButtonItem_ItemClick(object sender, ItemClickEventArgs e)
        {
            var newAsset = _fixedAssetModule.ShowNewAsset();
            newAsset.MainParent = this;
            newAsset.ShowObject(null);
            newAsset.ShowDialog();
        }

        private void assetsBarButtonItem_ItemClick(object sender, ItemClickEventArgs e)
        {
            var ch = this.MdiChildren;
            foreach (var form in ch)
            {
                if (form.GetType() == typeof(AssetList))
                {
                    form.Activate();
                    return;
                }
            }
            var assetList = _fixedAssetModule.ShowAssetList();
            assetList.MdiParent = this;
            assetList.ShowList();
            assetList.Show();
        }

        private void custodiansBarButtonItem_ItemClick(object sender, ItemClickEventArgs e)
        {
            var ch = this.MdiChildren;
            foreach (var form in ch)
            {
                if (form.GetType() == typeof(CustodianList))
                {
                    form.Activate();
                    return;
                }
            }
            var custodianlist = _fixedAssetModule.ShowCustodianList();
            custodianlist.MdiParent = this;
            custodianlist.Show();
        }

        private void assignAssetBarButtonItem_ItemClick(object sender, ItemClickEventArgs e)
        {
            if (this.ActiveMdiChild == null) return;
            if (this.ActiveMdiChild.GetType() == typeof(AssetList))
            {
                var list = this.ActiveMdiChild as AssetList;
                var selectedAsset = list.GetSelectedItem();
                if (selectedAsset != null)
                {
                    var custAsset = new CustodianAssetView();
                    custAsset.ShowObject(selectedAsset);
                    custAsset.ShowDialog();
                }

            }
            if (this.ActiveMdiChild.GetType() == typeof(AssetDetail))
            {
                var detailForm = this.ActiveMdiChild as AssetDetail;
                var selectedAsset = detailForm.CurrenObject;
                if (selectedAsset != null)
                {
                    var custAsset = new CustodianAssetView();
                    custAsset.ShowObject(selectedAsset);
                    custAsset.ShowDialog();

                }
                return;
            }
        }

        private void calculateDepreciationBarButtonItem_ItemClick(object sender, ItemClickEventArgs e)
        {
            if (this.ActiveMdiChild == null) return;
            if (this.ActiveMdiChild.GetType() == typeof(AssetList))
            {
                var list = this.ActiveMdiChild as AssetList;
                var selectedAsset = list.GetSelectedItem();
                if (selectedAsset != null)
                {
                    this.UseWaitCursor = true;
                    Cursor.Current = Cursors.WaitCursor;
                    Cursor.Show();
                    Cursor.Position.Offset(50, 50);
                    DepereciationHelper.CalculateDepreciation(selectedAsset);
                    this.UseWaitCursor = false;
                }
                return;
            }
            if (this.ActiveMdiChild.GetType() == typeof(AssetDetail))
            {
                var detailForm = this.ActiveMdiChild as AssetDetail;
                var selectedAsset = detailForm.CurrenObject;
                if (selectedAsset != null)
                {
                    this.UseWaitCursor = true;
                    Cursor.Current = Cursors.WaitCursor;
                    Cursor.Position.Offset(50, 50);
                    Cursor.Show();
                    DepereciationHelper.CalculateDepreciation(selectedAsset);
                    this.UseWaitCursor = false;
                }
                return;
            }
        }

        private void faSettingsBarButtonItem_ItemClick(object sender, ItemClickEventArgs e)
        {
            var ch = this.MdiChildren;
            foreach (var form in ch)
            {
                if (form.GetType() == typeof(LookUpList))
                {
                    form.Activate();
                    return;
                }
            }
            var custodianlist = _fixedAssetModule.ShowLookUpList();
            custodianlist.MdiParent = this;
            custodianlist.Show();
        }

        private void barButtonItem6_ItemClick(object sender, ItemClickEventArgs e)
        {
            var ch = this.MdiChildren;
            foreach (var form in ch)
            {
                if (form.GetType() == typeof(AssetCategoryList))
                {
                    form.Activate();
                    return;
                }
            }
            var assetcategorylist = _fixedAssetModule.ShowAssetcategoryList();
            assetcategorylist.MdiParent = this;
            assetcategorylist.Show();
        }

        private void barButtonItem1_ItemClick(object sender, ItemClickEventArgs e)
        {
            var applicationsetting = _fixedAssetModule.ShowApplicationsettingList();
            applicationsetting.ShowObject(null);
            applicationsetting.ShowDialog();
        }

        private void barButtonItem7_ItemClick(object sender, ItemClickEventArgs e)
        {
            this.UseWaitCursor = true;
            Cursor.Current = Cursors.WaitCursor;
            Cursor.Show();
            Cursor.Position.Offset(50, 50);
            DepereciationHelper.CalculateDepreciationToAll();
            this.UseWaitCursor = false;
        }

        private void homeBarButtonItem_ItemClick(object sender, ItemClickEventArgs e)
        {
            LoadStartupScreen();
        }

        private void exitBarButtonItem_ItemClick(object sender, ItemClickEventArgs e)
        {
            Application.Exit();
        }

        private void organizationBarButtonItem_ItemClick(object sender, ItemClickEventArgs e)
        {
            foreach (var mdiChild in this.MdiChildren)
            {
                if (mdiChild.GetType() == typeof(JobListView))
                {
                    mdiChild.Activate();
                    return;
                }
            }
            var jobListView = _hrmModule.GetJobListView();
            jobListView.ShowList();
            jobListView.MdiParent = this;
            jobListView.Show();
        }

        private void barButtonItem17_ItemClick(object sender, ItemClickEventArgs e)
        {
            foreach (var mdiChild in this.MdiChildren)
            {
                if (mdiChild.GetType() == typeof(EmployeeListView))
                {
                    mdiChild.Activate();
                    return;
                }
            }
            var employeelistview = _hrmModule.GetEmployeeListView();
            employeelistview.MdiParent = this;
            employeelistview.Show();
        }

        private void couponBarButtonItem_ItemClick(object sender, ItemClickEventArgs e)
        {
            foreach (var mdiChild in this.MdiChildren)
            {
                if (mdiChild.GetType() == typeof(CouponList))
                {
                    mdiChild.Activate();
                    return;
                }
            }
            var couponList = _fleetModule.ShowCouponList();
            couponList.ShowList();
            couponList.MdiParent = this;
            couponList.Show();
        }

        private void barButtonItem26_ItemClick(object sender, ItemClickEventArgs e)
        {
            foreach (var mdiChild in this.MdiChildren)
            {
                if (mdiChild.GetType() == typeof(TrainingListView))
                {
                    mdiChild.Activate();
                    return;
                }
            }
            var traininglistview = _hrmModule.GetTrainingListView();
            traininglistview.ShowList();
            traininglistview.MdiParent = this;
            traininglistview.Show();
        }

        private void barButtonItem27_ItemClick(object sender, ItemClickEventArgs e)
        {
            //var newtraining = new NewTrainingRequestView();
            //newtraining.ShowObject(null);
            //newtraining.ShowDialog();
        }

        private void reportsBarButtonItem_ItemClick(object sender, ItemClickEventArgs e)
        {
            foreach (var mdiChild in this.MdiChildren)
            {
                if (mdiChild.GetType() == typeof(HomeView))
                {
                    mdiChild.Activate();
                    return;
                }
            }
            var hv = new HomeView();
            hv.MdiParent = this;
            hv.Show();
        }

        private void barButtonItem24_ItemClick_1(object sender, ItemClickEventArgs e)
        {
            foreach (var mdiChild in this.MdiChildren)
            {
                if (mdiChild.GetType() == typeof(LeaveRequestListView))
                {
                    mdiChild.Activate();
                    return;
                }
            }
            var lrl = new LeaveRequestListView();
            lrl.ShowList();
            lrl.MdiParent = this;
            lrl.Show();
        }

        private void barButtonItem23_ItemClick(object sender, ItemClickEventArgs e)
        {
            foreach (var mdiChild in this.MdiChildren)
            {
                if (mdiChild.GetType() == typeof(LeaveStatusView))
                {
                    mdiChild.Activate();
                    return;
                }
            }
            var lsv = new LeaveStatusView();
            lsv.ShowList();
            lsv.MdiParent = this;
            lsv.Show();
        }

        private void calculateLeaveBarButtonItem_ItemClick(object sender, ItemClickEventArgs e)
        {
            var result = ViewHelper.ShowConfirmDialog("Are you sure you want to calculate current leave value for all employees.");
            if (result == DialogResult.Yes)
            {
                try
                {
                    LeaveCalculationHelper.CalculateLeaveForAll();
                    ViewHelper.ShowSuccessMessage("Leave calculation completed successfuly.");
                }
                catch (Exception exception)
                {
                    ViewHelper.ShowErrorMessage("Error has occured during leave calculation.", exception);
                }
            }
        }

        private void intialLeaveBarButtonItem_ItemClick(object sender, ItemClickEventArgs e)
        {
            var ilv = new EmployeeInitialLeaveConfigurationView();
            ilv.ShowList();
            ilv.ShowDialog();
        }

        private void usersBarButtonItem_ItemClick(object sender, ItemClickEventArgs e)
        {
            foreach (var mdiChild in this.MdiChildren)
            {
                if (mdiChild.GetType() == typeof(UsersListView))
                {
                    mdiChild.Activate();
                    return;
                }
            }
            var ulv = SecurityHelper.ShowUsersList();
            ulv.ShowList();
            ulv.MdiParent = this;
            ulv.Show();
        }

        private void MainForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (e.CloseReason == CloseReason.ApplicationExitCall)
                return;

            var result = MessageBox.Show(@"Are you sure you want to exit the application?", @"Exit ClearOffice", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (result == DialogResult.No)
                e.Cancel = true;
        }

        private void MainForm_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }

        private void logoutBarButtonItem_ItemClick(object sender, ItemClickEventArgs e)
        {
            var result = MessageBox.Show(@"Are you sure you want to logout from ClearOffice?", @"Logout", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (result == DialogResult.No)
                return;
            Application.Restart();
        }


        private void tireBarButtonItem_ItemClick(object sender, ItemClickEventArgs e)
        {
            foreach (var mdiChild in this.MdiChildren)
            {
                if (mdiChild.GetType() == typeof(TireListView))
                {
                    mdiChild.Activate();
                    return;
                }
            }
            var tireList = _fleetModule.ShowTireInventory();
            tireList.ShowList();
            tireList.MdiParent = this;
            tireList.Show();
        }

        private void fleetSettingBarButtonItem_ItemClick(object sender, ItemClickEventArgs e)
        {
            var ch = this.MdiChildren;
            foreach (var form in ch)
            {
                if (form.GetType() == typeof(FleetLookUpListView))
                {
                    form.Activate();
                    return;
                }
            }
            var listView = new FleetLookUpListView();
            listView.MdiParent = this;
            listView.ShowList();
            listView.Show();
        }

        private void itemsBarButtonItem_ItemClick(object sender, ItemClickEventArgs e)
        {
            var ch = this.MdiChildren;
            foreach (var form in ch)
            {
                if (form.GetType() == typeof(ItemsListView))
                {
                    form.Activate();
                    return;
                }
            }
            var listView = new ItemsListView();
            listView.MdiParent = this;
            listView.ShowList();
            listView.Show();
        }

        private void receivingBarButtonItem_ItemClick(object sender, ItemClickEventArgs e)
        {
            var ch = this.MdiChildren;
            foreach (var form in ch)
            {
                if (form.GetType() == typeof(ReceivingList))
                {
                    form.Activate();
                    return;
                }
            }
            var listView = new ReceivingList();
            listView.MdiParent = this;
            listView.ShowList();
            listView.Show();
        }

        private void stockStatusBarButtonItem_ItemClick(object sender, ItemClickEventArgs e)
        {
            var ch = this.MdiChildren;
            foreach (var form in ch)
            {
                if (form.GetType() == typeof(StockStatusView))
                {
                    form.Activate();
                    return;
                }
            }
            var listView = new StockStatusView();
            listView.MdiParent = this;
            listView.ShowList();
            listView.Show();
        }

        private void issueBarButtonItem_ItemClick(object sender, ItemClickEventArgs e)
        {
            var ch = this.MdiChildren;
            foreach (var form in ch)
            {
                if (form.GetType() == typeof(IssueListView))
                {
                    form.Activate();
                    return;
                }
            }
            var listView = new IssueListView();
            listView.MdiParent = this;
            listView.ShowList();
            listView.Show();
        }

        private void returnBarButtonItem_ItemClick(object sender, ItemClickEventArgs e)
        {
            var ch = this.MdiChildren;
            foreach (var form in ch)
            {
                if (form.GetType() == typeof(ReturnListView))
                {
                    form.Activate();
                    return;
                }
            }
            var listView = new ReturnListView();
            listView.MdiParent = this;
            listView.ShowList();
            listView.Show();
        }

        private void transferBarButtonItem_ItemClick(object sender, ItemClickEventArgs e)
        {
            var ch = this.MdiChildren;
            foreach (var form in ch)
            {
                if (form.GetType() == typeof(TransferListView))
                {
                    form.Activate();
                    return;
                }
            }
            var listView = new TransferListView();
            listView.MdiParent = this;
            listView.ShowList();
            listView.Show();
        }

        private void adjustmentBarButtonItem_ItemClick(object sender, ItemClickEventArgs e)
        {
            var ch = this.MdiChildren;
            foreach (var form in ch)
            {
                if (form.GetType() == typeof(AdjustmentListView))
                {
                    form.Activate();
                    return;
                }
            }
            var listView = new AdjustmentListView();
            listView.MdiParent = this;
            listView.ShowList();
            listView.Show();
        }

        private void inventorySettingBarButtonItem_ItemClick(object sender, ItemClickEventArgs e)
        {
            //var ch = this.MdiChildren;
            //foreach (var form in ch)
            //{
            //    if (form.GetType() == typeof(InventoryLookupListView))
            //    {
            //        form.Activate();
            //        return;
            //    }
            //}
            //var listView = new InventoryLookupListView();
            //listView.MdiParent = this;
            //listView.ShowList();
            //listView.Show();
        }

        private void warehousebarButtonItem_ItemClick(object sender, ItemClickEventArgs e)
        {
            var warehouse = new WarehouseView();
            warehouse.ShowList();
            warehouse.ShowDialog();
        }

        private void supplierbarButtonItem_ItemClick_1(object sender, ItemClickEventArgs e)
        {
            var supplier = new SupplierView();
            supplier.ShowList();
            supplier.ShowDialog();
        }

        private void measurementbarButtonItem_ItemClick(object sender, ItemClickEventArgs e)
        {
            var warehouse = new MeasurmentView();
            warehouse.ShowList();
            warehouse.ShowDialog();
        }


        public FleetPermissionHelper flph { get; set; }
    }
}