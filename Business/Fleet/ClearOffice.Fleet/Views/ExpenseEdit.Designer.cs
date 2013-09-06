namespace ClearOffice.Fleet.Views
{
    partial class ExpenseEdit
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
            System.Windows.Forms.Label paymentTypeIdLabel;
            System.Windows.Forms.Label amountLabel;
            System.Windows.Forms.Label descriptionLabel;
            System.Windows.Forms.Label paymentDateLabel;
            System.Windows.Forms.Label invoiceLabel;
            System.Windows.Forms.Label remarkLabel;
            this.SaveCommand = new DevExpress.XtraEditors.SimpleButton();
            this.CancelCommand = new DevExpress.XtraEditors.SimpleButton();
            this.paymentTypeIdLookUpEdit = new DevExpress.XtraEditors.LookUpEdit();
            this.expenseBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.paymentTypeBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.amountTextBox = new System.Windows.Forms.TextBox();
            this.descriptionTextBox = new System.Windows.Forms.TextBox();
            this.paymentDateDateEdit = new DevExpress.XtraEditors.DateEdit();
            this.invoiceTextBox = new System.Windows.Forms.TextBox();
            this.remarkTextBox = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.plateNoTextBox = new System.Windows.Forms.TextBox();
            this.errorProvider1 = new System.Windows.Forms.ErrorProvider(this.components);
            paymentTypeIdLabel = new System.Windows.Forms.Label();
            amountLabel = new System.Windows.Forms.Label();
            descriptionLabel = new System.Windows.Forms.Label();
            paymentDateLabel = new System.Windows.Forms.Label();
            invoiceLabel = new System.Windows.Forms.Label();
            remarkLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.paymentTypeIdLookUpEdit.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.expenseBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.paymentTypeBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.paymentDateDateEdit.Properties.VistaTimeProperties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.paymentDateDateEdit.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).BeginInit();
            this.SuspendLayout();
            // 
            // paymentTypeIdLabel
            // 
            paymentTypeIdLabel.AutoSize = true;
            paymentTypeIdLabel.Location = new System.Drawing.Point(8, 34);
            paymentTypeIdLabel.Name = "paymentTypeIdLabel";
            paymentTypeIdLabel.Size = new System.Drawing.Size(80, 13);
            paymentTypeIdLabel.TabIndex = 2;
            paymentTypeIdLabel.Text = "Payment Type:";
            // 
            // amountLabel
            // 
            amountLabel.AutoSize = true;
            amountLabel.Location = new System.Drawing.Point(8, 60);
            amountLabel.Name = "amountLabel";
            amountLabel.Size = new System.Drawing.Size(48, 13);
            amountLabel.TabIndex = 4;
            amountLabel.Text = "Amount:";
            // 
            // descriptionLabel
            // 
            descriptionLabel.AutoSize = true;
            descriptionLabel.Location = new System.Drawing.Point(8, 87);
            descriptionLabel.Name = "descriptionLabel";
            descriptionLabel.Size = new System.Drawing.Size(64, 13);
            descriptionLabel.TabIndex = 6;
            descriptionLabel.Text = "Description:";
            // 
            // paymentDateLabel
            // 
            paymentDateLabel.AutoSize = true;
            paymentDateLabel.Location = new System.Drawing.Point(8, 148);
            paymentDateLabel.Name = "paymentDateLabel";
            paymentDateLabel.Size = new System.Drawing.Size(79, 13);
            paymentDateLabel.TabIndex = 8;
            paymentDateLabel.Text = "Payment Date:";
            // 
            // invoiceLabel
            // 
            invoiceLabel.AutoSize = true;
            invoiceLabel.Location = new System.Drawing.Point(8, 174);
            invoiceLabel.Name = "invoiceLabel";
            invoiceLabel.Size = new System.Drawing.Size(46, 13);
            invoiceLabel.TabIndex = 10;
            invoiceLabel.Text = "Invoice:";
            // 
            // remarkLabel
            // 
            remarkLabel.AutoSize = true;
            remarkLabel.Location = new System.Drawing.Point(8, 201);
            remarkLabel.Name = "remarkLabel";
            remarkLabel.Size = new System.Drawing.Size(47, 13);
            remarkLabel.TabIndex = 12;
            remarkLabel.Text = "Remark:";
            // 
            // SaveCommand
            // 
            this.SaveCommand.Location = new System.Drawing.Point(120, 267);
            this.SaveCommand.Name = "SaveCommand";
            this.SaveCommand.Size = new System.Drawing.Size(75, 23);
            this.SaveCommand.TabIndex = 0;
            this.SaveCommand.Text = "Save";
            this.SaveCommand.Click += new System.EventHandler(this.SaveCommand_Click);
            // 
            // CancelCommand
            // 
            this.CancelCommand.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.CancelCommand.Location = new System.Drawing.Point(201, 267);
            this.CancelCommand.Name = "CancelCommand";
            this.CancelCommand.Size = new System.Drawing.Size(75, 23);
            this.CancelCommand.TabIndex = 1;
            this.CancelCommand.Text = "Cancel";
            this.CancelCommand.Click += new System.EventHandler(this.CancelCommand_Click);
            // 
            // paymentTypeIdLookUpEdit
            // 
            this.paymentTypeIdLookUpEdit.DataBindings.Add(new System.Windows.Forms.Binding("EditValue", this.expenseBindingSource, "PaymentTypeId", true));
            this.paymentTypeIdLookUpEdit.Location = new System.Drawing.Point(96, 31);
            this.paymentTypeIdLookUpEdit.Name = "paymentTypeIdLookUpEdit";
            this.paymentTypeIdLookUpEdit.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.paymentTypeIdLookUpEdit.Properties.Columns.AddRange(new DevExpress.XtraEditors.Controls.LookUpColumnInfo[] {
            new DevExpress.XtraEditors.Controls.LookUpColumnInfo("ItemName", "Item Name", 62, DevExpress.Utils.FormatType.None, "", true, DevExpress.Utils.HorzAlignment.Near)});
            this.paymentTypeIdLookUpEdit.Properties.DataSource = this.paymentTypeBindingSource;
            this.paymentTypeIdLookUpEdit.Properties.DisplayMember = "ItemName";
            this.paymentTypeIdLookUpEdit.Properties.NullText = "[Select Payment Category]";
            this.paymentTypeIdLookUpEdit.Properties.ValueMember = "LookupItemId";
            this.paymentTypeIdLookUpEdit.Size = new System.Drawing.Size(287, 20);
            this.paymentTypeIdLookUpEdit.TabIndex = 3;
            // 
            // expenseBindingSource
            // 
            this.expenseBindingSource.DataSource = typeof(ClearOffice.Fleet.Business.Expense);
            this.expenseBindingSource.CurrentItemChanged += new System.EventHandler(this.expenseBindingSource_CurrentItemChanged);
            // 
            // paymentTypeBindingSource
            // 
            this.paymentTypeBindingSource.DataSource = typeof(ClearOffice.Fleet.Business.LookupItem);
            // 
            // amountTextBox
            // 
            this.amountTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.expenseBindingSource, "Amount", true));
            this.amountTextBox.Location = new System.Drawing.Point(96, 57);
            this.amountTextBox.Name = "amountTextBox";
            this.amountTextBox.Size = new System.Drawing.Size(172, 21);
            this.amountTextBox.TabIndex = 5;
            // 
            // descriptionTextBox
            // 
            this.descriptionTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.expenseBindingSource, "Description", true));
            this.descriptionTextBox.Location = new System.Drawing.Point(96, 84);
            this.descriptionTextBox.Multiline = true;
            this.descriptionTextBox.Name = "descriptionTextBox";
            this.descriptionTextBox.Size = new System.Drawing.Size(287, 55);
            this.descriptionTextBox.TabIndex = 7;
            // 
            // paymentDateDateEdit
            // 
            this.paymentDateDateEdit.DataBindings.Add(new System.Windows.Forms.Binding("EditValue", this.expenseBindingSource, "PaymentDate", true));
            this.paymentDateDateEdit.EditValue = null;
            this.paymentDateDateEdit.Location = new System.Drawing.Point(96, 145);
            this.paymentDateDateEdit.Name = "paymentDateDateEdit";
            this.paymentDateDateEdit.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.paymentDateDateEdit.Properties.VistaTimeProperties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton()});
            this.paymentDateDateEdit.Size = new System.Drawing.Size(172, 20);
            this.paymentDateDateEdit.TabIndex = 9;
            // 
            // invoiceTextBox
            // 
            this.invoiceTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.expenseBindingSource, "Invoice", true));
            this.invoiceTextBox.Location = new System.Drawing.Point(96, 171);
            this.invoiceTextBox.Name = "invoiceTextBox";
            this.invoiceTextBox.Size = new System.Drawing.Size(172, 21);
            this.invoiceTextBox.TabIndex = 11;
            // 
            // remarkTextBox
            // 
            this.remarkTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.expenseBindingSource, "Remark", true));
            this.remarkTextBox.Location = new System.Drawing.Point(96, 198);
            this.remarkTextBox.Multiline = true;
            this.remarkTextBox.Name = "remarkTextBox";
            this.remarkTextBox.Size = new System.Drawing.Size(287, 61);
            this.remarkTextBox.TabIndex = 13;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(8, 13);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(46, 13);
            this.label1.TabIndex = 14;
            this.label1.Text = "Plate #:";
            // 
            // plateNoTextBox
            // 
            this.plateNoTextBox.Enabled = false;
            this.plateNoTextBox.Location = new System.Drawing.Point(96, 5);
            this.plateNoTextBox.Name = "plateNoTextBox";
            this.plateNoTextBox.Size = new System.Drawing.Size(171, 21);
            this.plateNoTextBox.TabIndex = 15;
            // 
            // errorProvider1
            // 
            this.errorProvider1.ContainerControl = this;
            this.errorProvider1.DataSource = this.expenseBindingSource;
            // 
            // ExpenseEdit
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CancelButton = this.CancelCommand;
            this.ClientSize = new System.Drawing.Size(396, 302);
            this.Controls.Add(this.plateNoTextBox);
            this.Controls.Add(this.label1);
            this.Controls.Add(remarkLabel);
            this.Controls.Add(this.remarkTextBox);
            this.Controls.Add(invoiceLabel);
            this.Controls.Add(this.invoiceTextBox);
            this.Controls.Add(paymentDateLabel);
            this.Controls.Add(this.paymentDateDateEdit);
            this.Controls.Add(descriptionLabel);
            this.Controls.Add(this.descriptionTextBox);
            this.Controls.Add(amountLabel);
            this.Controls.Add(this.amountTextBox);
            this.Controls.Add(paymentTypeIdLabel);
            this.Controls.Add(this.paymentTypeIdLookUpEdit);
            this.Controls.Add(this.CancelCommand);
            this.Controls.Add(this.SaveCommand);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "ExpenseEdit";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Expense Record Detail";
            ((System.ComponentModel.ISupportInitialize)(this.paymentTypeIdLookUpEdit.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.expenseBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.paymentTypeBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.paymentDateDateEdit.Properties.VistaTimeProperties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.paymentDateDateEdit.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private DevExpress.XtraEditors.SimpleButton SaveCommand;
        private DevExpress.XtraEditors.SimpleButton CancelCommand;
        private System.Windows.Forms.BindingSource expenseBindingSource;
        private System.Windows.Forms.BindingSource paymentTypeBindingSource;
        private DevExpress.XtraEditors.LookUpEdit paymentTypeIdLookUpEdit;
        private System.Windows.Forms.TextBox amountTextBox;
        private System.Windows.Forms.TextBox descriptionTextBox;
        private DevExpress.XtraEditors.DateEdit paymentDateDateEdit;
        private System.Windows.Forms.TextBox invoiceTextBox;
        private System.Windows.Forms.TextBox remarkTextBox;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox plateNoTextBox;
        private System.Windows.Forms.ErrorProvider errorProvider1;
    }
}