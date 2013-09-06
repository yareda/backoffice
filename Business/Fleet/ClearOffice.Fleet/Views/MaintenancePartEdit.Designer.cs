namespace ClearOffice.Fleet.Views
{
    partial class MaintenancePartEdit
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
            System.Windows.Forms.Label partNoLabel;
            System.Windows.Forms.Label descriptionLabel;
            System.Windows.Forms.Label replacedDateLabel;
            System.Windows.Forms.Label unitPriceLabel;
            System.Windows.Forms.Label quantityLabel;
            this.partNoTextEdit = new DevExpress.XtraEditors.TextEdit();
            this.descriptionMemoEdit = new DevExpress.XtraEditors.MemoEdit();
            this.replacedDateDateEdit = new DevExpress.XtraEditors.DateEdit();
            this.unitPriceTextEdit = new DevExpress.XtraEditors.TextEdit();
            this.quantityTextEdit = new DevExpress.XtraEditors.TextEdit();
            this.saveCommand = new DevExpress.XtraEditors.SimpleButton();
            this.cancelCommand = new DevExpress.XtraEditors.SimpleButton();
            this.errorProvider1 = new System.Windows.Forms.ErrorProvider(this.components);
            this.partBindingSource = new System.Windows.Forms.BindingSource(this.components);
            partNoLabel = new System.Windows.Forms.Label();
            descriptionLabel = new System.Windows.Forms.Label();
            replacedDateLabel = new System.Windows.Forms.Label();
            unitPriceLabel = new System.Windows.Forms.Label();
            quantityLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.partNoTextEdit.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.descriptionMemoEdit.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.replacedDateDateEdit.Properties.VistaTimeProperties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.replacedDateDateEdit.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.unitPriceTextEdit.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.quantityTextEdit.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.partBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // partNoLabel
            // 
            partNoLabel.AutoSize = true;
            partNoLabel.Location = new System.Drawing.Point(17, 15);
            partNoLabel.Name = "partNoLabel";
            partNoLabel.Size = new System.Drawing.Size(47, 13);
            partNoLabel.TabIndex = 0;
            partNoLabel.Text = "Part No:";
            // 
            // descriptionLabel
            // 
            descriptionLabel.AutoSize = true;
            descriptionLabel.Location = new System.Drawing.Point(17, 41);
            descriptionLabel.Name = "descriptionLabel";
            descriptionLabel.Size = new System.Drawing.Size(64, 13);
            descriptionLabel.TabIndex = 2;
            descriptionLabel.Text = "Description:";
            // 
            // replacedDateLabel
            // 
            replacedDateLabel.AutoSize = true;
            replacedDateLabel.Location = new System.Drawing.Point(17, 114);
            replacedDateLabel.Name = "replacedDateLabel";
            replacedDateLabel.Size = new System.Drawing.Size(81, 13);
            replacedDateLabel.TabIndex = 4;
            replacedDateLabel.Text = "Replaced Date:";
            // 
            // unitPriceLabel
            // 
            unitPriceLabel.AutoSize = true;
            unitPriceLabel.Location = new System.Drawing.Point(17, 140);
            unitPriceLabel.Name = "unitPriceLabel";
            unitPriceLabel.Size = new System.Drawing.Size(56, 13);
            unitPriceLabel.TabIndex = 6;
            unitPriceLabel.Text = "Unit Price:";
            // 
            // quantityLabel
            // 
            quantityLabel.AutoSize = true;
            quantityLabel.Location = new System.Drawing.Point(17, 166);
            quantityLabel.Name = "quantityLabel";
            quantityLabel.Size = new System.Drawing.Size(53, 13);
            quantityLabel.TabIndex = 8;
            quantityLabel.Text = "Quantity:";
            // 
            // partNoTextEdit
            // 
            this.partNoTextEdit.DataBindings.Add(new System.Windows.Forms.Binding("EditValue", this.partBindingSource, "PartNo", true));
            this.partNoTextEdit.Location = new System.Drawing.Point(100, 12);
            this.partNoTextEdit.Name = "partNoTextEdit";
            this.partNoTextEdit.Size = new System.Drawing.Size(250, 20);
            this.partNoTextEdit.TabIndex = 1;
            // 
            // descriptionMemoEdit
            // 
            this.descriptionMemoEdit.DataBindings.Add(new System.Windows.Forms.Binding("EditValue", this.partBindingSource, "Description", true));
            this.descriptionMemoEdit.Location = new System.Drawing.Point(100, 38);
            this.descriptionMemoEdit.Name = "descriptionMemoEdit";
            this.descriptionMemoEdit.Size = new System.Drawing.Size(250, 67);
            this.descriptionMemoEdit.TabIndex = 3;
            // 
            // replacedDateDateEdit
            // 
            this.replacedDateDateEdit.DataBindings.Add(new System.Windows.Forms.Binding("EditValue", this.partBindingSource, "ReplacedDate", true));
            this.replacedDateDateEdit.EditValue = null;
            this.replacedDateDateEdit.Location = new System.Drawing.Point(100, 111);
            this.replacedDateDateEdit.Name = "replacedDateDateEdit";
            this.replacedDateDateEdit.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.replacedDateDateEdit.Properties.VistaTimeProperties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton()});
            this.replacedDateDateEdit.Size = new System.Drawing.Size(250, 20);
            this.replacedDateDateEdit.TabIndex = 5;
            // 
            // unitPriceTextEdit
            // 
            this.unitPriceTextEdit.DataBindings.Add(new System.Windows.Forms.Binding("EditValue", this.partBindingSource, "UnitPrice", true));
            this.unitPriceTextEdit.Location = new System.Drawing.Point(100, 137);
            this.unitPriceTextEdit.Name = "unitPriceTextEdit";
            this.unitPriceTextEdit.Size = new System.Drawing.Size(156, 20);
            this.unitPriceTextEdit.TabIndex = 7;
            // 
            // quantityTextEdit
            // 
            this.quantityTextEdit.DataBindings.Add(new System.Windows.Forms.Binding("EditValue", this.partBindingSource, "Quantity", true));
            this.quantityTextEdit.Location = new System.Drawing.Point(100, 163);
            this.quantityTextEdit.Name = "quantityTextEdit";
            this.quantityTextEdit.Size = new System.Drawing.Size(156, 20);
            this.quantityTextEdit.TabIndex = 9;
            // 
            // saveCommand
            // 
            this.saveCommand.Location = new System.Drawing.Point(100, 200);
            this.saveCommand.Name = "saveCommand";
            this.saveCommand.Size = new System.Drawing.Size(75, 23);
            this.saveCommand.TabIndex = 10;
            this.saveCommand.Text = "Ok";
            this.saveCommand.Click += new System.EventHandler(this.saveCommand_Click);
            // 
            // cancelCommand
            // 
            this.cancelCommand.Location = new System.Drawing.Point(194, 200);
            this.cancelCommand.Name = "cancelCommand";
            this.cancelCommand.Size = new System.Drawing.Size(75, 23);
            this.cancelCommand.TabIndex = 11;
            this.cancelCommand.Text = "Cancel";
            this.cancelCommand.Click += new System.EventHandler(this.cancelCommand_Click);
            // 
            // errorProvider1
            // 
            this.errorProvider1.ContainerControl = this;
            this.errorProvider1.DataSource = this.partBindingSource;
            // 
            // partBindingSource
            // 
            this.partBindingSource.DataSource = typeof(ClearOffice.Fleet.Business.MaintenancePart);
            this.partBindingSource.CurrentItemChanged += new System.EventHandler(this.partBindingSource_CurrentItemChanged);
            // 
            // MaintenancePartEdit
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(369, 235);
            this.Controls.Add(this.cancelCommand);
            this.Controls.Add(this.saveCommand);
            this.Controls.Add(quantityLabel);
            this.Controls.Add(this.quantityTextEdit);
            this.Controls.Add(unitPriceLabel);
            this.Controls.Add(this.unitPriceTextEdit);
            this.Controls.Add(replacedDateLabel);
            this.Controls.Add(this.replacedDateDateEdit);
            this.Controls.Add(descriptionLabel);
            this.Controls.Add(this.descriptionMemoEdit);
            this.Controls.Add(partNoLabel);
            this.Controls.Add(this.partNoTextEdit);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "MaintenancePartEdit";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Maintenance Part";
            ((System.ComponentModel.ISupportInitialize)(this.partNoTextEdit.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.descriptionMemoEdit.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.replacedDateDateEdit.Properties.VistaTimeProperties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.replacedDateDateEdit.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.unitPriceTextEdit.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.quantityTextEdit.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.partBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.BindingSource partBindingSource;
        private DevExpress.XtraEditors.TextEdit partNoTextEdit;
        private DevExpress.XtraEditors.MemoEdit descriptionMemoEdit;
        private DevExpress.XtraEditors.DateEdit replacedDateDateEdit;
        private DevExpress.XtraEditors.TextEdit unitPriceTextEdit;
        private DevExpress.XtraEditors.TextEdit quantityTextEdit;
        private DevExpress.XtraEditors.SimpleButton saveCommand;
        private DevExpress.XtraEditors.SimpleButton cancelCommand;
        private System.Windows.Forms.ErrorProvider errorProvider1;
    }
}