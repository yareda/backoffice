namespace ClearOffice.Hrm.Views
{
    partial class NewTrainingRequestView
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
            this.traningRequestErrorProvider = new System.Windows.Forms.ErrorProvider(this.components);
            this.trainingRequestBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.btnSaveTrainingRequest = new DevExpress.XtraEditors.SimpleButton();
            this.btnCancelRequest = new DevExpress.XtraEditors.SimpleButton();
            this.layoutControl1 = new DevExpress.XtraLayout.LayoutControl();
            this.addTrainingCategoryHyperLinkEdit = new DevExpress.XtraEditors.HyperLinkEdit();
            this.budgetSecuredCheckEdit = new DevExpress.XtraEditors.CheckEdit();
            this.trainingDescriptionMemoEdit = new DevExpress.XtraEditors.MemoEdit();
            this.requestedByTextEdit = new DevExpress.XtraEditors.TextEdit();
            this.requestedDateDateEdit = new DevExpress.XtraEditors.DateEdit();
            this.estimatedNumberOfAttendantsTextEdit = new DevExpress.XtraEditors.TextEdit();
            this.estimatedBudgetTextEdit = new DevExpress.XtraEditors.TextEdit();
            this.trainingCategoryIdLookUpEdit = new DevExpress.XtraEditors.LookUpEdit();
            this.trainingCategoryBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.trainingTitleTextEdit = new DevExpress.XtraEditors.TextEdit();
            this.layoutControlGroup1 = new DevExpress.XtraLayout.LayoutControlGroup();
            this.layoutControlItem2 = new DevExpress.XtraLayout.LayoutControlItem();
            this.layoutControlItem3 = new DevExpress.XtraLayout.LayoutControlItem();
            this.layoutControlItem5 = new DevExpress.XtraLayout.LayoutControlItem();
            this.layoutControlItem6 = new DevExpress.XtraLayout.LayoutControlItem();
            this.layoutControlItem7 = new DevExpress.XtraLayout.LayoutControlItem();
            this.layoutControlItem8 = new DevExpress.XtraLayout.LayoutControlItem();
            this.layoutControlItem9 = new DevExpress.XtraLayout.LayoutControlItem();
            this.layoutControlItem4 = new DevExpress.XtraLayout.LayoutControlItem();
            this.layoutControlItem1 = new DevExpress.XtraLayout.LayoutControlItem();
            ((System.ComponentModel.ISupportInitialize)(this.traningRequestErrorProvider)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.trainingRequestBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControl1)).BeginInit();
            this.layoutControl1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.addTrainingCategoryHyperLinkEdit.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.budgetSecuredCheckEdit.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.trainingDescriptionMemoEdit.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.requestedByTextEdit.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.requestedDateDateEdit.Properties.VistaTimeProperties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.requestedDateDateEdit.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.estimatedNumberOfAttendantsTextEdit.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.estimatedBudgetTextEdit.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.trainingCategoryIdLookUpEdit.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.trainingCategoryBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.trainingTitleTextEdit.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlGroup1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem5)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem6)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem7)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem8)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem9)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem1)).BeginInit();
            this.SuspendLayout();
            // 
            // traningRequestErrorProvider
            // 
            this.traningRequestErrorProvider.ContainerControl = this;
            this.traningRequestErrorProvider.DataSource = this.trainingRequestBindingSource;
            // 
            // trainingRequestBindingSource
            // 
            this.trainingRequestBindingSource.DataSource = typeof(ClearOffice.Hrm.Business.Data.TrainingRequest);
            this.trainingRequestBindingSource.CurrentItemChanged += new System.EventHandler(this.trainingRequestBindingSource_CurrentItemChanged);
            // 
            // btnSaveTrainingRequest
            // 
            this.btnSaveTrainingRequest.Location = new System.Drawing.Point(227, 284);
            this.btnSaveTrainingRequest.Name = "btnSaveTrainingRequest";
            this.btnSaveTrainingRequest.Size = new System.Drawing.Size(75, 23);
            this.btnSaveTrainingRequest.TabIndex = 1;
            this.btnSaveTrainingRequest.Text = "Save";
            this.btnSaveTrainingRequest.Click += new System.EventHandler(this.btnSaveTrainingRequest_Click);
            // 
            // btnCancelRequest
            // 
            this.btnCancelRequest.Location = new System.Drawing.Point(320, 285);
            this.btnCancelRequest.Name = "btnCancelRequest";
            this.btnCancelRequest.Size = new System.Drawing.Size(75, 23);
            this.btnCancelRequest.TabIndex = 2;
            this.btnCancelRequest.Text = "Cancel";
            this.btnCancelRequest.Click += new System.EventHandler(this.btnCancelRequest_Click);
            // 
            // layoutControl1
            // 
            this.layoutControl1.Controls.Add(this.addTrainingCategoryHyperLinkEdit);
            this.layoutControl1.Controls.Add(this.budgetSecuredCheckEdit);
            this.layoutControl1.Controls.Add(this.trainingDescriptionMemoEdit);
            this.layoutControl1.Controls.Add(this.requestedByTextEdit);
            this.layoutControl1.Controls.Add(this.requestedDateDateEdit);
            this.layoutControl1.Controls.Add(this.estimatedNumberOfAttendantsTextEdit);
            this.layoutControl1.Controls.Add(this.estimatedBudgetTextEdit);
            this.layoutControl1.Controls.Add(this.trainingCategoryIdLookUpEdit);
            this.layoutControl1.Controls.Add(this.trainingTitleTextEdit);
            this.layoutControl1.Dock = System.Windows.Forms.DockStyle.Top;
            this.layoutControl1.Location = new System.Drawing.Point(0, 0);
            this.layoutControl1.Name = "layoutControl1";
            this.layoutControl1.Root = this.layoutControlGroup1;
            this.layoutControl1.Size = new System.Drawing.Size(622, 283);
            this.layoutControl1.TabIndex = 3;
            this.layoutControl1.Text = "layoutControl1";
            // 
            // addTrainingCategoryHyperLinkEdit
            // 
            this.addTrainingCategoryHyperLinkEdit.EditValue = "";
            this.addTrainingCategoryHyperLinkEdit.Location = new System.Drawing.Point(313, 36);
            this.addTrainingCategoryHyperLinkEdit.Margin = new System.Windows.Forms.Padding(0);
            this.addTrainingCategoryHyperLinkEdit.Name = "addTrainingCategoryHyperLinkEdit";
            this.addTrainingCategoryHyperLinkEdit.Properties.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.NoBorder;
            this.addTrainingCategoryHyperLinkEdit.Properties.Image = global::ClearOffice.Hrm.Properties.Resources.add;
            this.addTrainingCategoryHyperLinkEdit.Size = new System.Drawing.Size(297, 18);
            this.addTrainingCategoryHyperLinkEdit.StyleController = this.layoutControl1;
            this.addTrainingCategoryHyperLinkEdit.TabIndex = 14;
            this.addTrainingCategoryHyperLinkEdit.ToolTipTitle = "Add Training Category";
            this.addTrainingCategoryHyperLinkEdit.Click += new System.EventHandler(this.addTrainingCategoryHyperLinkEdit_Click);
            // 
            // budgetSecuredCheckEdit
            // 
            this.budgetSecuredCheckEdit.DataBindings.Add(new System.Windows.Forms.Binding("EditValue", this.trainingRequestBindingSource, "BudgetSecured", true));
            this.budgetSecuredCheckEdit.Location = new System.Drawing.Point(12, 60);
            this.budgetSecuredCheckEdit.Name = "budgetSecuredCheckEdit";
            this.budgetSecuredCheckEdit.Properties.Caption = "Budget Secured:";
            this.budgetSecuredCheckEdit.Size = new System.Drawing.Size(598, 19);
            this.budgetSecuredCheckEdit.StyleController = this.layoutControl1;
            this.budgetSecuredCheckEdit.TabIndex = 13;
            // 
            // trainingDescriptionMemoEdit
            // 
            this.trainingDescriptionMemoEdit.DataBindings.Add(new System.Windows.Forms.Binding("EditValue", this.trainingRequestBindingSource, "TrainingDescription", true));
            this.trainingDescriptionMemoEdit.Location = new System.Drawing.Point(179, 155);
            this.trainingDescriptionMemoEdit.Name = "trainingDescriptionMemoEdit";
            this.trainingDescriptionMemoEdit.Size = new System.Drawing.Size(431, 116);
            this.trainingDescriptionMemoEdit.StyleController = this.layoutControl1;
            this.trainingDescriptionMemoEdit.TabIndex = 12;
            // 
            // requestedByTextEdit
            // 
            this.requestedByTextEdit.DataBindings.Add(new System.Windows.Forms.Binding("EditValue", this.trainingRequestBindingSource, "RequestedBy", true));
            this.requestedByTextEdit.Location = new System.Drawing.Point(179, 131);
            this.requestedByTextEdit.Name = "requestedByTextEdit";
            this.requestedByTextEdit.Size = new System.Drawing.Size(431, 20);
            this.requestedByTextEdit.StyleController = this.layoutControl1;
            this.requestedByTextEdit.TabIndex = 11;
            // 
            // requestedDateDateEdit
            // 
            this.requestedDateDateEdit.DataBindings.Add(new System.Windows.Forms.Binding("EditValue", this.trainingRequestBindingSource, "RequestedDate", true));
            this.requestedDateDateEdit.EditValue = null;
            this.requestedDateDateEdit.Location = new System.Drawing.Point(479, 107);
            this.requestedDateDateEdit.Name = "requestedDateDateEdit";
            this.requestedDateDateEdit.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.requestedDateDateEdit.Properties.VistaTimeProperties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton()});
            this.requestedDateDateEdit.Size = new System.Drawing.Size(131, 20);
            this.requestedDateDateEdit.StyleController = this.layoutControl1;
            this.requestedDateDateEdit.TabIndex = 10;
            // 
            // estimatedNumberOfAttendantsTextEdit
            // 
            this.estimatedNumberOfAttendantsTextEdit.DataBindings.Add(new System.Windows.Forms.Binding("EditValue", this.trainingRequestBindingSource, "EstimatedNumberOfAttendants", true));
            this.estimatedNumberOfAttendantsTextEdit.Location = new System.Drawing.Point(179, 107);
            this.estimatedNumberOfAttendantsTextEdit.Name = "estimatedNumberOfAttendantsTextEdit";
            this.estimatedNumberOfAttendantsTextEdit.Size = new System.Drawing.Size(129, 20);
            this.estimatedNumberOfAttendantsTextEdit.StyleController = this.layoutControl1;
            this.estimatedNumberOfAttendantsTextEdit.TabIndex = 9;
            // 
            // estimatedBudgetTextEdit
            // 
            this.estimatedBudgetTextEdit.DataBindings.Add(new System.Windows.Forms.Binding("EditValue", this.trainingRequestBindingSource, "EstimatedBudget", true));
            this.estimatedBudgetTextEdit.Location = new System.Drawing.Point(179, 83);
            this.estimatedBudgetTextEdit.Name = "estimatedBudgetTextEdit";
            this.estimatedBudgetTextEdit.Size = new System.Drawing.Size(431, 20);
            this.estimatedBudgetTextEdit.StyleController = this.layoutControl1;
            this.estimatedBudgetTextEdit.TabIndex = 8;
            // 
            // trainingCategoryIdLookUpEdit
            // 
            this.trainingCategoryIdLookUpEdit.DataBindings.Add(new System.Windows.Forms.Binding("EditValue", this.trainingRequestBindingSource, "TrainingCategoryId", true));
            this.trainingCategoryIdLookUpEdit.Location = new System.Drawing.Point(179, 36);
            this.trainingCategoryIdLookUpEdit.Name = "trainingCategoryIdLookUpEdit";
            this.trainingCategoryIdLookUpEdit.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.trainingCategoryIdLookUpEdit.Properties.Columns.AddRange(new DevExpress.XtraEditors.Controls.LookUpColumnInfo[] {
            new DevExpress.XtraEditors.Controls.LookUpColumnInfo("TrainingCategoryName", "Training Categories", 126, DevExpress.Utils.FormatType.None, "", true, DevExpress.Utils.HorzAlignment.Near)});
            this.trainingCategoryIdLookUpEdit.Properties.DataSource = this.trainingCategoryBindingSource;
            this.trainingCategoryIdLookUpEdit.Properties.DisplayMember = "TrainingCategoryName";
            this.trainingCategoryIdLookUpEdit.Properties.NullText = "[Select Category]";
            this.trainingCategoryIdLookUpEdit.Properties.ValueMember = "TrainingCategoryId";
            this.trainingCategoryIdLookUpEdit.Size = new System.Drawing.Size(130, 20);
            this.trainingCategoryIdLookUpEdit.StyleController = this.layoutControl1;
            this.trainingCategoryIdLookUpEdit.TabIndex = 6;
            // 
            // trainingCategoryBindingSource
            // 
            this.trainingCategoryBindingSource.DataSource = typeof(ClearOffice.Hrm.Business.Data.TrainingCategory);
            // 
            // trainingTitleTextEdit
            // 
            this.trainingTitleTextEdit.DataBindings.Add(new System.Windows.Forms.Binding("EditValue", this.trainingRequestBindingSource, "TrainingTitle", true));
            this.trainingTitleTextEdit.Location = new System.Drawing.Point(179, 12);
            this.trainingTitleTextEdit.Name = "trainingTitleTextEdit";
            this.trainingTitleTextEdit.Size = new System.Drawing.Size(431, 20);
            this.trainingTitleTextEdit.StyleController = this.layoutControl1;
            this.trainingTitleTextEdit.TabIndex = 5;
            // 
            // layoutControlGroup1
            // 
            this.layoutControlGroup1.CustomizationFormText = "layoutControlGroup1";
            this.layoutControlGroup1.EnableIndentsWithoutBorders = DevExpress.Utils.DefaultBoolean.True;
            this.layoutControlGroup1.GroupBordersVisible = false;
            this.layoutControlGroup1.Items.AddRange(new DevExpress.XtraLayout.BaseLayoutItem[] {
            this.layoutControlItem2,
            this.layoutControlItem3,
            this.layoutControlItem5,
            this.layoutControlItem6,
            this.layoutControlItem7,
            this.layoutControlItem8,
            this.layoutControlItem9,
            this.layoutControlItem4,
            this.layoutControlItem1});
            this.layoutControlGroup1.Location = new System.Drawing.Point(0, 0);
            this.layoutControlGroup1.Name = "layoutControlGroup1";
            this.layoutControlGroup1.Size = new System.Drawing.Size(622, 283);
            this.layoutControlGroup1.Spacing = new DevExpress.XtraLayout.Utils.Padding(0, 0, 0, 0);
            this.layoutControlGroup1.Text = "layoutControlGroup1";
            this.layoutControlGroup1.TextVisible = false;
            // 
            // layoutControlItem2
            // 
            this.layoutControlItem2.Control = this.trainingTitleTextEdit;
            this.layoutControlItem2.CustomizationFormText = "Training Title:";
            this.layoutControlItem2.Location = new System.Drawing.Point(0, 0);
            this.layoutControlItem2.Name = "layoutControlItem2";
            this.layoutControlItem2.Size = new System.Drawing.Size(602, 24);
            this.layoutControlItem2.Text = "Training Title:";
            this.layoutControlItem2.TextSize = new System.Drawing.Size(163, 13);
            // 
            // layoutControlItem3
            // 
            this.layoutControlItem3.Control = this.trainingCategoryIdLookUpEdit;
            this.layoutControlItem3.CustomizationFormText = "Training Category Id:";
            this.layoutControlItem3.Location = new System.Drawing.Point(0, 24);
            this.layoutControlItem3.Name = "layoutControlItem3";
            this.layoutControlItem3.Size = new System.Drawing.Size(301, 24);
            this.layoutControlItem3.Text = "Training Category :";
            this.layoutControlItem3.TextSize = new System.Drawing.Size(163, 13);
            // 
            // layoutControlItem5
            // 
            this.layoutControlItem5.Control = this.estimatedBudgetTextEdit;
            this.layoutControlItem5.CustomizationFormText = "Estimated Budget:";
            this.layoutControlItem5.Location = new System.Drawing.Point(0, 71);
            this.layoutControlItem5.Name = "layoutControlItem5";
            this.layoutControlItem5.Size = new System.Drawing.Size(602, 24);
            this.layoutControlItem5.Text = "Estimated Budget:";
            this.layoutControlItem5.TextSize = new System.Drawing.Size(163, 13);
            // 
            // layoutControlItem6
            // 
            this.layoutControlItem6.Control = this.estimatedNumberOfAttendantsTextEdit;
            this.layoutControlItem6.CustomizationFormText = "Estimated Number Of Attendants:";
            this.layoutControlItem6.Location = new System.Drawing.Point(0, 95);
            this.layoutControlItem6.Name = "layoutControlItem6";
            this.layoutControlItem6.Size = new System.Drawing.Size(300, 24);
            this.layoutControlItem6.Text = "Estimated Number Of Attendants:";
            this.layoutControlItem6.TextSize = new System.Drawing.Size(163, 13);
            // 
            // layoutControlItem7
            // 
            this.layoutControlItem7.Control = this.requestedDateDateEdit;
            this.layoutControlItem7.CustomizationFormText = "Requested Date:";
            this.layoutControlItem7.Location = new System.Drawing.Point(300, 95);
            this.layoutControlItem7.Name = "layoutControlItem7";
            this.layoutControlItem7.Size = new System.Drawing.Size(302, 24);
            this.layoutControlItem7.Text = "Requested Date:";
            this.layoutControlItem7.TextSize = new System.Drawing.Size(163, 13);
            // 
            // layoutControlItem8
            // 
            this.layoutControlItem8.Control = this.requestedByTextEdit;
            this.layoutControlItem8.CustomizationFormText = "Requested By:";
            this.layoutControlItem8.Location = new System.Drawing.Point(0, 119);
            this.layoutControlItem8.Name = "layoutControlItem8";
            this.layoutControlItem8.Size = new System.Drawing.Size(602, 24);
            this.layoutControlItem8.Text = "Requested By:";
            this.layoutControlItem8.TextSize = new System.Drawing.Size(163, 13);
            // 
            // layoutControlItem9
            // 
            this.layoutControlItem9.Control = this.trainingDescriptionMemoEdit;
            this.layoutControlItem9.CustomizationFormText = "Training Description:";
            this.layoutControlItem9.Location = new System.Drawing.Point(0, 143);
            this.layoutControlItem9.Name = "layoutControlItem9";
            this.layoutControlItem9.Size = new System.Drawing.Size(602, 120);
            this.layoutControlItem9.Text = "Training Description:";
            this.layoutControlItem9.TextSize = new System.Drawing.Size(163, 13);
            // 
            // layoutControlItem4
            // 
            this.layoutControlItem4.Control = this.budgetSecuredCheckEdit;
            this.layoutControlItem4.CustomizationFormText = "Budget Secured:";
            this.layoutControlItem4.Location = new System.Drawing.Point(0, 48);
            this.layoutControlItem4.Name = "layoutControlItem4";
            this.layoutControlItem4.Size = new System.Drawing.Size(602, 23);
            this.layoutControlItem4.Text = "Budget Secured:";
            this.layoutControlItem4.TextSize = new System.Drawing.Size(0, 0);
            this.layoutControlItem4.TextToControlDistance = 0;
            this.layoutControlItem4.TextVisible = false;
            // 
            // layoutControlItem1
            // 
            this.layoutControlItem1.Control = this.addTrainingCategoryHyperLinkEdit;
            this.layoutControlItem1.CustomizationFormText = "layoutControlItem1";
            this.layoutControlItem1.Location = new System.Drawing.Point(301, 24);
            this.layoutControlItem1.Name = "layoutControlItem1";
            this.layoutControlItem1.Size = new System.Drawing.Size(301, 24);
            this.layoutControlItem1.Text = "layoutControlItem1";
            this.layoutControlItem1.TextSize = new System.Drawing.Size(0, 0);
            this.layoutControlItem1.TextToControlDistance = 0;
            this.layoutControlItem1.TextVisible = false;
            // 
            // NewTrainingRequestView
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(622, 312);
            this.Controls.Add(this.layoutControl1);
            this.Controls.Add(this.btnCancelRequest);
            this.Controls.Add(this.btnSaveTrainingRequest);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "NewTrainingRequestView";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Training Request";
            ((System.ComponentModel.ISupportInitialize)(this.traningRequestErrorProvider)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.trainingRequestBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControl1)).EndInit();
            this.layoutControl1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.addTrainingCategoryHyperLinkEdit.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.budgetSecuredCheckEdit.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.trainingDescriptionMemoEdit.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.requestedByTextEdit.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.requestedDateDateEdit.Properties.VistaTimeProperties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.requestedDateDateEdit.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.estimatedNumberOfAttendantsTextEdit.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.estimatedBudgetTextEdit.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.trainingCategoryIdLookUpEdit.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.trainingCategoryBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.trainingTitleTextEdit.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlGroup1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem5)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem6)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem7)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem8)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem9)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.BindingSource trainingRequestBindingSource;
        private System.Windows.Forms.ErrorProvider traningRequestErrorProvider;
        private DevExpress.XtraLayout.LayoutControl layoutControl1;
        private DevExpress.XtraEditors.MemoEdit trainingDescriptionMemoEdit;
        private DevExpress.XtraEditors.TextEdit requestedByTextEdit;
        private DevExpress.XtraEditors.DateEdit requestedDateDateEdit;
        private DevExpress.XtraEditors.TextEdit estimatedNumberOfAttendantsTextEdit;
        private DevExpress.XtraEditors.LookUpEdit trainingCategoryIdLookUpEdit;
        private DevExpress.XtraEditors.TextEdit trainingTitleTextEdit;
        private DevExpress.XtraLayout.LayoutControlGroup layoutControlGroup1;
        private DevExpress.XtraLayout.LayoutControlItem layoutControlItem2;
        private DevExpress.XtraLayout.LayoutControlItem layoutControlItem3;
        private DevExpress.XtraLayout.LayoutControlItem layoutControlItem6;
        private DevExpress.XtraLayout.LayoutControlItem layoutControlItem7;
        private DevExpress.XtraLayout.LayoutControlItem layoutControlItem8;
        private DevExpress.XtraLayout.LayoutControlItem layoutControlItem9;
        private DevExpress.XtraEditors.SimpleButton btnCancelRequest;
        private DevExpress.XtraEditors.SimpleButton btnSaveTrainingRequest;
        private DevExpress.XtraEditors.TextEdit estimatedBudgetTextEdit;
        private DevExpress.XtraLayout.LayoutControlItem layoutControlItem5;
        private System.Windows.Forms.BindingSource trainingCategoryBindingSource;
        private DevExpress.XtraEditors.CheckEdit budgetSecuredCheckEdit;
        private DevExpress.XtraLayout.LayoutControlItem layoutControlItem4;
        private DevExpress.XtraEditors.HyperLinkEdit addTrainingCategoryHyperLinkEdit;
        private DevExpress.XtraLayout.LayoutControlItem layoutControlItem1;
    }
}