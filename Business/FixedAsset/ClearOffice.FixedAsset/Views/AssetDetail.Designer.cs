namespace ClearOffice.FixedAsset.Views
{
    partial class AssetDetail
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
            System.Windows.Forms.Label physicalConditionLabel;
            System.Windows.Forms.Label assetValueLabel;
            System.Windows.Forms.Label usefulLifeLabel;
            System.Windows.Forms.Label vendorLabel;
            System.Windows.Forms.Label purchaseDateLabel;
            System.Windows.Forms.Label documentNumberLabel;
            System.Windows.Forms.Label depreciationMethodLabel;
            System.Windows.Forms.Label salvageValueLabel;
            System.Windows.Forms.Label assetNumberLabel;
            System.Windows.Forms.Label costCenterIdLabel;
            System.Windows.Forms.Label locationIdLabel;
            System.Windows.Forms.Label statusLabel;
            System.Windows.Forms.Label categoryLabel;
            System.Windows.Forms.Label descriptionLabel;
            System.Windows.Forms.Label groupIdLabel;
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AssetDetail));
            this.assetDetailBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.xtraTabControl1 = new DevExpress.XtraTab.XtraTabControl();
            this.xtraTabPage1 = new DevExpress.XtraTab.XtraTabPage();
            this.imagePictureEdit = new DevExpress.XtraEditors.PictureEdit();
            this.xtraTabPage2 = new DevExpress.XtraTab.XtraTabPage();
            this.gridControl1 = new DevExpress.XtraGrid.GridControl();
            this.custodianAssetBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.gridView1 = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.colDateFrom = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colDateTo = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colBadgeNo = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colFirstName = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colLastName = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colItemName = new DevExpress.XtraGrid.Columns.GridColumn();
            this.repositoryItemLookUpEdit1 = new DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit();
            this.xtraTabPage3 = new DevExpress.XtraTab.XtraTabPage();
            this.gridControl2 = new DevExpress.XtraGrid.GridControl();
            this.adjustementBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.adjustementGridView = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.colDocumentNumber = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colDocumentDate = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colFiscalPeriod = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colFiscalYear = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colPreviousValue = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colAdjustedValue = new DevExpress.XtraGrid.Columns.GridColumn();
            this.AdjustType = new DevExpress.XtraGrid.Columns.GridColumn();
            this.adjTypeRepository = new DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit();
            this.adjustementTypeBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.AdjustStatus = new DevExpress.XtraGrid.Columns.GridColumn();
            this.statusRepositoryItem = new DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit();
            this.adjustStatusBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.toolStrip2 = new System.Windows.Forms.ToolStrip();
            this.btnNewAdj = new System.Windows.Forms.ToolStripButton();
            this.btnDeleteAdj = new System.Windows.Forms.ToolStripButton();
            this.btnPostAdj = new System.Windows.Forms.ToolStripButton();
            this.xtraTabPage4 = new DevExpress.XtraTab.XtraTabPage();
            this.gridControl3 = new DevExpress.XtraGrid.GridControl();
            this.deperciationBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.gridView2 = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.colFiscalyear1 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colBookValueAtBeginningOfYear = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colBookValueAtEndOfYear = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colDepreciationRate = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colDeprecationExpense = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colAccumulatedDepreciation = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colFiscalPeriod1 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.salvageValueTextBox = new System.Windows.Forms.TextBox();
            this.txtCurrentBookvalue = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txtDeperToDate = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.depreciationMethodLookUpEdit = new DevExpress.XtraEditors.LookUpEdit();
            this.depreciationMethodBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.descriptionTextBox = new System.Windows.Forms.TextBox();
            this.physicalConditionLookUpEdit = new DevExpress.XtraEditors.LookUpEdit();
            this.physicalConditionBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.assetValueTextBox = new System.Windows.Forms.TextBox();
            this.usefulLifeTextBox = new System.Windows.Forms.TextBox();
            this.vendorLookUpEdit = new DevExpress.XtraEditors.LookUpEdit();
            this.vendorBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.purchaseDateDateEdit = new DevExpress.XtraEditors.DateEdit();
            this.documentNumberTextBox = new System.Windows.Forms.TextBox();
            this.vendorsbindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.catagoryBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.assetStatusBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.costCenterBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.groupBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.assetErrorProvider = new System.Windows.Forms.ErrorProvider(this.components);
            this.locationBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.assetNumberTextBox = new System.Windows.Forms.TextBox();
            this.costCenterIdLookUpEdit = new DevExpress.XtraEditors.LookUpEdit();
            this.locationIdLookUpEdit = new DevExpress.XtraEditors.LookUpEdit();
            this.linkDispoInfo = new System.Windows.Forms.LinkLabel();
            this.statusLookUpEdit = new DevExpress.XtraEditors.LookUpEdit();
            this.categoryLookUpEdit = new DevExpress.XtraEditors.LookUpEdit();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.groupIdLookUpEdit = new DevExpress.XtraEditors.LookUpEdit();
            this.ribbonControl1 = new DevExpress.XtraBars.Ribbon.RibbonControl();
            this.smallImageCollection = new DevExpress.Utils.ImageCollection(this.components);
            this.saveAssetBarButtonItem = new DevExpress.XtraBars.BarButtonItem();
            this.deleteAssetBarButtonItem = new DevExpress.XtraBars.BarButtonItem();
            this.calculateDepreciationBarButtonItem = new DevExpress.XtraBars.BarButtonItem();
            this.disposeAssetBarButtonItem = new DevExpress.XtraBars.BarButtonItem();
            this.returnBarButtonItem = new DevExpress.XtraBars.BarButtonItem();
            this.transferAssetBarButtonItem = new DevExpress.XtraBars.BarButtonItem();
            this.largeImageCollection = new DevExpress.Utils.ImageCollection(this.components);
            this.ribbonPage1 = new DevExpress.XtraBars.Ribbon.RibbonPage();
            this.ribbonPageGroup1 = new DevExpress.XtraBars.Ribbon.RibbonPageGroup();
            this.barButtonItem2 = new DevExpress.XtraBars.BarButtonItem();
            this.assetPanel = new DevExpress.XtraEditors.PanelControl();
            physicalConditionLabel = new System.Windows.Forms.Label();
            assetValueLabel = new System.Windows.Forms.Label();
            usefulLifeLabel = new System.Windows.Forms.Label();
            vendorLabel = new System.Windows.Forms.Label();
            purchaseDateLabel = new System.Windows.Forms.Label();
            documentNumberLabel = new System.Windows.Forms.Label();
            depreciationMethodLabel = new System.Windows.Forms.Label();
            salvageValueLabel = new System.Windows.Forms.Label();
            assetNumberLabel = new System.Windows.Forms.Label();
            costCenterIdLabel = new System.Windows.Forms.Label();
            locationIdLabel = new System.Windows.Forms.Label();
            statusLabel = new System.Windows.Forms.Label();
            categoryLabel = new System.Windows.Forms.Label();
            descriptionLabel = new System.Windows.Forms.Label();
            groupIdLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.assetDetailBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.xtraTabControl1)).BeginInit();
            this.xtraTabControl1.SuspendLayout();
            this.xtraTabPage1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.imagePictureEdit.Properties)).BeginInit();
            this.xtraTabPage2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gridControl1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.custodianAssetBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemLookUpEdit1)).BeginInit();
            this.xtraTabPage3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gridControl2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.adjustementBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.adjustementGridView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.adjTypeRepository)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.adjustementTypeBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.statusRepositoryItem)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.adjustStatusBindingSource)).BeginInit();
            this.toolStrip2.SuspendLayout();
            this.xtraTabPage4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gridControl3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.deperciationBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView2)).BeginInit();
            this.groupBox3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.depreciationMethodLookUpEdit.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.depreciationMethodBindingSource)).BeginInit();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.physicalConditionLookUpEdit.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.physicalConditionBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.vendorLookUpEdit.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.vendorBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.purchaseDateDateEdit.Properties.VistaTimeProperties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.purchaseDateDateEdit.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.vendorsbindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.catagoryBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.assetStatusBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.costCenterBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.groupBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.assetErrorProvider)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.locationBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.costCenterIdLookUpEdit.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.locationIdLookUpEdit.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.statusLookUpEdit.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.categoryLookUpEdit.Properties)).BeginInit();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.groupIdLookUpEdit.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ribbonControl1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.smallImageCollection)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.largeImageCollection)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.assetPanel)).BeginInit();
            this.assetPanel.SuspendLayout();
            this.SuspendLayout();
            // 
            // physicalConditionLabel
            // 
            physicalConditionLabel.AutoSize = true;
            physicalConditionLabel.Location = new System.Drawing.Point(17, 158);
            physicalConditionLabel.Name = "physicalConditionLabel";
            physicalConditionLabel.Size = new System.Drawing.Size(97, 13);
            physicalConditionLabel.TabIndex = 10;
            physicalConditionLabel.Text = "Physical Condition:";
            // 
            // assetValueLabel
            // 
            assetValueLabel.AutoSize = true;
            assetValueLabel.Location = new System.Drawing.Point(17, 131);
            assetValueLabel.Name = "assetValueLabel";
            assetValueLabel.Size = new System.Drawing.Size(67, 13);
            assetValueLabel.TabIndex = 8;
            assetValueLabel.Text = "Asset Value:";
            // 
            // usefulLifeLabel
            // 
            usefulLifeLabel.AutoSize = true;
            usefulLifeLabel.Location = new System.Drawing.Point(17, 104);
            usefulLifeLabel.Name = "usefulLifeLabel";
            usefulLifeLabel.Size = new System.Drawing.Size(99, 13);
            usefulLifeLabel.TabIndex = 6;
            usefulLifeLabel.Text = "Useful Life (Years):";
            // 
            // vendorLabel
            // 
            vendorLabel.AutoSize = true;
            vendorLabel.Location = new System.Drawing.Point(17, 78);
            vendorLabel.Name = "vendorLabel";
            vendorLabel.Size = new System.Drawing.Size(45, 13);
            vendorLabel.TabIndex = 4;
            vendorLabel.Text = "Vendor:";
            // 
            // purchaseDateLabel
            // 
            purchaseDateLabel.AutoSize = true;
            purchaseDateLabel.Location = new System.Drawing.Point(17, 52);
            purchaseDateLabel.Name = "purchaseDateLabel";
            purchaseDateLabel.Size = new System.Drawing.Size(81, 13);
            purchaseDateLabel.TabIndex = 2;
            purchaseDateLabel.Text = "Purchase Date:";
            // 
            // documentNumberLabel
            // 
            documentNumberLabel.AutoSize = true;
            documentNumberLabel.Location = new System.Drawing.Point(17, 25);
            documentNumberLabel.Name = "documentNumberLabel";
            documentNumberLabel.Size = new System.Drawing.Size(99, 13);
            documentNumberLabel.TabIndex = 0;
            documentNumberLabel.Text = "Document Number:";
            // 
            // depreciationMethodLabel
            // 
            depreciationMethodLabel.AutoSize = true;
            depreciationMethodLabel.Location = new System.Drawing.Point(8, 24);
            depreciationMethodLabel.Name = "depreciationMethodLabel";
            depreciationMethodLabel.Size = new System.Drawing.Size(110, 13);
            depreciationMethodLabel.TabIndex = 0;
            depreciationMethodLabel.Text = "Depreciation Method:";
            // 
            // salvageValueLabel
            // 
            salvageValueLabel.AutoSize = true;
            salvageValueLabel.Location = new System.Drawing.Point(8, 51);
            salvageValueLabel.Name = "salvageValueLabel";
            salvageValueLabel.Size = new System.Drawing.Size(78, 13);
            salvageValueLabel.TabIndex = 7;
            salvageValueLabel.Text = "Salvage Value:";
            // 
            // assetNumberLabel
            // 
            assetNumberLabel.AutoSize = true;
            assetNumberLabel.Location = new System.Drawing.Point(20, 23);
            assetNumberLabel.Name = "assetNumberLabel";
            assetNumberLabel.Size = new System.Drawing.Size(49, 13);
            assetNumberLabel.TabIndex = 6;
            assetNumberLabel.Text = "Asset #:";
            // 
            // costCenterIdLabel
            // 
            costCenterIdLabel.AutoSize = true;
            costCenterIdLabel.Location = new System.Drawing.Point(20, 102);
            costCenterIdLabel.Name = "costCenterIdLabel";
            costCenterIdLabel.Size = new System.Drawing.Size(69, 13);
            costCenterIdLabel.TabIndex = 6;
            costCenterIdLabel.Text = "Cost Center:";
            // 
            // locationIdLabel
            // 
            locationIdLabel.AutoSize = true;
            locationIdLabel.Location = new System.Drawing.Point(20, 128);
            locationIdLabel.Name = "locationIdLabel";
            locationIdLabel.Size = new System.Drawing.Size(51, 13);
            locationIdLabel.TabIndex = 8;
            locationIdLabel.Text = "Location:";
            // 
            // statusLabel
            // 
            statusLabel.AutoSize = true;
            statusLabel.Location = new System.Drawing.Point(20, 154);
            statusLabel.Name = "statusLabel";
            statusLabel.Size = new System.Drawing.Size(42, 13);
            statusLabel.TabIndex = 12;
            statusLabel.Text = "Status:";
            // 
            // categoryLabel
            // 
            categoryLabel.AutoSize = true;
            categoryLabel.Location = new System.Drawing.Point(20, 52);
            categoryLabel.Name = "categoryLabel";
            categoryLabel.Size = new System.Drawing.Size(56, 13);
            categoryLabel.TabIndex = 13;
            categoryLabel.Text = "Category:";
            // 
            // descriptionLabel
            // 
            descriptionLabel.AutoSize = true;
            descriptionLabel.Location = new System.Drawing.Point(336, 20);
            descriptionLabel.Name = "descriptionLabel";
            descriptionLabel.Size = new System.Drawing.Size(64, 13);
            descriptionLabel.TabIndex = 14;
            descriptionLabel.Text = "Description:";
            // 
            // groupIdLabel
            // 
            groupIdLabel.AutoSize = true;
            groupIdLabel.Location = new System.Drawing.Point(20, 76);
            groupIdLabel.Name = "groupIdLabel";
            groupIdLabel.Size = new System.Drawing.Size(40, 13);
            groupIdLabel.TabIndex = 16;
            groupIdLabel.Text = "Group:";
            // 
            // assetDetailBindingSource
            // 
            this.assetDetailBindingSource.DataSource = typeof(ClearOffice.FixedAsset.DataAccess.Asset);
            this.assetDetailBindingSource.CurrentItemChanged += new System.EventHandler(this.assetDetailBindingSource_CurrentItemChanged);
            // 
            // xtraTabControl1
            // 
            this.xtraTabControl1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.xtraTabControl1.Location = new System.Drawing.Point(7, 283);
            this.xtraTabControl1.Margin = new System.Windows.Forms.Padding(5);
            this.xtraTabControl1.Name = "xtraTabControl1";
            this.xtraTabControl1.SelectedTabPage = this.xtraTabPage1;
            this.xtraTabControl1.Size = new System.Drawing.Size(886, 133);
            this.xtraTabControl1.TabIndex = 4;
            this.xtraTabControl1.TabPages.AddRange(new DevExpress.XtraTab.XtraTabPage[] {
            this.xtraTabPage1,
            this.xtraTabPage2,
            this.xtraTabPage3,
            this.xtraTabPage4});
            // 
            // xtraTabPage1
            // 
            this.xtraTabPage1.AutoScroll = true;
            this.xtraTabPage1.Controls.Add(this.imagePictureEdit);
            this.xtraTabPage1.Name = "xtraTabPage1";
            this.xtraTabPage1.Size = new System.Drawing.Size(880, 105);
            this.xtraTabPage1.Text = "Image";
            // 
            // imagePictureEdit
            // 
            this.imagePictureEdit.DataBindings.Add(new System.Windows.Forms.Binding("EditValue", this.assetDetailBindingSource, "Image", true));
            this.imagePictureEdit.Dock = System.Windows.Forms.DockStyle.Fill;
            this.imagePictureEdit.Location = new System.Drawing.Point(0, 0);
            this.imagePictureEdit.Name = "imagePictureEdit";
            this.imagePictureEdit.Size = new System.Drawing.Size(880, 105);
            this.imagePictureEdit.TabIndex = 9;
            // 
            // xtraTabPage2
            // 
            this.xtraTabPage2.Controls.Add(this.gridControl1);
            this.xtraTabPage2.Name = "xtraTabPage2";
            this.xtraTabPage2.Size = new System.Drawing.Size(880, 105);
            this.xtraTabPage2.Text = "Usage History";
            // 
            // gridControl1
            // 
            this.gridControl1.DataSource = this.custodianAssetBindingSource;
            this.gridControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gridControl1.Location = new System.Drawing.Point(0, 0);
            this.gridControl1.MainView = this.gridView1;
            this.gridControl1.Name = "gridControl1";
            this.gridControl1.RepositoryItems.AddRange(new DevExpress.XtraEditors.Repository.RepositoryItem[] {
            this.repositoryItemLookUpEdit1});
            this.gridControl1.Size = new System.Drawing.Size(880, 105);
            this.gridControl1.TabIndex = 0;
            this.gridControl1.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridView1});
            // 
            // custodianAssetBindingSource
            // 
            this.custodianAssetBindingSource.DataSource = typeof(ClearOffice.FixedAsset.DataAccess.CustodianAssetInfo);
            // 
            // gridView1
            // 
            this.gridView1.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.colDateFrom,
            this.colDateTo,
            this.colBadgeNo,
            this.colFirstName,
            this.colLastName,
            this.colItemName});
            this.gridView1.GridControl = this.gridControl1;
            this.gridView1.Name = "gridView1";
            this.gridView1.OptionsBehavior.Editable = false;
            this.gridView1.OptionsView.ShowGroupPanel = false;
            // 
            // colDateFrom
            // 
            this.colDateFrom.FieldName = "DateFrom";
            this.colDateFrom.Name = "colDateFrom";
            this.colDateFrom.Visible = true;
            this.colDateFrom.VisibleIndex = 0;
            // 
            // colDateTo
            // 
            this.colDateTo.FieldName = "DateTo";
            this.colDateTo.Name = "colDateTo";
            this.colDateTo.Visible = true;
            this.colDateTo.VisibleIndex = 1;
            // 
            // colBadgeNo
            // 
            this.colBadgeNo.FieldName = "BadgeNo";
            this.colBadgeNo.Name = "colBadgeNo";
            this.colBadgeNo.Visible = true;
            this.colBadgeNo.VisibleIndex = 2;
            // 
            // colFirstName
            // 
            this.colFirstName.FieldName = "FirstName";
            this.colFirstName.Name = "colFirstName";
            this.colFirstName.Visible = true;
            this.colFirstName.VisibleIndex = 3;
            // 
            // colLastName
            // 
            this.colLastName.FieldName = "LastName";
            this.colLastName.Name = "colLastName";
            this.colLastName.Visible = true;
            this.colLastName.VisibleIndex = 4;
            // 
            // colItemName
            // 
            this.colItemName.Caption = "Status";
            this.colItemName.FieldName = "ItemName";
            this.colItemName.Name = "colItemName";
            this.colItemName.Visible = true;
            this.colItemName.VisibleIndex = 5;
            // 
            // repositoryItemLookUpEdit1
            // 
            this.repositoryItemLookUpEdit1.AutoHeight = false;
            this.repositoryItemLookUpEdit1.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.repositoryItemLookUpEdit1.Name = "repositoryItemLookUpEdit1";
            // 
            // xtraTabPage3
            // 
            this.xtraTabPage3.Controls.Add(this.gridControl2);
            this.xtraTabPage3.Controls.Add(this.toolStrip2);
            this.xtraTabPage3.Name = "xtraTabPage3";
            this.xtraTabPage3.Size = new System.Drawing.Size(880, 105);
            this.xtraTabPage3.Text = "Adjustment";
            // 
            // gridControl2
            // 
            this.gridControl2.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.gridControl2.DataSource = this.adjustementBindingSource;
            this.gridControl2.Location = new System.Drawing.Point(3, 29);
            this.gridControl2.MainView = this.adjustementGridView;
            this.gridControl2.Name = "gridControl2";
            this.gridControl2.RepositoryItems.AddRange(new DevExpress.XtraEditors.Repository.RepositoryItem[] {
            this.adjTypeRepository,
            this.statusRepositoryItem});
            this.gridControl2.Size = new System.Drawing.Size(874, 75);
            this.gridControl2.TabIndex = 1;
            this.gridControl2.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.adjustementGridView});
            this.gridControl2.Click += new System.EventHandler(this.gridControl2_Click);
            this.gridControl2.DoubleClick += new System.EventHandler(this.gridControl2_DoubleClick);
            // 
            // adjustementBindingSource
            // 
            this.adjustementBindingSource.DataSource = typeof(ClearOffice.FixedAsset.DataAccess.Adjustment);
            this.adjustementBindingSource.CurrentItemChanged += new System.EventHandler(this.adjustementBindingSource_CurrentItemChanged);
            // 
            // adjustementGridView
            // 
            this.adjustementGridView.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.colDocumentNumber,
            this.colDocumentDate,
            this.colFiscalPeriod,
            this.colFiscalYear,
            this.colPreviousValue,
            this.colAdjustedValue,
            this.AdjustType,
            this.AdjustStatus});
            this.adjustementGridView.GridControl = this.gridControl2;
            this.adjustementGridView.Name = "adjustementGridView";
            this.adjustementGridView.OptionsBehavior.Editable = false;
            this.adjustementGridView.OptionsView.ShowGroupPanel = false;
            // 
            // colDocumentNumber
            // 
            this.colDocumentNumber.Caption = "Document Number";
            this.colDocumentNumber.FieldName = "DocumentNumber";
            this.colDocumentNumber.Name = "colDocumentNumber";
            this.colDocumentNumber.Visible = true;
            this.colDocumentNumber.VisibleIndex = 1;
            // 
            // colDocumentDate
            // 
            this.colDocumentDate.Caption = "Document Date";
            this.colDocumentDate.FieldName = "DocumentDate";
            this.colDocumentDate.Name = "colDocumentDate";
            this.colDocumentDate.Visible = true;
            this.colDocumentDate.VisibleIndex = 2;
            // 
            // colFiscalPeriod
            // 
            this.colFiscalPeriod.Caption = "Fiscal Period";
            this.colFiscalPeriod.FieldName = "FiscalPeriod";
            this.colFiscalPeriod.Name = "colFiscalPeriod";
            this.colFiscalPeriod.Visible = true;
            this.colFiscalPeriod.VisibleIndex = 3;
            // 
            // colFiscalYear
            // 
            this.colFiscalYear.Caption = "Fiscal Year";
            this.colFiscalYear.FieldName = "FiscalYear";
            this.colFiscalYear.Name = "colFiscalYear";
            this.colFiscalYear.Visible = true;
            this.colFiscalYear.VisibleIndex = 4;
            // 
            // colPreviousValue
            // 
            this.colPreviousValue.Caption = "Previous Value";
            this.colPreviousValue.DisplayFormat.FormatString = "{0:#,##0.00;(#,##0.00);\\\'\\\'}";
            this.colPreviousValue.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Custom;
            this.colPreviousValue.FieldName = "PreviousValue";
            this.colPreviousValue.Name = "colPreviousValue";
            this.colPreviousValue.Visible = true;
            this.colPreviousValue.VisibleIndex = 5;
            // 
            // colAdjustedValue
            // 
            this.colAdjustedValue.Caption = "Adjusted Value";
            this.colAdjustedValue.DisplayFormat.FormatString = "{0:#,##0.00;(#,##0.00);\\\'\\\'}";
            this.colAdjustedValue.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Custom;
            this.colAdjustedValue.FieldName = "AdjustedValue";
            this.colAdjustedValue.Name = "colAdjustedValue";
            this.colAdjustedValue.Visible = true;
            this.colAdjustedValue.VisibleIndex = 6;
            // 
            // AdjustType
            // 
            this.AdjustType.Caption = "Adjustment Type";
            this.AdjustType.ColumnEdit = this.adjTypeRepository;
            this.AdjustType.FieldName = "AdjustmentType";
            this.AdjustType.Name = "AdjustType";
            this.AdjustType.Visible = true;
            this.AdjustType.VisibleIndex = 0;
            // 
            // adjTypeRepository
            // 
            this.adjTypeRepository.AutoHeight = false;
            this.adjTypeRepository.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.adjTypeRepository.DataSource = this.adjustementTypeBindingSource;
            this.adjTypeRepository.DisplayMember = "ItemName";
            this.adjTypeRepository.Name = "adjTypeRepository";
            this.adjTypeRepository.ValueMember = "LookupItemId";
            // 
            // adjustementTypeBindingSource
            // 
            this.adjustementTypeBindingSource.DataSource = typeof(ClearOffice.FixedAsset.DataAccess.LookupItem);
            // 
            // AdjustStatus
            // 
            this.AdjustStatus.Caption = "Status";
            this.AdjustStatus.ColumnEdit = this.statusRepositoryItem;
            this.AdjustStatus.FieldName = "Status";
            this.AdjustStatus.Name = "AdjustStatus";
            this.AdjustStatus.Visible = true;
            this.AdjustStatus.VisibleIndex = 7;
            // 
            // statusRepositoryItem
            // 
            this.statusRepositoryItem.AutoHeight = false;
            this.statusRepositoryItem.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.statusRepositoryItem.DataSource = this.adjustStatusBindingSource;
            this.statusRepositoryItem.DisplayMember = "ItemName";
            this.statusRepositoryItem.Name = "statusRepositoryItem";
            this.statusRepositoryItem.ValueMember = "LookupItemId";
            // 
            // adjustStatusBindingSource
            // 
            this.adjustStatusBindingSource.DataSource = typeof(ClearOffice.FixedAsset.DataAccess.LookupItem);
            // 
            // toolStrip2
            // 
            this.toolStrip2.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.btnNewAdj,
            this.btnDeleteAdj,
            this.btnPostAdj});
            this.toolStrip2.Location = new System.Drawing.Point(0, 0);
            this.toolStrip2.Name = "toolStrip2";
            this.toolStrip2.Size = new System.Drawing.Size(880, 25);
            this.toolStrip2.TabIndex = 0;
            this.toolStrip2.Text = "toolStrip2";
            // 
            // btnNewAdj
            // 
            this.btnNewAdj.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.btnNewAdj.Image = ((System.Drawing.Image)(resources.GetObject("btnNewAdj.Image")));
            this.btnNewAdj.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnNewAdj.Name = "btnNewAdj";
            this.btnNewAdj.Size = new System.Drawing.Size(23, 22);
            this.btnNewAdj.Text = "&New";
            this.btnNewAdj.Click += new System.EventHandler(this.btnNewAdj_Click);
            // 
            // btnDeleteAdj
            // 
            this.btnDeleteAdj.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.btnDeleteAdj.Enabled = false;
            this.btnDeleteAdj.Image = global::ClearOffice.FixedAsset.Properties.Resources.delete;
            this.btnDeleteAdj.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnDeleteAdj.Name = "btnDeleteAdj";
            this.btnDeleteAdj.Size = new System.Drawing.Size(23, 22);
            this.btnDeleteAdj.Text = "toolStripButton2";
            this.btnDeleteAdj.ToolTipText = "Delete";
            this.btnDeleteAdj.Click += new System.EventHandler(this.btnDeleteAdj_Click);
            // 
            // btnPostAdj
            // 
            this.btnPostAdj.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.btnPostAdj.Enabled = false;
            this.btnPostAdj.Image = global::ClearOffice.FixedAsset.Properties.Resources.thumb_up;
            this.btnPostAdj.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnPostAdj.Name = "btnPostAdj";
            this.btnPostAdj.Size = new System.Drawing.Size(23, 22);
            this.btnPostAdj.Text = "toolStripButton2";
            this.btnPostAdj.ToolTipText = "Post Adjustement";
            this.btnPostAdj.Click += new System.EventHandler(this.btnPostAdj_Click);
            // 
            // xtraTabPage4
            // 
            this.xtraTabPage4.Controls.Add(this.gridControl3);
            this.xtraTabPage4.Name = "xtraTabPage4";
            this.xtraTabPage4.Size = new System.Drawing.Size(880, 105);
            this.xtraTabPage4.Text = "Depreciation";
            // 
            // gridControl3
            // 
            this.gridControl3.DataSource = this.deperciationBindingSource;
            this.gridControl3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gridControl3.Location = new System.Drawing.Point(0, 0);
            this.gridControl3.MainView = this.gridView2;
            this.gridControl3.Name = "gridControl3";
            this.gridControl3.Size = new System.Drawing.Size(880, 105);
            this.gridControl3.TabIndex = 0;
            this.gridControl3.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridView2});
            // 
            // deperciationBindingSource
            // 
            this.deperciationBindingSource.DataSource = typeof(ClearOffice.FixedAsset.DataAccess.Depreciation);
            // 
            // gridView2
            // 
            this.gridView2.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.colFiscalyear1,
            this.colBookValueAtBeginningOfYear,
            this.colBookValueAtEndOfYear,
            this.colDepreciationRate,
            this.colDeprecationExpense,
            this.colAccumulatedDepreciation,
            this.colFiscalPeriod1});
            this.gridView2.GridControl = this.gridControl3;
            this.gridView2.GroupCount = 1;
            this.gridView2.Name = "gridView2";
            this.gridView2.OptionsBehavior.Editable = false;
            this.gridView2.OptionsView.ShowGroupedColumns = true;
            this.gridView2.OptionsView.ShowGroupPanel = false;
            this.gridView2.OptionsView.WaitAnimationOptions = DevExpress.XtraEditors.WaitAnimationOptions.Indicator;
            this.gridView2.SortInfo.AddRange(new DevExpress.XtraGrid.Columns.GridColumnSortInfo[] {
            new DevExpress.XtraGrid.Columns.GridColumnSortInfo(this.colFiscalyear1, DevExpress.Data.ColumnSortOrder.Ascending)});
            // 
            // colFiscalyear1
            // 
            this.colFiscalyear1.Caption = "Fiscal Year";
            this.colFiscalyear1.FieldName = "Fiscalyear";
            this.colFiscalyear1.Name = "colFiscalyear1";
            this.colFiscalyear1.OptionsColumn.AllowSort = DevExpress.Utils.DefaultBoolean.True;
            this.colFiscalyear1.SortMode = DevExpress.XtraGrid.ColumnSortMode.DisplayText;
            this.colFiscalyear1.Visible = true;
            this.colFiscalyear1.VisibleIndex = 0;
            this.colFiscalyear1.Width = 93;
            // 
            // colBookValueAtBeginningOfYear
            // 
            this.colBookValueAtBeginningOfYear.Caption = "Book Value at the Beginning of the Year";
            this.colBookValueAtBeginningOfYear.DisplayFormat.FormatString = "{0:#,##0.00;(#,##0.00);\\\'\\\'}";
            this.colBookValueAtBeginningOfYear.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Custom;
            this.colBookValueAtBeginningOfYear.FieldName = "BookValueAtBeginningOfYear";
            this.colBookValueAtBeginningOfYear.Name = "colBookValueAtBeginningOfYear";
            this.colBookValueAtBeginningOfYear.Visible = true;
            this.colBookValueAtBeginningOfYear.VisibleIndex = 2;
            this.colBookValueAtBeginningOfYear.Width = 194;
            // 
            // colBookValueAtEndOfYear
            // 
            this.colBookValueAtEndOfYear.Caption = "Book Value at the End of the Year";
            this.colBookValueAtEndOfYear.DisplayFormat.FormatString = "{0:#,##0.00;(#,##0.00);\\\'\\\'}";
            this.colBookValueAtEndOfYear.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Custom;
            this.colBookValueAtEndOfYear.FieldName = "BookValueAtEndOfYear";
            this.colBookValueAtEndOfYear.Name = "colBookValueAtEndOfYear";
            this.colBookValueAtEndOfYear.Visible = true;
            this.colBookValueAtEndOfYear.VisibleIndex = 6;
            this.colBookValueAtEndOfYear.Width = 174;
            // 
            // colDepreciationRate
            // 
            this.colDepreciationRate.Caption = "Depreciation Rate (%)";
            this.colDepreciationRate.FieldName = "DepreciationRate";
            this.colDepreciationRate.Name = "colDepreciationRate";
            this.colDepreciationRate.Visible = true;
            this.colDepreciationRate.VisibleIndex = 5;
            this.colDepreciationRate.Width = 117;
            // 
            // colDeprecationExpense
            // 
            this.colDeprecationExpense.Caption = "Depreciation Expense";
            this.colDeprecationExpense.DisplayFormat.FormatString = "{0:#,##0.00;(#,##0.00);\\\'\\\'}";
            this.colDeprecationExpense.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Custom;
            this.colDeprecationExpense.FieldName = "DeprecationExpense";
            this.colDeprecationExpense.Name = "colDeprecationExpense";
            this.colDeprecationExpense.Visible = true;
            this.colDeprecationExpense.VisibleIndex = 3;
            this.colDeprecationExpense.Width = 104;
            // 
            // colAccumulatedDepreciation
            // 
            this.colAccumulatedDepreciation.Caption = "Depreciation to Date";
            this.colAccumulatedDepreciation.DisplayFormat.FormatString = "{0:#,##0.00;(#,##0.00);\\\'\\\'}";
            this.colAccumulatedDepreciation.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Custom;
            this.colAccumulatedDepreciation.FieldName = "AccumulatedDepreciation";
            this.colAccumulatedDepreciation.Name = "colAccumulatedDepreciation";
            this.colAccumulatedDepreciation.Visible = true;
            this.colAccumulatedDepreciation.VisibleIndex = 4;
            this.colAccumulatedDepreciation.Width = 109;
            // 
            // colFiscalPeriod1
            // 
            this.colFiscalPeriod1.Caption = "Fiscal Period";
            this.colFiscalPeriod1.FieldName = "FiscalPeriod";
            this.colFiscalPeriod1.Name = "colFiscalPeriod1";
            this.colFiscalPeriod1.Visible = true;
            this.colFiscalPeriod1.VisibleIndex = 1;
            this.colFiscalPeriod1.Width = 71;
            // 
            // groupBox3
            // 
            this.groupBox3.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBox3.Controls.Add(salvageValueLabel);
            this.groupBox3.Controls.Add(this.salvageValueTextBox);
            this.groupBox3.Controls.Add(this.txtCurrentBookvalue);
            this.groupBox3.Controls.Add(this.label2);
            this.groupBox3.Controls.Add(this.txtDeperToDate);
            this.groupBox3.Controls.Add(this.label1);
            this.groupBox3.Controls.Add(depreciationMethodLabel);
            this.groupBox3.Controls.Add(this.depreciationMethodLookUpEdit);
            this.groupBox3.Location = new System.Drawing.Point(8, 192);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(875, 84);
            this.groupBox3.TabIndex = 2;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Depreciation Information";
            // 
            // salvageValueTextBox
            // 
            this.salvageValueTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.assetDetailBindingSource, "SalvageValue", true));
            this.salvageValueTextBox.Enabled = false;
            this.salvageValueTextBox.Location = new System.Drawing.Point(124, 47);
            this.salvageValueTextBox.Name = "salvageValueTextBox";
            this.salvageValueTextBox.Size = new System.Drawing.Size(293, 21);
            this.salvageValueTextBox.TabIndex = 8;
            this.salvageValueTextBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // txtCurrentBookvalue
            // 
            this.txtCurrentBookvalue.Enabled = false;
            this.txtCurrentBookvalue.Location = new System.Drawing.Point(568, 48);
            this.txtCurrentBookvalue.Name = "txtCurrentBookvalue";
            this.txtCurrentBookvalue.Size = new System.Drawing.Size(293, 21);
            this.txtCurrentBookvalue.TabIndex = 7;
            this.txtCurrentBookvalue.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(452, 52);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(103, 13);
            this.label2.TabIndex = 6;
            this.label2.Text = "Current Book Value:";
            // 
            // txtDeperToDate
            // 
            this.txtDeperToDate.Enabled = false;
            this.txtDeperToDate.Location = new System.Drawing.Point(568, 21);
            this.txtDeperToDate.Name = "txtDeperToDate";
            this.txtDeperToDate.Size = new System.Drawing.Size(293, 21);
            this.txtDeperToDate.TabIndex = 5;
            this.txtDeperToDate.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(452, 24);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(113, 13);
            this.label1.TabIndex = 4;
            this.label1.Text = "Depreciation  to Date:";
            // 
            // depreciationMethodLookUpEdit
            // 
            this.depreciationMethodLookUpEdit.DataBindings.Add(new System.Windows.Forms.Binding("EditValue", this.assetDetailBindingSource, "DepreciationMethod", true));
            this.depreciationMethodLookUpEdit.Enabled = false;
            this.depreciationMethodLookUpEdit.Location = new System.Drawing.Point(124, 21);
            this.depreciationMethodLookUpEdit.Name = "depreciationMethodLookUpEdit";
            this.depreciationMethodLookUpEdit.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.depreciationMethodLookUpEdit.Properties.DataSource = this.depreciationMethodBindingSource;
            this.depreciationMethodLookUpEdit.Properties.DisplayMember = "ItemName";
            this.depreciationMethodLookUpEdit.Properties.NullText = "[Select Depreciation  Method]";
            this.depreciationMethodLookUpEdit.Properties.ValueMember = "LookupItemId";
            this.depreciationMethodLookUpEdit.Size = new System.Drawing.Size(293, 20);
            this.depreciationMethodLookUpEdit.TabIndex = 1;
            // 
            // depreciationMethodBindingSource
            // 
            this.depreciationMethodBindingSource.DataSource = typeof(ClearOffice.FixedAsset.DataAccess.LookupItem);
            // 
            // groupBox2
            // 
            this.groupBox2.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBox2.Controls.Add(descriptionLabel);
            this.groupBox2.Controls.Add(this.descriptionTextBox);
            this.groupBox2.Controls.Add(physicalConditionLabel);
            this.groupBox2.Controls.Add(this.physicalConditionLookUpEdit);
            this.groupBox2.Controls.Add(assetValueLabel);
            this.groupBox2.Controls.Add(this.assetValueTextBox);
            this.groupBox2.Controls.Add(usefulLifeLabel);
            this.groupBox2.Controls.Add(this.usefulLifeTextBox);
            this.groupBox2.Controls.Add(vendorLabel);
            this.groupBox2.Controls.Add(this.vendorLookUpEdit);
            this.groupBox2.Controls.Add(purchaseDateLabel);
            this.groupBox2.Controls.Add(this.purchaseDateDateEdit);
            this.groupBox2.Controls.Add(documentNumberLabel);
            this.groupBox2.Controls.Add(this.documentNumberTextBox);
            this.groupBox2.Location = new System.Drawing.Point(400, 7);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(488, 184);
            this.groupBox2.TabIndex = 1;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Purchase Information";
            // 
            // descriptionTextBox
            // 
            this.descriptionTextBox.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.descriptionTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.assetDetailBindingSource, "Description", true));
            this.descriptionTextBox.Location = new System.Drawing.Point(336, 47);
            this.descriptionTextBox.Multiline = true;
            this.descriptionTextBox.Name = "descriptionTextBox";
            this.descriptionTextBox.Size = new System.Drawing.Size(142, 126);
            this.descriptionTextBox.TabIndex = 15;
            // 
            // physicalConditionLookUpEdit
            // 
            this.physicalConditionLookUpEdit.DataBindings.Add(new System.Windows.Forms.Binding("EditValue", this.assetDetailBindingSource, "PhysicalCondition", true));
            this.physicalConditionLookUpEdit.Location = new System.Drawing.Point(122, 153);
            this.physicalConditionLookUpEdit.Name = "physicalConditionLookUpEdit";
            this.physicalConditionLookUpEdit.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.physicalConditionLookUpEdit.Properties.Columns.AddRange(new DevExpress.XtraEditors.Controls.LookUpColumnInfo[] {
            new DevExpress.XtraEditors.Controls.LookUpColumnInfo("ItemName", "Physical Condition", 62, DevExpress.Utils.FormatType.None, "", true, DevExpress.Utils.HorzAlignment.Near)});
            this.physicalConditionLookUpEdit.Properties.DataSource = this.physicalConditionBindingSource;
            this.physicalConditionLookUpEdit.Properties.DisplayMember = "ItemName";
            this.physicalConditionLookUpEdit.Properties.NullText = "[Select Physical Condition]";
            this.physicalConditionLookUpEdit.Properties.ValueMember = "LookupItemId";
            this.physicalConditionLookUpEdit.Size = new System.Drawing.Size(208, 20);
            this.physicalConditionLookUpEdit.TabIndex = 11;
            // 
            // physicalConditionBindingSource
            // 
            this.physicalConditionBindingSource.DataSource = typeof(ClearOffice.FixedAsset.DataAccess.LookupItem);
            // 
            // assetValueTextBox
            // 
            this.assetValueTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.assetDetailBindingSource, "AssetValue", true));
            this.assetValueTextBox.Enabled = false;
            this.assetValueTextBox.Location = new System.Drawing.Point(122, 126);
            this.assetValueTextBox.Name = "assetValueTextBox";
            this.assetValueTextBox.Size = new System.Drawing.Size(208, 21);
            this.assetValueTextBox.TabIndex = 9;
            this.assetValueTextBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // usefulLifeTextBox
            // 
            this.usefulLifeTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.assetDetailBindingSource, "UsefulLife", true));
            this.usefulLifeTextBox.Enabled = false;
            this.usefulLifeTextBox.Location = new System.Drawing.Point(122, 99);
            this.usefulLifeTextBox.Name = "usefulLifeTextBox";
            this.usefulLifeTextBox.Size = new System.Drawing.Size(208, 21);
            this.usefulLifeTextBox.TabIndex = 7;
            // 
            // vendorLookUpEdit
            // 
            this.vendorLookUpEdit.DataBindings.Add(new System.Windows.Forms.Binding("EditValue", this.assetDetailBindingSource, "Vendor", true));
            this.vendorLookUpEdit.Location = new System.Drawing.Point(122, 73);
            this.vendorLookUpEdit.Name = "vendorLookUpEdit";
            this.vendorLookUpEdit.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.vendorLookUpEdit.Properties.Columns.AddRange(new DevExpress.XtraEditors.Controls.LookUpColumnInfo[] {
            new DevExpress.XtraEditors.Controls.LookUpColumnInfo("ItemName", "Vendor", 62, DevExpress.Utils.FormatType.None, "", true, DevExpress.Utils.HorzAlignment.Near)});
            this.vendorLookUpEdit.Properties.DataSource = this.vendorBindingSource;
            this.vendorLookUpEdit.Properties.DisplayMember = "ItemName";
            this.vendorLookUpEdit.Properties.NullText = "[Select Vendor]";
            this.vendorLookUpEdit.Properties.ValueMember = "LookupItemId";
            this.vendorLookUpEdit.Size = new System.Drawing.Size(208, 20);
            this.vendorLookUpEdit.TabIndex = 5;
            // 
            // vendorBindingSource
            // 
            this.vendorBindingSource.DataSource = typeof(ClearOffice.FixedAsset.DataAccess.LookupItem);
            // 
            // purchaseDateDateEdit
            // 
            this.purchaseDateDateEdit.DataBindings.Add(new System.Windows.Forms.Binding("EditValue", this.assetDetailBindingSource, "PurchaseDate", true));
            this.purchaseDateDateEdit.EditValue = null;
            this.purchaseDateDateEdit.Enabled = false;
            this.purchaseDateDateEdit.Location = new System.Drawing.Point(122, 47);
            this.purchaseDateDateEdit.Name = "purchaseDateDateEdit";
            this.purchaseDateDateEdit.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.purchaseDateDateEdit.Properties.VistaTimeProperties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton()});
            this.purchaseDateDateEdit.Size = new System.Drawing.Size(208, 20);
            this.purchaseDateDateEdit.TabIndex = 3;
            // 
            // documentNumberTextBox
            // 
            this.documentNumberTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.assetDetailBindingSource, "DocumentNumber", true));
            this.documentNumberTextBox.Location = new System.Drawing.Point(122, 20);
            this.documentNumberTextBox.Name = "documentNumberTextBox";
            this.documentNumberTextBox.Size = new System.Drawing.Size(208, 21);
            this.documentNumberTextBox.TabIndex = 1;
            // 
            // vendorsbindingSource
            // 
            this.vendorsbindingSource.DataSource = typeof(ClearOffice.FixedAsset.DataAccess.LookupItem);
            // 
            // catagoryBindingSource
            // 
            this.catagoryBindingSource.DataSource = typeof(ClearOffice.FixedAsset.DataAccess.AssetCategory);
            // 
            // assetStatusBindingSource
            // 
            this.assetStatusBindingSource.DataSource = typeof(ClearOffice.FixedAsset.DataAccess.LookupItem);
            // 
            // costCenterBindingSource
            // 
            this.costCenterBindingSource.DataSource = typeof(ClearOffice.FixedAsset.DataAccess.LookupItem);
            // 
            // groupBindingSource
            // 
            this.groupBindingSource.DataSource = typeof(ClearOffice.FixedAsset.DataAccess.LookupItem);
            // 
            // assetErrorProvider
            // 
            this.assetErrorProvider.ContainerControl = this;
            // 
            // locationBindingSource
            // 
            this.locationBindingSource.DataSource = typeof(ClearOffice.FixedAsset.DataAccess.LookupItem);
            // 
            // assetNumberTextBox
            // 
            this.assetNumberTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.assetDetailBindingSource, "AssetNumber", true));
            this.assetNumberTextBox.Location = new System.Drawing.Point(98, 20);
            this.assetNumberTextBox.Name = "assetNumberTextBox";
            this.assetNumberTextBox.Size = new System.Drawing.Size(264, 21);
            this.assetNumberTextBox.TabIndex = 0;
            // 
            // costCenterIdLookUpEdit
            // 
            this.costCenterIdLookUpEdit.DataBindings.Add(new System.Windows.Forms.Binding("EditValue", this.assetDetailBindingSource, "CostCenterId", true));
            this.costCenterIdLookUpEdit.Location = new System.Drawing.Point(98, 99);
            this.costCenterIdLookUpEdit.Name = "costCenterIdLookUpEdit";
            this.costCenterIdLookUpEdit.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.costCenterIdLookUpEdit.Properties.Columns.AddRange(new DevExpress.XtraEditors.Controls.LookUpColumnInfo[] {
            new DevExpress.XtraEditors.Controls.LookUpColumnInfo("ItemName", "Cost Center", 62, DevExpress.Utils.FormatType.None, "", true, DevExpress.Utils.HorzAlignment.Near)});
            this.costCenterIdLookUpEdit.Properties.DataSource = this.costCenterBindingSource;
            this.costCenterIdLookUpEdit.Properties.DisplayMember = "ItemName";
            this.costCenterIdLookUpEdit.Properties.NullText = "[Select Cost Center]";
            this.costCenterIdLookUpEdit.Properties.ValueMember = "LookupItemId";
            this.costCenterIdLookUpEdit.Size = new System.Drawing.Size(264, 20);
            this.costCenterIdLookUpEdit.TabIndex = 7;
            // 
            // locationIdLookUpEdit
            // 
            this.locationIdLookUpEdit.DataBindings.Add(new System.Windows.Forms.Binding("EditValue", this.assetDetailBindingSource, "LocationId", true));
            this.locationIdLookUpEdit.Location = new System.Drawing.Point(98, 125);
            this.locationIdLookUpEdit.Name = "locationIdLookUpEdit";
            this.locationIdLookUpEdit.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.locationIdLookUpEdit.Properties.Columns.AddRange(new DevExpress.XtraEditors.Controls.LookUpColumnInfo[] {
            new DevExpress.XtraEditors.Controls.LookUpColumnInfo("ItemName", "Location", 62, DevExpress.Utils.FormatType.None, "", true, DevExpress.Utils.HorzAlignment.Near)});
            this.locationIdLookUpEdit.Properties.DataSource = this.locationBindingSource;
            this.locationIdLookUpEdit.Properties.DisplayMember = "ItemName";
            this.locationIdLookUpEdit.Properties.NullText = "[Select Location]";
            this.locationIdLookUpEdit.Properties.ValueMember = "LookupItemId";
            this.locationIdLookUpEdit.Size = new System.Drawing.Size(264, 20);
            this.locationIdLookUpEdit.TabIndex = 9;
            // 
            // linkDispoInfo
            // 
            this.linkDispoInfo.AutoSize = true;
            this.linkDispoInfo.Location = new System.Drawing.Point(328, 154);
            this.linkDispoInfo.Name = "linkDispoInfo";
            this.linkDispoInfo.Size = new System.Drawing.Size(34, 13);
            this.linkDispoInfo.TabIndex = 11;
            this.linkDispoInfo.TabStop = true;
            this.linkDispoInfo.Text = "Detail";
            this.linkDispoInfo.Visible = false;
            this.linkDispoInfo.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.linkDispoInfo_LinkClicked);
            // 
            // statusLookUpEdit
            // 
            this.statusLookUpEdit.DataBindings.Add(new System.Windows.Forms.Binding("EditValue", this.assetDetailBindingSource, "Status", true));
            this.statusLookUpEdit.Enabled = false;
            this.statusLookUpEdit.Location = new System.Drawing.Point(98, 151);
            this.statusLookUpEdit.Name = "statusLookUpEdit";
            this.statusLookUpEdit.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.statusLookUpEdit.Properties.DataSource = this.assetStatusBindingSource;
            this.statusLookUpEdit.Properties.DisplayMember = "ItemName";
            this.statusLookUpEdit.Properties.NullText = "[Status]";
            this.statusLookUpEdit.Properties.ValueMember = "LookupItemId";
            this.statusLookUpEdit.Size = new System.Drawing.Size(224, 20);
            this.statusLookUpEdit.TabIndex = 13;
            // 
            // categoryLookUpEdit
            // 
            this.categoryLookUpEdit.DataBindings.Add(new System.Windows.Forms.Binding("EditValue", this.assetDetailBindingSource, "Category", true));
            this.categoryLookUpEdit.Location = new System.Drawing.Point(98, 47);
            this.categoryLookUpEdit.Name = "categoryLookUpEdit";
            this.categoryLookUpEdit.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.categoryLookUpEdit.Properties.Columns.AddRange(new DevExpress.XtraEditors.Controls.LookUpColumnInfo[] {
            new DevExpress.XtraEditors.Controls.LookUpColumnInfo("CategoryName", "Category ", 85, DevExpress.Utils.FormatType.None, "", true, DevExpress.Utils.HorzAlignment.Near),
            new DevExpress.XtraEditors.Controls.LookUpColumnInfo("DepreciationRate", "Rate", 96, DevExpress.Utils.FormatType.None, "", true, DevExpress.Utils.HorzAlignment.Near)});
            this.categoryLookUpEdit.Properties.DataSource = this.catagoryBindingSource;
            this.categoryLookUpEdit.Properties.DisplayMember = "CategoryName";
            this.categoryLookUpEdit.Properties.NullText = "[Select Category]";
            this.categoryLookUpEdit.Properties.ValueMember = "CategoryId";
            this.categoryLookUpEdit.Size = new System.Drawing.Size(264, 20);
            this.categoryLookUpEdit.TabIndex = 14;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(groupIdLabel);
            this.groupBox1.Controls.Add(this.groupIdLookUpEdit);
            this.groupBox1.Controls.Add(categoryLabel);
            this.groupBox1.Controls.Add(this.categoryLookUpEdit);
            this.groupBox1.Controls.Add(statusLabel);
            this.groupBox1.Controls.Add(this.statusLookUpEdit);
            this.groupBox1.Controls.Add(this.linkDispoInfo);
            this.groupBox1.Controls.Add(locationIdLabel);
            this.groupBox1.Controls.Add(this.locationIdLookUpEdit);
            this.groupBox1.Controls.Add(costCenterIdLabel);
            this.groupBox1.Controls.Add(this.costCenterIdLookUpEdit);
            this.groupBox1.Controls.Add(assetNumberLabel);
            this.groupBox1.Controls.Add(this.assetNumberTextBox);
            this.groupBox1.Location = new System.Drawing.Point(8, 7);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(386, 184);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Basic Information";
            // 
            // groupIdLookUpEdit
            // 
            this.groupIdLookUpEdit.DataBindings.Add(new System.Windows.Forms.Binding("EditValue", this.assetDetailBindingSource, "GroupId", true));
            this.groupIdLookUpEdit.Location = new System.Drawing.Point(98, 73);
            this.groupIdLookUpEdit.Name = "groupIdLookUpEdit";
            this.groupIdLookUpEdit.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.groupIdLookUpEdit.Properties.Columns.AddRange(new DevExpress.XtraEditors.Controls.LookUpColumnInfo[] {
            new DevExpress.XtraEditors.Controls.LookUpColumnInfo("ItemName", "Group", 62, DevExpress.Utils.FormatType.None, "", true, DevExpress.Utils.HorzAlignment.Near)});
            this.groupIdLookUpEdit.Properties.DataSource = this.groupBindingSource;
            this.groupIdLookUpEdit.Properties.DisplayMember = "ItemName";
            this.groupIdLookUpEdit.Properties.NullText = "[Select Group]";
            this.groupIdLookUpEdit.Properties.ValueMember = "LookupItemId";
            this.groupIdLookUpEdit.Size = new System.Drawing.Size(264, 20);
            this.groupIdLookUpEdit.TabIndex = 17;
            // 
            // ribbonControl1
            // 
            this.ribbonControl1.ApplicationButtonText = null;
            this.ribbonControl1.ExpandCollapseItem.Id = 0;
            this.ribbonControl1.Images = this.smallImageCollection;
            this.ribbonControl1.Items.AddRange(new DevExpress.XtraBars.BarItem[] {
            this.ribbonControl1.ExpandCollapseItem,
            this.saveAssetBarButtonItem,
            this.deleteAssetBarButtonItem,
            this.calculateDepreciationBarButtonItem,
            this.disposeAssetBarButtonItem,
            this.returnBarButtonItem,
            this.transferAssetBarButtonItem});
            this.ribbonControl1.LargeImages = this.largeImageCollection;
            this.ribbonControl1.Location = new System.Drawing.Point(0, 0);
            this.ribbonControl1.MaxItemId = 9;
            this.ribbonControl1.MdiMergeStyle = DevExpress.XtraBars.Ribbon.RibbonMdiMergeStyle.Always;
            this.ribbonControl1.Name = "ribbonControl1";
            this.ribbonControl1.Pages.AddRange(new DevExpress.XtraBars.Ribbon.RibbonPage[] {
            this.ribbonPage1});
            this.ribbonControl1.Size = new System.Drawing.Size(904, 142);
            // 
            // smallImageCollection
            // 
            this.smallImageCollection.ImageStream = ((DevExpress.Utils.ImageCollectionStreamer)(resources.GetObject("smallImageCollection.ImageStream")));
            this.smallImageCollection.Images.SetKeyName(0, "user-trash.png");
            this.smallImageCollection.Images.SetKeyName(1, "undo-16x16.png");
            this.smallImageCollection.Images.SetKeyName(2, "Cascade_16x16.png");
            // 
            // saveAssetBarButtonItem
            // 
            this.saveAssetBarButtonItem.Caption = "Save";
            this.saveAssetBarButtonItem.Id = 1;
            this.saveAssetBarButtonItem.LargeImageIndex = 0;
            this.saveAssetBarButtonItem.Name = "saveAssetBarButtonItem";
            this.saveAssetBarButtonItem.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.saveAssetBarButtonItem_ItemClick);
            // 
            // deleteAssetBarButtonItem
            // 
            this.deleteAssetBarButtonItem.Caption = "Delete";
            this.deleteAssetBarButtonItem.Id = 2;
            this.deleteAssetBarButtonItem.LargeImageIndex = 1;
            this.deleteAssetBarButtonItem.Name = "deleteAssetBarButtonItem";
            this.deleteAssetBarButtonItem.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.deleteAssetBarButtonItem_ItemClick);
            // 
            // calculateDepreciationBarButtonItem
            // 
            this.calculateDepreciationBarButtonItem.Caption = "Calculate Depreciation";
            this.calculateDepreciationBarButtonItem.Id = 3;
            this.calculateDepreciationBarButtonItem.LargeImageIndex = 2;
            this.calculateDepreciationBarButtonItem.Name = "calculateDepreciationBarButtonItem";
            this.calculateDepreciationBarButtonItem.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.calculateDepreciationBarButtonItem_ItemClick);
            // 
            // disposeAssetBarButtonItem
            // 
            this.disposeAssetBarButtonItem.Caption = "Dispose";
            this.disposeAssetBarButtonItem.Id = 4;
            this.disposeAssetBarButtonItem.ImageIndex = 0;
            this.disposeAssetBarButtonItem.Name = "disposeAssetBarButtonItem";
            this.disposeAssetBarButtonItem.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.disposeAssetBarButtonItem_ItemClick);
            // 
            // returnBarButtonItem
            // 
            this.returnBarButtonItem.Caption = "Return";
            this.returnBarButtonItem.Id = 6;
            this.returnBarButtonItem.ImageIndex = 1;
            this.returnBarButtonItem.Name = "returnBarButtonItem";
            this.returnBarButtonItem.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.returnBarButtonItem_ItemClick);
            // 
            // transferAssetBarButtonItem
            // 
            this.transferAssetBarButtonItem.Caption = "Transfer";
            this.transferAssetBarButtonItem.Id = 7;
            this.transferAssetBarButtonItem.ImageIndex = 2;
            this.transferAssetBarButtonItem.Name = "transferAssetBarButtonItem";
            this.transferAssetBarButtonItem.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.transferAssetBarButtonItem_ItemClick);
            // 
            // largeImageCollection
            // 
            this.largeImageCollection.ImageSize = new System.Drawing.Size(32, 32);
            this.largeImageCollection.ImageStream = ((DevExpress.Utils.ImageCollectionStreamer)(resources.GetObject("largeImageCollection.ImageStream")));
            this.largeImageCollection.Images.SetKeyName(0, "save-32x32.png");
            this.largeImageCollection.Images.SetKeyName(1, "Delete_32x32.png");
            this.largeImageCollection.Images.SetKeyName(2, "appointment-new.png");
            // 
            // ribbonPage1
            // 
            this.ribbonPage1.Groups.AddRange(new DevExpress.XtraBars.Ribbon.RibbonPageGroup[] {
            this.ribbonPageGroup1});
            this.ribbonPage1.Name = "ribbonPage1";
            this.ribbonPage1.Text = "Fixed Asset";
            // 
            // ribbonPageGroup1
            // 
            this.ribbonPageGroup1.ItemLinks.Add(this.saveAssetBarButtonItem);
            this.ribbonPageGroup1.ItemLinks.Add(this.deleteAssetBarButtonItem);
            this.ribbonPageGroup1.ItemLinks.Add(this.calculateDepreciationBarButtonItem);
            this.ribbonPageGroup1.ItemLinks.Add(this.transferAssetBarButtonItem);
            this.ribbonPageGroup1.ItemLinks.Add(this.returnBarButtonItem);
            this.ribbonPageGroup1.ItemLinks.Add(this.disposeAssetBarButtonItem);
            this.ribbonPageGroup1.Name = "ribbonPageGroup1";
            this.ribbonPageGroup1.Text = "Asset Detail";
            // 
            // barButtonItem2
            // 
            this.barButtonItem2.Caption = "barButtonItem2";
            this.barButtonItem2.Id = 5;
            this.barButtonItem2.Name = "barButtonItem2";
            // 
            // assetPanel
            // 
            this.assetPanel.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.assetPanel.Controls.Add(this.groupBox1);
            this.assetPanel.Controls.Add(this.groupBox3);
            this.assetPanel.Controls.Add(this.xtraTabControl1);
            this.assetPanel.Controls.Add(this.groupBox2);
            this.assetPanel.Location = new System.Drawing.Point(5, 146);
            this.assetPanel.Margin = new System.Windows.Forms.Padding(5);
            this.assetPanel.Name = "assetPanel";
            this.assetPanel.Size = new System.Drawing.Size(893, 424);
            this.assetPanel.TabIndex = 0;
            // 
            // AssetDetail
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(904, 576);
            this.Controls.Add(this.assetPanel);
            this.Controls.Add(this.ribbonControl1);
            this.Name = "AssetDetail";
            this.Text = "Asset Detail";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Activated += new System.EventHandler(this.AssetDetail_Activated);
            ((System.ComponentModel.ISupportInitialize)(this.assetDetailBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.xtraTabControl1)).EndInit();
            this.xtraTabControl1.ResumeLayout(false);
            this.xtraTabPage1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.imagePictureEdit.Properties)).EndInit();
            this.xtraTabPage2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.gridControl1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.custodianAssetBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemLookUpEdit1)).EndInit();
            this.xtraTabPage3.ResumeLayout(false);
            this.xtraTabPage3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gridControl2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.adjustementBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.adjustementGridView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.adjTypeRepository)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.adjustementTypeBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.statusRepositoryItem)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.adjustStatusBindingSource)).EndInit();
            this.toolStrip2.ResumeLayout(false);
            this.toolStrip2.PerformLayout();
            this.xtraTabPage4.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.gridControl3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.deperciationBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView2)).EndInit();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.depreciationMethodLookUpEdit.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.depreciationMethodBindingSource)).EndInit();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.physicalConditionLookUpEdit.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.physicalConditionBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.vendorLookUpEdit.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.vendorBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.purchaseDateDateEdit.Properties.VistaTimeProperties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.purchaseDateDateEdit.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.vendorsbindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.catagoryBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.assetStatusBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.costCenterBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.groupBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.assetErrorProvider)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.locationBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.costCenterIdLookUpEdit.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.locationIdLookUpEdit.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.statusLookUpEdit.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.categoryLookUpEdit.Properties)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.groupIdLookUpEdit.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ribbonControl1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.smallImageCollection)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.largeImageCollection)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.assetPanel)).EndInit();
            this.assetPanel.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.BindingSource assetDetailBindingSource;
        private DevExpress.XtraTab.XtraTabControl xtraTabControl1;
        private DevExpress.XtraTab.XtraTabPage xtraTabPage1;
        private DevExpress.XtraTab.XtraTabPage xtraTabPage2;
        private DevExpress.XtraTab.XtraTabPage xtraTabPage3;
        private DevExpress.XtraTab.XtraTabPage xtraTabPage4;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.TextBox txtCurrentBookvalue;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtDeperToDate;
        private System.Windows.Forms.Label label1;
        private DevExpress.XtraEditors.LookUpEdit depreciationMethodLookUpEdit;
        private System.Windows.Forms.GroupBox groupBox2;
        private DevExpress.XtraEditors.LookUpEdit physicalConditionLookUpEdit;
        private System.Windows.Forms.TextBox assetValueTextBox;
        private System.Windows.Forms.TextBox usefulLifeTextBox;
        private DevExpress.XtraEditors.LookUpEdit vendorLookUpEdit;
        private DevExpress.XtraEditors.DateEdit purchaseDateDateEdit;
        private System.Windows.Forms.TextBox documentNumberTextBox;
        private DevExpress.XtraGrid.GridControl gridControl1;
        private DevExpress.XtraGrid.Views.Grid.GridView gridView1;
        private DevExpress.XtraGrid.GridControl gridControl2;
        private DevExpress.XtraGrid.Views.Grid.GridView adjustementGridView;
        private System.Windows.Forms.ToolStrip toolStrip2;
        private System.Windows.Forms.ToolStripButton btnNewAdj;
        private System.Windows.Forms.ToolStripButton btnDeleteAdj;
        private DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit repositoryItemLookUpEdit1;
        private System.Windows.Forms.BindingSource vendorBindingSource;
        private System.Windows.Forms.ErrorProvider assetErrorProvider;
        private System.Windows.Forms.BindingSource adjustStatusBindingSource;
        private DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit adjTypeRepository;
        private DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit statusRepositoryItem;
        private System.Windows.Forms.ToolStripButton btnPostAdj;
        private System.Windows.Forms.BindingSource catagoryBindingSource;
        private System.Windows.Forms.BindingSource groupBindingSource;
        private System.Windows.Forms.BindingSource costCenterBindingSource;
        private System.Windows.Forms.BindingSource physicalConditionBindingSource;
        private System.Windows.Forms.BindingSource depreciationMethodBindingSource;
        private System.Windows.Forms.BindingSource locationBindingSource;
        private System.Windows.Forms.BindingSource adjustementBindingSource;
        private DevExpress.XtraGrid.Columns.GridColumn colDocumentNumber;
        private DevExpress.XtraGrid.Columns.GridColumn colDocumentDate;
        private DevExpress.XtraGrid.Columns.GridColumn colFiscalPeriod;
        private DevExpress.XtraGrid.Columns.GridColumn colFiscalYear;
        private DevExpress.XtraGrid.Columns.GridColumn colPreviousValue;
        private DevExpress.XtraGrid.Columns.GridColumn colAdjustedValue;
        private DevExpress.XtraGrid.Columns.GridColumn AdjustType;
        private DevExpress.XtraGrid.Columns.GridColumn AdjustStatus;
        private System.Windows.Forms.BindingSource adjustementTypeBindingSource;
        private System.Windows.Forms.BindingSource custodianAssetBindingSource;
        private System.Windows.Forms.BindingSource assetStatusBindingSource;
        private DevExpress.XtraGrid.GridControl gridControl3;
        private DevExpress.XtraGrid.Views.Grid.GridView gridView2;
        private System.Windows.Forms.BindingSource deperciationBindingSource;
        private DevExpress.XtraGrid.Columns.GridColumn colFiscalyear1;
        private DevExpress.XtraGrid.Columns.GridColumn colBookValueAtBeginningOfYear;
        private DevExpress.XtraGrid.Columns.GridColumn colBookValueAtEndOfYear;
        private DevExpress.XtraGrid.Columns.GridColumn colDepreciationRate;
        private DevExpress.XtraGrid.Columns.GridColumn colDeprecationExpense;
        private DevExpress.XtraGrid.Columns.GridColumn colAccumulatedDepreciation;
        private DevExpress.XtraGrid.Columns.GridColumn colFiscalPeriod1;
        private System.Windows.Forms.TextBox salvageValueTextBox;
        private DevExpress.XtraEditors.PictureEdit imagePictureEdit;
        private System.Windows.Forms.GroupBox groupBox1;
        private DevExpress.XtraEditors.LookUpEdit categoryLookUpEdit;
        private DevExpress.XtraEditors.LookUpEdit statusLookUpEdit;
        private System.Windows.Forms.LinkLabel linkDispoInfo;
        private DevExpress.XtraEditors.LookUpEdit locationIdLookUpEdit;
        private DevExpress.XtraEditors.LookUpEdit costCenterIdLookUpEdit;
        private System.Windows.Forms.TextBox assetNumberTextBox;
        private System.Windows.Forms.BindingSource vendorsbindingSource;
        private DevExpress.XtraGrid.Columns.GridColumn colDateFrom;
        private DevExpress.XtraGrid.Columns.GridColumn colDateTo;
        private DevExpress.XtraGrid.Columns.GridColumn colBadgeNo;
        private DevExpress.XtraGrid.Columns.GridColumn colFirstName;
        private DevExpress.XtraGrid.Columns.GridColumn colLastName;
        private DevExpress.XtraGrid.Columns.GridColumn colItemName;
        private System.Windows.Forms.TextBox descriptionTextBox;
        private DevExpress.XtraEditors.LookUpEdit groupIdLookUpEdit;
        private DevExpress.XtraBars.Ribbon.RibbonControl ribbonControl1;
        private DevExpress.XtraBars.Ribbon.RibbonPage ribbonPage1;
        private DevExpress.XtraBars.Ribbon.RibbonPageGroup ribbonPageGroup1;
        private DevExpress.XtraBars.BarButtonItem saveAssetBarButtonItem;
        private DevExpress.Utils.ImageCollection largeImageCollection;
        private DevExpress.Utils.ImageCollection smallImageCollection;
        private DevExpress.XtraBars.BarButtonItem deleteAssetBarButtonItem;
        private DevExpress.XtraBars.BarButtonItem calculateDepreciationBarButtonItem;
        private DevExpress.XtraBars.BarButtonItem disposeAssetBarButtonItem;
        private DevExpress.XtraBars.BarButtonItem returnBarButtonItem;
        private DevExpress.XtraBars.BarButtonItem transferAssetBarButtonItem;
        private DevExpress.XtraBars.BarButtonItem barButtonItem2;
        private DevExpress.XtraEditors.PanelControl assetPanel;
    }
}