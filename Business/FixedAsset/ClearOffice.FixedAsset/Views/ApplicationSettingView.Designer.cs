namespace ClearOffice.FixedAsset.Views
{
    partial class ApplicationSettingView
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
            System.Windows.Forms.Label defaultMethodLabel;
            this.errorProvider1 = new System.Windows.Forms.ErrorProvider();
            this.trackBarControl1 = new DevExpress.XtraEditors.TrackBarControl();
            this.btnSetSave = new DevExpress.XtraEditors.SimpleButton();
            this.btnchange = new DevExpress.XtraEditors.SimpleButton();
            this.settingbindingSource = new System.Windows.Forms.BindingSource();
            this.depreciationbindingSource = new System.Windows.Forms.BindingSource();
            this.defaultMethodLookUpEdit = new DevExpress.XtraEditors.LookUpEdit();
            this.dateEdit2 = new DevExpress.XtraEditors.DateEdit();
            this.dateEdit1 = new DevExpress.XtraEditors.DateEdit();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            defaultMethodLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.trackBarControl1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.trackBarControl1.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.settingbindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.depreciationbindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.defaultMethodLookUpEdit.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dateEdit2.Properties.VistaTimeProperties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dateEdit2.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dateEdit1.Properties.VistaTimeProperties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dateEdit1.Properties)).BeginInit();
            this.SuspendLayout();
            // 
            // errorProvider1
            // 
            this.errorProvider1.ContainerControl = this;
            // 
            // trackBarControl1
            // 
            this.trackBarControl1.EditValue = null;
            this.trackBarControl1.Location = new System.Drawing.Point(467, 185);
            this.trackBarControl1.Name = "trackBarControl1";
            this.trackBarControl1.Size = new System.Drawing.Size(104, 45);
            this.trackBarControl1.TabIndex = 2;
            // 
            // btnSetSave
            // 
            this.btnSetSave.Enabled = false;
            this.btnSetSave.Location = new System.Drawing.Point(189, 94);
            this.btnSetSave.Name = "btnSetSave";
            this.btnSetSave.Size = new System.Drawing.Size(75, 23);
            this.btnSetSave.TabIndex = 16;
            this.btnSetSave.Text = "Save";
            this.btnSetSave.Click += new System.EventHandler(this.btnSetSave_Click);
            // 
            // btnchange
            // 
            this.btnchange.Location = new System.Drawing.Point(285, 94);
            this.btnchange.Name = "btnchange";
            this.btnchange.Size = new System.Drawing.Size(101, 23);
            this.btnchange.TabIndex = 17;
            this.btnchange.Text = "Change Setting";
            this.btnchange.Click += new System.EventHandler(this.btnchange_Click);
            // 
            // settingbindingSource
            // 
            this.settingbindingSource.DataSource = typeof(ClearOffice.FixedAsset.DataAccess.ApplicationSetting);
            // 
            // depreciationbindingSource
            // 
            this.depreciationbindingSource.DataSource = typeof(ClearOffice.FixedAsset.DataAccess.LookupItem);
            // 
            // defaultMethodLabel
            // 
            defaultMethodLabel.AutoSize = true;
            defaultMethodLabel.Location = new System.Drawing.Point(22, 68);
            defaultMethodLabel.Name = "defaultMethodLabel";
            defaultMethodLabel.Size = new System.Drawing.Size(81, 13);
            defaultMethodLabel.TabIndex = 22;
            defaultMethodLabel.Text = "Default Method";
            // 
            // defaultMethodLookUpEdit
            // 
            this.defaultMethodLookUpEdit.DataBindings.Add(new System.Windows.Forms.Binding("EditValue", this.settingbindingSource, "DefaultMethod", true));
            this.defaultMethodLookUpEdit.Enabled = false;
            this.defaultMethodLookUpEdit.Location = new System.Drawing.Point(113, 65);
            this.defaultMethodLookUpEdit.Name = "defaultMethodLookUpEdit";
            this.defaultMethodLookUpEdit.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.defaultMethodLookUpEdit.Properties.Columns.AddRange(new DevExpress.XtraEditors.Controls.LookUpColumnInfo[] {
            new DevExpress.XtraEditors.Controls.LookUpColumnInfo("ItemName", "Depreciation Method", 62, DevExpress.Utils.FormatType.None, "", true, DevExpress.Utils.HorzAlignment.Near)});
            this.defaultMethodLookUpEdit.Properties.DataSource = this.depreciationbindingSource;
            this.defaultMethodLookUpEdit.Properties.DisplayMember = "ItemName";
            this.defaultMethodLookUpEdit.Properties.NullText = "[Select Depreciation Method]";
            this.defaultMethodLookUpEdit.Properties.ValueMember = "LookupItemId";
            this.defaultMethodLookUpEdit.Size = new System.Drawing.Size(275, 20);
            this.defaultMethodLookUpEdit.TabIndex = 23;
            // 
            // dateEdit2
            // 
            this.dateEdit2.DataBindings.Add(new System.Windows.Forms.Binding("EditValue", this.settingbindingSource, "FiscalYearEnd", true));
            this.dateEdit2.EditValue = null;
            this.dateEdit2.Enabled = false;
            this.dateEdit2.Location = new System.Drawing.Point(113, 38);
            this.dateEdit2.Name = "dateEdit2";
            this.dateEdit2.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.dateEdit2.Properties.VistaTimeProperties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton()});
            this.dateEdit2.Size = new System.Drawing.Size(275, 20);
            this.dateEdit2.TabIndex = 21;
            // 
            // dateEdit1
            // 
            this.dateEdit1.DataBindings.Add(new System.Windows.Forms.Binding("EditValue", this.settingbindingSource, "FiscalYearStart", true));
            this.dateEdit1.EditValue = null;
            this.dateEdit1.Enabled = false;
            this.dateEdit1.Location = new System.Drawing.Point(113, 12);
            this.dateEdit1.Name = "dateEdit1";
            this.dateEdit1.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.dateEdit1.Properties.VistaTimeProperties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton()});
            this.dateEdit1.Size = new System.Drawing.Size(275, 20);
            this.dateEdit1.TabIndex = 20;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(22, 41);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(79, 13);
            this.label2.TabIndex = 19;
            this.label2.Text = "Fiscal Year End";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(22, 12);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(88, 13);
            this.label1.TabIndex = 18;
            this.label1.Text = "Fiscal  Year Start";
            // 
            // ApplicationSettingView
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(399, 123);
            this.Controls.Add(defaultMethodLabel);
            this.Controls.Add(this.defaultMethodLookUpEdit);
            this.Controls.Add(this.dateEdit2);
            this.Controls.Add(this.dateEdit1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnSetSave);
            this.Controls.Add(this.btnchange);
            this.Controls.Add(this.trackBarControl1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "ApplicationSettingView";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Application Setting ";
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.trackBarControl1.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.trackBarControl1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.settingbindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.depreciationbindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.defaultMethodLookUpEdit.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dateEdit2.Properties.VistaTimeProperties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dateEdit2.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dateEdit1.Properties.VistaTimeProperties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dateEdit1.Properties)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.BindingSource settingbindingSource;
        private System.Windows.Forms.ErrorProvider errorProvider1;
        private System.Windows.Forms.BindingSource depreciationbindingSource;
        private DevExpress.XtraEditors.TrackBarControl trackBarControl1;
        private DevExpress.XtraEditors.SimpleButton btnSetSave;
        private DevExpress.XtraEditors.SimpleButton btnchange;
        private DevExpress.XtraEditors.LookUpEdit defaultMethodLookUpEdit;
        private DevExpress.XtraEditors.DateEdit dateEdit2;
        private DevExpress.XtraEditors.DateEdit dateEdit1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;

    }
}