namespace ClearOffice.Inventory.Views
{
    partial class NewIsssue
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
            System.Windows.Forms.Label issueNoLabel;
            System.Windows.Forms.Label issueDateLabel;
            System.Windows.Forms.Label issuedByLabel;
            System.Windows.Forms.Label warehouseIdLabel;
            System.Windows.Forms.Label remarkLabel;
            this.issueNoTextEdit = new DevExpress.XtraEditors.TextEdit();
            this.issueDateDateEdit = new DevExpress.XtraEditors.DateEdit();
            this.issuedByTextEdit = new DevExpress.XtraEditors.TextEdit();
            this.warehouseIdLookUpEdit = new DevExpress.XtraEditors.LookUpEdit();
            this.remarkMemoEdit = new DevExpress.XtraEditors.MemoEdit();
            this.saveCommand = new DevExpress.XtraEditors.SimpleButton();
            this.cancelCommand = new DevExpress.XtraEditors.SimpleButton();
            this.errorProvider1 = new System.Windows.Forms.ErrorProvider(this.components);
            this.issueBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.warehouseBindingSource = new System.Windows.Forms.BindingSource(this.components);
            issueNoLabel = new System.Windows.Forms.Label();
            issueDateLabel = new System.Windows.Forms.Label();
            issuedByLabel = new System.Windows.Forms.Label();
            warehouseIdLabel = new System.Windows.Forms.Label();
            remarkLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.issueNoTextEdit.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.issueDateDateEdit.Properties.VistaTimeProperties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.issueDateDateEdit.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.issuedByTextEdit.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.warehouseIdLookUpEdit.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.remarkMemoEdit.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.issueBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.warehouseBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // issueNoLabel
            // 
            issueNoLabel.AutoSize = true;
            issueNoLabel.Location = new System.Drawing.Point(7, 15);
            issueNoLabel.Name = "issueNoLabel";
            issueNoLabel.Size = new System.Drawing.Size(53, 13);
            issueNoLabel.TabIndex = 0;
            issueNoLabel.Text = "Issue No:";
            // 
            // issueDateLabel
            // 
            issueDateLabel.AutoSize = true;
            issueDateLabel.Location = new System.Drawing.Point(7, 41);
            issueDateLabel.Name = "issueDateLabel";
            issueDateLabel.Size = new System.Drawing.Size(63, 13);
            issueDateLabel.TabIndex = 2;
            issueDateLabel.Text = "Issue Date:";
            // 
            // issuedByLabel
            // 
            issuedByLabel.AutoSize = true;
            issuedByLabel.Location = new System.Drawing.Point(7, 67);
            issuedByLabel.Name = "issuedByLabel";
            issuedByLabel.Size = new System.Drawing.Size(58, 13);
            issuedByLabel.TabIndex = 4;
            issuedByLabel.Text = "Issued By:";
            // 
            // warehouseIdLabel
            // 
            warehouseIdLabel.AutoSize = true;
            warehouseIdLabel.Location = new System.Drawing.Point(7, 93);
            warehouseIdLabel.Name = "warehouseIdLabel";
            warehouseIdLabel.Size = new System.Drawing.Size(66, 13);
            warehouseIdLabel.TabIndex = 6;
            warehouseIdLabel.Text = "Warehouse:";
            // 
            // remarkLabel
            // 
            remarkLabel.AutoSize = true;
            remarkLabel.Location = new System.Drawing.Point(7, 119);
            remarkLabel.Name = "remarkLabel";
            remarkLabel.Size = new System.Drawing.Size(47, 13);
            remarkLabel.TabIndex = 8;
            remarkLabel.Text = "Remark:";
            // 
            // issueNoTextEdit
            // 
            this.issueNoTextEdit.DataBindings.Add(new System.Windows.Forms.Binding("EditValue", this.issueBindingSource, "IssueNo", true));
            this.issueNoTextEdit.Enabled = false;
            this.issueNoTextEdit.Location = new System.Drawing.Point(91, 12);
            this.issueNoTextEdit.Name = "issueNoTextEdit";
            this.issueNoTextEdit.Size = new System.Drawing.Size(282, 20);
            this.issueNoTextEdit.TabIndex = 1;
            // 
            // issueDateDateEdit
            // 
            this.issueDateDateEdit.DataBindings.Add(new System.Windows.Forms.Binding("EditValue", this.issueBindingSource, "IssueDate", true));
            this.issueDateDateEdit.EditValue = null;
            this.issueDateDateEdit.Location = new System.Drawing.Point(91, 38);
            this.issueDateDateEdit.Name = "issueDateDateEdit";
            this.issueDateDateEdit.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.issueDateDateEdit.Properties.VistaTimeProperties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton()});
            this.issueDateDateEdit.Size = new System.Drawing.Size(282, 20);
            this.issueDateDateEdit.TabIndex = 3;
            // 
            // issuedByTextEdit
            // 
            this.issuedByTextEdit.DataBindings.Add(new System.Windows.Forms.Binding("EditValue", this.issueBindingSource, "IssuedBy", true));
            this.issuedByTextEdit.Location = new System.Drawing.Point(91, 64);
            this.issuedByTextEdit.Name = "issuedByTextEdit";
            this.issuedByTextEdit.Size = new System.Drawing.Size(282, 20);
            this.issuedByTextEdit.TabIndex = 5;
            // 
            // warehouseIdLookUpEdit
            // 
            this.warehouseIdLookUpEdit.DataBindings.Add(new System.Windows.Forms.Binding("EditValue", this.issueBindingSource, "WarehouseId", true));
            this.warehouseIdLookUpEdit.Location = new System.Drawing.Point(91, 90);
            this.warehouseIdLookUpEdit.Name = "warehouseIdLookUpEdit";
            this.warehouseIdLookUpEdit.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.warehouseIdLookUpEdit.Properties.Columns.AddRange(new DevExpress.XtraEditors.Controls.LookUpColumnInfo[] {
            new DevExpress.XtraEditors.Controls.LookUpColumnInfo("Name", "Name", 37, DevExpress.Utils.FormatType.None, "", true, DevExpress.Utils.HorzAlignment.Near)});
            this.warehouseIdLookUpEdit.Properties.DataSource = this.warehouseBindingSource;
            this.warehouseIdLookUpEdit.Properties.DisplayMember = "Name";
            this.warehouseIdLookUpEdit.Properties.NullText = "[Select Warehouse]";
            this.warehouseIdLookUpEdit.Properties.ValueMember = "WarehouseId";
            this.warehouseIdLookUpEdit.Size = new System.Drawing.Size(282, 20);
            this.warehouseIdLookUpEdit.TabIndex = 7;
            // 
            // remarkMemoEdit
            // 
            this.remarkMemoEdit.DataBindings.Add(new System.Windows.Forms.Binding("EditValue", this.issueBindingSource, "Remark", true));
            this.remarkMemoEdit.Location = new System.Drawing.Point(91, 116);
            this.remarkMemoEdit.Name = "remarkMemoEdit";
            this.remarkMemoEdit.Size = new System.Drawing.Size(282, 96);
            this.remarkMemoEdit.TabIndex = 9;
            // 
            // saveCommand
            // 
            this.saveCommand.Location = new System.Drawing.Point(114, 219);
            this.saveCommand.Name = "saveCommand";
            this.saveCommand.Size = new System.Drawing.Size(75, 23);
            this.saveCommand.TabIndex = 10;
            this.saveCommand.Text = "Save";
            this.saveCommand.Click += new System.EventHandler(this.saveCommand_Click);
            // 
            // cancelCommand
            // 
            this.cancelCommand.Location = new System.Drawing.Point(196, 219);
            this.cancelCommand.Name = "cancelCommand";
            this.cancelCommand.Size = new System.Drawing.Size(75, 23);
            this.cancelCommand.TabIndex = 11;
            this.cancelCommand.Text = "Cancel";
            this.cancelCommand.Click += new System.EventHandler(this.cancelCommand_Click);
            // 
            // errorProvider1
            // 
            this.errorProvider1.ContainerControl = this;
            this.errorProvider1.DataSource = this.issueBindingSource;
            // 
            // issueBindingSource
            // 
            this.issueBindingSource.DataSource = typeof(ClearOffice.Inventory.DataAccess.Issue);
            this.issueBindingSource.CurrentItemChanged += new System.EventHandler(this.issueBindingSource_CurrentItemChanged);
            // 
            // warehouseBindingSource
            // 
            this.warehouseBindingSource.DataSource = typeof(ClearOffice.Inventory.DataAccess.Warehouse);
            // 
            // NewIsssue
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(384, 254);
            this.Controls.Add(this.cancelCommand);
            this.Controls.Add(this.saveCommand);
            this.Controls.Add(remarkLabel);
            this.Controls.Add(this.remarkMemoEdit);
            this.Controls.Add(warehouseIdLabel);
            this.Controls.Add(this.warehouseIdLookUpEdit);
            this.Controls.Add(issuedByLabel);
            this.Controls.Add(this.issuedByTextEdit);
            this.Controls.Add(issueDateLabel);
            this.Controls.Add(this.issueDateDateEdit);
            this.Controls.Add(issueNoLabel);
            this.Controls.Add(this.issueNoTextEdit);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "NewIsssue";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "New Issue";
            ((System.ComponentModel.ISupportInitialize)(this.issueNoTextEdit.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.issueDateDateEdit.Properties.VistaTimeProperties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.issueDateDateEdit.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.issuedByTextEdit.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.warehouseIdLookUpEdit.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.remarkMemoEdit.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.issueBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.warehouseBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.BindingSource issueBindingSource;
        private System.Windows.Forms.BindingSource warehouseBindingSource;
        private DevExpress.XtraEditors.TextEdit issueNoTextEdit;
        private DevExpress.XtraEditors.DateEdit issueDateDateEdit;
        private DevExpress.XtraEditors.TextEdit issuedByTextEdit;
        private DevExpress.XtraEditors.LookUpEdit warehouseIdLookUpEdit;
        private DevExpress.XtraEditors.MemoEdit remarkMemoEdit;
        private DevExpress.XtraEditors.SimpleButton saveCommand;
        private DevExpress.XtraEditors.SimpleButton cancelCommand;
        private System.Windows.Forms.ErrorProvider errorProvider1;
    }
}