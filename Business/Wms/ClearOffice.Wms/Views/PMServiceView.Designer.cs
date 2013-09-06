namespace ClearOffice.Wms.Views
{
    partial class PMServiceView
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
            System.Windows.Forms.Label priorityLabel1;
            System.Windows.Forms.Label categoryLabel;
            System.Windows.Forms.Label taskNameLabel;
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(PMServiceView));
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.btnSave = new System.Windows.Forms.ToolStripButton();
            this.btnDelete = new System.Windows.Forms.ToolStripButton();
            this.panelControl1 = new DevExpress.XtraEditors.PanelControl();
            this.rgTrackingMode = new DevExpress.XtraEditors.RadioGroup();
            this.priorityLookUpEdit = new DevExpress.XtraEditors.LookUpEdit();
            this.pmserviceBindingSource = new System.Windows.Forms.BindingSource();
            this.priorityBindingSource = new System.Windows.Forms.BindingSource();
            this.GBHoursTracking = new System.Windows.Forms.GroupBox();
            this.fixedHourTextBox = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.recurringHourTextBox = new System.Windows.Forms.TextBox();
            this.RGMileageTracking = new DevExpress.XtraEditors.RadioGroup();
            this.GBDateTracking = new System.Windows.Forms.GroupBox();
            this.LERecurringType = new System.Windows.Forms.ComboBox();
            this.durationTypeBindingSource = new System.Windows.Forms.BindingSource();
            this.fixedDateDateEdit = new DevExpress.XtraEditors.DateEdit();
            this.recurringDateTextBox = new System.Windows.Forms.TextBox();
            this.RGDateTracking = new DevExpress.XtraEditors.RadioGroup();
            this.categoryLookUpEdit = new DevExpress.XtraEditors.LookUpEdit();
            this.catagoryBindingSource = new System.Windows.Forms.BindingSource();
            this.taskNameTextBox = new System.Windows.Forms.TextBox();
            this.gridControl1 = new DevExpress.XtraGrid.GridControl();
            this.pmPartsBindingSource = new System.Windows.Forms.BindingSource();
            this.gridView1 = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.colPartId = new DevExpress.XtraGrid.Columns.GridColumn();
            this.partRepositoryItemGridLookUpEdit = new DevExpress.XtraEditors.Repository.RepositoryItemGridLookUpEdit();
            this.partInfoBindingSource = new System.Windows.Forms.BindingSource();
            this.gridView2 = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.colQuantity = new DevExpress.XtraGrid.Columns.GridColumn();
            this.pmserviceErrorProvider = new System.Windows.Forms.ErrorProvider();
            priorityLabel1 = new System.Windows.Forms.Label();
            categoryLabel = new System.Windows.Forms.Label();
            taskNameLabel = new System.Windows.Forms.Label();
            this.toolStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.panelControl1)).BeginInit();
            this.panelControl1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.rgTrackingMode.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.priorityLookUpEdit.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pmserviceBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.priorityBindingSource)).BeginInit();
            this.GBHoursTracking.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.RGMileageTracking.Properties)).BeginInit();
            this.GBDateTracking.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.durationTypeBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.fixedDateDateEdit.Properties.VistaTimeProperties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.fixedDateDateEdit.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.RGDateTracking.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.categoryLookUpEdit.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.catagoryBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridControl1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pmPartsBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.partRepositoryItemGridLookUpEdit)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.partInfoBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pmserviceErrorProvider)).BeginInit();
            this.SuspendLayout();
            // 
            // priorityLabel1
            // 
            priorityLabel1.AutoSize = true;
            priorityLabel1.Location = new System.Drawing.Point(294, 39);
            priorityLabel1.Name = "priorityLabel1";
            priorityLabel1.Size = new System.Drawing.Size(45, 13);
            priorityLabel1.TabIndex = 28;
            priorityLabel1.Text = "Priority:";
            // 
            // categoryLabel
            // 
            categoryLabel.AutoSize = true;
            categoryLabel.Location = new System.Drawing.Point(37, 39);
            categoryLabel.Name = "categoryLabel";
            categoryLabel.Size = new System.Drawing.Size(56, 13);
            categoryLabel.TabIndex = 23;
            categoryLabel.Text = "Category:";
            // 
            // taskNameLabel
            // 
            taskNameLabel.AutoSize = true;
            taskNameLabel.Location = new System.Drawing.Point(12, 13);
            taskNameLabel.Name = "taskNameLabel";
            taskNameLabel.Size = new System.Drawing.Size(76, 13);
            taskNameLabel.TabIndex = 21;
            taskNameLabel.Text = "Service Name:";
            // 
            // toolStrip1
            // 
            this.toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.btnSave,
            this.btnDelete});
            this.toolStrip1.Location = new System.Drawing.Point(0, 0);
            this.toolStrip1.Name = "toolStrip1";
            this.toolStrip1.Size = new System.Drawing.Size(677, 25);
            this.toolStrip1.TabIndex = 0;
            this.toolStrip1.Text = "toolStrip1";
            // 
            // btnSave
            // 
            this.btnSave.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.btnSave.Image = ((System.Drawing.Image)(resources.GetObject("btnSave.Image")));
            this.btnSave.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(23, 22);
            this.btnSave.Text = "&Save";
            this.btnSave.Click += new System.EventHandler(this.saveToolStripButton_Click);
            // 
            // btnDelete
            // 
            this.btnDelete.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.btnDelete.Enabled = false;
            this.btnDelete.Image = global::ClearOffice.Wms.Properties.Resources.delete;
            this.btnDelete.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(23, 22);
            this.btnDelete.Text = "toolStripButton1";
            this.btnDelete.ToolTipText = "Delete";
            this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
            // 
            // panelControl1
            // 
            this.panelControl1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panelControl1.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.NoBorder;
            this.panelControl1.Controls.Add(this.rgTrackingMode);
            this.panelControl1.Controls.Add(priorityLabel1);
            this.panelControl1.Controls.Add(this.priorityLookUpEdit);
            this.panelControl1.Controls.Add(this.GBHoursTracking);
            this.panelControl1.Controls.Add(this.GBDateTracking);
            this.panelControl1.Controls.Add(categoryLabel);
            this.panelControl1.Controls.Add(this.categoryLookUpEdit);
            this.panelControl1.Controls.Add(taskNameLabel);
            this.panelControl1.Controls.Add(this.taskNameTextBox);
            this.panelControl1.Location = new System.Drawing.Point(0, 28);
            this.panelControl1.Name = "panelControl1";
            this.panelControl1.Size = new System.Drawing.Size(677, 231);
            this.panelControl1.TabIndex = 1;
            // 
            // rgTrackingMode
            // 
            this.rgTrackingMode.EditValue = 1;
            this.rgTrackingMode.Location = new System.Drawing.Point(40, 75);
            this.rgTrackingMode.Name = "rgTrackingMode";
            this.rgTrackingMode.Properties.Appearance.BackColor = System.Drawing.Color.Transparent;
            this.rgTrackingMode.Properties.Appearance.Options.UseBackColor = true;
            this.rgTrackingMode.Properties.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.NoBorder;
            this.rgTrackingMode.Properties.Items.AddRange(new DevExpress.XtraEditors.Controls.RadioGroupItem[] {
            new DevExpress.XtraEditors.Controls.RadioGroupItem(1, "Date Tracking"),
            new DevExpress.XtraEditors.Controls.RadioGroupItem(2, "Hours Tracking")});
            this.rgTrackingMode.Size = new System.Drawing.Size(596, 31);
            this.rgTrackingMode.TabIndex = 31;
            this.rgTrackingMode.EditValueChanged += new System.EventHandler(this.rgTrackingMode_EditValueChanged);
            // 
            // priorityLookUpEdit
            // 
            this.priorityLookUpEdit.DataBindings.Add(new System.Windows.Forms.Binding("EditValue", this.pmserviceBindingSource, "Priority", true));
            this.priorityLookUpEdit.Location = new System.Drawing.Point(341, 36);
            this.priorityLookUpEdit.Name = "priorityLookUpEdit";
            this.priorityLookUpEdit.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.priorityLookUpEdit.Properties.Columns.AddRange(new DevExpress.XtraEditors.Controls.LookUpColumnInfo[] {
            new DevExpress.XtraEditors.Controls.LookUpColumnInfo("Name", "Name", 37, DevExpress.Utils.FormatType.None, "", true, DevExpress.Utils.HorzAlignment.Near),
            new DevExpress.XtraEditors.Controls.LookUpColumnInfo("Code", "Code", 35, DevExpress.Utils.FormatType.None, "", true, DevExpress.Utils.HorzAlignment.Near)});
            this.priorityLookUpEdit.Properties.DataSource = this.priorityBindingSource;
            this.priorityLookUpEdit.Properties.DisplayMember = "Name";
            this.priorityLookUpEdit.Properties.NullText = "[Select Priority]";
            this.priorityLookUpEdit.Properties.ValueMember = "ItemId";
            this.priorityLookUpEdit.Size = new System.Drawing.Size(177, 20);
            this.priorityLookUpEdit.TabIndex = 30;
            // 
            // pmserviceBindingSource
            // 
            this.pmserviceBindingSource.DataSource = typeof(ClearOffice.Wms.Business.PmService);
            this.pmserviceBindingSource.CurrentItemChanged += new System.EventHandler(this.pmserviceBindingSource_CurrentItemChanged);
            // 
            // priorityBindingSource
            // 
            this.priorityBindingSource.DataSource = typeof(ClearOffice.Wms.Business.LookupItem);
            // 
            // GBHoursTracking
            // 
            this.GBHoursTracking.Controls.Add(this.fixedHourTextBox);
            this.GBHoursTracking.Controls.Add(this.label1);
            this.GBHoursTracking.Controls.Add(this.recurringHourTextBox);
            this.GBHoursTracking.Controls.Add(this.RGMileageTracking);
            this.GBHoursTracking.Enabled = false;
            this.GBHoursTracking.Location = new System.Drawing.Point(335, 112);
            this.GBHoursTracking.Name = "GBHoursTracking";
            this.GBHoursTracking.Size = new System.Drawing.Size(293, 87);
            this.GBHoursTracking.TabIndex = 29;
            this.GBHoursTracking.TabStop = false;
            this.GBHoursTracking.Text = "Hours Tracking";
            // 
            // fixedHourTextBox
            // 
            this.fixedHourTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.pmserviceBindingSource, "FixedHour", true));
            this.fixedHourTextBox.Enabled = false;
            this.fixedHourTextBox.Location = new System.Drawing.Point(143, 54);
            this.fixedHourTextBox.Name = "fixedHourTextBox";
            this.fixedHourTextBox.Size = new System.Drawing.Size(138, 21);
            this.fixedHourTextBox.TabIndex = 20;
            this.fixedHourTextBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(318, 31);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(43, 13);
            this.label1.TabIndex = 19;
            this.label1.Text = "(Hours)";
            // 
            // recurringHourTextBox
            // 
            this.recurringHourTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.pmserviceBindingSource, "RecurringHour", true));
            this.recurringHourTextBox.Location = new System.Drawing.Point(143, 28);
            this.recurringHourTextBox.Name = "recurringHourTextBox";
            this.recurringHourTextBox.Size = new System.Drawing.Size(138, 21);
            this.recurringHourTextBox.TabIndex = 18;
            this.recurringHourTextBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // RGMileageTracking
            // 
            this.RGMileageTracking.AutoSizeInLayoutControl = true;
            this.RGMileageTracking.EditValue = 1;
            this.RGMileageTracking.Location = new System.Drawing.Point(13, 19);
            this.RGMileageTracking.Name = "RGMileageTracking";
            this.RGMileageTracking.Properties.Appearance.BackColor = System.Drawing.Color.Transparent;
            this.RGMileageTracking.Properties.Appearance.Options.UseBackColor = true;
            this.RGMileageTracking.Properties.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.NoBorder;
            this.RGMileageTracking.Properties.Items.AddRange(new DevExpress.XtraEditors.Controls.RadioGroupItem[] {
            new DevExpress.XtraEditors.Controls.RadioGroupItem(1, "Recurring: Every "),
            new DevExpress.XtraEditors.Controls.RadioGroupItem(2, "Fixed Hours:")});
            this.RGMileageTracking.Size = new System.Drawing.Size(124, 66);
            this.RGMileageTracking.TabIndex = 17;
            this.RGMileageTracking.EditValueChanged += new System.EventHandler(this.RGMileageTracking_EditValueChanged);
            // 
            // GBDateTracking
            // 
            this.GBDateTracking.Controls.Add(this.LERecurringType);
            this.GBDateTracking.Controls.Add(this.fixedDateDateEdit);
            this.GBDateTracking.Controls.Add(this.recurringDateTextBox);
            this.GBDateTracking.Controls.Add(this.RGDateTracking);
            this.GBDateTracking.Location = new System.Drawing.Point(28, 112);
            this.GBDateTracking.Name = "GBDateTracking";
            this.GBDateTracking.Size = new System.Drawing.Size(293, 86);
            this.GBDateTracking.TabIndex = 25;
            this.GBDateTracking.TabStop = false;
            this.GBDateTracking.Text = "Date Tracking ";
            // 
            // LERecurringType
            // 
            this.LERecurringType.DataSource = this.durationTypeBindingSource;
            this.LERecurringType.DisplayMember = "Name";
            this.LERecurringType.FormattingEnabled = true;
            this.LERecurringType.Location = new System.Drawing.Point(225, 30);
            this.LERecurringType.Name = "LERecurringType";
            this.LERecurringType.Size = new System.Drawing.Size(56, 21);
            this.LERecurringType.TabIndex = 20;
            this.LERecurringType.ValueMember = "Value";
            // 
            // durationTypeBindingSource
            // 
            this.durationTypeBindingSource.DataSource = typeof(ClearOffice.Wms.Views.DurationType);
            // 
            // fixedDateDateEdit
            // 
            this.fixedDateDateEdit.DataBindings.Add(new System.Windows.Forms.Binding("EditValue", this.pmserviceBindingSource, "FixedDate", true));
            this.fixedDateDateEdit.EditValue = null;
            this.fixedDateDateEdit.Enabled = false;
            this.fixedDateDateEdit.Location = new System.Drawing.Point(143, 56);
            this.fixedDateDateEdit.Name = "fixedDateDateEdit";
            this.fixedDateDateEdit.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.fixedDateDateEdit.Properties.VistaTimeProperties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton()});
            this.fixedDateDateEdit.Size = new System.Drawing.Size(138, 20);
            this.fixedDateDateEdit.TabIndex = 19;
            // 
            // recurringDateTextBox
            // 
            this.recurringDateTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.pmserviceBindingSource, "RecurringDate", true));
            this.recurringDateTextBox.Location = new System.Drawing.Point(143, 30);
            this.recurringDateTextBox.Name = "recurringDateTextBox";
            this.recurringDateTextBox.Size = new System.Drawing.Size(76, 21);
            this.recurringDateTextBox.TabIndex = 17;
            this.recurringDateTextBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // RGDateTracking
            // 
            this.RGDateTracking.AutoSizeInLayoutControl = true;
            this.RGDateTracking.EditValue = 1;
            this.RGDateTracking.Location = new System.Drawing.Point(13, 19);
            this.RGDateTracking.Name = "RGDateTracking";
            this.RGDateTracking.Properties.Appearance.BackColor = System.Drawing.Color.Transparent;
            this.RGDateTracking.Properties.Appearance.Options.UseBackColor = true;
            this.RGDateTracking.Properties.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.NoBorder;
            this.RGDateTracking.Properties.Items.AddRange(new DevExpress.XtraEditors.Controls.RadioGroupItem[] {
            new DevExpress.XtraEditors.Controls.RadioGroupItem(1, "Recurring: Every "),
            new DevExpress.XtraEditors.Controls.RadioGroupItem(2, "Fixed Date:")});
            this.RGDateTracking.Size = new System.Drawing.Size(124, 66);
            this.RGDateTracking.TabIndex = 16;
            this.RGDateTracking.EditValueChanged += new System.EventHandler(this.RGDateTracking_EditValueChanged);
            // 
            // categoryLookUpEdit
            // 
            this.categoryLookUpEdit.DataBindings.Add(new System.Windows.Forms.Binding("EditValue", this.pmserviceBindingSource, "Category", true));
            this.categoryLookUpEdit.Location = new System.Drawing.Point(95, 36);
            this.categoryLookUpEdit.Name = "categoryLookUpEdit";
            this.categoryLookUpEdit.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.categoryLookUpEdit.Properties.Columns.AddRange(new DevExpress.XtraEditors.Controls.LookUpColumnInfo[] {
            new DevExpress.XtraEditors.Controls.LookUpColumnInfo("Name", "Name", 37, DevExpress.Utils.FormatType.None, "", true, DevExpress.Utils.HorzAlignment.Near),
            new DevExpress.XtraEditors.Controls.LookUpColumnInfo("Code", "Code", 35, DevExpress.Utils.FormatType.None, "", true, DevExpress.Utils.HorzAlignment.Near)});
            this.categoryLookUpEdit.Properties.DataSource = this.catagoryBindingSource;
            this.categoryLookUpEdit.Properties.DisplayMember = "Name";
            this.categoryLookUpEdit.Properties.NullText = "[Select Category]";
            this.categoryLookUpEdit.Properties.ValueMember = "ItemId";
            this.categoryLookUpEdit.Size = new System.Drawing.Size(177, 20);
            this.categoryLookUpEdit.TabIndex = 24;
            // 
            // catagoryBindingSource
            // 
            this.catagoryBindingSource.DataSource = typeof(ClearOffice.Wms.Business.LookupItem);
            // 
            // taskNameTextBox
            // 
            this.taskNameTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.pmserviceBindingSource, "TaskName", true));
            this.taskNameTextBox.Location = new System.Drawing.Point(95, 10);
            this.taskNameTextBox.Name = "taskNameTextBox";
            this.taskNameTextBox.Size = new System.Drawing.Size(423, 21);
            this.taskNameTextBox.TabIndex = 22;
            // 
            // gridControl1
            // 
            this.gridControl1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.gridControl1.DataSource = this.pmPartsBindingSource;
            this.gridControl1.Location = new System.Drawing.Point(0, 265);
            this.gridControl1.MainView = this.gridView1;
            this.gridControl1.Name = "gridControl1";
            this.gridControl1.RepositoryItems.AddRange(new DevExpress.XtraEditors.Repository.RepositoryItem[] {
            this.partRepositoryItemGridLookUpEdit});
            this.gridControl1.Size = new System.Drawing.Size(677, 211);
            this.gridControl1.TabIndex = 2;
            this.gridControl1.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridView1});
            // 
            // pmPartsBindingSource
            // 
            this.pmPartsBindingSource.DataSource = typeof(ClearOffice.Wms.Business.PmServicePart);
            // 
            // gridView1
            // 
            this.gridView1.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.colPartId,
            this.colQuantity});
            this.gridView1.GridControl = this.gridControl1;
            this.gridView1.Name = "gridView1";
            this.gridView1.OptionsView.NewItemRowPosition = DevExpress.XtraGrid.Views.Grid.NewItemRowPosition.Top;
            this.gridView1.OptionsView.ShowGroupPanel = false;
            // 
            // colPartId
            // 
            this.colPartId.Caption = "Part";
            this.colPartId.ColumnEdit = this.partRepositoryItemGridLookUpEdit;
            this.colPartId.FieldName = "PartId";
            this.colPartId.Name = "colPartId";
            this.colPartId.Visible = true;
            this.colPartId.VisibleIndex = 0;
            // 
            // partRepositoryItemGridLookUpEdit
            // 
            this.partRepositoryItemGridLookUpEdit.AutoHeight = false;
            this.partRepositoryItemGridLookUpEdit.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.partRepositoryItemGridLookUpEdit.DataSource = this.partInfoBindingSource;
            this.partRepositoryItemGridLookUpEdit.DisplayMember = "PartNo";
            this.partRepositoryItemGridLookUpEdit.Name = "partRepositoryItemGridLookUpEdit";
            this.partRepositoryItemGridLookUpEdit.NullText = "[Select Part]";
            this.partRepositoryItemGridLookUpEdit.ValueMember = "PartId";
            this.partRepositoryItemGridLookUpEdit.View = this.gridView2;
            this.partRepositoryItemGridLookUpEdit.ViewType = DevExpress.XtraEditors.Repository.GridLookUpViewType.GridView;
            // 
            // partInfoBindingSource
            // 
            this.partInfoBindingSource.DataSource = typeof(ClearOffice.Wms.Business.PartInfo);
            // 
            // gridView2
            // 
            this.gridView2.FocusRectStyle = DevExpress.XtraGrid.Views.Grid.DrawFocusRectStyle.RowFocus;
            this.gridView2.Name = "gridView2";
            this.gridView2.OptionsSelection.EnableAppearanceFocusedCell = false;
            this.gridView2.OptionsView.ShowGroupPanel = false;
            // 
            // colQuantity
            // 
            this.colQuantity.FieldName = "Quantity";
            this.colQuantity.Name = "colQuantity";
            this.colQuantity.Visible = true;
            this.colQuantity.VisibleIndex = 1;
            // 
            // pmserviceErrorProvider
            // 
            this.pmserviceErrorProvider.ContainerControl = this;
            // 
            // PMServiceView
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(677, 476);
            this.Controls.Add(this.gridControl1);
            this.Controls.Add(this.panelControl1);
            this.Controls.Add(this.toolStrip1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "PMServiceView";
            this.Text = "PMServiceView";
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.panelControl1)).EndInit();
            this.panelControl1.ResumeLayout(false);
            this.panelControl1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.rgTrackingMode.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.priorityLookUpEdit.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pmserviceBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.priorityBindingSource)).EndInit();
            this.GBHoursTracking.ResumeLayout(false);
            this.GBHoursTracking.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.RGMileageTracking.Properties)).EndInit();
            this.GBDateTracking.ResumeLayout(false);
            this.GBDateTracking.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.durationTypeBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.fixedDateDateEdit.Properties.VistaTimeProperties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.fixedDateDateEdit.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.RGDateTracking.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.categoryLookUpEdit.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.catagoryBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridControl1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pmPartsBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.partRepositoryItemGridLookUpEdit)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.partInfoBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pmserviceErrorProvider)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ToolStrip toolStrip1;
        private DevExpress.XtraEditors.PanelControl panelControl1;
        private DevExpress.XtraEditors.LookUpEdit priorityLookUpEdit;
        private System.Windows.Forms.GroupBox GBHoursTracking;
        private System.Windows.Forms.TextBox fixedHourTextBox;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox recurringHourTextBox;
        private DevExpress.XtraEditors.RadioGroup RGMileageTracking;
        private System.Windows.Forms.GroupBox GBDateTracking;
        private System.Windows.Forms.ComboBox LERecurringType;
        private DevExpress.XtraEditors.DateEdit fixedDateDateEdit;
        private System.Windows.Forms.TextBox recurringDateTextBox;
        private DevExpress.XtraEditors.RadioGroup RGDateTracking;
        private DevExpress.XtraEditors.LookUpEdit categoryLookUpEdit;
        private System.Windows.Forms.TextBox taskNameTextBox;
        private DevExpress.XtraGrid.GridControl gridControl1;
        private DevExpress.XtraGrid.Views.Grid.GridView gridView1;
        private System.Windows.Forms.ToolStripButton btnSave;
        private System.Windows.Forms.ToolStripButton btnDelete;
        private System.Windows.Forms.BindingSource pmserviceBindingSource;
        private System.Windows.Forms.BindingSource catagoryBindingSource;
        private System.Windows.Forms.BindingSource priorityBindingSource;
        private System.Windows.Forms.BindingSource partInfoBindingSource;
        private System.Windows.Forms.BindingSource pmPartsBindingSource;
        private DevExpress.XtraGrid.Columns.GridColumn colPartId;
        private DevExpress.XtraEditors.Repository.RepositoryItemGridLookUpEdit partRepositoryItemGridLookUpEdit;
        private DevExpress.XtraGrid.Views.Grid.GridView gridView2;
        private DevExpress.XtraGrid.Columns.GridColumn colQuantity;
        private System.Windows.Forms.ErrorProvider pmserviceErrorProvider;
        private System.Windows.Forms.BindingSource durationTypeBindingSource;
        private DevExpress.XtraEditors.RadioGroup rgTrackingMode;

    }
}