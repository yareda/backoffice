namespace ClearOffice.Wms.Views
{
    partial class MaintainceLabourView
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
            System.Windows.Forms.Label performerIdLabel;
            System.Windows.Forms.Label performedByLabel;
            System.Windows.Forms.Label costLabel;
            System.Windows.Forms.Label hourLabel;
            System.Windows.Forms.Label labourRateLabel;
            System.Windows.Forms.Label descriptionLabel;
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MaintainceLabourView));
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.saveToolStripButton = new System.Windows.Forms.ToolStripButton();
            this.panelControl1 = new DevExpress.XtraEditors.PanelControl();
            this.descriptionTextBox = new System.Windows.Forms.TextBox();
            this.labourBindingSource = new System.Windows.Forms.BindingSource();
            this.performerLookUpEdit = new DevExpress.XtraEditors.LookUpEdit();
            this.performedByRadioGroup = new DevExpress.XtraEditors.RadioGroup();
            this.totalCostTextBox = new System.Windows.Forms.TextBox();
            this.hourTextBox = new System.Windows.Forms.TextBox();
            this.labourRateTextBox = new System.Windows.Forms.TextBox();
            this.labourErrorProvider = new System.Windows.Forms.ErrorProvider();
            performerIdLabel = new System.Windows.Forms.Label();
            performedByLabel = new System.Windows.Forms.Label();
            costLabel = new System.Windows.Forms.Label();
            hourLabel = new System.Windows.Forms.Label();
            labourRateLabel = new System.Windows.Forms.Label();
            descriptionLabel = new System.Windows.Forms.Label();
            this.toolStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.panelControl1)).BeginInit();
            this.panelControl1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.labourBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.performerLookUpEdit.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.performedByRadioGroup.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.labourErrorProvider)).BeginInit();
            this.SuspendLayout();
            // 
            // performerIdLabel
            // 
            performerIdLabel.AutoSize = true;
            performerIdLabel.Location = new System.Drawing.Point(14, 35);
            performerIdLabel.Name = "performerIdLabel";
            performerIdLabel.Size = new System.Drawing.Size(61, 13);
            performerIdLabel.TabIndex = 34;
            performerIdLabel.Text = "Technician:";
            // 
            // performedByLabel
            // 
            performedByLabel.AutoSize = true;
            performedByLabel.Location = new System.Drawing.Point(14, 9);
            performedByLabel.Name = "performedByLabel";
            performedByLabel.Size = new System.Drawing.Size(76, 13);
            performedByLabel.TabIndex = 33;
            performedByLabel.Text = "Performed By:";
            // 
            // costLabel
            // 
            costLabel.AutoSize = true;
            costLabel.Location = new System.Drawing.Point(14, 113);
            costLabel.Name = "costLabel";
            costLabel.Size = new System.Drawing.Size(35, 13);
            costLabel.TabIndex = 31;
            costLabel.Text = "Total:";
            // 
            // hourLabel
            // 
            hourLabel.AutoSize = true;
            hourLabel.Location = new System.Drawing.Point(14, 87);
            hourLabel.Name = "hourLabel";
            hourLabel.Size = new System.Drawing.Size(34, 13);
            hourLabel.TabIndex = 29;
            hourLabel.Text = "Hour:";
            // 
            // labourRateLabel
            // 
            labourRateLabel.AutoSize = true;
            labourRateLabel.Location = new System.Drawing.Point(14, 61);
            labourRateLabel.Name = "labourRateLabel";
            labourRateLabel.Size = new System.Drawing.Size(70, 13);
            labourRateLabel.TabIndex = 27;
            labourRateLabel.Text = "Labour Rate:";
            // 
            // descriptionLabel
            // 
            descriptionLabel.AutoSize = true;
            descriptionLabel.Location = new System.Drawing.Point(14, 140);
            descriptionLabel.Name = "descriptionLabel";
            descriptionLabel.Size = new System.Drawing.Size(64, 13);
            descriptionLabel.TabIndex = 38;
            descriptionLabel.Text = "Description:";
            // 
            // toolStrip1
            // 
            this.toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.saveToolStripButton});
            this.toolStrip1.Location = new System.Drawing.Point(0, 0);
            this.toolStrip1.Name = "toolStrip1";
            this.toolStrip1.Size = new System.Drawing.Size(553, 25);
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
            this.panelControl1.Controls.Add(descriptionLabel);
            this.panelControl1.Controls.Add(this.descriptionTextBox);
            this.panelControl1.Controls.Add(performerIdLabel);
            this.panelControl1.Controls.Add(this.performerLookUpEdit);
            this.panelControl1.Controls.Add(performedByLabel);
            this.panelControl1.Controls.Add(this.performedByRadioGroup);
            this.panelControl1.Controls.Add(costLabel);
            this.panelControl1.Controls.Add(this.totalCostTextBox);
            this.panelControl1.Controls.Add(hourLabel);
            this.panelControl1.Controls.Add(this.hourTextBox);
            this.panelControl1.Controls.Add(labourRateLabel);
            this.panelControl1.Controls.Add(this.labourRateTextBox);
            this.panelControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelControl1.Location = new System.Drawing.Point(0, 25);
            this.panelControl1.Name = "panelControl1";
            this.panelControl1.Size = new System.Drawing.Size(553, 241);
            this.panelControl1.TabIndex = 1;
            // 
            // descriptionTextBox
            // 
            this.descriptionTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.labourBindingSource, "Description", true));
            this.descriptionTextBox.Location = new System.Drawing.Point(96, 137);
            this.descriptionTextBox.Multiline = true;
            this.descriptionTextBox.Name = "descriptionTextBox";
            this.descriptionTextBox.Size = new System.Drawing.Size(416, 73);
            this.descriptionTextBox.TabIndex = 37;
            // 
            // labourBindingSource
            // 
            this.labourBindingSource.DataSource = typeof(ClearOffice.Wms.Business.MaintenanceLabour);
            // 
            // performerLookUpEdit
            // 
            this.performerLookUpEdit.DataBindings.Add(new System.Windows.Forms.Binding("EditValue", this.labourBindingSource, "PerformerId", true));
            this.performerLookUpEdit.Location = new System.Drawing.Point(96, 32);
            this.performerLookUpEdit.Name = "performerLookUpEdit";
            this.performerLookUpEdit.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.performerLookUpEdit.Properties.NullText = "";
            this.performerLookUpEdit.Size = new System.Drawing.Size(279, 20);
            this.performerLookUpEdit.TabIndex = 1;
            // 
            // performedByRadioGroup
            // 
            this.performedByRadioGroup.CausesValidation = false;
            this.performedByRadioGroup.EditValue = 1;
            this.performedByRadioGroup.Location = new System.Drawing.Point(96, 5);
            this.performedByRadioGroup.Name = "performedByRadioGroup";
            this.performedByRadioGroup.Properties.Appearance.BackColor = System.Drawing.Color.Transparent;
            this.performedByRadioGroup.Properties.Appearance.Options.UseBackColor = true;
            this.performedByRadioGroup.Properties.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.NoBorder;
            this.performedByRadioGroup.Properties.Items.AddRange(new DevExpress.XtraEditors.Controls.RadioGroupItem[] {
            new DevExpress.XtraEditors.Controls.RadioGroupItem(1, "Employee"),
            new DevExpress.XtraEditors.Controls.RadioGroupItem(2, "Vendor")});
            this.performedByRadioGroup.Size = new System.Drawing.Size(172, 21);
            this.performedByRadioGroup.TabIndex = 0;
            this.performedByRadioGroup.EditValueChanged += new System.EventHandler(this.performedByRadioGroup_EditValueChanged);
            // 
            // totalCostTextBox
            // 
            this.totalCostTextBox.Enabled = false;
            this.totalCostTextBox.Location = new System.Drawing.Point(96, 110);
            this.totalCostTextBox.Name = "totalCostTextBox";
            this.totalCostTextBox.Size = new System.Drawing.Size(279, 21);
            this.totalCostTextBox.TabIndex = 5;
            // 
            // hourTextBox
            // 
            this.hourTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.labourBindingSource, "Hour", true));
            this.hourTextBox.Location = new System.Drawing.Point(96, 84);
            this.hourTextBox.Name = "hourTextBox";
            this.hourTextBox.Size = new System.Drawing.Size(279, 21);
            this.hourTextBox.TabIndex = 4;
            this.hourTextBox.TextChanged += new System.EventHandler(this.hourTextBox_TextChanged);
            // 
            // labourRateTextBox
            // 
            this.labourRateTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.labourBindingSource, "LabourRate", true));
            this.labourRateTextBox.Location = new System.Drawing.Point(96, 58);
            this.labourRateTextBox.Name = "labourRateTextBox";
            this.labourRateTextBox.Size = new System.Drawing.Size(279, 21);
            this.labourRateTextBox.TabIndex = 3;
            // 
            // labourErrorProvider
            // 
            this.labourErrorProvider.ContainerControl = this;
            // 
            // MaintainceLabourView
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(553, 266);
            this.Controls.Add(this.panelControl1);
            this.Controls.Add(this.toolStrip1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "MaintainceLabourView";
            this.Text = "Maintaince Labour";
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.panelControl1)).EndInit();
            this.panelControl1.ResumeLayout(false);
            this.panelControl1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.labourBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.performerLookUpEdit.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.performedByRadioGroup.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.labourErrorProvider)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ToolStrip toolStrip1;
        private System.Windows.Forms.ToolStripButton saveToolStripButton;
        private DevExpress.XtraEditors.PanelControl panelControl1;
        private DevExpress.XtraEditors.LookUpEdit performerLookUpEdit;
        private DevExpress.XtraEditors.RadioGroup performedByRadioGroup;
        private System.Windows.Forms.TextBox totalCostTextBox;
        private System.Windows.Forms.TextBox hourTextBox;
        private System.Windows.Forms.TextBox labourRateTextBox;
        private System.Windows.Forms.BindingSource labourBindingSource;
        private System.Windows.Forms.TextBox descriptionTextBox;
        private System.Windows.Forms.ErrorProvider labourErrorProvider;

    }
}