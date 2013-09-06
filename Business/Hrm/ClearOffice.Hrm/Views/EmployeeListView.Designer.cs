namespace ClearOffice.Hrm.Views
{
    partial class EmployeeListView
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(EmployeeListView));
            this.ribbonControl1 = new DevExpress.XtraBars.Ribbon.RibbonControl();
            this.smallImageCollection = new DevExpress.Utils.ImageCollection(this.components);
            this.newEmployeeBarButtonItem = new DevExpress.XtraBars.BarButtonItem();
            this.showAllBarButtonItem = new DevExpress.XtraBars.BarButtonItem();
            this.refreshBarButtonItem = new DevExpress.XtraBars.BarButtonItem();
            this.requestLeaveBarButtonItem = new DevExpress.XtraBars.BarButtonItem();
            this.largeImageCollection = new DevExpress.Utils.ImageCollection(this.components);
            this.ribbonPage1 = new DevExpress.XtraBars.Ribbon.RibbonPage();
            this.ribbonPageGroup1 = new DevExpress.XtraBars.Ribbon.RibbonPageGroup();
            this.dockManager1 = new DevExpress.XtraBars.Docking.DockManager(this.components);
            this.dockPanel2 = new DevExpress.XtraBars.Docking.DockPanel();
            this.dockPanel2_Container = new DevExpress.XtraBars.Docking.ControlContainer();
            this.textEdit1 = new DevExpress.XtraEditors.TextEdit();
            this.simpleButton1 = new DevExpress.XtraEditors.SimpleButton();
            this.includeArchivedCheckEdit = new DevExpress.XtraEditors.CheckEdit();
            this.includeTerminatedCheckEdit = new DevExpress.XtraEditors.CheckEdit();
            this.dockPanel1 = new DevExpress.XtraBars.Docking.DockPanel();
            this.dockPanel1_Container = new DevExpress.XtraBars.Docking.ControlContainer();
            this.organizationTreeList = new DevExpress.XtraTreeList.TreeList();
            this.colNodeName = new DevExpress.XtraTreeList.Columns.TreeListColumn();
            this.organizationBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.gridControl1 = new DevExpress.XtraGrid.GridControl();
            this.employeeBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.gridView1 = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.colFullName = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colHireDate = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colEmployeeNo = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colSalary = new DevExpress.XtraGrid.Columns.GridColumn();
            this.newEmployeeBarBarButtonItem = new DevExpress.XtraBars.BarButtonItem();
            ((System.ComponentModel.ISupportInitialize)(this.ribbonControl1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.smallImageCollection)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.largeImageCollection)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dockManager1)).BeginInit();
            this.dockPanel2.SuspendLayout();
            this.dockPanel2_Container.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.textEdit1.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.includeArchivedCheckEdit.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.includeTerminatedCheckEdit.Properties)).BeginInit();
            this.dockPanel1.SuspendLayout();
            this.dockPanel1_Container.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.organizationTreeList)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.organizationBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridControl1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.employeeBindingSource)).BeginInit();
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
            this.newEmployeeBarButtonItem,
            this.showAllBarButtonItem,
            this.refreshBarButtonItem,
            this.requestLeaveBarButtonItem});
            this.ribbonControl1.LargeImages = this.largeImageCollection;
            this.ribbonControl1.Location = new System.Drawing.Point(0, 0);
            this.ribbonControl1.MaxItemId = 6;
            this.ribbonControl1.Name = "ribbonControl1";
            this.ribbonControl1.Pages.AddRange(new DevExpress.XtraBars.Ribbon.RibbonPage[] {
            this.ribbonPage1});
            this.ribbonControl1.SelectedPage = this.ribbonPage1;
            this.ribbonControl1.Size = new System.Drawing.Size(658, 143);
            // 
            // smallImageCollection
            // 
            this.smallImageCollection.ImageStream = ((DevExpress.Utils.ImageCollectionStreamer)(resources.GetObject("smallImageCollection.ImageStream")));
            this.smallImageCollection.Images.SetKeyName(0, "BO_Organizations.png");
            this.smallImageCollection.Images.SetKeyName(1, "Refresh_16x16.png");
            this.smallImageCollection.Images.SetKeyName(2, "new-16x16.png");
            this.smallImageCollection.Images.SetKeyName(3, "alarm-clock--plus.png");
            // 
            // newEmployeeBarButtonItem
            // 
            this.newEmployeeBarButtonItem.Caption = "New Employee";
            this.newEmployeeBarButtonItem.Id = 1;
            this.newEmployeeBarButtonItem.ImageIndex = 2;
            this.newEmployeeBarButtonItem.LargeImageIndex = 8;
            this.newEmployeeBarButtonItem.Name = "newEmployeeBarButtonItem";
            this.newEmployeeBarButtonItem.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.newEmployeeBarButtonItem_ItemClick);
            // 
            // showAllBarButtonItem
            // 
            this.showAllBarButtonItem.Caption = "Show All";
            this.showAllBarButtonItem.Id = 3;
            this.showAllBarButtonItem.ImageIndex = 0;
            this.showAllBarButtonItem.Name = "showAllBarButtonItem";
            this.showAllBarButtonItem.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.showAllBarButtonItem_ItemClick);
            // 
            // refreshBarButtonItem
            // 
            this.refreshBarButtonItem.Caption = "Refresh";
            this.refreshBarButtonItem.Id = 4;
            this.refreshBarButtonItem.ImageIndex = 1;
            this.refreshBarButtonItem.Name = "refreshBarButtonItem";
            this.refreshBarButtonItem.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.refreshBarButtonItem_ItemClick);
            // 
            // requestLeaveBarButtonItem
            // 
            this.requestLeaveBarButtonItem.Caption = "Request Leave";
            this.requestLeaveBarButtonItem.Id = 5;
            this.requestLeaveBarButtonItem.ImageIndex = 3;
            this.requestLeaveBarButtonItem.Name = "requestLeaveBarButtonItem";
            this.requestLeaveBarButtonItem.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.requestLeaveBarButtonItem_ItemClick);
            // 
            // largeImageCollection
            // 
            this.largeImageCollection.ImageSize = new System.Drawing.Size(32, 32);
            this.largeImageCollection.ImageStream = ((DevExpress.Utils.ImageCollectionStreamer)(resources.GetObject("largeImageCollection.ImageStream")));
            this.largeImageCollection.Images.SetKeyName(0, "save-32x32.png");
            this.largeImageCollection.Images.SetKeyName(1, "Delete_32x32.png");
            this.largeImageCollection.Images.SetKeyName(2, "appointment-new.png");
            this.largeImageCollection.Images.SetKeyName(3, "GenerateData_32x32.png");
            this.largeImageCollection.Images.SetKeyName(4, "ActiveRents_32x32.png");
            this.largeImageCollection.Images.SetKeyName(5, "SelectAllMarked_32x32.png");
            this.largeImageCollection.Images.SetKeyName(6, "open-32x32.png");
            this.largeImageCollection.Images.SetKeyName(7, "EMail_32x32.png");
            this.largeImageCollection.Images.SetKeyName(8, "new-32x32.png");
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
            this.ribbonPageGroup1.ItemLinks.Add(this.newEmployeeBarButtonItem);
            this.ribbonPageGroup1.ItemLinks.Add(this.refreshBarButtonItem);
            this.ribbonPageGroup1.ItemLinks.Add(this.showAllBarButtonItem);
            this.ribbonPageGroup1.ItemLinks.Add(this.requestLeaveBarButtonItem);
            this.ribbonPageGroup1.Name = "ribbonPageGroup1";
            this.ribbonPageGroup1.Text = "Employees";
            // 
            // dockManager1
            // 
            this.dockManager1.Form = this;
            this.dockManager1.HiddenPanels.AddRange(new DevExpress.XtraBars.Docking.DockPanel[] {
            this.dockPanel2});
            this.dockManager1.RootPanels.AddRange(new DevExpress.XtraBars.Docking.DockPanel[] {
            this.dockPanel1});
            this.dockManager1.TopZIndexControls.AddRange(new string[] {
            "DevExpress.XtraBars.BarDockControl",
            "DevExpress.XtraBars.StandaloneBarDockControl",
            "System.Windows.Forms.StatusBar",
            "DevExpress.XtraBars.Ribbon.RibbonStatusBar",
            "DevExpress.XtraBars.Ribbon.RibbonControl"});
            // 
            // dockPanel2
            // 
            this.dockPanel2.Controls.Add(this.dockPanel2_Container);
            this.dockPanel2.Dock = DevExpress.XtraBars.Docking.DockingStyle.Fill;
            this.dockPanel2.ID = new System.Guid("07a4aa36-3d72-4223-bc37-f486f525fc68");
            this.dockPanel2.Location = new System.Drawing.Point(4, 23);
            this.dockPanel2.Name = "dockPanel2";
            this.dockPanel2.OriginalSize = new System.Drawing.Size(200, 200);
            this.dockPanel2.SavedDock = DevExpress.XtraBars.Docking.DockingStyle.Fill;
            this.dockPanel2.SavedIndex = 1;
            this.dockPanel2.SavedParent = this.dockPanel1;
            this.dockPanel2.SavedTabbed = true;
            this.dockPanel2.Size = new System.Drawing.Size(273, 356);
            this.dockPanel2.Text = "Search";
            this.dockPanel2.Visibility = DevExpress.XtraBars.Docking.DockVisibility.Hidden;
            // 
            // dockPanel2_Container
            // 
            this.dockPanel2_Container.Controls.Add(this.textEdit1);
            this.dockPanel2_Container.Controls.Add(this.simpleButton1);
            this.dockPanel2_Container.Controls.Add(this.includeArchivedCheckEdit);
            this.dockPanel2_Container.Controls.Add(this.includeTerminatedCheckEdit);
            this.dockPanel2_Container.Location = new System.Drawing.Point(0, 0);
            this.dockPanel2_Container.Name = "dockPanel2_Container";
            this.dockPanel2_Container.Size = new System.Drawing.Size(273, 356);
            this.dockPanel2_Container.TabIndex = 0;
            // 
            // textEdit1
            // 
            this.textEdit1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.textEdit1.Location = new System.Drawing.Point(6, 5);
            this.textEdit1.MenuManager = this.ribbonControl1;
            this.textEdit1.Name = "textEdit1";
            this.textEdit1.Size = new System.Drawing.Size(261, 20);
            this.textEdit1.TabIndex = 5;
            // 
            // simpleButton1
            // 
            this.simpleButton1.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.simpleButton1.Location = new System.Drawing.Point(110, 31);
            this.simpleButton1.Name = "simpleButton1";
            this.simpleButton1.Size = new System.Drawing.Size(52, 23);
            this.simpleButton1.TabIndex = 4;
            this.simpleButton1.Text = "Search";
            // 
            // includeArchivedCheckEdit
            // 
            this.includeArchivedCheckEdit.Location = new System.Drawing.Point(7, 87);
            this.includeArchivedCheckEdit.MenuManager = this.ribbonControl1;
            this.includeArchivedCheckEdit.Name = "includeArchivedCheckEdit";
            this.includeArchivedCheckEdit.Properties.Caption = "Include archived employees.";
            this.includeArchivedCheckEdit.Size = new System.Drawing.Size(178, 19);
            this.includeArchivedCheckEdit.TabIndex = 3;
            // 
            // includeTerminatedCheckEdit
            // 
            this.includeTerminatedCheckEdit.Location = new System.Drawing.Point(7, 62);
            this.includeTerminatedCheckEdit.MenuManager = this.ribbonControl1;
            this.includeTerminatedCheckEdit.Name = "includeTerminatedCheckEdit";
            this.includeTerminatedCheckEdit.Properties.Caption = "Include terminated employees.";
            this.includeTerminatedCheckEdit.Size = new System.Drawing.Size(195, 19);
            this.includeTerminatedCheckEdit.TabIndex = 2;
            // 
            // dockPanel1
            // 
            this.dockPanel1.Controls.Add(this.dockPanel1_Container);
            this.dockPanel1.Dock = DevExpress.XtraBars.Docking.DockingStyle.Left;
            this.dockPanel1.FloatVertical = true;
            this.dockPanel1.ID = new System.Guid("70add0de-c694-4a3f-8bf1-f1d48a3c1700");
            this.dockPanel1.Location = new System.Drawing.Point(0, 143);
            this.dockPanel1.Name = "dockPanel1";
            this.dockPanel1.OriginalSize = new System.Drawing.Size(281, 200);
            this.dockPanel1.Size = new System.Drawing.Size(281, 410);
            this.dockPanel1.Text = "Organization Hierarchy";
            // 
            // dockPanel1_Container
            // 
            this.dockPanel1_Container.Controls.Add(this.organizationTreeList);
            this.dockPanel1_Container.Location = new System.Drawing.Point(4, 23);
            this.dockPanel1_Container.Name = "dockPanel1_Container";
            this.dockPanel1_Container.Size = new System.Drawing.Size(273, 383);
            this.dockPanel1_Container.TabIndex = 0;
            // 
            // organizationTreeList
            // 
            this.organizationTreeList.Columns.AddRange(new DevExpress.XtraTreeList.Columns.TreeListColumn[] {
            this.colNodeName});
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
            this.organizationTreeList.Size = new System.Drawing.Size(273, 383);
            this.organizationTreeList.TabIndex = 0;
            this.organizationTreeList.CustomDrawNodeCell += new DevExpress.XtraTreeList.CustomDrawNodeCellEventHandler(this.organizationTreeList_CustomDrawNodeCell);
            this.organizationTreeList.Click += new System.EventHandler(this.organizationTreeList_DoubleClick);
            this.organizationTreeList.DoubleClick += new System.EventHandler(this.organizationTreeList_DoubleClick);
            // 
            // colNodeName
            // 
            this.colNodeName.FieldName = "NodeName";
            this.colNodeName.Name = "colNodeName";
            this.colNodeName.Visible = true;
            this.colNodeName.VisibleIndex = 0;
            this.colNodeName.Width = 26;
            // 
            // organizationBindingSource
            // 
            this.organizationBindingSource.DataSource = typeof(ClearOffice.Hrm.Business.Data.Organization);
            // 
            // gridControl1
            // 
            this.gridControl1.DataSource = this.employeeBindingSource;
            this.gridControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gridControl1.Location = new System.Drawing.Point(281, 143);
            this.gridControl1.MainView = this.gridView1;
            this.gridControl1.MenuManager = this.ribbonControl1;
            this.gridControl1.Name = "gridControl1";
            this.gridControl1.Size = new System.Drawing.Size(377, 410);
            this.gridControl1.TabIndex = 1;
            this.gridControl1.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridView1});
            this.gridControl1.DoubleClick += new System.EventHandler(this.gridControl1_DoubleClick);
            // 
            // employeeBindingSource
            // 
            this.employeeBindingSource.DataSource = typeof(ClearOffice.Hrm.Business.Data.EmployeeInfo);
            // 
            // gridView1
            // 
            this.gridView1.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.colFullName,
            this.colHireDate,
            this.colEmployeeNo,
            this.colSalary});
            this.gridView1.GridControl = this.gridControl1;
            this.gridView1.Name = "gridView1";
            this.gridView1.OptionsBehavior.Editable = false;
            this.gridView1.OptionsView.ShowAutoFilterRow = true;
            this.gridView1.OptionsView.ShowGroupedColumns = true;
            this.gridView1.OptionsView.ShowGroupPanel = false;
            // 
            // colFullName
            // 
            this.colFullName.DisplayFormat.FormatString = "{0:#,##0.00;(#,##0.00);\\\'\\\'}";
            this.colFullName.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Custom;
            this.colFullName.FieldName = "FullName";
            this.colFullName.Name = "colFullName";
            this.colFullName.Visible = true;
            this.colFullName.VisibleIndex = 0;
            // 
            // colHireDate
            // 
            this.colHireDate.Caption = "Hired Date";
            this.colHireDate.FieldName = "HireDate";
            this.colHireDate.Name = "colHireDate";
            this.colHireDate.Visible = true;
            this.colHireDate.VisibleIndex = 1;
            // 
            // colEmployeeNo
            // 
            this.colEmployeeNo.Caption = "Employee #";
            this.colEmployeeNo.FieldName = "EmployeeNo";
            this.colEmployeeNo.Name = "colEmployeeNo";
            this.colEmployeeNo.Visible = true;
            this.colEmployeeNo.VisibleIndex = 2;
            // 
            // colSalary
            // 
            this.colSalary.DisplayFormat.FormatString = "{0:#,##0.00;(#,##0.00);\\\'\\\'}";
            this.colSalary.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Custom;
            this.colSalary.FieldName = "Salary";
            this.colSalary.Name = "colSalary";
            this.colSalary.Visible = true;
            this.colSalary.VisibleIndex = 3;
            // 
            // newEmployeeBarBarButtonItem
            // 
            this.newEmployeeBarBarButtonItem.Caption = "New Employee";
            this.newEmployeeBarBarButtonItem.Id = 1;
            this.newEmployeeBarBarButtonItem.Name = "newEmployeeBarBarButtonItem";
            this.newEmployeeBarBarButtonItem.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.newEmployeeBarButtonItem_ItemClick);
            // 
            // EmployeeListView
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(658, 553);
            this.Controls.Add(this.gridControl1);
            this.Controls.Add(this.dockPanel1);
            this.Controls.Add(this.ribbonControl1);
            this.Name = "EmployeeListView";
            this.Text = "Employees";
            ((System.ComponentModel.ISupportInitialize)(this.ribbonControl1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.smallImageCollection)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.largeImageCollection)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dockManager1)).EndInit();
            this.dockPanel2.ResumeLayout(false);
            this.dockPanel2_Container.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.textEdit1.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.includeArchivedCheckEdit.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.includeTerminatedCheckEdit.Properties)).EndInit();
            this.dockPanel1.ResumeLayout(false);
            this.dockPanel1_Container.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.organizationTreeList)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.organizationBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridControl1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.employeeBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraBars.Ribbon.RibbonControl ribbonControl1;
        private DevExpress.XtraBars.Ribbon.RibbonPage ribbonPage1;
        private DevExpress.XtraBars.Ribbon.RibbonPageGroup ribbonPageGroup1;
        private DevExpress.XtraBars.Docking.DockManager dockManager1;
        private DevExpress.XtraGrid.GridControl gridControl1;
        private DevExpress.XtraGrid.Views.Grid.GridView gridView1;
        private DevExpress.XtraBars.Docking.DockPanel dockPanel1;
        private DevExpress.XtraBars.Docking.ControlContainer dockPanel1_Container;
        private DevExpress.XtraBars.BarButtonItem newEmployeeBarButtonItem;
        private System.Windows.Forms.BindingSource employeeBindingSource;
        private DevExpress.XtraGrid.Columns.GridColumn colFullName;
        private DevExpress.XtraGrid.Columns.GridColumn colHireDate;
        private DevExpress.XtraGrid.Columns.GridColumn colEmployeeNo;
        private DevExpress.XtraGrid.Columns.GridColumn colSalary;
        private DevExpress.XtraBars.BarButtonItem newEmployeeBarBarButtonItem;
        private DevExpress.Utils.ImageCollection smallImageCollection;
        private DevExpress.Utils.ImageCollection largeImageCollection;
        private DevExpress.XtraTreeList.TreeList organizationTreeList;
        private System.Windows.Forms.BindingSource organizationBindingSource;
        private DevExpress.XtraTreeList.Columns.TreeListColumn colNodeName;
        private DevExpress.XtraBars.BarButtonItem showAllBarButtonItem;
        private DevExpress.XtraBars.BarButtonItem refreshBarButtonItem;
        private DevExpress.XtraBars.Docking.DockPanel dockPanel2;
        private DevExpress.XtraBars.Docking.ControlContainer dockPanel2_Container;
        private DevExpress.XtraEditors.TextEdit textEdit1;
        private DevExpress.XtraEditors.SimpleButton simpleButton1;
        private DevExpress.XtraEditors.CheckEdit includeArchivedCheckEdit;
        private DevExpress.XtraEditors.CheckEdit includeTerminatedCheckEdit;
        private DevExpress.XtraBars.BarButtonItem requestLeaveBarButtonItem;
    }
}