namespace ClearOffice.Inventory.Views
{
    partial class ReturnListView
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ReturnListView));
            this.ribbonControl1 = new DevExpress.XtraBars.Ribbon.RibbonControl();
            this.smallImageCollection = new DevExpress.Utils.ImageCollection(this.components);
            this.newBarButtonItem = new DevExpress.XtraBars.BarButtonItem();
            this.refreshBarButtonItem = new DevExpress.XtraBars.BarButtonItem();
            this.largeImageCollection = new DevExpress.Utils.ImageCollection(this.components);
            this.ribbonPage1 = new DevExpress.XtraBars.Ribbon.RibbonPage();
            this.ribbonPageGroup1 = new DevExpress.XtraBars.Ribbon.RibbonPageGroup();
            this.gridControl1 = new DevExpress.XtraGrid.GridControl();
            this.returnBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.gridView1 = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.colReturnNo = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colAcceptedBy = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colAcceptedDate = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colPostedBy = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colPostedDate = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colStatusName = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colWarehouseText = new DevExpress.XtraGrid.Columns.GridColumn();
            ((System.ComponentModel.ISupportInitialize)(this.ribbonControl1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.smallImageCollection)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.largeImageCollection)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridControl1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.returnBindingSource)).BeginInit();
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
            this.ribbonControl1.Size = new System.Drawing.Size(633, 143);
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
            this.gridControl1.DataSource = this.returnBindingSource;
            this.gridControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gridControl1.Location = new System.Drawing.Point(0, 143);
            this.gridControl1.MainView = this.gridView1;
            this.gridControl1.MenuManager = this.ribbonControl1;
            this.gridControl1.Name = "gridControl1";
            this.gridControl1.Size = new System.Drawing.Size(633, 270);
            this.gridControl1.TabIndex = 1;
            this.gridControl1.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridView1});
            this.gridControl1.DoubleClick += new System.EventHandler(this.gridControl1_DoubleClick);
            // 
            // returnBindingSource
            // 
            this.returnBindingSource.DataSource = typeof(ClearOffice.Inventory.DataAccess.ReturnInfo);
            // 
            // gridView1
            // 
            this.gridView1.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.colReturnNo,
            this.colAcceptedBy,
            this.colAcceptedDate,
            this.colPostedBy,
            this.colPostedDate,
            this.colWarehouseText,
            this.colStatusName});
            this.gridView1.GridControl = this.gridControl1;
            this.gridView1.Name = "gridView1";
            this.gridView1.OptionsBehavior.Editable = false;
            this.gridView1.OptionsView.ShowAutoFilterRow = true;
            this.gridView1.OptionsView.ShowGroupPanel = false;
            // 
            // colReturnNo
            // 
            this.colReturnNo.FieldName = "ReturnNo";
            this.colReturnNo.Name = "colReturnNo";
            this.colReturnNo.Visible = true;
            this.colReturnNo.VisibleIndex = 0;
            // 
            // colAcceptedBy
            // 
            this.colAcceptedBy.FieldName = "AcceptedBy";
            this.colAcceptedBy.Name = "colAcceptedBy";
            this.colAcceptedBy.Visible = true;
            this.colAcceptedBy.VisibleIndex = 1;
            // 
            // colAcceptedDate
            // 
            this.colAcceptedDate.FieldName = "AcceptedDate";
            this.colAcceptedDate.Name = "colAcceptedDate";
            this.colAcceptedDate.Visible = true;
            this.colAcceptedDate.VisibleIndex = 2;
            // 
            // colPostedBy
            // 
            this.colPostedBy.FieldName = "PostedBy";
            this.colPostedBy.Name = "colPostedBy";
            this.colPostedBy.Visible = true;
            this.colPostedBy.VisibleIndex = 3;
            // 
            // colPostedDate
            // 
            this.colPostedDate.FieldName = "PostedDate";
            this.colPostedDate.Name = "colPostedDate";
            this.colPostedDate.Visible = true;
            this.colPostedDate.VisibleIndex = 4;
            // 
            // colStatusName
            // 
            this.colStatusName.FieldName = "StatusName";
            this.colStatusName.Name = "colStatusName";
            this.colStatusName.Visible = true;
            this.colStatusName.VisibleIndex = 6;
            // 
            // colWarehouseText
            // 
            this.colWarehouseText.Caption = "Warehouse";
            this.colWarehouseText.FieldName = "WarehouseText";
            this.colWarehouseText.Name = "colWarehouseText";
            this.colWarehouseText.Visible = true;
            this.colWarehouseText.VisibleIndex = 5;
            // 
            // ReturnListView
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(633, 413);
            this.Controls.Add(this.gridControl1);
            this.Controls.Add(this.ribbonControl1);
            this.Name = "ReturnListView";
            this.Text = "Return Stock Transaction";
            this.Activated += new System.EventHandler(this.ReturnListView_Activated);
            ((System.ComponentModel.ISupportInitialize)(this.ribbonControl1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.smallImageCollection)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.largeImageCollection)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridControl1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.returnBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraBars.Ribbon.RibbonControl ribbonControl1;
        private DevExpress.XtraBars.Ribbon.RibbonPage ribbonPage1;
        private DevExpress.XtraBars.Ribbon.RibbonPageGroup ribbonPageGroup1;
        private DevExpress.XtraGrid.GridControl gridControl1;
        private DevExpress.XtraGrid.Views.Grid.GridView gridView1;
        private DevExpress.Utils.ImageCollection smallImageCollection;
        private DevExpress.XtraBars.BarButtonItem newBarButtonItem;
        private DevExpress.XtraBars.BarButtonItem refreshBarButtonItem;
        private DevExpress.Utils.ImageCollection largeImageCollection;
        private System.Windows.Forms.BindingSource returnBindingSource;
        private DevExpress.XtraGrid.Columns.GridColumn colReturnNo;
        private DevExpress.XtraGrid.Columns.GridColumn colAcceptedBy;
        private DevExpress.XtraGrid.Columns.GridColumn colAcceptedDate;
        private DevExpress.XtraGrid.Columns.GridColumn colPostedBy;
        private DevExpress.XtraGrid.Columns.GridColumn colPostedDate;
        private DevExpress.XtraGrid.Columns.GridColumn colWarehouseText;
        private DevExpress.XtraGrid.Columns.GridColumn colStatusName;
    }
}