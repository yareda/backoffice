namespace ClearOffice.Inventory.Views
{
    partial class NewReturn
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
            System.Windows.Forms.Label returnNoLabel;
            System.Windows.Forms.Label acceptedByLabel;
            System.Windows.Forms.Label warehouseIdLabel;
            System.Windows.Forms.Label acceptedDateLabel;
            System.Windows.Forms.Label reasonLabel;
            System.Windows.Forms.Label remarkLabel;
            this.returnBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.returnNoTextEdit = new DevExpress.XtraEditors.TextEdit();
            this.acceptedByTextEdit = new DevExpress.XtraEditors.TextEdit();
            this.warehouseIdLookUpEdit = new DevExpress.XtraEditors.LookUpEdit();
            this.warehouseBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.acceptedDateDateEdit = new DevExpress.XtraEditors.DateEdit();
            this.reasonMemoEdit = new DevExpress.XtraEditors.MemoEdit();
            this.remarkMemoEdit = new DevExpress.XtraEditors.MemoEdit();
            this.saveCommand = new DevExpress.XtraEditors.SimpleButton();
            this.cancelCommand = new DevExpress.XtraEditors.SimpleButton();
            this.errorProvider1 = new System.Windows.Forms.ErrorProvider(this.components);
            returnNoLabel = new System.Windows.Forms.Label();
            acceptedByLabel = new System.Windows.Forms.Label();
            warehouseIdLabel = new System.Windows.Forms.Label();
            acceptedDateLabel = new System.Windows.Forms.Label();
            reasonLabel = new System.Windows.Forms.Label();
            remarkLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.returnBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.returnNoTextEdit.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.acceptedByTextEdit.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.warehouseIdLookUpEdit.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.warehouseBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.acceptedDateDateEdit.Properties.VistaTimeProperties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.acceptedDateDateEdit.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.reasonMemoEdit.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.remarkMemoEdit.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).BeginInit();
            this.SuspendLayout();
            // 
            // returnNoLabel
            // 
            returnNoLabel.AutoSize = true;
            returnNoLabel.Location = new System.Drawing.Point(10, 15);
            returnNoLabel.Name = "returnNoLabel";
            returnNoLabel.Size = new System.Drawing.Size(60, 13);
            returnNoLabel.TabIndex = 0;
            returnNoLabel.Text = "Return No:";
            // 
            // acceptedByLabel
            // 
            acceptedByLabel.AutoSize = true;
            acceptedByLabel.Location = new System.Drawing.Point(10, 67);
            acceptedByLabel.Name = "acceptedByLabel";
            acceptedByLabel.Size = new System.Drawing.Size(71, 13);
            acceptedByLabel.TabIndex = 2;
            acceptedByLabel.Text = "Accepted By:";
            // 
            // warehouseIdLabel
            // 
            warehouseIdLabel.AutoSize = true;
            warehouseIdLabel.Location = new System.Drawing.Point(10, 41);
            warehouseIdLabel.Name = "warehouseIdLabel";
            warehouseIdLabel.Size = new System.Drawing.Size(66, 13);
            warehouseIdLabel.TabIndex = 4;
            warehouseIdLabel.Text = "Warehouse:";
            // 
            // acceptedDateLabel
            // 
            acceptedDateLabel.AutoSize = true;
            acceptedDateLabel.Location = new System.Drawing.Point(10, 93);
            acceptedDateLabel.Name = "acceptedDateLabel";
            acceptedDateLabel.Size = new System.Drawing.Size(82, 13);
            acceptedDateLabel.TabIndex = 6;
            acceptedDateLabel.Text = "Accepted Date:";
            // 
            // reasonLabel
            // 
            reasonLabel.AutoSize = true;
            reasonLabel.Location = new System.Drawing.Point(10, 119);
            reasonLabel.Name = "reasonLabel";
            reasonLabel.Size = new System.Drawing.Size(47, 13);
            reasonLabel.TabIndex = 8;
            reasonLabel.Text = "Reason:";
            // 
            // remarkLabel
            // 
            remarkLabel.AutoSize = true;
            remarkLabel.Location = new System.Drawing.Point(10, 194);
            remarkLabel.Name = "remarkLabel";
            remarkLabel.Size = new System.Drawing.Size(47, 13);
            remarkLabel.TabIndex = 10;
            remarkLabel.Text = "Remark:";
            // 
            // returnBindingSource
            // 
            this.returnBindingSource.DataSource = typeof(ClearOffice.Inventory.DataAccess.ItemReturn);
            this.returnBindingSource.CurrentItemChanged += new System.EventHandler(this.returnBindingSource_CurrentItemChanged);
            // 
            // returnNoTextEdit
            // 
            this.returnNoTextEdit.DataBindings.Add(new System.Windows.Forms.Binding("EditValue", this.returnBindingSource, "ReturnNo", true));
            this.returnNoTextEdit.Enabled = false;
            this.returnNoTextEdit.Location = new System.Drawing.Point(94, 12);
            this.returnNoTextEdit.Name = "returnNoTextEdit";
            this.returnNoTextEdit.Size = new System.Drawing.Size(329, 20);
            this.returnNoTextEdit.TabIndex = 0;
            // 
            // acceptedByTextEdit
            // 
            this.acceptedByTextEdit.DataBindings.Add(new System.Windows.Forms.Binding("EditValue", this.returnBindingSource, "AcceptedBy", true));
            this.acceptedByTextEdit.Location = new System.Drawing.Point(94, 64);
            this.acceptedByTextEdit.Name = "acceptedByTextEdit";
            this.acceptedByTextEdit.Size = new System.Drawing.Size(329, 20);
            this.acceptedByTextEdit.TabIndex = 2;
            // 
            // warehouseIdLookUpEdit
            // 
            this.warehouseIdLookUpEdit.DataBindings.Add(new System.Windows.Forms.Binding("EditValue", this.returnBindingSource, "WarehouseId", true));
            this.warehouseIdLookUpEdit.Location = new System.Drawing.Point(94, 38);
            this.warehouseIdLookUpEdit.Name = "warehouseIdLookUpEdit";
            this.warehouseIdLookUpEdit.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.warehouseIdLookUpEdit.Properties.Columns.AddRange(new DevExpress.XtraEditors.Controls.LookUpColumnInfo[] {
            new DevExpress.XtraEditors.Controls.LookUpColumnInfo("Name", "Name", 37, DevExpress.Utils.FormatType.None, "", true, DevExpress.Utils.HorzAlignment.Near)});
            this.warehouseIdLookUpEdit.Properties.DataSource = this.warehouseBindingSource;
            this.warehouseIdLookUpEdit.Properties.DisplayMember = "Name";
            this.warehouseIdLookUpEdit.Properties.NullText = "[Select Warehouse]";
            this.warehouseIdLookUpEdit.Properties.ValueMember = "WarehouseId";
            this.warehouseIdLookUpEdit.Size = new System.Drawing.Size(329, 20);
            this.warehouseIdLookUpEdit.TabIndex = 1;
            // 
            // warehouseBindingSource
            // 
            this.warehouseBindingSource.DataSource = typeof(ClearOffice.Inventory.DataAccess.Warehouse);
            // 
            // acceptedDateDateEdit
            // 
            this.acceptedDateDateEdit.DataBindings.Add(new System.Windows.Forms.Binding("EditValue", this.returnBindingSource, "AcceptedDate", true));
            this.acceptedDateDateEdit.EditValue = null;
            this.acceptedDateDateEdit.Location = new System.Drawing.Point(94, 90);
            this.acceptedDateDateEdit.Name = "acceptedDateDateEdit";
            this.acceptedDateDateEdit.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.acceptedDateDateEdit.Properties.VistaTimeProperties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton()});
            this.acceptedDateDateEdit.Size = new System.Drawing.Size(329, 20);
            this.acceptedDateDateEdit.TabIndex = 3;
            // 
            // reasonMemoEdit
            // 
            this.reasonMemoEdit.DataBindings.Add(new System.Windows.Forms.Binding("EditValue", this.returnBindingSource, "Reason", true));
            this.reasonMemoEdit.Location = new System.Drawing.Point(94, 116);
            this.reasonMemoEdit.Name = "reasonMemoEdit";
            this.reasonMemoEdit.Size = new System.Drawing.Size(329, 69);
            this.reasonMemoEdit.TabIndex = 4;
            // 
            // remarkMemoEdit
            // 
            this.remarkMemoEdit.DataBindings.Add(new System.Windows.Forms.Binding("EditValue", this.returnBindingSource, "Remark", true));
            this.remarkMemoEdit.Location = new System.Drawing.Point(94, 191);
            this.remarkMemoEdit.Name = "remarkMemoEdit";
            this.remarkMemoEdit.Size = new System.Drawing.Size(329, 53);
            this.remarkMemoEdit.TabIndex = 5;
            // 
            // saveCommand
            // 
            this.saveCommand.Location = new System.Drawing.Point(139, 251);
            this.saveCommand.Name = "saveCommand";
            this.saveCommand.Size = new System.Drawing.Size(75, 23);
            this.saveCommand.TabIndex = 6;
            this.saveCommand.Text = "Save";
            this.saveCommand.Click += new System.EventHandler(this.saveCommand_Click);
            // 
            // cancelCommand
            // 
            this.cancelCommand.Location = new System.Drawing.Point(221, 251);
            this.cancelCommand.Name = "cancelCommand";
            this.cancelCommand.Size = new System.Drawing.Size(75, 23);
            this.cancelCommand.TabIndex = 7;
            this.cancelCommand.Text = "Cancel";
            this.cancelCommand.Click += new System.EventHandler(this.cancelCommand_Click);
            // 
            // errorProvider1
            // 
            this.errorProvider1.ContainerControl = this;
            this.errorProvider1.DataSource = this.returnBindingSource;
            // 
            // NewReturn
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(435, 282);
            this.Controls.Add(this.cancelCommand);
            this.Controls.Add(this.saveCommand);
            this.Controls.Add(remarkLabel);
            this.Controls.Add(this.remarkMemoEdit);
            this.Controls.Add(reasonLabel);
            this.Controls.Add(this.reasonMemoEdit);
            this.Controls.Add(acceptedDateLabel);
            this.Controls.Add(this.acceptedDateDateEdit);
            this.Controls.Add(warehouseIdLabel);
            this.Controls.Add(this.warehouseIdLookUpEdit);
            this.Controls.Add(acceptedByLabel);
            this.Controls.Add(this.acceptedByTextEdit);
            this.Controls.Add(returnNoLabel);
            this.Controls.Add(this.returnNoTextEdit);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "NewReturn";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "New Stock Return";
            ((System.ComponentModel.ISupportInitialize)(this.returnBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.returnNoTextEdit.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.acceptedByTextEdit.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.warehouseIdLookUpEdit.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.warehouseBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.acceptedDateDateEdit.Properties.VistaTimeProperties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.acceptedDateDateEdit.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.reasonMemoEdit.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.remarkMemoEdit.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.BindingSource returnBindingSource;
        private DevExpress.XtraEditors.TextEdit returnNoTextEdit;
        private DevExpress.XtraEditors.TextEdit acceptedByTextEdit;
        private DevExpress.XtraEditors.LookUpEdit warehouseIdLookUpEdit;
        private System.Windows.Forms.BindingSource warehouseBindingSource;
        private DevExpress.XtraEditors.DateEdit acceptedDateDateEdit;
        private DevExpress.XtraEditors.MemoEdit reasonMemoEdit;
        private DevExpress.XtraEditors.MemoEdit remarkMemoEdit;
        private DevExpress.XtraEditors.SimpleButton saveCommand;
        private DevExpress.XtraEditors.SimpleButton cancelCommand;
        private System.Windows.Forms.ErrorProvider errorProvider1;
    }
}