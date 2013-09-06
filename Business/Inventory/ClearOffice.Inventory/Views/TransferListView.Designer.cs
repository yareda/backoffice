namespace ClearOffice.Inventory.Views
{
    partial class TransferListView
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(TransferListView));
            this.ribbonControl1 = new DevExpress.XtraBars.Ribbon.RibbonControl();
            this.smallImageCollection = new DevExpress.Utils.ImageCollection(this.components);
            this.newBarButtonItem = new DevExpress.XtraBars.BarButtonItem();
            this.refreshBarButtonItem = new DevExpress.XtraBars.BarButtonItem();
            this.largeImageCollection = new DevExpress.Utils.ImageCollection(this.components);
            this.ribbonPage1 = new DevExpress.XtraBars.Ribbon.RibbonPage();
            this.ribbonPageGroup1 = new DevExpress.XtraBars.Ribbon.RibbonPageGroup();
            this.gridControl1 = new DevExpress.XtraGrid.GridControl();
            this.transferListBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.gridView1 = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.colTransferNo = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colTransferDate = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colTransferBy = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colPostedDate = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colPostedBy = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colStatus = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colSourceWarehouse = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colDestinationWarehouse = new DevExpress.XtraGrid.Columns.GridColumn();
            ((System.ComponentModel.ISupportInitialize)(this.ribbonControl1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.smallImageCollection)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.largeImageCollection)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridControl1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.transferListBindingSource)).BeginInit();
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
            this.newBarButtonItem,
            this.refreshBarButtonItem});
            this.ribbonControl1.LargeImages = this.largeImageCollection;
            this.ribbonControl1.Location = new System.Drawing.Point(0, 0);
            this.ribbonControl1.MaxItemId = 3;
            this.ribbonControl1.Name = "ribbonControl1";
            this.ribbonControl1.Pages.AddRange(new DevExpress.XtraBars.Ribbon.RibbonPage[] {
            this.ribbonPage1});
            this.ribbonControl1.SelectedPage = this.ribbonPage1;
            this.ribbonControl1.Size = new System.Drawing.Size(776, 143);
            // 
            // smallImageCollection
            // 
            this.smallImageCollection.ImageStream = ((DevExpress.Utils.ImageCollectionStreamer)(resources.GetObject("smallImageCollection.ImageStream")));
            this.smallImageCollection.Images.SetKeyName(0, "new-16x16.png");
            this.smallImageCollection.Images.SetKeyName(1, "Refresh_16x16.png");
            // 
            // newBarButtonItem
            // 
            this.newBarButtonItem.Caption = "New";
            this.newBarButtonItem.Id = 1;
            this.newBarButtonItem.LargeImageIndex = 0;
            this.newBarButtonItem.Name = "newBarButtonItem";
            this.newBarButtonItem.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.newBarButtonItem_ItemClick);
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
            this.ribbonPageGroup1.ItemLinks.Add(this.newBarButtonItem);
            this.ribbonPageGroup1.ItemLinks.Add(this.refreshBarButtonItem);
            this.ribbonPageGroup1.Name = "ribbonPageGroup1";
            this.ribbonPageGroup1.Text = "Transactions";
            // 
            // gridControl1
            // 
            this.gridControl1.DataSource = this.transferListBindingSource;
            this.gridControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gridControl1.Location = new System.Drawing.Point(0, 143);
            this.gridControl1.MainView = this.gridView1;
            this.gridControl1.MenuManager = this.ribbonControl1;
            this.gridControl1.Name = "gridControl1";
            this.gridControl1.Size = new System.Drawing.Size(776, 356);
            this.gridControl1.TabIndex = 1;
            this.gridControl1.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridView1});
            this.gridControl1.DoubleClick += new System.EventHandler(this.gridControl1_DoubleClick);
            // 
            // transferListBindingSource
            // 
            this.transferListBindingSource.DataSource = typeof(ClearOffice.Inventory.DataAccess.TransferInfo);
            // 
            // gridView1
            // 
            this.gridView1.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.colTransferNo,
            this.colTransferDate,
            this.colTransferBy,
            this.colPostedDate,
            this.colPostedBy,
            this.colSourceWarehouse,
            this.colDestinationWarehouse,
            this.colStatus});
            this.gridView1.GridControl = this.gridControl1;
            this.gridView1.Name = "gridView1";
            this.gridView1.OptionsBehavior.Editable = false;
            this.gridView1.OptionsView.ShowAutoFilterRow = true;
            this.gridView1.OptionsView.ShowGroupPanel = false;
            // 
            // colTransferNo
            // 
            this.colTransferNo.FieldName = "TransferNo";
            this.colTransferNo.Name = "colTransferNo";
            this.colTransferNo.Visible = true;
            this.colTransferNo.VisibleIndex = 0;
            // 
            // colTransferDate
            // 
            this.colTransferDate.FieldName = "TransferDate";
            this.colTransferDate.Name = "colTransferDate";
            this.colTransferDate.Visible = true;
            this.colTransferDate.VisibleIndex = 1;
            // 
            // colTransferBy
            // 
            this.colTransferBy.FieldName = "TransferBy";
            this.colTransferBy.Name = "colTransferBy";
            this.colTransferBy.Visible = true;
            this.colTransferBy.VisibleIndex = 2;
            // 
            // colPostedDate
            // 
            this.colPostedDate.FieldName = "PostedDate";
            this.colPostedDate.Name = "colPostedDate";
            this.colPostedDate.Visible = true;
            this.colPostedDate.VisibleIndex = 3;
            // 
            // colPostedBy
            // 
            this.colPostedBy.FieldName = "PostedBy";
            this.colPostedBy.Name = "colPostedBy";
            this.colPostedBy.Visible = true;
            this.colPostedBy.VisibleIndex = 4;
            // 
            // colStatus
            // 
            this.colStatus.FieldName = "Status";
            this.colStatus.Name = "colStatus";
            this.colStatus.Visible = true;
            this.colStatus.VisibleIndex = 5;
            // 
            // colSourceWarehouse
            // 
            this.colSourceWarehouse.FieldName = "SourceWarehouse";
            this.colSourceWarehouse.Name = "colSourceWarehouse";
            this.colSourceWarehouse.Visible = true;
            this.colSourceWarehouse.VisibleIndex = 6;
            // 
            // colDestinationWarehouse
            // 
            this.colDestinationWarehouse.FieldName = "DestinationWarehouse";
            this.colDestinationWarehouse.Name = "colDestinationWarehouse";
            this.colDestinationWarehouse.Visible = true;
            this.colDestinationWarehouse.VisibleIndex = 7;
            // 
            // TransferListView
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(776, 499);
            this.Controls.Add(this.gridControl1);
            this.Controls.Add(this.ribbonControl1);
            this.Name = "TransferListView";
            this.Text = "Stock Transfer List";
            this.Activated += new System.EventHandler(this.TransferListView_Activated);
            ((System.ComponentModel.ISupportInitialize)(this.ribbonControl1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.smallImageCollection)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.largeImageCollection)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridControl1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.transferListBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraBars.Ribbon.RibbonControl ribbonControl1;
        private DevExpress.XtraBars.Ribbon.RibbonPage ribbonPage1;
        private DevExpress.XtraBars.Ribbon.RibbonPageGroup ribbonPageGroup1;
        private DevExpress.XtraBars.BarButtonItem newBarButtonItem;
        private DevExpress.XtraBars.BarButtonItem refreshBarButtonItem;
        private DevExpress.XtraGrid.GridControl gridControl1;
        private DevExpress.XtraGrid.Views.Grid.GridView gridView1;
        private DevExpress.Utils.ImageCollection smallImageCollection;
        private DevExpress.Utils.ImageCollection largeImageCollection;
        private System.Windows.Forms.BindingSource transferListBindingSource;
        private DevExpress.XtraGrid.Columns.GridColumn colTransferNo;
        private DevExpress.XtraGrid.Columns.GridColumn colTransferDate;
        private DevExpress.XtraGrid.Columns.GridColumn colTransferBy;
        private DevExpress.XtraGrid.Columns.GridColumn colPostedDate;
        private DevExpress.XtraGrid.Columns.GridColumn colPostedBy;
        private DevExpress.XtraGrid.Columns.GridColumn colSourceWarehouse;
        private DevExpress.XtraGrid.Columns.GridColumn colDestinationWarehouse;
        private DevExpress.XtraGrid.Columns.GridColumn colStatus;
    }
}