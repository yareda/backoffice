namespace ClearOffice.Fleet.Views
{
    partial class UnMountTireView
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
            System.Windows.Forms.Label vehicleIdLabel;
            System.Windows.Forms.Label serialNoLabel;
            System.Windows.Forms.Label mountedDateLabel;
            System.Windows.Forms.Label mountedMilageLabel;
            System.Windows.Forms.Label unmountedDateLabel;
            System.Windows.Forms.Label unmountMilageLabel;
            System.Windows.Forms.Label positionLabel;
            System.Windows.Forms.Label remarkLabel;
            this.vehicleIdLookUpEdit = new DevExpress.XtraEditors.LookUpEdit();
            this.serialNoTextEdit = new DevExpress.XtraEditors.TextEdit();
            this.mountedDateDateEdit = new DevExpress.XtraEditors.DateEdit();
            this.mountedMilageTextEdit = new DevExpress.XtraEditors.TextEdit();
            this.unmountedDateDateEdit = new DevExpress.XtraEditors.DateEdit();
            this.unmountMilageTextEdit = new DevExpress.XtraEditors.TextEdit();
            this.positionTextEdit = new DevExpress.XtraEditors.TextEdit();
            this.remarkMemoEdit = new DevExpress.XtraEditors.MemoEdit();
            this.okCommand = new DevExpress.XtraEditors.SimpleButton();
            this.cancelCommand = new DevExpress.XtraEditors.SimpleButton();
            this.tireUsageBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.vehicleInfoBindingSource = new System.Windows.Forms.BindingSource(this.components);
            vehicleIdLabel = new System.Windows.Forms.Label();
            serialNoLabel = new System.Windows.Forms.Label();
            mountedDateLabel = new System.Windows.Forms.Label();
            mountedMilageLabel = new System.Windows.Forms.Label();
            unmountedDateLabel = new System.Windows.Forms.Label();
            unmountMilageLabel = new System.Windows.Forms.Label();
            positionLabel = new System.Windows.Forms.Label();
            remarkLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.vehicleIdLookUpEdit.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.serialNoTextEdit.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.mountedDateDateEdit.Properties.VistaTimeProperties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.mountedDateDateEdit.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.mountedMilageTextEdit.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.unmountedDateDateEdit.Properties.VistaTimeProperties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.unmountedDateDateEdit.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.unmountMilageTextEdit.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.positionTextEdit.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.remarkMemoEdit.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tireUsageBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.vehicleInfoBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // vehicleIdLabel
            // 
            vehicleIdLabel.AutoSize = true;
            vehicleIdLabel.Location = new System.Drawing.Point(10, 41);
            vehicleIdLabel.Name = "vehicleIdLabel";
            vehicleIdLabel.Size = new System.Drawing.Size(70, 13);
            vehicleIdLabel.TabIndex = 0;
            vehicleIdLabel.Text = "Mounted On:";
            // 
            // vehicleIdLookUpEdit
            // 
            this.vehicleIdLookUpEdit.DataBindings.Add(new System.Windows.Forms.Binding("EditValue", this.tireUsageBindingSource, "VehicleId", true));
            this.vehicleIdLookUpEdit.Location = new System.Drawing.Point(97, 38);
            this.vehicleIdLookUpEdit.Name = "vehicleIdLookUpEdit";
            this.vehicleIdLookUpEdit.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.vehicleIdLookUpEdit.Properties.Columns.AddRange(new DevExpress.XtraEditors.Controls.LookUpColumnInfo[] {
            new DevExpress.XtraEditors.Controls.LookUpColumnInfo("PlateNumber", "Plate Number", 100, DevExpress.Utils.FormatType.None, "", true, DevExpress.Utils.HorzAlignment.Near)});
            this.vehicleIdLookUpEdit.Properties.DataSource = this.vehicleInfoBindingSource;
            this.vehicleIdLookUpEdit.Properties.DisplayMember = "PlateNumber";
            this.vehicleIdLookUpEdit.Properties.NullText = "[Select Vehicle]";
            this.vehicleIdLookUpEdit.Properties.ValueMember = "VehicleId";
            this.vehicleIdLookUpEdit.Size = new System.Drawing.Size(321, 20);
            this.vehicleIdLookUpEdit.TabIndex = 1;
            // 
            // serialNoLabel
            // 
            serialNoLabel.AutoSize = true;
            serialNoLabel.Location = new System.Drawing.Point(10, 15);
            serialNoLabel.Name = "serialNoLabel";
            serialNoLabel.Size = new System.Drawing.Size(53, 13);
            serialNoLabel.TabIndex = 2;
            serialNoLabel.Text = "Serial No:";
            // 
            // serialNoTextEdit
            // 
            this.serialNoTextEdit.DataBindings.Add(new System.Windows.Forms.Binding("EditValue", this.tireUsageBindingSource, "TireDetail.SerialNo", true));
            this.serialNoTextEdit.Enabled = false;
            this.serialNoTextEdit.Location = new System.Drawing.Point(97, 12);
            this.serialNoTextEdit.Name = "serialNoTextEdit";
            this.serialNoTextEdit.Size = new System.Drawing.Size(321, 20);
            this.serialNoTextEdit.TabIndex = 0;
            // 
            // mountedDateLabel
            // 
            mountedDateLabel.AutoSize = true;
            mountedDateLabel.Location = new System.Drawing.Point(10, 90);
            mountedDateLabel.Name = "mountedDateLabel";
            mountedDateLabel.Size = new System.Drawing.Size(79, 13);
            mountedDateLabel.TabIndex = 4;
            mountedDateLabel.Text = "Mounted Date:";
            // 
            // mountedDateDateEdit
            // 
            this.mountedDateDateEdit.DataBindings.Add(new System.Windows.Forms.Binding("EditValue", this.tireUsageBindingSource, "MountedDate", true));
            this.mountedDateDateEdit.EditValue = null;
            this.mountedDateDateEdit.Location = new System.Drawing.Point(97, 90);
            this.mountedDateDateEdit.Name = "mountedDateDateEdit";
            this.mountedDateDateEdit.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.mountedDateDateEdit.Properties.VistaTimeProperties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton()});
            this.mountedDateDateEdit.Size = new System.Drawing.Size(100, 20);
            this.mountedDateDateEdit.TabIndex = 3;
            // 
            // mountedMilageLabel
            // 
            mountedMilageLabel.AutoSize = true;
            mountedMilageLabel.Location = new System.Drawing.Point(10, 114);
            mountedMilageLabel.Name = "mountedMilageLabel";
            mountedMilageLabel.Size = new System.Drawing.Size(86, 13);
            mountedMilageLabel.TabIndex = 6;
            mountedMilageLabel.Text = "Mounted Milage:";
            // 
            // mountedMilageTextEdit
            // 
            this.mountedMilageTextEdit.DataBindings.Add(new System.Windows.Forms.Binding("EditValue", this.tireUsageBindingSource, "MountedMilage", true));
            this.mountedMilageTextEdit.Location = new System.Drawing.Point(97, 114);
            this.mountedMilageTextEdit.Name = "mountedMilageTextEdit";
            this.mountedMilageTextEdit.Size = new System.Drawing.Size(100, 20);
            this.mountedMilageTextEdit.TabIndex = 4;
            // 
            // unmountedDateLabel
            // 
            unmountedDateLabel.AutoSize = true;
            unmountedDateLabel.Location = new System.Drawing.Point(222, 90);
            unmountedDateLabel.Name = "unmountedDateLabel";
            unmountedDateLabel.Size = new System.Drawing.Size(92, 13);
            unmountedDateLabel.TabIndex = 8;
            unmountedDateLabel.Text = "Unmounted Date:";
            // 
            // unmountedDateDateEdit
            // 
            this.unmountedDateDateEdit.DataBindings.Add(new System.Windows.Forms.Binding("EditValue", this.tireUsageBindingSource, "UnmountedDate", true));
            this.unmountedDateDateEdit.EditValue = null;
            this.unmountedDateDateEdit.Location = new System.Drawing.Point(318, 90);
            this.unmountedDateDateEdit.Name = "unmountedDateDateEdit";
            this.unmountedDateDateEdit.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.unmountedDateDateEdit.Properties.VistaTimeProperties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton()});
            this.unmountedDateDateEdit.Size = new System.Drawing.Size(100, 20);
            this.unmountedDateDateEdit.TabIndex = 5;
            // 
            // unmountMilageLabel
            // 
            unmountMilageLabel.AutoSize = true;
            unmountMilageLabel.Location = new System.Drawing.Point(222, 114);
            unmountMilageLabel.Name = "unmountMilageLabel";
            unmountMilageLabel.Size = new System.Drawing.Size(87, 13);
            unmountMilageLabel.TabIndex = 10;
            unmountMilageLabel.Text = "Unmount Milage:";
            // 
            // unmountMilageTextEdit
            // 
            this.unmountMilageTextEdit.DataBindings.Add(new System.Windows.Forms.Binding("EditValue", this.tireUsageBindingSource, "UnmountMilage", true));
            this.unmountMilageTextEdit.Location = new System.Drawing.Point(318, 114);
            this.unmountMilageTextEdit.Name = "unmountMilageTextEdit";
            this.unmountMilageTextEdit.Size = new System.Drawing.Size(100, 20);
            this.unmountMilageTextEdit.TabIndex = 6;
            // 
            // positionLabel
            // 
            positionLabel.AutoSize = true;
            positionLabel.Location = new System.Drawing.Point(10, 67);
            positionLabel.Name = "positionLabel";
            positionLabel.Size = new System.Drawing.Size(48, 13);
            positionLabel.TabIndex = 12;
            positionLabel.Text = "Position:";
            // 
            // positionTextEdit
            // 
            this.positionTextEdit.DataBindings.Add(new System.Windows.Forms.Binding("EditValue", this.tireUsageBindingSource, "Position", true));
            this.positionTextEdit.Location = new System.Drawing.Point(97, 64);
            this.positionTextEdit.Name = "positionTextEdit";
            this.positionTextEdit.Size = new System.Drawing.Size(321, 20);
            this.positionTextEdit.TabIndex = 2;
            // 
            // remarkLabel
            // 
            remarkLabel.AutoSize = true;
            remarkLabel.Location = new System.Drawing.Point(10, 145);
            remarkLabel.Name = "remarkLabel";
            remarkLabel.Size = new System.Drawing.Size(47, 13);
            remarkLabel.TabIndex = 14;
            remarkLabel.Text = "Remark:";
            // 
            // remarkMemoEdit
            // 
            this.remarkMemoEdit.DataBindings.Add(new System.Windows.Forms.Binding("EditValue", this.tireUsageBindingSource, "Remark", true));
            this.remarkMemoEdit.Location = new System.Drawing.Point(97, 142);
            this.remarkMemoEdit.Name = "remarkMemoEdit";
            this.remarkMemoEdit.Size = new System.Drawing.Size(321, 96);
            this.remarkMemoEdit.TabIndex = 7;
            // 
            // okCommand
            // 
            this.okCommand.Location = new System.Drawing.Point(144, 246);
            this.okCommand.Name = "okCommand";
            this.okCommand.Size = new System.Drawing.Size(75, 23);
            this.okCommand.TabIndex = 8;
            this.okCommand.Text = "Ok";
            this.okCommand.Click += new System.EventHandler(this.okCommand_Click);
            // 
            // cancelCommand
            // 
            this.cancelCommand.Location = new System.Drawing.Point(225, 246);
            this.cancelCommand.Name = "cancelCommand";
            this.cancelCommand.Size = new System.Drawing.Size(75, 23);
            this.cancelCommand.TabIndex = 9;
            this.cancelCommand.Text = "Cancel";
            this.cancelCommand.Click += new System.EventHandler(this.cancelCommand_Click);
            // 
            // tireUsageBindingSource
            // 
            this.tireUsageBindingSource.DataSource = typeof(ClearOffice.Fleet.Business.VehicleTire);
            this.tireUsageBindingSource.CurrentItemChanged += new System.EventHandler(this.tireUsageBindingSource_CurrentItemChanged);
            // 
            // vehicleInfoBindingSource
            // 
            this.vehicleInfoBindingSource.DataSource = typeof(ClearOffice.Fleet.Business.VehicleInfo);
            // 
            // UnMountTireView
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(444, 281);
            this.Controls.Add(this.cancelCommand);
            this.Controls.Add(this.okCommand);
            this.Controls.Add(remarkLabel);
            this.Controls.Add(this.remarkMemoEdit);
            this.Controls.Add(positionLabel);
            this.Controls.Add(this.positionTextEdit);
            this.Controls.Add(unmountMilageLabel);
            this.Controls.Add(this.unmountMilageTextEdit);
            this.Controls.Add(unmountedDateLabel);
            this.Controls.Add(this.unmountedDateDateEdit);
            this.Controls.Add(mountedMilageLabel);
            this.Controls.Add(this.mountedMilageTextEdit);
            this.Controls.Add(mountedDateLabel);
            this.Controls.Add(this.mountedDateDateEdit);
            this.Controls.Add(serialNoLabel);
            this.Controls.Add(this.serialNoTextEdit);
            this.Controls.Add(vehicleIdLabel);
            this.Controls.Add(this.vehicleIdLookUpEdit);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "UnMountTireView";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Mount/UnMount Tire";
            ((System.ComponentModel.ISupportInitialize)(this.vehicleIdLookUpEdit.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.serialNoTextEdit.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.mountedDateDateEdit.Properties.VistaTimeProperties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.mountedDateDateEdit.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.mountedMilageTextEdit.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.unmountedDateDateEdit.Properties.VistaTimeProperties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.unmountedDateDateEdit.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.unmountMilageTextEdit.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.positionTextEdit.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.remarkMemoEdit.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tireUsageBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.vehicleInfoBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.BindingSource tireUsageBindingSource;
        private DevExpress.XtraEditors.LookUpEdit vehicleIdLookUpEdit;
        private DevExpress.XtraEditors.TextEdit serialNoTextEdit;
        private DevExpress.XtraEditors.DateEdit mountedDateDateEdit;
        private DevExpress.XtraEditors.TextEdit mountedMilageTextEdit;
        private DevExpress.XtraEditors.DateEdit unmountedDateDateEdit;
        private DevExpress.XtraEditors.TextEdit unmountMilageTextEdit;
        private DevExpress.XtraEditors.TextEdit positionTextEdit;
        private DevExpress.XtraEditors.MemoEdit remarkMemoEdit;
        private DevExpress.XtraEditors.SimpleButton okCommand;
        private DevExpress.XtraEditors.SimpleButton cancelCommand;
        private System.Windows.Forms.BindingSource vehicleInfoBindingSource;
    }
}