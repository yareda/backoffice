namespace ClearOffice.Inventory.Views
{
    partial class IssueListView
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(IssueListView));
            this.ribbonControl1 = new DevExpress.XtraBars.Ribbon.RibbonControl();
            this.smallImageCollection = new DevExpress.Utils.ImageCollection(this.components);
            this.newIssueBarButtonItem = new DevExpress.XtraBars.BarButtonItem();
            this.refreshBarButtonItem = new DevExpress.XtraBars.BarButtonItem();
            this.largeImageCollection = new DevExpress.Utils.ImageCollection(this.components);
            this.ribbonPage1 = new DevExpress.XtraBars.Ribbon.RibbonPage();
            this.ribbonPageGroup1 = new DevExpress.XtraBars.Ribbon.RibbonPageGroup();
            this.gridControl1 = new DevExpress.XtraGrid.GridControl();
            this.issuesBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.gridView1 = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.colIssueNo = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colIssueDate = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colIssuedBy = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colPostedDate = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colPostedBy = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colStatus = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colIssuedTo = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colWarehouseText = new DevExpress.XtraGrid.Columns.GridColumn();
            ((System.ComponentModel.ISupportInitialize)(this.ribbonControl1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.smallImageCollection)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.largeImageCollection)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridControl1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.issuesBindingSource)).BeginInit();
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
            this.newIssueBarButtonItem,
            this.refreshBarButtonItem});
            this.ribbonControl1.LargeImages = this.largeImageCollection;
            this.ribbonControl1.Location = new System.Drawing.Point(0, 0);
            this.ribbonControl1.MaxItemId = 3;
            this.ribbonControl1.Name = "ribbonControl1";
            this.ribbonControl1.Pages.AddRange(new DevExpress.XtraBars.Ribbon.RibbonPage[] {
            this.ribbonPage1});
            this.ribbonControl1.SelectedPage = this.ribbonPage1;
            this.ribbonControl1.Size = new System.Drawing.Size(682, 143);
            // 
            // smallImageCollection
            // 
            this.smallImageCollection.ImageStream = ((DevExpress.Utils.ImageCollectionStreamer)(resources.GetObject("smallImageCollection.ImageStream")));
            this.smallImageCollection.Images.SetKeyName(0, "new-16x16.png");
            this.smallImageCollection.Images.SetKeyName(1, "Refresh_16x16.png");
            // 
            // newIssueBarButtonItem
            // 
            this.newIssueBarButtonItem.Caption = "New";
            this.newIssueBarButtonItem.Id = 1;
            this.newIssueBarButtonItem.LargeImageIndex = 0;
            this.newIssueBarButtonItem.Name = "newIssueBarButtonItem";
            this.newIssueBarButtonItem.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.newIssueBarButtonItem_ItemClick);
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
            this.ribbonPageGroup1.ItemLinks.Add(this.newIssueBarButtonItem);
            this.ribbonPageGroup1.ItemLinks.Add(this.refreshBarButtonItem);
            this.ribbonPageGroup1.Name = "ribbonPageGroup1";
            this.ribbonPageGroup1.Text = "Transactions";
            // 
            // gridControl1
            // 
            this.gridControl1.DataSource = this.issuesBindingSource;
            this.gridControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gridControl1.Location = new System.Drawing.Point(0, 143);
            this.gridControl1.MainView = this.gridView1;
            this.gridControl1.MenuManager = this.ribbonControl1;
            this.gridControl1.Name = "gridControl1";
            this.gridControl1.Size = new System.Drawing.Size(682, 290);
            this.gridControl1.TabIndex = 1;
            this.gridControl1.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridView1});
            this.gridControl1.DoubleClick += new System.EventHandler(this.gridControl1_DoubleClick);
            // 
            // issuesBindingSource
            // 
            this.issuesBindingSource.DataSource = typeof(ClearOffice.Inventory.DataAccess.IssueInfo);
            // 
            // gridView1
            // 
            this.gridView1.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.colIssueNo,
            this.colIssueDate,
            this.colIssuedBy,
            this.colIssuedTo,
            this.colPostedDate,
            this.colPostedBy,
            this.colWarehouseText,
            this.colStatus});
            this.gridView1.GridControl = this.gridControl1;
            this.gridView1.Name = "gridView1";
            this.gridView1.OptionsBehavior.Editable = false;
            this.gridView1.OptionsView.ShowAutoFilterRow = true;
            this.gridView1.OptionsView.ShowGroupPanel = false;
            // 
            // colIssueNo
            // 
            this.colIssueNo.FieldName = "IssueNo";
            this.colIssueNo.Name = "colIssueNo";
            this.colIssueNo.Visible = true;
            this.colIssueNo.VisibleIndex = 0;
            // 
            // colIssueDate
            // 
            this.colIssueDate.FieldName = "IssueDate";
            this.colIssueDate.Name = "colIssueDate";
            this.colIssueDate.Visible = true;
            this.colIssueDate.VisibleIndex = 1;
            // 
            // colIssuedBy
            // 
            this.colIssuedBy.FieldName = "IssuedBy";
            this.colIssuedBy.Name = "colIssuedBy";
            this.colIssuedBy.Visible = true;
            this.colIssuedBy.VisibleIndex = 2;
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
            // colIssuedTo
            // 
            this.colIssuedTo.FieldName = "IssuedTo";
            this.colIssuedTo.Name = "colIssuedTo";
            this.colIssuedTo.Visible = true;
            this.colIssuedTo.VisibleIndex = 6;
            // 
            // colWarehouseText
            // 
            this.colWarehouseText.Caption = "Warehouse";
            this.colWarehouseText.FieldName = "WarehouseText";
            this.colWarehouseText.Name = "colWarehouseText";
            this.colWarehouseText.Visible = true;
            this.colWarehouseText.VisibleIndex = 7;
            // 
            // IssueListView
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(682, 433);
            this.Controls.Add(this.gridControl1);
            this.Controls.Add(this.ribbonControl1);
            this.Name = "IssueListView";
            this.Text = "Issue";
            this.Activated += new System.EventHandler(this.IssueListView_Activated);
            ((System.ComponentModel.ISupportInitialize)(this.ribbonControl1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.smallImageCollection)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.largeImageCollection)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridControl1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.issuesBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraBars.Ribbon.RibbonControl ribbonControl1;
        private DevExpress.XtraBars.Ribbon.RibbonPage ribbonPage1;
        private DevExpress.XtraBars.Ribbon.RibbonPageGroup ribbonPageGroup1;
        private DevExpress.XtraGrid.GridControl gridControl1;
        private DevExpress.XtraGrid.Views.Grid.GridView gridView1;
        private DevExpress.XtraBars.BarButtonItem newIssueBarButtonItem;
        private DevExpress.XtraBars.BarButtonItem refreshBarButtonItem;
        private System.Windows.Forms.BindingSource issuesBindingSource;
        private DevExpress.Utils.ImageCollection smallImageCollection;
        private DevExpress.Utils.ImageCollection largeImageCollection;
        private DevExpress.XtraGrid.Columns.GridColumn colIssueNo;
        private DevExpress.XtraGrid.Columns.GridColumn colIssueDate;
        private DevExpress.XtraGrid.Columns.GridColumn colIssuedBy;
        private DevExpress.XtraGrid.Columns.GridColumn colIssuedTo;
        private DevExpress.XtraGrid.Columns.GridColumn colPostedDate;
        private DevExpress.XtraGrid.Columns.GridColumn colPostedBy;
        private DevExpress.XtraGrid.Columns.GridColumn colWarehouseText;
        private DevExpress.XtraGrid.Columns.GridColumn colStatus;
    }
}