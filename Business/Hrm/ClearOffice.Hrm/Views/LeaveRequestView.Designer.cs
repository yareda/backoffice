namespace ClearOffice.Hrm.Views
{
    partial class LeaveRequestView
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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.layoutControl1 = new DevExpress.XtraLayout.LayoutControl();
            this.requestDateDateEdit = new DevExpress.XtraEditors.DateEdit();
            this.requestBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.remarkMemoEdit = new DevExpress.XtraEditors.MemoEdit();
            this.toDateEdit = new DevExpress.XtraEditors.DateEdit();
            this.fromDateEdit = new DevExpress.XtraEditors.DateEdit();
            this.currentLeaveDaysTextEdit = new DevExpress.XtraEditors.TextEdit();
            this.employeeBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.numDaysTextEdit = new DevExpress.XtraEditors.TextEdit();
            this.layoutControlGroup1 = new DevExpress.XtraLayout.LayoutControlGroup();
            this.layoutControlItem2 = new DevExpress.XtraLayout.LayoutControlItem();
            this.layoutControlItem3 = new DevExpress.XtraLayout.LayoutControlItem();
            this.layoutControlItem4 = new DevExpress.XtraLayout.LayoutControlItem();
            this.layoutControlItem5 = new DevExpress.XtraLayout.LayoutControlItem();
            this.layoutControlItem6 = new DevExpress.XtraLayout.LayoutControlItem();
            this.layoutControlItem7 = new DevExpress.XtraLayout.LayoutControlItem();
            this.btnRequest = new DevExpress.XtraEditors.SimpleButton();
            this.btnCancel = new DevExpress.XtraEditors.SimpleButton();
            this.requestErrorProvider = new System.Windows.Forms.ErrorProvider(this.components);
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControl1)).BeginInit();
            this.layoutControl1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.requestDateDateEdit.Properties.VistaTimeProperties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.requestDateDateEdit.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.requestBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.remarkMemoEdit.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.toDateEdit.Properties.VistaTimeProperties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.toDateEdit.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.fromDateEdit.Properties.VistaTimeProperties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.fromDateEdit.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.currentLeaveDaysTextEdit.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.employeeBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numDaysTextEdit.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlGroup1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem5)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem6)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem7)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.requestErrorProvider)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBox1.Controls.Add(this.layoutControl1);
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(456, 202);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Leave Request";
            // 
            // layoutControl1
            // 
            this.layoutControl1.Controls.Add(this.requestDateDateEdit);
            this.layoutControl1.Controls.Add(this.remarkMemoEdit);
            this.layoutControl1.Controls.Add(this.toDateEdit);
            this.layoutControl1.Controls.Add(this.fromDateEdit);
            this.layoutControl1.Controls.Add(this.currentLeaveDaysTextEdit);
            this.layoutControl1.Controls.Add(this.numDaysTextEdit);
            this.layoutControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.layoutControl1.Location = new System.Drawing.Point(3, 17);
            this.layoutControl1.Name = "layoutControl1";
            this.layoutControl1.Root = this.layoutControlGroup1;
            this.layoutControl1.Size = new System.Drawing.Size(450, 182);
            this.layoutControl1.TabIndex = 0;
            this.layoutControl1.Text = "layoutControl1";
            // 
            // requestDateDateEdit
            // 
            this.requestDateDateEdit.DataBindings.Add(new System.Windows.Forms.Binding("EditValue", this.requestBindingSource, "RequestDate", true));
            this.requestDateDateEdit.EditValue = null;
            this.requestDateDateEdit.Location = new System.Drawing.Point(99, 60);
            this.requestDateDateEdit.Name = "requestDateDateEdit";
            this.requestDateDateEdit.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.requestDateDateEdit.Properties.VistaTimeProperties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton()});
            this.requestDateDateEdit.Size = new System.Drawing.Size(339, 20);
            this.requestDateDateEdit.StyleController = this.layoutControl1;
            this.requestDateDateEdit.TabIndex = 10;
            // 
            // requestBindingSource
            // 
            this.requestBindingSource.DataSource = typeof(ClearOffice.Hrm.Business.Data.EmployeePto);
            // 
            // remarkMemoEdit
            // 
            this.remarkMemoEdit.DataBindings.Add(new System.Windows.Forms.Binding("EditValue", this.requestBindingSource, "Remark", true));
            this.remarkMemoEdit.Location = new System.Drawing.Point(99, 84);
            this.remarkMemoEdit.Name = "remarkMemoEdit";
            this.remarkMemoEdit.Size = new System.Drawing.Size(339, 86);
            this.remarkMemoEdit.StyleController = this.layoutControl1;
            this.remarkMemoEdit.TabIndex = 9;
            // 
            // toDateEdit
            // 
            this.toDateEdit.DataBindings.Add(new System.Windows.Forms.Binding("EditValue", this.requestBindingSource, "To", true));
            this.toDateEdit.EditValue = null;
            this.toDateEdit.Location = new System.Drawing.Point(314, 36);
            this.toDateEdit.Name = "toDateEdit";
            this.toDateEdit.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.toDateEdit.Properties.VistaTimeProperties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton()});
            this.toDateEdit.Size = new System.Drawing.Size(124, 20);
            this.toDateEdit.StyleController = this.layoutControl1;
            this.toDateEdit.TabIndex = 8;
            // 
            // fromDateEdit
            // 
            this.fromDateEdit.DataBindings.Add(new System.Windows.Forms.Binding("EditValue", this.requestBindingSource, "From", true));
            this.fromDateEdit.EditValue = null;
            this.fromDateEdit.Location = new System.Drawing.Point(99, 36);
            this.fromDateEdit.Name = "fromDateEdit";
            this.fromDateEdit.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.fromDateEdit.Properties.VistaTimeProperties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton()});
            this.fromDateEdit.Size = new System.Drawing.Size(124, 20);
            this.fromDateEdit.StyleController = this.layoutControl1;
            this.fromDateEdit.TabIndex = 7;
            // 
            // currentLeaveDaysTextEdit
            // 
            this.currentLeaveDaysTextEdit.DataBindings.Add(new System.Windows.Forms.Binding("EditValue", this.employeeBindingSource, "CurrentLeaveDays", true));
            this.currentLeaveDaysTextEdit.Enabled = false;
            this.currentLeaveDaysTextEdit.Location = new System.Drawing.Point(388, 12);
            this.currentLeaveDaysTextEdit.Name = "currentLeaveDaysTextEdit";
            this.currentLeaveDaysTextEdit.Size = new System.Drawing.Size(50, 20);
            this.currentLeaveDaysTextEdit.StyleController = this.layoutControl1;
            this.currentLeaveDaysTextEdit.TabIndex = 6;
            // 
            // employeeBindingSource
            // 
            this.employeeBindingSource.DataSource = typeof(ClearOffice.Hrm.Business.Data.Employee);
            // 
            // numDaysTextEdit
            // 
            this.numDaysTextEdit.DataBindings.Add(new System.Windows.Forms.Binding("EditValue", this.requestBindingSource, "NumDays", true));
            this.numDaysTextEdit.Location = new System.Drawing.Point(99, 12);
            this.numDaysTextEdit.Name = "numDaysTextEdit";
            this.numDaysTextEdit.Size = new System.Drawing.Size(198, 20);
            this.numDaysTextEdit.StyleController = this.layoutControl1;
            this.numDaysTextEdit.TabIndex = 5;
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
            this.layoutControlItem6,
            this.layoutControlItem7});
            this.layoutControlGroup1.Location = new System.Drawing.Point(0, 0);
            this.layoutControlGroup1.Name = "layoutControlGroup1";
            this.layoutControlGroup1.Size = new System.Drawing.Size(450, 182);
            this.layoutControlGroup1.Spacing = new DevExpress.XtraLayout.Utils.Padding(0, 0, 0, 0);
            this.layoutControlGroup1.Text = "layoutControlGroup1";
            this.layoutControlGroup1.TextVisible = false;
            // 
            // layoutControlItem2
            // 
            this.layoutControlItem2.Control = this.numDaysTextEdit;
            this.layoutControlItem2.CustomizationFormText = "Number Of Days:";
            this.layoutControlItem2.Location = new System.Drawing.Point(0, 0);
            this.layoutControlItem2.Name = "layoutControlItem2";
            this.layoutControlItem2.Size = new System.Drawing.Size(289, 24);
            this.layoutControlItem2.Text = "Number Of Days:";
            this.layoutControlItem2.TextSize = new System.Drawing.Size(83, 13);
            // 
            // layoutControlItem3
            // 
            this.layoutControlItem3.Control = this.currentLeaveDaysTextEdit;
            this.layoutControlItem3.CustomizationFormText = "Current Leave Days:";
            this.layoutControlItem3.Location = new System.Drawing.Point(289, 0);
            this.layoutControlItem3.Name = "layoutControlItem3";
            this.layoutControlItem3.Size = new System.Drawing.Size(141, 24);
            this.layoutControlItem3.Text = "Remaining Days:";
            this.layoutControlItem3.TextSize = new System.Drawing.Size(83, 13);
            // 
            // layoutControlItem4
            // 
            this.layoutControlItem4.Control = this.fromDateEdit;
            this.layoutControlItem4.CustomizationFormText = "From:";
            this.layoutControlItem4.Location = new System.Drawing.Point(0, 24);
            this.layoutControlItem4.Name = "layoutControlItem4";
            this.layoutControlItem4.Size = new System.Drawing.Size(215, 24);
            this.layoutControlItem4.Text = "From:";
            this.layoutControlItem4.TextSize = new System.Drawing.Size(83, 13);
            // 
            // layoutControlItem5
            // 
            this.layoutControlItem5.Control = this.toDateEdit;
            this.layoutControlItem5.CustomizationFormText = "To:";
            this.layoutControlItem5.Location = new System.Drawing.Point(215, 24);
            this.layoutControlItem5.Name = "layoutControlItem5";
            this.layoutControlItem5.Size = new System.Drawing.Size(215, 24);
            this.layoutControlItem5.Text = "To:";
            this.layoutControlItem5.TextSize = new System.Drawing.Size(83, 13);
            // 
            // layoutControlItem6
            // 
            this.layoutControlItem6.Control = this.remarkMemoEdit;
            this.layoutControlItem6.CustomizationFormText = "Remark:";
            this.layoutControlItem6.Location = new System.Drawing.Point(0, 72);
            this.layoutControlItem6.Name = "layoutControlItem6";
            this.layoutControlItem6.Size = new System.Drawing.Size(430, 90);
            this.layoutControlItem6.Text = "Remark:";
            this.layoutControlItem6.TextSize = new System.Drawing.Size(83, 13);
            // 
            // layoutControlItem7
            // 
            this.layoutControlItem7.Control = this.requestDateDateEdit;
            this.layoutControlItem7.CustomizationFormText = "Request Date:";
            this.layoutControlItem7.Location = new System.Drawing.Point(0, 48);
            this.layoutControlItem7.Name = "layoutControlItem7";
            this.layoutControlItem7.Size = new System.Drawing.Size(430, 24);
            this.layoutControlItem7.Text = "Request Date:";
            this.layoutControlItem7.TextSize = new System.Drawing.Size(83, 13);
            // 
            // btnRequest
            // 
            this.btnRequest.Location = new System.Drawing.Point(160, 220);
            this.btnRequest.Name = "btnRequest";
            this.btnRequest.Size = new System.Drawing.Size(75, 23);
            this.btnRequest.TabIndex = 1;
            this.btnRequest.Text = "Request";
            this.btnRequest.Click += new System.EventHandler(this.btnRequest_Click);
            // 
            // btnCancel
            // 
            this.btnCancel.Location = new System.Drawing.Point(241, 220);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(75, 23);
            this.btnCancel.TabIndex = 2;
            this.btnCancel.Text = "Cancel";
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // requestErrorProvider
            // 
            this.requestErrorProvider.ContainerControl = this;
            this.requestErrorProvider.DataSource = this.requestBindingSource;
            // 
            // LeaveRequestView
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(480, 247);
            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.btnRequest);
            this.Controls.Add(this.groupBox1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "LeaveRequestView";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Request Leave ";
            this.groupBox1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.layoutControl1)).EndInit();
            this.layoutControl1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.requestDateDateEdit.Properties.VistaTimeProperties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.requestDateDateEdit.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.requestBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.remarkMemoEdit.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.toDateEdit.Properties.VistaTimeProperties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.toDateEdit.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.fromDateEdit.Properties.VistaTimeProperties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.fromDateEdit.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.currentLeaveDaysTextEdit.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.employeeBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numDaysTextEdit.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlGroup1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem5)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem6)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem7)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.requestErrorProvider)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.BindingSource requestBindingSource;
        private System.Windows.Forms.GroupBox groupBox1;
        private DevExpress.XtraLayout.LayoutControl layoutControl1;
        private DevExpress.XtraEditors.MemoEdit remarkMemoEdit;
        private DevExpress.XtraEditors.DateEdit toDateEdit;
        private DevExpress.XtraEditors.DateEdit fromDateEdit;
        private DevExpress.XtraEditors.TextEdit currentLeaveDaysTextEdit;
        private System.Windows.Forms.BindingSource employeeBindingSource;
        private DevExpress.XtraEditors.TextEdit numDaysTextEdit;
        private DevExpress.XtraLayout.LayoutControlGroup layoutControlGroup1;
        private DevExpress.XtraLayout.LayoutControlItem layoutControlItem2;
        private DevExpress.XtraLayout.LayoutControlItem layoutControlItem3;
        private DevExpress.XtraLayout.LayoutControlItem layoutControlItem4;
        private DevExpress.XtraLayout.LayoutControlItem layoutControlItem5;
        private DevExpress.XtraLayout.LayoutControlItem layoutControlItem6;
        private DevExpress.XtraEditors.SimpleButton btnRequest;
        private DevExpress.XtraEditors.SimpleButton btnCancel;
        private System.Windows.Forms.ErrorProvider requestErrorProvider;
        private DevExpress.XtraEditors.DateEdit requestDateDateEdit;
        private DevExpress.XtraLayout.LayoutControlItem layoutControlItem7;
    }
}