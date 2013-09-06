namespace ClearOffice.FixedAsset.Views
{
    partial class AssetList
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AssetList));
            this.assetListBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.assetGridControl = new DevExpress.XtraGrid.GridControl();
            this.gridView1 = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.colAssetNumber = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colAssetValue = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colGroupText = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colCatagoryText = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colStatusText = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colDepreciationMethodText = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colDepreciationToDate = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colCurrentBookValue = new DevExpress.XtraGrid.Columns.GridColumn();
            this.ribbonControl1 = new DevExpress.XtraBars.Ribbon.RibbonControl();
            this.smallImageCollection = new DevExpress.Utils.ImageCollection(this.components);
            this.deleteAssetBarButtonItem = new DevExpress.XtraBars.BarButtonItem();
            this.refreshListBarButtonItem = new DevExpress.XtraBars.BarButtonItem();
            this.calculateDepreciationBarButtonItem = new DevExpress.XtraBars.BarButtonItem();
            this.assignBarButtonItem = new DevExpress.XtraBars.BarButtonItem();
            this.largeImageCollection = new DevExpress.Utils.ImageCollection(this.components);
            this.assetListRibbonPage = new DevExpress.XtraBars.Ribbon.RibbonPage();
            this.ribbonPageGroup1 = new DevExpress.XtraBars.Ribbon.RibbonPageGroup();
            this.ribbonPageGroup2 = new DevExpress.XtraBars.Ribbon.RibbonPageGroup();
            this.colDocumentNumber = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colLocationName = new DevExpress.XtraGrid.Columns.GridColumn();
            ((System.ComponentModel.ISupportInitialize)(this.assetListBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.assetGridControl)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ribbonControl1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.smallImageCollection)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.largeImageCollection)).BeginInit();
            this.SuspendLayout();
            // 
            // assetListBindingSource
            // 
            this.assetListBindingSource.DataSource = typeof(ClearOffice.FixedAsset.DataAccess.AssetListInfo);
            // 
            // assetGridControl
            // 
            this.assetGridControl.DataSource = this.assetListBindingSource;
            this.assetGridControl.Location = new System.Drawing.Point(0, 149);
            this.assetGridControl.MainView = this.gridView1;
            this.assetGridControl.Name = "assetGridControl";
            this.assetGridControl.Size = new System.Drawing.Size(618, 373);
            this.assetGridControl.TabIndex = 1;
            this.assetGridControl.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridView1});
            this.assetGridControl.Click += new System.EventHandler(this.gridControl1_Click);
            this.assetGridControl.DoubleClick += new System.EventHandler(this.gridControl1_DoubleClick);
            // 
            // gridView1
            // 
            this.gridView1.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.colAssetNumber,
            this.colDocumentNumber,
            this.colLocationName,
            this.colAssetValue,
            this.colGroupText,
            this.colCatagoryText,
            this.colStatusText,
            this.colDepreciationMethodText,
            this.colDepreciationToDate,
            this.colCurrentBookValue});
            this.gridView1.GridControl = this.assetGridControl;
            this.gridView1.Name = "gridView1";
            this.gridView1.OptionsBehavior.Editable = false;
            this.gridView1.OptionsView.ShowAutoFilterRow = true;
            this.gridView1.OptionsView.ShowGroupPanel = false;
            // 
            // colAssetNumber
            // 
            this.colAssetNumber.Caption = "Asset Number";
            this.colAssetNumber.FieldName = "AssetNumber";
            this.colAssetNumber.Name = "colAssetNumber";
            this.colAssetNumber.Visible = true;
            this.colAssetNumber.VisibleIndex = 0;
            this.colAssetNumber.Width = 60;
            // 
            // colAssetValue
            // 
            this.colAssetValue.Caption = "Asset Value";
            this.colAssetValue.DisplayFormat.FormatString = "{0:#,##0.00;(#,##0.00);\\\'\\\'}";
            this.colAssetValue.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Custom;
            this.colAssetValue.FieldName = "AssetValue";
            this.colAssetValue.Name = "colAssetValue";
            this.colAssetValue.Visible = true;
            this.colAssetValue.VisibleIndex = 7;
            this.colAssetValue.Width = 50;
            // 
            // colGroupText
            // 
            this.colGroupText.Caption = "Group";
            this.colGroupText.FieldName = "GroupText";
            this.colGroupText.Name = "colGroupText";
            this.colGroupText.Visible = true;
            this.colGroupText.VisibleIndex = 3;
            this.colGroupText.Width = 39;
            // 
            // colCatagoryText
            // 
            this.colCatagoryText.Caption = "Category";
            this.colCatagoryText.FieldName = "CatagoryText";
            this.colCatagoryText.Name = "colCatagoryText";
            this.colCatagoryText.Visible = true;
            this.colCatagoryText.VisibleIndex = 4;
            this.colCatagoryText.Width = 63;
            // 
            // colStatusText
            // 
            this.colStatusText.Caption = "Status";
            this.colStatusText.FieldName = "StatusText";
            this.colStatusText.Name = "colStatusText";
            this.colStatusText.Visible = true;
            this.colStatusText.VisibleIndex = 5;
            this.colStatusText.Width = 28;
            // 
            // colDepreciationMethodText
            // 
            this.colDepreciationMethodText.Caption = "Depreciation Method";
            this.colDepreciationMethodText.FieldName = "DepreciationMethodText";
            this.colDepreciationMethodText.Name = "colDepreciationMethodText";
            this.colDepreciationMethodText.Visible = true;
            this.colDepreciationMethodText.VisibleIndex = 6;
            this.colDepreciationMethodText.Width = 51;
            // 
            // colDepreciationToDate
            // 
            this.colDepreciationToDate.Caption = "Depreciation To Date";
            this.colDepreciationToDate.DisplayFormat.FormatString = "{0:#,##0.00;(#,##0.00);\\\'\\\'}";
            this.colDepreciationToDate.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Custom;
            this.colDepreciationToDate.FieldName = "DepreciationToDate";
            this.colDepreciationToDate.Name = "colDepreciationToDate";
            this.colDepreciationToDate.Visible = true;
            this.colDepreciationToDate.VisibleIndex = 8;
            this.colDepreciationToDate.Width = 80;
            // 
            // colCurrentBookValue
            // 
            this.colCurrentBookValue.Caption = "Current Book Value";
            this.colCurrentBookValue.DisplayFormat.FormatString = "{0:#,##0.00;(#,##0.00);\\\'\\\'}";
            this.colCurrentBookValue.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Custom;
            this.colCurrentBookValue.FieldName = "CurrentBookValue";
            this.colCurrentBookValue.Name = "colCurrentBookValue";
            this.colCurrentBookValue.Visible = true;
            this.colCurrentBookValue.VisibleIndex = 9;
            this.colCurrentBookValue.Width = 108;
            // 
            // ribbonControl1
            // 
            this.ribbonControl1.ApplicationButtonText = null;
            this.ribbonControl1.ExpandCollapseItem.Id = 0;
            this.ribbonControl1.Images = this.smallImageCollection;
            this.ribbonControl1.Items.AddRange(new DevExpress.XtraBars.BarItem[] {
            this.ribbonControl1.ExpandCollapseItem,
            this.deleteAssetBarButtonItem,
            this.refreshListBarButtonItem,
            this.calculateDepreciationBarButtonItem,
            this.assignBarButtonItem});
            this.ribbonControl1.LargeImages = this.largeImageCollection;
            this.ribbonControl1.Location = new System.Drawing.Point(0, 0);
            this.ribbonControl1.MaxItemId = 5;
            this.ribbonControl1.MdiMergeStyle = DevExpress.XtraBars.Ribbon.RibbonMdiMergeStyle.Always;
            this.ribbonControl1.Name = "ribbonControl1";
            this.ribbonControl1.Pages.AddRange(new DevExpress.XtraBars.Ribbon.RibbonPage[] {
            this.assetListRibbonPage});
            this.ribbonControl1.Size = new System.Drawing.Size(618, 142);
            // 
            // smallImageCollection
            // 
            this.smallImageCollection.ImageStream = ((DevExpress.Utils.ImageCollectionStreamer)(resources.GetObject("smallImageCollection.ImageStream")));
            this.smallImageCollection.Images.SetKeyName(0, "user-trash.png");
            this.smallImageCollection.Images.SetKeyName(1, "undo-16x16.png");
            this.smallImageCollection.Images.SetKeyName(2, "Cascade_16x16.png");
            this.smallImageCollection.Images.SetKeyName(3, "delete.png");
            this.smallImageCollection.Images.SetKeyName(4, "MenuBar_Refresh.png");
            this.smallImageCollection.Images.SetKeyName(5, "ActiveCustomersList_16x16.png");
            // 
            // deleteAssetBarButtonItem
            // 
            this.deleteAssetBarButtonItem.Caption = "Delete";
            this.deleteAssetBarButtonItem.Id = 1;
            this.deleteAssetBarButtonItem.ImageIndex = 3;
            this.deleteAssetBarButtonItem.Name = "deleteAssetBarButtonItem";
            this.deleteAssetBarButtonItem.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.deleteAssetBarButtonItem_ItemClick);
            // 
            // refreshListBarButtonItem
            // 
            this.refreshListBarButtonItem.Caption = "Refresh";
            this.refreshListBarButtonItem.Id = 2;
            this.refreshListBarButtonItem.ImageIndex = 4;
            this.refreshListBarButtonItem.Name = "refreshListBarButtonItem";
            this.refreshListBarButtonItem.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.refreshListBarButtonItem_ItemClick);
            // 
            // calculateDepreciationBarButtonItem
            // 
            this.calculateDepreciationBarButtonItem.Caption = "Calculate Depreciation";
            this.calculateDepreciationBarButtonItem.Id = 3;
            this.calculateDepreciationBarButtonItem.LargeImageIndex = 2;
            this.calculateDepreciationBarButtonItem.Name = "calculateDepreciationBarButtonItem";
            this.calculateDepreciationBarButtonItem.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.calculateDepreciationBarButtonItem_ItemClick);
            // 
            // assignBarButtonItem
            // 
            this.assignBarButtonItem.Caption = "Assign";
            this.assignBarButtonItem.Id = 4;
            this.assignBarButtonItem.ImageIndex = 5;
            this.assignBarButtonItem.Name = "assignBarButtonItem";
            this.assignBarButtonItem.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.assignBarButtonItem_ItemClick);
            // 
            // largeImageCollection
            // 
            this.largeImageCollection.ImageSize = new System.Drawing.Size(32, 32);
            this.largeImageCollection.ImageStream = ((DevExpress.Utils.ImageCollectionStreamer)(resources.GetObject("largeImageCollection.ImageStream")));
            this.largeImageCollection.Images.SetKeyName(0, "save-32x32.png");
            this.largeImageCollection.Images.SetKeyName(1, "Delete_32x32.png");
            this.largeImageCollection.Images.SetKeyName(2, "appointment-new.png");
            // 
            // assetListRibbonPage
            // 
            this.assetListRibbonPage.Groups.AddRange(new DevExpress.XtraBars.Ribbon.RibbonPageGroup[] {
            this.ribbonPageGroup1,
            this.ribbonPageGroup2});
            this.assetListRibbonPage.Name = "assetListRibbonPage";
            this.assetListRibbonPage.Text = "Fixed Asset";
            // 
            // ribbonPageGroup1
            // 
            this.ribbonPageGroup1.ItemLinks.Add(this.refreshListBarButtonItem);
            this.ribbonPageGroup1.ItemLinks.Add(this.deleteAssetBarButtonItem);
            this.ribbonPageGroup1.ItemLinks.Add(this.assignBarButtonItem);
            this.ribbonPageGroup1.Name = "ribbonPageGroup1";
            this.ribbonPageGroup1.Text = "Assets";
            // 
            // ribbonPageGroup2
            // 
            this.ribbonPageGroup2.ItemLinks.Add(this.calculateDepreciationBarButtonItem);
            this.ribbonPageGroup2.Name = "ribbonPageGroup2";
            this.ribbonPageGroup2.Text = "Depreciation";
            // 
            // colDocumentNumber
            // 
            this.colDocumentNumber.Caption = "Document #";
            this.colDocumentNumber.FieldName = "DocumentNumber";
            this.colDocumentNumber.Name = "colDocumentNumber";
            this.colDocumentNumber.Visible = true;
            this.colDocumentNumber.VisibleIndex = 1;
            this.colDocumentNumber.Width = 67;
            // 
            // colLocationName
            // 
            this.colLocationName.Caption = "Location";
            this.colLocationName.FieldName = "LocationName";
            this.colLocationName.Name = "colLocationName";
            this.colLocationName.Visible = true;
            this.colLocationName.VisibleIndex = 2;
            this.colLocationName.Width = 54;
            // 
            // AssetList
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(618, 521);
            this.Controls.Add(this.ribbonControl1);
            this.Controls.Add(this.assetGridControl);
            this.Name = "AssetList";
            this.Text = "Assets List";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Activated += new System.EventHandler(this.AssetList_Activated);
            ((System.ComponentModel.ISupportInitialize)(this.assetListBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.assetGridControl)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ribbonControl1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.smallImageCollection)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.largeImageCollection)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.BindingSource assetListBindingSource;
        private DevExpress.XtraGrid.GridControl assetGridControl;
        private DevExpress.XtraGrid.Views.Grid.GridView gridView1;
        private DevExpress.XtraGrid.Columns.GridColumn colAssetNumber;
        private DevExpress.XtraGrid.Columns.GridColumn colAssetValue;
        private DevExpress.XtraGrid.Columns.GridColumn colGroupText;
        private DevExpress.XtraGrid.Columns.GridColumn colCatagoryText;
        private DevExpress.XtraGrid.Columns.GridColumn colStatusText;
        private DevExpress.XtraGrid.Columns.GridColumn colDepreciationMethodText;
        private DevExpress.XtraGrid.Columns.GridColumn colDepreciationToDate;
        private DevExpress.XtraGrid.Columns.GridColumn colCurrentBookValue;
        private DevExpress.XtraBars.Ribbon.RibbonControl ribbonControl1;
        private DevExpress.XtraBars.Ribbon.RibbonPage assetListRibbonPage;
        private DevExpress.XtraBars.Ribbon.RibbonPageGroup ribbonPageGroup1;
        private DevExpress.XtraBars.BarButtonItem deleteAssetBarButtonItem;
        private DevExpress.Utils.ImageCollection smallImageCollection;
        private DevExpress.Utils.ImageCollection largeImageCollection;
        private DevExpress.XtraBars.BarButtonItem refreshListBarButtonItem;
        private DevExpress.XtraBars.Ribbon.RibbonPageGroup ribbonPageGroup2;
        private DevExpress.XtraBars.BarButtonItem calculateDepreciationBarButtonItem;
        private DevExpress.XtraBars.BarButtonItem assignBarButtonItem;
        private DevExpress.XtraGrid.Columns.GridColumn colDocumentNumber;
        private DevExpress.XtraGrid.Columns.GridColumn colLocationName;
    }
}