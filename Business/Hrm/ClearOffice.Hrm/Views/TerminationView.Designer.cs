namespace ClearOffice.Hrm.Views
{
    partial class TerminationView
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
            this.employeeNoTextEdit = new DevExpress.XtraEditors.TextEdit();
            this.employeeInfoBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.fullNameTextEdit = new DevExpress.XtraEditors.TextEdit();
            this.layoutControlGroup1 = new DevExpress.XtraLayout.LayoutControlGroup();
            this.layoutControlItem2 = new DevExpress.XtraLayout.LayoutControlItem();
            this.layoutControlItem3 = new DevExpress.XtraLayout.LayoutControlItem();
            this.terminationErrorProvider = new System.Windows.Forms.ErrorProvider(this.components);
            this.terminationBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.layoutControl2 = new DevExpress.XtraLayout.LayoutControl();
            this.actionTakenByTextEdit = new DevExpress.XtraEditors.TextEdit();
            this.effectiveDateDateEdit = new DevExpress.XtraEditors.DateEdit();
            this.terminationDateDateEdit = new DevExpress.XtraEditors.DateEdit();
            this.terminationReasonMemoEdit = new DevExpress.XtraEditors.MemoEdit();
            this.layoutControlGroup2 = new DevExpress.XtraLayout.LayoutControlGroup();
            this.layoutControlItem4 = new DevExpress.XtraLayout.LayoutControlItem();
            this.layoutControlItem5 = new DevExpress.XtraLayout.LayoutControlItem();
            this.layoutControlItem6 = new DevExpress.XtraLayout.LayoutControlItem();
            this.layoutControlItem7 = new DevExpress.XtraLayout.LayoutControlItem();
            this.btnSaveTermination = new DevExpress.XtraEditors.SimpleButton();
            this.btnCancelTermination = new DevExpress.XtraEditors.SimpleButton();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControl1)).BeginInit();
            this.layoutControl1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.employeeNoTextEdit.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.employeeInfoBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.fullNameTextEdit.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlGroup1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.terminationErrorProvider)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.terminationBindingSource)).BeginInit();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControl2)).BeginInit();
            this.layoutControl2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.actionTakenByTextEdit.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.effectiveDateDateEdit.Properties.VistaTimeProperties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.effectiveDateDateEdit.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.terminationDateDateEdit.Properties.VistaTimeProperties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.terminationDateDateEdit.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.terminationReasonMemoEdit.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlGroup2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem5)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem6)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem7)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.layoutControl1);
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(533, 94);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Employee ";
            // 
            // layoutControl1
            // 
            this.layoutControl1.Controls.Add(this.employeeNoTextEdit);
            this.layoutControl1.Controls.Add(this.fullNameTextEdit);
            this.layoutControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.layoutControl1.Location = new System.Drawing.Point(3, 17);
            this.layoutControl1.Name = "layoutControl1";
            this.layoutControl1.Root = this.layoutControlGroup1;
            this.layoutControl1.Size = new System.Drawing.Size(527, 74);
            this.layoutControl1.TabIndex = 0;
            this.layoutControl1.Text = "layoutControl1";
            // 
            // employeeNoTextEdit
            // 
            this.employeeNoTextEdit.DataBindings.Add(new System.Windows.Forms.Binding("EditValue", this.employeeInfoBindingSource, "EmployeeNo", true));
            this.employeeNoTextEdit.Enabled = false;
            this.employeeNoTextEdit.Location = new System.Drawing.Point(82, 36);
            this.employeeNoTextEdit.Name = "employeeNoTextEdit";
            this.employeeNoTextEdit.Size = new System.Drawing.Size(433, 20);
            this.employeeNoTextEdit.StyleController = this.layoutControl1;
            this.employeeNoTextEdit.TabIndex = 6;
            // 
            // employeeInfoBindingSource
            // 
            this.employeeInfoBindingSource.DataSource = typeof(ClearOffice.Hrm.Business.Data.EmployeeInfo);
            // 
            // fullNameTextEdit
            // 
            this.fullNameTextEdit.DataBindings.Add(new System.Windows.Forms.Binding("EditValue", this.employeeInfoBindingSource, "FullName", true));
            this.fullNameTextEdit.Enabled = false;
            this.fullNameTextEdit.Location = new System.Drawing.Point(82, 12);
            this.fullNameTextEdit.Name = "fullNameTextEdit";
            this.fullNameTextEdit.Size = new System.Drawing.Size(433, 20);
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
            this.layoutControlItem3});
            this.layoutControlGroup1.Location = new System.Drawing.Point(0, 0);
            this.layoutControlGroup1.Name = "layoutControlGroup1";
            this.layoutControlGroup1.Size = new System.Drawing.Size(527, 74);
            this.layoutControlGroup1.Spacing = new DevExpress.XtraLayout.Utils.Padding(0, 0, 0, 0);
            this.layoutControlGroup1.Text = "layoutControlGroup1";
            this.layoutControlGroup1.TextVisible = false;
            // 
            // layoutControlItem2
            // 
            this.layoutControlItem2.Control = this.fullNameTextEdit;
            this.layoutControlItem2.CustomizationFormText = "Full Name:";
            this.layoutControlItem2.Location = new System.Drawing.Point(0, 0);
            this.layoutControlItem2.Name = "layoutControlItem2";
            this.layoutControlItem2.Size = new System.Drawing.Size(507, 24);
            this.layoutControlItem2.Text = "Full Name:";
            this.layoutControlItem2.TextSize = new System.Drawing.Size(66, 13);
            // 
            // layoutControlItem3
            // 
            this.layoutControlItem3.Control = this.employeeNoTextEdit;
            this.layoutControlItem3.CustomizationFormText = "Employee No:";
            this.layoutControlItem3.Location = new System.Drawing.Point(0, 24);
            this.layoutControlItem3.Name = "layoutControlItem3";
            this.layoutControlItem3.Size = new System.Drawing.Size(507, 30);
            this.layoutControlItem3.Text = "Employee No:";
            this.layoutControlItem3.TextSize = new System.Drawing.Size(66, 13);
            // 
            // terminationErrorProvider
            // 
            this.terminationErrorProvider.ContainerControl = this;
            this.terminationErrorProvider.DataSource = this.terminationBindingSource;
            // 
            // terminationBindingSource
            // 
            this.terminationBindingSource.DataSource = typeof(ClearOffice.Hrm.Business.Data.EmployeeTermination);
            this.terminationBindingSource.CurrentItemChanged += new System.EventHandler(this.terminationBindingSource_CurrentItemChanged);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.layoutControl2);
            this.groupBox2.Location = new System.Drawing.Point(12, 112);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(538, 224);
            this.groupBox2.TabIndex = 1;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Termination Information";
            // 
            // layoutControl2
            // 
            this.layoutControl2.Controls.Add(this.actionTakenByTextEdit);
            this.layoutControl2.Controls.Add(this.effectiveDateDateEdit);
            this.layoutControl2.Controls.Add(this.terminationDateDateEdit);
            this.layoutControl2.Controls.Add(this.terminationReasonMemoEdit);
            this.layoutControl2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.layoutControl2.Location = new System.Drawing.Point(3, 17);
            this.layoutControl2.Name = "layoutControl2";
            this.layoutControl2.Root = this.layoutControlGroup2;
            this.layoutControl2.Size = new System.Drawing.Size(532, 204);
            this.layoutControl2.TabIndex = 0;
            this.layoutControl2.Text = "layoutControl2";
            // 
            // actionTakenByTextEdit
            // 
            this.actionTakenByTextEdit.DataBindings.Add(new System.Windows.Forms.Binding("EditValue", this.terminationBindingSource, "ActionTakenBy", true));
            this.actionTakenByTextEdit.Location = new System.Drawing.Point(115, 172);
            this.actionTakenByTextEdit.Name = "actionTakenByTextEdit";
            this.actionTakenByTextEdit.Size = new System.Drawing.Size(405, 20);
            this.actionTakenByTextEdit.StyleController = this.layoutControl2;
            this.actionTakenByTextEdit.TabIndex = 8;
            // 
            // effectiveDateDateEdit
            // 
            this.effectiveDateDateEdit.DataBindings.Add(new System.Windows.Forms.Binding("EditValue", this.terminationBindingSource, "EffectiveDate", true));
            this.effectiveDateDateEdit.EditValue = null;
            this.effectiveDateDateEdit.Location = new System.Drawing.Point(371, 148);
            this.effectiveDateDateEdit.Name = "effectiveDateDateEdit";
            this.effectiveDateDateEdit.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.effectiveDateDateEdit.Properties.VistaTimeProperties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton()});
            this.effectiveDateDateEdit.Size = new System.Drawing.Size(149, 20);
            this.effectiveDateDateEdit.StyleController = this.layoutControl2;
            this.effectiveDateDateEdit.TabIndex = 7;
            // 
            // terminationDateDateEdit
            // 
            this.terminationDateDateEdit.DataBindings.Add(new System.Windows.Forms.Binding("EditValue", this.terminationBindingSource, "TerminationDate", true));
            this.terminationDateDateEdit.EditValue = null;
            this.terminationDateDateEdit.Location = new System.Drawing.Point(115, 148);
            this.terminationDateDateEdit.Name = "terminationDateDateEdit";
            this.terminationDateDateEdit.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.terminationDateDateEdit.Properties.VistaTimeProperties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton()});
            this.terminationDateDateEdit.Size = new System.Drawing.Size(149, 20);
            this.terminationDateDateEdit.StyleController = this.layoutControl2;
            this.terminationDateDateEdit.TabIndex = 6;
            // 
            // terminationReasonMemoEdit
            // 
            this.terminationReasonMemoEdit.DataBindings.Add(new System.Windows.Forms.Binding("EditValue", this.terminationBindingSource, "TerminationReason", true));
            this.terminationReasonMemoEdit.Location = new System.Drawing.Point(115, 12);
            this.terminationReasonMemoEdit.Name = "terminationReasonMemoEdit";
            this.terminationReasonMemoEdit.Size = new System.Drawing.Size(405, 132);
            this.terminationReasonMemoEdit.StyleController = this.layoutControl2;
            this.terminationReasonMemoEdit.TabIndex = 5;
            // 
            // layoutControlGroup2
            // 
            this.layoutControlGroup2.CustomizationFormText = "layoutControlGroup2";
            this.layoutControlGroup2.EnableIndentsWithoutBorders = DevExpress.Utils.DefaultBoolean.True;
            this.layoutControlGroup2.GroupBordersVisible = false;
            this.layoutControlGroup2.Items.AddRange(new DevExpress.XtraLayout.BaseLayoutItem[] {
            this.layoutControlItem4,
            this.layoutControlItem5,
            this.layoutControlItem6,
            this.layoutControlItem7});
            this.layoutControlGroup2.Location = new System.Drawing.Point(0, 0);
            this.layoutControlGroup2.Name = "layoutControlGroup2";
            this.layoutControlGroup2.Size = new System.Drawing.Size(532, 204);
            this.layoutControlGroup2.Spacing = new DevExpress.XtraLayout.Utils.Padding(0, 0, 0, 0);
            this.layoutControlGroup2.Text = "layoutControlGroup2";
            this.layoutControlGroup2.TextVisible = false;
            // 
            // layoutControlItem4
            // 
            this.layoutControlItem4.Control = this.terminationReasonMemoEdit;
            this.layoutControlItem4.CustomizationFormText = "Termination Reason:";
            this.layoutControlItem4.Location = new System.Drawing.Point(0, 0);
            this.layoutControlItem4.Name = "layoutControlItem4";
            this.layoutControlItem4.Size = new System.Drawing.Size(512, 136);
            this.layoutControlItem4.Text = "Termination Reason:";
            this.layoutControlItem4.TextSize = new System.Drawing.Size(99, 13);
            // 
            // layoutControlItem5
            // 
            this.layoutControlItem5.Control = this.terminationDateDateEdit;
            this.layoutControlItem5.CustomizationFormText = "Termination Date:";
            this.layoutControlItem5.Location = new System.Drawing.Point(0, 136);
            this.layoutControlItem5.Name = "layoutControlItem5";
            this.layoutControlItem5.Size = new System.Drawing.Size(256, 24);
            this.layoutControlItem5.Text = "Termination Date:";
            this.layoutControlItem5.TextSize = new System.Drawing.Size(99, 13);
            // 
            // layoutControlItem6
            // 
            this.layoutControlItem6.Control = this.effectiveDateDateEdit;
            this.layoutControlItem6.CustomizationFormText = "Effective Date:";
            this.layoutControlItem6.Location = new System.Drawing.Point(256, 136);
            this.layoutControlItem6.Name = "layoutControlItem6";
            this.layoutControlItem6.Size = new System.Drawing.Size(256, 24);
            this.layoutControlItem6.Text = "Effective Date:";
            this.layoutControlItem6.TextSize = new System.Drawing.Size(99, 13);
            // 
            // layoutControlItem7
            // 
            this.layoutControlItem7.Control = this.actionTakenByTextEdit;
            this.layoutControlItem7.CustomizationFormText = "Action Taken By:";
            this.layoutControlItem7.Location = new System.Drawing.Point(0, 160);
            this.layoutControlItem7.Name = "layoutControlItem7";
            this.layoutControlItem7.Size = new System.Drawing.Size(512, 24);
            this.layoutControlItem7.Text = "Action Taken By:";
            this.layoutControlItem7.TextSize = new System.Drawing.Size(99, 13);
            // 
            // btnSaveTermination
            // 
            this.btnSaveTermination.Location = new System.Drawing.Point(238, 342);
            this.btnSaveTermination.Name = "btnSaveTermination";
            this.btnSaveTermination.Size = new System.Drawing.Size(75, 23);
            this.btnSaveTermination.TabIndex = 2;
            this.btnSaveTermination.Text = "Terminate";
            this.btnSaveTermination.Click += new System.EventHandler(this.btnSaveTermination_Click);
            // 
            // btnCancelTermination
            // 
            this.btnCancelTermination.Location = new System.Drawing.Point(334, 342);
            this.btnCancelTermination.Name = "btnCancelTermination";
            this.btnCancelTermination.Size = new System.Drawing.Size(75, 23);
            this.btnCancelTermination.TabIndex = 3;
            this.btnCancelTermination.Text = "Cancel";
            this.btnCancelTermination.Click += new System.EventHandler(this.btnCancelTermination_Click);
            // 
            // TerminationView
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(557, 375);
            this.Controls.Add(this.btnCancelTermination);
            this.Controls.Add(this.btnSaveTermination);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "TerminationView";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Employee Termination";
            this.groupBox1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.layoutControl1)).EndInit();
            this.layoutControl1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.employeeNoTextEdit.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.employeeInfoBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.fullNameTextEdit.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlGroup1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.terminationErrorProvider)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.terminationBindingSource)).EndInit();
            this.groupBox2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.layoutControl2)).EndInit();
            this.layoutControl2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.actionTakenByTextEdit.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.effectiveDateDateEdit.Properties.VistaTimeProperties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.effectiveDateDateEdit.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.terminationDateDateEdit.Properties.VistaTimeProperties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.terminationDateDateEdit.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.terminationReasonMemoEdit.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlGroup2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem5)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem6)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem7)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.BindingSource terminationBindingSource;
        private System.Windows.Forms.ErrorProvider terminationErrorProvider;
        private DevExpress.XtraEditors.SimpleButton btnCancelTermination;
        private DevExpress.XtraEditors.SimpleButton btnSaveTermination;
        private System.Windows.Forms.GroupBox groupBox2;
        private DevExpress.XtraLayout.LayoutControl layoutControl1;
        private DevExpress.XtraEditors.TextEdit fullNameTextEdit;
        private System.Windows.Forms.BindingSource employeeInfoBindingSource;
        private DevExpress.XtraLayout.LayoutControlGroup layoutControlGroup1;
        private DevExpress.XtraLayout.LayoutControlItem layoutControlItem2;
        private DevExpress.XtraEditors.TextEdit employeeNoTextEdit;
        private DevExpress.XtraLayout.LayoutControlItem layoutControlItem3;
        private DevExpress.XtraLayout.LayoutControl layoutControl2;
        private DevExpress.XtraEditors.TextEdit actionTakenByTextEdit;
        private DevExpress.XtraEditors.DateEdit effectiveDateDateEdit;
        private DevExpress.XtraEditors.DateEdit terminationDateDateEdit;
        private DevExpress.XtraEditors.MemoEdit terminationReasonMemoEdit;
        private DevExpress.XtraLayout.LayoutControlGroup layoutControlGroup2;
        private DevExpress.XtraLayout.LayoutControlItem layoutControlItem4;
        private DevExpress.XtraLayout.LayoutControlItem layoutControlItem5;
        private DevExpress.XtraLayout.LayoutControlItem layoutControlItem6;
        private DevExpress.XtraLayout.LayoutControlItem layoutControlItem7;
    }
}