namespace ClearOffice.Hrm.Views
{
    partial class NewPersonView
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
            System.Windows.Forms.Label firstNameLabel;
            System.Windows.Forms.Label lastNameLabel;
            System.Windows.Forms.Label grandFatherNameLabel;
            System.Windows.Forms.Label dobLabel;
            System.Windows.Forms.Label remarkLabel;
            System.Windows.Forms.Label nationalityIdLabel;
            System.Windows.Forms.Label maritalStatusIdLabel;
            System.Windows.Forms.Label sexLabel;
            this.personErrorProvider = new System.Windows.Forms.ErrorProvider(this.components);
            this.personBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.CancelCommand = new DevExpress.XtraEditors.SimpleButton();
            this.SaveCommand = new DevExpress.XtraEditors.SimpleButton();
            this.firstNameTextEdit = new DevExpress.XtraEditors.TextEdit();
            this.lastNameTextEdit = new DevExpress.XtraEditors.TextEdit();
            this.grandFatherNameTextEdit = new DevExpress.XtraEditors.TextEdit();
            this.dobDateEdit = new DevExpress.XtraEditors.DateEdit();
            this.remarkMemoEdit = new DevExpress.XtraEditors.MemoEdit();
            this.photoPictureEdit = new DevExpress.XtraEditors.PictureEdit();
            this.nationalityIdLookUpEdit = new DevExpress.XtraEditors.LookUpEdit();
            this.nationalityBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.maritalStatusIdLookUpEdit = new DevExpress.XtraEditors.LookUpEdit();
            this.maritalStatusBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.sexLookUpEdit = new DevExpress.XtraEditors.LookUpEdit();
            this.sexBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.addNationalityHyperLinkEdit = new DevExpress.XtraEditors.HyperLinkEdit();
            firstNameLabel = new System.Windows.Forms.Label();
            lastNameLabel = new System.Windows.Forms.Label();
            grandFatherNameLabel = new System.Windows.Forms.Label();
            dobLabel = new System.Windows.Forms.Label();
            remarkLabel = new System.Windows.Forms.Label();
            nationalityIdLabel = new System.Windows.Forms.Label();
            maritalStatusIdLabel = new System.Windows.Forms.Label();
            sexLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.personErrorProvider)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.personBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.firstNameTextEdit.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.lastNameTextEdit.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.grandFatherNameTextEdit.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dobDateEdit.Properties.VistaTimeProperties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dobDateEdit.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.remarkMemoEdit.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.photoPictureEdit.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nationalityIdLookUpEdit.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nationalityBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.maritalStatusIdLookUpEdit.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.maritalStatusBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.sexLookUpEdit.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.sexBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.addNationalityHyperLinkEdit.Properties)).BeginInit();
            this.SuspendLayout();
            // 
            // firstNameLabel
            // 
            firstNameLabel.AutoSize = true;
            firstNameLabel.Location = new System.Drawing.Point(7, 16);
            firstNameLabel.Name = "firstNameLabel";
            firstNameLabel.Size = new System.Drawing.Size(62, 13);
            firstNameLabel.TabIndex = 128;
            firstNameLabel.Text = "First Name:";
            // 
            // lastNameLabel
            // 
            lastNameLabel.AutoSize = true;
            lastNameLabel.Location = new System.Drawing.Point(7, 42);
            lastNameLabel.Name = "lastNameLabel";
            lastNameLabel.Size = new System.Drawing.Size(73, 13);
            lastNameLabel.TabIndex = 129;
            lastNameLabel.Text = "Father Name:";
            // 
            // grandFatherNameLabel
            // 
            grandFatherNameLabel.AutoSize = true;
            grandFatherNameLabel.Location = new System.Drawing.Point(7, 68);
            grandFatherNameLabel.Name = "grandFatherNameLabel";
            grandFatherNameLabel.Size = new System.Drawing.Size(84, 13);
            grandFatherNameLabel.TabIndex = 130;
            grandFatherNameLabel.Text = "G/Father Name:";
            // 
            // dobLabel
            // 
            dobLabel.AutoSize = true;
            dobLabel.Location = new System.Drawing.Point(7, 94);
            dobLabel.Name = "dobLabel";
            dobLabel.Size = new System.Drawing.Size(72, 13);
            dobLabel.TabIndex = 131;
            dobLabel.Text = "Date of birth:";
            // 
            // remarkLabel
            // 
            remarkLabel.AutoSize = true;
            remarkLabel.Location = new System.Drawing.Point(7, 195);
            remarkLabel.Name = "remarkLabel";
            remarkLabel.Size = new System.Drawing.Size(47, 13);
            remarkLabel.TabIndex = 132;
            remarkLabel.Text = "Remark:";
            // 
            // nationalityIdLabel
            // 
            nationalityIdLabel.AutoSize = true;
            nationalityIdLabel.Location = new System.Drawing.Point(7, 120);
            nationalityIdLabel.Name = "nationalityIdLabel";
            nationalityIdLabel.Size = new System.Drawing.Size(62, 13);
            nationalityIdLabel.TabIndex = 134;
            nationalityIdLabel.Text = "Nationality:";
            // 
            // maritalStatusIdLabel
            // 
            maritalStatusIdLabel.AutoSize = true;
            maritalStatusIdLabel.Location = new System.Drawing.Point(7, 146);
            maritalStatusIdLabel.Name = "maritalStatusIdLabel";
            maritalStatusIdLabel.Size = new System.Drawing.Size(77, 13);
            maritalStatusIdLabel.TabIndex = 135;
            maritalStatusIdLabel.Text = "Marital Status:";
            // 
            // sexLabel
            // 
            sexLabel.AutoSize = true;
            sexLabel.Location = new System.Drawing.Point(7, 172);
            sexLabel.Name = "sexLabel";
            sexLabel.Size = new System.Drawing.Size(29, 13);
            sexLabel.TabIndex = 136;
            sexLabel.Text = "Sex:";
            // 
            // personErrorProvider
            // 
            this.personErrorProvider.ContainerControl = this;
            this.personErrorProvider.DataSource = this.personBindingSource;
            // 
            // personBindingSource
            // 
            this.personBindingSource.DataSource = typeof(ClearOffice.Hrm.Business.Data.Person);
            this.personBindingSource.CurrentItemChanged += new System.EventHandler(this.personBindingSource_CurrentItemChanged);
            // 
            // CancelCommand
            // 
            this.CancelCommand.Location = new System.Drawing.Point(265, 273);
            this.CancelCommand.Name = "CancelCommand";
            this.CancelCommand.Size = new System.Drawing.Size(82, 23);
            this.CancelCommand.TabIndex = 10;
            this.CancelCommand.Text = "Cancel";
            this.CancelCommand.Click += new System.EventHandler(this.CancelCommand_Click);
            // 
            // SaveCommand
            // 
            this.SaveCommand.Location = new System.Drawing.Point(166, 273);
            this.SaveCommand.Name = "SaveCommand";
            this.SaveCommand.Size = new System.Drawing.Size(82, 23);
            this.SaveCommand.TabIndex = 9;
            this.SaveCommand.Text = "Save";
            this.SaveCommand.Click += new System.EventHandler(this.SaveCommand_Click);
            // 
            // firstNameTextEdit
            // 
            this.firstNameTextEdit.DataBindings.Add(new System.Windows.Forms.Binding("EditValue", this.personBindingSource, "FirstName", true, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged));
            this.firstNameTextEdit.Location = new System.Drawing.Point(91, 12);
            this.firstNameTextEdit.Name = "firstNameTextEdit";
            this.firstNameTextEdit.Size = new System.Drawing.Size(179, 20);
            this.firstNameTextEdit.TabIndex = 0;
            // 
            // lastNameTextEdit
            // 
            this.lastNameTextEdit.DataBindings.Add(new System.Windows.Forms.Binding("EditValue", this.personBindingSource, "LastName", true, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged));
            this.lastNameTextEdit.Location = new System.Drawing.Point(91, 38);
            this.lastNameTextEdit.Name = "lastNameTextEdit";
            this.lastNameTextEdit.Size = new System.Drawing.Size(179, 20);
            this.lastNameTextEdit.TabIndex = 1;
            // 
            // grandFatherNameTextEdit
            // 
            this.grandFatherNameTextEdit.DataBindings.Add(new System.Windows.Forms.Binding("EditValue", this.personBindingSource, "GrandFatherName", true, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged));
            this.grandFatherNameTextEdit.Location = new System.Drawing.Point(91, 64);
            this.grandFatherNameTextEdit.Name = "grandFatherNameTextEdit";
            this.grandFatherNameTextEdit.Size = new System.Drawing.Size(179, 20);
            this.grandFatherNameTextEdit.TabIndex = 2;
            // 
            // dobDateEdit
            // 
            this.dobDateEdit.DataBindings.Add(new System.Windows.Forms.Binding("EditValue", this.personBindingSource, "Dob", true, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged));
            this.dobDateEdit.EditValue = null;
            this.dobDateEdit.Location = new System.Drawing.Point(91, 90);
            this.dobDateEdit.Name = "dobDateEdit";
            this.dobDateEdit.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.dobDateEdit.Properties.VistaTimeProperties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton()});
            this.dobDateEdit.Size = new System.Drawing.Size(179, 20);
            this.dobDateEdit.TabIndex = 3;
            // 
            // remarkMemoEdit
            // 
            this.remarkMemoEdit.DataBindings.Add(new System.Windows.Forms.Binding("EditValue", this.personBindingSource, "Remark", true));
            this.remarkMemoEdit.Location = new System.Drawing.Point(91, 199);
            this.remarkMemoEdit.Name = "remarkMemoEdit";
            this.remarkMemoEdit.Size = new System.Drawing.Size(363, 56);
            this.remarkMemoEdit.TabIndex = 8;
            // 
            // photoPictureEdit
            // 
            this.photoPictureEdit.DataBindings.Add(new System.Windows.Forms.Binding("EditValue", this.personBindingSource, "Photo", true));
            this.photoPictureEdit.Location = new System.Drawing.Point(276, 10);
            this.photoPictureEdit.Name = "photoPictureEdit";
            this.photoPictureEdit.Size = new System.Drawing.Size(178, 179);
            this.photoPictureEdit.TabIndex = 7;
            // 
            // nationalityIdLookUpEdit
            // 
            this.nationalityIdLookUpEdit.DataBindings.Add(new System.Windows.Forms.Binding("EditValue", this.personBindingSource, "NationalityId", true));
            this.nationalityIdLookUpEdit.Location = new System.Drawing.Point(91, 116);
            this.nationalityIdLookUpEdit.Name = "nationalityIdLookUpEdit";
            this.nationalityIdLookUpEdit.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.nationalityIdLookUpEdit.Properties.Columns.AddRange(new DevExpress.XtraEditors.Controls.LookUpColumnInfo[] {
            new DevExpress.XtraEditors.Controls.LookUpColumnInfo("NationalityName", "Nationalities", 91, DevExpress.Utils.FormatType.None, "", true, DevExpress.Utils.HorzAlignment.Near)});
            this.nationalityIdLookUpEdit.Properties.DataSource = this.nationalityBindingSource;
            this.nationalityIdLookUpEdit.Properties.DisplayMember = "NationalityName";
            this.nationalityIdLookUpEdit.Properties.NullText = "[Select Nationality]";
            this.nationalityIdLookUpEdit.Properties.ValueMember = "NationalityId";
            this.nationalityIdLookUpEdit.Size = new System.Drawing.Size(142, 20);
            this.nationalityIdLookUpEdit.TabIndex = 4;
            // 
            // nationalityBindingSource
            // 
            this.nationalityBindingSource.DataSource = typeof(ClearOffice.Hrm.Business.Data.Nationality);
            // 
            // maritalStatusIdLookUpEdit
            // 
            this.maritalStatusIdLookUpEdit.DataBindings.Add(new System.Windows.Forms.Binding("EditValue", this.personBindingSource, "MaritalStatusId", true));
            this.maritalStatusIdLookUpEdit.Location = new System.Drawing.Point(91, 142);
            this.maritalStatusIdLookUpEdit.Name = "maritalStatusIdLookUpEdit";
            this.maritalStatusIdLookUpEdit.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.maritalStatusIdLookUpEdit.Properties.Columns.AddRange(new DevExpress.XtraEditors.Controls.LookUpColumnInfo[] {
            new DevExpress.XtraEditors.Controls.LookUpColumnInfo("MaritalStatusType", "Marital Status", 103, DevExpress.Utils.FormatType.None, "", true, DevExpress.Utils.HorzAlignment.Near)});
            this.maritalStatusIdLookUpEdit.Properties.DataSource = this.maritalStatusBindingSource;
            this.maritalStatusIdLookUpEdit.Properties.DisplayMember = "MaritalStatusType";
            this.maritalStatusIdLookUpEdit.Properties.NullText = "[Select Marital Status]";
            this.maritalStatusIdLookUpEdit.Properties.ValueMember = "MaritalStatusId";
            this.maritalStatusIdLookUpEdit.Size = new System.Drawing.Size(179, 20);
            this.maritalStatusIdLookUpEdit.TabIndex = 5;
            // 
            // maritalStatusBindingSource
            // 
            this.maritalStatusBindingSource.DataSource = typeof(ClearOffice.Hrm.Business.Data.MaritalStatus);
            // 
            // sexLookUpEdit
            // 
            this.sexLookUpEdit.DataBindings.Add(new System.Windows.Forms.Binding("EditValue", this.personBindingSource, "Sex", true));
            this.sexLookUpEdit.Location = new System.Drawing.Point(91, 168);
            this.sexLookUpEdit.Name = "sexLookUpEdit";
            this.sexLookUpEdit.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.sexLookUpEdit.Properties.Columns.AddRange(new DevExpress.XtraEditors.Controls.LookUpColumnInfo[] {
            new DevExpress.XtraEditors.Controls.LookUpColumnInfo("Name", "Sex", 37, DevExpress.Utils.FormatType.None, "", true, DevExpress.Utils.HorzAlignment.Near)});
            this.sexLookUpEdit.Properties.DataSource = this.sexBindingSource;
            this.sexLookUpEdit.Properties.DisplayMember = "Name";
            this.sexLookUpEdit.Properties.NullText = "[Select Sex]";
            this.sexLookUpEdit.Properties.ValueMember = "RecordId";
            this.sexLookUpEdit.Size = new System.Drawing.Size(179, 20);
            this.sexLookUpEdit.TabIndex = 6;
            // 
            // sexBindingSource
            // 
            this.sexBindingSource.DataSource = typeof(ClearOffice.Hrm.Business.Data.Sex);
            // 
            // addNationalityHyperLinkEdit
            // 
            this.addNationalityHyperLinkEdit.EditValue = "";
            this.addNationalityHyperLinkEdit.Location = new System.Drawing.Point(236, 117);
            this.addNationalityHyperLinkEdit.Margin = new System.Windows.Forms.Padding(0);
            this.addNationalityHyperLinkEdit.Name = "addNationalityHyperLinkEdit";
            this.addNationalityHyperLinkEdit.Properties.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.NoBorder;
            this.addNationalityHyperLinkEdit.Properties.Image = global::ClearOffice.Hrm.Properties.Resources.add;
            this.addNationalityHyperLinkEdit.Size = new System.Drawing.Size(34, 18);
            this.addNationalityHyperLinkEdit.TabIndex = 137;
            this.addNationalityHyperLinkEdit.ToolTip = "Add New Education Level";
            this.addNationalityHyperLinkEdit.ToolTipTitle = "Add";
            this.addNationalityHyperLinkEdit.Click += new System.EventHandler(this.addNationalityHyperLinkEdit_Click);
            // 
            // NewPersonView
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(466, 305);
            this.Controls.Add(this.addNationalityHyperLinkEdit);
            this.Controls.Add(sexLabel);
            this.Controls.Add(this.sexLookUpEdit);
            this.Controls.Add(maritalStatusIdLabel);
            this.Controls.Add(this.maritalStatusIdLookUpEdit);
            this.Controls.Add(nationalityIdLabel);
            this.Controls.Add(this.nationalityIdLookUpEdit);
            this.Controls.Add(this.photoPictureEdit);
            this.Controls.Add(remarkLabel);
            this.Controls.Add(this.remarkMemoEdit);
            this.Controls.Add(dobLabel);
            this.Controls.Add(this.dobDateEdit);
            this.Controls.Add(grandFatherNameLabel);
            this.Controls.Add(this.grandFatherNameTextEdit);
            this.Controls.Add(lastNameLabel);
            this.Controls.Add(this.lastNameTextEdit);
            this.Controls.Add(firstNameLabel);
            this.Controls.Add(this.firstNameTextEdit);
            this.Controls.Add(this.CancelCommand);
            this.Controls.Add(this.SaveCommand);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "NewPersonView";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "New Employee";
            ((System.ComponentModel.ISupportInitialize)(this.personErrorProvider)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.personBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.firstNameTextEdit.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.lastNameTextEdit.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.grandFatherNameTextEdit.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dobDateEdit.Properties.VistaTimeProperties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dobDateEdit.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.remarkMemoEdit.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.photoPictureEdit.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nationalityIdLookUpEdit.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nationalityBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.maritalStatusIdLookUpEdit.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.maritalStatusBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.sexLookUpEdit.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.sexBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.addNationalityHyperLinkEdit.Properties)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.BindingSource personBindingSource;
        private System.Windows.Forms.ErrorProvider personErrorProvider;
        private DevExpress.XtraEditors.SimpleButton CancelCommand;
        private DevExpress.XtraEditors.SimpleButton SaveCommand;
        private DevExpress.XtraEditors.PictureEdit photoPictureEdit;
        private DevExpress.XtraEditors.MemoEdit remarkMemoEdit;
        private DevExpress.XtraEditors.DateEdit dobDateEdit;
        private DevExpress.XtraEditors.TextEdit grandFatherNameTextEdit;
        private DevExpress.XtraEditors.TextEdit lastNameTextEdit;
        private DevExpress.XtraEditors.TextEdit firstNameTextEdit;
        private DevExpress.XtraEditors.LookUpEdit sexLookUpEdit;
        private DevExpress.XtraEditors.LookUpEdit maritalStatusIdLookUpEdit;
        private DevExpress.XtraEditors.LookUpEdit nationalityIdLookUpEdit;
        private System.Windows.Forms.BindingSource maritalStatusBindingSource;
        private System.Windows.Forms.BindingSource nationalityBindingSource;
        private System.Windows.Forms.BindingSource sexBindingSource;
        private DevExpress.XtraEditors.HyperLinkEdit addNationalityHyperLinkEdit;
    }
}