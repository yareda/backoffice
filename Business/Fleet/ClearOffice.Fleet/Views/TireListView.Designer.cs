namespace ClearOffice.Fleet.Views
{
    partial class TireListView
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(TireListView));
            this.ribbonControl1 = new DevExpress.XtraBars.Ribbon.RibbonControl();
            this.smallImageCollection = new DevExpress.Utils.ImageCollection(this.components);
            this.newTireBarButtonItem = new DevExpress.XtraBars.BarButtonItem();
            this.refreshListBarButtonItem = new DevExpress.XtraBars.BarButtonItem();
            this.largeImageCollection = new DevExpress.Utils.ImageCollection(this.components);
            this.ribbonPage1 = new DevExpress.XtraBars.Ribbon.RibbonPage();
            this.ribbonPageGroup1 = new DevExpress.XtraBars.Ribbon.RibbonPageGroup();
            this.gridControl1 = new DevExpress.XtraGrid.GridControl();
            this.tiresBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.gridView1 = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.colSerialNo = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colPurchasedDate = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colSizeName = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colTypeName = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colBrandName = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colVendorName = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colStatusName = new DevExpress.XtraGrid.Columns.GridColumn();
            ((System.ComponentModel.ISupportInitialize)(this.ribbonControl1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.smallImageCollection)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.largeImageCollection)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridControl1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tiresBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).BeginInit();
            this.SuspendLayout();
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
            this.newTireBarButtonItem,
            this.refreshListBarButtonItem});
            this.ribbonControl1.LargeImages = this.largeImageCollection;
            this.ribbonControl1.Location = new System.Drawing.Point(0, 0);
            this.ribbonControl1.MaxItemId = 3;
            this.ribbonControl1.Name = "ribbonControl1";
            this.ribbonControl1.Pages.AddRange(new DevExpress.XtraBars.Ribbon.RibbonPage[] {
            this.ribbonPage1});
            this.ribbonControl1.SelectedPage = this.ribbonPage1;
            this.ribbonControl1.Size = new System.Drawing.Size(760, 143);
            // 
            // smallImageCollection
            // 
            this.smallImageCollection.ImageStream = ((DevExpress.Utils.ImageCollectionStreamer)(resources.GetObject("smallImageCollection.ImageStream")));
            this.smallImageCollection.Images.SetKeyName(0, "Refresh_16x16.png");
            this.smallImageCollection.Images.SetKeyName(1, "time_add.png");
            this.smallImageCollection.Images.SetKeyName(2, "AddFile_16x16.png");
            // 
            // newTireBarButtonItem
            // 
            this.newTireBarButtonItem.Caption = "New Tire";
            this.newTireBarButtonItem.Id = 1;
            this.newTireBarButtonItem.ImageIndex = 2;
            this.newTireBarButtonItem.Name = "newTireBarButtonItem";
            this.newTireBarButtonItem.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.newTireBarButtonItem_ItemClick);
            // 
            // refreshListBarButtonItem
            // 
            this.refreshListBarButtonItem.Caption = "Refresh";
            this.refreshListBarButtonItem.Id = 2;
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
            this.ribbonPageGroup1.ItemLinks.Add(this.newTireBarButtonItem);
            this.ribbonPageGroup1.ItemLinks.Add(this.refreshListBarButtonItem);
            this.ribbonPageGroup1.Name = "ribbonPageGroup1";
            this.ribbonPageGroup1.Text = "Tire";
            // 
            // gridControl1
            // 
            this.gridControl1.DataSource = this.tiresBindingSource;
            this.gridControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gridControl1.Location = new System.Drawing.Point(0, 143);
            this.gridControl1.MainView = this.gridView1;
            this.gridControl1.MenuManager = this.ribbonControl1;
            this.gridControl1.Name = "gridControl1";
            this.gridControl1.Size = new System.Drawing.Size(760, 343);
            this.gridControl1.TabIndex = 1;
            this.gridControl1.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridView1});
            this.gridControl1.DoubleClick += new System.EventHandler(this.gridControl1_DoubleClick);
            // 
            // tiresBindingSource
            // 
            this.tiresBindingSource.DataSource = typeof(ClearOffice.Fleet.Business.TireInfo);
            // 
            // gridView1
            // 
            this.gridView1.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.colSerialNo,
            this.colPurchasedDate,
            this.colSizeName,
            this.colTypeName,
            this.colBrandName,
            this.colVendorName,
            this.colStatusName});
            this.gridView1.GridControl = this.gridControl1;
            this.gridView1.Name = "gridView1";
            this.gridView1.OptionsBehavior.Editable = false;
            this.gridView1.OptionsView.ShowAutoFilterRow = true;
            this.gridView1.OptionsView.ShowGroupPanel = false;
            // 
            // colSerialNo
            // 
            this.colSerialNo.FieldName = "SerialNo";
            this.colSerialNo.Name = "colSerialNo";
            this.colSerialNo.Visible = true;
            this.colSerialNo.VisibleIndex = 0;
            // 
            // colPurchasedDate
            // 
            this.colPurchasedDate.FieldName = "PurchasedDate";
            this.colPurchasedDate.Name = "colPurchasedDate";
            this.colPurchasedDate.Visible = true;
            this.colPurchasedDate.VisibleIndex = 1;
            // 
            // colSizeName
            // 
            this.colSizeName.Caption = "Size";
            this.colSizeName.FieldName = "SizeName";
            this.colSizeName.Name = "colSizeName";
            this.colSizeName.Visible = true;
            this.colSizeName.VisibleIndex = 2;
            // 
            // colTypeName
            // 
            this.colTypeName.Caption = "Type";
            this.colTypeName.FieldName = "TypeName";
            this.colTypeName.Name = "colTypeName";
            this.colTypeName.Visible = true;
            this.colTypeName.VisibleIndex = 3;
            // 
            // colBrandName
            // 
            this.colBrandName.Caption = "Brand/Manufacturer";
            this.colBrandName.FieldName = "BrandName";
            this.colBrandName.Name = "colBrandName";
            this.colBrandName.Visible = true;
            this.colBrandName.VisibleIndex = 4;
            // 
            // colVendorName
            // 
            this.colVendorName.Caption = "Vendor";
            this.colVendorName.FieldName = "VendorName";
            this.colVendorName.Name = "colVendorName";
            this.colVendorName.Visible = true;
            this.colVendorName.VisibleIndex = 5;
            // 
            // colStatusName
            // 
            this.colStatusName.Caption = "Status";
            this.colStatusName.FieldName = "StatusName";
            this.colStatusName.Name = "colStatusName";
            this.colStatusName.Visible = true;
            this.colStatusName.VisibleIndex = 6;
            // 
            // TireListView
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(760, 486);
            this.Controls.Add(this.gridControl1);
            this.Controls.Add(this.ribbonControl1);
            this.Name = "TireListView";
            this.Text = "Tire Inventory";
            this.Activated += new System.EventHandler(this.TireListView_Activated);
            ((System.ComponentModel.ISupportInitialize)(this.ribbonControl1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.smallImageCollection)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.largeImageCollection)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridControl1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tiresBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraBars.Ribbon.RibbonControl ribbonControl1;
        private DevExpress.XtraBars.Ribbon.RibbonPage ribbonPage1;
        private DevExpress.XtraBars.Ribbon.RibbonPageGroup ribbonPageGroup1;
        private DevExpress.XtraGrid.GridControl gridControl1;
        private DevExpress.XtraGrid.Views.Grid.GridView gridView1;
        private DevExpress.XtraBars.BarButtonItem newTireBarButtonItem;
        private DevExpress.XtraBars.BarButtonItem refreshListBarButtonItem;
        private DevExpress.Utils.ImageCollection smallImageCollection;
        private DevExpress.Utils.ImageCollection largeImageCollection;
        private System.Windows.Forms.BindingSource tiresBindingSource;
        private DevExpress.XtraGrid.Columns.GridColumn colSerialNo;
        private DevExpress.XtraGrid.Columns.GridColumn colPurchasedDate;
        private DevExpress.XtraGrid.Columns.GridColumn colSizeName;
        private DevExpress.XtraGrid.Columns.GridColumn colTypeName;
        private DevExpress.XtraGrid.Columns.GridColumn colBrandName;
        private DevExpress.XtraGrid.Columns.GridColumn colStatusName;
        private DevExpress.XtraGrid.Columns.GridColumn colVendorName;
    }
}