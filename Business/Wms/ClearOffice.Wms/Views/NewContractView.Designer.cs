namespace ClearOffice.Wms.Views
{
    partial class NewContractView
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
            System.Windows.Forms.Label contractNoLabel;
            System.Windows.Forms.Label contractTypeLabel;
            System.Windows.Forms.Label contractDateLabel;
            System.Windows.Forms.Label paymentTermsLabel;
            System.Windows.Forms.Label startDateLabel;
            System.Windows.Forms.Label durationLabel;
            System.Windows.Forms.Label amountLabel;
            System.Windows.Forms.Label remarkLabel;
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(NewContractView));
            this.customerIdLabel = new System.Windows.Forms.Label();
            this.panelControl1 = new DevExpress.XtraEditors.PanelControl();
            this.remarkTextBox = new System.Windows.Forms.TextBox();
            this.ContractBindingSource = new System.Windows.Forms.BindingSource();
            this.customerIdGridLookUpEdit = new DevExpress.XtraEditors.GridLookUpEdit();
            this.CustomerListBindingSource = new System.Windows.Forms.BindingSource();
            this.customerIdGridLookUpEditView = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.colName = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colCustomerTypeName = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colContact = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colAddress = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colCity = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colPostalCode = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colPhone1 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colPhone2 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colFax = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colEmail = new DevExpress.XtraGrid.Columns.GridColumn();
            this.amountTextBox = new System.Windows.Forms.TextBox();
            this.RenewalBindingSource = new System.Windows.Forms.BindingSource();
            this.CmboDuration = new System.Windows.Forms.ComboBox();
            this.DurationBindingSource = new System.Windows.Forms.BindingSource();
            this.durationTextBox = new System.Windows.Forms.TextBox();
            this.startDateDateEdit = new DevExpress.XtraEditors.DateEdit();
            this.paymentTermsLookUpEdit = new DevExpress.XtraEditors.LookUpEdit();
            this.PaymentTermsBindingSource = new System.Windows.Forms.BindingSource();
            this.contractDateDateEdit = new DevExpress.XtraEditors.DateEdit();
            this.contractTypeLookUpEdit = new DevExpress.XtraEditors.LookUpEdit();
            this.ContractTypeBindingSource = new System.Windows.Forms.BindingSource();
            this.contractNoTextBox = new System.Windows.Forms.TextBox();
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.BtnSave = new System.Windows.Forms.ToolStripButton();
            this.BtnSaveNew = new System.Windows.Forms.ToolStripButton();
            this.NewContractErrorProvider = new System.Windows.Forms.ErrorProvider();
            contractNoLabel = new System.Windows.Forms.Label();
            contractTypeLabel = new System.Windows.Forms.Label();
            contractDateLabel = new System.Windows.Forms.Label();
            paymentTermsLabel = new System.Windows.Forms.Label();
            startDateLabel = new System.Windows.Forms.Label();
            durationLabel = new System.Windows.Forms.Label();
            amountLabel = new System.Windows.Forms.Label();
            remarkLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.panelControl1)).BeginInit();
            this.panelControl1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ContractBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.customerIdGridLookUpEdit.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.CustomerListBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.customerIdGridLookUpEditView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.RenewalBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.DurationBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.startDateDateEdit.Properties.VistaTimeProperties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.startDateDateEdit.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.paymentTermsLookUpEdit.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.PaymentTermsBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.contractDateDateEdit.Properties.VistaTimeProperties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.contractDateDateEdit.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.contractTypeLookUpEdit.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ContractTypeBindingSource)).BeginInit();
            this.toolStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.NewContractErrorProvider)).BeginInit();
            this.SuspendLayout();
            // 
            // contractNoLabel
            // 
            contractNoLabel.AutoSize = true;
            contractNoLabel.Location = new System.Drawing.Point(12, 12);
            contractNoLabel.Name = "contractNoLabel";
            contractNoLabel.Size = new System.Drawing.Size(69, 13);
            contractNoLabel.TabIndex = 0;
            contractNoLabel.Text = "Contract No:";
            // 
            // contractTypeLabel
            // 
            contractTypeLabel.AutoSize = true;
            contractTypeLabel.Location = new System.Drawing.Point(12, 92);
            contractTypeLabel.Name = "contractTypeLabel";
            contractTypeLabel.Size = new System.Drawing.Size(80, 13);
            contractTypeLabel.TabIndex = 2;
            contractTypeLabel.Text = "Contract Type:";
            // 
            // contractDateLabel
            // 
            contractDateLabel.AutoSize = true;
            contractDateLabel.Location = new System.Drawing.Point(12, 37);
            contractDateLabel.Name = "contractDateLabel";
            contractDateLabel.Size = new System.Drawing.Size(79, 13);
            contractDateLabel.TabIndex = 4;
            contractDateLabel.Text = "Contract Date:";
            // 
            // paymentTermsLabel
            // 
            paymentTermsLabel.AutoSize = true;
            paymentTermsLabel.Location = new System.Drawing.Point(12, 148);
            paymentTermsLabel.Name = "paymentTermsLabel";
            paymentTermsLabel.Size = new System.Drawing.Size(80, 13);
            paymentTermsLabel.TabIndex = 8;
            paymentTermsLabel.Text = "Payment Term:";
            // 
            // startDateLabel
            // 
            startDateLabel.AutoSize = true;
            startDateLabel.Location = new System.Drawing.Point(280, 37);
            startDateLabel.Name = "startDateLabel";
            startDateLabel.Size = new System.Drawing.Size(61, 13);
            startDateLabel.TabIndex = 10;
            startDateLabel.Text = "Start Date:";
            // 
            // durationLabel
            // 
            durationLabel.AutoSize = true;
            durationLabel.Location = new System.Drawing.Point(12, 122);
            durationLabel.Name = "durationLabel";
            durationLabel.Size = new System.Drawing.Size(52, 13);
            durationLabel.TabIndex = 12;
            durationLabel.Text = "Duration:";
            // 
            // amountLabel
            // 
            amountLabel.AutoSize = true;
            amountLabel.Location = new System.Drawing.Point(280, 121);
            amountLabel.Name = "amountLabel";
            amountLabel.Size = new System.Drawing.Size(48, 13);
            amountLabel.TabIndex = 15;
            amountLabel.Text = "Amount:";
            // 
            // remarkLabel
            // 
            remarkLabel.AutoSize = true;
            remarkLabel.Location = new System.Drawing.Point(12, 175);
            remarkLabel.Name = "remarkLabel";
            remarkLabel.Size = new System.Drawing.Size(47, 13);
            remarkLabel.TabIndex = 17;
            remarkLabel.Text = "Remark:";
            // 
            // customerIdLabel
            // 
            this.customerIdLabel.AutoSize = true;
            this.customerIdLabel.Location = new System.Drawing.Point(12, 66);
            this.customerIdLabel.Name = "customerIdLabel";
            this.customerIdLabel.Size = new System.Drawing.Size(57, 13);
            this.customerIdLabel.TabIndex = 16;
            this.customerIdLabel.Text = "Customer:";
            // 
            // panelControl1
            // 
            this.panelControl1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panelControl1.Controls.Add(remarkLabel);
            this.panelControl1.Controls.Add(this.remarkTextBox);
            this.panelControl1.Controls.Add(this.customerIdLabel);
            this.panelControl1.Controls.Add(this.customerIdGridLookUpEdit);
            this.panelControl1.Controls.Add(amountLabel);
            this.panelControl1.Controls.Add(this.amountTextBox);
            this.panelControl1.Controls.Add(this.CmboDuration);
            this.panelControl1.Controls.Add(durationLabel);
            this.panelControl1.Controls.Add(this.durationTextBox);
            this.panelControl1.Controls.Add(startDateLabel);
            this.panelControl1.Controls.Add(this.startDateDateEdit);
            this.panelControl1.Controls.Add(paymentTermsLabel);
            this.panelControl1.Controls.Add(this.paymentTermsLookUpEdit);
            this.panelControl1.Controls.Add(contractDateLabel);
            this.panelControl1.Controls.Add(this.contractDateDateEdit);
            this.panelControl1.Controls.Add(contractTypeLabel);
            this.panelControl1.Controls.Add(this.contractTypeLookUpEdit);
            this.panelControl1.Controls.Add(contractNoLabel);
            this.panelControl1.Controls.Add(this.contractNoTextBox);
            this.panelControl1.Location = new System.Drawing.Point(0, 28);
            this.panelControl1.Name = "panelControl1";
            this.panelControl1.Size = new System.Drawing.Size(522, 293);
            this.panelControl1.TabIndex = 0;
            // 
            // remarkTextBox
            // 
            this.remarkTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.ContractBindingSource, "Remark", true));
            this.remarkTextBox.Location = new System.Drawing.Point(101, 172);
            this.remarkTextBox.Multiline = true;
            this.remarkTextBox.Name = "remarkTextBox";
            this.remarkTextBox.Size = new System.Drawing.Size(408, 99);
            this.remarkTextBox.TabIndex = 18;
            // 
            // ContractBindingSource
            // 
            this.ContractBindingSource.DataSource = typeof(ClearOffice.Wms.Business.Contract);
            // 
            // customerIdGridLookUpEdit
            // 
            this.customerIdGridLookUpEdit.DataBindings.Add(new System.Windows.Forms.Binding("EditValue", this.ContractBindingSource, "CustomerId", true));
            this.customerIdGridLookUpEdit.EditValue = "[Select customer]";
            this.customerIdGridLookUpEdit.Location = new System.Drawing.Point(101, 63);
            this.customerIdGridLookUpEdit.Name = "customerIdGridLookUpEdit";
            this.customerIdGridLookUpEdit.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.customerIdGridLookUpEdit.Properties.DataSource = this.CustomerListBindingSource;
            this.customerIdGridLookUpEdit.Properties.DisplayMember = "Name";
            this.customerIdGridLookUpEdit.Properties.NullText = "[Select customer]";
            this.customerIdGridLookUpEdit.Properties.PopupFormSize = new System.Drawing.Size(550, 0);
            this.customerIdGridLookUpEdit.Properties.ValueMember = "CustomerId";
            this.customerIdGridLookUpEdit.Properties.View = this.customerIdGridLookUpEditView;
            this.customerIdGridLookUpEdit.Size = new System.Drawing.Size(408, 20);
            this.customerIdGridLookUpEdit.TabIndex = 8;
            // 
            // CustomerListBindingSource
            // 
            this.CustomerListBindingSource.DataSource = typeof(ClearOffice.Wms.Business.CustomerInfo);
            // 
            // customerIdGridLookUpEditView
            // 
            this.customerIdGridLookUpEditView.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.colName,
            this.colCustomerTypeName,
            this.colContact,
            this.colAddress,
            this.colCity,
            this.colPostalCode,
            this.colPhone1,
            this.colPhone2,
            this.colFax,
            this.colEmail});
            this.customerIdGridLookUpEditView.FocusRectStyle = DevExpress.XtraGrid.Views.Grid.DrawFocusRectStyle.RowFocus;
            this.customerIdGridLookUpEditView.Name = "customerIdGridLookUpEditView";
            this.customerIdGridLookUpEditView.OptionsSelection.EnableAppearanceFocusedCell = false;
            this.customerIdGridLookUpEditView.OptionsView.ShowAutoFilterRow = true;
            this.customerIdGridLookUpEditView.OptionsView.ShowGroupPanel = false;
            // 
            // colName
            // 
            this.colName.FieldName = "Name";
            this.colName.Name = "colName";
            this.colName.Visible = true;
            this.colName.VisibleIndex = 0;
            // 
            // colCustomerTypeName
            // 
            this.colCustomerTypeName.Caption = "Customer Type";
            this.colCustomerTypeName.FieldName = "CustomerTypeName";
            this.colCustomerTypeName.Name = "colCustomerTypeName";
            this.colCustomerTypeName.Visible = true;
            this.colCustomerTypeName.VisibleIndex = 9;
            // 
            // colContact
            // 
            this.colContact.FieldName = "Contact";
            this.colContact.Name = "colContact";
            this.colContact.Visible = true;
            this.colContact.VisibleIndex = 1;
            // 
            // colAddress
            // 
            this.colAddress.FieldName = "Address";
            this.colAddress.Name = "colAddress";
            this.colAddress.Visible = true;
            this.colAddress.VisibleIndex = 2;
            // 
            // colCity
            // 
            this.colCity.FieldName = "City";
            this.colCity.Name = "colCity";
            this.colCity.Visible = true;
            this.colCity.VisibleIndex = 3;
            // 
            // colPostalCode
            // 
            this.colPostalCode.FieldName = "PostalCode";
            this.colPostalCode.Name = "colPostalCode";
            this.colPostalCode.Visible = true;
            this.colPostalCode.VisibleIndex = 4;
            // 
            // colPhone1
            // 
            this.colPhone1.FieldName = "Phone1";
            this.colPhone1.Name = "colPhone1";
            this.colPhone1.Visible = true;
            this.colPhone1.VisibleIndex = 5;
            // 
            // colPhone2
            // 
            this.colPhone2.FieldName = "Phone2";
            this.colPhone2.Name = "colPhone2";
            this.colPhone2.Visible = true;
            this.colPhone2.VisibleIndex = 6;
            // 
            // colFax
            // 
            this.colFax.FieldName = "Fax";
            this.colFax.Name = "colFax";
            this.colFax.Visible = true;
            this.colFax.VisibleIndex = 7;
            // 
            // colEmail
            // 
            this.colEmail.FieldName = "Email";
            this.colEmail.Name = "colEmail";
            this.colEmail.Visible = true;
            this.colEmail.VisibleIndex = 8;
            // 
            // amountTextBox
            // 
            this.amountTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.RenewalBindingSource, "Amount", true));
            this.amountTextBox.Location = new System.Drawing.Point(342, 118);
            this.amountTextBox.Name = "amountTextBox";
            this.amountTextBox.Size = new System.Drawing.Size(167, 21);
            this.amountTextBox.TabIndex = 6;
            this.amountTextBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // RenewalBindingSource
            // 
            this.RenewalBindingSource.DataSource = typeof(ClearOffice.Wms.Business.ContractRenewal);
            // 
            // CmboDuration
            // 
            this.CmboDuration.DataSource = this.DurationBindingSource;
            this.CmboDuration.DisplayMember = "Name";
            this.CmboDuration.FormattingEnabled = true;
            this.CmboDuration.Location = new System.Drawing.Point(203, 118);
            this.CmboDuration.Name = "CmboDuration";
            this.CmboDuration.Size = new System.Drawing.Size(65, 21);
            this.CmboDuration.TabIndex = 4;
            this.CmboDuration.ValueMember = "Value";
            // 
            // DurationBindingSource
            // 
            this.DurationBindingSource.DataSource = typeof(ClearOffice.Wms.Views.DurationType);
            // 
            // durationTextBox
            // 
            this.durationTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.RenewalBindingSource, "Duration", true));
            this.durationTextBox.Location = new System.Drawing.Point(101, 119);
            this.durationTextBox.Name = "durationTextBox";
            this.durationTextBox.Size = new System.Drawing.Size(96, 21);
            this.durationTextBox.TabIndex = 3;
            this.durationTextBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // startDateDateEdit
            // 
            this.startDateDateEdit.DataBindings.Add(new System.Windows.Forms.Binding("EditValue", this.RenewalBindingSource, "StartDate", true));
            this.startDateDateEdit.EditValue = null;
            this.startDateDateEdit.Location = new System.Drawing.Point(342, 37);
            this.startDateDateEdit.Name = "startDateDateEdit";
            this.startDateDateEdit.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.startDateDateEdit.Properties.VistaTimeProperties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton()});
            this.startDateDateEdit.Size = new System.Drawing.Size(167, 20);
            this.startDateDateEdit.TabIndex = 5;
            // 
            // paymentTermsLookUpEdit
            // 
            this.paymentTermsLookUpEdit.DataBindings.Add(new System.Windows.Forms.Binding("EditValue", this.RenewalBindingSource, "PaymentTerms", true));
            this.paymentTermsLookUpEdit.Location = new System.Drawing.Point(101, 146);
            this.paymentTermsLookUpEdit.Name = "paymentTermsLookUpEdit";
            this.paymentTermsLookUpEdit.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.paymentTermsLookUpEdit.Properties.Columns.AddRange(new DevExpress.XtraEditors.Controls.LookUpColumnInfo[] {
            new DevExpress.XtraEditors.Controls.LookUpColumnInfo("Name", "Name", 37, DevExpress.Utils.FormatType.None, "", true, DevExpress.Utils.HorzAlignment.Near)});
            this.paymentTermsLookUpEdit.Properties.DataSource = this.PaymentTermsBindingSource;
            this.paymentTermsLookUpEdit.Properties.DisplayMember = "Name";
            this.paymentTermsLookUpEdit.Properties.NullText = "[Select Payment Term]";
            this.paymentTermsLookUpEdit.Properties.ValueMember = "ItemId";
            this.paymentTermsLookUpEdit.Size = new System.Drawing.Size(167, 20);
            this.paymentTermsLookUpEdit.TabIndex = 7;
            // 
            // PaymentTermsBindingSource
            // 
            this.PaymentTermsBindingSource.DataSource = typeof(ClearOffice.Wms.Business.LookupItem);
            // 
            // contractDateDateEdit
            // 
            this.contractDateDateEdit.DataBindings.Add(new System.Windows.Forms.Binding("EditValue", this.ContractBindingSource, "ContractDate", true));
            this.contractDateDateEdit.EditValue = null;
            this.contractDateDateEdit.Location = new System.Drawing.Point(101, 37);
            this.contractDateDateEdit.Name = "contractDateDateEdit";
            this.contractDateDateEdit.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.contractDateDateEdit.Properties.VistaTimeProperties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton()});
            this.contractDateDateEdit.Size = new System.Drawing.Size(167, 20);
            this.contractDateDateEdit.TabIndex = 2;
            // 
            // contractTypeLookUpEdit
            // 
            this.contractTypeLookUpEdit.DataBindings.Add(new System.Windows.Forms.Binding("EditValue", this.ContractBindingSource, "ContractType", true));
            this.contractTypeLookUpEdit.Location = new System.Drawing.Point(101, 89);
            this.contractTypeLookUpEdit.Name = "contractTypeLookUpEdit";
            this.contractTypeLookUpEdit.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.contractTypeLookUpEdit.Properties.Columns.AddRange(new DevExpress.XtraEditors.Controls.LookUpColumnInfo[] {
            new DevExpress.XtraEditors.Controls.LookUpColumnInfo("Name", "Name", 37, DevExpress.Utils.FormatType.None, "", true, DevExpress.Utils.HorzAlignment.Near)});
            this.contractTypeLookUpEdit.Properties.DataSource = this.ContractTypeBindingSource;
            this.contractTypeLookUpEdit.Properties.DisplayMember = "Name";
            this.contractTypeLookUpEdit.Properties.NullText = "[Select Contract Type]";
            this.contractTypeLookUpEdit.Properties.ValueMember = "ItemId";
            this.contractTypeLookUpEdit.Size = new System.Drawing.Size(167, 20);
            this.contractTypeLookUpEdit.TabIndex = 1;
            // 
            // ContractTypeBindingSource
            // 
            this.ContractTypeBindingSource.DataSource = typeof(ClearOffice.Wms.Business.LookupItem);
            // 
            // contractNoTextBox
            // 
            this.contractNoTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.ContractBindingSource, "ContractNo", true));
            this.contractNoTextBox.Location = new System.Drawing.Point(101, 10);
            this.contractNoTextBox.Name = "contractNoTextBox";
            this.contractNoTextBox.Size = new System.Drawing.Size(408, 21);
            this.contractNoTextBox.TabIndex = 0;
            // 
            // toolStrip1
            // 
            this.toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.BtnSave,
            this.BtnSaveNew});
            this.toolStrip1.Location = new System.Drawing.Point(0, 0);
            this.toolStrip1.Name = "toolStrip1";
            this.toolStrip1.Size = new System.Drawing.Size(522, 25);
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
            // BtnSaveNew
            // 
            this.BtnSaveNew.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.BtnSaveNew.Image = global::ClearOffice.Wms.Properties.Resources.page_save;
            this.BtnSaveNew.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.BtnSaveNew.Name = "BtnSaveNew";
            this.BtnSaveNew.Size = new System.Drawing.Size(23, 22);
            this.BtnSaveNew.Text = "BtnSaveNew";
            this.BtnSaveNew.ToolTipText = "Save & New";
            this.BtnSaveNew.Click += new System.EventHandler(this.BtnSaveNew_Click);
            // 
            // NewContractErrorProvider
            // 
            this.NewContractErrorProvider.ContainerControl = this;
            // 
            // NewContractView
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(522, 323);
            this.Controls.Add(this.toolStrip1);
            this.Controls.Add(this.panelControl1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "NewContractView";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "New Contract";
            ((System.ComponentModel.ISupportInitialize)(this.panelControl1)).EndInit();
            this.panelControl1.ResumeLayout(false);
            this.panelControl1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ContractBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.customerIdGridLookUpEdit.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.CustomerListBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.customerIdGridLookUpEditView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.RenewalBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.DurationBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.startDateDateEdit.Properties.VistaTimeProperties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.startDateDateEdit.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.paymentTermsLookUpEdit.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.PaymentTermsBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.contractDateDateEdit.Properties.VistaTimeProperties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.contractDateDateEdit.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.contractTypeLookUpEdit.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ContractTypeBindingSource)).EndInit();
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.NewContractErrorProvider)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private DevExpress.XtraEditors.PanelControl panelControl1;
        private System.Windows.Forms.ToolStrip toolStrip1;
        private System.Windows.Forms.ToolStripButton BtnSave;
        private System.Windows.Forms.ToolStripButton BtnSaveNew;
        private System.Windows.Forms.BindingSource ContractBindingSource;
        private System.Windows.Forms.BindingSource RenewalBindingSource;
        private System.Windows.Forms.BindingSource PaymentTermsBindingSource;
        private System.Windows.Forms.BindingSource CustomerListBindingSource;
        private System.Windows.Forms.TextBox amountTextBox;
        private System.Windows.Forms.ComboBox CmboDuration;
        private System.Windows.Forms.TextBox durationTextBox;
        private DevExpress.XtraEditors.DateEdit startDateDateEdit;
        private DevExpress.XtraEditors.LookUpEdit paymentTermsLookUpEdit;
        private DevExpress.XtraEditors.DateEdit contractDateDateEdit;
        private DevExpress.XtraEditors.LookUpEdit contractTypeLookUpEdit;
        private System.Windows.Forms.BindingSource ContractTypeBindingSource;
        private System.Windows.Forms.TextBox contractNoTextBox;
        private DevExpress.XtraEditors.GridLookUpEdit customerIdGridLookUpEdit;
        private DevExpress.XtraGrid.Views.Grid.GridView customerIdGridLookUpEditView;
        private DevExpress.XtraGrid.Columns.GridColumn colName;
        private DevExpress.XtraGrid.Columns.GridColumn colCustomerTypeName;
        private DevExpress.XtraGrid.Columns.GridColumn colContact;
        private DevExpress.XtraGrid.Columns.GridColumn colAddress;
        private DevExpress.XtraGrid.Columns.GridColumn colCity;
        private DevExpress.XtraGrid.Columns.GridColumn colPostalCode;
        private DevExpress.XtraGrid.Columns.GridColumn colPhone1;
        private DevExpress.XtraGrid.Columns.GridColumn colPhone2;
        private DevExpress.XtraGrid.Columns.GridColumn colFax;
        private DevExpress.XtraGrid.Columns.GridColumn colEmail;
        private System.Windows.Forms.ErrorProvider NewContractErrorProvider;
        private System.Windows.Forms.BindingSource DurationBindingSource;
        private System.Windows.Forms.Label customerIdLabel;
        private System.Windows.Forms.TextBox remarkTextBox;
    }
}