namespace ClearOffice.Hrm.Views
{
    partial class TrainingFeedbackView
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
            this.simpleButton1 = new DevExpress.XtraEditors.SimpleButton();
            this.simpleButton2 = new DevExpress.XtraEditors.SimpleButton();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.layoutControl1 = new DevExpress.XtraLayout.LayoutControl();
            this.feedbackMemoEdit = new DevExpress.XtraEditors.MemoEdit();
            this.feedBackBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.feedbackByTextEdit = new DevExpress.XtraEditors.TextEdit();
            this.layoutControlGroup1 = new DevExpress.XtraLayout.LayoutControlGroup();
            this.layoutControlItem2 = new DevExpress.XtraLayout.LayoutControlItem();
            this.layoutControlItem3 = new DevExpress.XtraLayout.LayoutControlItem();
            this.feedBackErrorProvider = new System.Windows.Forms.ErrorProvider(this.components);
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControl1)).BeginInit();
            this.layoutControl1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.feedbackMemoEdit.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.feedBackBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.feedbackByTextEdit.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlGroup1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.feedBackErrorProvider)).BeginInit();
            this.SuspendLayout();
            // 
            // simpleButton1
            // 
            this.simpleButton1.Location = new System.Drawing.Point(189, 227);
            this.simpleButton1.Name = "simpleButton1";
            this.simpleButton1.Size = new System.Drawing.Size(75, 23);
            this.simpleButton1.TabIndex = 0;
            this.simpleButton1.Text = "Save";
            this.simpleButton1.Click += new System.EventHandler(this.simpleButton1_Click);
            // 
            // simpleButton2
            // 
            this.simpleButton2.CausesValidation = false;
            this.simpleButton2.Location = new System.Drawing.Point(271, 227);
            this.simpleButton2.Name = "simpleButton2";
            this.simpleButton2.Size = new System.Drawing.Size(75, 23);
            this.simpleButton2.TabIndex = 1;
            this.simpleButton2.Text = "Cancel";
            this.simpleButton2.Click += new System.EventHandler(this.simpleButton2_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.layoutControl1);
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(500, 209);
            this.groupBox1.TabIndex = 2;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Feedback";
            // 
            // layoutControl1
            // 
            this.layoutControl1.Controls.Add(this.feedbackMemoEdit);
            this.layoutControl1.Controls.Add(this.feedbackByTextEdit);
            this.layoutControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.layoutControl1.Location = new System.Drawing.Point(3, 17);
            this.layoutControl1.Name = "layoutControl1";
            this.layoutControl1.Root = this.layoutControlGroup1;
            this.layoutControl1.Size = new System.Drawing.Size(494, 189);
            this.layoutControl1.TabIndex = 0;
            this.layoutControl1.Text = "layoutControl1";
            // 
            // feedbackMemoEdit
            // 
            this.feedbackMemoEdit.DataBindings.Add(new System.Windows.Forms.Binding("EditValue", this.feedBackBindingSource, "Feedback", true));
            this.feedbackMemoEdit.Location = new System.Drawing.Point(81, 36);
            this.feedbackMemoEdit.Name = "feedbackMemoEdit";
            this.feedbackMemoEdit.Size = new System.Drawing.Size(401, 141);
            this.feedbackMemoEdit.StyleController = this.layoutControl1;
            this.feedbackMemoEdit.TabIndex = 6;
            // 
            // feedBackBindingSource
            // 
            this.feedBackBindingSource.DataSource = typeof(ClearOffice.Hrm.Business.Data.TrainingFeedback);
            // 
            // feedbackByTextEdit
            // 
            this.feedbackByTextEdit.DataBindings.Add(new System.Windows.Forms.Binding("EditValue", this.feedBackBindingSource, "FeedbackBy", true));
            this.feedbackByTextEdit.Location = new System.Drawing.Point(81, 12);
            this.feedbackByTextEdit.Name = "feedbackByTextEdit";
            this.feedbackByTextEdit.Size = new System.Drawing.Size(401, 20);
            this.feedbackByTextEdit.StyleController = this.layoutControl1;
            this.feedbackByTextEdit.TabIndex = 5;
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
            this.layoutControlGroup1.Size = new System.Drawing.Size(494, 189);
            this.layoutControlGroup1.Spacing = new DevExpress.XtraLayout.Utils.Padding(0, 0, 0, 0);
            this.layoutControlGroup1.Text = "layoutControlGroup1";
            this.layoutControlGroup1.TextVisible = false;
            // 
            // layoutControlItem2
            // 
            this.layoutControlItem2.Control = this.feedbackByTextEdit;
            this.layoutControlItem2.CustomizationFormText = "Feedback By:";
            this.layoutControlItem2.Location = new System.Drawing.Point(0, 0);
            this.layoutControlItem2.Name = "layoutControlItem2";
            this.layoutControlItem2.Size = new System.Drawing.Size(474, 24);
            this.layoutControlItem2.Text = "Feedback By:";
            this.layoutControlItem2.TextSize = new System.Drawing.Size(65, 13);
            // 
            // layoutControlItem3
            // 
            this.layoutControlItem3.Control = this.feedbackMemoEdit;
            this.layoutControlItem3.CustomizationFormText = "Feedback:";
            this.layoutControlItem3.Location = new System.Drawing.Point(0, 24);
            this.layoutControlItem3.Name = "layoutControlItem3";
            this.layoutControlItem3.Size = new System.Drawing.Size(474, 145);
            this.layoutControlItem3.Text = "Feedback:";
            this.layoutControlItem3.TextSize = new System.Drawing.Size(65, 13);
            // 
            // feedBackErrorProvider
            // 
            this.feedBackErrorProvider.ContainerControl = this;
            this.feedBackErrorProvider.DataSource = this.feedBackBindingSource;
            // 
            // TrainingFeedbackView
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(519, 257);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.simpleButton2);
            this.Controls.Add(this.simpleButton1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "TrainingFeedbackView";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Training Feedback ";
            this.groupBox1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.layoutControl1)).EndInit();
            this.layoutControl1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.feedbackMemoEdit.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.feedBackBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.feedbackByTextEdit.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlGroup1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.feedBackErrorProvider)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraEditors.SimpleButton simpleButton1;
        private DevExpress.XtraEditors.SimpleButton simpleButton2;
        private System.Windows.Forms.GroupBox groupBox1;
        private DevExpress.XtraLayout.LayoutControl layoutControl1;
        private DevExpress.XtraEditors.MemoEdit feedbackMemoEdit;
        private System.Windows.Forms.BindingSource feedBackBindingSource;
        private DevExpress.XtraEditors.TextEdit feedbackByTextEdit;
        private DevExpress.XtraLayout.LayoutControlGroup layoutControlGroup1;
        private DevExpress.XtraLayout.LayoutControlItem layoutControlItem2;
        private DevExpress.XtraLayout.LayoutControlItem layoutControlItem3;
        private System.Windows.Forms.ErrorProvider feedBackErrorProvider;
    }
}