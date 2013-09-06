namespace ClearOffice.Wms.Views
{
    partial class InsuranceView
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
            System.Windows.Forms.Label policyNumberLabel;
            System.Windows.Forms.Label startDateLabel;
            System.Windows.Forms.Label endDateLabel;
            System.Windows.Forms.Label paymentLabel;
            System.Windows.Forms.Label deductableLabel;
            System.Windows.Forms.Label remarkLabel;
            System.Windows.Forms.Label companyIdLabel;
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(InsuranceView));
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.saveToolStripButton = new System.Windows.Forms.ToolStripButton();
            this.panelControl1 = new DevExpress.XtraEditors.PanelControl();
            this.companyIdLookUpEdit = new DevExpress.XtraEditors.LookUpEdit();
            this.InsuranceBindingSource = new System.Windows.Forms.BindingSource();
            this.CompaniesBindingSource = new System.Windows.Forms.BindingSource();
            this.remarkTextBox = new System.Windows.Forms.TextBox();
            this.deductableTextBox = new System.Windows.Forms.TextBox();
            this.paymentTextBox = new System.Windows.Forms.TextBox();
            this.endDateDateEdit = new DevExpress.XtraEditors.DateEdit();
            this.startDateDateEdit = new DevExpress.XtraEditors.DateEdit();
            this.policyNumberTextBox = new System.Windows.Forms.TextBox();
            this.InsuranceErrorProvider = new System.Windows.Forms.ErrorProvider();
            policyNumberLabel = new System.Windows.Forms.Label();
            startDateLabel = new System.Windows.Forms.Label();
            endDateLabel = new System.Windows.Forms.Label();
            paymentLabel = new System.Windows.Forms.Label();
            deductableLabel = new System.Windows.Forms.Label();
            remarkLabel = new System.Windows.Forms.Label();
            companyIdLabel = new System.Windows.Forms.Label();
            this.toolStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.panelControl1)).BeginInit();
            this.panelControl1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.companyIdLookUpEdit.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.InsuranceBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.CompaniesBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.endDateDateEdit.Properties.VistaTimeProperties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.endDateDateEdit.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.startDateDateEdit.Properties.VistaTimeProperties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.startDateDateEdit.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.InsuranceErrorProvider)).BeginInit();
            this.SuspendLayout();
            // 
            // policyNumberLabel
            // 
            policyNumberLabel.AutoSize = true;
            policyNumberLabel.Location = new System.Drawing.Point(345, 21);
            policyNumberLabel.Name = "policyNumberLabel";
            policyNumberLabel.Size = new System.Drawing.Size(78, 13);
            policyNumberLabel.TabIndex = 2;
            policyNumberLabel.Text = "Policy Number:";
            // 
            // startDateLabel
            // 
            startDateLabel.AutoSize = true;
            startDateLabel.Location = new System.Drawing.Point(13, 51);
            startDateLabel.Name = "startDateLabel";
            startDateLabel.Size = new System.Drawing.Size(61, 13);
            startDateLabel.TabIndex = 4;
            startDateLabel.Text = "Start Date:";
            // 
            // endDateLabel
            // 
            endDateLabel.AutoSize = true;
            endDateLabel.Location = new System.Drawing.Point(345, 48);
            endDateLabel.Name = "endDateLabel";
            endDateLabel.Size = new System.Drawing.Size(55, 13);
            endDateLabel.TabIndex = 6;
            endDateLabel.Text = "End Date:";
            // 
            // paymentLabel
            // 
            paymentLabel.AutoSize = true;
            paymentLabel.Location = new System.Drawing.Point(13, 77);
            paymentLabel.Name = "paymentLabel";
            paymentLabel.Size = new System.Drawing.Size(53, 13);
            paymentLabel.TabIndex = 8;
            paymentLabel.Text = "Payment:";
            // 
            // deductableLabel
            // 
            deductableLabel.AutoSize = true;
            deductableLabel.Location = new System.Drawing.Point(345, 74);
            deductableLabel.Name = "deductableLabel";
            deductableLabel.Size = new System.Drawing.Size(61, 13);
            deductableLabel.TabIndex = 10;
            deductableLabel.Text = "Deductible:";
            // 
            // remarkLabel
            // 
            remarkLabel.AutoSize = true;
            remarkLabel.Location = new System.Drawing.Point(13, 104);
            remarkLabel.Name = "remarkLabel";
            remarkLabel.Size = new System.Drawing.Size(47, 13);
            remarkLabel.TabIndex = 12;
            remarkLabel.Text = "Remark:";
            // 
            // companyIdLabel
            // 
            companyIdLabel.AutoSize = true;
            companyIdLabel.Location = new System.Drawing.Point(13, 21);
            companyIdLabel.Name = "companyIdLabel";
            companyIdLabel.Size = new System.Drawing.Size(110, 13);
            companyIdLabel.TabIndex = 13;
            companyIdLabel.Text = "Insurance Company :";
            // 
            // toolStrip1
            // 
            this.toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.saveToolStripButton});
            this.toolStrip1.Location = new System.Drawing.Point(0, 0);
            this.toolStrip1.Name = "toolStrip1";
            this.toolStrip1.Size = new System.Drawing.Size(638, 25);
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
            this.panelControl1.Controls.Add(companyIdLabel);
            this.panelControl1.Controls.Add(this.companyIdLookUpEdit);
            this.panelControl1.Controls.Add(remarkLabel);
            this.panelControl1.Controls.Add(this.remarkTextBox);
            this.panelControl1.Controls.Add(deductableLabel);
            this.panelControl1.Controls.Add(this.deductableTextBox);
            this.panelControl1.Controls.Add(paymentLabel);
            this.panelControl1.Controls.Add(this.paymentTextBox);
            this.panelControl1.Controls.Add(endDateLabel);
            this.panelControl1.Controls.Add(this.endDateDateEdit);
            this.panelControl1.Controls.Add(startDateLabel);
            this.panelControl1.Controls.Add(this.startDateDateEdit);
            this.panelControl1.Controls.Add(policyNumberLabel);
            this.panelControl1.Controls.Add(this.policyNumberTextBox);
            this.panelControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelControl1.Location = new System.Drawing.Point(0, 25);
            this.panelControl1.Name = "panelControl1";
            this.panelControl1.Size = new System.Drawing.Size(638, 212);
            this.panelControl1.TabIndex = 1;
            // 
            // companyIdLookUpEdit
            // 
            this.companyIdLookUpEdit.DataBindings.Add(new System.Windows.Forms.Binding("EditValue", this.InsuranceBindingSource, "CompanyId", true));
            this.companyIdLookUpEdit.Location = new System.Drawing.Point(126, 18);
            this.companyIdLookUpEdit.Name = "companyIdLookUpEdit";
            this.companyIdLookUpEdit.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.companyIdLookUpEdit.Properties.Columns.AddRange(new DevExpress.XtraEditors.Controls.LookUpColumnInfo[] {
            new DevExpress.XtraEditors.Controls.LookUpColumnInfo("Name", "Name", 37, DevExpress.Utils.FormatType.None, "", true, DevExpress.Utils.HorzAlignment.Near)});
            this.companyIdLookUpEdit.Properties.DataSource = this.CompaniesBindingSource;
            this.companyIdLookUpEdit.Properties.DisplayMember = "Name";
            this.companyIdLookUpEdit.Properties.NullText = "[Select Insurance Company]";
            this.companyIdLookUpEdit.Properties.ValueMember = "ItemId";
            this.companyIdLookUpEdit.Size = new System.Drawing.Size(188, 20);
            this.companyIdLookUpEdit.TabIndex = 14;
            // 
            // InsuranceBindingSource
            // 
            this.InsuranceBindingSource.DataSource = typeof(ClearOffice.Wms.Business.EquipmentInsurance);
            // 
            // CompaniesBindingSource
            // 
            this.CompaniesBindingSource.DataSource = typeof(ClearOffice.Wms.Business.LookupItem);
            // 
            // remarkTextBox
            // 
            this.remarkTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.InsuranceBindingSource, "Remark", true));
            this.remarkTextBox.Location = new System.Drawing.Point(126, 98);
            this.remarkTextBox.Multiline = true;
            this.remarkTextBox.Name = "remarkTextBox";
            this.remarkTextBox.Size = new System.Drawing.Size(486, 83);
            this.remarkTextBox.TabIndex = 13;
            // 
            // deductableTextBox
            // 
            this.deductableTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.InsuranceBindingSource, "Deductable", true));
            this.deductableTextBox.Location = new System.Drawing.Point(424, 71);
            this.deductableTextBox.Name = "deductableTextBox";
            this.deductableTextBox.Size = new System.Drawing.Size(188, 21);
            this.deductableTextBox.TabIndex = 11;
            this.deductableTextBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // paymentTextBox
            // 
            this.paymentTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.InsuranceBindingSource, "Payment", true));
            this.paymentTextBox.Location = new System.Drawing.Point(126, 71);
            this.paymentTextBox.Name = "paymentTextBox";
            this.paymentTextBox.Size = new System.Drawing.Size(188, 21);
            this.paymentTextBox.TabIndex = 9;
            this.paymentTextBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // endDateDateEdit
            // 
            this.endDateDateEdit.DataBindings.Add(new System.Windows.Forms.Binding("EditValue", this.InsuranceBindingSource, "EndDate", true));
            this.endDateDateEdit.EditValue = null;
            this.endDateDateEdit.Location = new System.Drawing.Point(424, 45);
            this.endDateDateEdit.Name = "endDateDateEdit";
            this.endDateDateEdit.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.endDateDateEdit.Properties.VistaTimeProperties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton()});
            this.endDateDateEdit.Size = new System.Drawing.Size(188, 20);
            this.endDateDateEdit.TabIndex = 7;
            // 
            // startDateDateEdit
            // 
            this.startDateDateEdit.DataBindings.Add(new System.Windows.Forms.Binding("EditValue", this.InsuranceBindingSource, "StartDate", true));
            this.startDateDateEdit.EditValue = null;
            this.startDateDateEdit.Location = new System.Drawing.Point(126, 45);
            this.startDateDateEdit.Name = "startDateDateEdit";
            this.startDateDateEdit.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.startDateDateEdit.Properties.VistaTimeProperties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton()});
            this.startDateDateEdit.Size = new System.Drawing.Size(188, 20);
            this.startDateDateEdit.TabIndex = 5;
            // 
            // policyNumberTextBox
            // 
            this.policyNumberTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.InsuranceBindingSource, "PolicyNumber", true));
            this.policyNumberTextBox.Location = new System.Drawing.Point(424, 18);
            this.policyNumberTextBox.Name = "policyNumberTextBox";
            this.policyNumberTextBox.Size = new System.Drawing.Size(188, 21);
            this.policyNumberTextBox.TabIndex = 3;
            // 
            // InsuranceErrorProvider
            // 
            this.InsuranceErrorProvider.ContainerControl = this;
            // 
            // InsuranceView
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(638, 237);
            this.Controls.Add(this.panelControl1);
            this.Controls.Add(this.toolStrip1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "InsuranceView";
            this.Text = "Equipment Insurance";
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.panelControl1)).EndInit();
            this.panelControl1.ResumeLayout(false);
            this.panelControl1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.companyIdLookUpEdit.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.InsuranceBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.CompaniesBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.endDateDateEdit.Properties.VistaTimeProperties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.endDateDateEdit.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.startDateDateEdit.Properties.VistaTimeProperties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.startDateDateEdit.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.InsuranceErrorProvider)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ToolStrip toolStrip1;
        private System.Windows.Forms.ToolStripButton saveToolStripButton;
        private DevExpress.XtraEditors.PanelControl panelControl1;
        private System.Windows.Forms.TextBox remarkTextBox;
        private System.Windows.Forms.BindingSource InsuranceBindingSource;
        private System.Windows.Forms.TextBox deductableTextBox;
        private System.Windows.Forms.TextBox paymentTextBox;
        private DevExpress.XtraEditors.DateEdit endDateDateEdit;
        private DevExpress.XtraEditors.DateEdit startDateDateEdit;
        private System.Windows.Forms.TextBox policyNumberTextBox;
        private DevExpress.XtraEditors.LookUpEdit companyIdLookUpEdit;
        private System.Windows.Forms.BindingSource CompaniesBindingSource;
        private System.Windows.Forms.ErrorProvider InsuranceErrorProvider;
    }
}