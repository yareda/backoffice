namespace ClearOffice.Wms.Views
{
    partial class MaintenacePartView
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
            System.Windows.Forms.Label partIdLabel;
            System.Windows.Forms.Label unitCostLabel;
            System.Windows.Forms.Label quantityLabel;
            System.Windows.Forms.Label descriptionLabel;
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MaintenacePartView));
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.BtnSave = new System.Windows.Forms.ToolStripButton();
            this.BtnDelete = new System.Windows.Forms.ToolStripButton();
            this.MaintaincePartBindingSource = new System.Windows.Forms.BindingSource();
            this.PartInfoBindingSource = new System.Windows.Forms.BindingSource();
            this.panelControl1 = new DevExpress.XtraEditors.PanelControl();
            this.descriptionTextBox = new System.Windows.Forms.TextBox();
            this.quantityTextBox = new System.Windows.Forms.TextBox();
            this.unitCostTextBox = new System.Windows.Forms.TextBox();
            this.partIdLookUpEdit = new DevExpress.XtraEditors.LookUpEdit();
            this.MaintaincePartErrorProvider = new System.Windows.Forms.ErrorProvider();
            partIdLabel = new System.Windows.Forms.Label();
            unitCostLabel = new System.Windows.Forms.Label();
            quantityLabel = new System.Windows.Forms.Label();
            descriptionLabel = new System.Windows.Forms.Label();
            this.toolStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.MaintaincePartBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.PartInfoBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.panelControl1)).BeginInit();
            this.panelControl1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.partIdLookUpEdit.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.MaintaincePartErrorProvider)).BeginInit();
            this.SuspendLayout();
            // 
            // partIdLabel
            // 
            partIdLabel.AutoSize = true;
            partIdLabel.Location = new System.Drawing.Point(25, 19);
            partIdLabel.Name = "partIdLabel";
            partIdLabel.Size = new System.Drawing.Size(31, 13);
            partIdLabel.TabIndex = 0;
            partIdLabel.Text = "Part:";
            // 
            // unitCostLabel
            // 
            unitCostLabel.AutoSize = true;
            unitCostLabel.Location = new System.Drawing.Point(25, 45);
            unitCostLabel.Name = "unitCostLabel";
            unitCostLabel.Size = new System.Drawing.Size(55, 13);
            unitCostLabel.TabIndex = 2;
            unitCostLabel.Text = "Unit Cost:";
            // 
            // quantityLabel
            // 
            quantityLabel.AutoSize = true;
            quantityLabel.Location = new System.Drawing.Point(25, 72);
            quantityLabel.Name = "quantityLabel";
            quantityLabel.Size = new System.Drawing.Size(53, 13);
            quantityLabel.TabIndex = 4;
            quantityLabel.Text = "Quantity:";
            // 
            // descriptionLabel
            // 
            descriptionLabel.AutoSize = true;
            descriptionLabel.Location = new System.Drawing.Point(25, 99);
            descriptionLabel.Name = "descriptionLabel";
            descriptionLabel.Size = new System.Drawing.Size(64, 13);
            descriptionLabel.TabIndex = 6;
            descriptionLabel.Text = "Description:";
            // 
            // toolStrip1
            // 
            this.toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.BtnSave,
            this.BtnDelete});
            this.toolStrip1.Location = new System.Drawing.Point(0, 0);
            this.toolStrip1.Name = "toolStrip1";
            this.toolStrip1.Size = new System.Drawing.Size(496, 25);
            this.toolStrip1.TabIndex = 0;
            this.toolStrip1.Text = "toolStrip1";
            // 
            // BtnSave
            // 
            this.BtnSave.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.BtnSave.Image = ((System.Drawing.Image)(resources.GetObject("BtnSave.Image")));
            this.BtnSave.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.BtnSave.Name = "BtnSave";
            this.BtnSave.Size = new System.Drawing.Size(23, 22);
            this.BtnSave.Text = "&Save";
            this.BtnSave.Click += new System.EventHandler(this.BtnSave_Click);
            // 
            // BtnDelete
            // 
            this.BtnDelete.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.BtnDelete.Enabled = false;
            this.BtnDelete.Image = global::ClearOffice.Wms.Properties.Resources.delete;
            this.BtnDelete.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.BtnDelete.Name = "BtnDelete";
            this.BtnDelete.Size = new System.Drawing.Size(23, 22);
            this.BtnDelete.Text = "toolStripButton1";
            this.BtnDelete.ToolTipText = "Delete";
            // 
            // MaintaincePartBindingSource
            // 
            this.MaintaincePartBindingSource.DataSource = typeof(ClearOffice.Wms.Business.MaintenancePart);
            // 
            // PartInfoBindingSource
            // 
            this.PartInfoBindingSource.DataSource = typeof(ClearOffice.Wms.Business.PartInfo);
            // 
            // panelControl1
            // 
            this.panelControl1.Controls.Add(descriptionLabel);
            this.panelControl1.Controls.Add(this.descriptionTextBox);
            this.panelControl1.Controls.Add(quantityLabel);
            this.panelControl1.Controls.Add(this.quantityTextBox);
            this.panelControl1.Controls.Add(unitCostLabel);
            this.panelControl1.Controls.Add(this.unitCostTextBox);
            this.panelControl1.Controls.Add(partIdLabel);
            this.panelControl1.Controls.Add(this.partIdLookUpEdit);
            this.panelControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelControl1.Location = new System.Drawing.Point(0, 25);
            this.panelControl1.Name = "panelControl1";
            this.panelControl1.Size = new System.Drawing.Size(496, 185);
            this.panelControl1.TabIndex = 1;
            // 
            // descriptionTextBox
            // 
            this.descriptionTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.MaintaincePartBindingSource, "Description", true));
            this.descriptionTextBox.Location = new System.Drawing.Point(95, 96);
            this.descriptionTextBox.Multiline = true;
            this.descriptionTextBox.Name = "descriptionTextBox";
            this.descriptionTextBox.Size = new System.Drawing.Size(386, 75);
            this.descriptionTextBox.TabIndex = 7;
            // 
            // quantityTextBox
            // 
            this.quantityTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.MaintaincePartBindingSource, "Quantity", true));
            this.quantityTextBox.Location = new System.Drawing.Point(95, 69);
            this.quantityTextBox.Name = "quantityTextBox";
            this.quantityTextBox.Size = new System.Drawing.Size(279, 21);
            this.quantityTextBox.TabIndex = 5;
            // 
            // unitCostTextBox
            // 
            this.unitCostTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.MaintaincePartBindingSource, "UnitCost", true));
            this.unitCostTextBox.Location = new System.Drawing.Point(95, 42);
            this.unitCostTextBox.Name = "unitCostTextBox";
            this.unitCostTextBox.Size = new System.Drawing.Size(279, 21);
            this.unitCostTextBox.TabIndex = 3;
            // 
            // partIdLookUpEdit
            // 
            this.partIdLookUpEdit.DataBindings.Add(new System.Windows.Forms.Binding("EditValue", this.MaintaincePartBindingSource, "PartId", true));
            this.partIdLookUpEdit.Location = new System.Drawing.Point(95, 16);
            this.partIdLookUpEdit.Name = "partIdLookUpEdit";
            this.partIdLookUpEdit.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.partIdLookUpEdit.Properties.Columns.AddRange(new DevExpress.XtraEditors.Controls.LookUpColumnInfo[] {
            new DevExpress.XtraEditors.Controls.LookUpColumnInfo("PartName", "Part Name", 60, DevExpress.Utils.FormatType.None, "", true, DevExpress.Utils.HorzAlignment.Near),
            new DevExpress.XtraEditors.Controls.LookUpColumnInfo("PartNo", "Part No", 46, DevExpress.Utils.FormatType.None, "", true, DevExpress.Utils.HorzAlignment.Near)});
            this.partIdLookUpEdit.Properties.DataSource = this.PartInfoBindingSource;
            this.partIdLookUpEdit.Properties.DisplayMember = "PartName";
            this.partIdLookUpEdit.Properties.NullText = "[Select Part]";
            this.partIdLookUpEdit.Properties.ValueMember = "PartId";
            this.partIdLookUpEdit.Size = new System.Drawing.Size(279, 20);
            this.partIdLookUpEdit.TabIndex = 1;
            this.partIdLookUpEdit.EditValueChanged += new System.EventHandler(this.partIdLookUpEdit_EditValueChanged);
            // 
            // MaintaincePartErrorProvider
            // 
            this.MaintaincePartErrorProvider.ContainerControl = this;
            // 
            // MaintenacePartView
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(496, 210);
            this.Controls.Add(this.panelControl1);
            this.Controls.Add(this.toolStrip1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "MaintenacePartView";
            this.Text = "MaintenacePartView";
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.MaintaincePartBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.PartInfoBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.panelControl1)).EndInit();
            this.panelControl1.ResumeLayout(false);
            this.panelControl1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.partIdLookUpEdit.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.MaintaincePartErrorProvider)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ToolStrip toolStrip1;
        private System.Windows.Forms.ToolStripButton BtnSave;
        private System.Windows.Forms.BindingSource MaintaincePartBindingSource;
        private System.Windows.Forms.ToolStripButton BtnDelete;
        private System.Windows.Forms.BindingSource PartInfoBindingSource;
        private DevExpress.XtraEditors.PanelControl panelControl1;
        private System.Windows.Forms.TextBox descriptionTextBox;
        private System.Windows.Forms.TextBox quantityTextBox;
        private System.Windows.Forms.TextBox unitCostTextBox;
        private DevExpress.XtraEditors.LookUpEdit partIdLookUpEdit;
        private System.Windows.Forms.ErrorProvider MaintaincePartErrorProvider;
    }
}