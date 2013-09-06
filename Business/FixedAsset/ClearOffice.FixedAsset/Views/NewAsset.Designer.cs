namespace ClearOffice.FixedAsset.Views
{
    partial class NewAsset
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
            System.Windows.Forms.Label assetNumberLabel;
            System.Windows.Forms.Label categoryLabel;
            System.Windows.Forms.Label groupIdLabel;
            System.Windows.Forms.Label costCenterIdLabel;
            System.Windows.Forms.Label depreciationMethodLabel;
            System.Windows.Forms.Label locationIdLabel;
            System.Windows.Forms.Label salvageValueLabel;
            System.Windows.Forms.Label assetValueLabel;
            System.Windows.Forms.Label purchaseDateLabel;
            System.Windows.Forms.Label usefulLifeLabel;
            System.Windows.Forms.Label descriptionLabel;
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.btnSave = new System.Windows.Forms.ToolStripButton();
            this.btnSaveAndNew = new System.Windows.Forms.ToolStripButton();
            this.panelControl1 = new DevExpress.XtraEditors.PanelControl();
            this.descriptionTextBox = new System.Windows.Forms.TextBox();
            this.newAssetBindingSource = new System.Windows.Forms.BindingSource();
            this.label1 = new System.Windows.Forms.Label();
            this.usefulLifeTextBox = new System.Windows.Forms.TextBox();
            this.purchaseDateDateEdit = new DevExpress.XtraEditors.DateEdit();
            this.assetValueTextBox = new System.Windows.Forms.TextBox();
            this.salvageValueTextBox = new System.Windows.Forms.TextBox();
            this.locationIdLookUpEdit = new DevExpress.XtraEditors.LookUpEdit();
            this.locationBindingSource = new System.Windows.Forms.BindingSource();
            this.depreciationMethodLookUpEdit = new DevExpress.XtraEditors.LookUpEdit();
            this.depreciationMethodBindingSource = new System.Windows.Forms.BindingSource();
            this.costCenterIdLookUpEdit = new DevExpress.XtraEditors.LookUpEdit();
            this.costCenterBindingSource = new System.Windows.Forms.BindingSource();
            this.groupIdLookUpEdit = new DevExpress.XtraEditors.LookUpEdit();
            this.groupBindingSource = new System.Windows.Forms.BindingSource();
            this.categoryLookUpEdit = new DevExpress.XtraEditors.LookUpEdit();
            this.catagoryBindingSource = new System.Windows.Forms.BindingSource();
            this.assetNumberTextBox = new System.Windows.Forms.TextBox();
            this.assetErrorProvider = new System.Windows.Forms.ErrorProvider();
            assetNumberLabel = new System.Windows.Forms.Label();
            categoryLabel = new System.Windows.Forms.Label();
            groupIdLabel = new System.Windows.Forms.Label();
            costCenterIdLabel = new System.Windows.Forms.Label();
            depreciationMethodLabel = new System.Windows.Forms.Label();
            locationIdLabel = new System.Windows.Forms.Label();
            salvageValueLabel = new System.Windows.Forms.Label();
            assetValueLabel = new System.Windows.Forms.Label();
            purchaseDateLabel = new System.Windows.Forms.Label();
            usefulLifeLabel = new System.Windows.Forms.Label();
            descriptionLabel = new System.Windows.Forms.Label();
            this.toolStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.panelControl1)).BeginInit();
            this.panelControl1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.newAssetBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.purchaseDateDateEdit.Properties.VistaTimeProperties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.purchaseDateDateEdit.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.locationIdLookUpEdit.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.locationBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.depreciationMethodLookUpEdit.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.depreciationMethodBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.costCenterIdLookUpEdit.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.costCenterBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.groupIdLookUpEdit.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.groupBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.categoryLookUpEdit.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.catagoryBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.assetErrorProvider)).BeginInit();
            this.SuspendLayout();
            // 
            // assetNumberLabel
            // 
            assetNumberLabel.AutoSize = true;
            assetNumberLabel.Location = new System.Drawing.Point(5, 10);
            assetNumberLabel.Name = "assetNumberLabel";
            assetNumberLabel.Size = new System.Drawing.Size(49, 13);
            assetNumberLabel.TabIndex = 0;
            assetNumberLabel.Text = "Asset #:";
            // 
            // categoryLabel
            // 
            categoryLabel.AutoSize = true;
            categoryLabel.Location = new System.Drawing.Point(5, 37);
            categoryLabel.Name = "categoryLabel";
            categoryLabel.Size = new System.Drawing.Size(56, 13);
            categoryLabel.TabIndex = 2;
            categoryLabel.Text = "Category:";
            // 
            // groupIdLabel
            // 
            groupIdLabel.AutoSize = true;
            groupIdLabel.Location = new System.Drawing.Point(5, 63);
            groupIdLabel.Name = "groupIdLabel";
            groupIdLabel.Size = new System.Drawing.Size(40, 13);
            groupIdLabel.TabIndex = 4;
            groupIdLabel.Text = "Group:";
            // 
            // costCenterIdLabel
            // 
            costCenterIdLabel.AutoSize = true;
            costCenterIdLabel.Location = new System.Drawing.Point(5, 89);
            costCenterIdLabel.Name = "costCenterIdLabel";
            costCenterIdLabel.Size = new System.Drawing.Size(69, 13);
            costCenterIdLabel.TabIndex = 6;
            costCenterIdLabel.Text = "Cost Center:";
            // 
            // depreciationMethodLabel
            // 
            depreciationMethodLabel.AutoSize = true;
            depreciationMethodLabel.Location = new System.Drawing.Point(5, 142);
            depreciationMethodLabel.Name = "depreciationMethodLabel";
            depreciationMethodLabel.Size = new System.Drawing.Size(110, 13);
            depreciationMethodLabel.TabIndex = 10;
            depreciationMethodLabel.Text = "Depreciation Method:";
            // 
            // locationIdLabel
            // 
            locationIdLabel.AutoSize = true;
            locationIdLabel.Location = new System.Drawing.Point(5, 115);
            locationIdLabel.Name = "locationIdLabel";
            locationIdLabel.Size = new System.Drawing.Size(51, 13);
            locationIdLabel.TabIndex = 11;
            locationIdLabel.Text = "Location:";
            // 
            // salvageValueLabel
            // 
            salvageValueLabel.AutoSize = true;
            salvageValueLabel.Location = new System.Drawing.Point(5, 222);
            salvageValueLabel.Name = "salvageValueLabel";
            salvageValueLabel.Size = new System.Drawing.Size(78, 13);
            salvageValueLabel.TabIndex = 14;
            salvageValueLabel.Text = "Salvage Value:";
            // 
            // assetValueLabel
            // 
            assetValueLabel.AutoSize = true;
            assetValueLabel.Location = new System.Drawing.Point(5, 168);
            assetValueLabel.Name = "assetValueLabel";
            assetValueLabel.Size = new System.Drawing.Size(67, 13);
            assetValueLabel.TabIndex = 16;
            assetValueLabel.Text = "Asset Value:";
            // 
            // purchaseDateLabel
            // 
            purchaseDateLabel.AutoSize = true;
            purchaseDateLabel.Location = new System.Drawing.Point(5, 249);
            purchaseDateLabel.Name = "purchaseDateLabel";
            purchaseDateLabel.Size = new System.Drawing.Size(81, 13);
            purchaseDateLabel.TabIndex = 17;
            purchaseDateLabel.Text = "Purchase Date:";
            // 
            // usefulLifeLabel
            // 
            usefulLifeLabel.AutoSize = true;
            usefulLifeLabel.Location = new System.Drawing.Point(5, 195);
            usefulLifeLabel.Name = "usefulLifeLabel";
            usefulLifeLabel.Size = new System.Drawing.Size(61, 13);
            usefulLifeLabel.TabIndex = 20;
            usefulLifeLabel.Text = "Useful Life:";
            // 
            // descriptionLabel
            // 
            descriptionLabel.AutoSize = true;
            descriptionLabel.Location = new System.Drawing.Point(5, 275);
            descriptionLabel.Name = "descriptionLabel";
            descriptionLabel.Size = new System.Drawing.Size(64, 13);
            descriptionLabel.TabIndex = 21;
            descriptionLabel.Text = "Description:";
            // 
            // toolStrip1
            // 
            this.toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.btnSave,
            this.btnSaveAndNew});
            this.toolStrip1.Location = new System.Drawing.Point(0, 0);
            this.toolStrip1.Name = "toolStrip1";
            this.toolStrip1.Size = new System.Drawing.Size(561, 25);
            this.toolStrip1.TabIndex = 0;
            this.toolStrip1.Text = "toolStrip1";
            // 
            // btnSave
            // 
            this.btnSave.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.btnSave.Image = global::ClearOffice.FixedAsset.Properties.Resources.Save_16x16;
            this.btnSave.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(23, 22);
            this.btnSave.Text = "&Save";
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // btnSaveAndNew
            // 
            this.btnSaveAndNew.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.btnSaveAndNew.Image = global::ClearOffice.FixedAsset.Properties.Resources.save_as_16x16;
            this.btnSaveAndNew.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnSaveAndNew.Name = "btnSaveAndNew";
            this.btnSaveAndNew.Size = new System.Drawing.Size(23, 22);
            this.btnSaveAndNew.Text = "toolStripButton1";
            this.btnSaveAndNew.ToolTipText = "Save & New";
            this.btnSaveAndNew.Click += new System.EventHandler(this.btnSaveAndNew_Click);
            // 
            // panelControl1
            // 
            this.panelControl1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panelControl1.Controls.Add(descriptionLabel);
            this.panelControl1.Controls.Add(this.descriptionTextBox);
            this.panelControl1.Controls.Add(this.label1);
            this.panelControl1.Controls.Add(usefulLifeLabel);
            this.panelControl1.Controls.Add(this.usefulLifeTextBox);
            this.panelControl1.Controls.Add(purchaseDateLabel);
            this.panelControl1.Controls.Add(this.purchaseDateDateEdit);
            this.panelControl1.Controls.Add(assetValueLabel);
            this.panelControl1.Controls.Add(this.assetValueTextBox);
            this.panelControl1.Controls.Add(salvageValueLabel);
            this.panelControl1.Controls.Add(this.salvageValueTextBox);
            this.panelControl1.Controls.Add(locationIdLabel);
            this.panelControl1.Controls.Add(this.locationIdLookUpEdit);
            this.panelControl1.Controls.Add(depreciationMethodLabel);
            this.panelControl1.Controls.Add(this.depreciationMethodLookUpEdit);
            this.panelControl1.Controls.Add(costCenterIdLabel);
            this.panelControl1.Controls.Add(this.costCenterIdLookUpEdit);
            this.panelControl1.Controls.Add(groupIdLabel);
            this.panelControl1.Controls.Add(this.groupIdLookUpEdit);
            this.panelControl1.Controls.Add(categoryLabel);
            this.panelControl1.Controls.Add(this.categoryLookUpEdit);
            this.panelControl1.Controls.Add(assetNumberLabel);
            this.panelControl1.Controls.Add(this.assetNumberTextBox);
            this.panelControl1.Location = new System.Drawing.Point(12, 38);
            this.panelControl1.Name = "panelControl1";
            this.panelControl1.Size = new System.Drawing.Size(537, 338);
            this.panelControl1.TabIndex = 1;
            // 
            // descriptionTextBox
            // 
            this.descriptionTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.newAssetBindingSource, "Description", true));
            this.descriptionTextBox.Location = new System.Drawing.Point(129, 272);
            this.descriptionTextBox.Multiline = true;
            this.descriptionTextBox.Name = "descriptionTextBox";
            this.descriptionTextBox.Size = new System.Drawing.Size(327, 49);
            this.descriptionTextBox.TabIndex = 22;
            // 
            // newAssetBindingSource
            // 
            this.newAssetBindingSource.DataSource = typeof(ClearOffice.FixedAsset.DataAccess.Asset);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(463, 199);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(39, 13);
            this.label1.TabIndex = 21;
            this.label1.Text = "Years";
            // 
            // usefulLifeTextBox
            // 
            this.usefulLifeTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.newAssetBindingSource, "UsefulLife", true));
            this.usefulLifeTextBox.Location = new System.Drawing.Point(129, 192);
            this.usefulLifeTextBox.Name = "usefulLifeTextBox";
            this.usefulLifeTextBox.Size = new System.Drawing.Size(327, 21);
            this.usefulLifeTextBox.TabIndex = 7;
            // 
            // purchaseDateDateEdit
            // 
            this.purchaseDateDateEdit.DataBindings.Add(new System.Windows.Forms.Binding("EditValue", this.newAssetBindingSource, "PurchaseDate", true));
            this.purchaseDateDateEdit.EditValue = null;
            this.purchaseDateDateEdit.Location = new System.Drawing.Point(129, 246);
            this.purchaseDateDateEdit.Name = "purchaseDateDateEdit";
            this.purchaseDateDateEdit.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.purchaseDateDateEdit.Properties.VistaTimeProperties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton()});
            this.purchaseDateDateEdit.Size = new System.Drawing.Size(327, 20);
            this.purchaseDateDateEdit.TabIndex = 9;
            // 
            // assetValueTextBox
            // 
            this.assetValueTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.newAssetBindingSource, "AssetValue", true));
            this.assetValueTextBox.Location = new System.Drawing.Point(129, 165);
            this.assetValueTextBox.Name = "assetValueTextBox";
            this.assetValueTextBox.Size = new System.Drawing.Size(327, 21);
            this.assetValueTextBox.TabIndex = 6;
            this.assetValueTextBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // salvageValueTextBox
            // 
            this.salvageValueTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.newAssetBindingSource, "SalvageValue", true));
            this.salvageValueTextBox.Location = new System.Drawing.Point(129, 219);
            this.salvageValueTextBox.Name = "salvageValueTextBox";
            this.salvageValueTextBox.Size = new System.Drawing.Size(327, 21);
            this.salvageValueTextBox.TabIndex = 8;
            this.salvageValueTextBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // locationIdLookUpEdit
            // 
            this.locationIdLookUpEdit.DataBindings.Add(new System.Windows.Forms.Binding("EditValue", this.newAssetBindingSource, "LocationId", true));
            this.locationIdLookUpEdit.Location = new System.Drawing.Point(129, 112);
            this.locationIdLookUpEdit.Name = "locationIdLookUpEdit";
            this.locationIdLookUpEdit.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.locationIdLookUpEdit.Properties.Columns.AddRange(new DevExpress.XtraEditors.Controls.LookUpColumnInfo[] {
            new DevExpress.XtraEditors.Controls.LookUpColumnInfo("ItemName", "Location", 62, DevExpress.Utils.FormatType.None, "", true, DevExpress.Utils.HorzAlignment.Near)});
            this.locationIdLookUpEdit.Properties.DataSource = this.locationBindingSource;
            this.locationIdLookUpEdit.Properties.DisplayMember = "ItemName";
            this.locationIdLookUpEdit.Properties.NullText = "[Select Location]";
            this.locationIdLookUpEdit.Properties.ValueMember = "LookupItemId";
            this.locationIdLookUpEdit.Size = new System.Drawing.Size(327, 20);
            this.locationIdLookUpEdit.TabIndex = 4;
            // 
            // locationBindingSource
            // 
            this.locationBindingSource.DataSource = typeof(ClearOffice.FixedAsset.DataAccess.LookupItem);
            // 
            // depreciationMethodLookUpEdit
            // 
            this.depreciationMethodLookUpEdit.DataBindings.Add(new System.Windows.Forms.Binding("EditValue", this.newAssetBindingSource, "DepreciationMethod", true));
            this.depreciationMethodLookUpEdit.Location = new System.Drawing.Point(129, 139);
            this.depreciationMethodLookUpEdit.Name = "depreciationMethodLookUpEdit";
            this.depreciationMethodLookUpEdit.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.depreciationMethodLookUpEdit.Properties.Columns.AddRange(new DevExpress.XtraEditors.Controls.LookUpColumnInfo[] {
            new DevExpress.XtraEditors.Controls.LookUpColumnInfo("ItemName", "Depreciation Method", 62, DevExpress.Utils.FormatType.None, "", true, DevExpress.Utils.HorzAlignment.Near)});
            this.depreciationMethodLookUpEdit.Properties.DataSource = this.depreciationMethodBindingSource;
            this.depreciationMethodLookUpEdit.Properties.DisplayMember = "ItemName";
            this.depreciationMethodLookUpEdit.Properties.NullText = "[Select Depreciation Method]";
            this.depreciationMethodLookUpEdit.Properties.ValueMember = "LookupItemId";
            this.depreciationMethodLookUpEdit.Size = new System.Drawing.Size(327, 20);
            this.depreciationMethodLookUpEdit.TabIndex = 5;
            // 
            // depreciationMethodBindingSource
            // 
            this.depreciationMethodBindingSource.DataSource = typeof(ClearOffice.FixedAsset.DataAccess.LookupItem);
            // 
            // costCenterIdLookUpEdit
            // 
            this.costCenterIdLookUpEdit.DataBindings.Add(new System.Windows.Forms.Binding("EditValue", this.newAssetBindingSource, "CostCenterId", true));
            this.costCenterIdLookUpEdit.Location = new System.Drawing.Point(129, 86);
            this.costCenterIdLookUpEdit.Name = "costCenterIdLookUpEdit";
            this.costCenterIdLookUpEdit.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.costCenterIdLookUpEdit.Properties.Columns.AddRange(new DevExpress.XtraEditors.Controls.LookUpColumnInfo[] {
            new DevExpress.XtraEditors.Controls.LookUpColumnInfo("ItemName", "Cost Center", 62, DevExpress.Utils.FormatType.None, "", true, DevExpress.Utils.HorzAlignment.Near)});
            this.costCenterIdLookUpEdit.Properties.DataSource = this.costCenterBindingSource;
            this.costCenterIdLookUpEdit.Properties.DisplayMember = "ItemName";
            this.costCenterIdLookUpEdit.Properties.NullText = "[Select Cost Center]";
            this.costCenterIdLookUpEdit.Properties.ValueMember = "LookupItemId";
            this.costCenterIdLookUpEdit.Size = new System.Drawing.Size(327, 20);
            this.costCenterIdLookUpEdit.TabIndex = 3;
            // 
            // costCenterBindingSource
            // 
            this.costCenterBindingSource.DataSource = typeof(ClearOffice.FixedAsset.DataAccess.LookupItem);
            // 
            // groupIdLookUpEdit
            // 
            this.groupIdLookUpEdit.DataBindings.Add(new System.Windows.Forms.Binding("EditValue", this.newAssetBindingSource, "GroupId", true));
            this.groupIdLookUpEdit.Location = new System.Drawing.Point(129, 60);
            this.groupIdLookUpEdit.Name = "groupIdLookUpEdit";
            this.groupIdLookUpEdit.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.groupIdLookUpEdit.Properties.Columns.AddRange(new DevExpress.XtraEditors.Controls.LookUpColumnInfo[] {
            new DevExpress.XtraEditors.Controls.LookUpColumnInfo("ItemName", "Group", 62, DevExpress.Utils.FormatType.None, "", true, DevExpress.Utils.HorzAlignment.Near)});
            this.groupIdLookUpEdit.Properties.DataSource = this.groupBindingSource;
            this.groupIdLookUpEdit.Properties.DisplayMember = "ItemName";
            this.groupIdLookUpEdit.Properties.NullText = "[Select Group]";
            this.groupIdLookUpEdit.Properties.ValueMember = "LookupItemId";
            this.groupIdLookUpEdit.Size = new System.Drawing.Size(327, 20);
            this.groupIdLookUpEdit.TabIndex = 2;
            // 
            // groupBindingSource
            // 
            this.groupBindingSource.DataSource = typeof(ClearOffice.FixedAsset.DataAccess.LookupItem);
            // 
            // categoryLookUpEdit
            // 
            this.categoryLookUpEdit.DataBindings.Add(new System.Windows.Forms.Binding("EditValue", this.newAssetBindingSource, "Category", true));
            this.categoryLookUpEdit.Location = new System.Drawing.Point(129, 34);
            this.categoryLookUpEdit.Name = "categoryLookUpEdit";
            this.categoryLookUpEdit.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.categoryLookUpEdit.Properties.Columns.AddRange(new DevExpress.XtraEditors.Controls.LookUpColumnInfo[] {
            new DevExpress.XtraEditors.Controls.LookUpColumnInfo("CategoryName", "Category ", 85, DevExpress.Utils.FormatType.None, "", true, DevExpress.Utils.HorzAlignment.Near),
            new DevExpress.XtraEditors.Controls.LookUpColumnInfo("DepreciationRate", "Rate", 96, DevExpress.Utils.FormatType.None, "", true, DevExpress.Utils.HorzAlignment.Near)});
            this.categoryLookUpEdit.Properties.DataSource = this.catagoryBindingSource;
            this.categoryLookUpEdit.Properties.DisplayMember = "CategoryName";
            this.categoryLookUpEdit.Properties.NullText = "[Select Category]";
            this.categoryLookUpEdit.Properties.ValueMember = "CategoryId";
            this.categoryLookUpEdit.Size = new System.Drawing.Size(327, 20);
            this.categoryLookUpEdit.TabIndex = 1;
            // 
            // catagoryBindingSource
            // 
            this.catagoryBindingSource.DataSource = typeof(ClearOffice.FixedAsset.DataAccess.AssetCategory);
            // 
            // assetNumberTextBox
            // 
            this.assetNumberTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.newAssetBindingSource, "AssetNumber", true));
            this.assetNumberTextBox.Location = new System.Drawing.Point(129, 7);
            this.assetNumberTextBox.Name = "assetNumberTextBox";
            this.assetNumberTextBox.Size = new System.Drawing.Size(327, 21);
            this.assetNumberTextBox.TabIndex = 0;
            // 
            // assetErrorProvider
            // 
            this.assetErrorProvider.ContainerControl = this;
            // 
            // NewAsset
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(561, 388);
            this.Controls.Add(this.panelControl1);
            this.Controls.Add(this.toolStrip1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "NewAsset";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "New Asset";
            this.Click += new System.EventHandler(this.btnSave_Click);
            this.DoubleClick += new System.EventHandler(this.btnSaveAndNew_Click);
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.panelControl1)).EndInit();
            this.panelControl1.ResumeLayout(false);
            this.panelControl1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.newAssetBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.purchaseDateDateEdit.Properties.VistaTimeProperties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.purchaseDateDateEdit.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.locationIdLookUpEdit.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.locationBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.depreciationMethodLookUpEdit.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.depreciationMethodBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.costCenterIdLookUpEdit.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.costCenterBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.groupIdLookUpEdit.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.groupBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.categoryLookUpEdit.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.catagoryBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.assetErrorProvider)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ToolStrip toolStrip1;
        private System.Windows.Forms.ToolStripButton btnSave;
        private System.Windows.Forms.BindingSource newAssetBindingSource;
        private DevExpress.XtraEditors.PanelControl panelControl1;
        private System.Windows.Forms.TextBox assetNumberTextBox;
        private DevExpress.XtraEditors.LookUpEdit groupIdLookUpEdit;
        private DevExpress.XtraEditors.LookUpEdit categoryLookUpEdit;
        private DevExpress.XtraEditors.LookUpEdit locationIdLookUpEdit;
        private DevExpress.XtraEditors.LookUpEdit depreciationMethodLookUpEdit;
        private DevExpress.XtraEditors.LookUpEdit costCenterIdLookUpEdit;
        private System.Windows.Forms.BindingSource catagoryBindingSource;
        private System.Windows.Forms.BindingSource groupBindingSource;
        private System.Windows.Forms.BindingSource locationBindingSource;
        private System.Windows.Forms.BindingSource depreciationMethodBindingSource;
        private System.Windows.Forms.BindingSource costCenterBindingSource;
        private System.Windows.Forms.ErrorProvider assetErrorProvider;
        private System.Windows.Forms.ToolStripButton btnSaveAndNew;
        private DevExpress.XtraEditors.DateEdit purchaseDateDateEdit;
        private System.Windows.Forms.TextBox assetValueTextBox;
        private System.Windows.Forms.TextBox salvageValueTextBox;
        private System.Windows.Forms.TextBox usefulLifeTextBox;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox descriptionTextBox;
    }
}