namespace ClearOffice.Fleet.Views
{
    partial class MaintenanceActivityEdit
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
            System.Windows.Forms.Label activityTypeIdLabel;
            System.Windows.Forms.Label descriptionLabel;
            System.Windows.Forms.Label laborUnitsLabel;
            System.Windows.Forms.Label unitCostLabel;
            System.Windows.Forms.Label performerLabel;
            System.Windows.Forms.Label notesLabel;
            this.errorProvider1 = new System.Windows.Forms.ErrorProvider(this.components);
            this.activityTypeIdLookUpEdit = new DevExpress.XtraEditors.LookUpEdit();
            this.descriptionMemoEdit = new DevExpress.XtraEditors.MemoEdit();
            this.laborUnitsTextEdit = new DevExpress.XtraEditors.TextEdit();
            this.unitCostTextEdit = new DevExpress.XtraEditors.TextEdit();
            this.performerTextEdit = new DevExpress.XtraEditors.TextEdit();
            this.performedByCheckEdit = new DevExpress.XtraEditors.CheckEdit();
            this.notesMemoEdit = new DevExpress.XtraEditors.MemoEdit();
            this.okCommand = new DevExpress.XtraEditors.SimpleButton();
            this.cancelCommand = new DevExpress.XtraEditors.SimpleButton();
            this.activityBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.activityTypesBindingSource = new System.Windows.Forms.BindingSource(this.components);
            activityTypeIdLabel = new System.Windows.Forms.Label();
            descriptionLabel = new System.Windows.Forms.Label();
            laborUnitsLabel = new System.Windows.Forms.Label();
            unitCostLabel = new System.Windows.Forms.Label();
            performerLabel = new System.Windows.Forms.Label();
            notesLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.activityTypeIdLookUpEdit.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.descriptionMemoEdit.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.laborUnitsTextEdit.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.unitCostTextEdit.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.performerTextEdit.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.performedByCheckEdit.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.notesMemoEdit.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.activityBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.activityTypesBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // activityTypeIdLabel
            // 
            activityTypeIdLabel.AutoSize = true;
            activityTypeIdLabel.Location = new System.Drawing.Point(10, 15);
            activityTypeIdLabel.Name = "activityTypeIdLabel";
            activityTypeIdLabel.Size = new System.Drawing.Size(47, 13);
            activityTypeIdLabel.TabIndex = 0;
            activityTypeIdLabel.Text = "Activity:";
            // 
            // descriptionLabel
            // 
            descriptionLabel.AutoSize = true;
            descriptionLabel.Location = new System.Drawing.Point(10, 41);
            descriptionLabel.Name = "descriptionLabel";
            descriptionLabel.Size = new System.Drawing.Size(64, 13);
            descriptionLabel.TabIndex = 2;
            descriptionLabel.Text = "Description:";
            // 
            // laborUnitsLabel
            // 
            laborUnitsLabel.AutoSize = true;
            laborUnitsLabel.Location = new System.Drawing.Point(10, 111);
            laborUnitsLabel.Name = "laborUnitsLabel";
            laborUnitsLabel.Size = new System.Drawing.Size(65, 13);
            laborUnitsLabel.TabIndex = 4;
            laborUnitsLabel.Text = "Labor Units:";
            // 
            // unitCostLabel
            // 
            unitCostLabel.AutoSize = true;
            unitCostLabel.Location = new System.Drawing.Point(190, 111);
            unitCostLabel.Name = "unitCostLabel";
            unitCostLabel.Size = new System.Drawing.Size(55, 13);
            unitCostLabel.TabIndex = 6;
            unitCostLabel.Text = "Unit Cost:";
            // 
            // performerLabel
            // 
            performerLabel.AutoSize = true;
            performerLabel.Location = new System.Drawing.Point(10, 164);
            performerLabel.Name = "performerLabel";
            performerLabel.Size = new System.Drawing.Size(59, 13);
            performerLabel.TabIndex = 8;
            performerLabel.Text = "Performer:";
            // 
            // notesLabel
            // 
            notesLabel.AutoSize = true;
            notesLabel.Location = new System.Drawing.Point(10, 190);
            notesLabel.Name = "notesLabel";
            notesLabel.Size = new System.Drawing.Size(39, 13);
            notesLabel.TabIndex = 11;
            notesLabel.Text = "Notes:";
            // 
            // errorProvider1
            // 
            this.errorProvider1.ContainerControl = this;
            this.errorProvider1.DataSource = this.activityBindingSource;
            // 
            // activityTypeIdLookUpEdit
            // 
            this.activityTypeIdLookUpEdit.DataBindings.Add(new System.Windows.Forms.Binding("EditValue", this.activityBindingSource, "ActivityTypeId", true));
            this.activityTypeIdLookUpEdit.Location = new System.Drawing.Point(78, 12);
            this.activityTypeIdLookUpEdit.Name = "activityTypeIdLookUpEdit";
            this.activityTypeIdLookUpEdit.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.activityTypeIdLookUpEdit.Properties.Columns.AddRange(new DevExpress.XtraEditors.Controls.LookUpColumnInfo[] {
            new DevExpress.XtraEditors.Controls.LookUpColumnInfo("ItemName", "Activity Name", 62, DevExpress.Utils.FormatType.None, "", true, DevExpress.Utils.HorzAlignment.Near)});
            this.activityTypeIdLookUpEdit.Properties.DataSource = this.activityTypesBindingSource;
            this.activityTypeIdLookUpEdit.Properties.DisplayMember = "ItemName";
            this.activityTypeIdLookUpEdit.Properties.NullText = "[Select activity type]";
            this.activityTypeIdLookUpEdit.Properties.ValueMember = "LookupItemId";
            this.activityTypeIdLookUpEdit.Size = new System.Drawing.Size(273, 20);
            this.activityTypeIdLookUpEdit.TabIndex = 1;
            // 
            // descriptionMemoEdit
            // 
            this.descriptionMemoEdit.DataBindings.Add(new System.Windows.Forms.Binding("EditValue", this.activityBindingSource, "Description", true));
            this.descriptionMemoEdit.Location = new System.Drawing.Point(78, 38);
            this.descriptionMemoEdit.Name = "descriptionMemoEdit";
            this.descriptionMemoEdit.Size = new System.Drawing.Size(273, 64);
            this.descriptionMemoEdit.TabIndex = 3;
            // 
            // laborUnitsTextEdit
            // 
            this.laborUnitsTextEdit.DataBindings.Add(new System.Windows.Forms.Binding("EditValue", this.activityBindingSource, "LaborUnits", true));
            this.laborUnitsTextEdit.Location = new System.Drawing.Point(78, 108);
            this.laborUnitsTextEdit.Name = "laborUnitsTextEdit";
            this.laborUnitsTextEdit.Size = new System.Drawing.Size(100, 20);
            this.laborUnitsTextEdit.TabIndex = 5;
            // 
            // unitCostTextEdit
            // 
            this.unitCostTextEdit.DataBindings.Add(new System.Windows.Forms.Binding("EditValue", this.activityBindingSource, "UnitCost", true));
            this.unitCostTextEdit.Location = new System.Drawing.Point(251, 108);
            this.unitCostTextEdit.Name = "unitCostTextEdit";
            this.unitCostTextEdit.Size = new System.Drawing.Size(100, 20);
            this.unitCostTextEdit.TabIndex = 7;
            // 
            // performerTextEdit
            // 
            this.performerTextEdit.DataBindings.Add(new System.Windows.Forms.Binding("EditValue", this.activityBindingSource, "Performer", true));
            this.performerTextEdit.Location = new System.Drawing.Point(78, 161);
            this.performerTextEdit.Name = "performerTextEdit";
            this.performerTextEdit.Size = new System.Drawing.Size(273, 20);
            this.performerTextEdit.TabIndex = 9;
            // 
            // performedByCheckEdit
            // 
            this.performedByCheckEdit.DataBindings.Add(new System.Windows.Forms.Binding("EditValue", this.activityBindingSource, "PerformedBy", true));
            this.performedByCheckEdit.Location = new System.Drawing.Point(76, 134);
            this.performedByCheckEdit.Name = "performedByCheckEdit";
            this.performedByCheckEdit.Properties.Caption = "Performed by external entity";
            this.performedByCheckEdit.Size = new System.Drawing.Size(211, 19);
            this.performedByCheckEdit.TabIndex = 11;
            // 
            // notesMemoEdit
            // 
            this.notesMemoEdit.DataBindings.Add(new System.Windows.Forms.Binding("EditValue", this.activityBindingSource, "Notes", true));
            this.notesMemoEdit.Location = new System.Drawing.Point(78, 187);
            this.notesMemoEdit.Name = "notesMemoEdit";
            this.notesMemoEdit.Size = new System.Drawing.Size(273, 66);
            this.notesMemoEdit.TabIndex = 12;
            // 
            // okCommand
            // 
            this.okCommand.Location = new System.Drawing.Point(106, 259);
            this.okCommand.Name = "okCommand";
            this.okCommand.Size = new System.Drawing.Size(75, 23);
            this.okCommand.TabIndex = 13;
            this.okCommand.Text = "Ok";
            this.okCommand.Click += new System.EventHandler(this.okCommand_Click);
            // 
            // cancelCommand
            // 
            this.cancelCommand.Location = new System.Drawing.Point(187, 259);
            this.cancelCommand.Name = "cancelCommand";
            this.cancelCommand.Size = new System.Drawing.Size(75, 23);
            this.cancelCommand.TabIndex = 14;
            this.cancelCommand.Text = "Cancel";
            this.cancelCommand.Click += new System.EventHandler(this.cancelCommand_Click);
            // 
            // activityBindingSource
            // 
            this.activityBindingSource.DataSource = typeof(ClearOffice.Fleet.Business.MaintenanceActivity);
            this.activityBindingSource.CurrentItemChanged += new System.EventHandler(this.activityBindingSource_CurrentItemChanged);
            // 
            // activityTypesBindingSource
            // 
            this.activityTypesBindingSource.DataSource = typeof(ClearOffice.Fleet.Business.LookupItem);
            // 
            // MaintenanceActivityEdit
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(368, 294);
            this.Controls.Add(this.cancelCommand);
            this.Controls.Add(this.okCommand);
            this.Controls.Add(notesLabel);
            this.Controls.Add(this.notesMemoEdit);
            this.Controls.Add(this.performedByCheckEdit);
            this.Controls.Add(performerLabel);
            this.Controls.Add(this.performerTextEdit);
            this.Controls.Add(unitCostLabel);
            this.Controls.Add(this.unitCostTextEdit);
            this.Controls.Add(laborUnitsLabel);
            this.Controls.Add(this.laborUnitsTextEdit);
            this.Controls.Add(descriptionLabel);
            this.Controls.Add(this.descriptionMemoEdit);
            this.Controls.Add(activityTypeIdLabel);
            this.Controls.Add(this.activityTypeIdLookUpEdit);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "MaintenanceActivityEdit";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "MaintenanceActivityEdit";
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.activityTypeIdLookUpEdit.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.descriptionMemoEdit.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.laborUnitsTextEdit.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.unitCostTextEdit.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.performerTextEdit.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.performedByCheckEdit.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.notesMemoEdit.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.activityBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.activityTypesBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.BindingSource activityBindingSource;
        private System.Windows.Forms.ErrorProvider errorProvider1;
        private DevExpress.XtraEditors.LookUpEdit activityTypeIdLookUpEdit;
        private DevExpress.XtraEditors.SimpleButton cancelCommand;
        private DevExpress.XtraEditors.SimpleButton okCommand;
        private DevExpress.XtraEditors.MemoEdit notesMemoEdit;
        private DevExpress.XtraEditors.CheckEdit performedByCheckEdit;
        private DevExpress.XtraEditors.TextEdit performerTextEdit;
        private DevExpress.XtraEditors.TextEdit unitCostTextEdit;
        private DevExpress.XtraEditors.TextEdit laborUnitsTextEdit;
        private DevExpress.XtraEditors.MemoEdit descriptionMemoEdit;
        private System.Windows.Forms.BindingSource activityTypesBindingSource;
    }
}