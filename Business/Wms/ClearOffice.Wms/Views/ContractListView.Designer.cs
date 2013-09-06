namespace ClearOffice.Wms.Views
{
    partial class ContractListView
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ContractListView));
            this.gridControl1 = new DevExpress.XtraGrid.GridControl();
            this.ContractListBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.ContractListGridView = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.colContractNo = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colCustomerName = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colContractTypeName = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colStartDate = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colDuration = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colAmount = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colDescription = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colContractStatusText = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colPaymentTermName = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colExpirationDate = new DevExpress.XtraGrid.Columns.GridColumn();
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.btnNew = new System.Windows.Forms.ToolStripButton();
            this.BtnDelete = new System.Windows.Forms.ToolStripButton();
            this.BtnRefresh = new System.Windows.Forms.ToolStripButton();
            ((System.ComponentModel.ISupportInitialize)(this.gridControl1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ContractListBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ContractListGridView)).BeginInit();
            this.toolStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // gridControl1
            // 
            this.gridControl1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.gridControl1.DataSource = this.ContractListBindingSource;
            this.gridControl1.Location = new System.Drawing.Point(3, 28);
            this.gridControl1.MainView = this.ContractListGridView;
            this.gridControl1.Name = "gridControl1";
            this.gridControl1.Size = new System.Drawing.Size(854, 272);
            this.gridControl1.TabIndex = 0;
            this.gridControl1.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.ContractListGridView});
            this.gridControl1.Click += new System.EventHandler(this.gridControl1_Click);
            this.gridControl1.DoubleClick += new System.EventHandler(this.gridControl1_DoubleClick);
            // 
            // ContractListBindingSource
            // 
            this.ContractListBindingSource.DataSource = typeof(ClearOffice.Wms.Business.ContractInfo);
            // 
            // ContractListGridView
            // 
            this.ContractListGridView.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.colContractNo,
            this.colCustomerName,
            this.colContractTypeName,
            this.colStartDate,
            this.colDuration,
            this.colAmount,
            this.colDescription,
            this.colContractStatusText,
            this.colPaymentTermName,
            this.colExpirationDate});
            this.ContractListGridView.GridControl = this.gridControl1;
            this.ContractListGridView.Name = "ContractListGridView";
            this.ContractListGridView.OptionsBehavior.Editable = false;
            this.ContractListGridView.OptionsView.ShowAutoFilterRow = true;
            this.ContractListGridView.OptionsView.ShowGroupPanel = false;
            // 
            // colContractNo
            // 
            this.colContractNo.FieldName = "ContractNo";
            this.colContractNo.Name = "colContractNo";
            this.colContractNo.Visible = true;
            this.colContractNo.VisibleIndex = 0;
            // 
            // colCustomerName
            // 
            this.colCustomerName.Caption = "Customer";
            this.colCustomerName.FieldName = "CustomerName";
            this.colCustomerName.Name = "colCustomerName";
            this.colCustomerName.Visible = true;
            this.colCustomerName.VisibleIndex = 8;
            // 
            // colContractTypeName
            // 
            this.colContractTypeName.Caption = "Contract Type";
            this.colContractTypeName.FieldName = "ContractTypeName";
            this.colContractTypeName.Name = "colContractTypeName";
            this.colContractTypeName.Visible = true;
            this.colContractTypeName.VisibleIndex = 1;
            // 
            // colStartDate
            // 
            this.colStartDate.FieldName = "StartDate";
            this.colStartDate.Name = "colStartDate";
            this.colStartDate.Visible = true;
            this.colStartDate.VisibleIndex = 2;
            // 
            // colDuration
            // 
            this.colDuration.FieldName = "Duration";
            this.colDuration.Name = "colDuration";
            this.colDuration.Visible = true;
            this.colDuration.VisibleIndex = 3;
            // 
            // colAmount
            // 
            this.colAmount.DisplayFormat.FormatString = "{0:#,##0.00;(#,##0.00);\'\'} ";
            this.colAmount.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Custom;
            this.colAmount.FieldName = "Amount";
            this.colAmount.Name = "colAmount";
            this.colAmount.Visible = true;
            this.colAmount.VisibleIndex = 4;
            // 
            // colDescription
            // 
            this.colDescription.FieldName = "Description";
            this.colDescription.Name = "colDescription";
            this.colDescription.Visible = true;
            this.colDescription.VisibleIndex = 5;
            // 
            // colContractStatusText
            // 
            this.colContractStatusText.Caption = "Status";
            this.colContractStatusText.FieldName = "ContractStatusText";
            this.colContractStatusText.Name = "colContractStatusText";
            this.colContractStatusText.Visible = true;
            this.colContractStatusText.VisibleIndex = 9;
            // 
            // colPaymentTermName
            // 
            this.colPaymentTermName.Caption = "Payment Terms";
            this.colPaymentTermName.FieldName = "PaymentTermName";
            this.colPaymentTermName.Name = "colPaymentTermName";
            this.colPaymentTermName.Visible = true;
            this.colPaymentTermName.VisibleIndex = 6;
            // 
            // colExpirationDate
            // 
            this.colExpirationDate.Caption = "Expiration Date";
            this.colExpirationDate.FieldName = "ExpirationDate";
            this.colExpirationDate.Name = "colExpirationDate";
            this.colExpirationDate.Visible = true;
            this.colExpirationDate.VisibleIndex = 7;
            // 
            // toolStrip1
            // 
            this.toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.btnNew,
            this.BtnDelete,
            this.BtnRefresh});
            this.toolStrip1.Location = new System.Drawing.Point(0, 0);
            this.toolStrip1.Name = "toolStrip1";
            this.toolStrip1.Size = new System.Drawing.Size(856, 25);
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
            this.btnNew.Click += new System.EventHandler(this.newToolStripButton_Click);
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
            this.BtnRefresh.Text = "toolStripButton2";
            this.BtnRefresh.ToolTipText = "Refresh";
            this.BtnRefresh.Click += new System.EventHandler(this.BtnRefresh_Click);
            // 
            // ContractListView
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(856, 301);
            this.Controls.Add(this.toolStrip1);
            this.Controls.Add(this.gridControl1);
            this.Name = "ContractListView";
            this.Text = "ContractListView";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            ((System.ComponentModel.ISupportInitialize)(this.gridControl1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ContractListBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ContractListGridView)).EndInit();
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private DevExpress.XtraGrid.GridControl gridControl1;
        private DevExpress.XtraGrid.Views.Grid.GridView ContractListGridView;
        private System.Windows.Forms.BindingSource ContractListBindingSource;
        private System.Windows.Forms.ToolStrip toolStrip1;
        private System.Windows.Forms.ToolStripButton btnNew;
        private System.Windows.Forms.ToolStripButton BtnDelete;
        private System.Windows.Forms.ToolStripButton BtnRefresh;
        private DevExpress.XtraGrid.Columns.GridColumn colContractNo;
        private DevExpress.XtraGrid.Columns.GridColumn colCustomerName;
        private DevExpress.XtraGrid.Columns.GridColumn colContractTypeName;
        private DevExpress.XtraGrid.Columns.GridColumn colStartDate;
        private DevExpress.XtraGrid.Columns.GridColumn colDuration;
        private DevExpress.XtraGrid.Columns.GridColumn colAmount;
        private DevExpress.XtraGrid.Columns.GridColumn colDescription;
        private DevExpress.XtraGrid.Columns.GridColumn colContractStatusText;
        private DevExpress.XtraGrid.Columns.GridColumn colPaymentTermName;
        private DevExpress.XtraGrid.Columns.GridColumn colExpirationDate;
    }
}