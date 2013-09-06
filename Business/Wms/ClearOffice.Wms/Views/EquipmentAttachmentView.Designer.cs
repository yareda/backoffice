namespace ClearOffice.Wms.Views
{
    partial class EquipmentAttachmentView
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
            System.Windows.Forms.Label discriptionLabel;
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(EquipmentAttachmentView));
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.saveToolStripButton = new System.Windows.Forms.ToolStripButton();
            this.panelControl1 = new DevExpress.XtraEditors.PanelControl();
            this.discriptionTextBox = new System.Windows.Forms.TextBox();
            this.attachmentBindingSource = new System.Windows.Forms.BindingSource();
            this.label1 = new System.Windows.Forms.Label();
            this.txtAtachment = new System.Windows.Forms.TextBox();
            this.btnSelect = new System.Windows.Forms.Button();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.attachmentErrorProvider = new System.Windows.Forms.ErrorProvider();
            discriptionLabel = new System.Windows.Forms.Label();
            this.toolStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.panelControl1)).BeginInit();
            this.panelControl1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.attachmentBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.attachmentErrorProvider)).BeginInit();
            this.SuspendLayout();
            // 
            // discriptionLabel
            // 
            discriptionLabel.AutoSize = true;
            discriptionLabel.Location = new System.Drawing.Point(8, 37);
            discriptionLabel.Name = "discriptionLabel";
            discriptionLabel.Size = new System.Drawing.Size(64, 13);
            discriptionLabel.TabIndex = 3;
            discriptionLabel.Text = "Description:";
            // 
            // toolStrip1
            // 
            this.toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.saveToolStripButton});
            this.toolStrip1.Location = new System.Drawing.Point(0, 0);
            this.toolStrip1.Name = "toolStrip1";
            this.toolStrip1.Size = new System.Drawing.Size(451, 25);
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
            this.panelControl1.Controls.Add(discriptionLabel);
            this.panelControl1.Controls.Add(this.discriptionTextBox);
            this.panelControl1.Controls.Add(this.label1);
            this.panelControl1.Controls.Add(this.txtAtachment);
            this.panelControl1.Controls.Add(this.btnSelect);
            this.panelControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelControl1.Location = new System.Drawing.Point(0, 25);
            this.panelControl1.Name = "panelControl1";
            this.panelControl1.Size = new System.Drawing.Size(451, 142);
            this.panelControl1.TabIndex = 1;
            // 
            // discriptionTextBox
            // 
            this.discriptionTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.attachmentBindingSource, "Description", true));
            this.discriptionTextBox.Location = new System.Drawing.Point(74, 34);
            this.discriptionTextBox.Multiline = true;
            this.discriptionTextBox.Name = "discriptionTextBox";
            this.discriptionTextBox.Size = new System.Drawing.Size(341, 84);
            this.discriptionTextBox.TabIndex = 4;
            // 
            // attachmentBindingSource
            // 
            this.attachmentBindingSource.DataSource = typeof(ClearOffice.Wms.Business.EquipmentAttachment);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(5, 10);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(63, 13);
            this.label1.TabIndex = 2;
            this.label1.Text = "Attachment";
            // 
            // txtAtachment
            // 
            this.txtAtachment.Enabled = false;
            this.txtAtachment.Location = new System.Drawing.Point(74, 7);
            this.txtAtachment.Name = "txtAtachment";
            this.txtAtachment.Size = new System.Drawing.Size(242, 21);
            this.txtAtachment.TabIndex = 1;
            // 
            // btnSelect
            // 
            this.btnSelect.Image = global::ClearOffice.Wms.Properties.Resources.folder_explore;
            this.btnSelect.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnSelect.Location = new System.Drawing.Point(322, 5);
            this.btnSelect.Name = "btnSelect";
            this.btnSelect.Size = new System.Drawing.Size(93, 23);
            this.btnSelect.TabIndex = 0;
            this.btnSelect.Text = "Select...";
            this.btnSelect.UseVisualStyleBackColor = true;
            this.btnSelect.Click += new System.EventHandler(this.btnSelect_Click);
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            // 
            // attachmentErrorProvider
            // 
            this.attachmentErrorProvider.ContainerControl = this;
            // 
            // EquipmentAttachmentView
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(451, 167);
            this.Controls.Add(this.panelControl1);
            this.Controls.Add(this.toolStrip1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "EquipmentAttachmentView";
            this.Text = "Attachment";
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.panelControl1)).EndInit();
            this.panelControl1.ResumeLayout(false);
            this.panelControl1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.attachmentBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.attachmentErrorProvider)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ToolStrip toolStrip1;
        private System.Windows.Forms.ToolStripButton saveToolStripButton;
        private DevExpress.XtraEditors.PanelControl panelControl1;
        private System.Windows.Forms.Button btnSelect;
        private System.Windows.Forms.BindingSource attachmentBindingSource;
        private System.Windows.Forms.TextBox discriptionTextBox;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtAtachment;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
        private System.Windows.Forms.ErrorProvider attachmentErrorProvider;
    }
}