namespace ClearOffice.Wms.Views
{
	partial class LookUpDetail
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
            System.Windows.Forms.Label descriptionLabel;
            System.Windows.Forms.Label codeLabel;
            System.Windows.Forms.Label nameLabel;
            this.lookupItemBindingSource = new System.Windows.Forms.BindingSource();
            this.errorProvider = new System.Windows.Forms.ErrorProvider();
            this.saveToolStripButton = new System.Windows.Forms.Button();
            this.descriptionTextBox = new System.Windows.Forms.TextBox();
            this.codeTextBox = new System.Windows.Forms.TextBox();
            this.nameTextBox = new System.Windows.Forms.TextBox();
            this.Cancel = new System.Windows.Forms.Button();
            descriptionLabel = new System.Windows.Forms.Label();
            codeLabel = new System.Windows.Forms.Label();
            nameLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.lookupItemBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider)).BeginInit();
            this.SuspendLayout();
            // 
            // descriptionLabel
            // 
            descriptionLabel.AutoSize = true;
            descriptionLabel.Location = new System.Drawing.Point(21, 65);
            descriptionLabel.Name = "descriptionLabel";
            descriptionLabel.Size = new System.Drawing.Size(64, 13);
            descriptionLabel.TabIndex = 10;
            descriptionLabel.Text = "Description:";
            // 
            // codeLabel
            // 
            codeLabel.AutoSize = true;
            codeLabel.Location = new System.Drawing.Point(21, 40);
            codeLabel.Name = "codeLabel";
            codeLabel.Size = new System.Drawing.Size(36, 13);
            codeLabel.TabIndex = 8;
            codeLabel.Text = "Code:";
            // 
            // nameLabel
            // 
            nameLabel.AutoSize = true;
            nameLabel.Location = new System.Drawing.Point(21, 15);
            nameLabel.Name = "nameLabel";
            nameLabel.Size = new System.Drawing.Size(38, 13);
            nameLabel.TabIndex = 6;
            nameLabel.Text = "Name:";
            // 
            // lookupItemBindingSource
            // 
            this.lookupItemBindingSource.DataSource = typeof(ClearOffice.Wms.Business.LookupItem);
            this.lookupItemBindingSource.CurrentChanged += new System.EventHandler(this.lookupItemBindingSource_CurrentChanged);
            // 
            // errorProvider
            // 
            this.errorProvider.ContainerControl = this;
            // 
            // saveToolStripButton
            // 
            this.saveToolStripButton.Location = new System.Drawing.Point(147, 140);
            this.saveToolStripButton.Name = "saveToolStripButton";
            this.saveToolStripButton.Size = new System.Drawing.Size(83, 23);
            this.saveToolStripButton.TabIndex = 2;
            this.saveToolStripButton.Text = "Save";
            this.saveToolStripButton.UseVisualStyleBackColor = true;
            this.saveToolStripButton.Click += new System.EventHandler(this.saveToolStripButton_Click);
            // 
            // descriptionTextBox
            // 
            this.descriptionTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.lookupItemBindingSource, "Description", true));
            this.descriptionTextBox.Location = new System.Drawing.Point(91, 63);
            this.descriptionTextBox.Multiline = true;
            this.descriptionTextBox.Name = "descriptionTextBox";
            this.descriptionTextBox.Size = new System.Drawing.Size(329, 71);
            this.descriptionTextBox.TabIndex = 11;
            // 
            // codeTextBox
            // 
            this.codeTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.lookupItemBindingSource, "Code", true));
            this.codeTextBox.Location = new System.Drawing.Point(91, 37);
            this.codeTextBox.Name = "codeTextBox";
            this.codeTextBox.Size = new System.Drawing.Size(293, 21);
            this.codeTextBox.TabIndex = 9;
            // 
            // nameTextBox
            // 
            this.nameTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.lookupItemBindingSource, "Name", true));
            this.nameTextBox.Location = new System.Drawing.Point(91, 12);
            this.nameTextBox.Name = "nameTextBox";
            this.nameTextBox.Size = new System.Drawing.Size(293, 21);
            this.nameTextBox.TabIndex = 7;
            // 
            // Cancel
            // 
            this.Cancel.Location = new System.Drawing.Point(251, 140);
            this.Cancel.Name = "Cancel";
            this.Cancel.Size = new System.Drawing.Size(75, 23);
            this.Cancel.TabIndex = 12;
            this.Cancel.Text = "Cancel";
            this.Cancel.UseVisualStyleBackColor = true;
            // 
            // LookUpDetail
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.ClientSize = new System.Drawing.Size(429, 166);
            this.Controls.Add(this.Cancel);
            this.Controls.Add(descriptionLabel);
            this.Controls.Add(this.descriptionTextBox);
            this.Controls.Add(codeLabel);
            this.Controls.Add(this.codeTextBox);
            this.Controls.Add(nameLabel);
            this.Controls.Add(this.nameTextBox);
            this.Controls.Add(this.saveToolStripButton);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "LookUpDetail";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Edit Look up item";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.LookUpDetail_FormClosed);
            ((System.ComponentModel.ISupportInitialize)(this.lookupItemBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

		}

		#endregion

        private System.Windows.Forms.BindingSource lookupItemBindingSource;
        private System.Windows.Forms.ErrorProvider errorProvider;
        private System.Windows.Forms.Button saveToolStripButton;
        private System.Windows.Forms.Button Cancel;
        private System.Windows.Forms.TextBox descriptionTextBox;
        private System.Windows.Forms.TextBox codeTextBox;
        private System.Windows.Forms.TextBox nameTextBox;
	}
}