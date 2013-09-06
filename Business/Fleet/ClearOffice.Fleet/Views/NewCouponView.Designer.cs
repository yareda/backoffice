namespace ClearOffice.Fleet.Views
{
    partial class NewCouponView
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
            this.addCommand = new DevExpress.XtraEditors.SimpleButton();
            this.cancelCommand = new DevExpress.XtraEditors.SimpleButton();
            this.layoutControl1 = new DevExpress.XtraLayout.LayoutControl();
            this.cashValueTextEdit = new DevExpress.XtraEditors.TextEdit();
            this.couponBindingSource = new System.Windows.Forms.BindingSource();
            this.remarkMemoEdit = new DevExpress.XtraEditors.MemoEdit();
            this.datePurchasedDateEdit = new DevExpress.XtraEditors.DateEdit();
            this.purchasedFromTextEdit = new DevExpress.XtraEditors.TextEdit();
            this.couponLabelMemoEdit = new DevExpress.XtraEditors.TextEdit();
            this.layoutControlGroup1 = new DevExpress.XtraLayout.LayoutControlGroup();
            this.layoutControlItem2 = new DevExpress.XtraLayout.LayoutControlItem();
            this.layoutControlItem3 = new DevExpress.XtraLayout.LayoutControlItem();
            this.layoutControlItem4 = new DevExpress.XtraLayout.LayoutControlItem();
            this.layoutControlItem5 = new DevExpress.XtraLayout.LayoutControlItem();
            this.layoutControlItem6 = new DevExpress.XtraLayout.LayoutControlItem();
            this.errorProvider1 = new System.Windows.Forms.ErrorProvider();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControl1)).BeginInit();
            this.layoutControl1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.cashValueTextEdit.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.couponBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.remarkMemoEdit.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.datePurchasedDateEdit.Properties.VistaTimeProperties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.datePurchasedDateEdit.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.purchasedFromTextEdit.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.couponLabelMemoEdit.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlGroup1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem5)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem6)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).BeginInit();
            this.SuspendLayout();
            // 
            // addCommand
            // 
            this.addCommand.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.addCommand.Location = new System.Drawing.Point(185, 249);
            this.addCommand.Name = "addCommand";
            this.addCommand.Size = new System.Drawing.Size(94, 23);
            this.addCommand.TabIndex = 0;
            this.addCommand.Text = "Add";
            this.addCommand.Click += new System.EventHandler(this.addCommand_Click);
            // 
            // cancelCommand
            // 
            this.cancelCommand.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.cancelCommand.Location = new System.Drawing.Point(285, 249);
            this.cancelCommand.Name = "cancelCommand";
            this.cancelCommand.Size = new System.Drawing.Size(94, 23);
            this.cancelCommand.TabIndex = 1;
            this.cancelCommand.Text = "Cancel";
            this.cancelCommand.Click += new System.EventHandler(this.cancelCommand_Click);
            // 
            // layoutControl1
            // 
            this.layoutControl1.Controls.Add(this.cashValueTextEdit);
            this.layoutControl1.Controls.Add(this.remarkMemoEdit);
            this.layoutControl1.Controls.Add(this.datePurchasedDateEdit);
            this.layoutControl1.Controls.Add(this.purchasedFromTextEdit);
            this.layoutControl1.Controls.Add(this.couponLabelMemoEdit);
            this.layoutControl1.Location = new System.Drawing.Point(0, 0);
            this.layoutControl1.Margin = new System.Windows.Forms.Padding(10);
            this.layoutControl1.Name = "layoutControl1";
            this.layoutControl1.OptionsCustomizationForm.DesignTimeCustomizationFormPositionAndSize = new System.Drawing.Rectangle(564, 58, 250, 350);
            this.layoutControl1.Root = this.layoutControlGroup1;
            this.layoutControl1.Size = new System.Drawing.Size(564, 247);
            this.layoutControl1.TabIndex = 2;
            this.layoutControl1.Text = "layoutControl1";
            // 
            // cashValueTextEdit
            // 
            this.cashValueTextEdit.DataBindings.Add(new System.Windows.Forms.Binding("EditValue", this.couponBindingSource, "CashValue", true));
            this.cashValueTextEdit.Location = new System.Drawing.Point(96, 84);
            this.cashValueTextEdit.Name = "cashValueTextEdit";
            this.cashValueTextEdit.Size = new System.Drawing.Size(456, 20);
            this.cashValueTextEdit.StyleController = this.layoutControl1;
            this.cashValueTextEdit.TabIndex = 9;
            // 
            // couponBindingSource
            // 
            this.couponBindingSource.DataSource = typeof(ClearOffice.Fleet.Business.Coupon);
            this.couponBindingSource.CurrentItemChanged += new System.EventHandler(this.couponBindingSource_CurrentItemChanged);
            // 
            // remarkMemoEdit
            // 
            this.remarkMemoEdit.DataBindings.Add(new System.Windows.Forms.Binding("EditValue", this.couponBindingSource, "Remark", true));
            this.remarkMemoEdit.Location = new System.Drawing.Point(96, 108);
            this.remarkMemoEdit.Name = "remarkMemoEdit";
            this.remarkMemoEdit.Size = new System.Drawing.Size(456, 127);
            this.remarkMemoEdit.StyleController = this.layoutControl1;
            this.remarkMemoEdit.TabIndex = 8;
            // 
            // datePurchasedDateEdit
            // 
            this.datePurchasedDateEdit.DataBindings.Add(new System.Windows.Forms.Binding("EditValue", this.couponBindingSource, "DatePurchased", true));
            this.datePurchasedDateEdit.EditValue = null;
            this.datePurchasedDateEdit.Location = new System.Drawing.Point(96, 60);
            this.datePurchasedDateEdit.Name = "datePurchasedDateEdit";
            this.datePurchasedDateEdit.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.datePurchasedDateEdit.Properties.VistaTimeProperties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton()});
            this.datePurchasedDateEdit.Size = new System.Drawing.Size(456, 20);
            this.datePurchasedDateEdit.StyleController = this.layoutControl1;
            this.datePurchasedDateEdit.TabIndex = 7;
            // 
            // purchasedFromTextEdit
            // 
            this.purchasedFromTextEdit.DataBindings.Add(new System.Windows.Forms.Binding("EditValue", this.couponBindingSource, "PurchasedFrom", true));
            this.purchasedFromTextEdit.Location = new System.Drawing.Point(96, 36);
            this.purchasedFromTextEdit.Name = "purchasedFromTextEdit";
            this.purchasedFromTextEdit.Size = new System.Drawing.Size(456, 20);
            this.purchasedFromTextEdit.StyleController = this.layoutControl1;
            this.purchasedFromTextEdit.TabIndex = 6;
            // 
            // couponLabelMemoEdit
            // 
            this.couponLabelMemoEdit.DataBindings.Add(new System.Windows.Forms.Binding("EditValue", this.couponBindingSource, "CouponLabel", true));
            this.couponLabelMemoEdit.Location = new System.Drawing.Point(96, 12);
            this.couponLabelMemoEdit.Name = "couponLabelMemoEdit";
            this.couponLabelMemoEdit.Size = new System.Drawing.Size(456, 20);
            this.couponLabelMemoEdit.StyleController = this.layoutControl1;
            this.couponLabelMemoEdit.TabIndex = 5;
            // 
            // layoutControlGroup1
            // 
            this.layoutControlGroup1.CustomizationFormText = "layoutControlGroup1";
            this.layoutControlGroup1.EnableIndentsWithoutBorders = DevExpress.Utils.DefaultBoolean.True;
            this.layoutControlGroup1.GroupBordersVisible = false;
            this.layoutControlGroup1.Items.AddRange(new DevExpress.XtraLayout.BaseLayoutItem[] {
            this.layoutControlItem2,
            this.layoutControlItem3,
            this.layoutControlItem4,
            this.layoutControlItem5,
            this.layoutControlItem6});
            this.layoutControlGroup1.Location = new System.Drawing.Point(0, 0);
            this.layoutControlGroup1.Name = "layoutControlGroup1";
            this.layoutControlGroup1.Size = new System.Drawing.Size(564, 247);
            this.layoutControlGroup1.Spacing = new DevExpress.XtraLayout.Utils.Padding(0, 0, 0, 0);
            this.layoutControlGroup1.Text = "layoutControlGroup1";
            this.layoutControlGroup1.TextVisible = false;
            // 
            // layoutControlItem2
            // 
            this.layoutControlItem2.Control = this.couponLabelMemoEdit;
            this.layoutControlItem2.CustomizationFormText = "Coupon Label:";
            this.layoutControlItem2.Location = new System.Drawing.Point(0, 0);
            this.layoutControlItem2.Name = "layoutControlItem2";
            this.layoutControlItem2.Size = new System.Drawing.Size(544, 24);
            this.layoutControlItem2.Text = "Coupon Label:";
            this.layoutControlItem2.TextSize = new System.Drawing.Size(81, 13);
            // 
            // layoutControlItem3
            // 
            this.layoutControlItem3.Control = this.purchasedFromTextEdit;
            this.layoutControlItem3.CustomizationFormText = "Purchased From:";
            this.layoutControlItem3.Location = new System.Drawing.Point(0, 24);
            this.layoutControlItem3.Name = "layoutControlItem3";
            this.layoutControlItem3.Size = new System.Drawing.Size(544, 24);
            this.layoutControlItem3.Text = "Purchased From:";
            this.layoutControlItem3.TextSize = new System.Drawing.Size(81, 13);
            // 
            // layoutControlItem4
            // 
            this.layoutControlItem4.Control = this.datePurchasedDateEdit;
            this.layoutControlItem4.CustomizationFormText = "Date Purchased:";
            this.layoutControlItem4.Location = new System.Drawing.Point(0, 48);
            this.layoutControlItem4.Name = "layoutControlItem4";
            this.layoutControlItem4.Size = new System.Drawing.Size(544, 24);
            this.layoutControlItem4.Text = "Date Purchased:";
            this.layoutControlItem4.TextSize = new System.Drawing.Size(81, 13);
            // 
            // layoutControlItem5
            // 
            this.layoutControlItem5.Control = this.remarkMemoEdit;
            this.layoutControlItem5.CustomizationFormText = "Remark:";
            this.layoutControlItem5.Location = new System.Drawing.Point(0, 96);
            this.layoutControlItem5.Name = "layoutControlItem5";
            this.layoutControlItem5.Size = new System.Drawing.Size(544, 131);
            this.layoutControlItem5.Text = "Remark:";
            this.layoutControlItem5.TextSize = new System.Drawing.Size(81, 13);
            // 
            // layoutControlItem6
            // 
            this.layoutControlItem6.Control = this.cashValueTextEdit;
            this.layoutControlItem6.CustomizationFormText = "Cash Value:";
            this.layoutControlItem6.Location = new System.Drawing.Point(0, 72);
            this.layoutControlItem6.Name = "layoutControlItem6";
            this.layoutControlItem6.Size = new System.Drawing.Size(544, 24);
            this.layoutControlItem6.Text = "Cash Value:";
            this.layoutControlItem6.TextSize = new System.Drawing.Size(81, 13);
            // 
            // errorProvider1
            // 
            this.errorProvider1.ContainerControl = this;
            this.errorProvider1.DataSource = this.couponBindingSource;
            // 
            // NewCouponView
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(564, 281);
            this.Controls.Add(this.layoutControl1);
            this.Controls.Add(this.cancelCommand);
            this.Controls.Add(this.addCommand);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "NewCouponView";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "New Coupon";
            ((System.ComponentModel.ISupportInitialize)(this.layoutControl1)).EndInit();
            this.layoutControl1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.cashValueTextEdit.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.couponBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.remarkMemoEdit.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.datePurchasedDateEdit.Properties.VistaTimeProperties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.datePurchasedDateEdit.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.purchasedFromTextEdit.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.couponLabelMemoEdit.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlGroup1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem5)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem6)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.BindingSource couponBindingSource;
        private DevExpress.XtraEditors.SimpleButton addCommand;
        private DevExpress.XtraEditors.SimpleButton cancelCommand;
        private DevExpress.XtraLayout.LayoutControl layoutControl1;
        private DevExpress.XtraEditors.MemoEdit remarkMemoEdit;
        private DevExpress.XtraEditors.DateEdit datePurchasedDateEdit;
        private DevExpress.XtraEditors.TextEdit purchasedFromTextEdit;
        private DevExpress.XtraLayout.LayoutControlGroup layoutControlGroup1;
        private DevExpress.XtraLayout.LayoutControlItem layoutControlItem2;
        private DevExpress.XtraLayout.LayoutControlItem layoutControlItem3;
        private DevExpress.XtraLayout.LayoutControlItem layoutControlItem4;
        private DevExpress.XtraLayout.LayoutControlItem layoutControlItem5;
        private System.Windows.Forms.ErrorProvider errorProvider1;
        private DevExpress.XtraEditors.TextEdit cashValueTextEdit;
        private DevExpress.XtraEditors.TextEdit couponLabelMemoEdit;
        private DevExpress.XtraLayout.LayoutControlItem layoutControlItem6;
    }
}