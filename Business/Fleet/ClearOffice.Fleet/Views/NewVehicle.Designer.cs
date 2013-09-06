namespace ClearOffice.Fleet.Views
{
    partial class NewVehicle
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
            System.Windows.Forms.Label plateNumberLabel;
            System.Windows.Forms.Label modelIdLabel;
            System.Windows.Forms.Label makeIdLabel;
            System.Windows.Forms.Label ownershipIdLabel;
            System.Windows.Forms.Label productionYearLabel;
            System.Windows.Forms.Label purchaseDateLabel;
            System.Windows.Forms.Label remarkLabel;
            this.plateNumberTextBox = new System.Windows.Forms.TextBox();
            this.vehicleBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.modelIdLookUpEdit = new DevExpress.XtraEditors.LookUpEdit();
            this.modelBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.makeIdLookUpEdit = new DevExpress.XtraEditors.LookUpEdit();
            this.makeBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.ownershipIdLookUpEdit = new DevExpress.XtraEditors.LookUpEdit();
            this.ownershipBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.productionYearTextBox = new System.Windows.Forms.TextBox();
            this.purchaseDateDateEdit = new DevExpress.XtraEditors.DateEdit();
            this.remarkTextBox = new System.Windows.Forms.TextBox();
            this.SaveCommand = new DevExpress.XtraEditors.SimpleButton();
            this.CancelCommand = new DevExpress.XtraEditors.SimpleButton();
            this.errorProvider1 = new System.Windows.Forms.ErrorProvider(this.components);
            plateNumberLabel = new System.Windows.Forms.Label();
            modelIdLabel = new System.Windows.Forms.Label();
            makeIdLabel = new System.Windows.Forms.Label();
            ownershipIdLabel = new System.Windows.Forms.Label();
            productionYearLabel = new System.Windows.Forms.Label();
            purchaseDateLabel = new System.Windows.Forms.Label();
            remarkLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.vehicleBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.modelIdLookUpEdit.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.modelBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.makeIdLookUpEdit.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.makeBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ownershipIdLookUpEdit.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ownershipBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.purchaseDateDateEdit.Properties.VistaTimeProperties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.purchaseDateDateEdit.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).BeginInit();
            this.SuspendLayout();
            // 
            // plateNumberLabel
            // 
            plateNumberLabel.AutoSize = true;
            plateNumberLabel.Location = new System.Drawing.Point(9, 15);
            plateNumberLabel.Name = "plateNumberLabel";
            plateNumberLabel.Size = new System.Drawing.Size(75, 13);
            plateNumberLabel.TabIndex = 0;
            plateNumberLabel.Text = "Plate Number:";
            // 
            // modelIdLabel
            // 
            modelIdLabel.AutoSize = true;
            modelIdLabel.Location = new System.Drawing.Point(9, 42);
            modelIdLabel.Name = "modelIdLabel";
            modelIdLabel.Size = new System.Drawing.Size(35, 13);
            modelIdLabel.TabIndex = 2;
            modelIdLabel.Text = "Type:";
            // 
            // makeIdLabel
            // 
            makeIdLabel.AutoSize = true;
            makeIdLabel.Location = new System.Drawing.Point(9, 68);
            makeIdLabel.Name = "makeIdLabel";
            makeIdLabel.Size = new System.Drawing.Size(36, 13);
            makeIdLabel.TabIndex = 4;
            makeIdLabel.Text = "Make:";
            // 
            // ownershipIdLabel
            // 
            ownershipIdLabel.AutoSize = true;
            ownershipIdLabel.Location = new System.Drawing.Point(9, 94);
            ownershipIdLabel.Name = "ownershipIdLabel";
            ownershipIdLabel.Size = new System.Drawing.Size(62, 13);
            ownershipIdLabel.TabIndex = 6;
            ownershipIdLabel.Text = "Ownership:";
            // 
            // productionYearLabel
            // 
            productionYearLabel.AutoSize = true;
            productionYearLabel.Location = new System.Drawing.Point(9, 123);
            productionYearLabel.Name = "productionYearLabel";
            productionYearLabel.Size = new System.Drawing.Size(87, 13);
            productionYearLabel.TabIndex = 8;
            productionYearLabel.Text = "Production Year:";
            // 
            // purchaseDateLabel
            // 
            purchaseDateLabel.AutoSize = true;
            purchaseDateLabel.Location = new System.Drawing.Point(9, 150);
            purchaseDateLabel.Name = "purchaseDateLabel";
            purchaseDateLabel.Size = new System.Drawing.Size(81, 13);
            purchaseDateLabel.TabIndex = 10;
            purchaseDateLabel.Text = "Purchase Date:";
            // 
            // remarkLabel
            // 
            remarkLabel.AutoSize = true;
            remarkLabel.Location = new System.Drawing.Point(9, 176);
            remarkLabel.Name = "remarkLabel";
            remarkLabel.Size = new System.Drawing.Size(47, 13);
            remarkLabel.TabIndex = 12;
            remarkLabel.Text = "Remark:";
            // 
            // plateNumberTextBox
            // 
            this.plateNumberTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.vehicleBindingSource, "PlateNumber", true));
            this.plateNumberTextBox.Location = new System.Drawing.Point(102, 12);
            this.plateNumberTextBox.Name = "plateNumberTextBox";
            this.plateNumberTextBox.Size = new System.Drawing.Size(355, 21);
            this.plateNumberTextBox.TabIndex = 0;
            // 
            // vehicleBindingSource
            // 
            this.vehicleBindingSource.DataSource = typeof(ClearOffice.Fleet.Business.Vehicle);
            // 
            // modelIdLookUpEdit
            // 
            this.modelIdLookUpEdit.DataBindings.Add(new System.Windows.Forms.Binding("EditValue", this.vehicleBindingSource, "ModelId", true));
            this.modelIdLookUpEdit.Location = new System.Drawing.Point(102, 39);
            this.modelIdLookUpEdit.Name = "modelIdLookUpEdit";
            this.modelIdLookUpEdit.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.modelIdLookUpEdit.Properties.Columns.AddRange(new DevExpress.XtraEditors.Controls.LookUpColumnInfo[] {
            new DevExpress.XtraEditors.Controls.LookUpColumnInfo("ItemName", "Item Name", 62, DevExpress.Utils.FormatType.None, "", true, DevExpress.Utils.HorzAlignment.Near)});
            this.modelIdLookUpEdit.Properties.DataSource = this.modelBindingSource;
            this.modelIdLookUpEdit.Properties.DisplayMember = "ItemName";
            this.modelIdLookUpEdit.Properties.NullText = "[Select Vehicle Type]";
            this.modelIdLookUpEdit.Properties.ValueMember = "LookupItemId";
            this.modelIdLookUpEdit.Size = new System.Drawing.Size(355, 20);
            this.modelIdLookUpEdit.TabIndex = 1;
            // 
            // modelBindingSource
            // 
            this.modelBindingSource.DataSource = typeof(ClearOffice.Fleet.Business.LookupItem);
            // 
            // makeIdLookUpEdit
            // 
            this.makeIdLookUpEdit.DataBindings.Add(new System.Windows.Forms.Binding("EditValue", this.vehicleBindingSource, "MakeId", true));
            this.makeIdLookUpEdit.Location = new System.Drawing.Point(102, 65);
            this.makeIdLookUpEdit.Name = "makeIdLookUpEdit";
            this.makeIdLookUpEdit.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.makeIdLookUpEdit.Properties.Columns.AddRange(new DevExpress.XtraEditors.Controls.LookUpColumnInfo[] {
            new DevExpress.XtraEditors.Controls.LookUpColumnInfo("ItemName", "Item Name", 62, DevExpress.Utils.FormatType.None, "", true, DevExpress.Utils.HorzAlignment.Near)});
            this.makeIdLookUpEdit.Properties.DataSource = this.makeBindingSource;
            this.makeIdLookUpEdit.Properties.DisplayMember = "ItemName";
            this.makeIdLookUpEdit.Properties.NullText = "[Select Vehicle Make]";
            this.makeIdLookUpEdit.Properties.ValueMember = "LookupItemId";
            this.makeIdLookUpEdit.Size = new System.Drawing.Size(355, 20);
            this.makeIdLookUpEdit.TabIndex = 2;
            // 
            // makeBindingSource
            // 
            this.makeBindingSource.DataSource = typeof(ClearOffice.Fleet.Business.LookupItem);
            // 
            // ownershipIdLookUpEdit
            // 
            this.ownershipIdLookUpEdit.DataBindings.Add(new System.Windows.Forms.Binding("EditValue", this.vehicleBindingSource, "OwnershipId", true));
            this.ownershipIdLookUpEdit.Location = new System.Drawing.Point(102, 91);
            this.ownershipIdLookUpEdit.Name = "ownershipIdLookUpEdit";
            this.ownershipIdLookUpEdit.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.ownershipIdLookUpEdit.Properties.Columns.AddRange(new DevExpress.XtraEditors.Controls.LookUpColumnInfo[] {
            new DevExpress.XtraEditors.Controls.LookUpColumnInfo("ItemName", "Item Name", 62, DevExpress.Utils.FormatType.None, "", true, DevExpress.Utils.HorzAlignment.Near)});
            this.ownershipIdLookUpEdit.Properties.DataSource = this.ownershipBindingSource;
            this.ownershipIdLookUpEdit.Properties.DisplayMember = "ItemName";
            this.ownershipIdLookUpEdit.Properties.NullText = "[Select Ownership Status]";
            this.ownershipIdLookUpEdit.Properties.ValueMember = "LookupItemId";
            this.ownershipIdLookUpEdit.Size = new System.Drawing.Size(355, 20);
            this.ownershipIdLookUpEdit.TabIndex = 3;
            // 
            // ownershipBindingSource
            // 
            this.ownershipBindingSource.DataSource = typeof(ClearOffice.Fleet.Business.LookupItem);
            // 
            // productionYearTextBox
            // 
            this.productionYearTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.vehicleBindingSource, "ProductionYear", true));
            this.productionYearTextBox.Location = new System.Drawing.Point(102, 120);
            this.productionYearTextBox.Name = "productionYearTextBox";
            this.productionYearTextBox.Size = new System.Drawing.Size(355, 21);
            this.productionYearTextBox.TabIndex = 4;
            // 
            // purchaseDateDateEdit
            // 
            this.purchaseDateDateEdit.DataBindings.Add(new System.Windows.Forms.Binding("EditValue", this.vehicleBindingSource, "PurchaseDate", true));
            this.purchaseDateDateEdit.EditValue = null;
            this.purchaseDateDateEdit.Location = new System.Drawing.Point(102, 147);
            this.purchaseDateDateEdit.Name = "purchaseDateDateEdit";
            this.purchaseDateDateEdit.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.purchaseDateDateEdit.Properties.VistaTimeProperties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton()});
            this.purchaseDateDateEdit.Size = new System.Drawing.Size(355, 20);
            this.purchaseDateDateEdit.TabIndex = 5;
            // 
            // remarkTextBox
            // 
            this.remarkTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.vehicleBindingSource, "Remark", true));
            this.remarkTextBox.Location = new System.Drawing.Point(102, 173);
            this.remarkTextBox.Multiline = true;
            this.remarkTextBox.Name = "remarkTextBox";
            this.remarkTextBox.Size = new System.Drawing.Size(355, 98);
            this.remarkTextBox.TabIndex = 6;
            // 
            // SaveCommand
            // 
            this.SaveCommand.Location = new System.Drawing.Point(163, 281);
            this.SaveCommand.Name = "SaveCommand";
            this.SaveCommand.Size = new System.Drawing.Size(75, 23);
            this.SaveCommand.TabIndex = 7;
            this.SaveCommand.Text = "Save";
            this.SaveCommand.Click += new System.EventHandler(this.SaveCommand_Click);
            // 
            // CancelCommand
            // 
            this.CancelCommand.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.CancelCommand.Location = new System.Drawing.Point(245, 281);
            this.CancelCommand.Name = "CancelCommand";
            this.CancelCommand.Size = new System.Drawing.Size(75, 23);
            this.CancelCommand.TabIndex = 15;
            this.CancelCommand.Text = "Cancel";
            this.CancelCommand.Click += new System.EventHandler(this.CancelCommand_Click);
            // 
            // errorProvider1
            // 
            this.errorProvider1.ContainerControl = this;
            // 
            // NewVehicle
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CancelButton = this.CancelCommand;
            this.ClientSize = new System.Drawing.Size(482, 317);
            this.Controls.Add(this.CancelCommand);
            this.Controls.Add(this.SaveCommand);
            this.Controls.Add(remarkLabel);
            this.Controls.Add(this.remarkTextBox);
            this.Controls.Add(purchaseDateLabel);
            this.Controls.Add(this.purchaseDateDateEdit);
            this.Controls.Add(productionYearLabel);
            this.Controls.Add(this.productionYearTextBox);
            this.Controls.Add(ownershipIdLabel);
            this.Controls.Add(this.ownershipIdLookUpEdit);
            this.Controls.Add(makeIdLabel);
            this.Controls.Add(this.makeIdLookUpEdit);
            this.Controls.Add(modelIdLabel);
            this.Controls.Add(this.modelIdLookUpEdit);
            this.Controls.Add(plateNumberLabel);
            this.Controls.Add(this.plateNumberTextBox);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "NewVehicle";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "New Vehicle";
            ((System.ComponentModel.ISupportInitialize)(this.vehicleBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.modelIdLookUpEdit.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.modelBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.makeIdLookUpEdit.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.makeBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ownershipIdLookUpEdit.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ownershipBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.purchaseDateDateEdit.Properties.VistaTimeProperties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.purchaseDateDateEdit.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.BindingSource vehicleBindingSource;
        private System.Windows.Forms.TextBox plateNumberTextBox;
        private DevExpress.XtraEditors.LookUpEdit modelIdLookUpEdit;
        private DevExpress.XtraEditors.LookUpEdit makeIdLookUpEdit;
        private DevExpress.XtraEditors.LookUpEdit ownershipIdLookUpEdit;
        private System.Windows.Forms.TextBox productionYearTextBox;
        private DevExpress.XtraEditors.DateEdit purchaseDateDateEdit;
        private System.Windows.Forms.TextBox remarkTextBox;
        private DevExpress.XtraEditors.SimpleButton SaveCommand;
        private DevExpress.XtraEditors.SimpleButton CancelCommand;
        private System.Windows.Forms.BindingSource modelBindingSource;
        private System.Windows.Forms.BindingSource makeBindingSource;
        private System.Windows.Forms.BindingSource ownershipBindingSource;
        private System.Windows.Forms.ErrorProvider errorProvider1;
    }
}