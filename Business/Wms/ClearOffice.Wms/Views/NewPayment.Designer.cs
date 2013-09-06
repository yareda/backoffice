namespace ClearOffice.Wms.Views
{
    partial class NewPayment
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
            this.errorProvider1 = new System.Windows.Forms.ErrorProvider();
            this.PaymentbindingSource = new System.Windows.Forms.BindingSource();
            this.amountReceivedLabel = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.btnpySave = new System.Windows.Forms.Button();
            this.othersTextBox = new System.Windows.Forms.TextBox();
            this.btnCancel = new System.Windows.Forms.Button();
            this.checkNoTextBox = new System.Windows.Forms.TextBox();
            this.bankTransferTextBox = new System.Windows.Forms.TextBox();
            this.radioGroup1 = new DevExpress.XtraEditors.RadioGroup();
            this.amountReceivedTextBox = new System.Windows.Forms.TextBox();
            this.paymentDateLabel = new System.Windows.Forms.Label();
            this.paymentDateEdit = new DevExpress.XtraEditors.DateEdit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.PaymentbindingSource)).BeginInit();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.radioGroup1.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.paymentDateEdit.Properties.VistaTimeProperties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.paymentDateEdit.Properties)).BeginInit();
            this.SuspendLayout();
            // 
            // errorProvider1
            // 
            this.errorProvider1.ContainerControl = this;
            // 
            // PaymentbindingSource
            // 
            this.PaymentbindingSource.DataSource = typeof(ClearOffice.Wms.Business.PaymentRecord);
            // 
            // amountReceivedLabel
            // 
            this.amountReceivedLabel.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.amountReceivedLabel.AutoSize = true;
            this.amountReceivedLabel.Location = new System.Drawing.Point(23, 8);
            this.amountReceivedLabel.Name = "amountReceivedLabel";
            this.amountReceivedLabel.Size = new System.Drawing.Size(95, 13);
            this.amountReceivedLabel.TabIndex = 43;
            this.amountReceivedLabel.Text = "Amount Received:";
            // 
            // groupBox1
            // 
            this.groupBox1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.groupBox1.Controls.Add(this.btnpySave);
            this.groupBox1.Controls.Add(this.othersTextBox);
            this.groupBox1.Controls.Add(this.btnCancel);
            this.groupBox1.Controls.Add(this.checkNoTextBox);
            this.groupBox1.Controls.Add(this.bankTransferTextBox);
            this.groupBox1.Controls.Add(this.radioGroup1);
            this.groupBox1.Location = new System.Drawing.Point(14, 60);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(388, 149);
            this.groupBox1.TabIndex = 40;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Payment Method";
            // 
            // btnpySave
            // 
            this.btnpySave.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnpySave.Location = new System.Drawing.Point(143, 118);
            this.btnpySave.Name = "btnpySave";
            this.btnpySave.Size = new System.Drawing.Size(75, 23);
            this.btnpySave.TabIndex = 46;
            this.btnpySave.Text = "Save";
            this.btnpySave.UseVisualStyleBackColor = true;
            this.btnpySave.Click += new System.EventHandler(this.btnpySave_Click);
            // 
            // othersTextBox
            // 
            this.othersTextBox.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.othersTextBox.Enabled = false;
            this.othersTextBox.Location = new System.Drawing.Point(128, 91);
            this.othersTextBox.Name = "othersTextBox";
            this.othersTextBox.Size = new System.Drawing.Size(254, 21);
            this.othersTextBox.TabIndex = 4;
            // 
            // btnCancel
            // 
            this.btnCancel.Location = new System.Drawing.Point(233, 118);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(75, 23);
            this.btnCancel.TabIndex = 47;
            this.btnCancel.Text = "Cancel";
            this.btnCancel.UseVisualStyleBackColor = true;
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // checkNoTextBox
            // 
            this.checkNoTextBox.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.checkNoTextBox.Enabled = false;
            this.checkNoTextBox.Location = new System.Drawing.Point(128, 39);
            this.checkNoTextBox.Name = "checkNoTextBox";
            this.checkNoTextBox.Size = new System.Drawing.Size(254, 21);
            this.checkNoTextBox.TabIndex = 3;
            // 
            // bankTransferTextBox
            // 
            this.bankTransferTextBox.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.bankTransferTextBox.Enabled = false;
            this.bankTransferTextBox.Location = new System.Drawing.Point(128, 66);
            this.bankTransferTextBox.Name = "bankTransferTextBox";
            this.bankTransferTextBox.Size = new System.Drawing.Size(254, 21);
            this.bankTransferTextBox.TabIndex = 2;
            // 
            // radioGroup1
            // 
            this.radioGroup1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.radioGroup1.DataBindings.Add(new System.Windows.Forms.Binding("EditValue", this.PaymentbindingSource, "PaymentMethod", true));
            this.radioGroup1.Location = new System.Drawing.Point(12, 10);
            this.radioGroup1.Name = "radioGroup1";
            this.radioGroup1.Properties.Appearance.BackColor = System.Drawing.Color.Transparent;
            this.radioGroup1.Properties.Appearance.Options.UseBackColor = true;
            this.radioGroup1.Properties.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.NoBorder;
            this.radioGroup1.Properties.Items.AddRange(new DevExpress.XtraEditors.Controls.RadioGroupItem[] {
            new DevExpress.XtraEditors.Controls.RadioGroupItem(5, "Cash"),
            new DevExpress.XtraEditors.Controls.RadioGroupItem(6, "Check #"),
            new DevExpress.XtraEditors.Controls.RadioGroupItem(7, "Bank Transfer"),
            new DevExpress.XtraEditors.Controls.RadioGroupItem(8, "Others")});
            this.radioGroup1.Size = new System.Drawing.Size(110, 107);
            this.radioGroup1.TabIndex = 0;
            this.radioGroup1.SelectedIndexChanged += new System.EventHandler(this.radioGroup1_SelectedIndexChanged);
            // 
            // amountReceivedTextBox
            // 
            this.amountReceivedTextBox.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.amountReceivedTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.PaymentbindingSource, "AmountReceived", true));
            this.amountReceivedTextBox.Location = new System.Drawing.Point(117, 8);
            this.amountReceivedTextBox.Name = "amountReceivedTextBox";
            this.amountReceivedTextBox.Size = new System.Drawing.Size(279, 21);
            this.amountReceivedTextBox.TabIndex = 39;
            // 
            // paymentDateLabel
            // 
            this.paymentDateLabel.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.paymentDateLabel.AutoSize = true;
            this.paymentDateLabel.Location = new System.Drawing.Point(23, 37);
            this.paymentDateLabel.Name = "paymentDateLabel";
            this.paymentDateLabel.Size = new System.Drawing.Size(79, 13);
            this.paymentDateLabel.TabIndex = 41;
            this.paymentDateLabel.Text = "Payment Date:";
            // 
            // paymentDateEdit
            // 
            this.paymentDateEdit.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.paymentDateEdit.DataBindings.Add(new System.Windows.Forms.Binding("EditValue", this.PaymentbindingSource, "PaymentDate", true));
            this.paymentDateEdit.EditValue = null;
            this.paymentDateEdit.Location = new System.Drawing.Point(117, 34);
            this.paymentDateEdit.Name = "paymentDateEdit";
            this.paymentDateEdit.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.paymentDateEdit.Properties.VistaTimeProperties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton()});
            this.paymentDateEdit.Size = new System.Drawing.Size(279, 20);
            this.paymentDateEdit.TabIndex = 42;
            // 
            // NewPayment
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(416, 218);
            this.Controls.Add(this.amountReceivedLabel);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.amountReceivedTextBox);
            this.Controls.Add(this.paymentDateLabel);
            this.Controls.Add(this.paymentDateEdit);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "NewPayment";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Payment";
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.PaymentbindingSource)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.radioGroup1.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.paymentDateEdit.Properties.VistaTimeProperties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.paymentDateEdit.Properties)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ErrorProvider errorProvider1;
        private System.Windows.Forms.BindingSource PaymentbindingSource;
        private System.Windows.Forms.Label amountReceivedLabel;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox amountReceivedTextBox;
        private System.Windows.Forms.Label paymentDateLabel;
        private DevExpress.XtraEditors.DateEdit paymentDateEdit;
        private System.Windows.Forms.Button btnpySave;
        private System.Windows.Forms.TextBox othersTextBox;
        private System.Windows.Forms.Button btnCancel;
        private System.Windows.Forms.TextBox checkNoTextBox;
        private System.Windows.Forms.TextBox bankTransferTextBox;
        private DevExpress.XtraEditors.RadioGroup radioGroup1;


    }
}