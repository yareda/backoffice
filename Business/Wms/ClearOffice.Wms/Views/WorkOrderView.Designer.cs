namespace ClearOffice.Wms.Views
{
    partial class WorkOrderView
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
            System.Windows.Forms.Label assignedToLabel;
            System.Windows.Forms.Label priorityLabel;
            System.Windows.Forms.Label statusLabel;
            System.Windows.Forms.Label remarkLabel;
            System.Windows.Forms.Label endDateLabel;
            System.Windows.Forms.Label startDateLabel;
            System.Windows.Forms.Label issueDateLabel;
            System.Windows.Forms.Label workOrderNoLabel;
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(WorkOrderView));
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.BtnSave = new System.Windows.Forms.ToolStripButton();
            this.btnDelete = new System.Windows.Forms.ToolStripButton();
            this.panelControl1 = new DevExpress.XtraEditors.PanelControl();
            this.button2 = new System.Windows.Forms.Button();
            this.statusLookUpEdit = new DevExpress.XtraEditors.LookUpEdit();
            this.WorkOrderBindingSource = new System.Windows.Forms.BindingSource();
            this.StatusBindingSource = new System.Windows.Forms.BindingSource();
            this.remarkTextBox = new System.Windows.Forms.TextBox();
            this.endDateDateEdit = new DevExpress.XtraEditors.DateEdit();
            this.startDateDateEdit = new DevExpress.XtraEditors.DateEdit();
            this.issueDateDateEdit = new DevExpress.XtraEditors.DateEdit();
            this.workOrderNoTextBox = new System.Windows.Forms.TextBox();
            this.gridControl1 = new DevExpress.XtraGrid.GridControl();
            this.TasksBindingSource = new System.Windows.Forms.BindingSource();
            this.MaintainanceTasksGridView = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.colServiceTypeId = new DevExpress.XtraGrid.Columns.GridColumn();
            this.taskNameRepositoryItemGridLookUpEdit = new DevExpress.XtraEditors.Repository.RepositoryItemGridLookUpEdit();
            this.pmServiceListBindingSource = new System.Windows.Forms.BindingSource();
            this.gridView1 = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.colPartsCost = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colLabourCost = new DevExpress.XtraGrid.Columns.GridColumn();
            this.toolStrip2 = new System.Windows.Forms.ToolStrip();
            this.btnNewTask = new System.Windows.Forms.ToolStripButton();
            this.btnDeleteTask = new System.Windows.Forms.ToolStripButton();
            this.gridControl2 = new DevExpress.XtraGrid.GridControl();
            this.partsBindingSource = new System.Windows.Forms.BindingSource();
            this.PartsGridView = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.colPartId = new DevExpress.XtraGrid.Columns.GridColumn();
            this.partNoRepositoryItemGridLookUpEdit = new DevExpress.XtraEditors.Repository.RepositoryItemGridLookUpEdit();
            this.partInfoBindingSource = new System.Windows.Forms.BindingSource();
            this.gridView2 = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.colQuantity = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colUnitCost = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colTotal3 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.toolStrip3 = new System.Windows.Forms.ToolStrip();
            this.btnDeleteParts = new System.Windows.Forms.ToolStripButton();
            this.gridControl3 = new DevExpress.XtraGrid.GridControl();
            this.laboursBindingSource = new System.Windows.Forms.BindingSource();
            this.LaboursGridView = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.colPerformerId = new DevExpress.XtraGrid.Columns.GridColumn();
            this.performerNameRepositoryItemGridLookUpEdit = new DevExpress.XtraEditors.Repository.RepositoryItemGridLookUpEdit();
            this.vendorAndEmployeesBindingSource = new System.Windows.Forms.BindingSource();
            this.gridView3 = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.colLabourRate = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colHour = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colTotal = new DevExpress.XtraGrid.Columns.GridColumn();
            this.toolStrip4 = new System.Windows.Forms.ToolStrip();
            this.btnNewLabour = new System.Windows.Forms.ToolStripButton();
            this.btnDeleteLabour = new System.Windows.Forms.ToolStripButton();
            this.panelControl2 = new DevExpress.XtraEditors.PanelControl();
            this.TotalsGroupBox = new System.Windows.Forms.GroupBox();
            this.TxtTotal = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.TxtTaxes = new System.Windows.Forms.TextBox();
            this.TaxCheckBox = new System.Windows.Forms.CheckBox();
            this.TxtDiscount = new System.Windows.Forms.TextBox();
            this.DiscountCheckBox = new System.Windows.Forms.CheckBox();
            this.TxtLabourTotal = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.TxtPartTotal = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.OptionalInfoGroupBox = new System.Windows.Forms.GroupBox();
            this.assignedToLookUpEdit = new DevExpress.XtraEditors.LookUpEdit();
            this.EmployeesBindingSource = new System.Windows.Forms.BindingSource();
            this.priorityLookUpEdit = new DevExpress.XtraEditors.LookUpEdit();
            this.PriorityBindingSource = new System.Windows.Forms.BindingSource();
            this.WorkorderErrorProvider = new System.Windows.Forms.ErrorProvider();
            this.xtraTabControl1 = new DevExpress.XtraTab.XtraTabControl();
            this.maintenanceTaskXtraTabPage = new DevExpress.XtraTab.XtraTabPage();
            this.partsXtraTabPage = new DevExpress.XtraTab.XtraTabPage();
            this.laborXtraTabPage = new DevExpress.XtraTab.XtraTabPage();
            assignedToLabel = new System.Windows.Forms.Label();
            priorityLabel = new System.Windows.Forms.Label();
            statusLabel = new System.Windows.Forms.Label();
            remarkLabel = new System.Windows.Forms.Label();
            endDateLabel = new System.Windows.Forms.Label();
            startDateLabel = new System.Windows.Forms.Label();
            issueDateLabel = new System.Windows.Forms.Label();
            workOrderNoLabel = new System.Windows.Forms.Label();
            this.toolStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.panelControl1)).BeginInit();
            this.panelControl1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.statusLookUpEdit.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.WorkOrderBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.StatusBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.endDateDateEdit.Properties.VistaTimeProperties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.endDateDateEdit.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.startDateDateEdit.Properties.VistaTimeProperties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.startDateDateEdit.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.issueDateDateEdit.Properties.VistaTimeProperties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.issueDateDateEdit.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridControl1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.TasksBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.MaintainanceTasksGridView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.taskNameRepositoryItemGridLookUpEdit)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pmServiceListBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).BeginInit();
            this.toolStrip2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gridControl2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.partsBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.PartsGridView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.partNoRepositoryItemGridLookUpEdit)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.partInfoBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView2)).BeginInit();
            this.toolStrip3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gridControl3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.laboursBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.LaboursGridView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.performerNameRepositoryItemGridLookUpEdit)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.vendorAndEmployeesBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView3)).BeginInit();
            this.toolStrip4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.panelControl2)).BeginInit();
            this.panelControl2.SuspendLayout();
            this.TotalsGroupBox.SuspendLayout();
            this.OptionalInfoGroupBox.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.assignedToLookUpEdit.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.EmployeesBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.priorityLookUpEdit.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.PriorityBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.WorkorderErrorProvider)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.xtraTabControl1)).BeginInit();
            this.xtraTabControl1.SuspendLayout();
            this.maintenanceTaskXtraTabPage.SuspendLayout();
            this.partsXtraTabPage.SuspendLayout();
            this.laborXtraTabPage.SuspendLayout();
            this.SuspendLayout();
            // 
            // assignedToLabel
            // 
            assignedToLabel.AutoSize = true;
            assignedToLabel.Location = new System.Drawing.Point(18, 36);
            assignedToLabel.Name = "assignedToLabel";
            assignedToLabel.Size = new System.Drawing.Size(69, 13);
            assignedToLabel.TabIndex = 7;
            assignedToLabel.Text = "Assigned To:";
            // 
            // priorityLabel
            // 
            priorityLabel.AutoSize = true;
            priorityLabel.Location = new System.Drawing.Point(18, 62);
            priorityLabel.Name = "priorityLabel";
            priorityLabel.Size = new System.Drawing.Size(45, 13);
            priorityLabel.TabIndex = 5;
            priorityLabel.Text = "Priority:";
            // 
            // statusLabel
            // 
            statusLabel.AutoSize = true;
            statusLabel.Location = new System.Drawing.Point(357, 13);
            statusLabel.Name = "statusLabel";
            statusLabel.Size = new System.Drawing.Size(42, 13);
            statusLabel.TabIndex = 32;
            statusLabel.Text = "Status:";
            // 
            // remarkLabel
            // 
            remarkLabel.AutoSize = true;
            remarkLabel.Location = new System.Drawing.Point(357, 65);
            remarkLabel.Name = "remarkLabel";
            remarkLabel.Size = new System.Drawing.Size(47, 13);
            remarkLabel.TabIndex = 30;
            remarkLabel.Text = "Remark:";
            // 
            // endDateLabel
            // 
            endDateLabel.AutoSize = true;
            endDateLabel.Location = new System.Drawing.Point(357, 39);
            endDateLabel.Name = "endDateLabel";
            endDateLabel.Size = new System.Drawing.Size(55, 13);
            endDateLabel.TabIndex = 29;
            endDateLabel.Text = "End Date:";
            // 
            // startDateLabel
            // 
            startDateLabel.AutoSize = true;
            startDateLabel.Location = new System.Drawing.Point(8, 65);
            startDateLabel.Name = "startDateLabel";
            startDateLabel.Size = new System.Drawing.Size(61, 13);
            startDateLabel.TabIndex = 27;
            startDateLabel.Text = "Start Date:";
            // 
            // issueDateLabel
            // 
            issueDateLabel.AutoSize = true;
            issueDateLabel.Location = new System.Drawing.Point(8, 39);
            issueDateLabel.Name = "issueDateLabel";
            issueDateLabel.Size = new System.Drawing.Size(63, 13);
            issueDateLabel.TabIndex = 25;
            issueDateLabel.Text = "Issue Date:";
            // 
            // workOrderNoLabel
            // 
            workOrderNoLabel.AutoSize = true;
            workOrderNoLabel.Location = new System.Drawing.Point(8, 13);
            workOrderNoLabel.Name = "workOrderNoLabel";
            workOrderNoLabel.Size = new System.Drawing.Size(78, 13);
            workOrderNoLabel.TabIndex = 23;
            workOrderNoLabel.Text = "Work Order #:";
            // 
            // toolStrip1
            // 
            this.toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.BtnSave,
            this.btnDelete});
            this.toolStrip1.Location = new System.Drawing.Point(0, 0);
            this.toolStrip1.Name = "toolStrip1";
            this.toolStrip1.Size = new System.Drawing.Size(924, 25);
            this.toolStrip1.TabIndex = 0;
            this.toolStrip1.Text = "toolStrip1";
            // 
            // BtnSave
            // 
            this.BtnSave.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.BtnSave.Image = ((System.Drawing.Image)(resources.GetObject("BtnSave.Image")));
            this.BtnSave.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.BtnSave.Name = "BtnSave";
            this.BtnSave.Size = new System.Drawing.Size(23, 22);
            this.BtnSave.Text = "&Save";
            this.BtnSave.Click += new System.EventHandler(this.BtnSave_Click);
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
            this.panelControl1.Controls.Add(this.button2);
            this.panelControl1.Controls.Add(statusLabel);
            this.panelControl1.Controls.Add(this.statusLookUpEdit);
            this.panelControl1.Controls.Add(remarkLabel);
            this.panelControl1.Controls.Add(this.remarkTextBox);
            this.panelControl1.Controls.Add(endDateLabel);
            this.panelControl1.Controls.Add(this.endDateDateEdit);
            this.panelControl1.Controls.Add(startDateLabel);
            this.panelControl1.Controls.Add(this.startDateDateEdit);
            this.panelControl1.Controls.Add(issueDateLabel);
            this.panelControl1.Controls.Add(this.issueDateDateEdit);
            this.panelControl1.Controls.Add(workOrderNoLabel);
            this.panelControl1.Controls.Add(this.workOrderNoTextBox);
            this.panelControl1.Location = new System.Drawing.Point(4, 28);
            this.panelControl1.Name = "panelControl1";
            this.panelControl1.Size = new System.Drawing.Size(916, 142);
            this.panelControl1.TabIndex = 1;
            // 
            // button2
            // 
            this.button2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.button2.Image = global::ClearOffice.Wms.Properties.Resources.printer;
            this.button2.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button2.Location = new System.Drawing.Point(808, 14);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(90, 23);
            this.button2.TabIndex = 36;
            this.button2.Text = "Print";
            this.button2.UseVisualStyleBackColor = true;
            // 
            // statusLookUpEdit
            // 
            this.statusLookUpEdit.DataBindings.Add(new System.Windows.Forms.Binding("EditValue", this.WorkOrderBindingSource, "Status", true));
            this.statusLookUpEdit.Location = new System.Drawing.Point(416, 11);
            this.statusLookUpEdit.Name = "statusLookUpEdit";
            this.statusLookUpEdit.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.statusLookUpEdit.Properties.Columns.AddRange(new DevExpress.XtraEditors.Controls.LookUpColumnInfo[] {
            new DevExpress.XtraEditors.Controls.LookUpColumnInfo("Name", "Name", 37, DevExpress.Utils.FormatType.None, "", true, DevExpress.Utils.HorzAlignment.Near)});
            this.statusLookUpEdit.Properties.DataSource = this.StatusBindingSource;
            this.statusLookUpEdit.Properties.DisplayMember = "Name";
            this.statusLookUpEdit.Properties.NullText = "[Select Status]";
            this.statusLookUpEdit.Properties.ValueMember = "ItemId";
            this.statusLookUpEdit.Size = new System.Drawing.Size(254, 20);
            this.statusLookUpEdit.TabIndex = 34;
            // 
            // WorkOrderBindingSource
            // 
            this.WorkOrderBindingSource.DataSource = typeof(ClearOffice.Wms.Business.WorkOrder);
            this.WorkOrderBindingSource.CurrentItemChanged += new System.EventHandler(this.WorkOrderBindingSource_CurrentItemChanged);
            // 
            // StatusBindingSource
            // 
            this.StatusBindingSource.DataSource = typeof(ClearOffice.Wms.Business.LookupItem);
            // 
            // remarkTextBox
            // 
            this.remarkTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.WorkOrderBindingSource, "Remark", true));
            this.remarkTextBox.Location = new System.Drawing.Point(416, 63);
            this.remarkTextBox.Multiline = true;
            this.remarkTextBox.Name = "remarkTextBox";
            this.remarkTextBox.Size = new System.Drawing.Size(353, 69);
            this.remarkTextBox.TabIndex = 33;
            // 
            // endDateDateEdit
            // 
            this.endDateDateEdit.DataBindings.Add(new System.Windows.Forms.Binding("EditValue", this.WorkOrderBindingSource, "EndDate", true));
            this.endDateDateEdit.EditValue = null;
            this.endDateDateEdit.Location = new System.Drawing.Point(416, 37);
            this.endDateDateEdit.Name = "endDateDateEdit";
            this.endDateDateEdit.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.endDateDateEdit.Properties.VistaTimeProperties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton()});
            this.endDateDateEdit.Size = new System.Drawing.Size(254, 20);
            this.endDateDateEdit.TabIndex = 31;
            // 
            // startDateDateEdit
            // 
            this.startDateDateEdit.DataBindings.Add(new System.Windows.Forms.Binding("EditValue", this.WorkOrderBindingSource, "StartDate", true));
            this.startDateDateEdit.EditValue = null;
            this.startDateDateEdit.Location = new System.Drawing.Point(97, 62);
            this.startDateDateEdit.Name = "startDateDateEdit";
            this.startDateDateEdit.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.startDateDateEdit.Properties.VistaTimeProperties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton()});
            this.startDateDateEdit.Size = new System.Drawing.Size(254, 20);
            this.startDateDateEdit.TabIndex = 28;
            // 
            // issueDateDateEdit
            // 
            this.issueDateDateEdit.DataBindings.Add(new System.Windows.Forms.Binding("EditValue", this.WorkOrderBindingSource, "IssueDate", true));
            this.issueDateDateEdit.EditValue = null;
            this.issueDateDateEdit.Location = new System.Drawing.Point(97, 36);
            this.issueDateDateEdit.Name = "issueDateDateEdit";
            this.issueDateDateEdit.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.issueDateDateEdit.Properties.VistaTimeProperties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton()});
            this.issueDateDateEdit.Size = new System.Drawing.Size(254, 20);
            this.issueDateDateEdit.TabIndex = 26;
            // 
            // workOrderNoTextBox
            // 
            this.workOrderNoTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.WorkOrderBindingSource, "WorkOrderNo", true));
            this.workOrderNoTextBox.Location = new System.Drawing.Point(97, 10);
            this.workOrderNoTextBox.Name = "workOrderNoTextBox";
            this.workOrderNoTextBox.Size = new System.Drawing.Size(254, 21);
            this.workOrderNoTextBox.TabIndex = 24;
            // 
            // gridControl1
            // 
            this.gridControl1.AllowRestoreSelectionAndFocusedRow = DevExpress.Utils.DefaultBoolean.True;
            this.gridControl1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.gridControl1.DataSource = this.TasksBindingSource;
            this.gridControl1.Location = new System.Drawing.Point(3, 28);
            this.gridControl1.MainView = this.MaintainanceTasksGridView;
            this.gridControl1.Name = "gridControl1";
            this.gridControl1.RepositoryItems.AddRange(new DevExpress.XtraEditors.Repository.RepositoryItem[] {
            this.taskNameRepositoryItemGridLookUpEdit});
            this.gridControl1.Size = new System.Drawing.Size(904, 140);
            this.gridControl1.TabIndex = 2;
            this.gridControl1.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.MaintainanceTasksGridView});
            this.gridControl1.Click += new System.EventHandler(this.gridControl1_Click);
            this.gridControl1.DoubleClick += new System.EventHandler(this.gridControl1_DoubleClick);
            // 
            // TasksBindingSource
            // 
            this.TasksBindingSource.DataSource = typeof(ClearOffice.Wms.Business.MaintenanceTask);
            this.TasksBindingSource.CurrentItemChanged += new System.EventHandler(this.TasksBindingSource_CurrentItemChanged);
            // 
            // MaintainanceTasksGridView
            // 
            this.MaintainanceTasksGridView.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.colServiceTypeId,
            this.colPartsCost,
            this.colLabourCost});
            this.MaintainanceTasksGridView.GridControl = this.gridControl1;
            this.MaintainanceTasksGridView.Name = "MaintainanceTasksGridView";
            this.MaintainanceTasksGridView.OptionsBehavior.Editable = false;
            this.MaintainanceTasksGridView.OptionsView.ShowGroupPanel = false;
            // 
            // colServiceTypeId
            // 
            this.colServiceTypeId.Caption = "Task Name";
            this.colServiceTypeId.ColumnEdit = this.taskNameRepositoryItemGridLookUpEdit;
            this.colServiceTypeId.FieldName = "ServiceTypeId";
            this.colServiceTypeId.Name = "colServiceTypeId";
            this.colServiceTypeId.Visible = true;
            this.colServiceTypeId.VisibleIndex = 0;
            // 
            // taskNameRepositoryItemGridLookUpEdit
            // 
            this.taskNameRepositoryItemGridLookUpEdit.AutoHeight = false;
            this.taskNameRepositoryItemGridLookUpEdit.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.taskNameRepositoryItemGridLookUpEdit.DataSource = this.pmServiceListBindingSource;
            this.taskNameRepositoryItemGridLookUpEdit.DisplayMember = "TaskName";
            this.taskNameRepositoryItemGridLookUpEdit.Name = "taskNameRepositoryItemGridLookUpEdit";
            this.taskNameRepositoryItemGridLookUpEdit.NullText = "";
            this.taskNameRepositoryItemGridLookUpEdit.PopupFilterMode = DevExpress.XtraEditors.PopupFilterMode.StartsWith;
            this.taskNameRepositoryItemGridLookUpEdit.ValueMember = "PmServiceId";
            this.taskNameRepositoryItemGridLookUpEdit.View = this.gridView1;
            this.taskNameRepositoryItemGridLookUpEdit.ViewType = DevExpress.XtraEditors.Repository.GridLookUpViewType.GridView;
            // 
            // pmServiceListBindingSource
            // 
            this.pmServiceListBindingSource.DataSource = typeof(ClearOffice.Wms.Business.PmService);
            // 
            // gridView1
            // 
            this.gridView1.FocusRectStyle = DevExpress.XtraGrid.Views.Grid.DrawFocusRectStyle.RowFocus;
            this.gridView1.Name = "gridView1";
            this.gridView1.OptionsSelection.EnableAppearanceFocusedCell = false;
            this.gridView1.OptionsView.ShowGroupPanel = false;
            // 
            // colPartsCost
            // 
            this.colPartsCost.Caption = "Part Cost";
            this.colPartsCost.DisplayFormat.FormatString = "{0:#,##0.00;(#,##0.00);\'\'} ";
            this.colPartsCost.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Custom;
            this.colPartsCost.FieldName = "PartsCost";
            this.colPartsCost.Name = "colPartsCost";
            this.colPartsCost.Visible = true;
            this.colPartsCost.VisibleIndex = 1;
            // 
            // colLabourCost
            // 
            this.colLabourCost.Caption = "Labor Cost";
            this.colLabourCost.DisplayFormat.FormatString = "{0:#,##0.00;(#,##0.00);\'\'} ";
            this.colLabourCost.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Custom;
            this.colLabourCost.FieldName = "LabourCost";
            this.colLabourCost.Name = "colLabourCost";
            this.colLabourCost.Visible = true;
            this.colLabourCost.VisibleIndex = 2;
            // 
            // toolStrip2
            // 
            this.toolStrip2.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.btnNewTask,
            this.btnDeleteTask});
            this.toolStrip2.Location = new System.Drawing.Point(0, 0);
            this.toolStrip2.Name = "toolStrip2";
            this.toolStrip2.Size = new System.Drawing.Size(910, 25);
            this.toolStrip2.TabIndex = 1;
            this.toolStrip2.Text = "toolStrip2";
            // 
            // btnNewTask
            // 
            this.btnNewTask.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.btnNewTask.Image = ((System.Drawing.Image)(resources.GetObject("btnNewTask.Image")));
            this.btnNewTask.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnNewTask.Name = "btnNewTask";
            this.btnNewTask.Size = new System.Drawing.Size(23, 22);
            this.btnNewTask.Text = "&New";
            this.btnNewTask.Click += new System.EventHandler(this.BtnNewTask_Click);
            // 
            // btnDeleteTask
            // 
            this.btnDeleteTask.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.btnDeleteTask.Enabled = false;
            this.btnDeleteTask.Image = global::ClearOffice.Wms.Properties.Resources.delete;
            this.btnDeleteTask.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnDeleteTask.Name = "btnDeleteTask";
            this.btnDeleteTask.Size = new System.Drawing.Size(23, 22);
            this.btnDeleteTask.Text = "toolStripButton1";
            this.btnDeleteTask.ToolTipText = "Delete";
            this.btnDeleteTask.Click += new System.EventHandler(this.btnDeleteTask_Click);
            // 
            // gridControl2
            // 
            this.gridControl2.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.gridControl2.DataSource = this.partsBindingSource;
            this.gridControl2.Location = new System.Drawing.Point(3, 28);
            this.gridControl2.MainView = this.PartsGridView;
            this.gridControl2.Name = "gridControl2";
            this.gridControl2.RepositoryItems.AddRange(new DevExpress.XtraEditors.Repository.RepositoryItem[] {
            this.partNoRepositoryItemGridLookUpEdit});
            this.gridControl2.Size = new System.Drawing.Size(904, 143);
            this.gridControl2.TabIndex = 1;
            this.gridControl2.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.PartsGridView});
            this.gridControl2.Click += new System.EventHandler(this.gridControl2_Click);
            // 
            // partsBindingSource
            // 
            this.partsBindingSource.DataSource = typeof(ClearOffice.Wms.Business.MaintenancePart);
            this.partsBindingSource.CurrentItemChanged += new System.EventHandler(this.partsBindingSource_CurrentItemChanged);
            // 
            // PartsGridView
            // 
            this.PartsGridView.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.colPartId,
            this.colQuantity,
            this.colUnitCost,
            this.colTotal3});
            this.PartsGridView.GridControl = this.gridControl2;
            this.PartsGridView.Name = "PartsGridView";
            this.PartsGridView.OptionsView.NewItemRowPosition = DevExpress.XtraGrid.Views.Grid.NewItemRowPosition.Top;
            this.PartsGridView.OptionsView.ShowFooter = true;
            this.PartsGridView.OptionsView.ShowGroupPanel = false;
            // 
            // colPartId
            // 
            this.colPartId.Caption = "Part #";
            this.colPartId.ColumnEdit = this.partNoRepositoryItemGridLookUpEdit;
            this.colPartId.FieldName = "PartId";
            this.colPartId.Name = "colPartId";
            this.colPartId.Visible = true;
            this.colPartId.VisibleIndex = 0;
            // 
            // partNoRepositoryItemGridLookUpEdit
            // 
            this.partNoRepositoryItemGridLookUpEdit.AutoHeight = false;
            this.partNoRepositoryItemGridLookUpEdit.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.partNoRepositoryItemGridLookUpEdit.DataSource = this.partInfoBindingSource;
            this.partNoRepositoryItemGridLookUpEdit.DisplayMember = "PartNo";
            this.partNoRepositoryItemGridLookUpEdit.Name = "partNoRepositoryItemGridLookUpEdit";
            this.partNoRepositoryItemGridLookUpEdit.NullText = "[Select Part]";
            this.partNoRepositoryItemGridLookUpEdit.PopupFilterMode = DevExpress.XtraEditors.PopupFilterMode.StartsWith;
            this.partNoRepositoryItemGridLookUpEdit.ValueMember = "PartId";
            this.partNoRepositoryItemGridLookUpEdit.View = this.gridView2;
            this.partNoRepositoryItemGridLookUpEdit.ViewType = DevExpress.XtraEditors.Repository.GridLookUpViewType.GridView;
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
            // colUnitCost
            // 
            this.colUnitCost.DisplayFormat.FormatString = "{0:#,##0.00;(#,##0.00);\'\'} ";
            this.colUnitCost.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Custom;
            this.colUnitCost.FieldName = "UnitCost";
            this.colUnitCost.Name = "colUnitCost";
            this.colUnitCost.Visible = true;
            this.colUnitCost.VisibleIndex = 2;
            // 
            // colTotal3
            // 
            this.colTotal3.Caption = "Total";
            this.colTotal3.DisplayFormat.FormatString = "{0:#,##0.00;(#,##0.00);\'\'} ";
            this.colTotal3.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Custom;
            this.colTotal3.FieldName = "colTotal3";
            this.colTotal3.Name = "colTotal3";
            this.colTotal3.SummaryItem.SummaryType = DevExpress.Data.SummaryItemType.Sum;
            this.colTotal3.UnboundExpression = "[Quantity] * [UnitCost]";
            this.colTotal3.UnboundType = DevExpress.Data.UnboundColumnType.Decimal;
            this.colTotal3.Visible = true;
            this.colTotal3.VisibleIndex = 3;
            // 
            // toolStrip3
            // 
            this.toolStrip3.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.btnDeleteParts});
            this.toolStrip3.Location = new System.Drawing.Point(0, 0);
            this.toolStrip3.Name = "toolStrip3";
            this.toolStrip3.Size = new System.Drawing.Size(910, 25);
            this.toolStrip3.TabIndex = 0;
            this.toolStrip3.Text = "toolStrip3";
            // 
            // btnDeleteParts
            // 
            this.btnDeleteParts.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.btnDeleteParts.Enabled = false;
            this.btnDeleteParts.Image = global::ClearOffice.Wms.Properties.Resources.delete;
            this.btnDeleteParts.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnDeleteParts.Name = "btnDeleteParts";
            this.btnDeleteParts.Size = new System.Drawing.Size(23, 22);
            this.btnDeleteParts.Text = "toolStripButton1";
            this.btnDeleteParts.ToolTipText = "Delete";
            this.btnDeleteParts.Click += new System.EventHandler(this.btnDeleteParts_Click);
            // 
            // gridControl3
            // 
            this.gridControl3.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.gridControl3.DataSource = this.laboursBindingSource;
            this.gridControl3.Location = new System.Drawing.Point(3, 28);
            this.gridControl3.MainView = this.LaboursGridView;
            this.gridControl3.Name = "gridControl3";
            this.gridControl3.RepositoryItems.AddRange(new DevExpress.XtraEditors.Repository.RepositoryItem[] {
            this.performerNameRepositoryItemGridLookUpEdit});
            this.gridControl3.Size = new System.Drawing.Size(904, 143);
            this.gridControl3.TabIndex = 1;
            this.gridControl3.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.LaboursGridView});
            this.gridControl3.Click += new System.EventHandler(this.gridControl3_Click);
            this.gridControl3.DoubleClick += new System.EventHandler(this.gridControl3_DoubleClick);
            // 
            // laboursBindingSource
            // 
            this.laboursBindingSource.DataSource = typeof(ClearOffice.Wms.Business.MaintenanceLabour);
            this.laboursBindingSource.CurrentItemChanged += new System.EventHandler(this.laboursBindingSource_CurrentItemChanged);
            // 
            // LaboursGridView
            // 
            this.LaboursGridView.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.colPerformerId,
            this.colLabourRate,
            this.colHour,
            this.colTotal});
            this.LaboursGridView.GridControl = this.gridControl3;
            this.LaboursGridView.Name = "LaboursGridView";
            this.LaboursGridView.OptionsBehavior.Editable = false;
            this.LaboursGridView.OptionsView.ShowFooter = true;
            this.LaboursGridView.OptionsView.ShowGroupPanel = false;
            // 
            // colPerformerId
            // 
            this.colPerformerId.Caption = "Performer";
            this.colPerformerId.ColumnEdit = this.performerNameRepositoryItemGridLookUpEdit;
            this.colPerformerId.FieldName = "PerformerId";
            this.colPerformerId.Name = "colPerformerId";
            this.colPerformerId.Visible = true;
            this.colPerformerId.VisibleIndex = 2;
            // 
            // performerNameRepositoryItemGridLookUpEdit
            // 
            this.performerNameRepositoryItemGridLookUpEdit.AutoHeight = false;
            this.performerNameRepositoryItemGridLookUpEdit.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.performerNameRepositoryItemGridLookUpEdit.DataSource = this.vendorAndEmployeesBindingSource;
            this.performerNameRepositoryItemGridLookUpEdit.DisplayMember = "Name";
            this.performerNameRepositoryItemGridLookUpEdit.Name = "performerNameRepositoryItemGridLookUpEdit";
            this.performerNameRepositoryItemGridLookUpEdit.NullText = "[Select Performer]";
            this.performerNameRepositoryItemGridLookUpEdit.PopupFilterMode = DevExpress.XtraEditors.PopupFilterMode.StartsWith;
            this.performerNameRepositoryItemGridLookUpEdit.ValueMember = "Id";
            this.performerNameRepositoryItemGridLookUpEdit.View = this.gridView3;
            this.performerNameRepositoryItemGridLookUpEdit.ViewType = DevExpress.XtraEditors.Repository.GridLookUpViewType.GridView;
            // 
            // vendorAndEmployeesBindingSource
            // 
            this.vendorAndEmployeesBindingSource.DataSource = typeof(ClearOffice.Wms.Business.WorkshopEmployeesAndVendors);
            // 
            // gridView3
            // 
            this.gridView3.FocusRectStyle = DevExpress.XtraGrid.Views.Grid.DrawFocusRectStyle.RowFocus;
            this.gridView3.Name = "gridView3";
            this.gridView3.OptionsSelection.EnableAppearanceFocusedCell = false;
            this.gridView3.OptionsView.ShowGroupPanel = false;
            // 
            // colLabourRate
            // 
            this.colLabourRate.Caption = "Labor Rate";
            this.colLabourRate.DisplayFormat.FormatString = "{0:#,##0.00;(#,##0.00);\\\'\\\'}";
            this.colLabourRate.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Custom;
            this.colLabourRate.FieldName = "LabourRate";
            this.colLabourRate.Name = "colLabourRate";
            this.colLabourRate.Visible = true;
            this.colLabourRate.VisibleIndex = 0;
            // 
            // colHour
            // 
            this.colHour.FieldName = "Hour";
            this.colHour.Name = "colHour";
            this.colHour.Visible = true;
            this.colHour.VisibleIndex = 1;
            // 
            // colTotal
            // 
            this.colTotal.Caption = "Total";
            this.colTotal.DisplayFormat.FormatString = "{0:#,##0.00;(#,##0.00);\\\'\\\'}";
            this.colTotal.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Custom;
            this.colTotal.FieldName = "colTotal";
            this.colTotal.Name = "colTotal";
            this.colTotal.SummaryItem.DisplayFormat = "{0:#,##0.00;(#,##0.00);\\\'\\\'}";
            this.colTotal.SummaryItem.SummaryType = DevExpress.Data.SummaryItemType.Sum;
            this.colTotal.UnboundExpression = "[Hour] * [LabourRate]";
            this.colTotal.UnboundType = DevExpress.Data.UnboundColumnType.Decimal;
            this.colTotal.Visible = true;
            this.colTotal.VisibleIndex = 3;
            // 
            // toolStrip4
            // 
            this.toolStrip4.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.btnNewLabour,
            this.btnDeleteLabour});
            this.toolStrip4.Location = new System.Drawing.Point(0, 0);
            this.toolStrip4.Name = "toolStrip4";
            this.toolStrip4.Size = new System.Drawing.Size(910, 25);
            this.toolStrip4.TabIndex = 0;
            this.toolStrip4.Text = "toolStrip4";
            // 
            // btnNewLabour
            // 
            this.btnNewLabour.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.btnNewLabour.Image = ((System.Drawing.Image)(resources.GetObject("btnNewLabour.Image")));
            this.btnNewLabour.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnNewLabour.Name = "btnNewLabour";
            this.btnNewLabour.Size = new System.Drawing.Size(23, 22);
            this.btnNewLabour.Text = "&New";
            this.btnNewLabour.Click += new System.EventHandler(this.btnNewLabour_Click);
            // 
            // btnDeleteLabour
            // 
            this.btnDeleteLabour.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.btnDeleteLabour.Enabled = false;
            this.btnDeleteLabour.Image = global::ClearOffice.Wms.Properties.Resources.delete;
            this.btnDeleteLabour.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnDeleteLabour.Name = "btnDeleteLabour";
            this.btnDeleteLabour.Size = new System.Drawing.Size(23, 22);
            this.btnDeleteLabour.Text = "toolStripButton1";
            this.btnDeleteLabour.ToolTipText = "Delete";
            this.btnDeleteLabour.Click += new System.EventHandler(this.btnDeleteLabour_Click);
            // 
            // panelControl2
            // 
            this.panelControl2.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panelControl2.Controls.Add(this.TotalsGroupBox);
            this.panelControl2.Controls.Add(this.OptionalInfoGroupBox);
            this.panelControl2.Location = new System.Drawing.Point(4, 379);
            this.panelControl2.Name = "panelControl2";
            this.panelControl2.Size = new System.Drawing.Size(916, 172);
            this.panelControl2.TabIndex = 3;
            // 
            // TotalsGroupBox
            // 
            this.TotalsGroupBox.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.TotalsGroupBox.Controls.Add(this.TxtTotal);
            this.TotalsGroupBox.Controls.Add(this.label3);
            this.TotalsGroupBox.Controls.Add(this.TxtTaxes);
            this.TotalsGroupBox.Controls.Add(this.TaxCheckBox);
            this.TotalsGroupBox.Controls.Add(this.TxtDiscount);
            this.TotalsGroupBox.Controls.Add(this.DiscountCheckBox);
            this.TotalsGroupBox.Controls.Add(this.TxtLabourTotal);
            this.TotalsGroupBox.Controls.Add(this.label2);
            this.TotalsGroupBox.Controls.Add(this.TxtPartTotal);
            this.TotalsGroupBox.Controls.Add(this.label1);
            this.TotalsGroupBox.Location = new System.Drawing.Point(612, 4);
            this.TotalsGroupBox.Name = "TotalsGroupBox";
            this.TotalsGroupBox.Size = new System.Drawing.Size(296, 157);
            this.TotalsGroupBox.TabIndex = 1;
            this.TotalsGroupBox.TabStop = false;
            this.TotalsGroupBox.Text = "Totals";
            // 
            // TxtTotal
            // 
            this.TxtTotal.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.WorkOrderBindingSource, "TotalCost", true, System.Windows.Forms.DataSourceUpdateMode.OnValidation, null, "C2"));
            this.TxtTotal.Enabled = false;
            this.TxtTotal.Location = new System.Drawing.Point(95, 121);
            this.TxtTotal.Name = "TxtTotal";
            this.TxtTotal.Size = new System.Drawing.Size(141, 21);
            this.TxtTotal.TabIndex = 19;
            this.TxtTotal.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // label3
            // 
            this.label3.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(7, 124);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(35, 13);
            this.label3.TabIndex = 18;
            this.label3.Text = "Total:";
            // 
            // TxtTaxes
            // 
            this.TxtTaxes.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.WorkOrderBindingSource, "Tax", true));
            this.TxtTaxes.Enabled = false;
            this.TxtTaxes.Location = new System.Drawing.Point(95, 95);
            this.TxtTaxes.Name = "TxtTaxes";
            this.TxtTaxes.Size = new System.Drawing.Size(141, 21);
            this.TxtTaxes.TabIndex = 17;
            this.TxtTaxes.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // TaxCheckBox
            // 
            this.TaxCheckBox.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.TaxCheckBox.AutoSize = true;
            this.TaxCheckBox.Location = new System.Drawing.Point(7, 97);
            this.TaxCheckBox.Name = "TaxCheckBox";
            this.TaxCheckBox.Size = new System.Drawing.Size(66, 17);
            this.TaxCheckBox.TabIndex = 16;
            this.TaxCheckBox.Text = "Taxes %";
            this.TaxCheckBox.UseVisualStyleBackColor = true;
            this.TaxCheckBox.CheckedChanged += new System.EventHandler(this.TaxCheckBox_CheckedChanged);
            // 
            // TxtDiscount
            // 
            this.TxtDiscount.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.WorkOrderBindingSource, "Discount", true));
            this.TxtDiscount.Enabled = false;
            this.TxtDiscount.Location = new System.Drawing.Point(95, 70);
            this.TxtDiscount.Name = "TxtDiscount";
            this.TxtDiscount.Size = new System.Drawing.Size(141, 21);
            this.TxtDiscount.TabIndex = 15;
            this.TxtDiscount.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // DiscountCheckBox
            // 
            this.DiscountCheckBox.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.DiscountCheckBox.AutoSize = true;
            this.DiscountCheckBox.Location = new System.Drawing.Point(7, 72);
            this.DiscountCheckBox.Name = "DiscountCheckBox";
            this.DiscountCheckBox.Size = new System.Drawing.Size(79, 17);
            this.DiscountCheckBox.TabIndex = 14;
            this.DiscountCheckBox.Text = "Discount %";
            this.DiscountCheckBox.UseVisualStyleBackColor = true;
            this.DiscountCheckBox.CheckedChanged += new System.EventHandler(this.DiscountCheckBox_CheckedChanged);
            // 
            // TxtLabourTotal
            // 
            this.TxtLabourTotal.Enabled = false;
            this.TxtLabourTotal.Location = new System.Drawing.Point(95, 45);
            this.TxtLabourTotal.Name = "TxtLabourTotal";
            this.TxtLabourTotal.Size = new System.Drawing.Size(141, 21);
            this.TxtLabourTotal.TabIndex = 13;
            this.TxtLabourTotal.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // label2
            // 
            this.label2.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label2.AutoSize = true;
            this.label2.Enabled = false;
            this.label2.Location = new System.Drawing.Point(7, 47);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(44, 13);
            this.label2.TabIndex = 12;
            this.label2.Text = "Labour:";
            // 
            // TxtPartTotal
            // 
            this.TxtPartTotal.Enabled = false;
            this.TxtPartTotal.Location = new System.Drawing.Point(95, 16);
            this.TxtPartTotal.Name = "TxtPartTotal";
            this.TxtPartTotal.Size = new System.Drawing.Size(141, 21);
            this.TxtPartTotal.TabIndex = 11;
            this.TxtPartTotal.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // label1
            // 
            this.label1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label1.AutoSize = true;
            this.label1.Enabled = false;
            this.label1.Location = new System.Drawing.Point(7, 19);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(36, 13);
            this.label1.TabIndex = 10;
            this.label1.Text = "Parts:";
            // 
            // OptionalInfoGroupBox
            // 
            this.OptionalInfoGroupBox.Controls.Add(assignedToLabel);
            this.OptionalInfoGroupBox.Controls.Add(this.assignedToLookUpEdit);
            this.OptionalInfoGroupBox.Controls.Add(priorityLabel);
            this.OptionalInfoGroupBox.Controls.Add(this.priorityLookUpEdit);
            this.OptionalInfoGroupBox.Location = new System.Drawing.Point(6, 15);
            this.OptionalInfoGroupBox.Name = "OptionalInfoGroupBox";
            this.OptionalInfoGroupBox.Size = new System.Drawing.Size(353, 114);
            this.OptionalInfoGroupBox.TabIndex = 0;
            this.OptionalInfoGroupBox.TabStop = false;
            this.OptionalInfoGroupBox.Text = "Optional Informations";
            // 
            // assignedToLookUpEdit
            // 
            this.assignedToLookUpEdit.DataBindings.Add(new System.Windows.Forms.Binding("EditValue", this.WorkOrderBindingSource, "AssignedTo", true));
            this.assignedToLookUpEdit.Location = new System.Drawing.Point(93, 33);
            this.assignedToLookUpEdit.Name = "assignedToLookUpEdit";
            this.assignedToLookUpEdit.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.assignedToLookUpEdit.Properties.Columns.AddRange(new DevExpress.XtraEditors.Controls.LookUpColumnInfo[] {
            new DevExpress.XtraEditors.Controls.LookUpColumnInfo("EmployeeNo", "Employee No", 72, DevExpress.Utils.FormatType.None, "", true, DevExpress.Utils.HorzAlignment.Near),
            new DevExpress.XtraEditors.Controls.LookUpColumnInfo("FullName", "Full Name", 56, DevExpress.Utils.FormatType.None, "", true, DevExpress.Utils.HorzAlignment.Near)});
            this.assignedToLookUpEdit.Properties.DataSource = this.EmployeesBindingSource;
            this.assignedToLookUpEdit.Properties.DisplayMember = "FullName";
            this.assignedToLookUpEdit.Properties.NullText = "[Select Assignee]";
            this.assignedToLookUpEdit.Properties.ValueMember = "EmployeeId";
            this.assignedToLookUpEdit.Size = new System.Drawing.Size(163, 20);
            this.assignedToLookUpEdit.TabIndex = 8;
            // 
            // EmployeesBindingSource
            // 
            this.EmployeesBindingSource.DataSource = typeof(ClearOffice.Wms.Business.WorkshopEmployeesInfo);
            // 
            // priorityLookUpEdit
            // 
            this.priorityLookUpEdit.DataBindings.Add(new System.Windows.Forms.Binding("EditValue", this.WorkOrderBindingSource, "Priority", true));
            this.priorityLookUpEdit.Location = new System.Drawing.Point(93, 59);
            this.priorityLookUpEdit.Name = "priorityLookUpEdit";
            this.priorityLookUpEdit.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.priorityLookUpEdit.Properties.Columns.AddRange(new DevExpress.XtraEditors.Controls.LookUpColumnInfo[] {
            new DevExpress.XtraEditors.Controls.LookUpColumnInfo("Name", "Name", 37, DevExpress.Utils.FormatType.None, "", true, DevExpress.Utils.HorzAlignment.Near),
            new DevExpress.XtraEditors.Controls.LookUpColumnInfo("Code", "Code", 35, DevExpress.Utils.FormatType.None, "", true, DevExpress.Utils.HorzAlignment.Near)});
            this.priorityLookUpEdit.Properties.DataSource = this.PriorityBindingSource;
            this.priorityLookUpEdit.Properties.DisplayMember = "Name";
            this.priorityLookUpEdit.Properties.NullText = "[Select Priority]";
            this.priorityLookUpEdit.Properties.ValueMember = "ItemId";
            this.priorityLookUpEdit.Size = new System.Drawing.Size(163, 20);
            this.priorityLookUpEdit.TabIndex = 6;
            // 
            // PriorityBindingSource
            // 
            this.PriorityBindingSource.DataSource = typeof(ClearOffice.Wms.Business.LookupItem);
            // 
            // WorkorderErrorProvider
            // 
            this.WorkorderErrorProvider.ContainerControl = this;
            // 
            // xtraTabControl1
            // 
            this.xtraTabControl1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.xtraTabControl1.Location = new System.Drawing.Point(4, 176);
            this.xtraTabControl1.Name = "xtraTabControl1";
            this.xtraTabControl1.SelectedTabPage = this.maintenanceTaskXtraTabPage;
            this.xtraTabControl1.Size = new System.Drawing.Size(916, 197);
            this.xtraTabControl1.TabIndex = 4;
            this.xtraTabControl1.TabPages.AddRange(new DevExpress.XtraTab.XtraTabPage[] {
            this.maintenanceTaskXtraTabPage,
            this.partsXtraTabPage,
            this.laborXtraTabPage});
            // 
            // maintenanceTaskXtraTabPage
            // 
            this.maintenanceTaskXtraTabPage.Controls.Add(this.gridControl1);
            this.maintenanceTaskXtraTabPage.Controls.Add(this.toolStrip2);
            this.maintenanceTaskXtraTabPage.Name = "maintenanceTaskXtraTabPage";
            this.maintenanceTaskXtraTabPage.Size = new System.Drawing.Size(910, 171);
            this.maintenanceTaskXtraTabPage.Text = "Maintenance Tasks";
            // 
            // partsXtraTabPage
            // 
            this.partsXtraTabPage.Controls.Add(this.gridControl2);
            this.partsXtraTabPage.Controls.Add(this.toolStrip3);
            this.partsXtraTabPage.Name = "partsXtraTabPage";
            this.partsXtraTabPage.Size = new System.Drawing.Size(910, 171);
            this.partsXtraTabPage.Text = "Parts";
            // 
            // laborXtraTabPage
            // 
            this.laborXtraTabPage.Controls.Add(this.gridControl3);
            this.laborXtraTabPage.Controls.Add(this.toolStrip4);
            this.laborXtraTabPage.Name = "laborXtraTabPage";
            this.laborXtraTabPage.Size = new System.Drawing.Size(910, 171);
            this.laborXtraTabPage.Text = "Labor Units";
            // 
            // WorkOrderView
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(924, 553);
            this.Controls.Add(this.xtraTabControl1);
            this.Controls.Add(this.panelControl2);
            this.Controls.Add(this.panelControl1);
            this.Controls.Add(this.toolStrip1);
            this.Name = "WorkOrderView";
            this.Text = "WorkOrderView";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.WorkOrderView_FormClosing);
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.panelControl1)).EndInit();
            this.panelControl1.ResumeLayout(false);
            this.panelControl1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.statusLookUpEdit.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.WorkOrderBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.StatusBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.endDateDateEdit.Properties.VistaTimeProperties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.endDateDateEdit.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.startDateDateEdit.Properties.VistaTimeProperties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.startDateDateEdit.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.issueDateDateEdit.Properties.VistaTimeProperties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.issueDateDateEdit.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridControl1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.TasksBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.MaintainanceTasksGridView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.taskNameRepositoryItemGridLookUpEdit)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pmServiceListBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).EndInit();
            this.toolStrip2.ResumeLayout(false);
            this.toolStrip2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gridControl2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.partsBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.PartsGridView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.partNoRepositoryItemGridLookUpEdit)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.partInfoBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView2)).EndInit();
            this.toolStrip3.ResumeLayout(false);
            this.toolStrip3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gridControl3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.laboursBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.LaboursGridView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.performerNameRepositoryItemGridLookUpEdit)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.vendorAndEmployeesBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView3)).EndInit();
            this.toolStrip4.ResumeLayout(false);
            this.toolStrip4.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.panelControl2)).EndInit();
            this.panelControl2.ResumeLayout(false);
            this.TotalsGroupBox.ResumeLayout(false);
            this.TotalsGroupBox.PerformLayout();
            this.OptionalInfoGroupBox.ResumeLayout(false);
            this.OptionalInfoGroupBox.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.assignedToLookUpEdit.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.EmployeesBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.priorityLookUpEdit.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.PriorityBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.WorkorderErrorProvider)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.xtraTabControl1)).EndInit();
            this.xtraTabControl1.ResumeLayout(false);
            this.maintenanceTaskXtraTabPage.ResumeLayout(false);
            this.maintenanceTaskXtraTabPage.PerformLayout();
            this.partsXtraTabPage.ResumeLayout(false);
            this.partsXtraTabPage.PerformLayout();
            this.laborXtraTabPage.ResumeLayout(false);
            this.laborXtraTabPage.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ToolStrip toolStrip1;
        private System.Windows.Forms.ToolStripButton BtnSave;
        private DevExpress.XtraEditors.PanelControl panelControl1;
        private DevExpress.XtraEditors.PanelControl panelControl2;
        private System.Windows.Forms.GroupBox TotalsGroupBox;
        private System.Windows.Forms.TextBox TxtTotal;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox TxtTaxes;
        private System.Windows.Forms.CheckBox TaxCheckBox;
        private System.Windows.Forms.TextBox TxtDiscount;
        private System.Windows.Forms.CheckBox DiscountCheckBox;
        private System.Windows.Forms.TextBox TxtLabourTotal;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox TxtPartTotal;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox OptionalInfoGroupBox;
        private DevExpress.XtraEditors.LookUpEdit assignedToLookUpEdit;
        private System.Windows.Forms.BindingSource WorkOrderBindingSource;
        private DevExpress.XtraEditors.LookUpEdit priorityLookUpEdit;
        private System.Windows.Forms.BindingSource pmServiceListBindingSource;
        private DevExpress.XtraGrid.GridControl gridControl1;
        private DevExpress.XtraGrid.Views.Grid.GridView MaintainanceTasksGridView;
        private System.Windows.Forms.ToolStrip toolStrip2;
        private System.Windows.Forms.ToolStripButton btnNewTask;
        private DevExpress.XtraGrid.GridControl gridControl2;
        private DevExpress.XtraGrid.Views.Grid.GridView PartsGridView;
        private DevExpress.XtraGrid.GridControl gridControl3;
        private DevExpress.XtraGrid.Views.Grid.GridView LaboursGridView;
        private DevExpress.XtraGrid.Columns.GridColumn colLabourRate;
        private DevExpress.XtraGrid.Columns.GridColumn colHour;
        private DevExpress.XtraGrid.Columns.GridColumn colTotal;
        private System.Windows.Forms.ToolStrip toolStrip4;
        private System.Windows.Forms.ToolStripButton btnNewLabour;
        private System.Windows.Forms.ToolStripButton btnDelete;
        private DevExpress.XtraEditors.LookUpEdit statusLookUpEdit;
        private System.Windows.Forms.TextBox remarkTextBox;
        private DevExpress.XtraEditors.DateEdit endDateDateEdit;
        private DevExpress.XtraEditors.DateEdit startDateDateEdit;
        private DevExpress.XtraEditors.DateEdit issueDateDateEdit;
        private System.Windows.Forms.TextBox workOrderNoTextBox;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.BindingSource StatusBindingSource;
        private System.Windows.Forms.BindingSource PriorityBindingSource;
        private System.Windows.Forms.BindingSource EmployeesBindingSource;
        private System.Windows.Forms.ToolStripButton btnDeleteTask;
        private System.Windows.Forms.ToolStripButton btnDeleteLabour;
        private System.Windows.Forms.ErrorProvider WorkorderErrorProvider;
        private System.Windows.Forms.BindingSource TasksBindingSource;
        private System.Windows.Forms.BindingSource partsBindingSource;
        private System.Windows.Forms.BindingSource laboursBindingSource;
        private System.Windows.Forms.BindingSource vendorAndEmployeesBindingSource;
        private System.Windows.Forms.BindingSource partInfoBindingSource;
        private DevExpress.XtraGrid.Columns.GridColumn colServiceTypeId;
        private DevExpress.XtraEditors.Repository.RepositoryItemGridLookUpEdit taskNameRepositoryItemGridLookUpEdit;
        private DevExpress.XtraGrid.Views.Grid.GridView gridView1;
        private DevExpress.XtraGrid.Columns.GridColumn colPartsCost;
        private DevExpress.XtraGrid.Columns.GridColumn colLabourCost;
        private DevExpress.XtraEditors.Repository.RepositoryItemGridLookUpEdit partNoRepositoryItemGridLookUpEdit;
        private DevExpress.XtraGrid.Views.Grid.GridView gridView2;
        private DevExpress.XtraEditors.Repository.RepositoryItemGridLookUpEdit performerNameRepositoryItemGridLookUpEdit;
        private DevExpress.XtraGrid.Views.Grid.GridView gridView3;
        private System.Windows.Forms.ToolStrip toolStrip3;
        private System.Windows.Forms.ToolStripButton btnDeleteParts;
        private DevExpress.XtraGrid.Columns.GridColumn colPerformerId;
        private DevExpress.XtraGrid.Columns.GridColumn colPartId;
        private DevExpress.XtraGrid.Columns.GridColumn colQuantity;
        private DevExpress.XtraGrid.Columns.GridColumn colUnitCost;
        private DevExpress.XtraGrid.Columns.GridColumn colTotal3;
        private DevExpress.XtraTab.XtraTabControl xtraTabControl1;
        private DevExpress.XtraTab.XtraTabPage maintenanceTaskXtraTabPage;
        private DevExpress.XtraTab.XtraTabPage partsXtraTabPage;
        private DevExpress.XtraTab.XtraTabPage laborXtraTabPage;
    }
}