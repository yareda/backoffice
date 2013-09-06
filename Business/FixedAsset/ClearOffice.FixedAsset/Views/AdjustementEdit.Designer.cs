namespace ClearOffice.FixedAsset.Views
{
    partial class AdjustementEdit
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
            System.Windows.Forms.Label documentNumberLabel;
            System.Windows.Forms.Label documentDateLabel;
            System.Windows.Forms.Label adjustmentTypeLabel;
            System.Windows.Forms.Label fiscalPeriodLabel;
            System.Windows.Forms.Label fiscalYearLabel;
            System.Windows.Forms.Label previousValueLabel;
            System.Windows.Forms.Label adjustedValueLabel;
            System.Windows.Forms.Label remarkLabel;
            this.panelControl1 = new DevExpress.XtraEditors.PanelControl();
            this.fiscalPeriodTextBox = new System.Windows.Forms.TextBox();
            this.adjustementBindingSource = new System.Windows.Forms.BindingSource();
            this.fiscalYearTextBox = new System.Windows.Forms.TextBox();
            this.remarkTextBox = new System.Windows.Forms.TextBox();
            this.adjustedValueTextBox = new System.Windows.Forms.TextBox();
            this.previousValueTextBox = new System.Windows.Forms.TextBox();
            this.adjustmentTypeLookUpEdit = new DevExpress.XtraEditors.LookUpEdit();
            this.adjustementTypeBindingSource = new System.Windows.Forms.BindingSource();
            this.documentDateDateEdit = new DevExpress.XtraEditors.DateEdit();
            this.documentNumberTextBox = new System.Windows.Forms.TextBox();
            this.adjustementErrorProvider = new System.Windows.Forms.ErrorProvider();
            this.assetBindingSource = new System.Windows.Forms.BindingSource();
            this.btnSave = new DevExpress.XtraEditors.SimpleButton();
            this.btnCancel = new DevExpress.XtraEditors.SimpleButton();
            documentNumberLabel = new System.Windows.Forms.Label();
            documentDateLabel = new System.Windows.Forms.Label();
            adjustmentTypeLabel = new System.Windows.Forms.Label();
            fiscalPeriodLabel = new System.Windows.Forms.Label();
            fiscalYearLabel = new System.Windows.Forms.Label();
            previousValueLabel = new System.Windows.Forms.Label();
            adjustedValueLabel = new System.Windows.Forms.Label();
            remarkLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.panelControl1)).BeginInit();
            this.panelControl1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.adjustementBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.adjustmentTypeLookUpEdit.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.adjustementTypeBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.documentDateDateEdit.Properties.VistaTimeProperties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.documentDateDateEdit.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.adjustementErrorProvider)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.assetBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // documentNumberLabel
            // 
            documentNumberLabel.AutoSize = true;
            documentNumberLabel.Location = new System.Drawing.Point(6, 37);
            documentNumberLabel.Name = "documentNumberLabel";
            documentNumberLabel.Size = new System.Drawing.Size(99, 13);
            documentNumberLabel.TabIndex = 0;
            documentNumberLabel.Text = "Document Number:";
            // 
            // documentDateLabel
            // 
            documentDateLabel.AutoSize = true;
            documentDateLabel.Location = new System.Drawing.Point(265, 37);
            documentDateLabel.Name = "documentDateLabel";
            documentDateLabel.Size = new System.Drawing.Size(85, 13);
            documentDateLabel.TabIndex = 2;
            documentDateLabel.Text = "Document Date:";
            // 
            // adjustmentTypeLabel
            // 
            adjustmentTypeLabel.AutoSize = true;
            adjustmentTypeLabel.Location = new System.Drawing.Point(6, 11);
            adjustmentTypeLabel.Name = "adjustmentTypeLabel";
            adjustmentTypeLabel.Size = new System.Drawing.Size(93, 13);
            adjustmentTypeLabel.TabIndex = 4;
            adjustmentTypeLabel.Text = "Adjustment Type:";
            // 
            // fiscalPeriodLabel
            // 
            fiscalPeriodLabel.AutoSize = true;
            fiscalPeriodLabel.Location = new System.Drawing.Point(6, 64);
            fiscalPeriodLabel.Name = "fiscalPeriodLabel";
            fiscalPeriodLabel.Size = new System.Drawing.Size(70, 13);
            fiscalPeriodLabel.TabIndex = 6;
            fiscalPeriodLabel.Text = "Fiscal Period:";
            // 
            // fiscalYearLabel
            // 
            fiscalYearLabel.AutoSize = true;
            fiscalYearLabel.Location = new System.Drawing.Point(265, 64);
            fiscalYearLabel.Name = "fiscalYearLabel";
            fiscalYearLabel.Size = new System.Drawing.Size(62, 13);
            fiscalYearLabel.TabIndex = 8;
            fiscalYearLabel.Text = "Fiscal Year:";
            // 
            // previousValueLabel
            // 
            previousValueLabel.AutoSize = true;
            previousValueLabel.Location = new System.Drawing.Point(6, 91);
            previousValueLabel.Name = "previousValueLabel";
            previousValueLabel.Size = new System.Drawing.Size(81, 13);
            previousValueLabel.TabIndex = 10;
            previousValueLabel.Text = "Previous Value:";
            // 
            // adjustedValueLabel
            // 
            adjustedValueLabel.AutoSize = true;
            adjustedValueLabel.Location = new System.Drawing.Point(265, 91);
            adjustedValueLabel.Name = "adjustedValueLabel";
            adjustedValueLabel.Size = new System.Drawing.Size(83, 13);
            adjustedValueLabel.TabIndex = 12;
            adjustedValueLabel.Text = "Adjusted Value:";
            // 
            // remarkLabel
            // 
            remarkLabel.AutoSize = true;
            remarkLabel.Location = new System.Drawing.Point(6, 118);
            remarkLabel.Name = "remarkLabel";
            remarkLabel.Size = new System.Drawing.Size(47, 13);
            remarkLabel.TabIndex = 14;
            remarkLabel.Text = "Remark:";
            // 
            // panelControl1
            // 
            this.panelControl1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panelControl1.Controls.Add(this.fiscalPeriodTextBox);
            this.panelControl1.Controls.Add(this.fiscalYearTextBox);
            this.panelControl1.Controls.Add(remarkLabel);
            this.panelControl1.Controls.Add(this.remarkTextBox);
            this.panelControl1.Controls.Add(adjustedValueLabel);
            this.panelControl1.Controls.Add(this.adjustedValueTextBox);
            this.panelControl1.Controls.Add(previousValueLabel);
            this.panelControl1.Controls.Add(this.previousValueTextBox);
            this.panelControl1.Controls.Add(fiscalYearLabel);
            this.panelControl1.Controls.Add(fiscalPeriodLabel);
            this.panelControl1.Controls.Add(adjustmentTypeLabel);
            this.panelControl1.Controls.Add(this.adjustmentTypeLookUpEdit);
            this.panelControl1.Controls.Add(documentDateLabel);
            this.panelControl1.Controls.Add(this.documentDateDateEdit);
            this.panelControl1.Controls.Add(documentNumberLabel);
            this.panelControl1.Controls.Add(this.documentNumberTextBox);
            this.panelControl1.Location = new System.Drawing.Point(12, 12);
            this.panelControl1.Name = "panelControl1";
            this.panelControl1.Size = new System.Drawing.Size(514, 210);
            this.panelControl1.TabIndex = 1;
            // 
            // fiscalPeriodTextBox
            // 
            this.fiscalPeriodTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.adjustementBindingSource, "FiscalPeriod", true));
            this.fiscalPeriodTextBox.Location = new System.Drawing.Point(111, 61);
            this.fiscalPeriodTextBox.Name = "fiscalPeriodTextBox";
            this.fiscalPeriodTextBox.Size = new System.Drawing.Size(148, 21);
            this.fiscalPeriodTextBox.TabIndex = 22;
            // 
            // adjustementBindingSource
            // 
            this.adjustementBindingSource.DataSource = typeof(ClearOffice.FixedAsset.DataAccess.Adjustment);
            // 
            // fiscalYearTextBox
            // 
            this.fiscalYearTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.adjustementBindingSource, "FiscalYear", true));
            this.fiscalYearTextBox.Location = new System.Drawing.Point(358, 61);
            this.fiscalYearTextBox.Name = "fiscalYearTextBox";
            this.fiscalYearTextBox.Size = new System.Drawing.Size(148, 21);
            this.fiscalYearTextBox.TabIndex = 21;
            // 
            // remarkTextBox
            // 
            this.remarkTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.adjustementBindingSource, "Remark", true));
            this.remarkTextBox.Location = new System.Drawing.Point(111, 115);
            this.remarkTextBox.Multiline = true;
            this.remarkTextBox.Name = "remarkTextBox";
            this.remarkTextBox.Size = new System.Drawing.Size(395, 80);
            this.remarkTextBox.TabIndex = 15;
            // 
            // adjustedValueTextBox
            // 
            this.adjustedValueTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.adjustementBindingSource, "AdjustedValue", true));
            this.adjustedValueTextBox.Location = new System.Drawing.Point(358, 88);
            this.adjustedValueTextBox.Name = "adjustedValueTextBox";
            this.adjustedValueTextBox.Size = new System.Drawing.Size(148, 21);
            this.adjustedValueTextBox.TabIndex = 13;
            // 
            // previousValueTextBox
            // 
            this.previousValueTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.adjustementBindingSource, "PreviousValue", true));
            this.previousValueTextBox.Enabled = false;
            this.previousValueTextBox.Location = new System.Drawing.Point(111, 88);
            this.previousValueTextBox.Name = "previousValueTextBox";
            this.previousValueTextBox.Size = new System.Drawing.Size(148, 21);
            this.previousValueTextBox.TabIndex = 11;
            // 
            // adjustmentTypeLookUpEdit
            // 
            this.adjustmentTypeLookUpEdit.DataBindings.Add(new System.Windows.Forms.Binding("EditValue", this.adjustementBindingSource, "AdjustmentType", true));
            this.adjustmentTypeLookUpEdit.Location = new System.Drawing.Point(111, 8);
            this.adjustmentTypeLookUpEdit.Name = "adjustmentTypeLookUpEdit";
            this.adjustmentTypeLookUpEdit.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.adjustmentTypeLookUpEdit.Properties.Columns.AddRange(new DevExpress.XtraEditors.Controls.LookUpColumnInfo[] {
            new DevExpress.XtraEditors.Controls.LookUpColumnInfo("ItemName", "Item Name", 62, DevExpress.Utils.FormatType.None, "", true, DevExpress.Utils.HorzAlignment.Near)});
            this.adjustmentTypeLookUpEdit.Properties.DataSource = this.adjustementTypeBindingSource;
            this.adjustmentTypeLookUpEdit.Properties.DisplayMember = "ItemName";
            this.adjustmentTypeLookUpEdit.Properties.NullText = "[Select Adjustment Type]";
            this.adjustmentTypeLookUpEdit.Properties.ValueMember = "LookupItemId";
            this.adjustmentTypeLookUpEdit.Size = new System.Drawing.Size(395, 20);
            this.adjustmentTypeLookUpEdit.TabIndex = 5;
            // 
            // adjustementTypeBindingSource
            // 
            this.adjustementTypeBindingSource.DataSource = typeof(ClearOffice.FixedAsset.DataAccess.LookupItem);
            // 
            // documentDateDateEdit
            // 
            this.documentDateDateEdit.DataBindings.Add(new System.Windows.Forms.Binding("EditValue", this.adjustementBindingSource, "DocumentDate", true));
            this.documentDateDateEdit.EditValue = null;
            this.documentDateDateEdit.Location = new System.Drawing.Point(358, 34);
            this.documentDateDateEdit.Name = "documentDateDateEdit";
            this.documentDateDateEdit.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.documentDateDateEdit.Properties.VistaTimeProperties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton()});
            this.documentDateDateEdit.Size = new System.Drawing.Size(148, 20);
            this.documentDateDateEdit.TabIndex = 3;
            // 
            // documentNumberTextBox
            // 
            this.documentNumberTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.adjustementBindingSource, "DocumentNumber", true));
            this.documentNumberTextBox.Location = new System.Drawing.Point(111, 34);
            this.documentNumberTextBox.Name = "documentNumberTextBox";
            this.documentNumberTextBox.Size = new System.Drawing.Size(148, 21);
            this.documentNumberTextBox.TabIndex = 1;
            // 
            // adjustementErrorProvider
            // 
            this.adjustementErrorProvider.ContainerControl = this;
            this.adjustementErrorProvider.DataSource = this.adjustementBindingSource;
            // 
            // assetBindingSource
            // 
            this.assetBindingSource.DataSource = typeof(ClearOffice.FixedAsset.DataAccess.Asset);
            // 
            // btnSave
            // 
            this.btnSave.Location = new System.Drawing.Point(195, 228);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(75, 23);
            this.btnSave.TabIndex = 17;
            this.btnSave.Text = "Save";
            this.btnSave.Click += new System.EventHandler(this.saveToolStripButton_Click);
            // 
            // btnCancel
            // 
            this.btnCancel.Location = new System.Drawing.Point(298, 228);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(75, 23);
            this.btnCancel.TabIndex = 18;
            this.btnCancel.Text = "Cancel";
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // AdjustementEdit
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(528, 257);
            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.btnSave);
            this.Controls.Add(this.panelControl1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "AdjustementEdit";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Adjustment Edit";
            ((System.ComponentModel.ISupportInitialize)(this.panelControl1)).EndInit();
            this.panelControl1.ResumeLayout(false);
            this.panelControl1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.adjustementBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.adjustmentTypeLookUpEdit.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.adjustementTypeBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.documentDateDateEdit.Properties.VistaTimeProperties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.documentDateDateEdit.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.adjustementErrorProvider)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.assetBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraEditors.PanelControl panelControl1;
        private System.Windows.Forms.BindingSource adjustementBindingSource;
        private System.Windows.Forms.TextBox remarkTextBox;
        private System.Windows.Forms.TextBox adjustedValueTextBox;
        private System.Windows.Forms.TextBox previousValueTextBox;
        private DevExpress.XtraEditors.LookUpEdit adjustmentTypeLookUpEdit;
        private DevExpress.XtraEditors.DateEdit documentDateDateEdit;
        private System.Windows.Forms.TextBox documentNumberTextBox;
        private System.Windows.Forms.ErrorProvider adjustementErrorProvider;
        private System.Windows.Forms.BindingSource adjustementTypeBindingSource;
        private System.Windows.Forms.TextBox fiscalYearTextBox;
        private System.Windows.Forms.TextBox fiscalPeriodTextBox;
        private System.Windows.Forms.BindingSource assetBindingSource;
        private DevExpress.XtraEditors.SimpleButton btnCancel;
        private DevExpress.XtraEditors.SimpleButton btnSave;
    }
}