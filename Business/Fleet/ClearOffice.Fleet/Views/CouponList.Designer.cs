namespace ClearOffice.Fleet.Views
{
    partial class CouponList
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(CouponList));
            this.ribbonControl1 = new DevExpress.XtraBars.Ribbon.RibbonControl();
            this.smallImageCollection = new DevExpress.Utils.ImageCollection();
            this.newCouponBarButtonItem = new DevExpress.XtraBars.BarButtonItem();
            this.refreshBarButtonItem = new DevExpress.XtraBars.BarButtonItem();
            this.largeImageCollection = new DevExpress.Utils.ImageCollection();
            this.fleetListRibbonPage = new DevExpress.XtraBars.Ribbon.RibbonPage();
            this.ribbonPageGroup1 = new DevExpress.XtraBars.Ribbon.RibbonPageGroup();
            this.barButtonItem = new DevExpress.XtraBars.BarButtonItem();
            this.gridControl1 = new DevExpress.XtraGrid.GridControl();
            this.couponsBindingSource = new System.Windows.Forms.BindingSource();
            this.gridView1 = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.colCouponLabel = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colPurchasedFrom = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colDatePurchased = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colCashValue = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colConsumedCashAmount = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colConsumedValueAmount = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colRemainingAmount = new DevExpress.XtraGrid.Columns.GridColumn();
            ((System.ComponentModel.ISupportInitialize)(this.ribbonControl1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.smallImageCollection)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.largeImageCollection)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridControl1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.couponsBindingSource)).BeginInit();
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
            this.ribbonControl1.Images = this.smallImageCollection;
            this.ribbonControl1.Items.AddRange(new DevExpress.XtraBars.BarItem[] {
            this.ribbonControl1.ExpandCollapseItem,
            this.newCouponBarButtonItem,
            this.refreshBarButtonItem});
            this.ribbonControl1.LargeImages = this.largeImageCollection;
            this.ribbonControl1.Location = new System.Drawing.Point(0, 0);
            this.ribbonControl1.MaxItemId = 3;
            this.ribbonControl1.MdiMergeStyle = DevExpress.XtraBars.Ribbon.RibbonMdiMergeStyle.Always;
            this.ribbonControl1.Name = "ribbonControl1";
            this.ribbonControl1.Pages.AddRange(new DevExpress.XtraBars.Ribbon.RibbonPage[] {
            this.fleetListRibbonPage});
            this.ribbonControl1.SelectedPage = this.fleetListRibbonPage;
            this.ribbonControl1.Size = new System.Drawing.Size(830, 143);
            // 
            // smallImageCollection
            // 
            this.smallImageCollection.ImageStream = ((DevExpress.Utils.ImageCollectionStreamer)(resources.GetObject("smallImageCollection.ImageStream")));
            this.smallImageCollection.Images.SetKeyName(0, "contact-new.png");
            this.smallImageCollection.Images.SetKeyName(1, "mail-reply-all.png");
            this.smallImageCollection.Images.SetKeyName(2, "Refresh_16x16.png");
            this.smallImageCollection.Images.SetKeyName(3, "Order.png");
            // 
            // newCouponBarButtonItem
            // 
            this.newCouponBarButtonItem.Caption = "New Coupon";
            this.newCouponBarButtonItem.Id = 1;
            this.newCouponBarButtonItem.ImageIndex = 3;
            this.newCouponBarButtonItem.Name = "newCouponBarButtonItem";
            this.newCouponBarButtonItem.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.newCouponBarButtonItem_ItemClick);
            // 
            // refreshBarButtonItem
            // 
            this.refreshBarButtonItem.Caption = "Refresh";
            this.refreshBarButtonItem.Id = 2;
            this.refreshBarButtonItem.ImageIndex = 2;
            this.refreshBarButtonItem.Name = "refreshBarButtonItem";
            this.refreshBarButtonItem.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.refreshBarButtonItem_ItemClick);
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
            this.ribbonPageGroup1.ItemLinks.Add(this.newCouponBarButtonItem);
            this.ribbonPageGroup1.ItemLinks.Add(this.refreshBarButtonItem);
            this.ribbonPageGroup1.Name = "ribbonPageGroup1";
            this.ribbonPageGroup1.Text = "Coupon";
            // 
            // barButtonItem
            // 
            this.barButtonItem.Caption = "New Coupon";
            this.barButtonItem.Id = 1;
            this.barButtonItem.Name = "barButtonItem";
            // 
            // gridControl1
            // 
            this.gridControl1.DataSource = this.couponsBindingSource;
            this.gridControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gridControl1.Location = new System.Drawing.Point(0, 143);
            this.gridControl1.MainView = this.gridView1;
            this.gridControl1.MenuManager = this.ribbonControl1;
            this.gridControl1.Name = "gridControl1";
            this.gridControl1.Size = new System.Drawing.Size(830, 293);
            this.gridControl1.TabIndex = 1;
            this.gridControl1.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridView1});
            this.gridControl1.DoubleClick += new System.EventHandler(this.gridControl1_DoubleClick);
            // 
            // couponsBindingSource
            // 
            this.couponsBindingSource.DataSource = typeof(ClearOffice.Fleet.Business.CouponInfo);
            // 
            // gridView1
            // 
            this.gridView1.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.colCouponLabel,
            this.colPurchasedFrom,
            this.colDatePurchased,
            this.colCashValue,
            this.colConsumedCashAmount,
            this.colRemainingAmount,
            this.colConsumedValueAmount});
            this.gridView1.GridControl = this.gridControl1;
            this.gridView1.Name = "gridView1";
            this.gridView1.OptionsBehavior.Editable = false;
            this.gridView1.OptionsView.ShowAutoFilterRow = true;
            this.gridView1.OptionsView.ShowGroupPanel = false;
            // 
            // colCouponLabel
            // 
            this.colCouponLabel.FieldName = "CouponLabel";
            this.colCouponLabel.Name = "colCouponLabel";
            this.colCouponLabel.Visible = true;
            this.colCouponLabel.VisibleIndex = 0;
            this.colCouponLabel.Width = 135;
            // 
            // colPurchasedFrom
            // 
            this.colPurchasedFrom.FieldName = "PurchasedFrom";
            this.colPurchasedFrom.Name = "colPurchasedFrom";
            this.colPurchasedFrom.Visible = true;
            this.colPurchasedFrom.VisibleIndex = 1;
            this.colPurchasedFrom.Width = 135;
            // 
            // colDatePurchased
            // 
            this.colDatePurchased.FieldName = "DatePurchased";
            this.colDatePurchased.Name = "colDatePurchased";
            this.colDatePurchased.Visible = true;
            this.colDatePurchased.VisibleIndex = 2;
            this.colDatePurchased.Width = 135;
            // 
            // colCashValue
            // 
            this.colCashValue.DisplayFormat.FormatString = "{0:#,##0.00;(#,##0.00);\\\'\\\'}";
            this.colCashValue.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Custom;
            this.colCashValue.FieldName = "CashValue";
            this.colCashValue.Name = "colCashValue";
            this.colCashValue.Visible = true;
            this.colCashValue.VisibleIndex = 3;
            this.colCashValue.Width = 110;
            // 
            // colConsumedCashAmount
            // 
            this.colConsumedCashAmount.Caption = "Consumed Amount (in Birr)";
            this.colConsumedCashAmount.DisplayFormat.FormatString = "{0:#,##0.00;(#,##0.00);\\\'\\\'}";
            this.colConsumedCashAmount.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Custom;
            this.colConsumedCashAmount.FieldName = "ConsumedCashAmount";
            this.colConsumedCashAmount.Name = "colConsumedCashAmount";
            this.colConsumedCashAmount.Visible = true;
            this.colConsumedCashAmount.VisibleIndex = 4;
            this.colConsumedCashAmount.Width = 147;
            // 
            // colConsumedValueAmount
            // 
            this.colConsumedValueAmount.Caption = "Consumed Amount (in Lt.)";
            this.colConsumedValueAmount.FieldName = "ConsumedValueAmount";
            this.colConsumedValueAmount.Name = "colConsumedValueAmount";
            this.colConsumedValueAmount.Visible = true;
            this.colConsumedValueAmount.VisibleIndex = 6;
            this.colConsumedValueAmount.Width = 150;
            // 
            // colRemainingAmount
            // 
            this.colRemainingAmount.DisplayFormat.FormatString = "{0:#,##0.00;(#,##0.00);\\\'\\\'}";
            this.colRemainingAmount.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Custom;
            this.colRemainingAmount.FieldName = "RemainingAmount";
            this.colRemainingAmount.Name = "colRemainingAmount";
            this.colRemainingAmount.Visible = true;
            this.colRemainingAmount.VisibleIndex = 5;
            // 
            // CouponList
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(830, 436);
            this.Controls.Add(this.gridControl1);
            this.Controls.Add(this.ribbonControl1);
            this.Name = "CouponList";
            this.Text = "Fuel Coupons";
            this.Activated += new System.EventHandler(this.CouponList_Activated);
            ((System.ComponentModel.ISupportInitialize)(this.ribbonControl1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.smallImageCollection)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.largeImageCollection)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridControl1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.couponsBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraBars.Ribbon.RibbonControl ribbonControl1;
        private DevExpress.XtraBars.Ribbon.RibbonPage fleetListRibbonPage;
        private DevExpress.XtraBars.Ribbon.RibbonPageGroup ribbonPageGroup1;
        private DevExpress.XtraBars.BarButtonItem newCouponBarButtonItem;
        private DevExpress.XtraBars.BarButtonItem refreshBarButtonItem;
        private DevExpress.XtraBars.BarButtonItem barButtonItem;
        private DevExpress.Utils.ImageCollection smallImageCollection;
        private DevExpress.Utils.ImageCollection largeImageCollection;
        private DevExpress.XtraGrid.GridControl gridControl1;
        private DevExpress.XtraGrid.Views.Grid.GridView gridView1;
        private System.Windows.Forms.BindingSource couponsBindingSource;
        private DevExpress.XtraGrid.Columns.GridColumn colCouponLabel;
        private DevExpress.XtraGrid.Columns.GridColumn colPurchasedFrom;
        private DevExpress.XtraGrid.Columns.GridColumn colDatePurchased;
        private DevExpress.XtraGrid.Columns.GridColumn colCashValue;
        private DevExpress.XtraGrid.Columns.GridColumn colConsumedCashAmount;
        private DevExpress.XtraGrid.Columns.GridColumn colConsumedValueAmount;
        private DevExpress.XtraGrid.Columns.GridColumn colRemainingAmount;
    }
}