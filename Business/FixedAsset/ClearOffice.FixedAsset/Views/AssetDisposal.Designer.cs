namespace ClearOffice.FixedAsset.Views
{
    partial class AssetDisposal
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
            System.Windows.Forms.Label disposalTypeLabel;
            System.Windows.Forms.Label amountLabel;
            System.Windows.Forms.Label documentNumberLabel;
            System.Windows.Forms.Label documentDateLabel;
            System.Windows.Forms.Label fiscalYearLabel;
            System.Windows.Forms.Label remarkLabel;
            System.Windows.Forms.Label disposaldateLabel;
            this.panelControl1 = new DevExpress.XtraEditors.PanelControl();
            this.disposaldateDateEdit = new DevExpress.XtraEditors.DateEdit();
            this.disposalBindingSource = new System.Windows.Forms.BindingSource();
            this.remarkTextBox = new System.Windows.Forms.TextBox();
            this.fiscalYearTextBox = new System.Windows.Forms.TextBox();
            this.documentDateDateEdit = new DevExpress.XtraEditors.DateEdit();
            this.documentNumberTextBox = new System.Windows.Forms.TextBox();
            this.amountTextBox = new System.Windows.Forms.TextBox();
            this.disposalTypeLookUpEdit = new DevExpress.XtraEditors.LookUpEdit();
            this.disposalTypeBindingSource = new System.Windows.Forms.BindingSource();
            this.disposalErrorProvider = new System.Windows.Forms.ErrorProvider();
            this.btnSave = new DevExpress.XtraEditors.SimpleButton();
            this.btnCancel = new DevExpress.XtraEditors.SimpleButton();
            disposalTypeLabel = new System.Windows.Forms.Label();
            amountLabel = new System.Windows.Forms.Label();
            documentNumberLabel = new System.Windows.Forms.Label();
            documentDateLabel = new System.Windows.Forms.Label();
            fiscalYearLabel = new System.Windows.Forms.Label();
            remarkLabel = new System.Windows.Forms.Label();
            disposaldateLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.panelControl1)).BeginInit();
            this.panelControl1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.disposaldateDateEdit.Properties.VistaTimeProperties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.disposaldateDateEdit.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.disposalBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.documentDateDateEdit.Properties.VistaTimeProperties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.documentDateDateEdit.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.disposalTypeLookUpEdit.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.disposalTypeBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.disposalErrorProvider)).BeginInit();
            this.SuspendLayout();
            // 
            // disposalTypeLabel
            // 
            disposalTypeLabel.AutoSize = true;
            disposalTypeLabel.Location = new System.Drawing.Point(12, 18);
            disposalTypeLabel.Name = "disposalTypeLabel";
            disposalTypeLabel.Size = new System.Drawing.Size(77, 13);
            disposalTypeLabel.TabIndex = 2;
            disposalTypeLabel.Text = "Disposal Type:";
            // 
            // amountLabel
            // 
            amountLabel.AutoSize = true;
            amountLabel.Location = new System.Drawing.Point(247, 18);
            amountLabel.Name = "amountLabel";
            amountLabel.Size = new System.Drawing.Size(71, 13);
            amountLabel.TabIndex = 4;
            amountLabel.Text = "Amount Sold:";
            // 
            // documentNumberLabel
            // 
            documentNumberLabel.AutoSize = true;
            documentNumberLabel.Location = new System.Drawing.Point(12, 44);
            documentNumberLabel.Name = "documentNumberLabel";
            documentNumberLabel.Size = new System.Drawing.Size(70, 13);
            documentNumberLabel.TabIndex = 6;
            documentNumberLabel.Text = "Document #:";
            // 
            // documentDateLabel
            // 
            documentDateLabel.AutoSize = true;
            documentDateLabel.Location = new System.Drawing.Point(247, 45);
            documentDateLabel.Name = "documentDateLabel";
            documentDateLabel.Size = new System.Drawing.Size(85, 13);
            documentDateLabel.TabIndex = 8;
            documentDateLabel.Text = "Document Date:";
            // 
            // fiscalYearLabel
            // 
            fiscalYearLabel.AutoSize = true;
            fiscalYearLabel.Location = new System.Drawing.Point(12, 71);
            fiscalYearLabel.Name = "fiscalYearLabel";
            fiscalYearLabel.Size = new System.Drawing.Size(62, 13);
            fiscalYearLabel.TabIndex = 10;
            fiscalYearLabel.Text = "Fiscal Year:";
            // 
            // remarkLabel
            // 
            remarkLabel.AutoSize = true;
            remarkLabel.Location = new System.Drawing.Point(12, 98);
            remarkLabel.Name = "remarkLabel";
            remarkLabel.Size = new System.Drawing.Size(47, 13);
            remarkLabel.TabIndex = 12;
            remarkLabel.Text = "Remark:";
            // 
            // disposaldateLabel
            // 
            disposaldateLabel.AutoSize = true;
            disposaldateLabel.Location = new System.Drawing.Point(247, 71);
            disposaldateLabel.Name = "disposaldateLabel";
            disposaldateLabel.Size = new System.Drawing.Size(80, 13);
            disposaldateLabel.TabIndex = 14;
            disposaldateLabel.Text = "Disposed Date:";
            // 
            // panelControl1
            // 
            this.panelControl1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panelControl1.Controls.Add(disposaldateLabel);
            this.panelControl1.Controls.Add(this.disposaldateDateEdit);
            this.panelControl1.Controls.Add(remarkLabel);
            this.panelControl1.Controls.Add(this.remarkTextBox);
            this.panelControl1.Controls.Add(fiscalYearLabel);
            this.panelControl1.Controls.Add(this.fiscalYearTextBox);
            this.panelControl1.Controls.Add(documentDateLabel);
            this.panelControl1.Controls.Add(this.documentDateDateEdit);
            this.panelControl1.Controls.Add(documentNumberLabel);
            this.panelControl1.Controls.Add(this.documentNumberTextBox);
            this.panelControl1.Controls.Add(amountLabel);
            this.panelControl1.Controls.Add(this.amountTextBox);
            this.panelControl1.Controls.Add(disposalTypeLabel);
            this.panelControl1.Controls.Add(this.disposalTypeLookUpEdit);
            this.panelControl1.Location = new System.Drawing.Point(12, 10);
            this.panelControl1.Name = "panelControl1";
            this.panelControl1.Size = new System.Drawing.Size(483, 186);
            this.panelControl1.TabIndex = 1;
            // 
            // disposaldateDateEdit
            // 
            this.disposaldateDateEdit.DataBindings.Add(new System.Windows.Forms.Binding("EditValue", this.disposalBindingSource, "Disposaldate", true));
            this.disposaldateDateEdit.EditValue = null;
            this.disposaldateDateEdit.Location = new System.Drawing.Point(340, 68);
            this.disposaldateDateEdit.Name = "disposaldateDateEdit";
            this.disposaldateDateEdit.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.disposaldateDateEdit.Properties.VistaTimeProperties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton()});
            this.disposaldateDateEdit.Size = new System.Drawing.Size(137, 20);
            this.disposaldateDateEdit.TabIndex = 15;
            // 
            // disposalBindingSource
            // 
            this.disposalBindingSource.DataSource = typeof(ClearOffice.FixedAsset.DataAccess.Disposal);
            // 
            // remarkTextBox
            // 
            this.remarkTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.disposalBindingSource, "Remark", true));
            this.remarkTextBox.Location = new System.Drawing.Point(95, 95);
            this.remarkTextBox.Multiline = true;
            this.remarkTextBox.Name = "remarkTextBox";
            this.remarkTextBox.Size = new System.Drawing.Size(382, 80);
            this.remarkTextBox.TabIndex = 13;
            // 
            // fiscalYearTextBox
            // 
            this.fiscalYearTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.disposalBindingSource, "FiscalYear", true));
            this.fiscalYearTextBox.Location = new System.Drawing.Point(95, 68);
            this.fiscalYearTextBox.Name = "fiscalYearTextBox";
            this.fiscalYearTextBox.Size = new System.Drawing.Size(137, 21);
            this.fiscalYearTextBox.TabIndex = 11;
            // 
            // documentDateDateEdit
            // 
            this.documentDateDateEdit.DataBindings.Add(new System.Windows.Forms.Binding("EditValue", this.disposalBindingSource, "DocumentDate", true));
            this.documentDateDateEdit.EditValue = null;
            this.documentDateDateEdit.Location = new System.Drawing.Point(340, 42);
            this.documentDateDateEdit.Name = "documentDateDateEdit";
            this.documentDateDateEdit.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.documentDateDateEdit.Properties.VistaTimeProperties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton()});
            this.documentDateDateEdit.Size = new System.Drawing.Size(137, 20);
            this.documentDateDateEdit.TabIndex = 9;
            // 
            // documentNumberTextBox
            // 
            this.documentNumberTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.disposalBindingSource, "DocumentNumber", true));
            this.documentNumberTextBox.Location = new System.Drawing.Point(95, 41);
            this.documentNumberTextBox.Name = "documentNumberTextBox";
            this.documentNumberTextBox.Size = new System.Drawing.Size(137, 21);
            this.documentNumberTextBox.TabIndex = 7;
            // 
            // amountTextBox
            // 
            this.amountTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.disposalBindingSource, "Amount", true));
            this.amountTextBox.Location = new System.Drawing.Point(340, 15);
            this.amountTextBox.Name = "amountTextBox";
            this.amountTextBox.Size = new System.Drawing.Size(137, 21);
            this.amountTextBox.TabIndex = 5;
            // 
            // disposalTypeLookUpEdit
            // 
            this.disposalTypeLookUpEdit.DataBindings.Add(new System.Windows.Forms.Binding("EditValue", this.disposalBindingSource, "DisposalType", true));
            this.disposalTypeLookUpEdit.Location = new System.Drawing.Point(95, 15);
            this.disposalTypeLookUpEdit.Name = "disposalTypeLookUpEdit";
            this.disposalTypeLookUpEdit.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.disposalTypeLookUpEdit.Properties.Columns.AddRange(new DevExpress.XtraEditors.Controls.LookUpColumnInfo[] {
            new DevExpress.XtraEditors.Controls.LookUpColumnInfo("ItemName", "Disposal Type", 62, DevExpress.Utils.FormatType.None, "", true, DevExpress.Utils.HorzAlignment.Near)});
            this.disposalTypeLookUpEdit.Properties.DataSource = this.disposalTypeBindingSource;
            this.disposalTypeLookUpEdit.Properties.DisplayMember = "ItemName";
            this.disposalTypeLookUpEdit.Properties.NullText = "[Select Disposal Type]";
            this.disposalTypeLookUpEdit.Properties.ValueMember = "LookupItemId";
            this.disposalTypeLookUpEdit.Size = new System.Drawing.Size(137, 20);
            this.disposalTypeLookUpEdit.TabIndex = 3;
            this.disposalTypeLookUpEdit.EditValueChanged += new System.EventHandler(this.disposalTypeLookUpEdit_EditValueChanged);
            // 
            // disposalTypeBindingSource
            // 
            this.disposalTypeBindingSource.DataSource = typeof(ClearOffice.FixedAsset.DataAccess.LookupItem);
            // 
            // disposalErrorProvider
            // 
            this.disposalErrorProvider.ContainerControl = this;
            // 
            // btnSave
            // 
            this.btnSave.Enabled = false;
            this.btnSave.Location = new System.Drawing.Point(159, 204);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(75, 23);
            this.btnSave.TabIndex = 35;
            this.btnSave.Text = "Save";
            this.btnSave.Click += new System.EventHandler(this.saveToolStripButton_Click);
            // 
            // btnCancel
            // 
            this.btnCancel.Enabled = false;
            this.btnCancel.Location = new System.Drawing.Point(255, 204);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(75, 23);
            this.btnCancel.TabIndex = 36;
            this.btnCancel.Text = "Cancel";
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // AssetDisposal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(507, 232);
            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.btnSave);
            this.Controls.Add(this.panelControl1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "AssetDisposal";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Disposal";
            ((System.ComponentModel.ISupportInitialize)(this.panelControl1)).EndInit();
            this.panelControl1.ResumeLayout(false);
            this.panelControl1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.disposaldateDateEdit.Properties.VistaTimeProperties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.disposaldateDateEdit.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.disposalBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.documentDateDateEdit.Properties.VistaTimeProperties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.documentDateDateEdit.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.disposalTypeLookUpEdit.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.disposalTypeBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.disposalErrorProvider)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraEditors.PanelControl panelControl1;
        private System.Windows.Forms.BindingSource disposalBindingSource;
        private DevExpress.XtraEditors.DateEdit disposaldateDateEdit;
        private System.Windows.Forms.TextBox remarkTextBox;
        private System.Windows.Forms.TextBox fiscalYearTextBox;
        private DevExpress.XtraEditors.DateEdit documentDateDateEdit;
        private System.Windows.Forms.TextBox documentNumberTextBox;
        private System.Windows.Forms.TextBox amountTextBox;
        private DevExpress.XtraEditors.LookUpEdit disposalTypeLookUpEdit;
        private System.Windows.Forms.BindingSource disposalTypeBindingSource;
        private System.Windows.Forms.ErrorProvider disposalErrorProvider;
        private DevExpress.XtraEditors.SimpleButton btnCancel;
        private DevExpress.XtraEditors.SimpleButton btnSave;
    }
}