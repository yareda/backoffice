namespace ClearOffice.Fleet.Views
{
    partial class NewTire
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
            System.Windows.Forms.Label serialNoLabel;
            System.Windows.Forms.Label sizeLabel;
            System.Windows.Forms.Label tireTypeLabel;
            System.Windows.Forms.Label brandLabel;
            System.Windows.Forms.Label purchasedDateLabel;
            System.Windows.Forms.Label vendorLabel;
            System.Windows.Forms.Label commentLabel;
            this.serialNoTextEdit = new DevExpress.XtraEditors.TextEdit();
            this.tireBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.sizeLookUpEdit = new DevExpress.XtraEditors.LookUpEdit();
            this.tireSizeBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.tireTypeLookUpEdit = new DevExpress.XtraEditors.LookUpEdit();
            this.tireTypeBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.brandLookUpEdit = new DevExpress.XtraEditors.LookUpEdit();
            this.tireBrandBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.purchasedDateDateEdit = new DevExpress.XtraEditors.DateEdit();
            this.vendorLookUpEdit = new DevExpress.XtraEditors.LookUpEdit();
            this.vendorBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.commentMemoEdit = new DevExpress.XtraEditors.MemoEdit();
            this.addCommand = new DevExpress.XtraEditors.SimpleButton();
            this.canceCommand = new DevExpress.XtraEditors.SimpleButton();
            serialNoLabel = new System.Windows.Forms.Label();
            sizeLabel = new System.Windows.Forms.Label();
            tireTypeLabel = new System.Windows.Forms.Label();
            brandLabel = new System.Windows.Forms.Label();
            purchasedDateLabel = new System.Windows.Forms.Label();
            vendorLabel = new System.Windows.Forms.Label();
            commentLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.serialNoTextEdit.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tireBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.sizeLookUpEdit.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tireSizeBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tireTypeLookUpEdit.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tireTypeBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.brandLookUpEdit.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tireBrandBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.purchasedDateDateEdit.Properties.VistaTimeProperties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.purchasedDateDateEdit.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.vendorLookUpEdit.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.vendorBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.commentMemoEdit.Properties)).BeginInit();
            this.SuspendLayout();
            // 
            // serialNoLabel
            // 
            serialNoLabel.AutoSize = true;
            serialNoLabel.Location = new System.Drawing.Point(9, 15);
            serialNoLabel.Name = "serialNoLabel";
            serialNoLabel.Size = new System.Drawing.Size(53, 13);
            serialNoLabel.TabIndex = 0;
            serialNoLabel.Text = "Serial No:";
            // 
            // sizeLabel
            // 
            sizeLabel.AutoSize = true;
            sizeLabel.Location = new System.Drawing.Point(9, 41);
            sizeLabel.Name = "sizeLabel";
            sizeLabel.Size = new System.Drawing.Size(30, 13);
            sizeLabel.TabIndex = 2;
            sizeLabel.Text = "Size:";
            // 
            // tireTypeLabel
            // 
            tireTypeLabel.AutoSize = true;
            tireTypeLabel.Location = new System.Drawing.Point(9, 67);
            tireTypeLabel.Name = "tireTypeLabel";
            tireTypeLabel.Size = new System.Drawing.Size(56, 13);
            tireTypeLabel.TabIndex = 4;
            tireTypeLabel.Text = "Tire Type:";
            // 
            // brandLabel
            // 
            brandLabel.AutoSize = true;
            brandLabel.Location = new System.Drawing.Point(9, 93);
            brandLabel.Name = "brandLabel";
            brandLabel.Size = new System.Drawing.Size(39, 13);
            brandLabel.TabIndex = 6;
            brandLabel.Text = "Brand:";
            // 
            // purchasedDateLabel
            // 
            purchasedDateLabel.AutoSize = true;
            purchasedDateLabel.Location = new System.Drawing.Point(9, 119);
            purchasedDateLabel.Name = "purchasedDateLabel";
            purchasedDateLabel.Size = new System.Drawing.Size(81, 13);
            purchasedDateLabel.TabIndex = 8;
            purchasedDateLabel.Text = "Purchase Date:";
            // 
            // vendorLabel
            // 
            vendorLabel.AutoSize = true;
            vendorLabel.Location = new System.Drawing.Point(9, 145);
            vendorLabel.Name = "vendorLabel";
            vendorLabel.Size = new System.Drawing.Size(45, 13);
            vendorLabel.TabIndex = 12;
            vendorLabel.Text = "Vendor:";
            // 
            // commentLabel
            // 
            commentLabel.AutoSize = true;
            commentLabel.Location = new System.Drawing.Point(9, 171);
            commentLabel.Name = "commentLabel";
            commentLabel.Size = new System.Drawing.Size(56, 13);
            commentLabel.TabIndex = 14;
            commentLabel.Text = "Comment:";
            // 
            // serialNoTextEdit
            // 
            this.serialNoTextEdit.DataBindings.Add(new System.Windows.Forms.Binding("EditValue", this.tireBindingSource, "SerialNo", true));
            this.serialNoTextEdit.Location = new System.Drawing.Point(99, 12);
            this.serialNoTextEdit.Name = "serialNoTextEdit";
            this.serialNoTextEdit.Size = new System.Drawing.Size(281, 20);
            this.serialNoTextEdit.TabIndex = 1;
            // 
            // tireBindingSource
            // 
            this.tireBindingSource.DataSource = typeof(ClearOffice.Fleet.Business.Tire);
            // 
            // sizeLookUpEdit
            // 
            this.sizeLookUpEdit.DataBindings.Add(new System.Windows.Forms.Binding("EditValue", this.tireBindingSource, "Size", true));
            this.sizeLookUpEdit.Location = new System.Drawing.Point(99, 38);
            this.sizeLookUpEdit.Name = "sizeLookUpEdit";
            this.sizeLookUpEdit.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.sizeLookUpEdit.Properties.Columns.AddRange(new DevExpress.XtraEditors.Controls.LookUpColumnInfo[] {
            new DevExpress.XtraEditors.Controls.LookUpColumnInfo("ItemName", "Tire Size", 62, DevExpress.Utils.FormatType.None, "", true, DevExpress.Utils.HorzAlignment.Near)});
            this.sizeLookUpEdit.Properties.DataSource = this.tireSizeBindingSource;
            this.sizeLookUpEdit.Properties.DisplayMember = "ItemName";
            this.sizeLookUpEdit.Properties.NullText = "[Select Tire Size]";
            this.sizeLookUpEdit.Properties.ValueMember = "LookupItemId";
            this.sizeLookUpEdit.Size = new System.Drawing.Size(281, 20);
            this.sizeLookUpEdit.TabIndex = 3;
            // 
            // tireSizeBindingSource
            // 
            this.tireSizeBindingSource.DataSource = typeof(ClearOffice.Fleet.Business.TireSizeInfo);
            // 
            // tireTypeLookUpEdit
            // 
            this.tireTypeLookUpEdit.DataBindings.Add(new System.Windows.Forms.Binding("EditValue", this.tireBindingSource, "TireType", true));
            this.tireTypeLookUpEdit.Location = new System.Drawing.Point(99, 64);
            this.tireTypeLookUpEdit.Name = "tireTypeLookUpEdit";
            this.tireTypeLookUpEdit.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.tireTypeLookUpEdit.Properties.Columns.AddRange(new DevExpress.XtraEditors.Controls.LookUpColumnInfo[] {
            new DevExpress.XtraEditors.Controls.LookUpColumnInfo("ItemName", "Tire Type", 62, DevExpress.Utils.FormatType.None, "", true, DevExpress.Utils.HorzAlignment.Near)});
            this.tireTypeLookUpEdit.Properties.DataSource = this.tireTypeBindingSource;
            this.tireTypeLookUpEdit.Properties.DisplayMember = "ItemName";
            this.tireTypeLookUpEdit.Properties.NullText = "[Select Tire Type]";
            this.tireTypeLookUpEdit.Properties.ValueMember = "LookupItemId";
            this.tireTypeLookUpEdit.Size = new System.Drawing.Size(281, 20);
            this.tireTypeLookUpEdit.TabIndex = 5;
            // 
            // tireTypeBindingSource
            // 
            this.tireTypeBindingSource.DataSource = typeof(ClearOffice.Fleet.Business.TireTypeInfo);
            // 
            // brandLookUpEdit
            // 
            this.brandLookUpEdit.DataBindings.Add(new System.Windows.Forms.Binding("EditValue", this.tireBindingSource, "Brand", true));
            this.brandLookUpEdit.Location = new System.Drawing.Point(99, 90);
            this.brandLookUpEdit.Name = "brandLookUpEdit";
            this.brandLookUpEdit.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.brandLookUpEdit.Properties.Columns.AddRange(new DevExpress.XtraEditors.Controls.LookUpColumnInfo[] {
            new DevExpress.XtraEditors.Controls.LookUpColumnInfo("ItemName", "Tire Brand", 62, DevExpress.Utils.FormatType.None, "", true, DevExpress.Utils.HorzAlignment.Near)});
            this.brandLookUpEdit.Properties.DataSource = this.tireBrandBindingSource;
            this.brandLookUpEdit.Properties.DisplayMember = "ItemName";
            this.brandLookUpEdit.Properties.NullText = "[Select Tire Brand]";
            this.brandLookUpEdit.Properties.ValueMember = "LookupItemId";
            this.brandLookUpEdit.Size = new System.Drawing.Size(281, 20);
            this.brandLookUpEdit.TabIndex = 7;
            // 
            // tireBrandBindingSource
            // 
            this.tireBrandBindingSource.DataSource = typeof(ClearOffice.Fleet.Business.TireBrandInfo);
            // 
            // purchasedDateDateEdit
            // 
            this.purchasedDateDateEdit.DataBindings.Add(new System.Windows.Forms.Binding("EditValue", this.tireBindingSource, "PurchasedDate", true));
            this.purchasedDateDateEdit.EditValue = null;
            this.purchasedDateDateEdit.Location = new System.Drawing.Point(99, 116);
            this.purchasedDateDateEdit.Name = "purchasedDateDateEdit";
            this.purchasedDateDateEdit.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.purchasedDateDateEdit.Properties.VistaTimeProperties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton()});
            this.purchasedDateDateEdit.Size = new System.Drawing.Size(281, 20);
            this.purchasedDateDateEdit.TabIndex = 9;
            // 
            // vendorLookUpEdit
            // 
            this.vendorLookUpEdit.DataBindings.Add(new System.Windows.Forms.Binding("EditValue", this.tireBindingSource, "Vendor", true));
            this.vendorLookUpEdit.Location = new System.Drawing.Point(99, 142);
            this.vendorLookUpEdit.Name = "vendorLookUpEdit";
            this.vendorLookUpEdit.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.vendorLookUpEdit.Properties.Columns.AddRange(new DevExpress.XtraEditors.Controls.LookUpColumnInfo[] {
            new DevExpress.XtraEditors.Controls.LookUpColumnInfo("ItemName", "Item Name", 62, DevExpress.Utils.FormatType.None, "", true, DevExpress.Utils.HorzAlignment.Near)});
            this.vendorLookUpEdit.Properties.DataSource = this.vendorBindingSource;
            this.vendorLookUpEdit.Properties.DisplayMember = "ItemName";
            this.vendorLookUpEdit.Properties.NullText = "[Select Vendor]";
            this.vendorLookUpEdit.Properties.ValueMember = "LookupItemId";
            this.vendorLookUpEdit.Size = new System.Drawing.Size(281, 20);
            this.vendorLookUpEdit.TabIndex = 13;
            // 
            // vendorBindingSource
            // 
            this.vendorBindingSource.DataSource = typeof(ClearOffice.Fleet.Business.LookupItem);
            // 
            // commentMemoEdit
            // 
            this.commentMemoEdit.DataBindings.Add(new System.Windows.Forms.Binding("EditValue", this.tireBindingSource, "Comment", true));
            this.commentMemoEdit.Location = new System.Drawing.Point(99, 168);
            this.commentMemoEdit.Name = "commentMemoEdit";
            this.commentMemoEdit.Size = new System.Drawing.Size(366, 82);
            this.commentMemoEdit.TabIndex = 15;
            // 
            // addCommand
            // 
            this.addCommand.Location = new System.Drawing.Point(173, 260);
            this.addCommand.Name = "addCommand";
            this.addCommand.Size = new System.Drawing.Size(75, 23);
            this.addCommand.TabIndex = 16;
            this.addCommand.Text = "Add";
            this.addCommand.Click += new System.EventHandler(this.addCommand_Click);
            // 
            // canceCommand
            // 
            this.canceCommand.Location = new System.Drawing.Point(255, 260);
            this.canceCommand.Name = "canceCommand";
            this.canceCommand.Size = new System.Drawing.Size(75, 23);
            this.canceCommand.TabIndex = 17;
            this.canceCommand.Text = "Cancel";
            this.canceCommand.Click += new System.EventHandler(this.canceCommand_Click);
            // 
            // NewTire
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(479, 299);
            this.Controls.Add(this.canceCommand);
            this.Controls.Add(this.addCommand);
            this.Controls.Add(commentLabel);
            this.Controls.Add(this.commentMemoEdit);
            this.Controls.Add(vendorLabel);
            this.Controls.Add(this.vendorLookUpEdit);
            this.Controls.Add(purchasedDateLabel);
            this.Controls.Add(this.purchasedDateDateEdit);
            this.Controls.Add(brandLabel);
            this.Controls.Add(this.brandLookUpEdit);
            this.Controls.Add(tireTypeLabel);
            this.Controls.Add(this.tireTypeLookUpEdit);
            this.Controls.Add(sizeLabel);
            this.Controls.Add(this.sizeLookUpEdit);
            this.Controls.Add(serialNoLabel);
            this.Controls.Add(this.serialNoTextEdit);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "NewTire";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Add New Tire";
            ((System.ComponentModel.ISupportInitialize)(this.serialNoTextEdit.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tireBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.sizeLookUpEdit.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tireSizeBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tireTypeLookUpEdit.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tireTypeBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.brandLookUpEdit.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tireBrandBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.purchasedDateDateEdit.Properties.VistaTimeProperties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.purchasedDateDateEdit.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.vendorLookUpEdit.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.vendorBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.commentMemoEdit.Properties)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.BindingSource tireBindingSource;
        private DevExpress.XtraEditors.TextEdit serialNoTextEdit;
        private DevExpress.XtraEditors.LookUpEdit sizeLookUpEdit;
        private DevExpress.XtraEditors.LookUpEdit tireTypeLookUpEdit;
        private DevExpress.XtraEditors.LookUpEdit brandLookUpEdit;
        private DevExpress.XtraEditors.DateEdit purchasedDateDateEdit;
        private DevExpress.XtraEditors.LookUpEdit vendorLookUpEdit;
        private DevExpress.XtraEditors.MemoEdit commentMemoEdit;
        private DevExpress.XtraEditors.SimpleButton addCommand;
        private DevExpress.XtraEditors.SimpleButton canceCommand;
        private System.Windows.Forms.BindingSource tireSizeBindingSource;
        private System.Windows.Forms.BindingSource tireTypeBindingSource;
        private System.Windows.Forms.BindingSource tireBrandBindingSource;
        private System.Windows.Forms.BindingSource vendorBindingSource;
    }
}