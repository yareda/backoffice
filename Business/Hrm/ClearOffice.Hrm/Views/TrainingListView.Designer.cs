namespace ClearOffice.Hrm.Views
{
    partial class TrainingListView
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(TrainingListView));
            this.trainingInfoBindingSource = new System.Windows.Forms.BindingSource();
            this.ribbonControl1 = new DevExpress.XtraBars.Ribbon.RibbonControl();
            this.SmallImageCollection = new DevExpress.Utils.ImageCollection();
            this.newrequestbarButtonItem = new DevExpress.XtraBars.BarButtonItem();
            this.showAllbarButtonItem = new DevExpress.XtraBars.BarButtonItem();
            this.ribbonPage1 = new DevExpress.XtraBars.Ribbon.RibbonPage();
            this.ribbonPageGroup1 = new DevExpress.XtraBars.Ribbon.RibbonPageGroup();
            this.gridControl1 = new DevExpress.XtraGrid.GridControl();
            this.gridView1 = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.colTrainingTitle = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colRequestedDate = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colRequestedBy = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colConductedBy = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colConductedFrom = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colConductedTo = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colActualCost = new DevExpress.XtraGrid.Columns.GridColumn();
            ((System.ComponentModel.ISupportInitialize)(this.trainingInfoBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ribbonControl1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.SmallImageCollection)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridControl1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // trainingInfoBindingSource
            // 
            this.trainingInfoBindingSource.DataSource = typeof(ClearOffice.Hrm.Business.Data.TrainingInfo);
            // 
            // ribbonControl1
            // 
            this.ribbonControl1.ApplicationButtonText = null;
            // 
            // 
            // 
            this.ribbonControl1.ExpandCollapseItem.Id = 0;
            this.ribbonControl1.ExpandCollapseItem.Name = "";
            this.ribbonControl1.Images = this.SmallImageCollection;
            this.ribbonControl1.Items.AddRange(new DevExpress.XtraBars.BarItem[] {
            this.ribbonControl1.ExpandCollapseItem,
            this.newrequestbarButtonItem,
            this.showAllbarButtonItem});
            this.ribbonControl1.Location = new System.Drawing.Point(0, 0);
            this.ribbonControl1.MaxItemId = 5;
            this.ribbonControl1.Name = "ribbonControl1";
            this.ribbonControl1.Pages.AddRange(new DevExpress.XtraBars.Ribbon.RibbonPage[] {
            this.ribbonPage1});
            this.ribbonControl1.SelectedPage = this.ribbonPage1;
            this.ribbonControl1.Size = new System.Drawing.Size(724, 143);
            // 
            // SmallImageCollection
            // 
            this.SmallImageCollection.ImageStream = ((DevExpress.Utils.ImageCollectionStreamer)(resources.GetObject("SmallImageCollection.ImageStream")));
            this.SmallImageCollection.Images.SetKeyName(0, "Question.png");
            this.SmallImageCollection.Images.SetKeyName(1, "Period_16x16.png");
            this.SmallImageCollection.Images.SetKeyName(2, "ListItems16x16.png");
            // 
            // newrequestbarButtonItem
            // 
            this.newrequestbarButtonItem.Caption = "Training Request";
            this.newrequestbarButtonItem.Id = 1;
            this.newrequestbarButtonItem.ImageIndex = 0;
            this.newrequestbarButtonItem.Name = "newrequestbarButtonItem";
            this.newrequestbarButtonItem.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.newTrainingRequest_ItemClick);
            // 
            // showAllbarButtonItem
            // 
            this.showAllbarButtonItem.Caption = "Show All";
            this.showAllbarButtonItem.Id = 4;
            this.showAllbarButtonItem.ImageIndex = 2;
            this.showAllbarButtonItem.Name = "showAllbarButtonItem";
            this.showAllbarButtonItem.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.showAllbarButtonItem_ItemClick);
            // 
            // ribbonPage1
            // 
            this.ribbonPage1.Groups.AddRange(new DevExpress.XtraBars.Ribbon.RibbonPageGroup[] {
            this.ribbonPageGroup1});
            this.ribbonPage1.Name = "ribbonPage1";
            this.ribbonPage1.Text = "Human Resource";
            // 
            // ribbonPageGroup1
            // 
            this.ribbonPageGroup1.ItemLinks.Add(this.newrequestbarButtonItem);
            this.ribbonPageGroup1.ItemLinks.Add(this.showAllbarButtonItem);
            this.ribbonPageGroup1.Name = "ribbonPageGroup1";
            this.ribbonPageGroup1.Text = "Trainings";
            // 
            // gridControl1
            // 
            this.gridControl1.DataSource = this.trainingInfoBindingSource;
            this.gridControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gridControl1.Location = new System.Drawing.Point(0, 143);
            this.gridControl1.MainView = this.gridView1;
            this.gridControl1.Name = "gridControl1";
            this.gridControl1.Size = new System.Drawing.Size(724, 333);
            this.gridControl1.TabIndex = 4;
            this.gridControl1.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridView1});
            this.gridControl1.DoubleClick += new System.EventHandler(this.gridControl1_DoubleClick);
            // 
            // gridView1
            // 
            this.gridView1.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.colTrainingTitle,
            this.colRequestedDate,
            this.colRequestedBy,
            this.colConductedBy,
            this.colConductedFrom,
            this.colConductedTo,
            this.colActualCost});
            this.gridView1.GridControl = this.gridControl1;
            this.gridView1.Name = "gridView1";
            this.gridView1.OptionsBehavior.Editable = false;
            this.gridView1.OptionsView.ShowAutoFilterRow = true;
            this.gridView1.OptionsView.ShowGroupedColumns = true;
            this.gridView1.OptionsView.ShowGroupPanel = false;
            // 
            // colTrainingTitle
            // 
            this.colTrainingTitle.DisplayFormat.FormatString = "{0:#,##0.00;(#,##0.00);\\\'\\\'}";
            this.colTrainingTitle.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Custom;
            this.colTrainingTitle.FieldName = "TrainingTitle";
            this.colTrainingTitle.Name = "colTrainingTitle";
            this.colTrainingTitle.Visible = true;
            this.colTrainingTitle.VisibleIndex = 0;
            // 
            // colRequestedDate
            // 
            this.colRequestedDate.FieldName = "RequestedDate";
            this.colRequestedDate.Name = "colRequestedDate";
            this.colRequestedDate.Visible = true;
            this.colRequestedDate.VisibleIndex = 1;
            // 
            // colRequestedBy
            // 
            this.colRequestedBy.FieldName = "RequestedBy";
            this.colRequestedBy.Name = "colRequestedBy";
            this.colRequestedBy.Visible = true;
            this.colRequestedBy.VisibleIndex = 2;
            // 
            // colConductedBy
            // 
            this.colConductedBy.FieldName = "ConductedBy";
            this.colConductedBy.Name = "colConductedBy";
            this.colConductedBy.Visible = true;
            this.colConductedBy.VisibleIndex = 3;
            // 
            // colConductedFrom
            // 
            this.colConductedFrom.FieldName = "ConductedFrom";
            this.colConductedFrom.Name = "colConductedFrom";
            this.colConductedFrom.Visible = true;
            this.colConductedFrom.VisibleIndex = 4;
            // 
            // colConductedTo
            // 
            this.colConductedTo.FieldName = "ConductedTo";
            this.colConductedTo.Name = "colConductedTo";
            this.colConductedTo.Visible = true;
            this.colConductedTo.VisibleIndex = 5;
            // 
            // colActualCost
            // 
            this.colActualCost.DisplayFormat.FormatString = "{0:#,##0.00;(#,##0.00);\\\'\\\'}";
            this.colActualCost.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Custom;
            this.colActualCost.FieldName = "ActualCost";
            this.colActualCost.Name = "colActualCost";
            this.colActualCost.Visible = true;
            this.colActualCost.VisibleIndex = 6;
            // 
            // TrainingListView
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(724, 476);
            this.Controls.Add(this.gridControl1);
            this.Controls.Add(this.ribbonControl1);
            this.Name = "TrainingListView";
            this.Text = "Training Lists";
            ((System.ComponentModel.ISupportInitialize)(this.trainingInfoBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ribbonControl1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.SmallImageCollection)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridControl1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.BindingSource trainingInfoBindingSource;
        private DevExpress.XtraBars.Ribbon.RibbonControl ribbonControl1;
        private DevExpress.XtraBars.BarButtonItem newrequestbarButtonItem;
        private DevExpress.XtraBars.Ribbon.RibbonPage ribbonPage1;
        private DevExpress.XtraBars.Ribbon.RibbonPageGroup ribbonPageGroup1;
        private DevExpress.XtraGrid.GridControl gridControl1;
        private DevExpress.XtraGrid.Views.Grid.GridView gridView1;
        private DevExpress.XtraGrid.Columns.GridColumn colTrainingTitle;
        private DevExpress.XtraGrid.Columns.GridColumn colRequestedDate;
        private DevExpress.XtraGrid.Columns.GridColumn colRequestedBy;
        private DevExpress.XtraGrid.Columns.GridColumn colConductedBy;
        private DevExpress.XtraGrid.Columns.GridColumn colConductedFrom;
        private DevExpress.XtraGrid.Columns.GridColumn colConductedTo;
        private DevExpress.XtraGrid.Columns.GridColumn colActualCost;
        private DevExpress.XtraBars.BarButtonItem showAllbarButtonItem;
        private DevExpress.Utils.ImageCollection SmallImageCollection;
    }
}