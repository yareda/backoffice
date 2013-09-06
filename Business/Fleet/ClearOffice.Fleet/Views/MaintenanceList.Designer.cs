namespace ClearOffice.Fleet.Views
{
    partial class MaintenanceList
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MaintenanceList));
            this.gridControl1 = new DevExpress.XtraGrid.GridControl();
            this.maintenanceListBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.gridView1 = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.colPlateNumber = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colServiceRequestNo = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colCreationDate = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colCompletionDate = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colTotalPartPrice = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colTotalActivityPrice = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colTotalExpenseAmount = new DevExpress.XtraGrid.Columns.GridColumn();
            this.totalCostGridColumn = new DevExpress.XtraGrid.Columns.GridColumn();
            this.ribbonControl1 = new DevExpress.XtraBars.Ribbon.RibbonControl();
            this.smallImageCollection = new DevExpress.Utils.ImageCollection(this.components);
            this.newMaintenanceBarButtonItem = new DevExpress.XtraBars.BarButtonItem();
            this.refreshListBarButtonItem = new DevExpress.XtraBars.BarButtonItem();
            this.largeImageCollection = new DevExpress.Utils.ImageCollection(this.components);
            this.ribbonPage1 = new DevExpress.XtraBars.Ribbon.RibbonPage();
            this.ribbonPageGroup1 = new DevExpress.XtraBars.Ribbon.RibbonPageGroup();
            ((System.ComponentModel.ISupportInitialize)(this.gridControl1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.maintenanceListBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ribbonControl1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.smallImageCollection)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.largeImageCollection)).BeginInit();
            this.SuspendLayout();
            // 
            // gridControl1
            // 
            this.gridControl1.DataSource = this.maintenanceListBindingSource;
            this.gridControl1.Location = new System.Drawing.Point(0, 138);
            this.gridControl1.MainView = this.gridView1;
            this.gridControl1.Name = "gridControl1";
            this.gridControl1.Size = new System.Drawing.Size(678, 329);
            this.gridControl1.TabIndex = 0;
            this.gridControl1.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridView1});
            this.gridControl1.DoubleClick += new System.EventHandler(this.gridControl1_DoubleClick);
            // 
            // maintenanceListBindingSource
            // 
            this.maintenanceListBindingSource.DataSource = typeof(ClearOffice.Fleet.Business.MaintenanceInfo);
            // 
            // gridView1
            // 
            this.gridView1.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.colPlateNumber,
            this.colServiceRequestNo,
            this.colCreationDate,
            this.colCompletionDate,
            this.colTotalPartPrice,
            this.colTotalActivityPrice,
            this.colTotalExpenseAmount,
            this.totalCostGridColumn});
            this.gridView1.GridControl = this.gridControl1;
            this.gridView1.Name = "gridView1";
            this.gridView1.OptionsBehavior.Editable = false;
            this.gridView1.OptionsView.ShowAutoFilterRow = true;
            this.gridView1.OptionsView.ShowGroupPanel = false;
            // 
            // colPlateNumber
            // 
            this.colPlateNumber.FieldName = "PlateNumber";
            this.colPlateNumber.Name = "colPlateNumber";
            this.colPlateNumber.Visible = true;
            this.colPlateNumber.VisibleIndex = 0;
            // 
            // colServiceRequestNo
            // 
            this.colServiceRequestNo.FieldName = "ServiceRequestNo";
            this.colServiceRequestNo.Name = "colServiceRequestNo";
            this.colServiceRequestNo.Visible = true;
            this.colServiceRequestNo.VisibleIndex = 1;
            // 
            // colCreationDate
            // 
            this.colCreationDate.Caption = "Start Date";
            this.colCreationDate.FieldName = "CreationDate";
            this.colCreationDate.Name = "colCreationDate";
            this.colCreationDate.Visible = true;
            this.colCreationDate.VisibleIndex = 2;
            // 
            // colCompletionDate
            // 
            this.colCompletionDate.FieldName = "CompletionDate";
            this.colCompletionDate.Name = "colCompletionDate";
            this.colCompletionDate.Visible = true;
            this.colCompletionDate.VisibleIndex = 3;
            // 
            // colTotalPartPrice
            // 
            this.colTotalPartPrice.Caption = "Part Cost";
            this.colTotalPartPrice.DisplayFormat.FormatString = "{0:#,##0.00;(#,##0.00);\'\'}";
            this.colTotalPartPrice.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Custom;
            this.colTotalPartPrice.FieldName = "TotalPartPrice";
            this.colTotalPartPrice.Name = "colTotalPartPrice";
            this.colTotalPartPrice.Visible = true;
            this.colTotalPartPrice.VisibleIndex = 4;
            // 
            // colTotalActivityPrice
            // 
            this.colTotalActivityPrice.Caption = "Activity/Task Cost";
            this.colTotalActivityPrice.DisplayFormat.FormatString = "{0:#,##0.00;(#,##0.00);\'\'}";
            this.colTotalActivityPrice.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Custom;
            this.colTotalActivityPrice.FieldName = "TotalActivityPrice";
            this.colTotalActivityPrice.Name = "colTotalActivityPrice";
            this.colTotalActivityPrice.Visible = true;
            this.colTotalActivityPrice.VisibleIndex = 5;
            // 
            // colTotalExpenseAmount
            // 
            this.colTotalExpenseAmount.Caption = "Other Expense";
            this.colTotalExpenseAmount.DisplayFormat.FormatString = "{0:#,##0.00;(#,##0.00);\'\'}";
            this.colTotalExpenseAmount.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Custom;
            this.colTotalExpenseAmount.FieldName = "TotalExpenseAmount";
            this.colTotalExpenseAmount.Name = "colTotalExpenseAmount";
            this.colTotalExpenseAmount.Visible = true;
            this.colTotalExpenseAmount.VisibleIndex = 6;
            // 
            // totalCostGridColumn
            // 
            this.totalCostGridColumn.Caption = "Total Cost";
            this.totalCostGridColumn.DisplayFormat.FormatString = "{0:#,##0.00;(#,##0.00);\'\'}";
            this.totalCostGridColumn.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Custom;
            this.totalCostGridColumn.FieldName = "totalCostGridColumn";
            this.totalCostGridColumn.Name = "totalCostGridColumn";
            this.totalCostGridColumn.UnboundExpression = "[TotalActivityPrice] + [TotalExpenseAmount] + [TotalPartPrice]";
            this.totalCostGridColumn.UnboundType = DevExpress.Data.UnboundColumnType.Decimal;
            this.totalCostGridColumn.Visible = true;
            this.totalCostGridColumn.VisibleIndex = 7;
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
            this.newMaintenanceBarButtonItem,
            this.refreshListBarButtonItem});
            this.ribbonControl1.LargeImages = this.largeImageCollection;
            this.ribbonControl1.Location = new System.Drawing.Point(0, 0);
            this.ribbonControl1.MaxItemId = 4;
            this.ribbonControl1.Name = "ribbonControl1";
            this.ribbonControl1.Pages.AddRange(new DevExpress.XtraBars.Ribbon.RibbonPage[] {
            this.ribbonPage1});
            this.ribbonControl1.SelectedPage = this.ribbonPage1;
            this.ribbonControl1.Size = new System.Drawing.Size(678, 143);            
            // 
            // smallImageCollection
            // 
            this.smallImageCollection.ImageStream = ((DevExpress.Utils.ImageCollectionStreamer)(resources.GetObject("smallImageCollection.ImageStream")));
            this.smallImageCollection.Images.SetKeyName(0, "Refresh_16x16.png");
            this.smallImageCollection.Images.SetKeyName(1, "time_add.png");
            // 
            // newMaintenanceBarButtonItem
            // 
            this.newMaintenanceBarButtonItem.Caption = "New";
            this.newMaintenanceBarButtonItem.Id = 2;
            this.newMaintenanceBarButtonItem.ImageIndex = 1;
            this.newMaintenanceBarButtonItem.Name = "newMaintenanceBarButtonItem";
            this.newMaintenanceBarButtonItem.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.newMaintenanceBarButtonItem_ItemClick);
            // 
            // refreshListBarButtonItem
            // 
            this.refreshListBarButtonItem.Caption = "Refresh";
            this.refreshListBarButtonItem.Id = 3;
            this.refreshListBarButtonItem.ImageIndex = 0;
            this.refreshListBarButtonItem.Name = "refreshListBarButtonItem";
            this.refreshListBarButtonItem.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.refreshListBarButtonItem_ItemClick);
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
            this.ribbonPageGroup1.ItemLinks.Add(this.newMaintenanceBarButtonItem);
            this.ribbonPageGroup1.ItemLinks.Add(this.refreshListBarButtonItem);
            this.ribbonPageGroup1.Name = "ribbonPageGroup1";
            this.ribbonPageGroup1.Text = "Maintenance";
            // 
            // MaintenanceList
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(678, 467);
            this.Controls.Add(this.ribbonControl1);
            this.Controls.Add(this.gridControl1);
            this.Name = "MaintenanceList";
            this.Text = "Vehicle Maintenance History";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Activated += new System.EventHandler(this.MaintenanceList_Activated);
            ((System.ComponentModel.ISupportInitialize)(this.gridControl1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.maintenanceListBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ribbonControl1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.smallImageCollection)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.largeImageCollection)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraGrid.GridControl gridControl1;
        private DevExpress.XtraGrid.Views.Grid.GridView gridView1;
        private System.Windows.Forms.BindingSource maintenanceListBindingSource;
        private DevExpress.XtraGrid.Columns.GridColumn colPlateNumber;
        private DevExpress.XtraGrid.Columns.GridColumn colServiceRequestNo;
        private DevExpress.XtraGrid.Columns.GridColumn colCreationDate;
        private DevExpress.XtraGrid.Columns.GridColumn colCompletionDate;
        private DevExpress.XtraGrid.Columns.GridColumn colTotalPartPrice;
        private DevExpress.XtraGrid.Columns.GridColumn colTotalActivityPrice;
        private DevExpress.XtraGrid.Columns.GridColumn colTotalExpenseAmount;
        private DevExpress.XtraGrid.Columns.GridColumn totalCostGridColumn;
        private DevExpress.XtraBars.Ribbon.RibbonControl ribbonControl1;
        private DevExpress.XtraBars.Ribbon.RibbonPage ribbonPage1;
        private DevExpress.XtraBars.Ribbon.RibbonPageGroup ribbonPageGroup1;
        private DevExpress.Utils.ImageCollection smallImageCollection;
        private DevExpress.Utils.ImageCollection largeImageCollection;
        private DevExpress.XtraBars.BarButtonItem newMaintenanceBarButtonItem;
        private DevExpress.XtraBars.BarButtonItem refreshListBarButtonItem;
    }
}