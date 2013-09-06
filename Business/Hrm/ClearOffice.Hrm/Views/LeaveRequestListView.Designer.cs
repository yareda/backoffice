namespace ClearOffice.Hrm.Views
{
    partial class LeaveRequestListView
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(LeaveRequestListView));
            this.ribbonControl1 = new DevExpress.XtraBars.Ribbon.RibbonControl();
            this.smallImageCollection = new DevExpress.Utils.ImageCollection();
            this.deleteBarButtonItem = new DevExpress.XtraBars.BarButtonItem();
            this.approveBarButtonItem = new DevExpress.XtraBars.BarButtonItem();
            this.refereshBarButtonItem = new DevExpress.XtraBars.BarButtonItem();
            this.largeImageCollection = new DevExpress.Utils.ImageCollection();
            this.ribbonPage1 = new DevExpress.XtraBars.Ribbon.RibbonPage();
            this.ribbonPageGroup1 = new DevExpress.XtraBars.Ribbon.RibbonPageGroup();
            this.gridControl1 = new DevExpress.XtraGrid.GridControl();
            this.leaveRequestsBindingSource = new System.Windows.Forms.BindingSource();
            this.gridView1 = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.colFrom = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colTo = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colNumDays = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colEmployeeFullName = new DevExpress.XtraGrid.Columns.GridColumn();
            ((System.ComponentModel.ISupportInitialize)(this.ribbonControl1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.smallImageCollection)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.largeImageCollection)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridControl1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.leaveRequestsBindingSource)).BeginInit();
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
            this.deleteBarButtonItem,
            this.approveBarButtonItem,
            this.refereshBarButtonItem});
            this.ribbonControl1.LargeImages = this.largeImageCollection;
            this.ribbonControl1.Location = new System.Drawing.Point(0, 0);
            this.ribbonControl1.MaxItemId = 4;
            this.ribbonControl1.MdiMergeStyle = DevExpress.XtraBars.Ribbon.RibbonMdiMergeStyle.Always;
            this.ribbonControl1.Name = "ribbonControl1";
            this.ribbonControl1.Pages.AddRange(new DevExpress.XtraBars.Ribbon.RibbonPage[] {
            this.ribbonPage1});
            this.ribbonControl1.SelectedPage = this.ribbonPage1;
            this.ribbonControl1.Size = new System.Drawing.Size(809, 143);
            // 
            // smallImageCollection
            // 
            this.smallImageCollection.ImageStream = ((DevExpress.Utils.ImageCollectionStreamer)(resources.GetObject("smallImageCollection.ImageStream")));
            this.smallImageCollection.Images.SetKeyName(0, "user-trash.png");
            this.smallImageCollection.Images.SetKeyName(1, "undo-16x16.png");
            this.smallImageCollection.Images.SetKeyName(2, "Cascade_16x16.png");
            this.smallImageCollection.Images.SetKeyName(3, "ActiveRents_16x16.png");
            this.smallImageCollection.Images.SetKeyName(4, "AddSort.png");
            this.smallImageCollection.Images.SetKeyName(5, "BO_Category.png");
            this.smallImageCollection.Images.SetKeyName(6, "BO_Task.png");
            this.smallImageCollection.Images.SetKeyName(7, "Cascade_16x16.png");
            this.smallImageCollection.Images.SetKeyName(8, "Categories_16x16.png");
            this.smallImageCollection.Images.SetKeyName(9, "Chart.png");
            this.smallImageCollection.Images.SetKeyName(10, "CheckBox.png");
            this.smallImageCollection.Images.SetKeyName(11, "CheckUp.png");
            this.smallImageCollection.Images.SetKeyName(12, "CustomersKPI_16x16.png");
            this.smallImageCollection.Images.SetKeyName(13, "Drafts_17.png");
            this.smallImageCollection.Images.SetKeyName(14, "EMail_16x16.png");
            this.smallImageCollection.Images.SetKeyName(15, "Filter_16x16.png");
            this.smallImageCollection.Images.SetKeyName(16, "Group_Administrator.png");
            this.smallImageCollection.Images.SetKeyName(17, "Group_KPI.png");
            this.smallImageCollection.Images.SetKeyName(18, "Navigation_16x16.png");
            this.smallImageCollection.Images.SetKeyName(19, "opened.png");
            this.smallImageCollection.Images.SetKeyName(20, "Order.png");
            this.smallImageCollection.Images.SetKeyName(21, "Panel.png");
            this.smallImageCollection.Images.SetKeyName(22, "Period_16x16.png");
            this.smallImageCollection.Images.SetKeyName(23, "save-16x16.png");
            this.smallImageCollection.Images.SetKeyName(24, "Shape.png");
            this.smallImageCollection.Images.SetKeyName(25, "Table.png");
            this.smallImageCollection.Images.SetKeyName(26, "To-Do-List_17.png");
            this.smallImageCollection.Images.SetKeyName(27, "UnmarkAll_16x16.png");
            this.smallImageCollection.Images.SetKeyName(28, "Upload_16x16.png");
            this.smallImageCollection.Images.SetKeyName(29, "Views_16x16.png");
            // 
            // deleteBarButtonItem
            // 
            this.deleteBarButtonItem.Caption = "Delete";
            this.deleteBarButtonItem.Id = 1;
            this.deleteBarButtonItem.LargeImageIndex = 1;
            this.deleteBarButtonItem.Name = "deleteBarButtonItem";
            this.deleteBarButtonItem.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.deleteBarButtonItem_ItemClick);
            // 
            // approveBarButtonItem
            // 
            this.approveBarButtonItem.Caption = "Approve";
            this.approveBarButtonItem.Id = 2;
            this.approveBarButtonItem.LargeImageIndex = 4;
            this.approveBarButtonItem.Name = "approveBarButtonItem";
            this.approveBarButtonItem.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.approveBarButtonItem_ItemClick);
            // 
            // refereshBarButtonItem
            // 
            this.refereshBarButtonItem.Caption = "Refresh";
            this.refereshBarButtonItem.Id = 3;
            this.refereshBarButtonItem.LargeImageIndex = 3;
            this.refereshBarButtonItem.Name = "refereshBarButtonItem";
            this.refereshBarButtonItem.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.refereshBarButtonItem_ItemClick);
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
            this.ribbonPageGroup1.ItemLinks.Add(this.deleteBarButtonItem);
            this.ribbonPageGroup1.ItemLinks.Add(this.approveBarButtonItem);
            this.ribbonPageGroup1.ItemLinks.Add(this.refereshBarButtonItem);
            this.ribbonPageGroup1.Name = "ribbonPageGroup1";
            this.ribbonPageGroup1.Text = "Leave Management";
            // 
            // gridControl1
            // 
            this.gridControl1.DataSource = this.leaveRequestsBindingSource;
            this.gridControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gridControl1.Location = new System.Drawing.Point(0, 143);
            this.gridControl1.MainView = this.gridView1;
            this.gridControl1.MenuManager = this.ribbonControl1;
            this.gridControl1.Name = "gridControl1";
            this.gridControl1.Size = new System.Drawing.Size(809, 248);
            this.gridControl1.TabIndex = 1;
            this.gridControl1.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridView1});
            this.gridControl1.DoubleClick += new System.EventHandler(this.gridControl1_DoubleClick);
            // 
            // leaveRequestsBindingSource
            // 
            this.leaveRequestsBindingSource.DataSource = typeof(ClearOffice.Hrm.Business.Data.EmployeePtoInfo);
            // 
            // gridView1
            // 
            this.gridView1.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.colFrom,
            this.colTo,
            this.colNumDays,
            this.colEmployeeFullName});
            this.gridView1.GridControl = this.gridControl1;
            this.gridView1.Name = "gridView1";
            this.gridView1.OptionsBehavior.Editable = false;
            this.gridView1.OptionsView.ShowAutoFilterRow = true;
            this.gridView1.OptionsView.ShowGroupPanel = false;
            // 
            // colFrom
            // 
            this.colFrom.FieldName = "From";
            this.colFrom.Name = "colFrom";
            this.colFrom.Visible = true;
            this.colFrom.VisibleIndex = 2;
            // 
            // colTo
            // 
            this.colTo.FieldName = "To";
            this.colTo.Name = "colTo";
            this.colTo.Visible = true;
            this.colTo.VisibleIndex = 3;
            // 
            // colNumDays
            // 
            this.colNumDays.Caption = "Number of days";
            this.colNumDays.FieldName = "NumDays";
            this.colNumDays.Name = "colNumDays";
            this.colNumDays.Visible = true;
            this.colNumDays.VisibleIndex = 1;
            // 
            // colEmployeeFullName
            // 
            this.colEmployeeFullName.FieldName = "EmployeeFullName";
            this.colEmployeeFullName.Name = "colEmployeeFullName";
            this.colEmployeeFullName.Visible = true;
            this.colEmployeeFullName.VisibleIndex = 0;
            // 
            // LeaveRequestListView
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(809, 391);
            this.Controls.Add(this.gridControl1);
            this.Controls.Add(this.ribbonControl1);
            this.Name = "LeaveRequestListView";
            this.Text = "Leave Requests";
            ((System.ComponentModel.ISupportInitialize)(this.ribbonControl1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.smallImageCollection)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.largeImageCollection)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridControl1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.leaveRequestsBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraBars.Ribbon.RibbonControl ribbonControl1;
        private DevExpress.XtraBars.Ribbon.RibbonPage ribbonPage1;
        private DevExpress.XtraBars.Ribbon.RibbonPageGroup ribbonPageGroup1;
        private DevExpress.XtraGrid.GridControl gridControl1;
        private DevExpress.XtraGrid.Views.Grid.GridView gridView1;
        private DevExpress.XtraBars.BarButtonItem deleteBarButtonItem;
        private DevExpress.Utils.ImageCollection smallImageCollection;
        private DevExpress.XtraBars.BarButtonItem approveBarButtonItem;
        private DevExpress.Utils.ImageCollection largeImageCollection;
        private System.Windows.Forms.BindingSource leaveRequestsBindingSource;
        private DevExpress.XtraGrid.Columns.GridColumn colFrom;
        private DevExpress.XtraGrid.Columns.GridColumn colTo;
        private DevExpress.XtraGrid.Columns.GridColumn colNumDays;
        private DevExpress.XtraGrid.Columns.GridColumn colEmployeeFullName;
        private DevExpress.XtraBars.BarButtonItem refereshBarButtonItem;
    }
}