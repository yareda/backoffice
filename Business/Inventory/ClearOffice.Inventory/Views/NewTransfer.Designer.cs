namespace ClearOffice.Inventory.Views
{
    partial class NewTransfer
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
            System.Windows.Forms.Label transferNoLabel;
            System.Windows.Forms.Label transferByLabel;
            System.Windows.Forms.Label transferDateLabel;
            System.Windows.Forms.Label warehouseFromLabel;
            System.Windows.Forms.Label warehouseToLabel;
            System.Windows.Forms.Label reasonLabel;
            System.Windows.Forms.Label remarkLabel;
            this.transferNoTextEdit = new DevExpress.XtraEditors.TextEdit();
            this.transferBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.transferByTextEdit = new DevExpress.XtraEditors.TextEdit();
            this.transferDateDateEdit = new DevExpress.XtraEditors.DateEdit();
            this.warehouseFromLookUpEdit = new DevExpress.XtraEditors.LookUpEdit();
            this.sourceWarehouseBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.warehouseToLookUpEdit = new DevExpress.XtraEditors.LookUpEdit();
            this.destinationWarehouseBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.reasonMemoEdit = new DevExpress.XtraEditors.MemoEdit();
            this.remarkMemoEdit = new DevExpress.XtraEditors.MemoEdit();
            this.saveCommand = new DevExpress.XtraEditors.SimpleButton();
            this.cancelCommand = new DevExpress.XtraEditors.SimpleButton();
            this.errorProvider1 = new System.Windows.Forms.ErrorProvider(this.components);
            transferNoLabel = new System.Windows.Forms.Label();
            transferByLabel = new System.Windows.Forms.Label();
            transferDateLabel = new System.Windows.Forms.Label();
            warehouseFromLabel = new System.Windows.Forms.Label();
            warehouseToLabel = new System.Windows.Forms.Label();
            reasonLabel = new System.Windows.Forms.Label();
            remarkLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.transferNoTextEdit.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.transferBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.transferByTextEdit.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.transferDateDateEdit.Properties.VistaTimeProperties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.transferDateDateEdit.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.warehouseFromLookUpEdit.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.sourceWarehouseBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.warehouseToLookUpEdit.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.destinationWarehouseBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.reasonMemoEdit.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.remarkMemoEdit.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).BeginInit();
            this.SuspendLayout();
            // 
            // transferNoLabel
            // 
            transferNoLabel.AutoSize = true;
            transferNoLabel.Location = new System.Drawing.Point(7, 15);
            transferNoLabel.Name = "transferNoLabel";
            transferNoLabel.Size = new System.Drawing.Size(68, 13);
            transferNoLabel.TabIndex = 0;
            transferNoLabel.Text = "Transfer No:";
            // 
            // transferByLabel
            // 
            transferByLabel.AutoSize = true;
            transferByLabel.Location = new System.Drawing.Point(7, 41);
            transferByLabel.Name = "transferByLabel";
            transferByLabel.Size = new System.Drawing.Size(67, 13);
            transferByLabel.TabIndex = 2;
            transferByLabel.Text = "Transfer By:";
            // 
            // transferDateLabel
            // 
            transferDateLabel.AutoSize = true;
            transferDateLabel.Location = new System.Drawing.Point(231, 41);
            transferDateLabel.Name = "transferDateLabel";
            transferDateLabel.Size = new System.Drawing.Size(78, 13);
            transferDateLabel.TabIndex = 4;
            transferDateLabel.Text = "Transfer Date:";
            // 
            // warehouseFromLabel
            // 
            warehouseFromLabel.AutoSize = true;
            warehouseFromLabel.Location = new System.Drawing.Point(7, 67);
            warehouseFromLabel.Name = "warehouseFromLabel";
            warehouseFromLabel.Size = new System.Drawing.Size(44, 13);
            warehouseFromLabel.TabIndex = 6;
            warehouseFromLabel.Text = "Source:";
            // 
            // warehouseToLabel
            // 
            warehouseToLabel.AutoSize = true;
            warehouseToLabel.Location = new System.Drawing.Point(231, 67);
            warehouseToLabel.Name = "warehouseToLabel";
            warehouseToLabel.Size = new System.Drawing.Size(65, 13);
            warehouseToLabel.TabIndex = 8;
            warehouseToLabel.Text = "Destination:";
            // 
            // reasonLabel
            // 
            reasonLabel.AutoSize = true;
            reasonLabel.Location = new System.Drawing.Point(7, 93);
            reasonLabel.Name = "reasonLabel";
            reasonLabel.Size = new System.Drawing.Size(47, 13);
            reasonLabel.TabIndex = 10;
            reasonLabel.Text = "Reason:";
            // 
            // remarkLabel
            // 
            remarkLabel.AutoSize = true;
            remarkLabel.Location = new System.Drawing.Point(7, 159);
            remarkLabel.Name = "remarkLabel";
            remarkLabel.Size = new System.Drawing.Size(47, 13);
            remarkLabel.TabIndex = 12;
            remarkLabel.Text = "Remark:";
            // 
            // transferNoTextEdit
            // 
            this.transferNoTextEdit.DataBindings.Add(new System.Windows.Forms.Binding("EditValue", this.transferBindingSource, "TransferNo", true));
            this.transferNoTextEdit.Location = new System.Drawing.Point(76, 12);
            this.transferNoTextEdit.Name = "transferNoTextEdit";
            this.transferNoTextEdit.Size = new System.Drawing.Size(147, 20);
            this.transferNoTextEdit.TabIndex = 1;
            // 
            // transferBindingSource
            // 
            this.transferBindingSource.DataSource = typeof(ClearOffice.Inventory.DataAccess.Transfer);
            this.transferBindingSource.CurrentItemChanged += new System.EventHandler(this.transferBindingSource_CurrentItemChanged);
            // 
            // transferByTextEdit
            // 
            this.transferByTextEdit.DataBindings.Add(new System.Windows.Forms.Binding("EditValue", this.transferBindingSource, "TransferBy", true));
            this.transferByTextEdit.Location = new System.Drawing.Point(76, 38);
            this.transferByTextEdit.Name = "transferByTextEdit";
            this.transferByTextEdit.Size = new System.Drawing.Size(147, 20);
            this.transferByTextEdit.TabIndex = 3;
            // 
            // transferDateDateEdit
            // 
            this.transferDateDateEdit.DataBindings.Add(new System.Windows.Forms.Binding("EditValue", this.transferBindingSource, "TransferDate", true));
            this.transferDateDateEdit.EditValue = null;
            this.transferDateDateEdit.Location = new System.Drawing.Point(309, 38);
            this.transferDateDateEdit.Name = "transferDateDateEdit";
            this.transferDateDateEdit.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.transferDateDateEdit.Properties.VistaTimeProperties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton()});
            this.transferDateDateEdit.Size = new System.Drawing.Size(150, 20);
            this.transferDateDateEdit.TabIndex = 5;
            // 
            // warehouseFromLookUpEdit
            // 
            this.warehouseFromLookUpEdit.DataBindings.Add(new System.Windows.Forms.Binding("EditValue", this.transferBindingSource, "WarehouseFrom", true));
            this.warehouseFromLookUpEdit.Location = new System.Drawing.Point(76, 64);
            this.warehouseFromLookUpEdit.Name = "warehouseFromLookUpEdit";
            this.warehouseFromLookUpEdit.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.warehouseFromLookUpEdit.Properties.Columns.AddRange(new DevExpress.XtraEditors.Controls.LookUpColumnInfo[] {
            new DevExpress.XtraEditors.Controls.LookUpColumnInfo("Name", "Name", 37, DevExpress.Utils.FormatType.None, "", true, DevExpress.Utils.HorzAlignment.Near)});
            this.warehouseFromLookUpEdit.Properties.DataSource = this.sourceWarehouseBindingSource;
            this.warehouseFromLookUpEdit.Properties.DisplayMember = "Name";
            this.warehouseFromLookUpEdit.Properties.NullText = "[Select Source Warehouse]";
            this.warehouseFromLookUpEdit.Properties.ValueMember = "WarehouseId";
            this.warehouseFromLookUpEdit.Size = new System.Drawing.Size(147, 20);
            this.warehouseFromLookUpEdit.TabIndex = 7;
            // 
            // sourceWarehouseBindingSource
            // 
            this.sourceWarehouseBindingSource.DataSource = typeof(ClearOffice.Inventory.DataAccess.Warehouse);
            // 
            // warehouseToLookUpEdit
            // 
            this.warehouseToLookUpEdit.DataBindings.Add(new System.Windows.Forms.Binding("EditValue", this.transferBindingSource, "WarehouseTo", true));
            this.warehouseToLookUpEdit.Location = new System.Drawing.Point(309, 64);
            this.warehouseToLookUpEdit.Name = "warehouseToLookUpEdit";
            this.warehouseToLookUpEdit.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.warehouseToLookUpEdit.Properties.Columns.AddRange(new DevExpress.XtraEditors.Controls.LookUpColumnInfo[] {
            new DevExpress.XtraEditors.Controls.LookUpColumnInfo("Name", "Name", 37, DevExpress.Utils.FormatType.None, "", true, DevExpress.Utils.HorzAlignment.Near)});
            this.warehouseToLookUpEdit.Properties.DataSource = this.destinationWarehouseBindingSource;
            this.warehouseToLookUpEdit.Properties.DisplayMember = "Name";
            this.warehouseToLookUpEdit.Properties.NullText = "[Select Destination Warehouse]";
            this.warehouseToLookUpEdit.Properties.ValueMember = "WarehouseId";
            this.warehouseToLookUpEdit.Size = new System.Drawing.Size(150, 20);
            this.warehouseToLookUpEdit.TabIndex = 9;
            // 
            // destinationWarehouseBindingSource
            // 
            this.destinationWarehouseBindingSource.DataSource = typeof(ClearOffice.Inventory.DataAccess.Warehouse);
            // 
            // reasonMemoEdit
            // 
            this.reasonMemoEdit.DataBindings.Add(new System.Windows.Forms.Binding("EditValue", this.transferBindingSource, "Reason", true));
            this.reasonMemoEdit.Location = new System.Drawing.Point(76, 90);
            this.reasonMemoEdit.Name = "reasonMemoEdit";
            this.reasonMemoEdit.Size = new System.Drawing.Size(383, 60);
            this.reasonMemoEdit.TabIndex = 11;
            // 
            // remarkMemoEdit
            // 
            this.remarkMemoEdit.DataBindings.Add(new System.Windows.Forms.Binding("EditValue", this.transferBindingSource, "Remark", true));
            this.remarkMemoEdit.Location = new System.Drawing.Point(76, 156);
            this.remarkMemoEdit.Name = "remarkMemoEdit";
            this.remarkMemoEdit.Size = new System.Drawing.Size(383, 60);
            this.remarkMemoEdit.TabIndex = 13;
            // 
            // saveCommand
            // 
            this.saveCommand.Location = new System.Drawing.Point(156, 223);
            this.saveCommand.Name = "saveCommand";
            this.saveCommand.Size = new System.Drawing.Size(75, 23);
            this.saveCommand.TabIndex = 14;
            this.saveCommand.Text = "Save";
            this.saveCommand.Click += new System.EventHandler(this.saveCommand_Click);
            // 
            // cancelCommand
            // 
            this.cancelCommand.Location = new System.Drawing.Point(237, 223);
            this.cancelCommand.Name = "cancelCommand";
            this.cancelCommand.Size = new System.Drawing.Size(75, 23);
            this.cancelCommand.TabIndex = 15;
            this.cancelCommand.Text = "Cancel";
            this.cancelCommand.Click += new System.EventHandler(this.cancelCommand_Click);
            // 
            // errorProvider1
            // 
            this.errorProvider1.ContainerControl = this;
            this.errorProvider1.DataSource = this.transferBindingSource;
            // 
            // NewTransfer
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(466, 255);
            this.Controls.Add(this.cancelCommand);
            this.Controls.Add(this.saveCommand);
            this.Controls.Add(remarkLabel);
            this.Controls.Add(this.remarkMemoEdit);
            this.Controls.Add(reasonLabel);
            this.Controls.Add(this.reasonMemoEdit);
            this.Controls.Add(warehouseToLabel);
            this.Controls.Add(this.warehouseToLookUpEdit);
            this.Controls.Add(warehouseFromLabel);
            this.Controls.Add(this.warehouseFromLookUpEdit);
            this.Controls.Add(transferDateLabel);
            this.Controls.Add(this.transferDateDateEdit);
            this.Controls.Add(transferByLabel);
            this.Controls.Add(this.transferByTextEdit);
            this.Controls.Add(transferNoLabel);
            this.Controls.Add(this.transferNoTextEdit);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "NewTransfer";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "New Stock Transfer";
            ((System.ComponentModel.ISupportInitialize)(this.transferNoTextEdit.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.transferBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.transferByTextEdit.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.transferDateDateEdit.Properties.VistaTimeProperties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.transferDateDateEdit.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.warehouseFromLookUpEdit.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.sourceWarehouseBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.warehouseToLookUpEdit.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.destinationWarehouseBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.reasonMemoEdit.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.remarkMemoEdit.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.BindingSource transferBindingSource;
        private DevExpress.XtraEditors.TextEdit transferNoTextEdit;
        private DevExpress.XtraEditors.TextEdit transferByTextEdit;
        private DevExpress.XtraEditors.DateEdit transferDateDateEdit;
        private DevExpress.XtraEditors.LookUpEdit warehouseFromLookUpEdit;
        private DevExpress.XtraEditors.LookUpEdit warehouseToLookUpEdit;
        private DevExpress.XtraEditors.MemoEdit reasonMemoEdit;
        private DevExpress.XtraEditors.MemoEdit remarkMemoEdit;
        private DevExpress.XtraEditors.SimpleButton saveCommand;
        private DevExpress.XtraEditors.SimpleButton cancelCommand;
        private System.Windows.Forms.BindingSource sourceWarehouseBindingSource;
        private System.Windows.Forms.BindingSource destinationWarehouseBindingSource;
        private System.Windows.Forms.ErrorProvider errorProvider1;
    }
}