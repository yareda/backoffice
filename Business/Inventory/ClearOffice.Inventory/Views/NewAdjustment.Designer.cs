namespace ClearOffice.Inventory.Views
{
    partial class NewAdjustment
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
            System.Windows.Forms.Label adjustmentNoLabel;
            System.Windows.Forms.Label warehouseIdLabel;
            System.Windows.Forms.Label createdByLabel;
            System.Windows.Forms.Label createdDateLabel;
            System.Windows.Forms.Label reasonLabel;
            this.adjustmenterrorProvider = new System.Windows.Forms.ErrorProvider(this.components);
            this.adjustmentBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.saveCommand = new DevExpress.XtraEditors.SimpleButton();
            this.cancelCommand = new DevExpress.XtraEditors.SimpleButton();
            this.adjustmentNoTextEdit = new DevExpress.XtraEditors.TextEdit();
            this.warehouseIdLookUpEdit = new DevExpress.XtraEditors.LookUpEdit();
            this.warehouseBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.createdByTextEdit = new DevExpress.XtraEditors.TextEdit();
            this.createdDateDateEdit = new DevExpress.XtraEditors.DateEdit();
            this.reasonTextEdit = new DevExpress.XtraEditors.MemoEdit();
            adjustmentNoLabel = new System.Windows.Forms.Label();
            warehouseIdLabel = new System.Windows.Forms.Label();
            createdByLabel = new System.Windows.Forms.Label();
            createdDateLabel = new System.Windows.Forms.Label();
            reasonLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.adjustmenterrorProvider)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.adjustmentBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.adjustmentNoTextEdit.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.warehouseIdLookUpEdit.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.warehouseBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.createdByTextEdit.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.createdDateDateEdit.Properties.VistaTimeProperties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.createdDateDateEdit.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.reasonTextEdit.Properties)).BeginInit();
            this.SuspendLayout();
            // 
            // adjustmentNoLabel
            // 
            adjustmentNoLabel.AutoSize = true;
            adjustmentNoLabel.Location = new System.Drawing.Point(16, 12);
            adjustmentNoLabel.Name = "adjustmentNoLabel";
            adjustmentNoLabel.Size = new System.Drawing.Size(77, 13);
            adjustmentNoLabel.TabIndex = 2;
            adjustmentNoLabel.Text = "Adjustment #:";
            // 
            // warehouseIdLabel
            // 
            warehouseIdLabel.AutoSize = true;
            warehouseIdLabel.Location = new System.Drawing.Point(16, 34);
            warehouseIdLabel.Name = "warehouseIdLabel";
            warehouseIdLabel.Size = new System.Drawing.Size(66, 13);
            warehouseIdLabel.TabIndex = 4;
            warehouseIdLabel.Text = "Warehouse:";
            // 
            // createdByLabel
            // 
            createdByLabel.AutoSize = true;
            createdByLabel.Location = new System.Drawing.Point(16, 60);
            createdByLabel.Name = "createdByLabel";
            createdByLabel.Size = new System.Drawing.Size(65, 13);
            createdByLabel.TabIndex = 6;
            createdByLabel.Text = "Created By:";
            // 
            // createdDateLabel
            // 
            createdDateLabel.AutoSize = true;
            createdDateLabel.Location = new System.Drawing.Point(16, 86);
            createdDateLabel.Name = "createdDateLabel";
            createdDateLabel.Size = new System.Drawing.Size(76, 13);
            createdDateLabel.TabIndex = 8;
            createdDateLabel.Text = "Created Date:";
            // 
            // reasonLabel
            // 
            reasonLabel.AutoSize = true;
            reasonLabel.Location = new System.Drawing.Point(17, 110);
            reasonLabel.Name = "reasonLabel";
            reasonLabel.Size = new System.Drawing.Size(47, 13);
            reasonLabel.TabIndex = 14;
            reasonLabel.Text = "Reason:";
            // 
            // adjustmenterrorProvider
            // 
            this.adjustmenterrorProvider.ContainerControl = this;
            this.adjustmenterrorProvider.DataSource = this.adjustmentBindingSource;
            // 
            // adjustmentBindingSource
            // 
            this.adjustmentBindingSource.DataSource = typeof(ClearOffice.Inventory.DataAccess.Adjustment);
            // 
            // saveCommand
            // 
            this.saveCommand.Location = new System.Drawing.Point(117, 185);
            this.saveCommand.Name = "saveCommand";
            this.saveCommand.Size = new System.Drawing.Size(75, 23);
            this.saveCommand.TabIndex = 0;
            this.saveCommand.Text = "Save";
            this.saveCommand.Click += new System.EventHandler(this.saveCommand_Click);
            // 
            // cancelCommand
            // 
            this.cancelCommand.Location = new System.Drawing.Point(212, 185);
            this.cancelCommand.Name = "cancelCommand";
            this.cancelCommand.Size = new System.Drawing.Size(75, 23);
            this.cancelCommand.TabIndex = 1;
            this.cancelCommand.Text = "Cancel";
            this.cancelCommand.Click += new System.EventHandler(this.cancelCommand_Click);
            // 
            // adjustmentNoTextEdit
            // 
            this.adjustmentNoTextEdit.DataBindings.Add(new System.Windows.Forms.Binding("EditValue", this.adjustmentBindingSource, "AdjustmentNo", true));
            this.adjustmentNoTextEdit.Location = new System.Drawing.Point(100, 9);
            this.adjustmentNoTextEdit.Name = "adjustmentNoTextEdit";
            this.adjustmentNoTextEdit.Properties.ReadOnly = true;
            this.adjustmentNoTextEdit.Size = new System.Drawing.Size(232, 20);
            this.adjustmentNoTextEdit.TabIndex = 3;
            // 
            // warehouseIdLookUpEdit
            // 
            this.warehouseIdLookUpEdit.DataBindings.Add(new System.Windows.Forms.Binding("EditValue", this.adjustmentBindingSource, "WarehouseId", true));
            this.warehouseIdLookUpEdit.Location = new System.Drawing.Point(100, 34);
            this.warehouseIdLookUpEdit.Name = "warehouseIdLookUpEdit";
            this.warehouseIdLookUpEdit.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.warehouseIdLookUpEdit.Properties.Columns.AddRange(new DevExpress.XtraEditors.Controls.LookUpColumnInfo[] {
            new DevExpress.XtraEditors.Controls.LookUpColumnInfo("Name", "Name", 37, DevExpress.Utils.FormatType.None, "", true, DevExpress.Utils.HorzAlignment.Near)});
            this.warehouseIdLookUpEdit.Properties.DataSource = this.warehouseBindingSource;
            this.warehouseIdLookUpEdit.Properties.DisplayMember = "Name";
            this.warehouseIdLookUpEdit.Properties.NullText = "[Select Warehouse]";
            this.warehouseIdLookUpEdit.Properties.ValueMember = "WarehouseId";
            this.warehouseIdLookUpEdit.Size = new System.Drawing.Size(232, 20);
            this.warehouseIdLookUpEdit.TabIndex = 5;
            // 
            // warehouseBindingSource
            // 
            this.warehouseBindingSource.DataSource = typeof(ClearOffice.Inventory.DataAccess.Warehouse);
            // 
            // createdByTextEdit
            // 
            this.createdByTextEdit.DataBindings.Add(new System.Windows.Forms.Binding("EditValue", this.adjustmentBindingSource, "CreatedBy", true));
            this.createdByTextEdit.Location = new System.Drawing.Point(100, 58);
            this.createdByTextEdit.Name = "createdByTextEdit";
            this.createdByTextEdit.Size = new System.Drawing.Size(232, 20);
            this.createdByTextEdit.TabIndex = 7;
            // 
            // createdDateDateEdit
            // 
            this.createdDateDateEdit.DataBindings.Add(new System.Windows.Forms.Binding("EditValue", this.adjustmentBindingSource, "CreatedDate", true));
            this.createdDateDateEdit.EditValue = null;
            this.createdDateDateEdit.Location = new System.Drawing.Point(100, 83);
            this.createdDateDateEdit.Name = "createdDateDateEdit";
            this.createdDateDateEdit.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.createdDateDateEdit.Properties.VistaTimeProperties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton()});
            this.createdDateDateEdit.Size = new System.Drawing.Size(232, 20);
            this.createdDateDateEdit.TabIndex = 9;
            // 
            // reasonTextEdit
            // 
            this.reasonTextEdit.DataBindings.Add(new System.Windows.Forms.Binding("EditValue", this.adjustmentBindingSource, "Reason", true));
            this.reasonTextEdit.Location = new System.Drawing.Point(100, 109);
            this.reasonTextEdit.Name = "reasonTextEdit";
            this.reasonTextEdit.Size = new System.Drawing.Size(277, 70);
            this.reasonTextEdit.TabIndex = 15;
            // 
            // NewAdjustment
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(389, 214);
            this.Controls.Add(reasonLabel);
            this.Controls.Add(createdDateLabel);
            this.Controls.Add(this.createdDateDateEdit);
            this.Controls.Add(createdByLabel);
            this.Controls.Add(this.createdByTextEdit);
            this.Controls.Add(warehouseIdLabel);
            this.Controls.Add(this.warehouseIdLookUpEdit);
            this.Controls.Add(adjustmentNoLabel);
            this.Controls.Add(this.adjustmentNoTextEdit);
            this.Controls.Add(this.cancelCommand);
            this.Controls.Add(this.saveCommand);
            this.Controls.Add(this.reasonTextEdit);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "NewAdjustment";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "New Adjustment";
            ((System.ComponentModel.ISupportInitialize)(this.adjustmenterrorProvider)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.adjustmentBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.adjustmentNoTextEdit.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.warehouseIdLookUpEdit.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.warehouseBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.createdByTextEdit.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.createdDateDateEdit.Properties.VistaTimeProperties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.createdDateDateEdit.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.reasonTextEdit.Properties)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.BindingSource adjustmentBindingSource;
        private System.Windows.Forms.ErrorProvider adjustmenterrorProvider;
        private DevExpress.XtraEditors.SimpleButton cancelCommand;
        private DevExpress.XtraEditors.SimpleButton saveCommand;
        private DevExpress.XtraEditors.DateEdit createdDateDateEdit;
        private DevExpress.XtraEditors.TextEdit createdByTextEdit;
        private DevExpress.XtraEditors.LookUpEdit warehouseIdLookUpEdit;
        private DevExpress.XtraEditors.TextEdit adjustmentNoTextEdit;
        private DevExpress.XtraEditors.MemoEdit reasonTextEdit;
        private System.Windows.Forms.BindingSource warehouseBindingSource;
    }
}