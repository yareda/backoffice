namespace ClearOffice.Fleet.Views
{
    partial class FuelLogEdit
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
            System.Windows.Forms.Label filledDateLabel;
            System.Windows.Forms.Label currentOdometerLabel;
            System.Windows.Forms.Label fuelAmountLabel;
            System.Windows.Forms.Label accountNoLabel;
            System.Windows.Forms.Label lastOdometerLabel;
            System.Windows.Forms.Label distanceCoveredLabel;
            System.Windows.Forms.Label totalCostLabel;
            System.Windows.Forms.Label remarkLabel;
            this.filledDateDateEdit = new DevExpress.XtraEditors.DateEdit();
            this.fuelLogBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.currentOdometerTextBox = new System.Windows.Forms.TextBox();
            this.fuelAmountTextBox = new System.Windows.Forms.TextBox();
            this.accountNoTextBox = new System.Windows.Forms.TextBox();
            this.lastOdometerTextBox = new System.Windows.Forms.TextBox();
            this.distanceCoveredTextBox = new System.Windows.Forms.TextBox();
            this.totalCostTextBox = new System.Windows.Forms.TextBox();
            this.remarkTextBox = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.plateNoTextBox = new System.Windows.Forms.TextBox();
            this.SaveCommand = new DevExpress.XtraEditors.SimpleButton();
            this.CancelCommand = new DevExpress.XtraEditors.SimpleButton();
            this.errorProvider1 = new System.Windows.Forms.ErrorProvider(this.components);
            filledDateLabel = new System.Windows.Forms.Label();
            currentOdometerLabel = new System.Windows.Forms.Label();
            fuelAmountLabel = new System.Windows.Forms.Label();
            accountNoLabel = new System.Windows.Forms.Label();
            lastOdometerLabel = new System.Windows.Forms.Label();
            distanceCoveredLabel = new System.Windows.Forms.Label();
            totalCostLabel = new System.Windows.Forms.Label();
            remarkLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.filledDateDateEdit.Properties.VistaTimeProperties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.filledDateDateEdit.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.fuelLogBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).BeginInit();
            this.SuspendLayout();
            // 
            // filledDateLabel
            // 
            filledDateLabel.AutoSize = true;
            filledDateLabel.Location = new System.Drawing.Point(8, 38);
            filledDateLabel.Name = "filledDateLabel";
            filledDateLabel.Size = new System.Drawing.Size(61, 13);
            filledDateLabel.TabIndex = 0;
            filledDateLabel.Text = "Filled Date:";
            // 
            // currentOdometerLabel
            // 
            currentOdometerLabel.AutoSize = true;
            currentOdometerLabel.Location = new System.Drawing.Point(222, 63);
            currentOdometerLabel.Name = "currentOdometerLabel";
            currentOdometerLabel.Size = new System.Drawing.Size(55, 26);
            currentOdometerLabel.TabIndex = 2;
            currentOdometerLabel.Text = "Odometer\r\nNow:";
            // 
            // fuelAmountLabel
            // 
            fuelAmountLabel.AutoSize = true;
            fuelAmountLabel.Location = new System.Drawing.Point(8, 119);
            fuelAmountLabel.Name = "fuelAmountLabel";
            fuelAmountLabel.Size = new System.Drawing.Size(67, 26);
            fuelAmountLabel.TabIndex = 4;
            fuelAmountLabel.Text = "Fuel Amount\r\n(In Lt.):";
            // 
            // accountNoLabel
            // 
            accountNoLabel.AutoSize = true;
            accountNoLabel.Location = new System.Drawing.Point(8, 150);
            accountNoLabel.Name = "accountNoLabel";
            accountNoLabel.Size = new System.Drawing.Size(66, 13);
            accountNoLabel.TabIndex = 6;
            accountNoLabel.Text = "Account No:";
            // 
            // lastOdometerLabel
            // 
            lastOdometerLabel.AutoSize = true;
            lastOdometerLabel.Location = new System.Drawing.Point(8, 63);
            lastOdometerLabel.Name = "lastOdometerLabel";
            lastOdometerLabel.Size = new System.Drawing.Size(82, 13);
            lastOdometerLabel.TabIndex = 8;
            lastOdometerLabel.Text = "Last Odometer:";
            // 
            // distanceCoveredLabel
            // 
            distanceCoveredLabel.AutoSize = true;
            distanceCoveredLabel.Location = new System.Drawing.Point(8, 90);
            distanceCoveredLabel.Name = "distanceCoveredLabel";
            distanceCoveredLabel.Size = new System.Drawing.Size(96, 13);
            distanceCoveredLabel.TabIndex = 10;
            distanceCoveredLabel.Text = "Distance Covered:";
            // 
            // totalCostLabel
            // 
            totalCostLabel.AutoSize = true;
            totalCostLabel.Location = new System.Drawing.Point(222, 119);
            totalCostLabel.Name = "totalCostLabel";
            totalCostLabel.Size = new System.Drawing.Size(56, 26);
            totalCostLabel.TabIndex = 12;
            totalCostLabel.Text = "Total Cost\r\n(In Birr):";
            // 
            // remarkLabel
            // 
            remarkLabel.AutoSize = true;
            remarkLabel.Location = new System.Drawing.Point(8, 181);
            remarkLabel.Name = "remarkLabel";
            remarkLabel.Size = new System.Drawing.Size(47, 13);
            remarkLabel.TabIndex = 14;
            remarkLabel.Text = "Remark:";
            // 
            // filledDateDateEdit
            // 
            this.filledDateDateEdit.DataBindings.Add(new System.Windows.Forms.Binding("EditValue", this.fuelLogBindingSource, "FilledDate", true));
            this.filledDateDateEdit.EditValue = null;
            this.filledDateDateEdit.Location = new System.Drawing.Point(105, 38);
            this.filledDateDateEdit.Name = "filledDateDateEdit";
            this.filledDateDateEdit.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.filledDateDateEdit.Properties.VistaTimeProperties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton()});
            this.filledDateDateEdit.Size = new System.Drawing.Size(287, 20);
            this.filledDateDateEdit.TabIndex = 1;
            // 
            // fuelLogBindingSource
            // 
            this.fuelLogBindingSource.DataSource = typeof(ClearOffice.Fleet.Business.FuelLog);
            this.fuelLogBindingSource.CurrentItemChanged += new System.EventHandler(this.fuelLogBindingSource_CurrentItemChanged);
            // 
            // currentOdometerTextBox
            // 
            this.currentOdometerTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.fuelLogBindingSource, "CurrentOdometer", true));
            this.currentOdometerTextBox.Location = new System.Drawing.Point(284, 63);
            this.currentOdometerTextBox.Name = "currentOdometerTextBox";
            this.currentOdometerTextBox.Size = new System.Drawing.Size(108, 21);
            this.currentOdometerTextBox.TabIndex = 3;
            // 
            // fuelAmountTextBox
            // 
            this.fuelAmountTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.fuelLogBindingSource, "FuelAmount", true));
            this.fuelAmountTextBox.Location = new System.Drawing.Point(105, 119);
            this.fuelAmountTextBox.Name = "fuelAmountTextBox";
            this.fuelAmountTextBox.Size = new System.Drawing.Size(100, 21);
            this.fuelAmountTextBox.TabIndex = 4;
            // 
            // accountNoTextBox
            // 
            this.accountNoTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.fuelLogBindingSource, "AccountNo", true));
            this.accountNoTextBox.Location = new System.Drawing.Point(105, 150);
            this.accountNoTextBox.Name = "accountNoTextBox";
            this.accountNoTextBox.Size = new System.Drawing.Size(100, 21);
            this.accountNoTextBox.TabIndex = 6;
            // 
            // lastOdometerTextBox
            // 
            this.lastOdometerTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.fuelLogBindingSource, "LastOdometer", true));
            this.lastOdometerTextBox.Location = new System.Drawing.Point(105, 63);
            this.lastOdometerTextBox.Name = "lastOdometerTextBox";
            this.lastOdometerTextBox.Size = new System.Drawing.Size(100, 21);
            this.lastOdometerTextBox.TabIndex = 2;
            // 
            // distanceCoveredTextBox
            // 
            this.distanceCoveredTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.fuelLogBindingSource, "DistanceCovered", true));
            this.distanceCoveredTextBox.Enabled = false;
            this.distanceCoveredTextBox.Location = new System.Drawing.Point(105, 90);
            this.distanceCoveredTextBox.Name = "distanceCoveredTextBox";
            this.distanceCoveredTextBox.Size = new System.Drawing.Size(100, 21);
            this.distanceCoveredTextBox.TabIndex = 11;
            // 
            // totalCostTextBox
            // 
            this.totalCostTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.fuelLogBindingSource, "TotalCost", true));
            this.totalCostTextBox.Location = new System.Drawing.Point(284, 119);
            this.totalCostTextBox.Name = "totalCostTextBox";
            this.totalCostTextBox.Size = new System.Drawing.Size(108, 21);
            this.totalCostTextBox.TabIndex = 5;
            // 
            // remarkTextBox
            // 
            this.remarkTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.fuelLogBindingSource, "Remark", true));
            this.remarkTextBox.Location = new System.Drawing.Point(105, 178);
            this.remarkTextBox.Multiline = true;
            this.remarkTextBox.Name = "remarkTextBox";
            this.remarkTextBox.Size = new System.Drawing.Size(287, 87);
            this.remarkTextBox.TabIndex = 7;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(8, 13);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(46, 13);
            this.label1.TabIndex = 16;
            this.label1.Text = "Plate #:";
            // 
            // plateNoTextBox
            // 
            this.plateNoTextBox.Enabled = false;
            this.plateNoTextBox.Location = new System.Drawing.Point(105, 13);
            this.plateNoTextBox.Name = "plateNoTextBox";
            this.plateNoTextBox.Size = new System.Drawing.Size(287, 21);
            this.plateNoTextBox.TabIndex = 0;
            // 
            // SaveCommand
            // 
            this.SaveCommand.Location = new System.Drawing.Point(123, 275);
            this.SaveCommand.Name = "SaveCommand";
            this.SaveCommand.Size = new System.Drawing.Size(75, 23);
            this.SaveCommand.TabIndex = 8;
            this.SaveCommand.Text = "Save";
            this.SaveCommand.Click += new System.EventHandler(this.SaveCommand_Click);
            // 
            // CancelCommand
            // 
            this.CancelCommand.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.CancelCommand.Location = new System.Drawing.Point(205, 275);
            this.CancelCommand.Name = "CancelCommand";
            this.CancelCommand.Size = new System.Drawing.Size(75, 23);
            this.CancelCommand.TabIndex = 9;
            this.CancelCommand.Text = "Cancel";
            this.CancelCommand.Click += new System.EventHandler(this.CancelCommand_Click);
            // 
            // errorProvider1
            // 
            this.errorProvider1.ContainerControl = this;
            this.errorProvider1.DataSource = this.fuelLogBindingSource;
            // 
            // FuelLogEdit
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CancelButton = this.CancelCommand;
            this.ClientSize = new System.Drawing.Size(402, 311);
            this.Controls.Add(this.CancelCommand);
            this.Controls.Add(this.SaveCommand);
            this.Controls.Add(this.plateNoTextBox);
            this.Controls.Add(this.label1);
            this.Controls.Add(remarkLabel);
            this.Controls.Add(this.remarkTextBox);
            this.Controls.Add(totalCostLabel);
            this.Controls.Add(this.totalCostTextBox);
            this.Controls.Add(distanceCoveredLabel);
            this.Controls.Add(this.distanceCoveredTextBox);
            this.Controls.Add(lastOdometerLabel);
            this.Controls.Add(this.lastOdometerTextBox);
            this.Controls.Add(accountNoLabel);
            this.Controls.Add(this.accountNoTextBox);
            this.Controls.Add(fuelAmountLabel);
            this.Controls.Add(this.fuelAmountTextBox);
            this.Controls.Add(currentOdometerLabel);
            this.Controls.Add(this.currentOdometerTextBox);
            this.Controls.Add(filledDateLabel);
            this.Controls.Add(this.filledDateDateEdit);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FuelLogEdit";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Fuel Log Information";
            ((System.ComponentModel.ISupportInitialize)(this.filledDateDateEdit.Properties.VistaTimeProperties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.filledDateDateEdit.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.fuelLogBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.BindingSource fuelLogBindingSource;
        private DevExpress.XtraEditors.DateEdit filledDateDateEdit;
        private System.Windows.Forms.TextBox currentOdometerTextBox;
        private System.Windows.Forms.TextBox fuelAmountTextBox;
        private System.Windows.Forms.TextBox accountNoTextBox;
        private System.Windows.Forms.TextBox lastOdometerTextBox;
        private System.Windows.Forms.TextBox distanceCoveredTextBox;
        private System.Windows.Forms.TextBox totalCostTextBox;
        private System.Windows.Forms.TextBox remarkTextBox;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox plateNoTextBox;
        private DevExpress.XtraEditors.SimpleButton SaveCommand;
        private DevExpress.XtraEditors.SimpleButton CancelCommand;
        private System.Windows.Forms.ErrorProvider errorProvider1;
    }
}