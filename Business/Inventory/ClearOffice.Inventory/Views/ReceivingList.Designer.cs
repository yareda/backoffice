namespace ClearOffice.Inventory.Views
{
    partial class ReceivingList
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ReceivingList));
            this.ribbonControl1 = new DevExpress.XtraBars.Ribbon.RibbonControl();
            this.smallImageCollection = new DevExpress.Utils.ImageCollection(this.components);
            this.newReceivingBarButtonItem = new DevExpress.XtraBars.BarButtonItem();
            this.refreshBarButtonItem = new DevExpress.XtraBars.BarButtonItem();
            this.largeImageCollection = new DevExpress.Utils.ImageCollection(this.components);
            this.ribbonPage1 = new DevExpress.XtraBars.Ribbon.RibbonPage();
            this.ribbonPageGroup1 = new DevExpress.XtraBars.Ribbon.RibbonPageGroup();
            this.gridControl1 = new DevExpress.XtraGrid.GridControl();
            this.receivingsBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.gridView1 = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.colGRN = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colAirwaybillNo = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colInvoiceNo = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colReceivedBy = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colReceivedDate = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colSupplierName = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colStatusName = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colWarehouseName = new DevExpress.XtraGrid.Columns.GridColumn();
            ((System.ComponentModel.ISupportInitialize)(this.ribbonControl1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.smallImageCollection)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.largeImageCollection)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridControl1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.receivingsBindingSource)).BeginInit();
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
            this.newReceivingBarButtonItem,
            this.refreshBarButtonItem});
            this.ribbonControl1.LargeImages = this.largeImageCollection;
            this.ribbonControl1.Location = new System.Drawing.Point(0, 0);
            this.ribbonControl1.MaxItemId = 3;
            this.ribbonControl1.Name = "ribbonControl1";
            this.ribbonControl1.Pages.AddRange(new DevExpress.XtraBars.Ribbon.RibbonPage[] {
            this.ribbonPage1});
            this.ribbonControl1.SelectedPage = this.ribbonPage1;
            this.ribbonControl1.Size = new System.Drawing.Size(792, 143);
            // 
            // smallImageCollection
            // 
            this.smallImageCollection.ImageStream = ((DevExpress.Utils.ImageCollectionStreamer)(resources.GetObject("smallImageCollection.ImageStream")));
            this.smallImageCollection.Images.SetKeyName(0, "new-16x16.png");
            this.smallImageCollection.Images.SetKeyName(1, "Refresh_16x16.png");
            // 
            // newReceivingBarButtonItem
            // 
            this.newReceivingBarButtonItem.Caption = "New";
            this.newReceivingBarButtonItem.Id = 1;
            this.newReceivingBarButtonItem.LargeImageIndex = 0;
            this.newReceivingBarButtonItem.Name = "newReceivingBarButtonItem";
            this.newReceivingBarButtonItem.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.newReceivingBarButtonItem_ItemClick);
            // 
            // refreshBarButtonItem
            // 
            this.refreshBarButtonItem.Caption = "Refresh";
            this.refreshBarButtonItem.Id = 2;
            this.refreshBarButtonItem.LargeImageIndex = 1;
            this.refreshBarButtonItem.Name = "refreshBarButtonItem";
            this.refreshBarButtonItem.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.refreshBarButtonItem_ItemClick);
            // 
            // largeImageCollection
            // 
            this.largeImageCollection.ImageSize = new System.Drawing.Size(32, 32);
            this.largeImageCollection.ImageStream = ((DevExpress.Utils.ImageCollectionStreamer)(resources.GetObject("largeImageCollection.ImageStream")));
            this.largeImageCollection.Images.SetKeyName(0, "new-32x32.png");
            this.largeImageCollection.Images.SetKeyName(1, "view-refresh.png");
            // 
            // ribbonPage1
            // 
            this.ribbonPage1.Groups.AddRange(new DevExpress.XtraBars.Ribbon.RibbonPageGroup[] {
            this.ribbonPageGroup1});
            this.ribbonPage1.Name = "ribbonPage1";
            this.ribbonPage1.Text = "Inventory";
            // 
            // ribbonPageGroup1
            // 
            this.ribbonPageGroup1.ItemLinks.Add(this.newReceivingBarButtonItem);
            this.ribbonPageGroup1.ItemLinks.Add(this.refreshBarButtonItem);
            this.ribbonPageGroup1.Name = "ribbonPageGroup1";
            this.ribbonPageGroup1.Text = "Transactions";
            // 
            // gridControl1
            // 
            this.gridControl1.DataSource = this.receivingsBindingSource;
            this.gridControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gridControl1.Location = new System.Drawing.Point(0, 143);
            this.gridControl1.MainView = this.gridView1;
            this.gridControl1.MenuManager = this.ribbonControl1;
            this.gridControl1.Name = "gridControl1";
            this.gridControl1.Size = new System.Drawing.Size(792, 350);
            this.gridControl1.TabIndex = 1;
            this.gridControl1.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridView1});
            this.gridControl1.DoubleClick += new System.EventHandler(this.gridControl1_DoubleClick);
            // 
            // receivingsBindingSource
            // 
            this.receivingsBindingSource.DataSource = typeof(ClearOffice.Inventory.DataAccess.ReceivingInfo);
            // 
            // gridView1
            // 
            this.gridView1.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.colGRN,
            this.colAirwaybillNo,
            this.colInvoiceNo,
            this.colReceivedBy,
            this.colReceivedDate,
            this.colSupplierName,
            this.colWarehouseName,
            this.colStatusName});
            this.gridView1.GridControl = this.gridControl1;
            this.gridView1.Name = "gridView1";
            this.gridView1.OptionsBehavior.Editable = false;
            this.gridView1.OptionsView.ShowAutoFilterRow = true;
            this.gridView1.OptionsView.ShowGroupPanel = false;
            // 
            // colGRN
            // 
            this.colGRN.FieldName = "GRN";
            this.colGRN.Name = "colGRN";
            this.colGRN.Visible = true;
            this.colGRN.VisibleIndex = 0;
            // 
            // colAirwaybillNo
            // 
            this.colAirwaybillNo.FieldName = "AirwaybillNo";
            this.colAirwaybillNo.Name = "colAirwaybillNo";
            this.colAirwaybillNo.Visible = true;
            this.colAirwaybillNo.VisibleIndex = 1;
            // 
            // colInvoiceNo
            // 
            this.colInvoiceNo.FieldName = "InvoiceNo";
            this.colInvoiceNo.Name = "colInvoiceNo";
            this.colInvoiceNo.Visible = true;
            this.colInvoiceNo.VisibleIndex = 2;
            // 
            // colReceivedBy
            // 
            this.colReceivedBy.FieldName = "ReceivedBy";
            this.colReceivedBy.Name = "colReceivedBy";
            this.colReceivedBy.Visible = true;
            this.colReceivedBy.VisibleIndex = 3;
            // 
            // colReceivedDate
            // 
            this.colReceivedDate.FieldName = "ReceivedDate";
            this.colReceivedDate.Name = "colReceivedDate";
            this.colReceivedDate.Visible = true;
            this.colReceivedDate.VisibleIndex = 4;
            // 
            // colSupplierName
            // 
            this.colSupplierName.Caption = "Supplier";
            this.colSupplierName.FieldName = "SupplierName";
            this.colSupplierName.Name = "colSupplierName";
            this.colSupplierName.Visible = true;
            this.colSupplierName.VisibleIndex = 5;
            // 
            // colStatusName
            // 
            this.colStatusName.FieldName = "StatusName";
            this.colStatusName.Name = "colStatusName";
            this.colStatusName.Visible = true;
            this.colStatusName.VisibleIndex = 7;
            // 
            // colWarehouseName
            // 
            this.colWarehouseName.Caption = "Warehouse";
            this.colWarehouseName.FieldName = "WarehouseName";
            this.colWarehouseName.Name = "colWarehouseName";
            this.colWarehouseName.Visible = true;
            this.colWarehouseName.VisibleIndex = 6;
            // 
            // ReceivingList
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(792, 493);
            this.Controls.Add(this.gridControl1);
            this.Controls.Add(this.ribbonControl1);
            this.Name = "ReceivingList";
            this.Text = "Receiving";
            this.Activated += new System.EventHandler(this.ReceivingList_Activated);
            ((System.ComponentModel.ISupportInitialize)(this.ribbonControl1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.smallImageCollection)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.largeImageCollection)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridControl1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.receivingsBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraBars.Ribbon.RibbonControl ribbonControl1;
        private DevExpress.XtraBars.Ribbon.RibbonPage ribbonPage1;
        private DevExpress.XtraBars.Ribbon.RibbonPageGroup ribbonPageGroup1;
        private DevExpress.XtraGrid.GridControl gridControl1;
        private DevExpress.XtraGrid.Views.Grid.GridView gridView1;
        private System.Windows.Forms.BindingSource receivingsBindingSource;
        private DevExpress.XtraBars.BarButtonItem newReceivingBarButtonItem;
        private DevExpress.XtraBars.BarButtonItem refreshBarButtonItem;
        private DevExpress.Utils.ImageCollection smallImageCollection;
        private DevExpress.Utils.ImageCollection largeImageCollection;
        private DevExpress.XtraGrid.Columns.GridColumn colGRN;
        private DevExpress.XtraGrid.Columns.GridColumn colAirwaybillNo;
        private DevExpress.XtraGrid.Columns.GridColumn colInvoiceNo;
        private DevExpress.XtraGrid.Columns.GridColumn colReceivedBy;
        private DevExpress.XtraGrid.Columns.GridColumn colReceivedDate;
        private DevExpress.XtraGrid.Columns.GridColumn colSupplierName;
        private DevExpress.XtraGrid.Columns.GridColumn colWarehouseName;
        private DevExpress.XtraGrid.Columns.GridColumn colStatusName;
    }
}