namespace ClearOffice.Hrm.Views
{
    partial class NodeEdit
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
            System.Windows.Forms.Label nodeNameLabel;
            System.Windows.Forms.Label nodeTypeIdLabel;
            System.Windows.Forms.Label parentIdLabel;
            System.Windows.Forms.Label descriptionLabel;
            this.nodeNameTextEdit = new DevExpress.XtraEditors.TextEdit();
            this.nodeTypeIdLookUpEdit = new DevExpress.XtraEditors.LookUpEdit();
            this.parentIdLookUpEdit = new DevExpress.XtraEditors.LookUpEdit();
            this.descriptionMemoEdit = new DevExpress.XtraEditors.MemoEdit();
            this.saveCommand = new DevExpress.XtraEditors.SimpleButton();
            this.cancelCommand = new DevExpress.XtraEditors.SimpleButton();
            this.errorProvider1 = new System.Windows.Forms.ErrorProvider();
            this.organizationBindingSource = new System.Windows.Forms.BindingSource();
            this.parentNodeBindingSource = new System.Windows.Forms.BindingSource();
            this.organizationTypeBindingSource = new System.Windows.Forms.BindingSource();
            nodeNameLabel = new System.Windows.Forms.Label();
            nodeTypeIdLabel = new System.Windows.Forms.Label();
            parentIdLabel = new System.Windows.Forms.Label();
            descriptionLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.nodeNameTextEdit.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nodeTypeIdLookUpEdit.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.parentIdLookUpEdit.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.descriptionMemoEdit.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.organizationBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.parentNodeBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.organizationTypeBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // nodeNameLabel
            // 
            nodeNameLabel.AutoSize = true;
            nodeNameLabel.Location = new System.Drawing.Point(11, 15);
            nodeNameLabel.Name = "nodeNameLabel";
            nodeNameLabel.Size = new System.Drawing.Size(60, 13);
            nodeNameLabel.TabIndex = 0;
            nodeNameLabel.Text = "Unit Name:";
            // 
            // nodeTypeIdLabel
            // 
            nodeTypeIdLabel.AutoSize = true;
            nodeTypeIdLabel.Location = new System.Drawing.Point(11, 67);
            nodeTypeIdLabel.Name = "nodeTypeIdLabel";
            nodeTypeIdLabel.Size = new System.Drawing.Size(57, 13);
            nodeTypeIdLabel.TabIndex = 2;
            nodeTypeIdLabel.Text = "Unit Type:";
            // 
            // parentIdLabel
            // 
            parentIdLabel.AutoSize = true;
            parentIdLabel.Location = new System.Drawing.Point(11, 41);
            parentIdLabel.Name = "parentIdLabel";
            parentIdLabel.Size = new System.Drawing.Size(65, 13);
            parentIdLabel.TabIndex = 4;
            parentIdLabel.Text = "Parent Unit:";
            // 
            // descriptionLabel
            // 
            descriptionLabel.AutoSize = true;
            descriptionLabel.Location = new System.Drawing.Point(11, 93);
            descriptionLabel.Name = "descriptionLabel";
            descriptionLabel.Size = new System.Drawing.Size(64, 13);
            descriptionLabel.TabIndex = 6;
            descriptionLabel.Text = "Description:";
            // 
            // nodeNameTextEdit
            // 
            this.nodeNameTextEdit.DataBindings.Add(new System.Windows.Forms.Binding("EditValue", this.organizationBindingSource, "NodeName", true));
            this.nodeNameTextEdit.Location = new System.Drawing.Point(82, 12);
            this.nodeNameTextEdit.Name = "nodeNameTextEdit";
            this.nodeNameTextEdit.Size = new System.Drawing.Size(258, 20);
            this.nodeNameTextEdit.TabIndex = 0;
            // 
            // nodeTypeIdLookUpEdit
            // 
            this.nodeTypeIdLookUpEdit.DataBindings.Add(new System.Windows.Forms.Binding("EditValue", this.organizationBindingSource, "NodeTypeId", true));
            this.nodeTypeIdLookUpEdit.Location = new System.Drawing.Point(82, 64);
            this.nodeTypeIdLookUpEdit.Name = "nodeTypeIdLookUpEdit";
            this.nodeTypeIdLookUpEdit.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.nodeTypeIdLookUpEdit.Properties.Columns.AddRange(new DevExpress.XtraEditors.Controls.LookUpColumnInfo[] {
            new DevExpress.XtraEditors.Controls.LookUpColumnInfo("NodeTypeName", "Unit Type", 92, DevExpress.Utils.FormatType.None, "", true, DevExpress.Utils.HorzAlignment.Near)});
            this.nodeTypeIdLookUpEdit.Properties.DataSource = this.organizationTypeBindingSource;
            this.nodeTypeIdLookUpEdit.Properties.DisplayMember = "NodeTypeName";
            this.nodeTypeIdLookUpEdit.Properties.NullText = "[Organization Unit Type]";
            this.nodeTypeIdLookUpEdit.Properties.ValueMember = "NodeTypeId";
            this.nodeTypeIdLookUpEdit.Size = new System.Drawing.Size(258, 20);
            this.nodeTypeIdLookUpEdit.TabIndex = 2;
            // 
            // parentIdLookUpEdit
            // 
            this.parentIdLookUpEdit.DataBindings.Add(new System.Windows.Forms.Binding("EditValue", this.organizationBindingSource, "ParentId", true));
            this.parentIdLookUpEdit.Location = new System.Drawing.Point(82, 38);
            this.parentIdLookUpEdit.Name = "parentIdLookUpEdit";
            this.parentIdLookUpEdit.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.parentIdLookUpEdit.Properties.Columns.AddRange(new DevExpress.XtraEditors.Controls.LookUpColumnInfo[] {
            new DevExpress.XtraEditors.Controls.LookUpColumnInfo("NodeName", "Node Name", 65, DevExpress.Utils.FormatType.None, "", true, DevExpress.Utils.HorzAlignment.Near)});
            this.parentIdLookUpEdit.Properties.DataSource = this.parentNodeBindingSource;
            this.parentIdLookUpEdit.Properties.DisplayMember = "NodeName";
            this.parentIdLookUpEdit.Properties.NullText = "[Select Parent Unit]";
            this.parentIdLookUpEdit.Properties.ValueMember = "NodeId";
            this.parentIdLookUpEdit.Size = new System.Drawing.Size(258, 20);
            this.parentIdLookUpEdit.TabIndex = 1;
            // 
            // descriptionMemoEdit
            // 
            this.descriptionMemoEdit.DataBindings.Add(new System.Windows.Forms.Binding("EditValue", this.organizationBindingSource, "Description", true));
            this.descriptionMemoEdit.Location = new System.Drawing.Point(82, 90);
            this.descriptionMemoEdit.Name = "descriptionMemoEdit";
            this.descriptionMemoEdit.Size = new System.Drawing.Size(258, 96);
            this.descriptionMemoEdit.TabIndex = 3;
            // 
            // saveCommand
            // 
            this.saveCommand.Location = new System.Drawing.Point(100, 195);
            this.saveCommand.Name = "saveCommand";
            this.saveCommand.Size = new System.Drawing.Size(75, 23);
            this.saveCommand.TabIndex = 4;
            this.saveCommand.Text = "Save";
            this.saveCommand.Click += new System.EventHandler(this.saveCommand_Click);
            // 
            // cancelCommand
            // 
            this.cancelCommand.Location = new System.Drawing.Point(182, 195);
            this.cancelCommand.Name = "cancelCommand";
            this.cancelCommand.Size = new System.Drawing.Size(75, 23);
            this.cancelCommand.TabIndex = 5;
            this.cancelCommand.Text = "Cancel";
            this.cancelCommand.Click += new System.EventHandler(this.cancelCommand_Click);
            // 
            // errorProvider1
            // 
            this.errorProvider1.ContainerControl = this;
            this.errorProvider1.DataSource = this.organizationBindingSource;
            // 
            // organizationBindingSource
            // 
            this.organizationBindingSource.DataSource = typeof(ClearOffice.Hrm.Business.Data.Organization);
            this.organizationBindingSource.CurrentItemChanged += new System.EventHandler(this.organizationBindingSource_CurrentItemChanged);
            // 
            // parentNodeBindingSource
            // 
            this.parentNodeBindingSource.DataSource = typeof(ClearOffice.Hrm.Business.Data.Organization);
            // 
            // organizationTypeBindingSource
            // 
            this.organizationTypeBindingSource.DataSource = typeof(ClearOffice.Hrm.Business.Data.OrganizationNodeType);
            // 
            // NodeEdit
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(356, 228);
            this.Controls.Add(this.cancelCommand);
            this.Controls.Add(this.saveCommand);
            this.Controls.Add(descriptionLabel);
            this.Controls.Add(this.descriptionMemoEdit);
            this.Controls.Add(parentIdLabel);
            this.Controls.Add(this.parentIdLookUpEdit);
            this.Controls.Add(nodeTypeIdLabel);
            this.Controls.Add(this.nodeTypeIdLookUpEdit);
            this.Controls.Add(nodeNameLabel);
            this.Controls.Add(this.nodeNameTextEdit);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "NodeEdit";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Add Organization Unit";
            ((System.ComponentModel.ISupportInitialize)(this.nodeNameTextEdit.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nodeTypeIdLookUpEdit.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.parentIdLookUpEdit.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.descriptionMemoEdit.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.organizationBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.parentNodeBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.organizationTypeBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.BindingSource organizationBindingSource;
        private System.Windows.Forms.BindingSource organizationTypeBindingSource;
        private DevExpress.XtraEditors.TextEdit nodeNameTextEdit;
        private DevExpress.XtraEditors.LookUpEdit nodeTypeIdLookUpEdit;
        private DevExpress.XtraEditors.LookUpEdit parentIdLookUpEdit;
        private DevExpress.XtraEditors.MemoEdit descriptionMemoEdit;
        private System.Windows.Forms.BindingSource parentNodeBindingSource;
        private DevExpress.XtraEditors.SimpleButton saveCommand;
        private DevExpress.XtraEditors.SimpleButton cancelCommand;
        private System.Windows.Forms.ErrorProvider errorProvider1;
    }
}