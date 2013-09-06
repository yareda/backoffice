namespace ClearOffice.Wms.Views
{
    partial class PaymentsView
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
            this.PaymentbindingSource = new System.Windows.Forms.BindingSource();
            this.errorProvider1 = new System.Windows.Forms.ErrorProvider();
            this.paymentDateLabel = new System.Windows.Forms.Label();
            this.paymentDateEdit = new DevExpress.XtraEditors.DateEdit();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.othersTextBox = new System.Windows.Forms.TextBox();
            this.checkNoTextBox = new System.Windows.Forms.TextBox();
            this.bankTransferTextBox = new System.Windows.Forms.TextBox();
            this.radioGroup1 = new DevExpress.XtraEditors.RadioGroup();
            this.amountReceivedLabel = new System.Windows.Forms.Label();
            this.amountReceivedTextBox = new System.Windows.Forms.TextBox();
            this.btnpySave = new System.Windows.Forms.Button();
            this.btnCancel = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.PaymentbindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.paymentDateEdit.Properties.VistaTimeProperties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.paymentDateEdit.Properties)).BeginInit();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.radioGroup1.Properties)).BeginInit();
            this.SuspendLayout();
            // 
            // PaymentbindingSource
            // 
            this.PaymentbindingSource.DataSource = typeof(ClearOffice.Wms.Business.PaymentRecord);
            // 
            // errorProvider1
            // 
            this.errorProvider1.ContainerControl = this;
            // 
            // paymentDateLabel
            // 
            this.paymentDateLabel.AutoSize = true;
            this.paymentDateLabel.Location = new System.Drawing.Point(24, 41);
            this.paymentDateLabel.Name = "paymentDateLabel";
            this.paymentDateLabel.Size = new System.Drawing.Size(79, 13);
            this.paymentDateLabel.TabIndex = 29;
            this.paymentDateLabel.Text = "Payment Date:";
            // 
            // paymentDateEdit
            // 
            this.paymentDateEdit.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.paymentDateEdit.DataBindings.Add(new System.Windows.Forms.Binding("EditValue", this.PaymentbindingSource, "PaymentDate", true));
            this.paymentDateEdit.EditValue = null;
            this.paymentDateEdit.Location = new System.Drawing.Point(126, 38);
            this.paymentDateEdit.Name = "paymentDateEdit";
            this.paymentDateEdit.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.paymentDateEdit.Properties.VistaTimeProperties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton()});
            this.paymentDateEdit.Size = new System.Drawing.Size(274, 20);
            this.paymentDateEdit.TabIndex = 26;
            // 
            // groupBox1
            // 
            this.groupBox1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBox1.Controls.Add(this.othersTextBox);
            this.groupBox1.Controls.Add(this.checkNoTextBox);
            this.groupBox1.Controls.Add(this.bankTransferTextBox);
            this.groupBox1.Controls.Add(this.radioGroup1);
            this.groupBox1.Location = new System.Drawing.Point(19, 66);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(388, 114);
            this.groupBox1.TabIndex = 28;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Payment Method";
            // 
            // othersTextBox
            // 
            this.othersTextBox.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.othersTextBox.Enabled = false;
            this.othersTextBox.Location = new System.Drawing.Point(128, 86);
            this.othersTextBox.Name = "othersTextBox";
            this.othersTextBox.Size = new System.Drawing.Size(254, 21);
            this.othersTextBox.TabIndex = 1;
            // 
            // checkNoTextBox
            // 
            this.checkNoTextBox.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.checkNoTextBox.Enabled = false;
            this.checkNoTextBox.Location = new System.Drawing.Point(128, 34);
            this.checkNoTextBox.Name = "checkNoTextBox";
            this.checkNoTextBox.Size = new System.Drawing.Size(254, 21);
            this.checkNoTextBox.TabIndex = 0;
            // 
            // bankTransferTextBox
            // 
            this.bankTransferTextBox.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.bankTransferTextBox.Enabled = false;
            this.bankTransferTextBox.Location = new System.Drawing.Point(128, 60);
            this.bankTransferTextBox.Name = "bankTransferTextBox";
            this.bankTransferTextBox.Size = new System.Drawing.Size(254, 21);
            this.bankTransferTextBox.TabIndex = 0;
            // 
            // radioGroup1
            // 
            this.radioGroup1.DataBindings.Add(new System.Windows.Forms.Binding("EditValue", this.PaymentbindingSource, "PaymentMethod", true, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged));
            this.radioGroup1.Location = new System.Drawing.Point(12, 3);
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
            this.radioGroup1.TabIndex = 1;
            this.radioGroup1.SelectedIndexChanged += new System.EventHandler(this.radioGroup1_SelectedIndexChanged);
            // 
            // amountReceivedLabel
            // 
            this.amountReceivedLabel.AutoSize = true;
            this.amountReceivedLabel.Location = new System.Drawing.Point(24, 15);
            this.amountReceivedLabel.Name = "amountReceivedLabel";
            this.amountReceivedLabel.Size = new System.Drawing.Size(95, 13);
            this.amountReceivedLabel.TabIndex = 27;
            this.amountReceivedLabel.Text = "Amount Received:";
            // 
            // amountReceivedTextBox
            // 
            this.amountReceivedTextBox.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.amountReceivedTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.PaymentbindingSource, "AmountReceived", true));
            this.amountReceivedTextBox.Location = new System.Drawing.Point(126, 12);
            this.amountReceivedTextBox.Name = "amountReceivedTextBox";
            this.amountReceivedTextBox.Size = new System.Drawing.Size(274, 21);
            this.amountReceivedTextBox.TabIndex = 25;
            // 
            // btnpySave
            // 
            this.btnpySave.Location = new System.Drawing.Point(147, 186);
            this.btnpySave.Name = "btnpySave";
            this.btnpySave.Size = new System.Drawing.Size(75, 23);
            this.btnpySave.TabIndex = 30;
            this.btnpySave.Text = "Save";
            this.btnpySave.UseVisualStyleBackColor = true;
            this.btnpySave.Click += new System.EventHandler(this.btnpySave_Click);
            // 
            // btnCancel
            // 
            this.btnCancel.Location = new System.Drawing.Point(238, 186);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(75, 23);
            this.btnCancel.TabIndex = 31;
            this.btnCancel.Text = "Cancel";
            this.btnCancel.UseVisualStyleBackColor = true;
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // PaymentsView
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(419, 218);
            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.btnpySave);
            this.Controls.Add(this.paymentDateLabel);
            this.Controls.Add(this.paymentDateEdit);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.amountReceivedLabel);
            this.Controls.Add(this.amountReceivedTextBox);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "PaymentsView";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Payments View";
            ((System.ComponentModel.ISupportInitialize)(this.PaymentbindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.paymentDateEdit.Properties.VistaTimeProperties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.paymentDateEdit.Properties)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.radioGroup1.Properties)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.BindingSource PaymentbindingSource;
        private System.Windows.Forms.ErrorProvider errorProvider1;
        private System.Windows.Forms.Button btnCancel;
        private System.Windows.Forms.Button btnpySave;
        private System.Windows.Forms.Label paymentDateLabel;
        private DevExpress.XtraEditors.DateEdit paymentDateEdit;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox othersTextBox;
        private System.Windows.Forms.TextBox checkNoTextBox;
        private System.Windows.Forms.TextBox bankTransferTextBox;
        private DevExpress.XtraEditors.RadioGroup radioGroup1;
        private System.Windows.Forms.Label amountReceivedLabel;
        private System.Windows.Forms.TextBox amountReceivedTextBox;
    }
}