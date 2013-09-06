namespace ClearOffice.Wms.Views
{
    partial class EquipmentsView
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
            this.equipmentsBindingSource = new System.Windows.Forms.BindingSource();
            this.gridControl1 = new DevExpress.XtraGrid.GridControl();
            this.equipmentsGridView = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.colSerial = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colDescription = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colCatagoryText = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colMakeText = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colModelText = new DevExpress.XtraGrid.Columns.GridColumn();
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.BtnDelete = new System.Windows.Forms.ToolStripButton();
            this.BtnRefresh = new System.Windows.Forms.ToolStripButton();
            ((System.ComponentModel.ISupportInitialize)(this.equipmentsBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridControl1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.equipmentsGridView)).BeginInit();
            this.toolStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // equipmentsBindingSource
            // 
            this.equipmentsBindingSource.DataSource = typeof(ClearOffice.Wms.Business.EquipmentListInfo);
            // 
            // gridControl1
            // 
            this.gridControl1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.gridControl1.DataSource = this.equipmentsBindingSource;
            this.gridControl1.Location = new System.Drawing.Point(0, 40);
            this.gridControl1.MainView = this.equipmentsGridView;
            this.gridControl1.Name = "gridControl1";
            this.gridControl1.Size = new System.Drawing.Size(827, 357);
            this.gridControl1.TabIndex = 0;
            this.gridControl1.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.equipmentsGridView});
            this.gridControl1.Click += new System.EventHandler(this.gridControl1_Click);
            this.gridControl1.DoubleClick += new System.EventHandler(this.gridControl1_DoubleClick);
            // 
            // equipmentsGridView
            // 
            this.equipmentsGridView.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.colSerial,
            this.colDescription,
            this.colCatagoryText,
            this.colMakeText,
            this.colModelText});
            this.equipmentsGridView.GridControl = this.gridControl1;
            this.equipmentsGridView.Name = "equipmentsGridView";
            this.equipmentsGridView.OptionsBehavior.Editable = false;
            this.equipmentsGridView.OptionsView.ShowGroupPanel = false;
            // 
            // colSerial
            // 
            this.colSerial.Caption = "Serial #";
            this.colSerial.FieldName = "Serial";
            this.colSerial.Name = "colSerial";
            this.colSerial.Visible = true;
            this.colSerial.VisibleIndex = 1;
            // 
            // colDescription
            // 
            this.colDescription.FieldName = "Description";
            this.colDescription.Name = "colDescription";
            this.colDescription.Visible = true;
            this.colDescription.VisibleIndex = 4;
            // 
            // colCatagoryText
            // 
            this.colCatagoryText.Caption = "Category";
            this.colCatagoryText.FieldName = "CatagoryText";
            this.colCatagoryText.Name = "colCatagoryText";
            this.colCatagoryText.Visible = true;
            this.colCatagoryText.VisibleIndex = 0;
            // 
            // colMakeText
            // 
            this.colMakeText.Caption = "Make";
            this.colMakeText.FieldName = "MakeText";
            this.colMakeText.Name = "colMakeText";
            this.colMakeText.Visible = true;
            this.colMakeText.VisibleIndex = 2;
            // 
            // colModelText
            // 
            this.colModelText.Caption = "Model";
            this.colModelText.FieldName = "ModelText";
            this.colModelText.Name = "colModelText";
            this.colModelText.Visible = true;
            this.colModelText.VisibleIndex = 3;
            // 
            // toolStrip1
            // 
            this.toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.BtnDelete,
            this.BtnRefresh});
            this.toolStrip1.Location = new System.Drawing.Point(0, 0);
            this.toolStrip1.Name = "toolStrip1";
            this.toolStrip1.Size = new System.Drawing.Size(828, 25);
            this.toolStrip1.TabIndex = 1;
            this.toolStrip1.Text = "toolStrip1";
            // 
            // BtnDelete
            // 
            this.BtnDelete.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.BtnDelete.Enabled = false;
            this.BtnDelete.Image = global::ClearOffice.Wms.Properties.Resources.delete;
            this.BtnDelete.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.BtnDelete.Name = "BtnDelete";
            this.BtnDelete.Size = new System.Drawing.Size(23, 22);
            this.BtnDelete.Text = "toolStripButton1";
            this.BtnDelete.ToolTipText = "Delete";
            this.BtnDelete.Click += new System.EventHandler(this.BtnDelete_Click);
            // 
            // BtnRefresh
            // 
            this.BtnRefresh.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.BtnRefresh.Image = global::ClearOffice.Wms.Properties.Resources.Refresh;
            this.BtnRefresh.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.BtnRefresh.Name = "BtnRefresh";
            this.BtnRefresh.Size = new System.Drawing.Size(23, 22);
            this.BtnRefresh.Text = "toolStripButton1";
            this.BtnRefresh.ToolTipText = "Refresh";
            this.BtnRefresh.Click += new System.EventHandler(this.BtnRefresh_Click);
            // 
            // EquipmentsView
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(828, 397);
            this.Controls.Add(this.toolStrip1);
            this.Controls.Add(this.gridControl1);
            this.Name = "EquipmentsView";
            this.Text = "Equipments";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            ((System.ComponentModel.ISupportInitialize)(this.equipmentsBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridControl1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.equipmentsGridView)).EndInit();
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.BindingSource equipmentsBindingSource;
        private DevExpress.XtraGrid.GridControl gridControl1;
        private DevExpress.XtraGrid.Views.Grid.GridView equipmentsGridView;
        private System.Windows.Forms.ToolStrip toolStrip1;
        private System.Windows.Forms.ToolStripButton BtnDelete;
        private DevExpress.XtraGrid.Columns.GridColumn colSerial;
        private DevExpress.XtraGrid.Columns.GridColumn colDescription;
        private DevExpress.XtraGrid.Columns.GridColumn colCatagoryText;
        private DevExpress.XtraGrid.Columns.GridColumn colMakeText;
        private DevExpress.XtraGrid.Columns.GridColumn colModelText;
        private System.Windows.Forms.ToolStripButton BtnRefresh;

    }
}