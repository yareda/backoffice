namespace ClearOffice.Fleet.Views
{
    partial class LookUpItemView
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
            System.Windows.Forms.Label itemNameLabel;
            this.lookUpItemBindingSource = new System.Windows.Forms.BindingSource();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.itemNameTextBox = new System.Windows.Forms.TextBox();
            this.lookupItemErrorProvider = new System.Windows.Forms.ErrorProvider();
            this.saveCommand = new DevExpress.XtraEditors.SimpleButton();
            this.cancelCommand = new DevExpress.XtraEditors.SimpleButton();
            itemNameLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.lookUpItemBindingSource)).BeginInit();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.lookupItemErrorProvider)).BeginInit();
            this.SuspendLayout();
            // 
            // itemNameLabel
            // 
            itemNameLabel.AutoSize = true;
            itemNameLabel.Location = new System.Drawing.Point(31, 27);
            itemNameLabel.Name = "itemNameLabel";
            itemNameLabel.Size = new System.Drawing.Size(38, 13);
            itemNameLabel.TabIndex = 2;
            itemNameLabel.Text = "Name:";
            // 
            // lookUpItemBindingSource
            // 
            this.lookUpItemBindingSource.DataSource = typeof(ClearOffice.Fleet.Business.LookupItem);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(itemNameLabel);
            this.groupBox1.Controls.Add(this.itemNameTextBox);
            this.groupBox1.Location = new System.Drawing.Point(7, 4);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(350, 69);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Item Information";
            // 
            // itemNameTextBox
            // 
            this.itemNameTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.lookUpItemBindingSource, "ItemName", true));
            this.itemNameTextBox.Location = new System.Drawing.Point(75, 24);
            this.itemNameTextBox.Name = "itemNameTextBox";
            this.itemNameTextBox.Size = new System.Drawing.Size(233, 21);
            this.itemNameTextBox.TabIndex = 3;
            // 
            // lookupItemErrorProvider
            // 
            this.lookupItemErrorProvider.ContainerControl = this;
            // 
            // saveCommand
            // 
            this.saveCommand.Location = new System.Drawing.Point(104, 79);
            this.saveCommand.Name = "saveCommand";
            this.saveCommand.Size = new System.Drawing.Size(75, 23);
            this.saveCommand.TabIndex = 2;
            this.saveCommand.Text = "Ok";
            this.saveCommand.Click += new System.EventHandler(this.saveCommand_Click);
            // 
            // cancelCommand
            // 
            this.cancelCommand.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.cancelCommand.Location = new System.Drawing.Point(185, 79);
            this.cancelCommand.Name = "cancelCommand";
            this.cancelCommand.Size = new System.Drawing.Size(75, 23);
            this.cancelCommand.TabIndex = 3;
            this.cancelCommand.Text = "Cancel";
            this.cancelCommand.Click += new System.EventHandler(this.cancelCommand_Click);
            // 
            // LookUpItemView
            // 
            this.AcceptButton = this.saveCommand;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CancelButton = this.cancelCommand;
            this.ClientSize = new System.Drawing.Size(364, 111);
            this.Controls.Add(this.cancelCommand);
            this.Controls.Add(this.saveCommand);
            this.Controls.Add(this.groupBox1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "LookUpItemView";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "LookUpItemView";
            ((System.ComponentModel.ISupportInitialize)(this.lookUpItemBindingSource)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.lookupItemErrorProvider)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.BindingSource lookUpItemBindingSource;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox itemNameTextBox;
        private System.Windows.Forms.ErrorProvider lookupItemErrorProvider;
        private DevExpress.XtraEditors.SimpleButton cancelCommand;
        private DevExpress.XtraEditors.SimpleButton saveCommand;
    }
}