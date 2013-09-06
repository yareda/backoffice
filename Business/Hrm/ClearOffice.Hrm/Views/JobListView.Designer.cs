namespace ClearOffice.Hrm.Views
{
    partial class JobListView
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(JobListView));
            DevExpress.Utils.SuperToolTip superToolTip1 = new DevExpress.Utils.SuperToolTip();
            DevExpress.Utils.ToolTipTitleItem toolTipTitleItem1 = new DevExpress.Utils.ToolTipTitleItem();
            DevExpress.Utils.ToolTipItem toolTipItem1 = new DevExpress.Utils.ToolTipItem();
            DevExpress.Utils.SuperToolTip superToolTip2 = new DevExpress.Utils.SuperToolTip();
            DevExpress.Utils.ToolTipTitleItem toolTipTitleItem2 = new DevExpress.Utils.ToolTipTitleItem();
            DevExpress.Utils.ToolTipItem toolTipItem2 = new DevExpress.Utils.ToolTipItem();
            this.ribbonControl1 = new DevExpress.XtraBars.Ribbon.RibbonControl();
            this.smallImageCollection = new DevExpress.Utils.ImageCollection(this.components);
            this.departmentsBarButtonItem = new DevExpress.XtraBars.BarButtonItem();
            this.btnNewJob = new DevExpress.XtraBars.BarButtonItem();
            this.profileBarButtonItem = new DevExpress.XtraBars.BarButtonItem();
            this.largeImageCollection = new DevExpress.Utils.ImageCollection(this.components);
            this.jobListRibbonPage = new DevExpress.XtraBars.Ribbon.RibbonPage();
            this.ribbonPageGroup1 = new DevExpress.XtraBars.Ribbon.RibbonPageGroup();
            this.dockManager1 = new DevExpress.XtraBars.Docking.DockManager(this.components);
            this.panelContainer1 = new DevExpress.XtraBars.Docking.DockPanel();
            this.dockPanel1 = new DevExpress.XtraBars.Docking.DockPanel();
            this.dockPanel1_Container = new DevExpress.XtraBars.Docking.ControlContainer();
            this.organizationTreeList = new DevExpress.XtraTreeList.TreeList();
            this.treeListColumn1 = new DevExpress.XtraTreeList.Columns.TreeListColumn();
            this.organizationBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.dockPanel2 = new DevExpress.XtraBars.Docking.DockPanel();
            this.dockPanel2_Container = new DevExpress.XtraBars.Docking.ControlContainer();
            this.simpleButton1 = new DevExpress.XtraEditors.SimpleButton();
            this.labelControl1 = new DevExpress.XtraEditors.LabelControl();
            this.textEdit1 = new DevExpress.XtraEditors.TextEdit();
            this.gridControl1 = new DevExpress.XtraGrid.GridControl();
            this.jobListBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.gridView1 = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.colJobTitle = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colJobSummary = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colNodeName = new DevExpress.XtraGrid.Columns.GridColumn();
            ((System.ComponentModel.ISupportInitialize)(this.ribbonControl1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.smallImageCollection)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.largeImageCollection)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dockManager1)).BeginInit();
            this.panelContainer1.SuspendLayout();
            this.dockPanel1.SuspendLayout();
            this.dockPanel1_Container.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.organizationTreeList)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.organizationBindingSource)).BeginInit();
            this.dockPanel2.SuspendLayout();
            this.dockPanel2_Container.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.textEdit1.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridControl1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.jobListBindingSource)).BeginInit();
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
            this.departmentsBarButtonItem,
            this.btnNewJob,
            this.profileBarButtonItem});
            this.ribbonControl1.LargeImages = this.largeImageCollection;
            this.ribbonControl1.Location = new System.Drawing.Point(0, 0);
            this.ribbonControl1.MaxItemId = 11;
            this.ribbonControl1.MdiMergeStyle = DevExpress.XtraBars.Ribbon.RibbonMdiMergeStyle.Always;
            this.ribbonControl1.Name = "ribbonControl1";
            this.ribbonControl1.Pages.AddRange(new DevExpress.XtraBars.Ribbon.RibbonPage[] {
            this.jobListRibbonPage});
            this.ribbonControl1.SelectedPage = this.jobListRibbonPage;
            this.ribbonControl1.Size = new System.Drawing.Size(787, 143);
            // 
            // smallImageCollection
            // 
            this.smallImageCollection.ImageStream = ((DevExpress.Utils.ImageCollectionStreamer)(resources.GetObject("smallImageCollection.ImageStream")));
            this.smallImageCollection.Images.SetKeyName(0, "chart_organisation.png");
            this.smallImageCollection.Images.SetKeyName(1, "Group_Catalog.png");
            this.smallImageCollection.Images.SetKeyName(2, "building.png");
            // 
            // departmentsBarButtonItem
            // 
            this.departmentsBarButtonItem.Caption = "Add Node";
            this.departmentsBarButtonItem.Id = 2;
            this.departmentsBarButtonItem.ImageIndex = 0;
            this.departmentsBarButtonItem.Name = "departmentsBarButtonItem";
            toolTipTitleItem1.Text = "New Organizational Entity";
            toolTipItem1.LeftIndent = 6;
            toolTipItem1.Text = "Allows you to add new organizational entity to your hierarchy. Use this to add ne" +
    "w department, division, project, unit or team.";
            superToolTip1.Items.Add(toolTipTitleItem1);
            superToolTip1.Items.Add(toolTipItem1);
            this.departmentsBarButtonItem.SuperTip = superToolTip1;
            this.departmentsBarButtonItem.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.departmentsBarButtonItem_ItemClick);
            // 
            // btnNewJob
            // 
            this.btnNewJob.Caption = "Add Position";
            this.btnNewJob.Id = 9;
            this.btnNewJob.ImageIndex = 1;
            this.btnNewJob.Name = "btnNewJob";
            toolTipTitleItem2.Text = "Add New Position";
            toolTipItem2.LeftIndent = 6;
            toolTipItem2.Text = "This is where you add positions/job to your organizational hierarchy. You can add" +
    " detail information about the position/job like competency, requirements and job" +
    " description.";
            superToolTip2.Items.Add(toolTipTitleItem2);
            superToolTip2.Items.Add(toolTipItem2);
            this.btnNewJob.SuperTip = superToolTip2;
            this.btnNewJob.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.btnNewJob_ItemClick);
            // 
            // profileBarButtonItem
            // 
            this.profileBarButtonItem.Caption = "Organization Profile";
            this.profileBarButtonItem.Id = 10;
            this.profileBarButtonItem.ImageIndex = 2;
            this.profileBarButtonItem.Name = "profileBarButtonItem";
            this.profileBarButtonItem.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.profileBarButtonItem_ItemClick);
            // 
            // largeImageCollection
            // 
            this.largeImageCollection.ImageSize = new System.Drawing.Size(32, 32);
            this.largeImageCollection.ImageStream = ((DevExpress.Utils.ImageCollectionStreamer)(resources.GetObject("largeImageCollection.ImageStream")));
            this.largeImageCollection.Images.SetKeyName(0, "preferences-system.png");
            this.largeImageCollection.Images.SetKeyName(1, "package-x-generic.png");
            this.largeImageCollection.Images.SetKeyName(2, "applications-internet.png");
            // 
            // jobListRibbonPage
            // 
            this.jobListRibbonPage.Groups.AddRange(new DevExpress.XtraBars.Ribbon.RibbonPageGroup[] {
            this.ribbonPageGroup1});
            this.jobListRibbonPage.Name = "jobListRibbonPage";
            this.jobListRibbonPage.Text = "Human Resource";
            // 
            // ribbonPageGroup1
            // 
            this.ribbonPageGroup1.ItemLinks.Add(this.departmentsBarButtonItem);
            this.ribbonPageGroup1.ItemLinks.Add(this.btnNewJob);
            this.ribbonPageGroup1.ItemLinks.Add(this.profileBarButtonItem);
            this.ribbonPageGroup1.Name = "ribbonPageGroup1";
            this.ribbonPageGroup1.Text = "Organization";
            // 
            // dockManager1
            // 
            this.dockManager1.Form = this;
            this.dockManager1.RootPanels.AddRange(new DevExpress.XtraBars.Docking.DockPanel[] {
            this.panelContainer1});
            this.dockManager1.TopZIndexControls.AddRange(new string[] {
            "DevExpress.XtraBars.BarDockControl",
            "DevExpress.XtraBars.StandaloneBarDockControl",
            "System.Windows.Forms.StatusBar",
            "DevExpress.XtraBars.Ribbon.RibbonStatusBar",
            "DevExpress.XtraBars.Ribbon.RibbonControl"});
            // 
            // panelContainer1
            // 
            this.panelContainer1.ActiveChild = this.dockPanel1;
            this.panelContainer1.Controls.Add(this.dockPanel1);
            this.panelContainer1.Controls.Add(this.dockPanel2);
            this.panelContainer1.Dock = DevExpress.XtraBars.Docking.DockingStyle.Left;
            this.panelContainer1.FloatVertical = true;
            this.panelContainer1.ID = new System.Guid("271a87fa-f933-4381-b6ea-6682648e7b39");
            this.panelContainer1.Location = new System.Drawing.Point(0, 143);
            this.panelContainer1.Name = "panelContainer1";
            this.panelContainer1.OriginalSize = new System.Drawing.Size(282, 200);
            this.panelContainer1.Size = new System.Drawing.Size(282, 389);
            this.panelContainer1.Tabbed = true;
            this.panelContainer1.Text = "panelContainer1";
            // 
            // dockPanel1
            // 
            this.dockPanel1.Controls.Add(this.dockPanel1_Container);
            this.dockPanel1.Dock = DevExpress.XtraBars.Docking.DockingStyle.Fill;
            this.dockPanel1.FloatVertical = true;
            this.dockPanel1.ID = new System.Guid("aafb62a5-d5c1-48ac-af06-5beaaf2d231c");
            this.dockPanel1.Location = new System.Drawing.Point(4, 23);
            this.dockPanel1.Name = "dockPanel1";
            this.dockPanel1.OriginalSize = new System.Drawing.Size(250, 335);
            this.dockPanel1.Size = new System.Drawing.Size(274, 335);
            this.dockPanel1.Text = "Organization Hierarchy";
            // 
            // dockPanel1_Container
            // 
            this.dockPanel1_Container.Controls.Add(this.organizationTreeList);
            this.dockPanel1_Container.Location = new System.Drawing.Point(0, 0);
            this.dockPanel1_Container.Name = "dockPanel1_Container";
            this.dockPanel1_Container.Size = new System.Drawing.Size(274, 335);
            this.dockPanel1_Container.TabIndex = 0;
            // 
            // organizationTreeList
            // 
            this.organizationTreeList.Columns.AddRange(new DevExpress.XtraTreeList.Columns.TreeListColumn[] {
            this.treeListColumn1});
            this.organizationTreeList.DataSource = this.organizationBindingSource;
            this.organizationTreeList.Dock = System.Windows.Forms.DockStyle.Fill;
            this.organizationTreeList.KeyFieldName = "NodeId";
            this.organizationTreeList.Location = new System.Drawing.Point(0, 0);
            this.organizationTreeList.Name = "organizationTreeList";
            this.organizationTreeList.OptionsBehavior.Editable = false;
            this.organizationTreeList.OptionsView.ShowColumns = false;
            this.organizationTreeList.OptionsView.ShowHorzLines = false;
            this.organizationTreeList.OptionsView.ShowIndicator = false;
            this.organizationTreeList.OptionsView.ShowVertLines = false;
            this.organizationTreeList.ParentFieldName = "ParentId";
            this.organizationTreeList.PreviewFieldName = "NodeName";
            this.organizationTreeList.Size = new System.Drawing.Size(274, 335);
            this.organizationTreeList.TabIndex = 1;
            this.organizationTreeList.CustomDrawNodeCell += new DevExpress.XtraTreeList.CustomDrawNodeCellEventHandler(this.organizationTreeList_CustomDrawNodeCell);
            this.organizationTreeList.Click += new System.EventHandler(this.organizationTreeList_DoubleClick);
            this.organizationTreeList.DoubleClick += new System.EventHandler(this.organizationTreeList_DoubleClick);
            // 
            // treeListColumn1
            // 
            this.treeListColumn1.FieldName = "NodeName";
            this.treeListColumn1.Name = "treeListColumn1";
            this.treeListColumn1.Visible = true;
            this.treeListColumn1.VisibleIndex = 0;
            this.treeListColumn1.Width = 26;
            // 
            // organizationBindingSource
            // 
            this.organizationBindingSource.DataSource = typeof(ClearOffice.Hrm.Business.Data.Organization);
            // 
            // dockPanel2
            // 
            this.dockPanel2.Controls.Add(this.dockPanel2_Container);
            this.dockPanel2.Dock = DevExpress.XtraBars.Docking.DockingStyle.Fill;
            this.dockPanel2.ID = new System.Guid("b7fb5670-5220-4c81-933e-68933fa427dc");
            this.dockPanel2.Location = new System.Drawing.Point(4, 23);
            this.dockPanel2.Name = "dockPanel2";
            this.dockPanel2.OriginalSize = new System.Drawing.Size(250, 335);
            this.dockPanel2.Size = new System.Drawing.Size(274, 335);
            this.dockPanel2.Text = "Search";
            // 
            // dockPanel2_Container
            // 
            this.dockPanel2_Container.Controls.Add(this.simpleButton1);
            this.dockPanel2_Container.Controls.Add(this.labelControl1);
            this.dockPanel2_Container.Controls.Add(this.textEdit1);
            this.dockPanel2_Container.Location = new System.Drawing.Point(0, 0);
            this.dockPanel2_Container.Name = "dockPanel2_Container";
            this.dockPanel2_Container.Size = new System.Drawing.Size(274, 335);
            this.dockPanel2_Container.TabIndex = 0;
            // 
            // simpleButton1
            // 
            this.simpleButton1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.simpleButton1.Location = new System.Drawing.Point(171, 56);
            this.simpleButton1.Name = "simpleButton1";
            this.simpleButton1.Size = new System.Drawing.Size(91, 23);
            this.simpleButton1.TabIndex = 2;
            this.simpleButton1.Text = "Search";
            // 
            // labelControl1
            // 
            this.labelControl1.Location = new System.Drawing.Point(8, 11);
            this.labelControl1.Name = "labelControl1";
            this.labelControl1.Size = new System.Drawing.Size(61, 13);
            this.labelControl1.TabIndex = 1;
            this.labelControl1.Text = "Position/Title";
            // 
            // textEdit1
            // 
            this.textEdit1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.textEdit1.Location = new System.Drawing.Point(8, 30);
            this.textEdit1.MenuManager = this.ribbonControl1;
            this.textEdit1.Name = "textEdit1";
            this.textEdit1.Size = new System.Drawing.Size(254, 20);
            this.textEdit1.TabIndex = 0;
            // 
            // gridControl1
            // 
            this.gridControl1.DataSource = this.jobListBindingSource;
            this.gridControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gridControl1.Location = new System.Drawing.Point(282, 143);
            this.gridControl1.MainView = this.gridView1;
            this.gridControl1.MenuManager = this.ribbonControl1;
            this.gridControl1.Name = "gridControl1";
            this.gridControl1.Size = new System.Drawing.Size(505, 389);
            this.gridControl1.TabIndex = 1;
            this.gridControl1.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridView1});
            this.gridControl1.DoubleClick += new System.EventHandler(this.gridControl1_DoubleClick);
            // 
            // jobListBindingSource
            // 
            this.jobListBindingSource.DataSource = typeof(ClearOffice.Hrm.Business.Data.JobInfo);
            // 
            // gridView1
            // 
            this.gridView1.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.colJobTitle,
            this.colJobSummary,
            this.colNodeName});
            this.gridView1.GridControl = this.gridControl1;
            this.gridView1.Name = "gridView1";
            this.gridView1.OptionsBehavior.Editable = false;
            this.gridView1.OptionsView.ShowAutoFilterRow = true;
            this.gridView1.OptionsView.ShowGroupPanel = false;
            // 
            // colJobTitle
            // 
            this.colJobTitle.Caption = "Job Title";
            this.colJobTitle.FieldName = "JobTitle";
            this.colJobTitle.Name = "colJobTitle";
            this.colJobTitle.Visible = true;
            this.colJobTitle.VisibleIndex = 0;
            // 
            // colJobSummary
            // 
            this.colJobSummary.Caption = "Summary";
            this.colJobSummary.FieldName = "JobSummary";
            this.colJobSummary.Name = "colJobSummary";
            this.colJobSummary.Visible = true;
            this.colJobSummary.VisibleIndex = 1;
            // 
            // colNodeName
            // 
            this.colNodeName.Caption = "Department";
            this.colNodeName.FieldName = "NodeName";
            this.colNodeName.Name = "colNodeName";
            this.colNodeName.Visible = true;
            this.colNodeName.VisibleIndex = 2;
            // 
            // JobListView
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(787, 532);
            this.Controls.Add(this.gridControl1);
            this.Controls.Add(this.panelContainer1);
            this.Controls.Add(this.ribbonControl1);
            this.Name = "JobListView";
            this.Text = "Positions & Jobs";
            this.Activated += new System.EventHandler(this.JobListView_Activated);
            ((System.ComponentModel.ISupportInitialize)(this.ribbonControl1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.smallImageCollection)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.largeImageCollection)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dockManager1)).EndInit();
            this.panelContainer1.ResumeLayout(false);
            this.dockPanel1.ResumeLayout(false);
            this.dockPanel1_Container.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.organizationTreeList)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.organizationBindingSource)).EndInit();
            this.dockPanel2.ResumeLayout(false);
            this.dockPanel2_Container.ResumeLayout(false);
            this.dockPanel2_Container.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.textEdit1.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridControl1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.jobListBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraBars.Ribbon.RibbonControl ribbonControl1;
        private DevExpress.XtraBars.Ribbon.RibbonPage jobListRibbonPage;
        private DevExpress.XtraBars.Ribbon.RibbonPageGroup ribbonPageGroup1;
        private DevExpress.XtraBars.Docking.DockManager dockManager1;
        private DevExpress.XtraGrid.GridControl gridControl1;
        private DevExpress.XtraGrid.Views.Grid.GridView gridView1;
        private DevExpress.XtraBars.Docking.DockPanel dockPanel1;
        private DevExpress.XtraBars.Docking.ControlContainer dockPanel1_Container;
        private DevExpress.XtraBars.BarButtonItem departmentsBarButtonItem;
        private DevExpress.Utils.ImageCollection smallImageCollection;
        private DevExpress.Utils.ImageCollection largeImageCollection;
        private DevExpress.XtraBars.Docking.DockPanel panelContainer1;
        private DevExpress.XtraBars.Docking.DockPanel dockPanel2;
        private DevExpress.XtraBars.Docking.ControlContainer dockPanel2_Container;
        private DevExpress.XtraEditors.SimpleButton simpleButton1;
        private DevExpress.XtraEditors.LabelControl labelControl1;
        private DevExpress.XtraEditors.TextEdit textEdit1;
        private System.Windows.Forms.BindingSource jobListBindingSource;
        private DevExpress.XtraGrid.Columns.GridColumn colJobTitle;
        private DevExpress.XtraGrid.Columns.GridColumn colJobSummary;
        private DevExpress.XtraGrid.Columns.GridColumn colNodeName;
        private DevExpress.XtraBars.BarButtonItem btnNewJob;
        private DevExpress.XtraTreeList.TreeList organizationTreeList;
        private DevExpress.XtraTreeList.Columns.TreeListColumn treeListColumn1;
        private System.Windows.Forms.BindingSource organizationBindingSource;
        private DevExpress.XtraBars.BarButtonItem profileBarButtonItem;
        private DevExpress.XtraBars.BarButtonItem barButtonItem1;
      

    }
}