namespace ClearOffice.Fleet.Views
{
    partial class VehicleDetail
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
            System.Windows.Forms.Label plateNumberLabel;
            System.Windows.Forms.Label makeIdLabel;
            System.Windows.Forms.Label modelIdLabel;
            System.Windows.Forms.Label ownershipIdLabel;
            System.Windows.Forms.Label productionYearLabel;
            System.Windows.Forms.Label libreNoLabel;
            System.Windows.Forms.Label purchaseDateLabel;
            System.Windows.Forms.Label vendorIdLabel;
            System.Windows.Forms.Label remarkLabel;
            System.Windows.Forms.Label chasisNoLabel;
            System.Windows.Forms.Label engineSerialLabel;
            System.Windows.Forms.Label cylindersLabel;
            System.Windows.Forms.Label fuelTypeIdLabel;
            System.Windows.Forms.Label noOfTiresLabel;
            System.Windows.Forms.Label fueltankCapacityLabel;
            DevExpress.XtraCharts.XYDiagram xyDiagram1 = new DevExpress.XtraCharts.XYDiagram();
            DevExpress.XtraCharts.Series series1 = new DevExpress.XtraCharts.Series();
            DevExpress.XtraCharts.PointSeriesLabel pointSeriesLabel1 = new DevExpress.XtraCharts.PointSeriesLabel();
            DevExpress.XtraCharts.LineSeriesView lineSeriesView1 = new DevExpress.XtraCharts.LineSeriesView();
            DevExpress.XtraCharts.SideBySideBarSeriesLabel sideBySideBarSeriesLabel1 = new DevExpress.XtraCharts.SideBySideBarSeriesLabel();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(VehicleDetail));
            this.groupControl1 = new DevExpress.XtraEditors.GroupControl();
            this.remarkTextBox = new System.Windows.Forms.TextBox();
            this.vehicleBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.vendorIdLookUpEdit = new DevExpress.XtraEditors.LookUpEdit();
            this.vendorBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.purchaseDateDateEdit = new DevExpress.XtraEditors.DateEdit();
            this.libreNoTextBox = new System.Windows.Forms.TextBox();
            this.productionYearTextBox = new System.Windows.Forms.TextBox();
            this.ownershipIdLookUpEdit = new DevExpress.XtraEditors.LookUpEdit();
            this.ownershipBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.modelIdLookUpEdit = new DevExpress.XtraEditors.LookUpEdit();
            this.modelBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.makeIdLookUpEdit = new DevExpress.XtraEditors.LookUpEdit();
            this.makeBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.plateNumberTextBox = new System.Windows.Forms.TextBox();
            this.xtraTabControl1 = new DevExpress.XtraTab.XtraTabControl();
            this.detailXtraTabPage = new DevExpress.XtraTab.XtraTabPage();
            this.fueltankCapacityTextBox = new System.Windows.Forms.TextBox();
            this.noOfTiresTextBox = new System.Windows.Forms.TextBox();
            this.fuelTypeIdLookUpEdit = new DevExpress.XtraEditors.LookUpEdit();
            this.fuelTypeBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.cylindersTextBox = new System.Windows.Forms.TextBox();
            this.engineSerialTextBox = new System.Windows.Forms.TextBox();
            this.chasisNoTextBox = new System.Windows.Forms.TextBox();
            this.picturePictureEdit = new DevExpress.XtraEditors.PictureEdit();
            this.fuelLogXtraTabPage = new DevExpress.XtraTab.XtraTabPage();
            this.chartControl1 = new DevExpress.XtraCharts.ChartControl();
            this.gridControl1 = new DevExpress.XtraGrid.GridControl();
            this.fuelLogBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.gridView1 = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.colFilledDate = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colDistanceCovered = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colFuelAmount = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colTotalCost = new DevExpress.XtraGrid.Columns.GridColumn();
            this.expenseXtraTabPage = new DevExpress.XtraTab.XtraTabPage();
            this.gridControl2 = new DevExpress.XtraGrid.GridControl();
            this.expenseBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.gridView2 = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.colInvoice = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colPaymentDate = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colAmount = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colDescription = new DevExpress.XtraGrid.Columns.GridColumn();
            this.insuranceXtraTabPage = new DevExpress.XtraTab.XtraTabPage();
            this.gridControl3 = new DevExpress.XtraGrid.GridControl();
            this.insuranceHistoryBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.gridView3 = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.colPolicyNo = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colPolicyType = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colCompanyId = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colDateInsured = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colRemainingDays = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colExpiresOn = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colAgentName = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colAgentTelephone = new DevExpress.XtraGrid.Columns.GridColumn();
            this.mainteanceXtraTabPage = new DevExpress.XtraTab.XtraTabPage();
            this.gridControl4 = new DevExpress.XtraGrid.GridControl();
            this.maintenanceBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.gridView4 = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.colCompletionDate = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colServiceRequestNo = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colServicedBy = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colAccountNo = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colServiceTypeId = new DevExpress.XtraGrid.Columns.GridColumn();
            this.tireXtraTabPage = new DevExpress.XtraTab.XtraTabPage();
            this.gridControl5 = new DevExpress.XtraGrid.GridControl();
            this.tireBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.gridView5 = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.colTireId = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colPosition = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colMountedDate = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colMountedMilage = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colUnmountedDate = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colUnmountMilage = new DevExpress.XtraGrid.Columns.GridColumn();
            this.groupControl2 = new DevExpress.XtraEditors.GroupControl();
            this.summaryLabel = new DevExpress.XtraEditors.LabelControl();
            this.ribbonControl1 = new DevExpress.XtraBars.Ribbon.RibbonControl();
            this.smallImageCollection = new DevExpress.Utils.ImageCollection(this.components);
            this.saveBarButtonItem = new DevExpress.XtraBars.BarButtonItem();
            this.deleteBarButtonItem = new DevExpress.XtraBars.BarButtonItem();
            this.addFuelLogBarButtonItem = new DevExpress.XtraBars.BarButtonItem();
            this.addExpenseBarButtonItem = new DevExpress.XtraBars.BarButtonItem();
            this.insuranceBarButtonItem = new DevExpress.XtraBars.BarButtonItem();
            this.largeImageCollection = new DevExpress.Utils.ImageCollection(this.components);
            this.ribbonPage1 = new DevExpress.XtraBars.Ribbon.RibbonPage();
            this.ribbonPageGroup1 = new DevExpress.XtraBars.Ribbon.RibbonPageGroup();
            this.panelControl2 = new DevExpress.XtraEditors.PanelControl();
            plateNumberLabel = new System.Windows.Forms.Label();
            makeIdLabel = new System.Windows.Forms.Label();
            modelIdLabel = new System.Windows.Forms.Label();
            ownershipIdLabel = new System.Windows.Forms.Label();
            productionYearLabel = new System.Windows.Forms.Label();
            libreNoLabel = new System.Windows.Forms.Label();
            purchaseDateLabel = new System.Windows.Forms.Label();
            vendorIdLabel = new System.Windows.Forms.Label();
            remarkLabel = new System.Windows.Forms.Label();
            chasisNoLabel = new System.Windows.Forms.Label();
            engineSerialLabel = new System.Windows.Forms.Label();
            cylindersLabel = new System.Windows.Forms.Label();
            fuelTypeIdLabel = new System.Windows.Forms.Label();
            noOfTiresLabel = new System.Windows.Forms.Label();
            fueltankCapacityLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.groupControl1)).BeginInit();
            this.groupControl1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.vehicleBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.vendorIdLookUpEdit.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.vendorBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.purchaseDateDateEdit.Properties.VistaTimeProperties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.purchaseDateDateEdit.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ownershipIdLookUpEdit.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ownershipBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.modelIdLookUpEdit.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.modelBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.makeIdLookUpEdit.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.makeBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.xtraTabControl1)).BeginInit();
            this.xtraTabControl1.SuspendLayout();
            this.detailXtraTabPage.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.fuelTypeIdLookUpEdit.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.fuelTypeBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picturePictureEdit.Properties)).BeginInit();
            this.fuelLogXtraTabPage.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.chartControl1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(xyDiagram1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(series1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(pointSeriesLabel1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(lineSeriesView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(sideBySideBarSeriesLabel1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridControl1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.fuelLogBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).BeginInit();
            this.expenseXtraTabPage.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gridControl2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.expenseBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView2)).BeginInit();
            this.insuranceXtraTabPage.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gridControl3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.insuranceHistoryBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView3)).BeginInit();
            this.mainteanceXtraTabPage.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gridControl4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.maintenanceBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView4)).BeginInit();
            this.tireXtraTabPage.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gridControl5)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tireBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView5)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.groupControl2)).BeginInit();
            this.groupControl2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ribbonControl1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.smallImageCollection)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.largeImageCollection)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.panelControl2)).BeginInit();
            this.panelControl2.SuspendLayout();
            this.SuspendLayout();
            // 
            // plateNumberLabel
            // 
            plateNumberLabel.AutoSize = true;
            plateNumberLabel.Location = new System.Drawing.Point(7, 26);
            plateNumberLabel.Name = "plateNumberLabel";
            plateNumberLabel.Size = new System.Drawing.Size(46, 13);
            plateNumberLabel.TabIndex = 0;
            plateNumberLabel.Text = "Plate #:";
            // 
            // makeIdLabel
            // 
            makeIdLabel.AutoSize = true;
            makeIdLabel.Location = new System.Drawing.Point(7, 76);
            makeIdLabel.Name = "makeIdLabel";
            makeIdLabel.Size = new System.Drawing.Size(36, 13);
            makeIdLabel.TabIndex = 2;
            makeIdLabel.Text = "Make:";
            // 
            // modelIdLabel
            // 
            modelIdLabel.AutoSize = true;
            modelIdLabel.Location = new System.Drawing.Point(7, 51);
            modelIdLabel.Name = "modelIdLabel";
            modelIdLabel.Size = new System.Drawing.Size(35, 13);
            modelIdLabel.TabIndex = 4;
            modelIdLabel.Text = "Type:";
            // 
            // ownershipIdLabel
            // 
            ownershipIdLabel.AutoSize = true;
            ownershipIdLabel.Location = new System.Drawing.Point(7, 100);
            ownershipIdLabel.Name = "ownershipIdLabel";
            ownershipIdLabel.Size = new System.Drawing.Size(62, 13);
            ownershipIdLabel.TabIndex = 6;
            ownershipIdLabel.Text = "Ownership:";
            // 
            // productionYearLabel
            // 
            productionYearLabel.AutoSize = true;
            productionYearLabel.Location = new System.Drawing.Point(239, 25);
            productionYearLabel.Name = "productionYearLabel";
            productionYearLabel.Size = new System.Drawing.Size(87, 13);
            productionYearLabel.TabIndex = 8;
            productionYearLabel.Text = "Production Year:";
            // 
            // libreNoLabel
            // 
            libreNoLabel.AutoSize = true;
            libreNoLabel.Location = new System.Drawing.Point(239, 99);
            libreNoLabel.Name = "libreNoLabel";
            libreNoLabel.Size = new System.Drawing.Size(50, 13);
            libreNoLabel.TabIndex = 10;
            libreNoLabel.Text = "Libre No:";
            // 
            // purchaseDateLabel
            // 
            purchaseDateLabel.AutoSize = true;
            purchaseDateLabel.Location = new System.Drawing.Point(239, 50);
            purchaseDateLabel.Name = "purchaseDateLabel";
            purchaseDateLabel.Size = new System.Drawing.Size(81, 13);
            purchaseDateLabel.TabIndex = 12;
            purchaseDateLabel.Text = "Purchase Date:";
            // 
            // vendorIdLabel
            // 
            vendorIdLabel.AutoSize = true;
            vendorIdLabel.Location = new System.Drawing.Point(239, 74);
            vendorIdLabel.Name = "vendorIdLabel";
            vendorIdLabel.Size = new System.Drawing.Size(45, 13);
            vendorIdLabel.TabIndex = 14;
            vendorIdLabel.Text = "Vendor:";
            // 
            // remarkLabel
            // 
            remarkLabel.AutoSize = true;
            remarkLabel.Location = new System.Drawing.Point(7, 128);
            remarkLabel.Name = "remarkLabel";
            remarkLabel.Size = new System.Drawing.Size(47, 13);
            remarkLabel.TabIndex = 16;
            remarkLabel.Text = "Remark:";
            // 
            // chasisNoLabel
            // 
            chasisNoLabel.AutoSize = true;
            chasisNoLabel.Location = new System.Drawing.Point(12, 17);
            chasisNoLabel.Name = "chasisNoLabel";
            chasisNoLabel.Size = new System.Drawing.Size(58, 13);
            chasisNoLabel.TabIndex = 11;
            chasisNoLabel.Text = "Chasis No:";
            // 
            // engineSerialLabel
            // 
            engineSerialLabel.AutoSize = true;
            engineSerialLabel.Location = new System.Drawing.Point(12, 44);
            engineSerialLabel.Name = "engineSerialLabel";
            engineSerialLabel.Size = new System.Drawing.Size(59, 13);
            engineSerialLabel.TabIndex = 12;
            engineSerialLabel.Text = "Engine No:";
            // 
            // cylindersLabel
            // 
            cylindersLabel.AutoSize = true;
            cylindersLabel.Location = new System.Drawing.Point(12, 71);
            cylindersLabel.Name = "cylindersLabel";
            cylindersLabel.Size = new System.Drawing.Size(55, 13);
            cylindersLabel.TabIndex = 13;
            cylindersLabel.Text = "Cylinders:";
            // 
            // fuelTypeIdLabel
            // 
            fuelTypeIdLabel.AutoSize = true;
            fuelTypeIdLabel.Location = new System.Drawing.Point(12, 98);
            fuelTypeIdLabel.Name = "fuelTypeIdLabel";
            fuelTypeIdLabel.Size = new System.Drawing.Size(58, 13);
            fuelTypeIdLabel.TabIndex = 14;
            fuelTypeIdLabel.Text = "Fuel Type:";
            // 
            // noOfTiresLabel
            // 
            noOfTiresLabel.AutoSize = true;
            noOfTiresLabel.Location = new System.Drawing.Point(12, 124);
            noOfTiresLabel.Name = "noOfTiresLabel";
            noOfTiresLabel.Size = new System.Drawing.Size(65, 13);
            noOfTiresLabel.TabIndex = 15;
            noOfTiresLabel.Text = "No Of Tires:";
            // 
            // fueltankCapacityLabel
            // 
            fueltankCapacityLabel.AutoSize = true;
            fueltankCapacityLabel.Location = new System.Drawing.Point(12, 151);
            fueltankCapacityLabel.Name = "fueltankCapacityLabel";
            fueltankCapacityLabel.Size = new System.Drawing.Size(53, 26);
            fueltankCapacityLabel.TabIndex = 16;
            fueltankCapacityLabel.Text = "Fuel tank\r\nCapacity:";
            // 
            // groupControl1
            // 
            this.groupControl1.Controls.Add(remarkLabel);
            this.groupControl1.Controls.Add(this.remarkTextBox);
            this.groupControl1.Controls.Add(vendorIdLabel);
            this.groupControl1.Controls.Add(this.vendorIdLookUpEdit);
            this.groupControl1.Controls.Add(purchaseDateLabel);
            this.groupControl1.Controls.Add(this.purchaseDateDateEdit);
            this.groupControl1.Controls.Add(libreNoLabel);
            this.groupControl1.Controls.Add(this.libreNoTextBox);
            this.groupControl1.Controls.Add(productionYearLabel);
            this.groupControl1.Controls.Add(this.productionYearTextBox);
            this.groupControl1.Controls.Add(ownershipIdLabel);
            this.groupControl1.Controls.Add(this.ownershipIdLookUpEdit);
            this.groupControl1.Controls.Add(modelIdLabel);
            this.groupControl1.Controls.Add(this.modelIdLookUpEdit);
            this.groupControl1.Controls.Add(makeIdLabel);
            this.groupControl1.Controls.Add(this.makeIdLookUpEdit);
            this.groupControl1.Controls.Add(plateNumberLabel);
            this.groupControl1.Controls.Add(this.plateNumberTextBox);
            this.groupControl1.Location = new System.Drawing.Point(5, 7);
            this.groupControl1.Name = "groupControl1";
            this.groupControl1.Size = new System.Drawing.Size(503, 195);
            this.groupControl1.TabIndex = 1;
            this.groupControl1.Text = "Basic Information";
            // 
            // remarkTextBox
            // 
            this.remarkTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.vehicleBindingSource, "Remark", true));
            this.remarkTextBox.Location = new System.Drawing.Point(70, 125);
            this.remarkTextBox.Multiline = true;
            this.remarkTextBox.Name = "remarkTextBox";
            this.remarkTextBox.Size = new System.Drawing.Size(426, 60);
            this.remarkTextBox.TabIndex = 17;
            // 
            // vehicleBindingSource
            // 
            this.vehicleBindingSource.DataSource = typeof(ClearOffice.Fleet.Business.Vehicle);
            this.vehicleBindingSource.CurrentItemChanged += new System.EventHandler(this.vehicleBindingSource_CurrentItemChanged);
            // 
            // vendorIdLookUpEdit
            // 
            this.vendorIdLookUpEdit.DataBindings.Add(new System.Windows.Forms.Binding("EditValue", this.vehicleBindingSource, "VendorId", true));
            this.vendorIdLookUpEdit.Location = new System.Drawing.Point(328, 74);
            this.vendorIdLookUpEdit.Name = "vendorIdLookUpEdit";
            this.vendorIdLookUpEdit.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.vendorIdLookUpEdit.Properties.Columns.AddRange(new DevExpress.XtraEditors.Controls.LookUpColumnInfo[] {
            new DevExpress.XtraEditors.Controls.LookUpColumnInfo("ItemName", "Vendor Name", 62, DevExpress.Utils.FormatType.None, "", true, DevExpress.Utils.HorzAlignment.Near)});
            this.vendorIdLookUpEdit.Properties.DataSource = this.vendorBindingSource;
            this.vendorIdLookUpEdit.Properties.DisplayMember = "ItemName";
            this.vendorIdLookUpEdit.Properties.NullText = "[Select Vendor]";
            this.vendorIdLookUpEdit.Properties.ValueMember = "LookupItemId";
            this.vendorIdLookUpEdit.Size = new System.Drawing.Size(168, 20);
            this.vendorIdLookUpEdit.TabIndex = 15;
            // 
            // vendorBindingSource
            // 
            this.vendorBindingSource.DataSource = typeof(ClearOffice.Fleet.Business.LookupItem);
            // 
            // purchaseDateDateEdit
            // 
            this.purchaseDateDateEdit.DataBindings.Add(new System.Windows.Forms.Binding("EditValue", this.vehicleBindingSource, "PurchaseDate", true));
            this.purchaseDateDateEdit.EditValue = null;
            this.purchaseDateDateEdit.Location = new System.Drawing.Point(328, 50);
            this.purchaseDateDateEdit.Name = "purchaseDateDateEdit";
            this.purchaseDateDateEdit.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.purchaseDateDateEdit.Properties.VistaTimeProperties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton()});
            this.purchaseDateDateEdit.Size = new System.Drawing.Size(168, 20);
            this.purchaseDateDateEdit.TabIndex = 13;
            // 
            // libreNoTextBox
            // 
            this.libreNoTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.vehicleBindingSource, "LibreNo", true));
            this.libreNoTextBox.Location = new System.Drawing.Point(328, 99);
            this.libreNoTextBox.Name = "libreNoTextBox";
            this.libreNoTextBox.Size = new System.Drawing.Size(168, 21);
            this.libreNoTextBox.TabIndex = 11;
            // 
            // productionYearTextBox
            // 
            this.productionYearTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.vehicleBindingSource, "ProductionYear", true));
            this.productionYearTextBox.Location = new System.Drawing.Point(328, 25);
            this.productionYearTextBox.Name = "productionYearTextBox";
            this.productionYearTextBox.Size = new System.Drawing.Size(168, 21);
            this.productionYearTextBox.TabIndex = 9;
            // 
            // ownershipIdLookUpEdit
            // 
            this.ownershipIdLookUpEdit.DataBindings.Add(new System.Windows.Forms.Binding("EditValue", this.vehicleBindingSource, "OwnershipId", true));
            this.ownershipIdLookUpEdit.Location = new System.Drawing.Point(70, 100);
            this.ownershipIdLookUpEdit.Name = "ownershipIdLookUpEdit";
            this.ownershipIdLookUpEdit.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.ownershipIdLookUpEdit.Properties.Columns.AddRange(new DevExpress.XtraEditors.Controls.LookUpColumnInfo[] {
            new DevExpress.XtraEditors.Controls.LookUpColumnInfo("ItemName", "Item Name", 62, DevExpress.Utils.FormatType.None, "", true, DevExpress.Utils.HorzAlignment.Near)});
            this.ownershipIdLookUpEdit.Properties.DataSource = this.ownershipBindingSource;
            this.ownershipIdLookUpEdit.Properties.DisplayMember = "ItemName";
            this.ownershipIdLookUpEdit.Properties.NullText = "[Select Ownership Type]";
            this.ownershipIdLookUpEdit.Properties.ValueMember = "LookupItemId";
            this.ownershipIdLookUpEdit.Size = new System.Drawing.Size(159, 20);
            this.ownershipIdLookUpEdit.TabIndex = 7;
            // 
            // ownershipBindingSource
            // 
            this.ownershipBindingSource.DataSource = typeof(ClearOffice.Fleet.Business.LookupItem);
            // 
            // modelIdLookUpEdit
            // 
            this.modelIdLookUpEdit.DataBindings.Add(new System.Windows.Forms.Binding("EditValue", this.vehicleBindingSource, "ModelId", true));
            this.modelIdLookUpEdit.Location = new System.Drawing.Point(70, 51);
            this.modelIdLookUpEdit.Name = "modelIdLookUpEdit";
            this.modelIdLookUpEdit.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.modelIdLookUpEdit.Properties.Columns.AddRange(new DevExpress.XtraEditors.Controls.LookUpColumnInfo[] {
            new DevExpress.XtraEditors.Controls.LookUpColumnInfo("ItemName", "Item Name", 62, DevExpress.Utils.FormatType.None, "", true, DevExpress.Utils.HorzAlignment.Near)});
            this.modelIdLookUpEdit.Properties.DataSource = this.modelBindingSource;
            this.modelIdLookUpEdit.Properties.DisplayMember = "ItemName";
            this.modelIdLookUpEdit.Properties.NullText = "[Select Model]";
            this.modelIdLookUpEdit.Properties.ValueMember = "LookupItemId";
            this.modelIdLookUpEdit.Size = new System.Drawing.Size(159, 20);
            this.modelIdLookUpEdit.TabIndex = 5;
            // 
            // modelBindingSource
            // 
            this.modelBindingSource.DataSource = typeof(ClearOffice.Fleet.Business.LookupItem);
            // 
            // makeIdLookUpEdit
            // 
            this.makeIdLookUpEdit.DataBindings.Add(new System.Windows.Forms.Binding("EditValue", this.vehicleBindingSource, "MakeId", true));
            this.makeIdLookUpEdit.Location = new System.Drawing.Point(70, 76);
            this.makeIdLookUpEdit.Name = "makeIdLookUpEdit";
            this.makeIdLookUpEdit.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.makeIdLookUpEdit.Properties.Columns.AddRange(new DevExpress.XtraEditors.Controls.LookUpColumnInfo[] {
            new DevExpress.XtraEditors.Controls.LookUpColumnInfo("ItemName", "Item Name", 62, DevExpress.Utils.FormatType.None, "", true, DevExpress.Utils.HorzAlignment.Near)});
            this.makeIdLookUpEdit.Properties.DataSource = this.makeBindingSource;
            this.makeIdLookUpEdit.Properties.DisplayMember = "ItemName";
            this.makeIdLookUpEdit.Properties.NullText = "[Select Type/Make]";
            this.makeIdLookUpEdit.Properties.ValueMember = "LookupItemId";
            this.makeIdLookUpEdit.Size = new System.Drawing.Size(159, 20);
            this.makeIdLookUpEdit.TabIndex = 3;
            // 
            // makeBindingSource
            // 
            this.makeBindingSource.DataSource = typeof(ClearOffice.Fleet.Business.LookupItem);
            // 
            // plateNumberTextBox
            // 
            this.plateNumberTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.vehicleBindingSource, "PlateNumber", true));
            this.plateNumberTextBox.Enabled = false;
            this.plateNumberTextBox.Location = new System.Drawing.Point(70, 26);
            this.plateNumberTextBox.Name = "plateNumberTextBox";
            this.plateNumberTextBox.Size = new System.Drawing.Size(159, 21);
            this.plateNumberTextBox.TabIndex = 1;
            // 
            // xtraTabControl1
            // 
            this.xtraTabControl1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.xtraTabControl1.Location = new System.Drawing.Point(5, 211);
            this.xtraTabControl1.Name = "xtraTabControl1";
            this.xtraTabControl1.SelectedTabPage = this.detailXtraTabPage;
            this.xtraTabControl1.Size = new System.Drawing.Size(933, 376);
            this.xtraTabControl1.TabIndex = 3;
            this.xtraTabControl1.TabPages.AddRange(new DevExpress.XtraTab.XtraTabPage[] {
            this.detailXtraTabPage,
            this.fuelLogXtraTabPage,
            this.expenseXtraTabPage,
            this.insuranceXtraTabPage,
            this.mainteanceXtraTabPage,
            this.tireXtraTabPage});
            // 
            // detailXtraTabPage
            // 
            this.detailXtraTabPage.AutoScroll = true;
            this.detailXtraTabPage.Controls.Add(fueltankCapacityLabel);
            this.detailXtraTabPage.Controls.Add(this.fueltankCapacityTextBox);
            this.detailXtraTabPage.Controls.Add(noOfTiresLabel);
            this.detailXtraTabPage.Controls.Add(this.noOfTiresTextBox);
            this.detailXtraTabPage.Controls.Add(fuelTypeIdLabel);
            this.detailXtraTabPage.Controls.Add(this.fuelTypeIdLookUpEdit);
            this.detailXtraTabPage.Controls.Add(cylindersLabel);
            this.detailXtraTabPage.Controls.Add(this.cylindersTextBox);
            this.detailXtraTabPage.Controls.Add(engineSerialLabel);
            this.detailXtraTabPage.Controls.Add(this.engineSerialTextBox);
            this.detailXtraTabPage.Controls.Add(chasisNoLabel);
            this.detailXtraTabPage.Controls.Add(this.chasisNoTextBox);
            this.detailXtraTabPage.Controls.Add(this.picturePictureEdit);
            this.detailXtraTabPage.Name = "detailXtraTabPage";
            this.detailXtraTabPage.Size = new System.Drawing.Size(927, 350);
            this.detailXtraTabPage.Text = "Detail Specification";
            // 
            // fueltankCapacityTextBox
            // 
            this.fueltankCapacityTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.vehicleBindingSource, "FueltankCapacity", true));
            this.fueltankCapacityTextBox.Location = new System.Drawing.Point(79, 148);
            this.fueltankCapacityTextBox.Name = "fueltankCapacityTextBox";
            this.fueltankCapacityTextBox.Size = new System.Drawing.Size(249, 21);
            this.fueltankCapacityTextBox.TabIndex = 17;
            // 
            // noOfTiresTextBox
            // 
            this.noOfTiresTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.vehicleBindingSource, "NoOfTires", true));
            this.noOfTiresTextBox.Location = new System.Drawing.Point(79, 121);
            this.noOfTiresTextBox.Name = "noOfTiresTextBox";
            this.noOfTiresTextBox.Size = new System.Drawing.Size(249, 21);
            this.noOfTiresTextBox.TabIndex = 16;
            // 
            // fuelTypeIdLookUpEdit
            // 
            this.fuelTypeIdLookUpEdit.DataBindings.Add(new System.Windows.Forms.Binding("EditValue", this.vehicleBindingSource, "FuelTypeId", true));
            this.fuelTypeIdLookUpEdit.Location = new System.Drawing.Point(79, 95);
            this.fuelTypeIdLookUpEdit.Name = "fuelTypeIdLookUpEdit";
            this.fuelTypeIdLookUpEdit.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.fuelTypeIdLookUpEdit.Properties.Columns.AddRange(new DevExpress.XtraEditors.Controls.LookUpColumnInfo[] {
            new DevExpress.XtraEditors.Controls.LookUpColumnInfo("ItemName", "Item Name", 62, DevExpress.Utils.FormatType.None, "", true, DevExpress.Utils.HorzAlignment.Near)});
            this.fuelTypeIdLookUpEdit.Properties.DataSource = this.fuelTypeBindingSource;
            this.fuelTypeIdLookUpEdit.Properties.DisplayMember = "ItemName";
            this.fuelTypeIdLookUpEdit.Properties.NullText = "[Select Fuel Type]";
            this.fuelTypeIdLookUpEdit.Properties.ValueMember = "LookupItemId";
            this.fuelTypeIdLookUpEdit.Size = new System.Drawing.Size(249, 20);
            this.fuelTypeIdLookUpEdit.TabIndex = 15;
            // 
            // fuelTypeBindingSource
            // 
            this.fuelTypeBindingSource.DataSource = typeof(ClearOffice.Fleet.Business.LookupItem);
            // 
            // cylindersTextBox
            // 
            this.cylindersTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.vehicleBindingSource, "Cylinders", true));
            this.cylindersTextBox.Location = new System.Drawing.Point(79, 68);
            this.cylindersTextBox.Name = "cylindersTextBox";
            this.cylindersTextBox.Size = new System.Drawing.Size(249, 21);
            this.cylindersTextBox.TabIndex = 14;
            // 
            // engineSerialTextBox
            // 
            this.engineSerialTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.vehicleBindingSource, "EngineSerial", true));
            this.engineSerialTextBox.Location = new System.Drawing.Point(79, 41);
            this.engineSerialTextBox.Name = "engineSerialTextBox";
            this.engineSerialTextBox.Size = new System.Drawing.Size(249, 21);
            this.engineSerialTextBox.TabIndex = 13;
            // 
            // chasisNoTextBox
            // 
            this.chasisNoTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.vehicleBindingSource, "ChasisNo", true));
            this.chasisNoTextBox.Location = new System.Drawing.Point(79, 14);
            this.chasisNoTextBox.Name = "chasisNoTextBox";
            this.chasisNoTextBox.Size = new System.Drawing.Size(249, 21);
            this.chasisNoTextBox.TabIndex = 12;
            // 
            // picturePictureEdit
            // 
            this.picturePictureEdit.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.picturePictureEdit.DataBindings.Add(new System.Windows.Forms.Binding("EditValue", this.vehicleBindingSource, "Picture", true));
            this.picturePictureEdit.Location = new System.Drawing.Point(344, 3);
            this.picturePictureEdit.Name = "picturePictureEdit";
            this.picturePictureEdit.Size = new System.Drawing.Size(580, 344);
            this.picturePictureEdit.TabIndex = 11;
            // 
            // fuelLogXtraTabPage
            // 
            this.fuelLogXtraTabPage.Controls.Add(this.chartControl1);
            this.fuelLogXtraTabPage.Controls.Add(this.gridControl1);
            this.fuelLogXtraTabPage.Name = "fuelLogXtraTabPage";
            this.fuelLogXtraTabPage.Size = new System.Drawing.Size(927, 350);
            this.fuelLogXtraTabPage.Text = "Fuel Log";
            // 
            // chartControl1
            // 
            this.chartControl1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            xyDiagram1.AxisX.Range.ScrollingRange.SideMarginsEnabled = true;
            xyDiagram1.AxisX.Range.SideMarginsEnabled = true;
            xyDiagram1.AxisX.VisibleInPanesSerializable = "-1";
            xyDiagram1.AxisY.Range.ScrollingRange.SideMarginsEnabled = true;
            xyDiagram1.AxisY.Range.SideMarginsEnabled = true;
            xyDiagram1.AxisY.VisibleInPanesSerializable = "-1";
            this.chartControl1.Diagram = xyDiagram1;
            this.chartControl1.Location = new System.Drawing.Point(410, 3);
            this.chartControl1.Name = "chartControl1";
            pointSeriesLabel1.LineVisible = true;
            series1.Label = pointSeriesLabel1;
            series1.Name = "Series 1";
            series1.View = lineSeriesView1;
            this.chartControl1.SeriesSerializable = new DevExpress.XtraCharts.Series[] {
        series1};
            sideBySideBarSeriesLabel1.LineVisible = true;
            this.chartControl1.SeriesTemplate.Label = sideBySideBarSeriesLabel1;
            this.chartControl1.Size = new System.Drawing.Size(576, 338);
            this.chartControl1.TabIndex = 1;
            // 
            // gridControl1
            // 
            this.gridControl1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.gridControl1.DataSource = this.fuelLogBindingSource;
            this.gridControl1.Location = new System.Drawing.Point(3, 3);
            this.gridControl1.MainView = this.gridView1;
            this.gridControl1.Name = "gridControl1";
            this.gridControl1.Size = new System.Drawing.Size(400, 339);
            this.gridControl1.TabIndex = 0;
            this.gridControl1.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridView1});
            this.gridControl1.DoubleClick += new System.EventHandler(this.gridControl1_DoubleClick);
            // 
            // fuelLogBindingSource
            // 
            this.fuelLogBindingSource.DataSource = typeof(ClearOffice.Fleet.Business.FuelLog);
            this.fuelLogBindingSource.CurrentItemChanged += new System.EventHandler(this.fuelLogBindingSource_CurrentItemChanged);
            // 
            // gridView1
            // 
            this.gridView1.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.colFilledDate,
            this.colDistanceCovered,
            this.colFuelAmount,
            this.colTotalCost});
            this.gridView1.GridControl = this.gridControl1;
            this.gridView1.Name = "gridView1";
            this.gridView1.OptionsBehavior.Editable = false;
            this.gridView1.OptionsView.ShowGroupPanel = false;
            // 
            // colFilledDate
            // 
            this.colFilledDate.FieldName = "FilledDate";
            this.colFilledDate.Name = "colFilledDate";
            this.colFilledDate.Visible = true;
            this.colFilledDate.VisibleIndex = 0;
            // 
            // colDistanceCovered
            // 
            this.colDistanceCovered.Caption = "Distance";
            this.colDistanceCovered.FieldName = "DistanceCovered";
            this.colDistanceCovered.Name = "colDistanceCovered";
            this.colDistanceCovered.Visible = true;
            this.colDistanceCovered.VisibleIndex = 1;
            // 
            // colFuelAmount
            // 
            this.colFuelAmount.FieldName = "FuelAmount";
            this.colFuelAmount.Name = "colFuelAmount";
            this.colFuelAmount.Visible = true;
            this.colFuelAmount.VisibleIndex = 2;
            // 
            // colTotalCost
            // 
            this.colTotalCost.Caption = "Fuel Cost";
            this.colTotalCost.DisplayFormat.FormatString = "{0:#,##0.00;(#,##0.00);\'\'}";
            this.colTotalCost.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Custom;
            this.colTotalCost.FieldName = "TotalCost";
            this.colTotalCost.Name = "colTotalCost";
            this.colTotalCost.Visible = true;
            this.colTotalCost.VisibleIndex = 3;
            // 
            // expenseXtraTabPage
            // 
            this.expenseXtraTabPage.Controls.Add(this.gridControl2);
            this.expenseXtraTabPage.Name = "expenseXtraTabPage";
            this.expenseXtraTabPage.Size = new System.Drawing.Size(927, 350);
            this.expenseXtraTabPage.Text = "Expense";
            // 
            // gridControl2
            // 
            this.gridControl2.DataSource = this.expenseBindingSource;
            this.gridControl2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gridControl2.Location = new System.Drawing.Point(0, 0);
            this.gridControl2.MainView = this.gridView2;
            this.gridControl2.Name = "gridControl2";
            this.gridControl2.Size = new System.Drawing.Size(927, 350);
            this.gridControl2.TabIndex = 0;
            this.gridControl2.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridView2});
            this.gridControl2.DoubleClick += new System.EventHandler(this.gridControl2_DoubleClick);
            // 
            // expenseBindingSource
            // 
            this.expenseBindingSource.DataSource = typeof(ClearOffice.Fleet.Business.Expense);
            this.expenseBindingSource.CurrentItemChanged += new System.EventHandler(this.expenseBindingSource_CurrentItemChanged);
            // 
            // gridView2
            // 
            this.gridView2.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.colInvoice,
            this.colPaymentDate,
            this.colAmount,
            this.colDescription});
            this.gridView2.GridControl = this.gridControl2;
            this.gridView2.Name = "gridView2";
            this.gridView2.OptionsBehavior.Editable = false;
            this.gridView2.OptionsView.ShowGroupPanel = false;
            // 
            // colInvoice
            // 
            this.colInvoice.Caption = "Invoice #";
            this.colInvoice.FieldName = "Invoice";
            this.colInvoice.Name = "colInvoice";
            this.colInvoice.Visible = true;
            this.colInvoice.VisibleIndex = 1;
            // 
            // colPaymentDate
            // 
            this.colPaymentDate.FieldName = "PaymentDate";
            this.colPaymentDate.Name = "colPaymentDate";
            this.colPaymentDate.Visible = true;
            this.colPaymentDate.VisibleIndex = 2;
            // 
            // colAmount
            // 
            this.colAmount.DisplayFormat.FormatString = "{0:#,##0.00;(#,##0.00);\'\'}";
            this.colAmount.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Custom;
            this.colAmount.FieldName = "Amount";
            this.colAmount.Name = "colAmount";
            this.colAmount.Visible = true;
            this.colAmount.VisibleIndex = 3;
            // 
            // colDescription
            // 
            this.colDescription.FieldName = "Description";
            this.colDescription.Name = "colDescription";
            this.colDescription.Visible = true;
            this.colDescription.VisibleIndex = 0;
            // 
            // insuranceXtraTabPage
            // 
            this.insuranceXtraTabPage.Controls.Add(this.gridControl3);
            this.insuranceXtraTabPage.Name = "insuranceXtraTabPage";
            this.insuranceXtraTabPage.Size = new System.Drawing.Size(927, 350);
            this.insuranceXtraTabPage.Text = "Insurance";
            // 
            // gridControl3
            // 
            this.gridControl3.DataSource = this.insuranceHistoryBindingSource;
            this.gridControl3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gridControl3.Location = new System.Drawing.Point(0, 0);
            this.gridControl3.MainView = this.gridView3;
            this.gridControl3.Name = "gridControl3";
            this.gridControl3.Size = new System.Drawing.Size(927, 350);
            this.gridControl3.TabIndex = 0;
            this.gridControl3.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridView3});
            this.gridControl3.DoubleClick += new System.EventHandler(this.gridControl3_DoubleClick);
            // 
            // insuranceHistoryBindingSource
            // 
            this.insuranceHistoryBindingSource.DataSource = typeof(ClearOffice.Fleet.Business.InsurancePolicy);
            this.insuranceHistoryBindingSource.CurrentItemChanged += new System.EventHandler(this.insuranceHistoryBindingSource_CurrentItemChanged);
            // 
            // gridView3
            // 
            this.gridView3.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.colPolicyNo,
            this.colPolicyType,
            this.colCompanyId,
            this.colDateInsured,
            this.colRemainingDays,
            this.colExpiresOn,
            this.colAgentName,
            this.colAgentTelephone});
            this.gridView3.GridControl = this.gridControl3;
            this.gridView3.Name = "gridView3";
            this.gridView3.OptionsBehavior.Editable = false;
            this.gridView3.OptionsView.ShowGroupPanel = false;
            // 
            // colPolicyNo
            // 
            this.colPolicyNo.FieldName = "PolicyNo";
            this.colPolicyNo.Name = "colPolicyNo";
            this.colPolicyNo.Visible = true;
            this.colPolicyNo.VisibleIndex = 0;
            // 
            // colPolicyType
            // 
            this.colPolicyType.FieldName = "PolicyType";
            this.colPolicyType.Name = "colPolicyType";
            this.colPolicyType.Visible = true;
            this.colPolicyType.VisibleIndex = 1;
            // 
            // colCompanyId
            // 
            this.colCompanyId.FieldName = "CompanyId";
            this.colCompanyId.Name = "colCompanyId";
            this.colCompanyId.Visible = true;
            this.colCompanyId.VisibleIndex = 2;
            // 
            // colDateInsured
            // 
            this.colDateInsured.FieldName = "DateInsured";
            this.colDateInsured.Name = "colDateInsured";
            this.colDateInsured.Visible = true;
            this.colDateInsured.VisibleIndex = 3;
            // 
            // colRemainingDays
            // 
            this.colRemainingDays.Caption = "Remaining Days";
            this.colRemainingDays.Name = "colRemainingDays";
            this.colRemainingDays.Visible = true;
            this.colRemainingDays.VisibleIndex = 6;
            // 
            // colExpiresOn
            // 
            this.colExpiresOn.Caption = "Expires On";
            this.colExpiresOn.Name = "colExpiresOn";
            this.colExpiresOn.Visible = true;
            this.colExpiresOn.VisibleIndex = 7;
            // 
            // colAgentName
            // 
            this.colAgentName.FieldName = "AgentName";
            this.colAgentName.Name = "colAgentName";
            this.colAgentName.Visible = true;
            this.colAgentName.VisibleIndex = 4;
            // 
            // colAgentTelephone
            // 
            this.colAgentTelephone.FieldName = "AgentTelephone";
            this.colAgentTelephone.Name = "colAgentTelephone";
            this.colAgentTelephone.Visible = true;
            this.colAgentTelephone.VisibleIndex = 5;
            // 
            // mainteanceXtraTabPage
            // 
            this.mainteanceXtraTabPage.Controls.Add(this.gridControl4);
            this.mainteanceXtraTabPage.Name = "mainteanceXtraTabPage";
            this.mainteanceXtraTabPage.Size = new System.Drawing.Size(927, 350);
            this.mainteanceXtraTabPage.Text = "Maintenance";
            // 
            // gridControl4
            // 
            this.gridControl4.DataSource = this.maintenanceBindingSource;
            this.gridControl4.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gridControl4.Location = new System.Drawing.Point(0, 0);
            this.gridControl4.MainView = this.gridView4;
            this.gridControl4.Name = "gridControl4";
            this.gridControl4.Size = new System.Drawing.Size(927, 350);
            this.gridControl4.TabIndex = 0;
            this.gridControl4.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridView4});
            // 
            // maintenanceBindingSource
            // 
            this.maintenanceBindingSource.DataSource = typeof(ClearOffice.Fleet.Business.Maintanance);
            // 
            // gridView4
            // 
            this.gridView4.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.colCompletionDate,
            this.colServiceRequestNo,
            this.colServicedBy,
            this.colAccountNo,
            this.colServiceTypeId});
            this.gridView4.GridControl = this.gridControl4;
            this.gridView4.Name = "gridView4";
            this.gridView4.OptionsBehavior.Editable = false;
            this.gridView4.OptionsView.ShowGroupPanel = false;
            // 
            // colCompletionDate
            // 
            this.colCompletionDate.FieldName = "CompletionDate";
            this.colCompletionDate.Name = "colCompletionDate";
            this.colCompletionDate.Visible = true;
            this.colCompletionDate.VisibleIndex = 1;
            // 
            // colServiceRequestNo
            // 
            this.colServiceRequestNo.FieldName = "ServiceRequestNo";
            this.colServiceRequestNo.Name = "colServiceRequestNo";
            this.colServiceRequestNo.Visible = true;
            this.colServiceRequestNo.VisibleIndex = 0;
            // 
            // colServicedBy
            // 
            this.colServicedBy.FieldName = "ServicedBy";
            this.colServicedBy.Name = "colServicedBy";
            this.colServicedBy.Visible = true;
            this.colServicedBy.VisibleIndex = 2;
            // 
            // colAccountNo
            // 
            this.colAccountNo.FieldName = "AccountNo";
            this.colAccountNo.Name = "colAccountNo";
            this.colAccountNo.Visible = true;
            this.colAccountNo.VisibleIndex = 4;
            // 
            // colServiceTypeId
            // 
            this.colServiceTypeId.FieldName = "ServiceTypeId";
            this.colServiceTypeId.Name = "colServiceTypeId";
            this.colServiceTypeId.Visible = true;
            this.colServiceTypeId.VisibleIndex = 3;
            // 
            // tireXtraTabPage
            // 
            this.tireXtraTabPage.Controls.Add(this.gridControl5);
            this.tireXtraTabPage.Name = "tireXtraTabPage";
            this.tireXtraTabPage.Size = new System.Drawing.Size(927, 350);
            this.tireXtraTabPage.Text = "Tire Usage";
            // 
            // gridControl5
            // 
            this.gridControl5.DataSource = this.tireBindingSource;
            this.gridControl5.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gridControl5.Location = new System.Drawing.Point(0, 0);
            this.gridControl5.MainView = this.gridView5;
            this.gridControl5.Name = "gridControl5";
            this.gridControl5.Size = new System.Drawing.Size(927, 350);
            this.gridControl5.TabIndex = 0;
            this.gridControl5.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridView5});
            // 
            // tireBindingSource
            // 
            this.tireBindingSource.DataSource = typeof(ClearOffice.Fleet.Business.VehicleTire);
            // 
            // gridView5
            // 
            this.gridView5.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.colTireId,
            this.colPosition,
            this.colMountedDate,
            this.colMountedMilage,
            this.colUnmountedDate,
            this.colUnmountMilage});
            this.gridView5.GridControl = this.gridControl5;
            this.gridView5.Name = "gridView5";
            this.gridView5.OptionsBehavior.Editable = false;
            this.gridView5.OptionsView.ShowGroupPanel = false;
            // 
            // colTireId
            // 
            this.colTireId.Caption = "Tire Serial";
            this.colTireId.FieldName = "TireId";
            this.colTireId.Name = "colTireId";
            this.colTireId.Visible = true;
            this.colTireId.VisibleIndex = 0;
            // 
            // colPosition
            // 
            this.colPosition.FieldName = "Position";
            this.colPosition.Name = "colPosition";
            this.colPosition.Visible = true;
            this.colPosition.VisibleIndex = 1;
            // 
            // colMountedDate
            // 
            this.colMountedDate.FieldName = "MountedDate";
            this.colMountedDate.Name = "colMountedDate";
            this.colMountedDate.Visible = true;
            this.colMountedDate.VisibleIndex = 2;
            // 
            // colMountedMilage
            // 
            this.colMountedMilage.FieldName = "MountedMilage";
            this.colMountedMilage.Name = "colMountedMilage";
            this.colMountedMilage.Visible = true;
            this.colMountedMilage.VisibleIndex = 3;
            // 
            // colUnmountedDate
            // 
            this.colUnmountedDate.FieldName = "UnmountedDate";
            this.colUnmountedDate.Name = "colUnmountedDate";
            this.colUnmountedDate.Visible = true;
            this.colUnmountedDate.VisibleIndex = 4;
            // 
            // colUnmountMilage
            // 
            this.colUnmountMilage.FieldName = "UnmountMilage";
            this.colUnmountMilage.Name = "colUnmountMilage";
            this.colUnmountMilage.Visible = true;
            this.colUnmountMilage.VisibleIndex = 5;
            // 
            // groupControl2
            // 
            this.groupControl2.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.groupControl2.Controls.Add(this.summaryLabel);
            this.groupControl2.Location = new System.Drawing.Point(512, 9);
            this.groupControl2.Name = "groupControl2";
            this.groupControl2.Size = new System.Drawing.Size(421, 196);
            this.groupControl2.TabIndex = 6;
            this.groupControl2.Text = "Summary";
            // 
            // summaryLabel
            // 
            this.summaryLabel.AllowHtmlString = true;
            this.summaryLabel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.summaryLabel.Location = new System.Drawing.Point(2, 22);
            this.summaryLabel.Name = "summaryLabel";
            this.summaryLabel.Size = new System.Drawing.Size(149, 84);
            this.summaryLabel.TabIndex = 0;
            this.summaryLabel.Text = "<b>Status</b>: {0} \r\n<b>Insured</b>: {1}\r\n<b>Policy Expires on</b>: {2}\r\n<b>Polic" +
    "y Remaining Days:</b> {3}\r\n<b>Average Milage</b>: {4}\r\n<b>Total Cost of Vehicle<" +
    "/b> {5}";
            // 
            // ribbonControl1
            // 
            this.ribbonControl1.ApplicationButtonText = null;
            // 
            // 
            // 
            this.ribbonControl1.ExpandCollapseItem.Id = 0;
            this.ribbonControl1.ExpandCollapseItem.Name = "";
            this.ribbonControl1.Images = this.smallImageCollection;
            this.ribbonControl1.Items.AddRange(new DevExpress.XtraBars.BarItem[] {
            this.ribbonControl1.ExpandCollapseItem,
            this.saveBarButtonItem,
            this.deleteBarButtonItem,
            this.addFuelLogBarButtonItem,
            this.addExpenseBarButtonItem,
            this.insuranceBarButtonItem});
            this.ribbonControl1.LargeImages = this.largeImageCollection;
            this.ribbonControl1.Location = new System.Drawing.Point(0, 0);
            this.ribbonControl1.MaxItemId = 6;
            this.ribbonControl1.Name = "ribbonControl1";
            this.ribbonControl1.Pages.AddRange(new DevExpress.XtraBars.Ribbon.RibbonPage[] {
            this.ribbonPage1});
            this.ribbonControl1.SelectedPage = this.ribbonPage1;
            this.ribbonControl1.Size = new System.Drawing.Size(943, 143);
            // 
            // smallImageCollection
            // 
            this.smallImageCollection.ImageStream = ((DevExpress.Utils.ImageCollectionStreamer)(resources.GetObject("smallImageCollection.ImageStream")));
            this.smallImageCollection.Images.SetKeyName(0, "Customers");
            this.smallImageCollection.Images.SetKeyName(1, "Print");
            this.smallImageCollection.Images.SetKeyName(2, "Contracts");
            this.smallImageCollection.Images.SetKeyName(3, "CustomerBilling");
            this.smallImageCollection.Images.SetKeyName(4, "CustomersByDate");
            this.smallImageCollection.Images.SetKeyName(5, "CustomersKPI");
            this.smallImageCollection.Images.SetKeyName(6, "PmServices");
            this.smallImageCollection.Images.SetKeyName(7, "Calculator");
            this.smallImageCollection.Images.SetKeyName(8, "Drafts");
            this.smallImageCollection.Images.SetKeyName(9, "NewVehicleIcon");
            this.smallImageCollection.Images.SetKeyName(10, "Alerts");
            this.smallImageCollection.Images.SetKeyName(11, "TireInventory");
            this.smallImageCollection.Images.SetKeyName(12, "AddFolder_16x16.png");
            this.smallImageCollection.Images.SetKeyName(13, "Revenue_16x16.png");
            this.smallImageCollection.Images.SetKeyName(14, "time_add.png");
            this.smallImageCollection.Images.SetKeyName(15, "Assign Asset");
            this.smallImageCollection.Images.SetKeyName(16, "custodians");
            this.smallImageCollection.Images.SetKeyName(17, "Edit_16x16.png");
            this.smallImageCollection.Images.SetKeyName(18, "app_setting.jpg");
            this.smallImageCollection.Images.SetKeyName(19, "Categories_16x16.png");
            this.smallImageCollection.Images.SetKeyName(20, "calendar_add.png");
            this.smallImageCollection.Images.SetKeyName(21, "coins_add.png");
            this.smallImageCollection.Images.SetKeyName(22, "shield_add.png");
            this.smallImageCollection.Images.SetKeyName(23, "cog_add.png");
            // 
            // saveBarButtonItem
            // 
            this.saveBarButtonItem.Caption = "Save";
            this.saveBarButtonItem.Id = 1;
            this.saveBarButtonItem.LargeImageIndex = 19;
            this.saveBarButtonItem.Name = "saveBarButtonItem";
            this.saveBarButtonItem.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.saveBarButtonItem_ItemClick);
            // 
            // deleteBarButtonItem
            // 
            this.deleteBarButtonItem.Caption = "Delete";
            this.deleteBarButtonItem.Id = 2;
            this.deleteBarButtonItem.LargeImageIndex = 20;
            this.deleteBarButtonItem.Name = "deleteBarButtonItem";
            this.deleteBarButtonItem.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.deleteBarButtonItem_ItemClick);
            // 
            // addFuelLogBarButtonItem
            // 
            this.addFuelLogBarButtonItem.Caption = "Fuellog";
            this.addFuelLogBarButtonItem.Id = 3;
            this.addFuelLogBarButtonItem.ImageIndex = 20;
            this.addFuelLogBarButtonItem.Name = "addFuelLogBarButtonItem";
            this.addFuelLogBarButtonItem.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.addFuelLogBarButtonItem_ItemClick);
            // 
            // addExpenseBarButtonItem
            // 
            this.addExpenseBarButtonItem.Caption = "Expense";
            this.addExpenseBarButtonItem.Id = 4;
            this.addExpenseBarButtonItem.ImageIndex = 21;
            this.addExpenseBarButtonItem.Name = "addExpenseBarButtonItem";
            this.addExpenseBarButtonItem.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.addExpenseBarButtonItem_ItemClick);
            // 
            // insuranceBarButtonItem
            // 
            this.insuranceBarButtonItem.Caption = "Insurance";
            this.insuranceBarButtonItem.Id = 5;
            this.insuranceBarButtonItem.ImageIndex = 22;
            this.insuranceBarButtonItem.Name = "insuranceBarButtonItem";
            this.insuranceBarButtonItem.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.insuranceBarButtonItem_ItemClick);
            // 
            // largeImageCollection
            // 
            this.largeImageCollection.ImageSize = new System.Drawing.Size(32, 32);
            this.largeImageCollection.ImageStream = ((DevExpress.Utils.ImageCollectionStreamer)(resources.GetObject("largeImageCollection.ImageStream")));
            this.largeImageCollection.Images.SetKeyName(0, "NewCustomer");
            this.largeImageCollection.Images.SetKeyName(1, "NewContract");
            this.largeImageCollection.Images.SetKeyName(2, "NewAlbum");
            this.largeImageCollection.Images.SetKeyName(3, "Calendar");
            this.largeImageCollection.Images.SetKeyName(4, "CustomerBilling");
            this.largeImageCollection.Images.SetKeyName(5, "CustomerCalendar");
            this.largeImageCollection.Images.SetKeyName(6, "CustomersKPI");
            this.largeImageCollection.Images.SetKeyName(7, "Home");
            this.largeImageCollection.Images.SetKeyName(8, "ActiveRecords");
            this.largeImageCollection.Images.SetKeyName(9, "Categories");
            this.largeImageCollection.Images.SetKeyName(10, "Settings");
            this.largeImageCollection.Images.SetKeyName(11, "Scheduler_32x32.png");
            this.largeImageCollection.Images.SetKeyName(12, "Action_Report_ShowDesigner_32x32.png");
            this.largeImageCollection.Images.SetKeyName(13, "Coupon");
            this.largeImageCollection.Images.SetKeyName(14, "ConsumeCoupon");
            this.largeImageCollection.Images.SetKeyName(15, "CalculateDepreciation");
            this.largeImageCollection.Images.SetKeyName(16, "appointment-new.png");
            this.largeImageCollection.Images.SetKeyName(17, "address-book-new.png");
            this.largeImageCollection.Images.SetKeyName(18, "Navigation_32x32.png");
            this.largeImageCollection.Images.SetKeyName(19, "save-32x32.png");
            this.largeImageCollection.Images.SetKeyName(20, "Delete_32x32.png");
            // 
            // ribbonPage1
            // 
            this.ribbonPage1.Groups.AddRange(new DevExpress.XtraBars.Ribbon.RibbonPageGroup[] {
            this.ribbonPageGroup1});
            this.ribbonPage1.Name = "ribbonPage1";
            this.ribbonPage1.Text = "Fleet";
            // 
            // ribbonPageGroup1
            // 
            this.ribbonPageGroup1.ItemLinks.Add(this.saveBarButtonItem);
            this.ribbonPageGroup1.ItemLinks.Add(this.deleteBarButtonItem);
            this.ribbonPageGroup1.ItemLinks.Add(this.addFuelLogBarButtonItem);
            this.ribbonPageGroup1.ItemLinks.Add(this.addExpenseBarButtonItem);
            this.ribbonPageGroup1.ItemLinks.Add(this.insuranceBarButtonItem);
            this.ribbonPageGroup1.Name = "ribbonPageGroup1";
            this.ribbonPageGroup1.Text = "Tasks";
            // 
            // panelControl2
            // 
            this.panelControl2.Controls.Add(this.groupControl2);
            this.panelControl2.Controls.Add(this.groupControl1);
            this.panelControl2.Controls.Add(this.xtraTabControl1);
            this.panelControl2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelControl2.Location = new System.Drawing.Point(0, 143);
            this.panelControl2.Name = "panelControl2";
            this.panelControl2.Size = new System.Drawing.Size(943, 587);
            this.panelControl2.TabIndex = 9;
            // 
            // VehicleDetail
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(943, 730);
            this.Controls.Add(this.panelControl2);
            this.Controls.Add(this.ribbonControl1);
            this.Name = "VehicleDetail";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Vehicle Detail";
            this.Activated += new System.EventHandler(this.VehicleDetail_Activated);
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.VehicleDetail_FormClosing);
            ((System.ComponentModel.ISupportInitialize)(this.groupControl1)).EndInit();
            this.groupControl1.ResumeLayout(false);
            this.groupControl1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.vehicleBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.vendorIdLookUpEdit.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.vendorBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.purchaseDateDateEdit.Properties.VistaTimeProperties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.purchaseDateDateEdit.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ownershipIdLookUpEdit.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ownershipBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.modelIdLookUpEdit.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.modelBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.makeIdLookUpEdit.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.makeBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.xtraTabControl1)).EndInit();
            this.xtraTabControl1.ResumeLayout(false);
            this.detailXtraTabPage.ResumeLayout(false);
            this.detailXtraTabPage.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.fuelTypeIdLookUpEdit.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.fuelTypeBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picturePictureEdit.Properties)).EndInit();
            this.fuelLogXtraTabPage.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(xyDiagram1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(pointSeriesLabel1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(lineSeriesView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(series1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(sideBySideBarSeriesLabel1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.chartControl1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridControl1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.fuelLogBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).EndInit();
            this.expenseXtraTabPage.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.gridControl2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.expenseBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView2)).EndInit();
            this.insuranceXtraTabPage.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.gridControl3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.insuranceHistoryBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView3)).EndInit();
            this.mainteanceXtraTabPage.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.gridControl4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.maintenanceBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView4)).EndInit();
            this.tireXtraTabPage.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.gridControl5)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tireBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView5)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.groupControl2)).EndInit();
            this.groupControl2.ResumeLayout(false);
            this.groupControl2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ribbonControl1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.smallImageCollection)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.largeImageCollection)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.panelControl2)).EndInit();
            this.panelControl2.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraEditors.GroupControl groupControl1;
        private DevExpress.XtraTab.XtraTabControl xtraTabControl1;
        private DevExpress.XtraTab.XtraTabPage fuelLogXtraTabPage;
        private DevExpress.XtraTab.XtraTabPage expenseXtraTabPage;
        private DevExpress.XtraTab.XtraTabPage insuranceXtraTabPage;
        private DevExpress.XtraTab.XtraTabPage mainteanceXtraTabPage;
        private DevExpress.XtraEditors.LookUpEdit modelIdLookUpEdit;
        private System.Windows.Forms.BindingSource vehicleBindingSource;
        private DevExpress.XtraEditors.LookUpEdit makeIdLookUpEdit;
        private System.Windows.Forms.TextBox plateNumberTextBox;
        private DevExpress.XtraTab.XtraTabPage detailXtraTabPage;
        private DevExpress.XtraTab.XtraTabPage tireXtraTabPage;
        private System.Windows.Forms.TextBox remarkTextBox;
        private DevExpress.XtraEditors.LookUpEdit vendorIdLookUpEdit;
        private DevExpress.XtraEditors.DateEdit purchaseDateDateEdit;
        private System.Windows.Forms.TextBox libreNoTextBox;
        private System.Windows.Forms.TextBox productionYearTextBox;
        private DevExpress.XtraEditors.LookUpEdit ownershipIdLookUpEdit;
        private DevExpress.XtraEditors.PictureEdit picturePictureEdit;
        private System.Windows.Forms.TextBox fueltankCapacityTextBox;
        private System.Windows.Forms.TextBox noOfTiresTextBox;
        private DevExpress.XtraEditors.LookUpEdit fuelTypeIdLookUpEdit;
        private System.Windows.Forms.TextBox cylindersTextBox;
        private System.Windows.Forms.TextBox engineSerialTextBox;
        private System.Windows.Forms.TextBox chasisNoTextBox;
        private DevExpress.XtraGrid.GridControl gridControl1;
        private DevExpress.XtraGrid.Views.Grid.GridView gridView1;
        private DevExpress.XtraGrid.GridControl gridControl2;
        private DevExpress.XtraGrid.Views.Grid.GridView gridView2;
        private DevExpress.XtraGrid.GridControl gridControl3;
        private DevExpress.XtraGrid.Views.Grid.GridView gridView3;
        private DevExpress.XtraGrid.GridControl gridControl4;
        private DevExpress.XtraGrid.Views.Grid.GridView gridView4;
        private DevExpress.XtraCharts.ChartControl chartControl1;
        private System.Windows.Forms.BindingSource makeBindingSource;
        private System.Windows.Forms.BindingSource modelBindingSource;
        private System.Windows.Forms.BindingSource ownershipBindingSource;
        private System.Windows.Forms.BindingSource vendorBindingSource;
        private System.Windows.Forms.BindingSource fuelTypeBindingSource;
        private System.Windows.Forms.BindingSource fuelLogBindingSource;
        private DevExpress.XtraGrid.Columns.GridColumn colFilledDate;
        private DevExpress.XtraGrid.Columns.GridColumn colDistanceCovered;
        private DevExpress.XtraGrid.Columns.GridColumn colFuelAmount;
        private System.Windows.Forms.BindingSource expenseBindingSource;
        private DevExpress.XtraGrid.Columns.GridColumn colInvoice;
        private DevExpress.XtraGrid.Columns.GridColumn colPaymentDate;
        private DevExpress.XtraGrid.Columns.GridColumn colAmount;
        private DevExpress.XtraGrid.Columns.GridColumn colDescription;
        private System.Windows.Forms.BindingSource insuranceHistoryBindingSource;
        private DevExpress.XtraGrid.Columns.GridColumn colPolicyNo;
        private DevExpress.XtraGrid.Columns.GridColumn colPolicyType;
        private DevExpress.XtraGrid.Columns.GridColumn colCompanyId;
        private DevExpress.XtraGrid.Columns.GridColumn colDateInsured;
        private DevExpress.XtraGrid.Columns.GridColumn colAgentName;
        private DevExpress.XtraGrid.Columns.GridColumn colAgentTelephone;
        private System.Windows.Forms.BindingSource maintenanceBindingSource;
        private DevExpress.XtraGrid.Columns.GridColumn colCompletionDate;
        private DevExpress.XtraGrid.Columns.GridColumn colServiceRequestNo;
        private DevExpress.XtraGrid.Columns.GridColumn colServicedBy;
        private DevExpress.XtraGrid.Columns.GridColumn colAccountNo;
        private DevExpress.XtraGrid.Columns.GridColumn colServiceTypeId;
        private System.Windows.Forms.BindingSource tireBindingSource;
        private DevExpress.XtraGrid.GridControl gridControl5;
        private DevExpress.XtraGrid.Views.Grid.GridView gridView5;
        private DevExpress.XtraGrid.Columns.GridColumn colTireId;
        private DevExpress.XtraGrid.Columns.GridColumn colPosition;
        private DevExpress.XtraGrid.Columns.GridColumn colMountedDate;
        private DevExpress.XtraGrid.Columns.GridColumn colMountedMilage;
        private DevExpress.XtraGrid.Columns.GridColumn colUnmountedDate;
        private DevExpress.XtraGrid.Columns.GridColumn colUnmountMilage;
        private DevExpress.XtraGrid.Columns.GridColumn colTotalCost;
        private DevExpress.XtraGrid.Columns.GridColumn colRemainingDays;
        private DevExpress.XtraGrid.Columns.GridColumn colExpiresOn;
        private DevExpress.XtraEditors.GroupControl groupControl2;
        private DevExpress.XtraEditors.LabelControl summaryLabel;
        private DevExpress.XtraBars.Ribbon.RibbonControl ribbonControl1;
        private DevExpress.XtraBars.Ribbon.RibbonPage ribbonPage1;
        private DevExpress.XtraBars.Ribbon.RibbonPageGroup ribbonPageGroup1;
        private DevExpress.XtraEditors.PanelControl panelControl2;
        private DevExpress.XtraBars.BarButtonItem saveBarButtonItem;
        private DevExpress.XtraBars.BarButtonItem deleteBarButtonItem;
        private DevExpress.Utils.ImageCollection smallImageCollection;
        private DevExpress.Utils.ImageCollection largeImageCollection;
        private DevExpress.XtraBars.BarButtonItem addFuelLogBarButtonItem;
        private DevExpress.XtraBars.BarButtonItem addExpenseBarButtonItem;
        private DevExpress.XtraBars.BarButtonItem insuranceBarButtonItem;
    }
}