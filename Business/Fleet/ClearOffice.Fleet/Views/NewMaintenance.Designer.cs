namespace ClearOffice.Fleet.Views
{
    partial class NewMaintenance
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
            this.labelControl1 = new DevExpress.XtraEditors.LabelControl();
            this.vehiclesLookUpEdit = new DevExpress.XtraEditors.LookUpEdit();
            this.labelControl2 = new DevExpress.XtraEditors.LabelControl();
            this.requestNoTextEdit = new DevExpress.XtraEditors.TextEdit();
            this.labelControl3 = new DevExpress.XtraEditors.LabelControl();
            this.requestDateEdit = new DevExpress.XtraEditors.DateEdit();
            this.okCommand = new DevExpress.XtraEditors.SimpleButton();
            this.cancelCommand = new DevExpress.XtraEditors.SimpleButton();
            this.errorProvider1 = new System.Windows.Forms.ErrorProvider(this.components);
            this.maintenanceBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.vehicleBindingSource = new System.Windows.Forms.BindingSource(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.vehiclesLookUpEdit.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.requestNoTextEdit.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.requestDateEdit.Properties.VistaTimeProperties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.requestDateEdit.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.maintenanceBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.vehicleBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // labelControl1
            // 
            this.labelControl1.Location = new System.Drawing.Point(29, 15);
            this.labelControl1.Name = "labelControl1";
            this.labelControl1.Size = new System.Drawing.Size(37, 13);
            this.labelControl1.TabIndex = 0;
            this.labelControl1.Text = "Vehicle:";
            // 
            // vehiclesLookUpEdit
            // 
            this.vehiclesLookUpEdit.DataBindings.Add(new System.Windows.Forms.Binding("EditValue", this.maintenanceBindingSource, "VehicleId", true));
            this.vehiclesLookUpEdit.Location = new System.Drawing.Point(133, 8);
            this.vehiclesLookUpEdit.Name = "vehiclesLookUpEdit";
            this.vehiclesLookUpEdit.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.vehiclesLookUpEdit.Properties.Columns.AddRange(new DevExpress.XtraEditors.Controls.LookUpColumnInfo[] {
            new DevExpress.XtraEditors.Controls.LookUpColumnInfo("PlateNumber", "Plate Number", 100, DevExpress.Utils.FormatType.None, "", true, DevExpress.Utils.HorzAlignment.Near),
            new DevExpress.XtraEditors.Controls.LookUpColumnInfo("ChasisNo", "Chasis No", 100, DevExpress.Utils.FormatType.None, "", true, DevExpress.Utils.HorzAlignment.Near),
            new DevExpress.XtraEditors.Controls.LookUpColumnInfo("EngineSerial", "Engine Serial", 100, DevExpress.Utils.FormatType.None, "", true, DevExpress.Utils.HorzAlignment.Near)});
            this.vehiclesLookUpEdit.Properties.DataSource = this.vehicleBindingSource;
            this.vehiclesLookUpEdit.Properties.DisplayMember = "PlateNumber";
            this.vehiclesLookUpEdit.Properties.NullText = "[Select Vehicle]";
            this.vehiclesLookUpEdit.Properties.ValueMember = "VehicleId";
            this.vehiclesLookUpEdit.Size = new System.Drawing.Size(214, 20);
            this.vehiclesLookUpEdit.TabIndex = 1;
            // 
            // labelControl2
            // 
            this.labelControl2.Location = new System.Drawing.Point(29, 37);
            this.labelControl2.Name = "labelControl2";
            this.labelControl2.Size = new System.Drawing.Size(98, 13);
            this.labelControl2.TabIndex = 2;
            this.labelControl2.Text = "Service Request No:";
            // 
            // requestNoTextEdit
            // 
            this.requestNoTextEdit.DataBindings.Add(new System.Windows.Forms.Binding("EditValue", this.maintenanceBindingSource, "ServiceRequestNo", true));
            this.requestNoTextEdit.Location = new System.Drawing.Point(133, 34);
            this.requestNoTextEdit.Name = "requestNoTextEdit";
            this.requestNoTextEdit.Size = new System.Drawing.Size(214, 20);
            this.requestNoTextEdit.TabIndex = 3;
            // 
            // labelControl3
            // 
            this.labelControl3.Location = new System.Drawing.Point(29, 63);
            this.labelControl3.Name = "labelControl3";
            this.labelControl3.Size = new System.Drawing.Size(70, 13);
            this.labelControl3.TabIndex = 4;
            this.labelControl3.Text = "Request Date:";
            // 
            // requestDateEdit
            // 
            this.requestDateEdit.DataBindings.Add(new System.Windows.Forms.Binding("EditValue", this.maintenanceBindingSource, "CreationDate", true));
            this.requestDateEdit.EditValue = null;
            this.requestDateEdit.Location = new System.Drawing.Point(133, 60);
            this.requestDateEdit.Name = "requestDateEdit";
            this.requestDateEdit.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.requestDateEdit.Properties.VistaTimeProperties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton()});
            this.requestDateEdit.Size = new System.Drawing.Size(214, 20);
            this.requestDateEdit.TabIndex = 5;
            // 
            // okCommand
            // 
            this.okCommand.Location = new System.Drawing.Point(105, 96);
            this.okCommand.Name = "okCommand";
            this.okCommand.Size = new System.Drawing.Size(75, 23);
            this.okCommand.TabIndex = 6;
            this.okCommand.Text = "Ok";
            this.okCommand.Click += new System.EventHandler(this.okCommand_Click);
            // 
            // cancelCommand
            // 
            this.cancelCommand.Location = new System.Drawing.Point(195, 96);
            this.cancelCommand.Name = "cancelCommand";
            this.cancelCommand.Size = new System.Drawing.Size(75, 23);
            this.cancelCommand.TabIndex = 7;
            this.cancelCommand.Text = "Cancel";
            this.cancelCommand.Click += new System.EventHandler(this.cancelCommand_Click);
            // 
            // errorProvider1
            // 
            this.errorProvider1.ContainerControl = this;
            this.errorProvider1.DataSource = this.maintenanceBindingSource;
            // 
            // maintenanceBindingSource
            // 
            this.maintenanceBindingSource.DataSource = typeof(ClearOffice.Fleet.Business.Maintanance);
            // 
            // vehicleBindingSource
            // 
            this.vehicleBindingSource.DataSource = typeof(ClearOffice.Fleet.Business.VehicleInfo);
            // 
            // NewMaintenance
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(374, 132);
            this.Controls.Add(this.cancelCommand);
            this.Controls.Add(this.okCommand);
            this.Controls.Add(this.requestDateEdit);
            this.Controls.Add(this.labelControl3);
            this.Controls.Add(this.requestNoTextEdit);
            this.Controls.Add(this.labelControl2);
            this.Controls.Add(this.vehiclesLookUpEdit);
            this.Controls.Add(this.labelControl1);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "NewMaintenance";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "New Maintenance";
            ((System.ComponentModel.ISupportInitialize)(this.vehiclesLookUpEdit.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.requestNoTextEdit.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.requestDateEdit.Properties.VistaTimeProperties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.requestDateEdit.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.maintenanceBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.vehicleBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private DevExpress.XtraEditors.LabelControl labelControl1;
        private DevExpress.XtraEditors.LookUpEdit vehiclesLookUpEdit;
        private DevExpress.XtraEditors.LabelControl labelControl2;
        private DevExpress.XtraEditors.TextEdit requestNoTextEdit;
        private DevExpress.XtraEditors.LabelControl labelControl3;
        private DevExpress.XtraEditors.DateEdit requestDateEdit;
        private System.Windows.Forms.BindingSource vehicleBindingSource;
        private DevExpress.XtraEditors.SimpleButton okCommand;
        private DevExpress.XtraEditors.SimpleButton cancelCommand;
        private System.Windows.Forms.BindingSource maintenanceBindingSource;
        private System.Windows.Forms.ErrorProvider errorProvider1;
    }
}