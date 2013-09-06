namespace ClearOffice.Fleet.Views
{
    partial class VehicleList
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(VehicleList));
            this.gridControl1 = new DevExpress.XtraGrid.GridControl();
            this.vehicleListContextMenuStrip = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.newVehicleToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.viewDetailToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem1 = new System.Windows.Forms.ToolStripSeparator();
            this.addFuelLogToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.addExpenseToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.newMaintenanceToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.vehicleListBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.gridView1 = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.fleetRibbonControl = new DevExpress.XtraBars.Ribbon.RibbonControl();
            this.smallImageCollection = new DevExpress.Utils.ImageCollection(this.components);
            this.refreshBarButtonItem = new DevExpress.XtraBars.BarButtonItem();
            this.newVehicleBarButtonItem = new DevExpress.XtraBars.BarButtonItem();
            this.largeImageCollection = new DevExpress.Utils.ImageCollection(this.components);
            this.fleetListRibbonPage = new DevExpress.XtraBars.Ribbon.RibbonPage();
            this.ribbonPageGroup1 = new DevExpress.XtraBars.Ribbon.RibbonPageGroup();
            this.colPlateNumber = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colProductionYear = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colChasisNo = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colEngineSerial = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colLibreNo = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colVehicleMakeName = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colVehicleOwnershipName = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colVehicleTypeName = new DevExpress.XtraGrid.Columns.GridColumn();
            ((System.ComponentModel.ISupportInitialize)(this.gridControl1)).BeginInit();
            this.vehicleListContextMenuStrip.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.vehicleListBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.fleetRibbonControl)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.smallImageCollection)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.largeImageCollection)).BeginInit();
            this.SuspendLayout();
            // 
            // gridControl1
            // 
            this.gridControl1.ContextMenuStrip = this.vehicleListContextMenuStrip;
            this.gridControl1.DataSource = this.vehicleListBindingSource;
            this.gridControl1.Location = new System.Drawing.Point(0, 149);
            this.gridControl1.MainView = this.gridView1;
            this.gridControl1.Name = "gridControl1";
            this.gridControl1.Size = new System.Drawing.Size(791, 374);
            this.gridControl1.TabIndex = 1;
            this.gridControl1.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridView1});
            this.gridControl1.DoubleClick += new System.EventHandler(this.gridControl1_DoubleClick);
            // 
            // vehicleListContextMenuStrip
            // 
            this.vehicleListContextMenuStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.newVehicleToolStripMenuItem,
            this.viewDetailToolStripMenuItem,
            this.toolStripMenuItem1,
            this.addFuelLogToolStripMenuItem,
            this.addExpenseToolStripMenuItem,
            this.newMaintenanceToolStripMenuItem});
            this.vehicleListContextMenuStrip.Name = "vehicleListContextMenuStrip";
            this.vehicleListContextMenuStrip.Size = new System.Drawing.Size(209, 120);
            // 
            // newVehicleToolStripMenuItem
            // 
            this.newVehicleToolStripMenuItem.Name = "newVehicleToolStripMenuItem";
            this.newVehicleToolStripMenuItem.Size = new System.Drawing.Size(208, 22);
            this.newVehicleToolStripMenuItem.Text = "New Vehicle";
            this.newVehicleToolStripMenuItem.Click += new System.EventHandler(this.newVehicleToolStripMenuItem_Click);
            // 
            // viewDetailToolStripMenuItem
            // 
            this.viewDetailToolStripMenuItem.Name = "viewDetailToolStripMenuItem";
            this.viewDetailToolStripMenuItem.Size = new System.Drawing.Size(208, 22);
            this.viewDetailToolStripMenuItem.Text = "View Detail";
            this.viewDetailToolStripMenuItem.Click += new System.EventHandler(this.viewDetailToolStripMenuItem_Click);
            // 
            // toolStripMenuItem1
            // 
            this.toolStripMenuItem1.Name = "toolStripMenuItem1";
            this.toolStripMenuItem1.Size = new System.Drawing.Size(205, 6);
            // 
            // addFuelLogToolStripMenuItem
            // 
            this.addFuelLogToolStripMenuItem.Name = "addFuelLogToolStripMenuItem";
            this.addFuelLogToolStripMenuItem.Size = new System.Drawing.Size(208, 22);
            this.addFuelLogToolStripMenuItem.Text = "Add Fuel Log";
            this.addFuelLogToolStripMenuItem.Click += new System.EventHandler(this.addFuelLogToolStripMenuItem_Click);
            // 
            // addExpenseToolStripMenuItem
            // 
            this.addExpenseToolStripMenuItem.Name = "addExpenseToolStripMenuItem";
            this.addExpenseToolStripMenuItem.Size = new System.Drawing.Size(208, 22);
            this.addExpenseToolStripMenuItem.Text = "Add Expense";
            this.addExpenseToolStripMenuItem.Click += new System.EventHandler(this.addExpenseToolStripMenuItem_Click);
            // 
            // newMaintenanceToolStripMenuItem
            // 
            this.newMaintenanceToolStripMenuItem.Name = "newMaintenanceToolStripMenuItem";
            this.newMaintenanceToolStripMenuItem.Size = new System.Drawing.Size(208, 22);
            this.newMaintenanceToolStripMenuItem.Text = "Add Maintenance Record";
            this.newMaintenanceToolStripMenuItem.Click += new System.EventHandler(this.newMaintenanceToolStripMenuItem_Click);
            // 
            // vehicleListBindingSource
            // 
            this.vehicleListBindingSource.DataSource = typeof(ClearOffice.Fleet.Business.VehicleInfo);
            // 
            // gridView1
            // 
            this.gridView1.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.colPlateNumber,
            this.colChasisNo,
            this.colEngineSerial,
            this.colLibreNo,
            this.colVehicleMakeName,
            this.colVehicleOwnershipName,
            this.colVehicleTypeName,
            this.colProductionYear});
            this.gridView1.GridControl = this.gridControl1;
            this.gridView1.Name = "gridView1";
            this.gridView1.OptionsBehavior.Editable = false;
            this.gridView1.OptionsView.ShowAutoFilterRow = true;
            this.gridView1.OptionsView.ShowGroupPanel = false;
            // 
            // fleetRibbonControl
            // 
            this.fleetRibbonControl.ApplicationButtonText = null;
            // 
            // 
            // 
            this.fleetRibbonControl.ExpandCollapseItem.Id = 0;
            this.fleetRibbonControl.ExpandCollapseItem.Name = "";
            this.fleetRibbonControl.Images = this.smallImageCollection;
            this.fleetRibbonControl.Items.AddRange(new DevExpress.XtraBars.BarItem[] {
            this.fleetRibbonControl.ExpandCollapseItem,
            this.refreshBarButtonItem,
            this.newVehicleBarButtonItem});
            this.fleetRibbonControl.LargeImages = this.largeImageCollection;
            this.fleetRibbonControl.Location = new System.Drawing.Point(0, 0);
            this.fleetRibbonControl.MaxItemId = 4;
            this.fleetRibbonControl.MdiMergeStyle = DevExpress.XtraBars.Ribbon.RibbonMdiMergeStyle.Always;
            this.fleetRibbonControl.Name = "fleetRibbonControl";
            this.fleetRibbonControl.Pages.AddRange(new DevExpress.XtraBars.Ribbon.RibbonPage[] {
            this.fleetListRibbonPage});
            this.fleetRibbonControl.SelectedPage = this.fleetListRibbonPage;
            this.fleetRibbonControl.Size = new System.Drawing.Size(791, 143);
            // 
            // smallImageCollection
            // 
            this.smallImageCollection.ImageStream = ((DevExpress.Utils.ImageCollectionStreamer)(resources.GetObject("smallImageCollection.ImageStream")));
            this.smallImageCollection.Images.SetKeyName(0, "Refresh_16x16.png");
            this.smallImageCollection.Images.SetKeyName(1, "car--plus.png");
            // 
            // refreshBarButtonItem
            // 
            this.refreshBarButtonItem.Caption = "Refresh";
            this.refreshBarButtonItem.Id = 1;
            this.refreshBarButtonItem.ImageIndex = 0;
            this.refreshBarButtonItem.Name = "refreshBarButtonItem";
            this.refreshBarButtonItem.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.refreshBarButtonItem_ItemClick);
            // 
            // newVehicleBarButtonItem
            // 
            this.newVehicleBarButtonItem.Caption = "New Vehicle";
            this.newVehicleBarButtonItem.Id = 3;
            this.newVehicleBarButtonItem.ImageIndex = 1;
            this.newVehicleBarButtonItem.Name = "newVehicleBarButtonItem";
            this.newVehicleBarButtonItem.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.newVehicleBarButtonItem_ItemClick);
            // 
            // largeImageCollection
            // 
            this.largeImageCollection.ImageSize = new System.Drawing.Size(32, 32);
            this.largeImageCollection.ImageStream = ((DevExpress.Utils.ImageCollectionStreamer)(resources.GetObject("largeImageCollection.ImageStream")));
            // 
            // fleetListRibbonPage
            // 
            this.fleetListRibbonPage.Groups.AddRange(new DevExpress.XtraBars.Ribbon.RibbonPageGroup[] {
            this.ribbonPageGroup1});
            this.fleetListRibbonPage.Name = "fleetListRibbonPage";
            this.fleetListRibbonPage.Text = "Fleet";
            // 
            // ribbonPageGroup1
            // 
            this.ribbonPageGroup1.ItemLinks.Add(this.newVehicleBarButtonItem);
            this.ribbonPageGroup1.ItemLinks.Add(this.refreshBarButtonItem);
            this.ribbonPageGroup1.Name = "ribbonPageGroup1";
            this.ribbonPageGroup1.Text = "Vehicles";
            // 
            // colPlateNumber
            // 
            this.colPlateNumber.FieldName = "PlateNumber";
            this.colPlateNumber.Name = "colPlateNumber";
            this.colPlateNumber.Visible = true;
            this.colPlateNumber.VisibleIndex = 0;
            // 
            // colProductionYear
            // 
            this.colProductionYear.FieldName = "ProductionYear";
            this.colProductionYear.Name = "colProductionYear";
            this.colProductionYear.Visible = true;
            this.colProductionYear.VisibleIndex = 7;
            // 
            // colChasisNo
            // 
            this.colChasisNo.FieldName = "ChasisNo";
            this.colChasisNo.Name = "colChasisNo";
            this.colChasisNo.Visible = true;
            this.colChasisNo.VisibleIndex = 1;
            // 
            // colEngineSerial
            // 
            this.colEngineSerial.FieldName = "EngineSerial";
            this.colEngineSerial.Name = "colEngineSerial";
            this.colEngineSerial.Visible = true;
            this.colEngineSerial.VisibleIndex = 2;
            // 
            // colLibreNo
            // 
            this.colLibreNo.FieldName = "LibreNo";
            this.colLibreNo.Name = "colLibreNo";
            this.colLibreNo.Visible = true;
            this.colLibreNo.VisibleIndex = 3;
            // 
            // colVehicleMakeName
            // 
            this.colVehicleMakeName.Caption = "Vehicle Make";
            this.colVehicleMakeName.FieldName = "VehicleMakeName";
            this.colVehicleMakeName.Name = "colVehicleMakeName";
            this.colVehicleMakeName.Visible = true;
            this.colVehicleMakeName.VisibleIndex = 4;
            // 
            // colVehicleOwnershipName
            // 
            this.colVehicleOwnershipName.Caption = "Ownership";
            this.colVehicleOwnershipName.FieldName = "VehicleOwnershipName";
            this.colVehicleOwnershipName.Name = "colVehicleOwnershipName";
            this.colVehicleOwnershipName.Visible = true;
            this.colVehicleOwnershipName.VisibleIndex = 5;
            // 
            // colVehicleTypeName
            // 
            this.colVehicleTypeName.Caption = "Vehicle Type";
            this.colVehicleTypeName.FieldName = "VehicleTypeName";
            this.colVehicleTypeName.Name = "colVehicleTypeName";
            this.colVehicleTypeName.Visible = true;
            this.colVehicleTypeName.VisibleIndex = 6;
            // 
            // VehicleList
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(791, 523);
            this.Controls.Add(this.fleetRibbonControl);
            this.Controls.Add(this.gridControl1);
            this.Name = "VehicleList";
            this.Text = "Vehicle List";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Activated += new System.EventHandler(this.VehicleList_Activated);
            ((System.ComponentModel.ISupportInitialize)(this.gridControl1)).EndInit();
            this.vehicleListContextMenuStrip.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.vehicleListBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.fleetRibbonControl)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.smallImageCollection)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.largeImageCollection)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraGrid.GridControl gridControl1;
        private DevExpress.XtraGrid.Views.Grid.GridView gridView1;
        private System.Windows.Forms.BindingSource vehicleListBindingSource;
        private System.Windows.Forms.ContextMenuStrip vehicleListContextMenuStrip;
        private System.Windows.Forms.ToolStripMenuItem newVehicleToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem viewDetailToolStripMenuItem;
        private System.Windows.Forms.ToolStripSeparator toolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem addFuelLogToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem addExpenseToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem newMaintenanceToolStripMenuItem;
        private DevExpress.XtraBars.Ribbon.RibbonControl fleetRibbonControl;
        private DevExpress.XtraBars.Ribbon.RibbonPage fleetListRibbonPage;
        private DevExpress.XtraBars.Ribbon.RibbonPageGroup ribbonPageGroup1;
        private DevExpress.XtraBars.BarButtonItem refreshBarButtonItem;
        private DevExpress.Utils.ImageCollection smallImageCollection;
        private DevExpress.Utils.ImageCollection largeImageCollection;
        private DevExpress.XtraBars.BarButtonItem newVehicleBarButtonItem;
        private DevExpress.XtraGrid.Columns.GridColumn colPlateNumber;
        private DevExpress.XtraGrid.Columns.GridColumn colChasisNo;
        private DevExpress.XtraGrid.Columns.GridColumn colEngineSerial;
        private DevExpress.XtraGrid.Columns.GridColumn colLibreNo;
        private DevExpress.XtraGrid.Columns.GridColumn colVehicleMakeName;
        private DevExpress.XtraGrid.Columns.GridColumn colVehicleOwnershipName;
        private DevExpress.XtraGrid.Columns.GridColumn colVehicleTypeName;
        private DevExpress.XtraGrid.Columns.GridColumn colProductionYear;
    }
}