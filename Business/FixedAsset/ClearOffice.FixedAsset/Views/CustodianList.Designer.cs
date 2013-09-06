namespace ClearOffice.FixedAsset.Views
{
    partial class CustodianList
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
            this.btnNewCustodian = new System.Windows.Forms.ToolStripButton();
            this.btnCustodianlistDelete = new System.Windows.Forms.ToolStripButton();
            this.btnCustrefresh = new System.Windows.Forms.ToolStripButton();
            this.custiodianlistbindingSource = new System.Windows.Forms.BindingSource();
            this.gridControl1 = new DevExpress.XtraGrid.GridControl();
            this.custodiangridView = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.colBadgeNo = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colFirstName = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colLastName = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colStatusText = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colLocation = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colDepartementText = new DevExpress.XtraGrid.Columns.GridColumn();
            this.toolStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.custiodianlistbindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridControl1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.custodiangridView)).BeginInit();
            this.SuspendLayout();
            // 
            // toolStrip1
            // 
            this.toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.btnNewCustodian,
            this.btnCustodianlistDelete,
            this.btnCustrefresh});
            this.toolStrip1.Location = new System.Drawing.Point(0, 0);
            this.toolStrip1.Name = "toolStrip1";
            this.toolStrip1.Size = new System.Drawing.Size(651, 25);
            this.toolStrip1.TabIndex = 0;
            this.toolStrip1.Text = "toolStrip1";
            // 
            // btnNewCustodian
            // 
            this.btnNewCustodian.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.btnNewCustodian.Image = global::ClearOffice.FixedAsset.Properties.Resources.New_16x16;
            this.btnNewCustodian.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnNewCustodian.Name = "btnNewCustodian";
            this.btnNewCustodian.Size = new System.Drawing.Size(23, 22);
            this.btnNewCustodian.Text = "toolStripButton3";
            this.btnNewCustodian.ToolTipText = "New";
            this.btnNewCustodian.Click += new System.EventHandler(this.btnNewCustodian_Click);
            // 
            // btnCustodianlistDelete
            // 
            this.btnCustodianlistDelete.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.btnCustodianlistDelete.Enabled = false;
            this.btnCustodianlistDelete.Image = global::ClearOffice.FixedAsset.Properties.Resources.delete;
            this.btnCustodianlistDelete.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnCustodianlistDelete.Name = "btnCustodianlistDelete";
            this.btnCustodianlistDelete.Size = new System.Drawing.Size(23, 22);
            this.btnCustodianlistDelete.Text = "toolStripButton1";
            this.btnCustodianlistDelete.ToolTipText = "Delete";
            this.btnCustodianlistDelete.Click += new System.EventHandler(this.btnCustodianlistDelete_Click);
            // 
            // btnCustrefresh
            // 
            this.btnCustrefresh.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.btnCustrefresh.Image = global::ClearOffice.FixedAsset.Properties.Resources.arrow_refresh;
            this.btnCustrefresh.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnCustrefresh.Name = "btnCustrefresh";
            this.btnCustrefresh.Size = new System.Drawing.Size(23, 22);
            this.btnCustrefresh.Text = "toolStripButton2";
            this.btnCustrefresh.ToolTipText = "Referesh";
            this.btnCustrefresh.Click += new System.EventHandler(this.btnCustrefresh_Click);
            // 
            // custiodianlistbindingSource
            // 
            this.custiodianlistbindingSource.DataSource = typeof(ClearOffice.FixedAsset.DataAccess.CustodianInfo);
            // 
            // gridControl1
            // 
            this.gridControl1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.gridControl1.DataSource = this.custiodianlistbindingSource;
            this.gridControl1.Location = new System.Drawing.Point(0, 28);
            this.gridControl1.MainView = this.custodiangridView;
            this.gridControl1.Name = "gridControl1";
            this.gridControl1.Size = new System.Drawing.Size(639, 309);
            this.gridControl1.TabIndex = 1;
            this.gridControl1.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.custodiangridView});
            this.gridControl1.Click += new System.EventHandler(this.gridControl1_Click);
            this.gridControl1.DoubleClick += new System.EventHandler(this.gridControl1_DoubleClick);
            // 
            // custodiangridView
            // 
            this.custodiangridView.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.colBadgeNo,
            this.colFirstName,
            this.colLastName,
            this.colStatusText,
            this.colLocation,
            this.colDepartementText});
            this.custodiangridView.GridControl = this.gridControl1;
            this.custodiangridView.Name = "custodiangridView";
            this.custodiangridView.OptionsBehavior.Editable = false;
            this.custodiangridView.OptionsView.ShowGroupPanel = false;
            // 
            // colBadgeNo
            // 
            this.colBadgeNo.Caption = "Badge #";
            this.colBadgeNo.FieldName = "BadgeNo";
            this.colBadgeNo.Name = "colBadgeNo";
            this.colBadgeNo.Visible = true;
            this.colBadgeNo.VisibleIndex = 0;
            // 
            // colFirstName
            // 
            this.colFirstName.FieldName = "FirstName";
            this.colFirstName.Name = "colFirstName";
            this.colFirstName.Visible = true;
            this.colFirstName.VisibleIndex = 1;
            // 
            // colLastName
            // 
            this.colLastName.FieldName = "LastName";
            this.colLastName.Name = "colLastName";
            this.colLastName.Visible = true;
            this.colLastName.VisibleIndex = 2;
            // 
            // colStatusText
            // 
            this.colStatusText.Caption = "Status";
            this.colStatusText.FieldName = "StatusText";
            this.colStatusText.Name = "colStatusText";
            this.colStatusText.Visible = true;
            this.colStatusText.VisibleIndex = 4;
            // 
            // colLocation
            // 
            this.colLocation.FieldName = "Location";
            this.colLocation.Name = "colLocation";
            this.colLocation.Visible = true;
            this.colLocation.VisibleIndex = 3;
            // 
            // colDepartementText
            // 
            this.colDepartementText.Caption = "Department";
            this.colDepartementText.FieldName = "DepartementText";
            this.colDepartementText.Name = "colDepartementText";
            this.colDepartementText.Visible = true;
            this.colDepartementText.VisibleIndex = 5;
            // 
            // CustodianList
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(651, 340);
            this.Controls.Add(this.gridControl1);
            this.Controls.Add(this.toolStrip1);
            this.MinimizeBox = false;
            this.Name = "CustodianList";
            this.Text = "CustodianListView";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.custiodianlistbindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridControl1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.custodiangridView)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ToolStrip toolStrip1;
        private System.Windows.Forms.ToolStripButton btnCustodianlistDelete;
        private System.Windows.Forms.ToolStripButton btnCustrefresh;
        private System.Windows.Forms.BindingSource custiodianlistbindingSource;
        private System.Windows.Forms.ToolStripButton btnNewCustodian;
        private DevExpress.XtraGrid.GridControl gridControl1;
        private DevExpress.XtraGrid.Views.Grid.GridView custodiangridView;
        private DevExpress.XtraGrid.Columns.GridColumn colBadgeNo;
        private DevExpress.XtraGrid.Columns.GridColumn colFirstName;
        private DevExpress.XtraGrid.Columns.GridColumn colLastName;
        private DevExpress.XtraGrid.Columns.GridColumn colStatusText;
        private DevExpress.XtraGrid.Columns.GridColumn colLocation;
        private DevExpress.XtraGrid.Columns.GridColumn colDepartementText;
    }
}