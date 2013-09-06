namespace ClearOffice.Inventory.Views
{
    partial class NewReceiving
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
            System.Windows.Forms.Label gRNLabel;
            System.Windows.Forms.Label invoiceNoLabel;
            System.Windows.Forms.Label receivedDateLabel;
            System.Windows.Forms.Label supplierIdLabel;
            System.Windows.Forms.Label warehouseIdLabel;
            System.Windows.Forms.Label remarkLabel;
            this.gRNTextEdit = new DevExpress.XtraEditors.TextEdit();
            this.receivingBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.invoiceNoTextEdit = new DevExpress.XtraEditors.TextEdit();
            this.receivedDateDateEdit = new DevExpress.XtraEditors.DateEdit();
            this.supplierIdLookUpEdit = new DevExpress.XtraEditors.LookUpEdit();
            this.supplierBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.warehouseIdLookUpEdit = new DevExpress.XtraEditors.LookUpEdit();
            this.warehouseBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.remarkMemoEdit = new DevExpress.XtraEditors.MemoEdit();
            this.saveCommand = new DevExpress.XtraEditors.SimpleButton();
            this.cancelCommand = new DevExpress.XtraEditors.SimpleButton();
            this.errorProvider1 = new System.Windows.Forms.ErrorProvider(this.components);
            gRNLabel = new System.Windows.Forms.Label();
            invoiceNoLabel = new System.Windows.Forms.Label();
            receivedDateLabel = new System.Windows.Forms.Label();
            supplierIdLabel = new System.Windows.Forms.Label();
            warehouseIdLabel = new System.Windows.Forms.Label();
            remarkLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.gRNTextEdit.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.receivingBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.invoiceNoTextEdit.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.receivedDateDateEdit.Properties.VistaTimeProperties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.receivedDateDateEdit.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.supplierIdLookUpEdit.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.supplierBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.warehouseIdLookUpEdit.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.warehouseBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.remarkMemoEdit.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).BeginInit();
            this.SuspendLayout();
            // 
            // gRNLabel
            // 
            gRNLabel.AutoSize = true;
            gRNLabel.Location = new System.Drawing.Point(15, 15);
            gRNLabel.Name = "gRNLabel";
            gRNLabel.Size = new System.Drawing.Size(32, 13);
            gRNLabel.TabIndex = 0;
            gRNLabel.Text = "GRN:";
            // 
            // invoiceNoLabel
            // 
            invoiceNoLabel.AutoSize = true;
            invoiceNoLabel.Location = new System.Drawing.Point(15, 41);
            invoiceNoLabel.Name = "invoiceNoLabel";
            invoiceNoLabel.Size = new System.Drawing.Size(62, 13);
            invoiceNoLabel.TabIndex = 2;
            invoiceNoLabel.Text = "Invoice No:";
            // 
            // receivedDateLabel
            // 
            receivedDateLabel.AutoSize = true;
            receivedDateLabel.Location = new System.Drawing.Point(15, 67);
            receivedDateLabel.Name = "receivedDateLabel";
            receivedDateLabel.Size = new System.Drawing.Size(81, 13);
            receivedDateLabel.TabIndex = 4;
            receivedDateLabel.Text = "Received Date:";
            // 
            // supplierIdLabel
            // 
            supplierIdLabel.AutoSize = true;
            supplierIdLabel.Location = new System.Drawing.Point(15, 93);
            supplierIdLabel.Name = "supplierIdLabel";
            supplierIdLabel.Size = new System.Drawing.Size(49, 13);
            supplierIdLabel.TabIndex = 6;
            supplierIdLabel.Text = "Supplier:";
            // 
            // warehouseIdLabel
            // 
            warehouseIdLabel.AutoSize = true;
            warehouseIdLabel.Location = new System.Drawing.Point(15, 119);
            warehouseIdLabel.Name = "warehouseIdLabel";
            warehouseIdLabel.Size = new System.Drawing.Size(66, 13);
            warehouseIdLabel.TabIndex = 8;
            warehouseIdLabel.Text = "Warehouse:";
            // 
            // remarkLabel
            // 
            remarkLabel.AutoSize = true;
            remarkLabel.Location = new System.Drawing.Point(15, 145);
            remarkLabel.Name = "remarkLabel";
            remarkLabel.Size = new System.Drawing.Size(47, 13);
            remarkLabel.TabIndex = 10;
            remarkLabel.Text = "Remark:";
            // 
            // gRNTextEdit
            // 
            this.gRNTextEdit.DataBindings.Add(new System.Windows.Forms.Binding("EditValue", this.receivingBindingSource, "GRN", true));
            this.gRNTextEdit.Enabled = false;
            this.gRNTextEdit.Location = new System.Drawing.Point(99, 12);
            this.gRNTextEdit.Name = "gRNTextEdit";
            this.gRNTextEdit.Size = new System.Drawing.Size(261, 20);
            this.gRNTextEdit.TabIndex = 1;
            // 
            // receivingBindingSource
            // 
            this.receivingBindingSource.DataSource = typeof(ClearOffice.Inventory.DataAccess.Receiving);
            this.receivingBindingSource.CurrentItemChanged += new System.EventHandler(this.receivingBindingSource_CurrentItemChanged);
            // 
            // invoiceNoTextEdit
            // 
            this.invoiceNoTextEdit.DataBindings.Add(new System.Windows.Forms.Binding("EditValue", this.receivingBindingSource, "InvoiceNo", true));
            this.invoiceNoTextEdit.Location = new System.Drawing.Point(99, 38);
            this.invoiceNoTextEdit.Name = "invoiceNoTextEdit";
            this.invoiceNoTextEdit.Size = new System.Drawing.Size(261, 20);
            this.invoiceNoTextEdit.TabIndex = 3;
            // 
            // receivedDateDateEdit
            // 
            this.receivedDateDateEdit.DataBindings.Add(new System.Windows.Forms.Binding("EditValue", this.receivingBindingSource, "ReceivedDate", true));
            this.receivedDateDateEdit.EditValue = null;
            this.receivedDateDateEdit.Location = new System.Drawing.Point(99, 64);
            this.receivedDateDateEdit.Name = "receivedDateDateEdit";
            this.receivedDateDateEdit.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.receivedDateDateEdit.Properties.VistaTimeProperties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton()});
            this.receivedDateDateEdit.Size = new System.Drawing.Size(261, 20);
            this.receivedDateDateEdit.TabIndex = 5;
            // 
            // supplierIdLookUpEdit
            // 
            this.supplierIdLookUpEdit.DataBindings.Add(new System.Windows.Forms.Binding("EditValue", this.receivingBindingSource, "SupplierId", true));
            this.supplierIdLookUpEdit.Location = new System.Drawing.Point(99, 90);
            this.supplierIdLookUpEdit.Name = "supplierIdLookUpEdit";
            this.supplierIdLookUpEdit.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.supplierIdLookUpEdit.Properties.Columns.AddRange(new DevExpress.XtraEditors.Controls.LookUpColumnInfo[] {
            new DevExpress.XtraEditors.Controls.LookUpColumnInfo("Name", "Name", 37, DevExpress.Utils.FormatType.None, "", true, DevExpress.Utils.HorzAlignment.Near)});
            this.supplierIdLookUpEdit.Properties.DataSource = this.supplierBindingSource;
            this.supplierIdLookUpEdit.Properties.DisplayMember = "Name";
            this.supplierIdLookUpEdit.Properties.NullText = "[Select Supplier]";
            this.supplierIdLookUpEdit.Properties.ValueMember = "SupplierId";
            this.supplierIdLookUpEdit.Size = new System.Drawing.Size(261, 20);
            this.supplierIdLookUpEdit.TabIndex = 7;
            // 
            // supplierBindingSource
            // 
            this.supplierBindingSource.DataSource = typeof(ClearOffice.Inventory.DataAccess.Supplier);
            // 
            // warehouseIdLookUpEdit
            // 
            this.warehouseIdLookUpEdit.DataBindings.Add(new System.Windows.Forms.Binding("EditValue", this.receivingBindingSource, "WarehouseId", true));
            this.warehouseIdLookUpEdit.Location = new System.Drawing.Point(99, 116);
            this.warehouseIdLookUpEdit.Name = "warehouseIdLookUpEdit";
            this.warehouseIdLookUpEdit.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.warehouseIdLookUpEdit.Properties.Columns.AddRange(new DevExpress.XtraEditors.Controls.LookUpColumnInfo[] {
            new DevExpress.XtraEditors.Controls.LookUpColumnInfo("Name", "Name", 37, DevExpress.Utils.FormatType.None, "", true, DevExpress.Utils.HorzAlignment.Near)});
            this.warehouseIdLookUpEdit.Properties.DataSource = this.warehouseBindingSource;
            this.warehouseIdLookUpEdit.Properties.DisplayMember = "Name";
            this.warehouseIdLookUpEdit.Properties.NullText = "[Select Warehouse]";
            this.warehouseIdLookUpEdit.Properties.ValueMember = "WarehouseId";
            this.warehouseIdLookUpEdit.Size = new System.Drawing.Size(261, 20);
            this.warehouseIdLookUpEdit.TabIndex = 9;
            // 
            // warehouseBindingSource
            // 
            this.warehouseBindingSource.DataSource = typeof(ClearOffice.Inventory.DataAccess.Warehouse);
            // 
            // remarkMemoEdit
            // 
            this.remarkMemoEdit.DataBindings.Add(new System.Windows.Forms.Binding("EditValue", this.receivingBindingSource, "Remark", true));
            this.remarkMemoEdit.Location = new System.Drawing.Point(99, 142);
            this.remarkMemoEdit.Name = "remarkMemoEdit";
            this.remarkMemoEdit.Size = new System.Drawing.Size(261, 73);
            this.remarkMemoEdit.TabIndex = 11;
            // 
            // saveCommand
            // 
            this.saveCommand.Location = new System.Drawing.Point(114, 222);
            this.saveCommand.Name = "saveCommand";
            this.saveCommand.Size = new System.Drawing.Size(75, 23);
            this.saveCommand.TabIndex = 12;
            this.saveCommand.Text = "Save";
            this.saveCommand.Click += new System.EventHandler(this.saveCommand_Click);
            // 
            // cancelCommand
            // 
            this.cancelCommand.Location = new System.Drawing.Point(196, 222);
            this.cancelCommand.Name = "cancelCommand";
            this.cancelCommand.Size = new System.Drawing.Size(75, 23);
            this.cancelCommand.TabIndex = 13;
            this.cancelCommand.Text = "Cancel";
            this.cancelCommand.Click += new System.EventHandler(this.cancelCommand_Click);
            // 
            // errorProvider1
            // 
            this.errorProvider1.ContainerControl = this;
            this.errorProvider1.DataSource = this.receivingBindingSource;
            // 
            // NewReceiving
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(384, 255);
            this.Controls.Add(this.cancelCommand);
            this.Controls.Add(this.saveCommand);
            this.Controls.Add(remarkLabel);
            this.Controls.Add(this.remarkMemoEdit);
            this.Controls.Add(warehouseIdLabel);
            this.Controls.Add(this.warehouseIdLookUpEdit);
            this.Controls.Add(supplierIdLabel);
            this.Controls.Add(this.supplierIdLookUpEdit);
            this.Controls.Add(receivedDateLabel);
            this.Controls.Add(this.receivedDateDateEdit);
            this.Controls.Add(invoiceNoLabel);
            this.Controls.Add(this.invoiceNoTextEdit);
            this.Controls.Add(gRNLabel);
            this.Controls.Add(this.gRNTextEdit);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "NewReceiving";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "New Receiving";
            ((System.ComponentModel.ISupportInitialize)(this.gRNTextEdit.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.receivingBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.invoiceNoTextEdit.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.receivedDateDateEdit.Properties.VistaTimeProperties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.receivedDateDateEdit.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.supplierIdLookUpEdit.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.supplierBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.warehouseIdLookUpEdit.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.warehouseBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.remarkMemoEdit.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.BindingSource receivingBindingSource;
        private DevExpress.XtraEditors.TextEdit gRNTextEdit;
        private DevExpress.XtraEditors.TextEdit invoiceNoTextEdit;
        private DevExpress.XtraEditors.DateEdit receivedDateDateEdit;
        private DevExpress.XtraEditors.LookUpEdit supplierIdLookUpEdit;
        private DevExpress.XtraEditors.LookUpEdit warehouseIdLookUpEdit;
        private DevExpress.XtraEditors.MemoEdit remarkMemoEdit;
        private DevExpress.XtraEditors.SimpleButton saveCommand;
        private DevExpress.XtraEditors.SimpleButton cancelCommand;
        private System.Windows.Forms.BindingSource warehouseBindingSource;
        private System.Windows.Forms.BindingSource supplierBindingSource;
        private System.Windows.Forms.ErrorProvider errorProvider1;
    }
}