namespace ClearOffice.Wms.Views
{
    partial class ContractRenewView
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
            System.Windows.Forms.Label startDateLabel;
            System.Windows.Forms.Label durationLabel;
            System.Windows.Forms.Label paymentTermsLabel;
            System.Windows.Forms.Label amountLabel;
            System.Windows.Forms.Label descriptionLabel;
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ContractRenewView));
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.saveToolStripButton = new System.Windows.Forms.ToolStripButton();
            this.panelControl1 = new DevExpress.XtraEditors.PanelControl();
            this.descriptionTextBox = new System.Windows.Forms.TextBox();
            this.RenewalBindingSource = new System.Windows.Forms.BindingSource();
            this.amountTextBox = new System.Windows.Forms.TextBox();
            this.paymentTermsLookUpEdit = new DevExpress.XtraEditors.LookUpEdit();
            this.PaymentTypeBindingSource = new System.Windows.Forms.BindingSource();
            this.CmbDuration = new System.Windows.Forms.ComboBox();
            this.DurationTypesBindingSource = new System.Windows.Forms.BindingSource();
            this.durationTextBox = new System.Windows.Forms.TextBox();
            this.startDateDateEdit = new DevExpress.XtraEditors.DateEdit();
            this.RenewErrorProvider = new System.Windows.Forms.ErrorProvider();
            startDateLabel = new System.Windows.Forms.Label();
            durationLabel = new System.Windows.Forms.Label();
            paymentTermsLabel = new System.Windows.Forms.Label();
            amountLabel = new System.Windows.Forms.Label();
            descriptionLabel = new System.Windows.Forms.Label();
            this.toolStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.panelControl1)).BeginInit();
            this.panelControl1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.RenewalBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.paymentTermsLookUpEdit.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.PaymentTypeBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.DurationTypesBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.startDateDateEdit.Properties.VistaTimeProperties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.startDateDateEdit.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.RenewErrorProvider)).BeginInit();
            this.SuspendLayout();
            // 
            // startDateLabel
            // 
            startDateLabel.AutoSize = true;
            startDateLabel.Location = new System.Drawing.Point(31, 11);
            startDateLabel.Name = "startDateLabel";
            startDateLabel.Size = new System.Drawing.Size(61, 13);
            startDateLabel.TabIndex = 0;
            startDateLabel.Text = "Start Date:";
            // 
            // durationLabel
            // 
            durationLabel.AutoSize = true;
            durationLabel.Location = new System.Drawing.Point(297, 11);
            durationLabel.Name = "durationLabel";
            durationLabel.Size = new System.Drawing.Size(52, 13);
            durationLabel.TabIndex = 2;
            durationLabel.Text = "Duration:";
            // 
            // paymentTermsLabel
            // 
            paymentTermsLabel.AutoSize = true;
            paymentTermsLabel.Location = new System.Drawing.Point(31, 37);
            paymentTermsLabel.Name = "paymentTermsLabel";
            paymentTermsLabel.Size = new System.Drawing.Size(85, 13);
            paymentTermsLabel.TabIndex = 5;
            paymentTermsLabel.Text = "Payment Terms:";
            // 
            // amountLabel
            // 
            amountLabel.AutoSize = true;
            amountLabel.Location = new System.Drawing.Point(297, 38);
            amountLabel.Name = "amountLabel";
            amountLabel.Size = new System.Drawing.Size(48, 13);
            amountLabel.TabIndex = 7;
            amountLabel.Text = "Amount:";
            // 
            // descriptionLabel
            // 
            descriptionLabel.AutoSize = true;
            descriptionLabel.Location = new System.Drawing.Point(31, 63);
            descriptionLabel.Name = "descriptionLabel";
            descriptionLabel.Size = new System.Drawing.Size(64, 13);
            descriptionLabel.TabIndex = 9;
            descriptionLabel.Text = "Description:";
            // 
            // toolStrip1
            // 
            this.toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.saveToolStripButton});
            this.toolStrip1.Location = new System.Drawing.Point(0, 0);
            this.toolStrip1.Name = "toolStrip1";
            this.toolStrip1.Size = new System.Drawing.Size(537, 25);
            this.toolStrip1.TabIndex = 0;
            this.toolStrip1.Text = "toolStrip1";
            // 
            // saveToolStripButton
            // 
            this.saveToolStripButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.saveToolStripButton.Image = ((System.Drawing.Image)(resources.GetObject("saveToolStripButton.Image")));
            this.saveToolStripButton.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.saveToolStripButton.Name = "saveToolStripButton";
            this.saveToolStripButton.Size = new System.Drawing.Size(23, 22);
            this.saveToolStripButton.Text = "&Save";
            this.saveToolStripButton.Click += new System.EventHandler(this.saveToolStripButton_Click);
            // 
            // panelControl1
            // 
            this.panelControl1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panelControl1.Controls.Add(descriptionLabel);
            this.panelControl1.Controls.Add(this.descriptionTextBox);
            this.panelControl1.Controls.Add(amountLabel);
            this.panelControl1.Controls.Add(this.amountTextBox);
            this.panelControl1.Controls.Add(paymentTermsLabel);
            this.panelControl1.Controls.Add(this.paymentTermsLookUpEdit);
            this.panelControl1.Controls.Add(this.CmbDuration);
            this.panelControl1.Controls.Add(durationLabel);
            this.panelControl1.Controls.Add(this.durationTextBox);
            this.panelControl1.Controls.Add(startDateLabel);
            this.panelControl1.Controls.Add(this.startDateDateEdit);
            this.panelControl1.Location = new System.Drawing.Point(0, 28);
            this.panelControl1.Name = "panelControl1";
            this.panelControl1.Size = new System.Drawing.Size(537, 143);
            this.panelControl1.TabIndex = 2;
            // 
            // descriptionTextBox
            // 
            this.descriptionTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.RenewalBindingSource, "Description", true));
            this.descriptionTextBox.Location = new System.Drawing.Point(118, 60);
            this.descriptionTextBox.Multiline = true;
            this.descriptionTextBox.Name = "descriptionTextBox";
            this.descriptionTextBox.Size = new System.Drawing.Size(399, 64);
            this.descriptionTextBox.TabIndex = 10;
            // 
            // RenewalBindingSource
            // 
            this.RenewalBindingSource.DataSource = typeof(ClearOffice.Wms.Business.ContractRenewal);
            // 
            // amountTextBox
            // 
            this.amountTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.RenewalBindingSource, "Amount", true));
            this.amountTextBox.Location = new System.Drawing.Point(355, 35);
            this.amountTextBox.Name = "amountTextBox";
            this.amountTextBox.Size = new System.Drawing.Size(162, 21);
            this.amountTextBox.TabIndex = 8;
            this.amountTextBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // paymentTermsLookUpEdit
            // 
            this.paymentTermsLookUpEdit.DataBindings.Add(new System.Windows.Forms.Binding("EditValue", this.RenewalBindingSource, "PaymentTerms", true));
            this.paymentTermsLookUpEdit.Location = new System.Drawing.Point(118, 34);
            this.paymentTermsLookUpEdit.Name = "paymentTermsLookUpEdit";
            this.paymentTermsLookUpEdit.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.paymentTermsLookUpEdit.Properties.Columns.AddRange(new DevExpress.XtraEditors.Controls.LookUpColumnInfo[] {
            new DevExpress.XtraEditors.Controls.LookUpColumnInfo("Name", "Name", 37, DevExpress.Utils.FormatType.None, "", true, DevExpress.Utils.HorzAlignment.Near)});
            this.paymentTermsLookUpEdit.Properties.DataSource = this.PaymentTypeBindingSource;
            this.paymentTermsLookUpEdit.Properties.DisplayMember = "Name";
            this.paymentTermsLookUpEdit.Properties.NullText = "[Select Payment Term]";
            this.paymentTermsLookUpEdit.Properties.ValueMember = "ItemId";
            this.paymentTermsLookUpEdit.Size = new System.Drawing.Size(162, 20);
            this.paymentTermsLookUpEdit.TabIndex = 6;
            // 
            // PaymentTypeBindingSource
            // 
            this.PaymentTypeBindingSource.DataSource = typeof(ClearOffice.Wms.Business.LookupItem);
            // 
            // CmbDuration
            // 
            this.CmbDuration.DataSource = this.DurationTypesBindingSource;
            this.CmbDuration.DisplayMember = "Name";
            this.CmbDuration.FormattingEnabled = true;
            this.CmbDuration.Location = new System.Drawing.Point(458, 8);
            this.CmbDuration.Name = "CmbDuration";
            this.CmbDuration.Size = new System.Drawing.Size(59, 21);
            this.CmbDuration.TabIndex = 4;
            this.CmbDuration.ValueMember = "value";
            // 
            // DurationTypesBindingSource
            // 
            this.DurationTypesBindingSource.DataSource = typeof(ClearOffice.Wms.Views.DurationType);
            // 
            // durationTextBox
            // 
            this.durationTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.RenewalBindingSource, "Duration", true));
            this.durationTextBox.Location = new System.Drawing.Point(355, 8);
            this.durationTextBox.Name = "durationTextBox";
            this.durationTextBox.Size = new System.Drawing.Size(97, 21);
            this.durationTextBox.TabIndex = 3;
            this.durationTextBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // startDateDateEdit
            // 
            this.startDateDateEdit.DataBindings.Add(new System.Windows.Forms.Binding("EditValue", this.RenewalBindingSource, "StartDate", true));
            this.startDateDateEdit.EditValue = null;
            this.startDateDateEdit.Location = new System.Drawing.Point(118, 8);
            this.startDateDateEdit.Name = "startDateDateEdit";
            this.startDateDateEdit.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.startDateDateEdit.Properties.VistaTimeProperties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton()});
            this.startDateDateEdit.Size = new System.Drawing.Size(162, 20);
            this.startDateDateEdit.TabIndex = 1;
            // 
            // RenewErrorProvider
            // 
            this.RenewErrorProvider.ContainerControl = this;
            // 
            // ContractRenewView
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(537, 172);
            this.Controls.Add(this.panelControl1);
            this.Controls.Add(this.toolStrip1);
            this.Name = "ContractRenewView";
            this.Text = "Renew Contract";
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.panelControl1)).EndInit();
            this.panelControl1.ResumeLayout(false);
            this.panelControl1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.RenewalBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.paymentTermsLookUpEdit.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.PaymentTypeBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.DurationTypesBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.startDateDateEdit.Properties.VistaTimeProperties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.startDateDateEdit.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.RenewErrorProvider)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ToolStrip toolStrip1;
        private DevExpress.XtraEditors.PanelControl panelControl1;
        private System.Windows.Forms.BindingSource RenewalBindingSource;
        private System.Windows.Forms.ToolStripButton saveToolStripButton;
        private DevExpress.XtraEditors.LookUpEdit paymentTermsLookUpEdit;
        private System.Windows.Forms.ComboBox CmbDuration;
        private System.Windows.Forms.TextBox durationTextBox;
        private DevExpress.XtraEditors.DateEdit startDateDateEdit;
        private System.Windows.Forms.TextBox descriptionTextBox;
        private System.Windows.Forms.TextBox amountTextBox;
        private System.Windows.Forms.ErrorProvider RenewErrorProvider;
        private System.Windows.Forms.BindingSource DurationTypesBindingSource;
        private System.Windows.Forms.BindingSource PaymentTypeBindingSource;
    }
}