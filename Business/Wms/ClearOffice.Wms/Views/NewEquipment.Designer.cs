namespace ClearOffice.Wms.Views
{
    partial class NewEquipment
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
            System.Windows.Forms.Label categoryIdLabel;
            System.Windows.Forms.Label makeLabel;
            System.Windows.Forms.Label modelLabel;
            System.Windows.Forms.Label serialLabel;
            System.Windows.Forms.Label dateInstalledLabel;
            System.Windows.Forms.Label photoLabel;
            System.Windows.Forms.Label baseHoursLabel;
            System.Windows.Forms.Label baseMileageLabel;
            System.Windows.Forms.Label baseDateLabel;
            System.Windows.Forms.Label assignedLabel;
            System.Windows.Forms.Label descriptionLabel;
            System.Windows.Forms.Label remarkLabel;
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(NewEquipment));
            this.equipmentBindingSource = new System.Windows.Forms.BindingSource();
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.saveToolStripButton = new System.Windows.Forms.ToolStripButton();
            this.BtnSaveAndNew = new System.Windows.Forms.ToolStripButton();
            this.NewEquiErrorProvider = new System.Windows.Forms.ErrorProvider();
            this.categoryIdLookUpEdit = new DevExpress.XtraEditors.LookUpEdit();
            this.CatagoryBindingSource = new System.Windows.Forms.BindingSource();
            this.makeLookUpEdit = new DevExpress.XtraEditors.LookUpEdit();
            this.MakeBindingSource = new System.Windows.Forms.BindingSource();
            this.modelLookUpEdit = new DevExpress.XtraEditors.LookUpEdit();
            this.ModelBindingSource = new System.Windows.Forms.BindingSource();
            this.serialTextBox = new System.Windows.Forms.TextBox();
            this.dateInstalledDateEdit = new DevExpress.XtraEditors.DateEdit();
            this.photoPictureEdit = new DevExpress.XtraEditors.PictureEdit();
            this.baseHoursTextBox = new System.Windows.Forms.TextBox();
            this.baseMileageTextBox = new System.Windows.Forms.TextBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.MileageRadioButton = new System.Windows.Forms.RadioButton();
            this.BaseHoureRadioButton = new System.Windows.Forms.RadioButton();
            this.baseDateDateEdit = new DevExpress.XtraEditors.DateEdit();
            this.assignedTextBox = new System.Windows.Forms.TextBox();
            this.descriptionTextBox = new System.Windows.Forms.TextBox();
            this.remarkTextBox = new System.Windows.Forms.TextBox();
            categoryIdLabel = new System.Windows.Forms.Label();
            makeLabel = new System.Windows.Forms.Label();
            modelLabel = new System.Windows.Forms.Label();
            serialLabel = new System.Windows.Forms.Label();
            dateInstalledLabel = new System.Windows.Forms.Label();
            photoLabel = new System.Windows.Forms.Label();
            baseHoursLabel = new System.Windows.Forms.Label();
            baseMileageLabel = new System.Windows.Forms.Label();
            baseDateLabel = new System.Windows.Forms.Label();
            assignedLabel = new System.Windows.Forms.Label();
            descriptionLabel = new System.Windows.Forms.Label();
            remarkLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.equipmentBindingSource)).BeginInit();
            this.toolStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.NewEquiErrorProvider)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.categoryIdLookUpEdit.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.CatagoryBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.makeLookUpEdit.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.MakeBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.modelLookUpEdit.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ModelBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dateInstalledDateEdit.Properties.VistaTimeProperties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dateInstalledDateEdit.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.photoPictureEdit.Properties)).BeginInit();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.baseDateDateEdit.Properties.VistaTimeProperties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.baseDateDateEdit.Properties)).BeginInit();
            this.SuspendLayout();
            // 
            // categoryIdLabel
            // 
            categoryIdLabel.AutoSize = true;
            categoryIdLabel.Location = new System.Drawing.Point(10, 38);
            categoryIdLabel.Name = "categoryIdLabel";
            categoryIdLabel.Size = new System.Drawing.Size(56, 13);
            categoryIdLabel.TabIndex = 7;
            categoryIdLabel.Text = "Category:";
            // 
            // makeLabel
            // 
            makeLabel.AutoSize = true;
            makeLabel.Location = new System.Drawing.Point(10, 64);
            makeLabel.Name = "makeLabel";
            makeLabel.Size = new System.Drawing.Size(36, 13);
            makeLabel.TabIndex = 9;
            makeLabel.Text = "Make:";
            // 
            // modelLabel
            // 
            modelLabel.AutoSize = true;
            modelLabel.Location = new System.Drawing.Point(10, 90);
            modelLabel.Name = "modelLabel";
            modelLabel.Size = new System.Drawing.Size(39, 13);
            modelLabel.TabIndex = 11;
            modelLabel.Text = "Model:";
            // 
            // serialLabel
            // 
            serialLabel.AutoSize = true;
            serialLabel.Location = new System.Drawing.Point(10, 116);
            serialLabel.Name = "serialLabel";
            serialLabel.Size = new System.Drawing.Size(48, 13);
            serialLabel.TabIndex = 12;
            serialLabel.Text = "Serial #:";
            // 
            // dateInstalledLabel
            // 
            dateInstalledLabel.AutoSize = true;
            dateInstalledLabel.Location = new System.Drawing.Point(10, 143);
            dateInstalledLabel.Name = "dateInstalledLabel";
            dateInstalledLabel.Size = new System.Drawing.Size(78, 13);
            dateInstalledLabel.TabIndex = 13;
            dateInstalledLabel.Text = "Date Installed:";
            // 
            // photoLabel
            // 
            photoLabel.AutoSize = true;
            photoLabel.Location = new System.Drawing.Point(389, 40);
            photoLabel.Name = "photoLabel";
            photoLabel.Size = new System.Drawing.Size(44, 13);
            photoLabel.TabIndex = 14;
            photoLabel.Text = "Picture:";
            // 
            // baseHoursLabel
            // 
            baseHoursLabel.AutoSize = true;
            baseHoursLabel.Location = new System.Drawing.Point(49, 60);
            baseHoursLabel.Name = "baseHoursLabel";
            baseHoursLabel.Size = new System.Drawing.Size(65, 13);
            baseHoursLabel.TabIndex = 15;
            baseHoursLabel.Text = "Base Hours:";
            // 
            // baseMileageLabel
            // 
            baseMileageLabel.AutoSize = true;
            baseMileageLabel.Location = new System.Drawing.Point(41, 119);
            baseMileageLabel.Name = "baseMileageLabel";
            baseMileageLabel.Size = new System.Drawing.Size(73, 13);
            baseMileageLabel.TabIndex = 16;
            baseMileageLabel.Text = "Base Mileage:";
            // 
            // baseDateLabel
            // 
            baseDateLabel.AutoSize = true;
            baseDateLabel.Location = new System.Drawing.Point(15, 153);
            baseDateLabel.Name = "baseDateLabel";
            baseDateLabel.Size = new System.Drawing.Size(60, 13);
            baseDateLabel.TabIndex = 18;
            baseDateLabel.Text = "Base Date:";
            // 
            // assignedLabel
            // 
            assignedLabel.AutoSize = true;
            assignedLabel.Location = new System.Drawing.Point(389, 180);
            assignedLabel.Name = "assignedLabel";
            assignedLabel.Size = new System.Drawing.Size(54, 13);
            assignedLabel.TabIndex = 19;
            assignedLabel.Text = "Assigned:";
            // 
            // descriptionLabel
            // 
            descriptionLabel.AutoSize = true;
            descriptionLabel.Location = new System.Drawing.Point(389, 276);
            descriptionLabel.Name = "descriptionLabel";
            descriptionLabel.Size = new System.Drawing.Size(64, 13);
            descriptionLabel.TabIndex = 20;
            descriptionLabel.Text = "Description:";
            // 
            // remarkLabel
            // 
            remarkLabel.AutoSize = true;
            remarkLabel.Location = new System.Drawing.Point(389, 207);
            remarkLabel.Name = "remarkLabel";
            remarkLabel.Size = new System.Drawing.Size(47, 13);
            remarkLabel.TabIndex = 21;
            remarkLabel.Text = "Remark:";
            // 
            // equipmentBindingSource
            // 
            this.equipmentBindingSource.DataSource = typeof(ClearOffice.Wms.Business.Equipment);
            this.equipmentBindingSource.CurrentItemChanged += new System.EventHandler(this.equipmentBindingSource_CurrentItemChanged);
            // 
            // toolStrip1
            // 
            this.toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.saveToolStripButton,
            this.BtnSaveAndNew});
            this.toolStrip1.Location = new System.Drawing.Point(0, 0);
            this.toolStrip1.Name = "toolStrip1";
            this.toolStrip1.Size = new System.Drawing.Size(810, 25);
            this.toolStrip1.TabIndex = 0;
            this.toolStrip1.Text = "toolStrip1";
            // 
            // saveToolStripButton
            // 
            this.saveToolStripButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.saveToolStripButton.Image = ((System.Drawing.Image)(resources.GetObject("saveToolStripButton.Image")));
            this.saveToolStripButton.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.saveToolStripButton.Name = "saveToolStripButton";
            this.saveToolStripButton.Size = new System.Drawing.Size(23, 22);
            this.saveToolStripButton.Text = "&Save";
            this.saveToolStripButton.Click += new System.EventHandler(this.saveToolStripButton_Click);
            // 
            // BtnSaveAndNew
            // 
            this.BtnSaveAndNew.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.BtnSaveAndNew.Image = global::ClearOffice.Wms.Properties.Resources.page_save;
            this.BtnSaveAndNew.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.BtnSaveAndNew.Name = "BtnSaveAndNew";
            this.BtnSaveAndNew.Size = new System.Drawing.Size(23, 22);
            this.BtnSaveAndNew.Text = "toolStripButton1";
            this.BtnSaveAndNew.ToolTipText = "Save & New";
            this.BtnSaveAndNew.Click += new System.EventHandler(this.BtnSaveAndNew_Click);
            // 
            // NewEquiErrorProvider
            // 
            this.NewEquiErrorProvider.ContainerControl = this;
            // 
            // categoryIdLookUpEdit
            // 
            this.categoryIdLookUpEdit.DataBindings.Add(new System.Windows.Forms.Binding("EditValue", this.equipmentBindingSource, "CategoryId", true));
            this.categoryIdLookUpEdit.Location = new System.Drawing.Point(94, 35);
            this.categoryIdLookUpEdit.Name = "categoryIdLookUpEdit";
            this.categoryIdLookUpEdit.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.categoryIdLookUpEdit.Properties.Columns.AddRange(new DevExpress.XtraEditors.Controls.LookUpColumnInfo[] {
            new DevExpress.XtraEditors.Controls.LookUpColumnInfo("Name", "Name", 37, DevExpress.Utils.FormatType.None, "", true, DevExpress.Utils.HorzAlignment.Near),
            new DevExpress.XtraEditors.Controls.LookUpColumnInfo("Code", "Code", 35, DevExpress.Utils.FormatType.None, "", true, DevExpress.Utils.HorzAlignment.Near)});
            this.categoryIdLookUpEdit.Properties.DataSource = this.CatagoryBindingSource;
            this.categoryIdLookUpEdit.Properties.DisplayMember = "Name";
            this.categoryIdLookUpEdit.Properties.NullText = "[Select Category]";
            this.categoryIdLookUpEdit.Properties.ValueMember = "ItemId";
            this.categoryIdLookUpEdit.Size = new System.Drawing.Size(253, 20);
            this.categoryIdLookUpEdit.TabIndex = 0;
            // 
            // CatagoryBindingSource
            // 
            this.CatagoryBindingSource.DataSource = typeof(ClearOffice.Wms.Business.LookupItem);
            // 
            // makeLookUpEdit
            // 
            this.makeLookUpEdit.DataBindings.Add(new System.Windows.Forms.Binding("EditValue", this.equipmentBindingSource, "Make", true));
            this.makeLookUpEdit.Location = new System.Drawing.Point(94, 61);
            this.makeLookUpEdit.Name = "makeLookUpEdit";
            this.makeLookUpEdit.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.makeLookUpEdit.Properties.Columns.AddRange(new DevExpress.XtraEditors.Controls.LookUpColumnInfo[] {
            new DevExpress.XtraEditors.Controls.LookUpColumnInfo("Name", "Name", 37, DevExpress.Utils.FormatType.None, "", true, DevExpress.Utils.HorzAlignment.Near),
            new DevExpress.XtraEditors.Controls.LookUpColumnInfo("Code", "Code", 35, DevExpress.Utils.FormatType.None, "", true, DevExpress.Utils.HorzAlignment.Near)});
            this.makeLookUpEdit.Properties.DataSource = this.MakeBindingSource;
            this.makeLookUpEdit.Properties.DisplayMember = "Name";
            this.makeLookUpEdit.Properties.NullText = "[Select Make]";
            this.makeLookUpEdit.Properties.ValueMember = "ItemId";
            this.makeLookUpEdit.Size = new System.Drawing.Size(253, 20);
            this.makeLookUpEdit.TabIndex = 1;
            // 
            // MakeBindingSource
            // 
            this.MakeBindingSource.DataSource = typeof(ClearOffice.Wms.Business.LookupItem);
            // 
            // modelLookUpEdit
            // 
            this.modelLookUpEdit.DataBindings.Add(new System.Windows.Forms.Binding("EditValue", this.equipmentBindingSource, "Model", true));
            this.modelLookUpEdit.Location = new System.Drawing.Point(94, 87);
            this.modelLookUpEdit.Name = "modelLookUpEdit";
            this.modelLookUpEdit.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.modelLookUpEdit.Properties.Columns.AddRange(new DevExpress.XtraEditors.Controls.LookUpColumnInfo[] {
            new DevExpress.XtraEditors.Controls.LookUpColumnInfo("Name", "Name", 37, DevExpress.Utils.FormatType.None, "", true, DevExpress.Utils.HorzAlignment.Near),
            new DevExpress.XtraEditors.Controls.LookUpColumnInfo("Code", "Code", 35, DevExpress.Utils.FormatType.None, "", true, DevExpress.Utils.HorzAlignment.Near)});
            this.modelLookUpEdit.Properties.DataSource = this.ModelBindingSource;
            this.modelLookUpEdit.Properties.DisplayMember = "Name";
            this.modelLookUpEdit.Properties.NullText = "[Select Model]";
            this.modelLookUpEdit.Properties.ValueMember = "ItemId";
            this.modelLookUpEdit.Size = new System.Drawing.Size(253, 20);
            this.modelLookUpEdit.TabIndex = 2;
            // 
            // ModelBindingSource
            // 
            this.ModelBindingSource.DataSource = typeof(ClearOffice.Wms.Business.LookupItem);
            // 
            // serialTextBox
            // 
            this.serialTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.equipmentBindingSource, "Serial", true));
            this.serialTextBox.Location = new System.Drawing.Point(94, 113);
            this.serialTextBox.Name = "serialTextBox";
            this.serialTextBox.Size = new System.Drawing.Size(253, 21);
            this.serialTextBox.TabIndex = 3;
            // 
            // dateInstalledDateEdit
            // 
            this.dateInstalledDateEdit.DataBindings.Add(new System.Windows.Forms.Binding("EditValue", this.equipmentBindingSource, "DateInstalled", true));
            this.dateInstalledDateEdit.EditValue = null;
            this.dateInstalledDateEdit.Location = new System.Drawing.Point(94, 140);
            this.dateInstalledDateEdit.Name = "dateInstalledDateEdit";
            this.dateInstalledDateEdit.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.dateInstalledDateEdit.Properties.VistaTimeProperties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton()});
            this.dateInstalledDateEdit.Size = new System.Drawing.Size(253, 20);
            this.dateInstalledDateEdit.TabIndex = 4;
            // 
            // photoPictureEdit
            // 
            this.photoPictureEdit.DataBindings.Add(new System.Windows.Forms.Binding("EditValue", this.equipmentBindingSource, "Photo", true));
            this.photoPictureEdit.Location = new System.Drawing.Point(452, 40);
            this.photoPictureEdit.Name = "photoPictureEdit";
            this.photoPictureEdit.Size = new System.Drawing.Size(347, 120);
            this.photoPictureEdit.TabIndex = 5;
            // 
            // baseHoursTextBox
            // 
            this.baseHoursTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.equipmentBindingSource, "BaseHours", true));
            this.baseHoursTextBox.Location = new System.Drawing.Point(120, 57);
            this.baseHoursTextBox.Name = "baseHoursTextBox";
            this.baseHoursTextBox.Size = new System.Drawing.Size(193, 21);
            this.baseHoursTextBox.TabIndex = 0;
            this.baseHoursTextBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // baseMileageTextBox
            // 
            this.baseMileageTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.equipmentBindingSource, "BaseMileage", true));
            this.baseMileageTextBox.Location = new System.Drawing.Point(120, 116);
            this.baseMileageTextBox.Name = "baseMileageTextBox";
            this.baseMileageTextBox.Size = new System.Drawing.Size(193, 21);
            this.baseMileageTextBox.TabIndex = 1;
            this.baseMileageTextBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.MileageRadioButton);
            this.groupBox1.Controls.Add(this.BaseHoureRadioButton);
            this.groupBox1.Controls.Add(baseHoursLabel);
            this.groupBox1.Controls.Add(baseMileageLabel);
            this.groupBox1.Controls.Add(this.baseHoursTextBox);
            this.groupBox1.Controls.Add(this.baseMileageTextBox);
            this.groupBox1.Controls.Add(baseDateLabel);
            this.groupBox1.Controls.Add(this.baseDateDateEdit);
            this.groupBox1.Location = new System.Drawing.Point(13, 166);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(334, 204);
            this.groupBox1.TabIndex = 18;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Maintenace Tracking";
            // 
            // MileageRadioButton
            // 
            this.MileageRadioButton.AutoSize = true;
            this.MileageRadioButton.Location = new System.Drawing.Point(17, 84);
            this.MileageRadioButton.Name = "MileageRadioButton";
            this.MileageRadioButton.Size = new System.Drawing.Size(124, 17);
            this.MileageRadioButton.TabIndex = 19;
            this.MileageRadioButton.TabStop = true;
            this.MileageRadioButton.Text = "Measured In Mileage";
            this.MileageRadioButton.UseVisualStyleBackColor = true;
            this.MileageRadioButton.CheckedChanged += new System.EventHandler(this.radioButton2_CheckedChanged);
            // 
            // BaseHoureRadioButton
            // 
            this.BaseHoureRadioButton.AutoSize = true;
            this.BaseHoureRadioButton.Location = new System.Drawing.Point(17, 31);
            this.BaseHoureRadioButton.Name = "BaseHoureRadioButton";
            this.BaseHoureRadioButton.Size = new System.Drawing.Size(121, 17);
            this.BaseHoureRadioButton.TabIndex = 18;
            this.BaseHoureRadioButton.TabStop = true;
            this.BaseHoureRadioButton.Text = "Measured In Houres";
            this.BaseHoureRadioButton.UseVisualStyleBackColor = true;
            this.BaseHoureRadioButton.CheckedChanged += new System.EventHandler(this.radioButton1_CheckedChanged);
            // 
            // baseDateDateEdit
            // 
            this.baseDateDateEdit.DataBindings.Add(new System.Windows.Forms.Binding("EditValue", this.equipmentBindingSource, "BaseDate", true));
            this.baseDateDateEdit.EditValue = null;
            this.baseDateDateEdit.Location = new System.Drawing.Point(81, 150);
            this.baseDateDateEdit.Name = "baseDateDateEdit";
            this.baseDateDateEdit.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.baseDateDateEdit.Properties.VistaTimeProperties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton()});
            this.baseDateDateEdit.Size = new System.Drawing.Size(232, 20);
            this.baseDateDateEdit.TabIndex = 2;
            // 
            // assignedTextBox
            // 
            this.assignedTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.equipmentBindingSource, "Assigned", true));
            this.assignedTextBox.Location = new System.Drawing.Point(452, 177);
            this.assignedTextBox.Name = "assignedTextBox";
            this.assignedTextBox.Size = new System.Drawing.Size(253, 21);
            this.assignedTextBox.TabIndex = 6;
            // 
            // descriptionTextBox
            // 
            this.descriptionTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.equipmentBindingSource, "Description", true));
            this.descriptionTextBox.Location = new System.Drawing.Point(452, 273);
            this.descriptionTextBox.Multiline = true;
            this.descriptionTextBox.Name = "descriptionTextBox";
            this.descriptionTextBox.Size = new System.Drawing.Size(347, 63);
            this.descriptionTextBox.TabIndex = 8;
            // 
            // remarkTextBox
            // 
            this.remarkTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.equipmentBindingSource, "Remark", true));
            this.remarkTextBox.Location = new System.Drawing.Point(452, 204);
            this.remarkTextBox.Multiline = true;
            this.remarkTextBox.Name = "remarkTextBox";
            this.remarkTextBox.Size = new System.Drawing.Size(347, 63);
            this.remarkTextBox.TabIndex = 7;
            // 
            // NewEquipment
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(810, 390);
            this.Controls.Add(remarkLabel);
            this.Controls.Add(this.remarkTextBox);
            this.Controls.Add(descriptionLabel);
            this.Controls.Add(this.descriptionTextBox);
            this.Controls.Add(assignedLabel);
            this.Controls.Add(this.assignedTextBox);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(photoLabel);
            this.Controls.Add(this.photoPictureEdit);
            this.Controls.Add(dateInstalledLabel);
            this.Controls.Add(this.dateInstalledDateEdit);
            this.Controls.Add(serialLabel);
            this.Controls.Add(this.serialTextBox);
            this.Controls.Add(modelLabel);
            this.Controls.Add(this.modelLookUpEdit);
            this.Controls.Add(makeLabel);
            this.Controls.Add(this.makeLookUpEdit);
            this.Controls.Add(categoryIdLabel);
            this.Controls.Add(this.categoryIdLookUpEdit);
            this.Controls.Add(this.toolStrip1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "NewEquipment";
            this.Text = "New Equipment";
            ((System.ComponentModel.ISupportInitialize)(this.equipmentBindingSource)).EndInit();
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.NewEquiErrorProvider)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.categoryIdLookUpEdit.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.CatagoryBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.makeLookUpEdit.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.MakeBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.modelLookUpEdit.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ModelBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dateInstalledDateEdit.Properties.VistaTimeProperties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dateInstalledDateEdit.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.photoPictureEdit.Properties)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.baseDateDateEdit.Properties.VistaTimeProperties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.baseDateDateEdit.Properties)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.BindingSource equipmentBindingSource;
        private System.Windows.Forms.ToolStrip toolStrip1;
        private System.Windows.Forms.ToolStripButton saveToolStripButton;
        private System.Windows.Forms.ErrorProvider NewEquiErrorProvider;
        private System.Windows.Forms.TextBox remarkTextBox;
        private System.Windows.Forms.TextBox descriptionTextBox;
        private System.Windows.Forms.TextBox assignedTextBox;
        private DevExpress.XtraEditors.DateEdit baseDateDateEdit;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.RadioButton MileageRadioButton;
        private System.Windows.Forms.RadioButton BaseHoureRadioButton;
        private System.Windows.Forms.TextBox baseHoursTextBox;
        private System.Windows.Forms.TextBox baseMileageTextBox;
        private DevExpress.XtraEditors.PictureEdit photoPictureEdit;
        private DevExpress.XtraEditors.DateEdit dateInstalledDateEdit;
        private System.Windows.Forms.TextBox serialTextBox;
        private DevExpress.XtraEditors.LookUpEdit modelLookUpEdit;
        private DevExpress.XtraEditors.LookUpEdit makeLookUpEdit;
        private DevExpress.XtraEditors.LookUpEdit categoryIdLookUpEdit;
        private System.Windows.Forms.ToolStripButton BtnSaveAndNew;
        private System.Windows.Forms.BindingSource CatagoryBindingSource;
        private System.Windows.Forms.BindingSource MakeBindingSource;
        private System.Windows.Forms.BindingSource ModelBindingSource;
    }
}