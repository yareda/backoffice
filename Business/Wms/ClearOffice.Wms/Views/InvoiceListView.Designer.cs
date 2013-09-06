namespace ClearOffice.Wms.Views
{
    partial class FrmInvoiceListView
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
            this.gridControl1 = new DevExpress.XtraGrid.GridControl();
            this.invoicebindingSource = new System.Windows.Forms.BindingSource();
            this.InvoicegridView = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.colInvoiceNo = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colInvoiceDate = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colRecievedTotal = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colWorkOrderNo = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colCustomer = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colInvoiceTotal = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colRemainingAmount = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colWorkOrderTotal = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colInvoiceStatusText = new DevExpress.XtraGrid.Columns.GridColumn();
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.btnRefresh = new System.Windows.Forms.ToolStripButton();
            this.btninvoicedelete = new System.Windows.Forms.ToolStripButton();
            this.toolStripButton1 = new System.Windows.Forms.ToolStripButton();
            this.statusbindingSource = new System.Windows.Forms.BindingSource();
            ((System.ComponentModel.ISupportInitialize)(this.gridControl1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.invoicebindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.InvoicegridView)).BeginInit();
            this.toolStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.statusbindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // gridControl1
            // 
            this.gridControl1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.gridControl1.DataSource = this.invoicebindingSource;
            this.gridControl1.Location = new System.Drawing.Point(-1, 30);
            this.gridControl1.MainView = this.InvoicegridView;
            this.gridControl1.Name = "gridControl1";
            this.gridControl1.Size = new System.Drawing.Size(812, 301);
            this.gridControl1.TabIndex = 0;
            this.gridControl1.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.InvoicegridView});
            this.gridControl1.Click += new System.EventHandler(this.gridControl1_Click);
            this.gridControl1.DoubleClick += new System.EventHandler(this.gridControl1_DoubleClick);
            // 
            // invoicebindingSource
            // 
            this.invoicebindingSource.DataSource = typeof(ClearOffice.Wms.Business.InvoiceInfo);
            // 
            // InvoicegridView
            // 
            this.InvoicegridView.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.colInvoiceNo,
            this.colInvoiceDate,
            this.colRecievedTotal,
            this.colWorkOrderNo,
            this.colCustomer,
            this.colInvoiceTotal,
            this.colRemainingAmount,
            this.colWorkOrderTotal,
            this.colInvoiceStatusText});
            this.InvoicegridView.GridControl = this.gridControl1;
            this.InvoicegridView.Name = "InvoicegridView";
            this.InvoicegridView.OptionsBehavior.Editable = false;
            this.InvoicegridView.OptionsView.ShowGroupedColumns = true;
            this.InvoicegridView.OptionsView.ShowGroupPanel = false;
            // 
            // colInvoiceNo
            // 
            this.colInvoiceNo.Caption = "Invoice #";
            this.colInvoiceNo.FieldName = "InvoiceNo";
            this.colInvoiceNo.Name = "colInvoiceNo";
            this.colInvoiceNo.Visible = true;
            this.colInvoiceNo.VisibleIndex = 0;
            // 
            // colInvoiceDate
            // 
            this.colInvoiceDate.Caption = "Invoice Date";
            this.colInvoiceDate.FieldName = "InvoiceDate";
            this.colInvoiceDate.Name = "colInvoiceDate";
            this.colInvoiceDate.Visible = true;
            this.colInvoiceDate.VisibleIndex = 1;
            // 
            // colRecievedTotal
            // 
            this.colRecievedTotal.Caption = "Received Total";
            this.colRecievedTotal.DisplayFormat.FormatString = "{0:#,##0.00;(#,##0.00);\\\'\\\'}";
            this.colRecievedTotal.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Custom;
            this.colRecievedTotal.FieldName = "RecievedTotal";
            this.colRecievedTotal.Name = "colRecievedTotal";
            this.colRecievedTotal.Visible = true;
            this.colRecievedTotal.VisibleIndex = 6;
            // 
            // colWorkOrderNo
            // 
            this.colWorkOrderNo.Caption = "Work Order #";
            this.colWorkOrderNo.FieldName = "WorkOrderNo";
            this.colWorkOrderNo.Name = "colWorkOrderNo";
            this.colWorkOrderNo.Visible = true;
            this.colWorkOrderNo.VisibleIndex = 3;
            // 
            // colCustomer
            // 
            this.colCustomer.FieldName = "Customer";
            this.colCustomer.Name = "colCustomer";
            this.colCustomer.Visible = true;
            this.colCustomer.VisibleIndex = 2;
            // 
            // colInvoiceTotal
            // 
            this.colInvoiceTotal.Caption = "Invoice Total";
            this.colInvoiceTotal.DisplayFormat.FormatString = "{0:#,##0.00;(#,##0.00);\\\'\\\'}";
            this.colInvoiceTotal.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Custom;
            this.colInvoiceTotal.FieldName = "InvoiceTotal";
            this.colInvoiceTotal.Name = "colInvoiceTotal";
            this.colInvoiceTotal.Visible = true;
            this.colInvoiceTotal.VisibleIndex = 5;
            // 
            // colRemainingAmount
            // 
            this.colRemainingAmount.Caption = "Remaining Amount";
            this.colRemainingAmount.DisplayFormat.FormatString = "{0:#,##0.00;(#,##0.00);\\\'\\\'";
            this.colRemainingAmount.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Custom;
            this.colRemainingAmount.FieldName = "RemainingAmount";
            this.colRemainingAmount.Name = "colRemainingAmount";
            this.colRemainingAmount.Visible = true;
            this.colRemainingAmount.VisibleIndex = 7;
            // 
            // colWorkOrderTotal
            // 
            this.colWorkOrderTotal.Caption = "Work Order Total";
            this.colWorkOrderTotal.DisplayFormat.FormatString = "{0:#,##0.00;(#,##0.00);\\\'\\\'}";
            this.colWorkOrderTotal.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Custom;
            this.colWorkOrderTotal.FieldName = "WorkOrderTotal";
            this.colWorkOrderTotal.Name = "colWorkOrderTotal";
            this.colWorkOrderTotal.Visible = true;
            this.colWorkOrderTotal.VisibleIndex = 4;
            // 
            // colInvoiceStatusText
            // 
            this.colInvoiceStatusText.Caption = "Status";
            this.colInvoiceStatusText.FieldName = "InvoiceStatusText";
            this.colInvoiceStatusText.Name = "colInvoiceStatusText";
            this.colInvoiceStatusText.Visible = true;
            this.colInvoiceStatusText.VisibleIndex = 8;
            // 
            // toolStrip1
            // 
            this.toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.btnRefresh,
            this.btninvoicedelete});
            this.toolStrip1.Location = new System.Drawing.Point(0, 0);
            this.toolStrip1.Name = "toolStrip1";
            this.toolStrip1.Size = new System.Drawing.Size(811, 25);
            this.toolStrip1.TabIndex = 1;
            this.toolStrip1.Text = "toolStrip1";
            // 
            // btnRefresh
            // 
            this.btnRefresh.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.btnRefresh.Image = global::ClearOffice.Wms.Properties.Resources.Refresh;
            this.btnRefresh.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnRefresh.Name = "btnRefresh";
            this.btnRefresh.Size = new System.Drawing.Size(23, 22);
            this.btnRefresh.ToolTipText = "Refresh";
            this.btnRefresh.Click += new System.EventHandler(this.btnRefresh_Click);
            // 
            // btninvoicedelete
            // 
            this.btninvoicedelete.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.btninvoicedelete.Image = global::ClearOffice.Wms.Properties.Resources.delete;
            this.btninvoicedelete.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btninvoicedelete.Name = "btninvoicedelete";
            this.btninvoicedelete.Size = new System.Drawing.Size(23, 22);
            this.btninvoicedelete.Text = "toolStripButton2";
            this.btninvoicedelete.ToolTipText = "Delete";
            this.btninvoicedelete.Click += new System.EventHandler(this.btninvoicedelete_Click);
            // 
            // toolStripButton1
            // 
            this.toolStripButton1.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.toolStripButton1.Image = global::ClearOffice.Wms.Properties.Resources.delete;
            this.toolStripButton1.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButton1.Name = "toolStripButton1";
            this.toolStripButton1.Size = new System.Drawing.Size(23, 22);
            this.toolStripButton1.Text = "toolStripButton1";
            this.toolStripButton1.ToolTipText = "Delete";
            // 
            // statusbindingSource
            // 
            this.statusbindingSource.DataSource = typeof(ClearOffice.Wms.Business.LookupItem);
            // 
            // FrmInvoiceListView
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(811, 336);
            this.Controls.Add(this.toolStrip1);
            this.Controls.Add(this.gridControl1);
            this.MinimizeBox = false;
            this.Name = "FrmInvoiceListView";
            this.Text = "InvoiceListView";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            ((System.ComponentModel.ISupportInitialize)(this.gridControl1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.invoicebindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.InvoicegridView)).EndInit();
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.statusbindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private DevExpress.XtraGrid.GridControl gridControl1;
        private DevExpress.XtraGrid.Views.Grid.GridView InvoicegridView;
        private System.Windows.Forms.BindingSource invoicebindingSource;
        private System.Windows.Forms.ToolStrip toolStrip1;
        private System.Windows.Forms.ToolStripButton btnRefresh;
        private System.Windows.Forms.ToolStripButton toolStripButton1;
        private System.Windows.Forms.ToolStripButton btninvoicedelete;
        private System.Windows.Forms.BindingSource statusbindingSource;
        private DevExpress.XtraGrid.Columns.GridColumn colInvoiceNo;
        private DevExpress.XtraGrid.Columns.GridColumn colInvoiceDate;
        private DevExpress.XtraGrid.Columns.GridColumn colRecievedTotal;
        private DevExpress.XtraGrid.Columns.GridColumn colWorkOrderNo;
        private DevExpress.XtraGrid.Columns.GridColumn colCustomer;
        private DevExpress.XtraGrid.Columns.GridColumn colInvoiceTotal;
        private DevExpress.XtraGrid.Columns.GridColumn colRemainingAmount;
        private DevExpress.XtraGrid.Columns.GridColumn colWorkOrderTotal;
        private DevExpress.XtraGrid.Columns.GridColumn colInvoiceStatusText;
    }
}