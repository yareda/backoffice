namespace ClearOffice.Hrm.Views
{
    partial class EmployeeWarningView
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
            this.hireDateDateEdit = new DevExpress.XtraEditors.DateEdit();
            this.employeeBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.employeeNoTextEdit = new DevExpress.XtraEditors.TextEdit();
            this.fullNameTextEdit = new DevExpress.XtraEditors.TextEdit();
            this.layoutControlGroup1 = new DevExpress.XtraLayout.LayoutControlGroup();
            this.layoutControlItem2 = new DevExpress.XtraLayout.LayoutControlItem();
            this.layoutControlItem3 = new DevExpress.XtraLayout.LayoutControlItem();
            this.layoutControlItem4 = new DevExpress.XtraLayout.LayoutControlItem();
            this.warningBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.layoutControl2 = new DevExpress.XtraLayout.LayoutControl();
            this.warningDateDateEdit = new DevExpress.XtraEditors.DateEdit();
            this.warningGivenByTextEdit = new DevExpress.XtraEditors.TextEdit();
            this.warningReasonMemoEdit = new DevExpress.XtraEditors.MemoEdit();
            this.warningTypeIdLookUpEdit = new DevExpress.XtraEditors.LookUpEdit();
            this.warningTypeBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.layoutControlGroup2 = new DevExpress.XtraLayout.LayoutControlGroup();
            this.layoutControlItem5 = new DevExpress.XtraLayout.LayoutControlItem();
            this.layoutControlItem6 = new DevExpress.XtraLayout.LayoutControlItem();
            this.layoutControlItem7 = new DevExpress.XtraLayout.LayoutControlItem();
            this.layoutControlItem8 = new DevExpress.XtraLayout.LayoutControlItem();
            this.btnSave = new DevExpress.XtraEditors.SimpleButton();
            this.simpleButton2 = new DevExpress.XtraEditors.SimpleButton();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControl1)).BeginInit();
            this.layoutControl1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.hireDateDateEdit.Properties.VistaTimeProperties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.hireDateDateEdit.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.employeeBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.employeeNoTextEdit.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.fullNameTextEdit.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlGroup1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.warningBindingSource)).BeginInit();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControl2)).BeginInit();
            this.layoutControl2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.warningDateDateEdit.Properties.VistaTimeProperties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.warningDateDateEdit.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.warningGivenByTextEdit.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.warningReasonMemoEdit.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.warningTypeIdLookUpEdit.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.warningTypeBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlGroup2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem5)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem6)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem7)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem8)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBox1.Controls.Add(this.layoutControl1);
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(505, 133);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Employment Information";
            // 
            // layoutControl1
            // 
            this.layoutControl1.Controls.Add(this.hireDateDateEdit);
            this.layoutControl1.Controls.Add(this.employeeNoTextEdit);
            this.layoutControl1.Controls.Add(this.fullNameTextEdit);
            this.layoutControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.layoutControl1.Location = new System.Drawing.Point(3, 17);
            this.layoutControl1.Name = "layoutControl1";
            this.layoutControl1.Root = this.layoutControlGroup1;
            this.layoutControl1.Size = new System.Drawing.Size(499, 113);
            this.layoutControl1.TabIndex = 0;
            this.layoutControl1.Text = "layoutControl1";
            // 
            // hireDateDateEdit
            // 
            this.hireDateDateEdit.DataBindings.Add(new System.Windows.Forms.Binding("EditValue", this.employeeBindingSource, "HireDate", true));
            this.hireDateDateEdit.EditValue = null;
            this.hireDateDateEdit.Enabled = false;
            this.hireDateDateEdit.Location = new System.Drawing.Point(113, 60);
            this.hireDateDateEdit.Name = "hireDateDateEdit";
            this.hireDateDateEdit.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.hireDateDateEdit.Properties.VistaTimeProperties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton()});
            this.hireDateDateEdit.Size = new System.Drawing.Size(374, 20);
            this.hireDateDateEdit.StyleController = this.layoutControl1;
            this.hireDateDateEdit.TabIndex = 7;
            // 
            // employeeBindingSource
            // 
            this.employeeBindingSource.DataSource = typeof(ClearOffice.Hrm.Business.Data.EmployeeInfo);
            // 
            // employeeNoTextEdit
            // 
            this.employeeNoTextEdit.DataBindings.Add(new System.Windows.Forms.Binding("EditValue", this.employeeBindingSource, "EmployeeNo", true));
            this.employeeNoTextEdit.Enabled = false;
            this.employeeNoTextEdit.Location = new System.Drawing.Point(113, 36);
            this.employeeNoTextEdit.Name = "employeeNoTextEdit";
            this.employeeNoTextEdit.Size = new System.Drawing.Size(374, 20);
            this.employeeNoTextEdit.StyleController = this.layoutControl1;
            this.employeeNoTextEdit.TabIndex = 6;
            // 
            // fullNameTextEdit
            // 
            this.fullNameTextEdit.DataBindings.Add(new System.Windows.Forms.Binding("EditValue", this.employeeBindingSource, "FullName", true));
            this.fullNameTextEdit.Enabled = false;
            this.fullNameTextEdit.Location = new System.Drawing.Point(113, 12);
            this.fullNameTextEdit.Name = "fullNameTextEdit";
            this.fullNameTextEdit.Size = new System.Drawing.Size(374, 20);
            this.fullNameTextEdit.StyleController = this.layoutControl1;
            this.fullNameTextEdit.TabIndex = 5;
            // 
            // layoutControlGroup1
            // 
            this.layoutControlGroup1.CustomizationFormText = "layoutControlGroup1";
            this.layoutControlGroup1.EnableIndentsWithoutBorders = DevExpress.Utils.DefaultBoolean.True;
            this.layoutControlGroup1.GroupBordersVisible = false;
            this.layoutControlGroup1.Items.AddRange(new DevExpress.XtraLayout.BaseLayoutItem[] {
            this.layoutControlItem2,
            this.layoutControlItem3,
            this.layoutControlItem4});
            this.layoutControlGroup1.Location = new System.Drawing.Point(0, 0);
            this.layoutControlGroup1.Name = "layoutControlGroup1";
            this.layoutControlGroup1.Size = new System.Drawing.Size(499, 113);
            this.layoutControlGroup1.Spacing = new DevExpress.XtraLayout.Utils.Padding(0, 0, 0, 0);
            this.layoutControlGroup1.Text = "layoutControlGroup1";
            this.layoutControlGroup1.TextVisible = false;
            // 
            // layoutControlItem2
            // 
            this.layoutControlItem2.Control = this.fullNameTextEdit;
            this.layoutControlItem2.CustomizationFormText = "Employee full Name:";
            this.layoutControlItem2.Location = new System.Drawing.Point(0, 0);
            this.layoutControlItem2.Name = "layoutControlItem2";
            this.layoutControlItem2.Size = new System.Drawing.Size(479, 24);
            this.layoutControlItem2.Text = "Employee full Name:";
            this.layoutControlItem2.TextSize = new System.Drawing.Size(97, 13);
            // 
            // layoutControlItem3
            // 
            this.layoutControlItem3.Control = this.employeeNoTextEdit;
            this.layoutControlItem3.CustomizationFormText = "Employee No:";
            this.layoutControlItem3.Location = new System.Drawing.Point(0, 24);
            this.layoutControlItem3.Name = "layoutControlItem3";
            this.layoutControlItem3.Size = new System.Drawing.Size(479, 24);
            this.layoutControlItem3.Text = "Employee No:";
            this.layoutControlItem3.TextSize = new System.Drawing.Size(97, 13);
            // 
            // layoutControlItem4
            // 
            this.layoutControlItem4.Control = this.hireDateDateEdit;
            this.layoutControlItem4.CustomizationFormText = "Hire Date:";
            this.layoutControlItem4.Location = new System.Drawing.Point(0, 48);
            this.layoutControlItem4.Name = "layoutControlItem4";
            this.layoutControlItem4.Size = new System.Drawing.Size(479, 45);
            this.layoutControlItem4.Text = "Hire Date:";
            this.layoutControlItem4.TextSize = new System.Drawing.Size(97, 13);
            // 
            // warningBindingSource
            // 
            this.warningBindingSource.DataSource = typeof(ClearOffice.Hrm.Business.Data.EmployeeWarning);
            this.warningBindingSource.CurrentItemChanged += new System.EventHandler(this.warningBindingSource_CurrentItemChanged);
            // 
            // groupBox2
            // 
            this.groupBox2.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBox2.Controls.Add(this.layoutControl2);
            this.groupBox2.Location = new System.Drawing.Point(15, 151);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(502, 150);
            this.groupBox2.TabIndex = 1;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Warning";
            // 
            // layoutControl2
            // 
            this.layoutControl2.Controls.Add(this.warningDateDateEdit);
            this.layoutControl2.Controls.Add(this.warningGivenByTextEdit);
            this.layoutControl2.Controls.Add(this.warningReasonMemoEdit);
            this.layoutControl2.Controls.Add(this.warningTypeIdLookUpEdit);
            this.layoutControl2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.layoutControl2.Location = new System.Drawing.Point(3, 17);
            this.layoutControl2.Name = "layoutControl2";
            this.layoutControl2.Root = this.layoutControlGroup2;
            this.layoutControl2.Size = new System.Drawing.Size(496, 130);
            this.layoutControl2.TabIndex = 0;
            this.layoutControl2.Text = "layoutControl2";
            // 
            // warningDateDateEdit
            // 
            this.warningDateDateEdit.DataBindings.Add(new System.Windows.Forms.Binding("EditValue", this.warningBindingSource, "WarningDate", true));
            this.warningDateDateEdit.EditValue = null;
            this.warningDateDateEdit.Location = new System.Drawing.Point(343, 98);
            this.warningDateDateEdit.Name = "warningDateDateEdit";
            this.warningDateDateEdit.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.warningDateDateEdit.Properties.VistaTimeProperties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton()});
            this.warningDateDateEdit.Size = new System.Drawing.Size(141, 20);
            this.warningDateDateEdit.StyleController = this.layoutControl2;
            this.warningDateDateEdit.TabIndex = 8;
            // 
            // warningGivenByTextEdit
            // 
            this.warningGivenByTextEdit.DataBindings.Add(new System.Windows.Forms.Binding("EditValue", this.warningBindingSource, "WarningGivenBy", true));
            this.warningGivenByTextEdit.Location = new System.Drawing.Point(105, 98);
            this.warningGivenByTextEdit.Name = "warningGivenByTextEdit";
            this.warningGivenByTextEdit.Size = new System.Drawing.Size(141, 20);
            this.warningGivenByTextEdit.StyleController = this.layoutControl2;
            this.warningGivenByTextEdit.TabIndex = 7;
            // 
            // warningReasonMemoEdit
            // 
            this.warningReasonMemoEdit.DataBindings.Add(new System.Windows.Forms.Binding("EditValue", this.warningBindingSource, "WarningReason", true));
            this.warningReasonMemoEdit.Location = new System.Drawing.Point(105, 36);
            this.warningReasonMemoEdit.Name = "warningReasonMemoEdit";
            this.warningReasonMemoEdit.Size = new System.Drawing.Size(379, 58);
            this.warningReasonMemoEdit.StyleController = this.layoutControl2;
            this.warningReasonMemoEdit.TabIndex = 6;
            // 
            // warningTypeIdLookUpEdit
            // 
            this.warningTypeIdLookUpEdit.DataBindings.Add(new System.Windows.Forms.Binding("EditValue", this.warningBindingSource, "WarningTypeId", true));
            this.warningTypeIdLookUpEdit.Location = new System.Drawing.Point(105, 12);
            this.warningTypeIdLookUpEdit.Name = "warningTypeIdLookUpEdit";
            this.warningTypeIdLookUpEdit.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.warningTypeIdLookUpEdit.Properties.Columns.AddRange(new DevExpress.XtraEditors.Controls.LookUpColumnInfo[] {
            new DevExpress.XtraEditors.Controls.LookUpColumnInfo("WarningTypeName", "Warning Types", 107, DevExpress.Utils.FormatType.None, "", true, DevExpress.Utils.HorzAlignment.Near)});
            this.warningTypeIdLookUpEdit.Properties.DataSource = this.warningTypeBindingSource;
            this.warningTypeIdLookUpEdit.Properties.DisplayMember = "WarningTypeName";
            this.warningTypeIdLookUpEdit.Properties.NullText = "[Select Warning Type]";
            this.warningTypeIdLookUpEdit.Properties.ValueMember = "WarningTypeId";
            this.warningTypeIdLookUpEdit.Size = new System.Drawing.Size(379, 20);
            this.warningTypeIdLookUpEdit.StyleController = this.layoutControl2;
            this.warningTypeIdLookUpEdit.TabIndex = 5;
            // 
            // warningTypeBindingSource
            // 
            this.warningTypeBindingSource.DataSource = typeof(ClearOffice.Hrm.Business.Data.WarningType);
            // 
            // layoutControlGroup2
            // 
            this.layoutControlGroup2.CustomizationFormText = "layoutControlGroup2";
            this.layoutControlGroup2.EnableIndentsWithoutBorders = DevExpress.Utils.DefaultBoolean.True;
            this.layoutControlGroup2.GroupBordersVisible = false;
            this.layoutControlGroup2.Items.AddRange(new DevExpress.XtraLayout.BaseLayoutItem[] {
            this.layoutControlItem5,
            this.layoutControlItem6,
            this.layoutControlItem7,
            this.layoutControlItem8});
            this.layoutControlGroup2.Location = new System.Drawing.Point(0, 0);
            this.layoutControlGroup2.Name = "layoutControlGroup2";
            this.layoutControlGroup2.Size = new System.Drawing.Size(496, 130);
            this.layoutControlGroup2.Spacing = new DevExpress.XtraLayout.Utils.Padding(0, 0, 0, 0);
            this.layoutControlGroup2.Text = "layoutControlGroup2";
            this.layoutControlGroup2.TextVisible = false;
            // 
            // layoutControlItem5
            // 
            this.layoutControlItem5.Control = this.warningTypeIdLookUpEdit;
            this.layoutControlItem5.CustomizationFormText = "Warning Type Id:";
            this.layoutControlItem5.Location = new System.Drawing.Point(0, 0);
            this.layoutControlItem5.Name = "layoutControlItem5";
            this.layoutControlItem5.Size = new System.Drawing.Size(476, 24);
            this.layoutControlItem5.Text = "Warning Type:";
            this.layoutControlItem5.TextSize = new System.Drawing.Size(89, 13);
            // 
            // layoutControlItem6
            // 
            this.layoutControlItem6.Control = this.warningReasonMemoEdit;
            this.layoutControlItem6.CustomizationFormText = "Warning Reason:";
            this.layoutControlItem6.Location = new System.Drawing.Point(0, 24);
            this.layoutControlItem6.Name = "layoutControlItem6";
            this.layoutControlItem6.Size = new System.Drawing.Size(476, 62);
            this.layoutControlItem6.Text = "Warning Reason:";
            this.layoutControlItem6.TextSize = new System.Drawing.Size(89, 13);
            // 
            // layoutControlItem7
            // 
            this.layoutControlItem7.Control = this.warningGivenByTextEdit;
            this.layoutControlItem7.CustomizationFormText = "Warning Given By:";
            this.layoutControlItem7.Location = new System.Drawing.Point(0, 86);
            this.layoutControlItem7.Name = "layoutControlItem7";
            this.layoutControlItem7.Size = new System.Drawing.Size(238, 24);
            this.layoutControlItem7.Text = "Warning Given By:";
            this.layoutControlItem7.TextSize = new System.Drawing.Size(89, 13);
            // 
            // layoutControlItem8
            // 
            this.layoutControlItem8.Control = this.warningDateDateEdit;
            this.layoutControlItem8.CustomizationFormText = "Warning Date:";
            this.layoutControlItem8.Location = new System.Drawing.Point(238, 86);
            this.layoutControlItem8.Name = "layoutControlItem8";
            this.layoutControlItem8.Size = new System.Drawing.Size(238, 24);
            this.layoutControlItem8.Text = "Warning Date:";
            this.layoutControlItem8.TextSize = new System.Drawing.Size(89, 13);
            // 
            // btnSave
            // 
            this.btnSave.Enabled = false;
            this.btnSave.Location = new System.Drawing.Point(189, 304);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(75, 23);
            this.btnSave.TabIndex = 2;
            this.btnSave.Text = "Save";
            this.btnSave.Click += new System.EventHandler(this.simpleButton1_Click);
            // 
            // simpleButton2
            // 
            this.simpleButton2.CausesValidation = false;
            this.simpleButton2.Location = new System.Drawing.Point(270, 304);
            this.simpleButton2.Name = "simpleButton2";
            this.simpleButton2.Size = new System.Drawing.Size(75, 23);
            this.simpleButton2.TabIndex = 3;
            this.simpleButton2.Text = "Cancel";
            this.simpleButton2.Click += new System.EventHandler(this.simpleButton2_Click);
            // 
            // EmployeeWarningView
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(529, 335);
            this.Controls.Add(this.simpleButton2);
            this.Controls.Add(this.btnSave);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "EmployeeWarningView";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Employee Warning";
            this.groupBox1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.layoutControl1)).EndInit();
            this.layoutControl1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.hireDateDateEdit.Properties.VistaTimeProperties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.hireDateDateEdit.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.employeeBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.employeeNoTextEdit.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.fullNameTextEdit.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlGroup1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.warningBindingSource)).EndInit();
            this.groupBox2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.layoutControl2)).EndInit();
            this.layoutControl2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.warningDateDateEdit.Properties.VistaTimeProperties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.warningDateDateEdit.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.warningGivenByTextEdit.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.warningReasonMemoEdit.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.warningTypeIdLookUpEdit.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.warningTypeBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlGroup2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem5)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem6)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem7)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem8)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private DevExpress.XtraLayout.LayoutControl layoutControl1;
        private DevExpress.XtraLayout.LayoutControlGroup layoutControlGroup1;
        private DevExpress.XtraEditors.DateEdit hireDateDateEdit;
        private System.Windows.Forms.BindingSource employeeBindingSource;
        private DevExpress.XtraEditors.TextEdit employeeNoTextEdit;
        private DevExpress.XtraEditors.TextEdit fullNameTextEdit;
        private DevExpress.XtraLayout.LayoutControlItem layoutControlItem2;
        private DevExpress.XtraLayout.LayoutControlItem layoutControlItem3;
        private DevExpress.XtraLayout.LayoutControlItem layoutControlItem4;
        private System.Windows.Forms.BindingSource warningBindingSource;
        private System.Windows.Forms.GroupBox groupBox2;
        private DevExpress.XtraLayout.LayoutControl layoutControl2;
        private DevExpress.XtraEditors.DateEdit warningDateDateEdit;
        private DevExpress.XtraEditors.TextEdit warningGivenByTextEdit;
        private DevExpress.XtraEditors.MemoEdit warningReasonMemoEdit;
        private DevExpress.XtraEditors.LookUpEdit warningTypeIdLookUpEdit;
        private DevExpress.XtraLayout.LayoutControlGroup layoutControlGroup2;
        private DevExpress.XtraLayout.LayoutControlItem layoutControlItem5;
        private DevExpress.XtraLayout.LayoutControlItem layoutControlItem6;
        private DevExpress.XtraLayout.LayoutControlItem layoutControlItem7;
        private DevExpress.XtraLayout.LayoutControlItem layoutControlItem8;
        private DevExpress.XtraEditors.SimpleButton btnSave;
        private DevExpress.XtraEditors.SimpleButton simpleButton2;
        private System.Windows.Forms.BindingSource warningTypeBindingSource;
    }
}