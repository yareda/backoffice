using ClearOffice.Inventory.DataAccess;

namespace ClearOffice.Inventory.Views
{
    partial class ItemDetail
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
            System.Windows.Forms.Label itemNoLabel;
            System.Windows.Forms.Label descriptionLabel;
            System.Windows.Forms.Label categoryIdLabel;
            System.Windows.Forms.Label subCategoryIdLabel;
            System.Windows.Forms.Label unitIdLabel;
            System.Windows.Forms.Label remarkLabel;
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ItemDetail));
            this.itemNoTextEdit = new DevExpress.XtraEditors.TextEdit();
            this.itemBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.descriptionMemoEdit = new DevExpress.XtraEditors.MemoEdit();
            this.categoryIdLookUpEdit = new DevExpress.XtraEditors.LookUpEdit();
            this.categoryBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.subCategoryIdLookUpEdit = new DevExpress.XtraEditors.LookUpEdit();
            this.subCategoryBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.unitIdLookUpEdit = new DevExpress.XtraEditors.LookUpEdit();
            this.unitBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.remarkMemoEdit = new DevExpress.XtraEditors.MemoEdit();
            this.imagePictureEdit = new DevExpress.XtraEditors.PictureEdit();
            this.saveCommand = new DevExpress.XtraEditors.SimpleButton();
            this.cancelCommand = new DevExpress.XtraEditors.SimpleButton();
            this.errorProvider1 = new System.Windows.Forms.ErrorProvider(this.components);
            this.addCategoryHyperLinkEdit = new DevExpress.XtraEditors.HyperLinkEdit();
            this.addsubCategoryHyperLinkEdit = new DevExpress.XtraEditors.HyperLinkEdit();
            itemNoLabel = new System.Windows.Forms.Label();
            descriptionLabel = new System.Windows.Forms.Label();
            categoryIdLabel = new System.Windows.Forms.Label();
            subCategoryIdLabel = new System.Windows.Forms.Label();
            unitIdLabel = new System.Windows.Forms.Label();
            remarkLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.itemNoTextEdit.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.itemBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.descriptionMemoEdit.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.categoryIdLookUpEdit.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.categoryBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.subCategoryIdLookUpEdit.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.subCategoryBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.unitIdLookUpEdit.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.unitBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.remarkMemoEdit.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.imagePictureEdit.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.addCategoryHyperLinkEdit.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.addsubCategoryHyperLinkEdit.Properties)).BeginInit();
            this.SuspendLayout();
            // 
            // itemNoLabel
            // 
            itemNoLabel.AutoSize = true;
            itemNoLabel.Location = new System.Drawing.Point(8, 7);
            itemNoLabel.Name = "itemNoLabel";
            itemNoLabel.Size = new System.Drawing.Size(80, 13);
            itemNoLabel.TabIndex = 0;
            itemNoLabel.Text = "Item No/Name:";
            // 
            // descriptionLabel
            // 
            descriptionLabel.AutoSize = true;
            descriptionLabel.Location = new System.Drawing.Point(8, 33);
            descriptionLabel.Name = "descriptionLabel";
            descriptionLabel.Size = new System.Drawing.Size(64, 13);
            descriptionLabel.TabIndex = 2;
            descriptionLabel.Text = "Description:";
            // 
            // categoryIdLabel
            // 
            categoryIdLabel.AutoSize = true;
            categoryIdLabel.Location = new System.Drawing.Point(8, 135);
            categoryIdLabel.Name = "categoryIdLabel";
            categoryIdLabel.Size = new System.Drawing.Size(56, 13);
            categoryIdLabel.TabIndex = 4;
            categoryIdLabel.Text = "Category:";
            // 
            // subCategoryIdLabel
            // 
            subCategoryIdLabel.AutoSize = true;
            subCategoryIdLabel.Location = new System.Drawing.Point(8, 161);
            subCategoryIdLabel.Name = "subCategoryIdLabel";
            subCategoryIdLabel.Size = new System.Drawing.Size(77, 13);
            subCategoryIdLabel.TabIndex = 6;
            subCategoryIdLabel.Text = "Sub Category:";
            // 
            // unitIdLabel
            // 
            unitIdLabel.AutoSize = true;
            unitIdLabel.Location = new System.Drawing.Point(8, 187);
            unitIdLabel.Name = "unitIdLabel";
            unitIdLabel.Size = new System.Drawing.Size(30, 13);
            unitIdLabel.TabIndex = 8;
            unitIdLabel.Text = "Unit:";
            // 
            // remarkLabel
            // 
            remarkLabel.AutoSize = true;
            remarkLabel.Location = new System.Drawing.Point(8, 213);
            remarkLabel.Name = "remarkLabel";
            remarkLabel.Size = new System.Drawing.Size(47, 13);
            remarkLabel.TabIndex = 10;
            remarkLabel.Text = "Remark:";
            // 
            // itemNoTextEdit
            // 
            this.itemNoTextEdit.DataBindings.Add(new System.Windows.Forms.Binding("EditValue", this.itemBindingSource, "ItemNo", true, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged));
            this.itemNoTextEdit.Location = new System.Drawing.Point(90, 4);
            this.itemNoTextEdit.Name = "itemNoTextEdit";
            this.itemNoTextEdit.Size = new System.Drawing.Size(242, 20);
            this.itemNoTextEdit.TabIndex = 1;
            // 
            // itemBindingSource
            // 
            this.itemBindingSource.DataSource = typeof(ClearOffice.Inventory.DataAccess.InventoryItem);
            this.itemBindingSource.CurrentItemChanged += new System.EventHandler(this.itemBindingSource_CurrentItemChanged);
            // 
            // descriptionMemoEdit
            // 
            this.descriptionMemoEdit.DataBindings.Add(new System.Windows.Forms.Binding("EditValue", this.itemBindingSource, "Description", true, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged));
            this.descriptionMemoEdit.Location = new System.Drawing.Point(90, 30);
            this.descriptionMemoEdit.Name = "descriptionMemoEdit";
            this.descriptionMemoEdit.Size = new System.Drawing.Size(242, 96);
            this.descriptionMemoEdit.TabIndex = 3;
            // 
            // categoryIdLookUpEdit
            // 
            this.categoryIdLookUpEdit.DataBindings.Add(new System.Windows.Forms.Binding("EditValue", this.itemBindingSource, "CategoryId", true));
            this.categoryIdLookUpEdit.Location = new System.Drawing.Point(90, 132);
            this.categoryIdLookUpEdit.Name = "categoryIdLookUpEdit";
            this.categoryIdLookUpEdit.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.categoryIdLookUpEdit.Properties.Columns.AddRange(new DevExpress.XtraEditors.Controls.LookUpColumnInfo[] {
            new DevExpress.XtraEditors.Controls.LookUpColumnInfo("Name", "Category", 100, DevExpress.Utils.FormatType.None, "", true, DevExpress.Utils.HorzAlignment.Near)});
            this.categoryIdLookUpEdit.Properties.DataSource = this.categoryBindingSource;
            this.categoryIdLookUpEdit.Properties.DisplayMember = "Name";
            this.categoryIdLookUpEdit.Properties.NullText = "[Select Category]";
            this.categoryIdLookUpEdit.Properties.ValueMember = "CategoryId";
            this.categoryIdLookUpEdit.Size = new System.Drawing.Size(205, 20);
            this.categoryIdLookUpEdit.TabIndex = 5;
            this.categoryIdLookUpEdit.EditValueChanged += new System.EventHandler(this.categoryIdLookUpEdit_EditValueChanged);
            // 
            // categoryBindingSource
            // 
            this.categoryBindingSource.DataSource = typeof(ClearOffice.Inventory.DataAccess.Category);
            // 
            // subCategoryIdLookUpEdit
            // 
            this.subCategoryIdLookUpEdit.DataBindings.Add(new System.Windows.Forms.Binding("EditValue", this.itemBindingSource, "SubCategoryId", true));
            this.subCategoryIdLookUpEdit.Location = new System.Drawing.Point(90, 158);
            this.subCategoryIdLookUpEdit.Name = "subCategoryIdLookUpEdit";
            this.subCategoryIdLookUpEdit.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.subCategoryIdLookUpEdit.Properties.Columns.AddRange(new DevExpress.XtraEditors.Controls.LookUpColumnInfo[] {
            new DevExpress.XtraEditors.Controls.LookUpColumnInfo("Name", "Sub Category", 100, DevExpress.Utils.FormatType.None, "", true, DevExpress.Utils.HorzAlignment.Near)});
            this.subCategoryIdLookUpEdit.Properties.DataSource = this.subCategoryBindingSource;
            this.subCategoryIdLookUpEdit.Properties.DisplayMember = "Name";
            this.subCategoryIdLookUpEdit.Properties.NullText = "[Select Sub Category]";
            this.subCategoryIdLookUpEdit.Properties.ValueMember = "SubCategoryId";
            this.subCategoryIdLookUpEdit.Size = new System.Drawing.Size(205, 20);
            this.subCategoryIdLookUpEdit.TabIndex = 7;
            // 
            // subCategoryBindingSource
            // 
            this.subCategoryBindingSource.DataSource = typeof(ClearOffice.Inventory.DataAccess.SubCategory);
            // 
            // unitIdLookUpEdit
            // 
            this.unitIdLookUpEdit.DataBindings.Add(new System.Windows.Forms.Binding("EditValue", this.itemBindingSource, "UnitId", true));
            this.unitIdLookUpEdit.Location = new System.Drawing.Point(90, 184);
            this.unitIdLookUpEdit.Name = "unitIdLookUpEdit";
            this.unitIdLookUpEdit.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.unitIdLookUpEdit.Properties.Columns.AddRange(new DevExpress.XtraEditors.Controls.LookUpColumnInfo[] {
            new DevExpress.XtraEditors.Controls.LookUpColumnInfo("Name", "Unit Name", 100, DevExpress.Utils.FormatType.None, "", true, DevExpress.Utils.HorzAlignment.Near)});
            this.unitIdLookUpEdit.Properties.DataSource = this.unitBindingSource;
            this.unitIdLookUpEdit.Properties.DisplayMember = "Name";
            this.unitIdLookUpEdit.Properties.NullText = "[Select Measurement Unit]";
            this.unitIdLookUpEdit.Properties.ValueMember = "UnitId";
            this.unitIdLookUpEdit.Size = new System.Drawing.Size(242, 20);
            this.unitIdLookUpEdit.TabIndex = 9;
            // 
            // unitBindingSource
            // 
            this.unitBindingSource.DataSource = typeof(ClearOffice.Inventory.DataAccess.MeasurementUnit);
            // 
            // remarkMemoEdit
            // 
            this.remarkMemoEdit.DataBindings.Add(new System.Windows.Forms.Binding("EditValue", this.itemBindingSource, "Remark", true));
            this.remarkMemoEdit.Location = new System.Drawing.Point(90, 210);
            this.remarkMemoEdit.Name = "remarkMemoEdit";
            this.remarkMemoEdit.Size = new System.Drawing.Size(431, 96);
            this.remarkMemoEdit.TabIndex = 11;
            // 
            // imagePictureEdit
            // 
            this.imagePictureEdit.DataBindings.Add(new System.Windows.Forms.Binding("EditValue", this.itemBindingSource, "Image", true));
            this.imagePictureEdit.Location = new System.Drawing.Point(338, 5);
            this.imagePictureEdit.Name = "imagePictureEdit";
            this.imagePictureEdit.Size = new System.Drawing.Size(183, 173);
            this.imagePictureEdit.TabIndex = 13;
            // 
            // saveCommand
            // 
            this.saveCommand.Location = new System.Drawing.Point(179, 314);
            this.saveCommand.Name = "saveCommand";
            this.saveCommand.Size = new System.Drawing.Size(75, 23);
            this.saveCommand.TabIndex = 14;
            this.saveCommand.Text = "Save";
            this.saveCommand.Click += new System.EventHandler(this.saveCommand_Click);
            // 
            // cancelCommand
            // 
            this.cancelCommand.Location = new System.Drawing.Point(272, 314);
            this.cancelCommand.Name = "cancelCommand";
            this.cancelCommand.Size = new System.Drawing.Size(75, 23);
            this.cancelCommand.TabIndex = 15;
            this.cancelCommand.Text = "Cancel";
            this.cancelCommand.Click += new System.EventHandler(this.cancelCommand_Click);
            // 
            // errorProvider1
            // 
            this.errorProvider1.ContainerControl = this;
            this.errorProvider1.DataSource = this.itemBindingSource;
            // 
            // addCategoryHyperLinkEdit
            // 
            this.addCategoryHyperLinkEdit.EditValue = "";
            this.addCategoryHyperLinkEdit.Location = new System.Drawing.Point(298, 132);
            this.addCategoryHyperLinkEdit.Margin = new System.Windows.Forms.Padding(0);
            this.addCategoryHyperLinkEdit.Name = "addCategoryHyperLinkEdit";
            this.addCategoryHyperLinkEdit.Properties.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.NoBorder;
            this.addCategoryHyperLinkEdit.Properties.Image = ((System.Drawing.Image)(resources.GetObject("addNationalityHyperLinkEdit.Properties.Image")));
            this.addCategoryHyperLinkEdit.Size = new System.Drawing.Size(34, 22);
            this.addCategoryHyperLinkEdit.TabIndex = 138;
            this.addCategoryHyperLinkEdit.ToolTip = "Add New Category";
            this.addCategoryHyperLinkEdit.ToolTipTitle = "Add";
            this.addCategoryHyperLinkEdit.Click += new System.EventHandler(this.addCategoryHyperLinkEdit_Click);
            // 
            // addsubCategoryHyperLinkEdit
            // 
            this.addsubCategoryHyperLinkEdit.EditValue = "";
            this.addsubCategoryHyperLinkEdit.Location = new System.Drawing.Point(298, 158);
            this.addsubCategoryHyperLinkEdit.Margin = new System.Windows.Forms.Padding(0);
            this.addsubCategoryHyperLinkEdit.Name = "addsubCategoryHyperLinkEdit";
            this.addsubCategoryHyperLinkEdit.Properties.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.NoBorder;
            this.addsubCategoryHyperLinkEdit.Properties.Image = ((System.Drawing.Image)(resources.GetObject("hyperLinkEdit1.Properties.Image")));
            this.addsubCategoryHyperLinkEdit.Size = new System.Drawing.Size(34, 22);
            this.addsubCategoryHyperLinkEdit.TabIndex = 139;
            this.addsubCategoryHyperLinkEdit.ToolTip = "Add New Sub Category";
            this.addsubCategoryHyperLinkEdit.ToolTipTitle = "Add";
            this.addsubCategoryHyperLinkEdit.Click += new System.EventHandler(this.addsubCategoryHyperLinkEdit_Click);
            // 
            // ItemDetail
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(526, 346);
            this.Controls.Add(this.addsubCategoryHyperLinkEdit);
            this.Controls.Add(this.addCategoryHyperLinkEdit);
            this.Controls.Add(this.cancelCommand);
            this.Controls.Add(this.saveCommand);
            this.Controls.Add(this.imagePictureEdit);
            this.Controls.Add(remarkLabel);
            this.Controls.Add(this.remarkMemoEdit);
            this.Controls.Add(unitIdLabel);
            this.Controls.Add(this.unitIdLookUpEdit);
            this.Controls.Add(subCategoryIdLabel);
            this.Controls.Add(this.subCategoryIdLookUpEdit);
            this.Controls.Add(categoryIdLabel);
            this.Controls.Add(this.categoryIdLookUpEdit);
            this.Controls.Add(descriptionLabel);
            this.Controls.Add(this.descriptionMemoEdit);
            this.Controls.Add(itemNoLabel);
            this.Controls.Add(this.itemNoTextEdit);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "ItemDetail";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Inventory Item Detail";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.ItemDetail_FormClosing);
            ((System.ComponentModel.ISupportInitialize)(this.itemNoTextEdit.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.itemBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.descriptionMemoEdit.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.categoryIdLookUpEdit.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.categoryBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.subCategoryIdLookUpEdit.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.subCategoryBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.unitIdLookUpEdit.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.unitBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.remarkMemoEdit.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.imagePictureEdit.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.addCategoryHyperLinkEdit.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.addsubCategoryHyperLinkEdit.Properties)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.BindingSource itemBindingSource;
        private DevExpress.XtraEditors.TextEdit itemNoTextEdit;
        private DevExpress.XtraEditors.MemoEdit descriptionMemoEdit;
        private DevExpress.XtraEditors.LookUpEdit categoryIdLookUpEdit;
        private DevExpress.XtraEditors.LookUpEdit subCategoryIdLookUpEdit;
        private DevExpress.XtraEditors.LookUpEdit unitIdLookUpEdit;
        private DevExpress.XtraEditors.MemoEdit remarkMemoEdit;
        private DevExpress.XtraEditors.PictureEdit imagePictureEdit;
        private DevExpress.XtraEditors.SimpleButton saveCommand;
        private DevExpress.XtraEditors.SimpleButton cancelCommand;
        private System.Windows.Forms.BindingSource categoryBindingSource;
        private System.Windows.Forms.BindingSource subCategoryBindingSource;
        private System.Windows.Forms.BindingSource unitBindingSource;
        private System.Windows.Forms.ErrorProvider errorProvider1;
        private DevExpress.XtraEditors.HyperLinkEdit addCategoryHyperLinkEdit;
        private DevExpress.XtraEditors.HyperLinkEdit addsubCategoryHyperLinkEdit;
    }
}