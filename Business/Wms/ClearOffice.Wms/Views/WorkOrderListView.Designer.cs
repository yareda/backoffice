namespace ClearOffice.Wms.Views
{
    partial class WorkOrderListView
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
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.BtnDelete = new System.Windows.Forms.ToolStripButton();
            this.btnRefresh = new System.Windows.Forms.ToolStripButton();
            this.gridControl1 = new DevExpress.XtraGrid.GridControl();
            this.WorkorderInfoBindingSource = new System.Windows.Forms.BindingSource();
            this.WorkOrderListGridView = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.colWorkOrderNo = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colEndDate = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colIssueDate = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colStatusText = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colTotalCost = new DevExpress.XtraGrid.Columns.GridColumn();
            this.toolStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gridControl1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.WorkorderInfoBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.WorkOrderListGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // toolStrip1
            // 
            this.toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.BtnDelete,
            this.btnRefresh});
            this.toolStrip1.Location = new System.Drawing.Point(0, 0);
            this.toolStrip1.Name = "toolStrip1";
            this.toolStrip1.Size = new System.Drawing.Size(765, 25);
            this.toolStrip1.TabIndex = 0;
            this.toolStrip1.Text = "toolStrip1";
            // 
            // BtnDelete
            // 
            this.BtnDelete.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.BtnDelete.Image = global::ClearOffice.Wms.Properties.Resources.delete;
            this.BtnDelete.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.BtnDelete.Name = "BtnDelete";
            this.BtnDelete.Size = new System.Drawing.Size(23, 22);
            this.BtnDelete.Text = "toolStripButton1";
            this.BtnDelete.ToolTipText = "Delete";
            this.BtnDelete.Click += new System.EventHandler(this.BtnDelete_Click);
            // 
            // btnRefresh
            // 
            this.btnRefresh.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.btnRefresh.Image = global::ClearOffice.Wms.Properties.Resources.Refresh;
            this.btnRefresh.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnRefresh.Name = "btnRefresh";
            this.btnRefresh.Size = new System.Drawing.Size(23, 22);
            this.btnRefresh.Text = "toolStripButton1";
            this.btnRefresh.ToolTipText = "Refresh";
            this.btnRefresh.Click += new System.EventHandler(this.btnRefresh_Click);
            // 
            // gridControl1
            // 
            this.gridControl1.DataSource = this.WorkorderInfoBindingSource;
            this.gridControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gridControl1.Location = new System.Drawing.Point(0, 25);
            this.gridControl1.MainView = this.WorkOrderListGridView;
            this.gridControl1.Name = "gridControl1";
            this.gridControl1.Size = new System.Drawing.Size(765, 301);
            this.gridControl1.TabIndex = 1;
            this.gridControl1.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.WorkOrderListGridView});
            this.gridControl1.DoubleClick += new System.EventHandler(this.gridControl1_DoubleClick);
            // 
            // WorkorderInfoBindingSource
            // 
            this.WorkorderInfoBindingSource.DataSource = typeof(ClearOffice.Wms.Business.WorkOrderInfo);
            // 
            // WorkOrderListGridView
            // 
            this.WorkOrderListGridView.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.colWorkOrderNo,
            this.colEndDate,
            this.colIssueDate,
            this.colStatusText,
            this.colTotalCost});
            this.WorkOrderListGridView.GridControl = this.gridControl1;
            this.WorkOrderListGridView.Name = "WorkOrderListGridView";
            this.WorkOrderListGridView.OptionsBehavior.Editable = false;
            this.WorkOrderListGridView.OptionsView.ShowGroupPanel = false;
            // 
            // colWorkOrderNo
            // 
            this.colWorkOrderNo.Caption = "Work Order#";
            this.colWorkOrderNo.FieldName = "WorkOrderNo";
            this.colWorkOrderNo.Name = "colWorkOrderNo";
            this.colWorkOrderNo.Visible = true;
            this.colWorkOrderNo.VisibleIndex = 0;
            // 
            // colEndDate
            // 
            this.colEndDate.FieldName = "EndDate";
            this.colEndDate.Name = "colEndDate";
            this.colEndDate.Visible = true;
            this.colEndDate.VisibleIndex = 1;
            // 
            // colIssueDate
            // 
            this.colIssueDate.FieldName = "IssueDate";
            this.colIssueDate.Name = "colIssueDate";
            this.colIssueDate.Visible = true;
            this.colIssueDate.VisibleIndex = 2;
            // 
            // colStatusText
            // 
            this.colStatusText.Caption = "Status";
            this.colStatusText.FieldName = "StatusText";
            this.colStatusText.Name = "colStatusText";
            this.colStatusText.Visible = true;
            this.colStatusText.VisibleIndex = 3;
            // 
            // colTotalCost
            // 
            this.colTotalCost.Caption = "Total Cost";
            this.colTotalCost.FieldName = "TotalCost";
            this.colTotalCost.Name = "colTotalCost";
            this.colTotalCost.Visible = true;
            this.colTotalCost.VisibleIndex = 4;
            // 
            // WorkOrderListView
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(765, 326);
            this.Controls.Add(this.gridControl1);
            this.Controls.Add(this.toolStrip1);
            this.Name = "WorkOrderListView";
            this.Text = "WorkOrders List";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gridControl1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.WorkorderInfoBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.WorkOrderListGridView)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ToolStrip toolStrip1;
        private DevExpress.XtraGrid.GridControl gridControl1;
        private DevExpress.XtraGrid.Views.Grid.GridView WorkOrderListGridView;
        private System.Windows.Forms.BindingSource WorkorderInfoBindingSource;
        private System.Windows.Forms.ToolStripButton BtnDelete;
        private System.Windows.Forms.ToolStripButton btnRefresh;
        public void OpenSelected()
        {
            throw new System.NotImplementedException();
        }

        private DevExpress.XtraGrid.Columns.GridColumn colWorkOrderNo;
        private DevExpress.XtraGrid.Columns.GridColumn colEndDate;
        private DevExpress.XtraGrid.Columns.GridColumn colIssueDate;
        private DevExpress.XtraGrid.Columns.GridColumn colStatusText;
        private DevExpress.XtraGrid.Columns.GridColumn colTotalCost;
    }
}