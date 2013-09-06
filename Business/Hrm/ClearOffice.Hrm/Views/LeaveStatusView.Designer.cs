namespace ClearOffice.Hrm.Views
{
    partial class LeaveStatusView
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(LeaveStatusView));
            this.leaveStatusBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.ribbonControl1 = new DevExpress.XtraBars.Ribbon.RibbonControl();
            this.smallImageCollection = new DevExpress.Utils.ImageCollection(this.components);
            this.refreshBarButtonItem = new DevExpress.XtraBars.BarButtonItem();
            this.largeImageCollection = new DevExpress.Utils.ImageCollection(this.components);
            this.ribbonPage1 = new DevExpress.XtraBars.Ribbon.RibbonPage();
            this.ribbonPageGroup1 = new DevExpress.XtraBars.Ribbon.RibbonPageGroup();
            this.gridControl1 = new DevExpress.XtraGrid.GridControl();
            this.gridView1 = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.colEmployeeFullName = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colPrevCount = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colCurrentCount = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colTotal = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colEmployeeNo = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colHireDate = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colServiceYear = new DevExpress.XtraGrid.Columns.GridColumn();
            ((System.ComponentModel.ISupportInitialize)(this.leaveStatusBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ribbonControl1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.smallImageCollection)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.largeImageCollection)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridControl1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // leaveStatusBindingSource
            // 
            this.leaveStatusBindingSource.DataSource = typeof(ClearOffice.Hrm.Business.Data.EmployeePtoStatusInfo);
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
            this.refreshBarButtonItem});
            this.ribbonControl1.LargeImages = this.largeImageCollection;
            this.ribbonControl1.Location = new System.Drawing.Point(0, 0);
            this.ribbonControl1.MaxItemId = 2;
            this.ribbonControl1.Name = "ribbonControl1";
            this.ribbonControl1.Pages.AddRange(new DevExpress.XtraBars.Ribbon.RibbonPage[] {
            this.ribbonPage1});
            this.ribbonControl1.SelectedPage = this.ribbonPage1;
            this.ribbonControl1.Size = new System.Drawing.Size(824, 143);
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
            // refreshBarButtonItem
            // 
            this.refreshBarButtonItem.Caption = "Refresh ";
            this.refreshBarButtonItem.Id = 1;
            this.refreshBarButtonItem.LargeImageIndex = 3;
            this.refreshBarButtonItem.Name = "refreshBarButtonItem";
            this.refreshBarButtonItem.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.refreshBarButtonItem_ItemClick);
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
            this.ribbonPageGroup1.ItemLinks.Add(this.refreshBarButtonItem);
            this.ribbonPageGroup1.Name = "ribbonPageGroup1";
            this.ribbonPageGroup1.Text = "Leave Management";
            // 
            // gridControl1
            // 
            this.gridControl1.DataSource = this.leaveStatusBindingSource;
            this.gridControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gridControl1.Location = new System.Drawing.Point(0, 143);
            this.gridControl1.MainView = this.gridView1;
            this.gridControl1.Name = "gridControl1";
            this.gridControl1.Size = new System.Drawing.Size(824, 272);
            this.gridControl1.TabIndex = 1;
            this.gridControl1.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridView1});
            // 
            // gridView1
            // 
            this.gridView1.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.colEmployeeFullName,
            this.colPrevCount,
            this.colCurrentCount,
            this.colTotal,
            this.colEmployeeNo,
            this.colHireDate,
            this.colServiceYear});
            this.gridView1.GridControl = this.gridControl1;
            this.gridView1.Name = "gridView1";
            this.gridView1.OptionsBehavior.Editable = false;
            this.gridView1.OptionsView.ShowAutoFilterRow = true;
            this.gridView1.OptionsView.ShowGroupPanel = false;
            // 
            // colEmployeeFullName
            // 
            this.colEmployeeFullName.FieldName = "EmployeeFullName";
            this.colEmployeeFullName.Name = "colEmployeeFullName";
            this.colEmployeeFullName.Visible = true;
            this.colEmployeeFullName.VisibleIndex = 0;
            // 
            // colPrevCount
            // 
            this.colPrevCount.Caption = "Previous Year Amount";
            this.colPrevCount.FieldName = "PrevCount";
            this.colPrevCount.Name = "colPrevCount";
            this.colPrevCount.Visible = true;
            this.colPrevCount.VisibleIndex = 4;
            // 
            // colCurrentCount
            // 
            this.colCurrentCount.Caption = "Current Year Amount";
            this.colCurrentCount.FieldName = "CurrentCount";
            this.colCurrentCount.Name = "colCurrentCount";
            this.colCurrentCount.Visible = true;
            this.colCurrentCount.VisibleIndex = 5;
            // 
            // colTotal
            // 
            this.colTotal.FieldName = "Total";
            this.colTotal.Name = "colTotal";
            this.colTotal.Visible = true;
            this.colTotal.VisibleIndex = 6;
            // 
            // colEmployeeNo
            // 
            this.colEmployeeNo.Caption = "Employee #";
            this.colEmployeeNo.FieldName = "EmployeeNo";
            this.colEmployeeNo.Name = "colEmployeeNo";
            this.colEmployeeNo.Visible = true;
            this.colEmployeeNo.VisibleIndex = 1;
            // 
            // colHireDate
            // 
            this.colHireDate.Caption = "Hired Date";
            this.colHireDate.FieldName = "HireDate";
            this.colHireDate.Name = "colHireDate";
            this.colHireDate.Visible = true;
            this.colHireDate.VisibleIndex = 2;
            // 
            // colServiceYear
            // 
            this.colServiceYear.FieldName = "ServiceYear";
            this.colServiceYear.Name = "colServiceYear";
            this.colServiceYear.Visible = true;
            this.colServiceYear.VisibleIndex = 3;
            // 
            // LeaveStatusView
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(824, 415);
            this.Controls.Add(this.gridControl1);
            this.Controls.Add(this.ribbonControl1);
            this.Name = "LeaveStatusView";
            this.Text = "Leave Status";
            ((System.ComponentModel.ISupportInitialize)(this.leaveStatusBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ribbonControl1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.smallImageCollection)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.largeImageCollection)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridControl1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.BindingSource leaveStatusBindingSource;
        private DevExpress.XtraBars.Ribbon.RibbonControl ribbonControl1;
        private DevExpress.XtraBars.BarButtonItem refreshBarButtonItem;
        private DevExpress.XtraBars.Ribbon.RibbonPage ribbonPage1;
        private DevExpress.XtraBars.Ribbon.RibbonPageGroup ribbonPageGroup1;
        private DevExpress.XtraGrid.GridControl gridControl1;
        private DevExpress.XtraGrid.Views.Grid.GridView gridView1;
        private DevExpress.XtraGrid.Columns.GridColumn colEmployeeFullName;
        private DevExpress.XtraGrid.Columns.GridColumn colPrevCount;
        private DevExpress.XtraGrid.Columns.GridColumn colCurrentCount;
        private DevExpress.XtraGrid.Columns.GridColumn colTotal;
        private DevExpress.XtraGrid.Columns.GridColumn colEmployeeNo;
        private DevExpress.XtraGrid.Columns.GridColumn colHireDate;
        private DevExpress.XtraGrid.Columns.GridColumn colServiceYear;
        private DevExpress.Utils.ImageCollection smallImageCollection;
        private DevExpress.Utils.ImageCollection largeImageCollection;
    }
}