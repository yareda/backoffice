namespace ClearOffice.Wms.Views
{
    partial class PMServiceListView
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(PMServiceListView));
            this.gridControl1 = new DevExpress.XtraGrid.GridControl();
            this.pmserviceBindingSource = new System.Windows.Forms.BindingSource();
            this.PMServiceGridView = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.colCatagoryName = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colTaskName = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colPriorityName = new DevExpress.XtraGrid.Columns.GridColumn();
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.btnNew = new System.Windows.Forms.ToolStripButton();
            this.btnDelete = new System.Windows.Forms.ToolStripButton();
            ((System.ComponentModel.ISupportInitialize)(this.gridControl1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pmserviceBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.PMServiceGridView)).BeginInit();
            this.toolStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // gridControl1
            // 
            this.gridControl1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.gridControl1.DataSource = this.pmserviceBindingSource;
            this.gridControl1.Location = new System.Drawing.Point(0, 28);
            this.gridControl1.MainView = this.PMServiceGridView;
            this.gridControl1.Name = "gridControl1";
            this.gridControl1.Size = new System.Drawing.Size(754, 340);
            this.gridControl1.TabIndex = 0;
            this.gridControl1.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.PMServiceGridView});
            this.gridControl1.Click += new System.EventHandler(this.gridControl1_Click);
            this.gridControl1.DoubleClick += new System.EventHandler(this.gridControl1_DoubleClick);
            // 
            // pmserviceBindingSource
            // 
            this.pmserviceBindingSource.DataSource = typeof(ClearOffice.Wms.Business.PmServiceInfo);
            // 
            // PMServiceGridView
            // 
            this.PMServiceGridView.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.colCatagoryName,
            this.colTaskName,
            this.colPriorityName});
            this.PMServiceGridView.GridControl = this.gridControl1;
            this.PMServiceGridView.Name = "PMServiceGridView";
            this.PMServiceGridView.OptionsBehavior.Editable = false;
            this.PMServiceGridView.OptionsView.ShowGroupPanel = false;
            // 
            // colCatagoryName
            // 
            this.colCatagoryName.Caption = "Category";
            this.colCatagoryName.FieldName = "CatagoryName";
            this.colCatagoryName.Name = "colCatagoryName";
            this.colCatagoryName.Visible = true;
            this.colCatagoryName.VisibleIndex = 0;
            // 
            // colTaskName
            // 
            this.colTaskName.Caption = "Service Name";
            this.colTaskName.FieldName = "TaskName";
            this.colTaskName.Name = "colTaskName";
            this.colTaskName.Visible = true;
            this.colTaskName.VisibleIndex = 1;
            // 
            // colPriorityName
            // 
            this.colPriorityName.Caption = "Priority";
            this.colPriorityName.FieldName = "PriorityName";
            this.colPriorityName.Name = "colPriorityName";
            this.colPriorityName.Visible = true;
            this.colPriorityName.VisibleIndex = 2;
            // 
            // toolStrip1
            // 
            this.toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.btnNew,
            this.btnDelete});
            this.toolStrip1.Location = new System.Drawing.Point(0, 0);
            this.toolStrip1.Name = "toolStrip1";
            this.toolStrip1.Size = new System.Drawing.Size(754, 25);
            this.toolStrip1.TabIndex = 1;
            this.toolStrip1.Text = "toolStrip1";
            // 
            // btnNew
            // 
            this.btnNew.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.btnNew.Image = ((System.Drawing.Image)(resources.GetObject("btnNew.Image")));
            this.btnNew.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnNew.Name = "btnNew";
            this.btnNew.Size = new System.Drawing.Size(23, 22);
            this.btnNew.Text = "&New";
            this.btnNew.Click += new System.EventHandler(this.btnNew_Click);
            // 
            // btnDelete
            // 
            this.btnDelete.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.btnDelete.Enabled = false;
            this.btnDelete.Image = global::ClearOffice.Wms.Properties.Resources.delete;
            this.btnDelete.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(23, 22);
            this.btnDelete.Text = "toolStripButton1";
            this.btnDelete.ToolTipText = "Delete";
            this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
            // 
            // PMServiceListView
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(754, 367);
            this.Controls.Add(this.toolStrip1);
            this.Controls.Add(this.gridControl1);
            this.Name = "PMServiceListView";
            this.Text = "PMService List";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            ((System.ComponentModel.ISupportInitialize)(this.gridControl1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pmserviceBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.PMServiceGridView)).EndInit();
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private DevExpress.XtraGrid.GridControl gridControl1;
        private DevExpress.XtraGrid.Views.Grid.GridView PMServiceGridView;
        private System.Windows.Forms.ToolStrip toolStrip1;
        private System.Windows.Forms.ToolStripButton btnDelete;
        private System.Windows.Forms.BindingSource pmserviceBindingSource;
        private DevExpress.XtraGrid.Columns.GridColumn colCatagoryName;
        private DevExpress.XtraGrid.Columns.GridColumn colTaskName;
        private DevExpress.XtraGrid.Columns.GridColumn colPriorityName;
        private System.Windows.Forms.ToolStripButton btnNew;
    }
}