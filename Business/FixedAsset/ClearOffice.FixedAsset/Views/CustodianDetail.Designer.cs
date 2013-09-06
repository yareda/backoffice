namespace ClearOffice.FixedAsset.Views
{
    partial class CustodianDetail
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
            this.txtLocation = new System.Windows.Forms.TextBox();
            this.custodiandetailbindingSource = new System.Windows.Forms.BindingSource();
            this.cmbDepartment = new DevExpress.XtraEditors.LookUpEdit();
            this.departmentbindingSource = new System.Windows.Forms.BindingSource();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.chkStatus = new DevExpress.XtraEditors.CheckEdit();
            this.txtDescription = new System.Windows.Forms.TextBox();
            this.txtLastName = new System.Windows.Forms.TextBox();
            this.txtFirstName = new System.Windows.Forms.TextBox();
            this.txtBadgeNo = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.gridControl1 = new DevExpress.XtraGrid.GridControl();
            this.custodianassetbindingSource = new System.Windows.Forms.BindingSource();
            this.custodianassetgridView = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.colAssetNumber = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colDateFrom = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colItemName = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colDateTo = new DevExpress.XtraGrid.Columns.GridColumn();
            this.repositoryItemLookUpEdit = new DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit();
            this.statusbindingSource = new System.Windows.Forms.BindingSource();
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.btnCustodianSave = new System.Windows.Forms.ToolStripButton();
            this.btnDeleteCustodian = new System.Windows.Forms.ToolStripButton();
            this.custodianerrorProvider = new System.Windows.Forms.ErrorProvider();
            ((System.ComponentModel.ISupportInitialize)(this.custodiandetailbindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cmbDepartment.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.departmentbindingSource)).BeginInit();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.chkStatus.Properties)).BeginInit();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gridControl1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.custodianassetbindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.custodianassetgridView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemLookUpEdit)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.statusbindingSource)).BeginInit();
            this.toolStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.custodianerrorProvider)).BeginInit();
            this.SuspendLayout();
            // 
            // txtLocation
            // 
            this.txtLocation.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtLocation.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.custodiandetailbindingSource, "Location", true));
            this.txtLocation.Location = new System.Drawing.Point(519, 49);
            this.txtLocation.Name = "txtLocation";
            this.txtLocation.Size = new System.Drawing.Size(290, 21);
            this.txtLocation.TabIndex = 8;
            // 
            // custodiandetailbindingSource
            // 
            this.custodiandetailbindingSource.DataSource = typeof(ClearOffice.FixedAsset.DataAccess.Custodian);
            // 
            // cmbDepartment
            // 
            this.cmbDepartment.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.cmbDepartment.DataBindings.Add(new System.Windows.Forms.Binding("EditValue", this.custodiandetailbindingSource, "Department", true));
            this.cmbDepartment.Location = new System.Drawing.Point(519, 23);
            this.cmbDepartment.Name = "cmbDepartment";
            this.cmbDepartment.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.cmbDepartment.Properties.Columns.AddRange(new DevExpress.XtraEditors.Controls.LookUpColumnInfo[] {
            new DevExpress.XtraEditors.Controls.LookUpColumnInfo("ItemName", "Department", 62, DevExpress.Utils.FormatType.None, "", true, DevExpress.Utils.HorzAlignment.Near)});
            this.cmbDepartment.Properties.DataSource = this.departmentbindingSource;
            this.cmbDepartment.Properties.DisplayMember = "ItemName";
            this.cmbDepartment.Properties.NullText = "[Select Department]";
            this.cmbDepartment.Properties.ValueMember = "LookupItemId";
            this.cmbDepartment.Size = new System.Drawing.Size(290, 20);
            this.cmbDepartment.TabIndex = 4;
            // 
            // departmentbindingSource
            // 
            this.departmentbindingSource.DataSource = typeof(ClearOffice.FixedAsset.DataAccess.LookupItem);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(447, 76);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(38, 13);
            this.label7.TabIndex = 3;
            this.label7.Text = "Status";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(447, 50);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(47, 13);
            this.label6.TabIndex = 2;
            this.label6.Text = "Location";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(447, 26);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(64, 13);
            this.label5.TabIndex = 1;
            this.label5.Text = "Department";
            // 
            // groupBox1
            // 
            this.groupBox1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBox1.Controls.Add(this.chkStatus);
            this.groupBox1.Controls.Add(this.txtLocation);
            this.groupBox1.Controls.Add(this.txtDescription);
            this.groupBox1.Controls.Add(this.txtLastName);
            this.groupBox1.Controls.Add(this.cmbDepartment);
            this.groupBox1.Controls.Add(this.txtFirstName);
            this.groupBox1.Controls.Add(this.label7);
            this.groupBox1.Controls.Add(this.txtBadgeNo);
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Location = new System.Drawing.Point(12, 30);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(818, 188);
            this.groupBox1.TabIndex = 3;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Basic Information";
            // 
            // chkStatus
            // 
            this.chkStatus.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.chkStatus.DataBindings.Add(new System.Windows.Forms.Binding("EditValue", this.custodiandetailbindingSource, "Status", true));
            this.chkStatus.Location = new System.Drawing.Point(519, 76);
            this.chkStatus.Name = "chkStatus";
            this.chkStatus.Properties.Caption = "Active";
            this.chkStatus.Size = new System.Drawing.Size(290, 19);
            this.chkStatus.TabIndex = 9;
            // 
            // txtDescription
            // 
            this.txtDescription.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtDescription.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.custodiandetailbindingSource, "Remark", true));
            this.txtDescription.Location = new System.Drawing.Point(78, 101);
            this.txtDescription.Multiline = true;
            this.txtDescription.Name = "txtDescription";
            this.txtDescription.Size = new System.Drawing.Size(731, 81);
            this.txtDescription.TabIndex = 7;
            // 
            // txtLastName
            // 
            this.txtLastName.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.custodiandetailbindingSource, "LastName", true));
            this.txtLastName.Location = new System.Drawing.Point(78, 76);
            this.txtLastName.Name = "txtLastName";
            this.txtLastName.Size = new System.Drawing.Size(290, 21);
            this.txtLastName.TabIndex = 6;
            // 
            // txtFirstName
            // 
            this.txtFirstName.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.custodiandetailbindingSource, "FirstName", true));
            this.txtFirstName.Location = new System.Drawing.Point(78, 52);
            this.txtFirstName.Name = "txtFirstName";
            this.txtFirstName.Size = new System.Drawing.Size(290, 21);
            this.txtFirstName.TabIndex = 5;
            // 
            // txtBadgeNo
            // 
            this.txtBadgeNo.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.custodiandetailbindingSource, "BadgeNo", true));
            this.txtBadgeNo.Location = new System.Drawing.Point(78, 26);
            this.txtBadgeNo.Name = "txtBadgeNo";
            this.txtBadgeNo.Size = new System.Drawing.Size(290, 21);
            this.txtBadgeNo.TabIndex = 4;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(6, 98);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(43, 13);
            this.label4.TabIndex = 3;
            this.label4.Text = "Remark";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(6, 76);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(57, 13);
            this.label3.TabIndex = 2;
            this.label3.Text = "Last Name";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(6, 52);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(58, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "First Name";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(6, 29);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(48, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Badge #";
            // 
            // groupBox2
            // 
            this.groupBox2.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBox2.Controls.Add(this.gridControl1);
            this.groupBox2.Location = new System.Drawing.Point(12, 224);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(818, 197);
            this.groupBox2.TabIndex = 4;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Custodian Asset";
            // 
            // gridControl1
            // 
            this.gridControl1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.gridControl1.DataSource = this.custodianassetbindingSource;
            this.gridControl1.Location = new System.Drawing.Point(6, 20);
            this.gridControl1.MainView = this.custodianassetgridView;
            this.gridControl1.Name = "gridControl1";
            this.gridControl1.RepositoryItems.AddRange(new DevExpress.XtraEditors.Repository.RepositoryItem[] {
            this.repositoryItemLookUpEdit});
            this.gridControl1.Size = new System.Drawing.Size(806, 171);
            this.gridControl1.TabIndex = 0;
            this.gridControl1.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.custodianassetgridView});
            // 
            // custodianassetbindingSource
            // 
            this.custodianassetbindingSource.DataSource = typeof(ClearOffice.FixedAsset.DataAccess.CustodianAssetsList);
            // 
            // custodianassetgridView
            // 
            this.custodianassetgridView.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.colAssetNumber,
            this.colDateFrom,
            this.colItemName,
            this.colDateTo});
            this.custodianassetgridView.GridControl = this.gridControl1;
            this.custodianassetgridView.Name = "custodianassetgridView";
            this.custodianassetgridView.OptionsBehavior.Editable = false;
            this.custodianassetgridView.OptionsView.ShowGroupPanel = false;
            // 
            // colAssetNumber
            // 
            this.colAssetNumber.FieldName = "AssetNumber";
            this.colAssetNumber.Name = "colAssetNumber";
            this.colAssetNumber.Visible = true;
            this.colAssetNumber.VisibleIndex = 0;
            // 
            // colDateFrom
            // 
            this.colDateFrom.Caption = "Assigned From";
            this.colDateFrom.FieldName = "DateFrom";
            this.colDateFrom.Name = "colDateFrom";
            this.colDateFrom.Visible = true;
            this.colDateFrom.VisibleIndex = 1;
            // 
            // colItemName
            // 
            this.colItemName.Caption = "Status";
            this.colItemName.FieldName = "ItemName";
            this.colItemName.Name = "colItemName";
            this.colItemName.Visible = true;
            this.colItemName.VisibleIndex = 3;
            // 
            // colDateTo
            // 
            this.colDateTo.Caption = "Assigned To";
            this.colDateTo.FieldName = "DateTo";
            this.colDateTo.Name = "colDateTo";
            this.colDateTo.Visible = true;
            this.colDateTo.VisibleIndex = 2;
            // 
            // repositoryItemLookUpEdit
            // 
            this.repositoryItemLookUpEdit.AutoHeight = false;
            this.repositoryItemLookUpEdit.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.repositoryItemLookUpEdit.Columns.AddRange(new DevExpress.XtraEditors.Controls.LookUpColumnInfo[] {
            new DevExpress.XtraEditors.Controls.LookUpColumnInfo("ItemName", "Item Name", 62, DevExpress.Utils.FormatType.None, "", true, DevExpress.Utils.HorzAlignment.Near)});
            this.repositoryItemLookUpEdit.DataSource = this.statusbindingSource;
            this.repositoryItemLookUpEdit.DisplayMember = "ItemName";
            this.repositoryItemLookUpEdit.Name = "repositoryItemLookUpEdit";
            this.repositoryItemLookUpEdit.ValueMember = "LookupItemId";
            // 
            // statusbindingSource
            // 
            this.statusbindingSource.DataSource = typeof(ClearOffice.FixedAsset.DataAccess.LookupItem);
            // 
            // toolStrip1
            // 
            this.toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.btnCustodianSave,
            this.btnDeleteCustodian});
            this.toolStrip1.Location = new System.Drawing.Point(0, 0);
            this.toolStrip1.Name = "toolStrip1";
            this.toolStrip1.Size = new System.Drawing.Size(857, 25);
            this.toolStrip1.TabIndex = 5;
            this.toolStrip1.Text = "toolStrip1";
            // 
            // btnCustodianSave
            // 
            this.btnCustodianSave.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.btnCustodianSave.Image = global::ClearOffice.FixedAsset.Properties.Resources.Save_16x16;
            this.btnCustodianSave.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnCustodianSave.Name = "btnCustodianSave";
            this.btnCustodianSave.Size = new System.Drawing.Size(23, 22);
            this.btnCustodianSave.ToolTipText = "Save";
            this.btnCustodianSave.Click += new System.EventHandler(this.btnCustodianSave_Click);
            // 
            // btnDeleteCustodian
            // 
            this.btnDeleteCustodian.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.btnDeleteCustodian.Image = global::ClearOffice.FixedAsset.Properties.Resources.delete;
            this.btnDeleteCustodian.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnDeleteCustodian.Name = "btnDeleteCustodian";
            this.btnDeleteCustodian.Size = new System.Drawing.Size(23, 22);
            this.btnDeleteCustodian.Text = "toolStripButton2";
            this.btnDeleteCustodian.ToolTipText = "Delete";
            this.btnDeleteCustodian.Click += new System.EventHandler(this.btnDeleteCustodian_Click);
            // 
            // custodianerrorProvider
            // 
            this.custodianerrorProvider.ContainerControl = this;
            this.custodianerrorProvider.DataSource = this.custodiandetailbindingSource;
            // 
            // CustodianDetail
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(857, 437);
            this.Controls.Add(this.toolStrip1);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "CustodianDetail";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Custodian Detail";
            ((System.ComponentModel.ISupportInitialize)(this.custodiandetailbindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cmbDepartment.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.departmentbindingSource)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.chkStatus.Properties)).EndInit();
            this.groupBox2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.gridControl1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.custodianassetbindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.custodianassetgridView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemLookUpEdit)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.statusbindingSource)).EndInit();
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.custodianerrorProvider)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtLocation;
        private DevExpress.XtraEditors.LookUpEdit cmbDepartment;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox txtDescription;
        private System.Windows.Forms.TextBox txtLastName;
        private System.Windows.Forms.TextBox txtFirstName;
        private System.Windows.Forms.TextBox txtBadgeNo;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox groupBox2;
        private DevExpress.XtraGrid.GridControl gridControl1;
        private DevExpress.XtraGrid.Views.Grid.GridView custodianassetgridView;
        private System.Windows.Forms.ToolStrip toolStrip1;
        private System.Windows.Forms.ToolStripButton btnCustodianSave;
        private System.Windows.Forms.ToolStripButton btnDeleteCustodian;
        private DevExpress.XtraEditors.CheckEdit chkStatus;
        private System.Windows.Forms.BindingSource custodiandetailbindingSource;
        private System.Windows.Forms.BindingSource departmentbindingSource;
        private System.Windows.Forms.ErrorProvider custodianerrorProvider;
        private System.Windows.Forms.BindingSource custodianassetbindingSource;
        private System.Windows.Forms.BindingSource statusbindingSource;
        private DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit repositoryItemLookUpEdit;
        private DevExpress.XtraGrid.Columns.GridColumn colAssetNumber;
        private DevExpress.XtraGrid.Columns.GridColumn colDateFrom;
        private DevExpress.XtraGrid.Columns.GridColumn colItemName;
        private DevExpress.XtraGrid.Columns.GridColumn colDateTo;
    }
}