namespace ClearOffice.Wms.Views
{
    partial class LookupEdit
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
            System.Windows.Forms.Label descriptionLabel;
            System.Windows.Forms.Label codeLabel;
            System.Windows.Forms.Label nameLabel;
            this.errorProvider = new System.Windows.Forms.ErrorProvider(this.components);
            this.lookupItemBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.saveToolStripButton = new System.Windows.Forms.Button();
            this.nameTextBox = new System.Windows.Forms.TextBox();
            this.descriptionTextBox = new System.Windows.Forms.TextBox();
            this.codeTextBox = new System.Windows.Forms.TextBox();
            this.btnCancel = new System.Windows.Forms.Button();
            descriptionLabel = new System.Windows.Forms.Label();
            codeLabel = new System.Windows.Forms.Label();
            nameLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.lookupItemBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // descriptionLabel
            // 
            descriptionLabel.Anchor = System.Windows.Forms.AnchorStyles.None;
            descriptionLabel.AutoSize = true;
            descriptionLabel.Location = new System.Drawing.Point(14, 67);
            descriptionLabel.Name = "descriptionLabel";
            descriptionLabel.Size = new System.Drawing.Size(64, 13);
            descriptionLabel.TabIndex = 18;
            descriptionLabel.Text = "Description:";
            // 
            // codeLabel
            // 
            codeLabel.Anchor = System.Windows.Forms.AnchorStyles.None;
            codeLabel.AutoSize = true;
            codeLabel.Location = new System.Drawing.Point(14, 40);
            codeLabel.Name = "codeLabel";
            codeLabel.Size = new System.Drawing.Size(36, 13);
            codeLabel.TabIndex = 16;
            codeLabel.Text = "Code:";
            // 
            // nameLabel
            // 
            nameLabel.Anchor = System.Windows.Forms.AnchorStyles.None;
            nameLabel.AutoSize = true;
            nameLabel.Location = new System.Drawing.Point(12, 13);
            nameLabel.Name = "nameLabel";
            nameLabel.Size = new System.Drawing.Size(38, 13);
            nameLabel.TabIndex = 14;
            nameLabel.Text = "Name:";
            // 
            // errorProvider
            // 
            this.errorProvider.ContainerControl = this;
            // 
            // lookupItemBindingSource
            // 
            this.lookupItemBindingSource.DataSource = typeof(ClearOffice.Wms.Business.LookupItem);
            this.lookupItemBindingSource.CurrentChanged += new System.EventHandler(this.lookupItemBindingSource_CurrentChanged);
            // 
            // saveToolStripButton
            // 
            this.saveToolStripButton.Location = new System.Drawing.Point(159, 136);
            this.saveToolStripButton.Name = "saveToolStripButton";
            this.saveToolStripButton.Size = new System.Drawing.Size(75, 23);
            this.saveToolStripButton.TabIndex = 3;
            this.saveToolStripButton.Text = "Save";
            this.saveToolStripButton.UseVisualStyleBackColor = true;
            this.saveToolStripButton.Click += new System.EventHandler(this.saveToolStripButton_Click);
            // 
            // nameTextBox
            // 
            this.nameTextBox.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.nameTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.lookupItemBindingSource, "Name", true));
            this.nameTextBox.Location = new System.Drawing.Point(83, 10);
            this.nameTextBox.Name = "nameTextBox";
            this.nameTextBox.Size = new System.Drawing.Size(295, 21);
            this.nameTextBox.TabIndex = 15;
            // 
            // descriptionTextBox
            // 
            this.descriptionTextBox.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.descriptionTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.lookupItemBindingSource, "Description", true));
            this.descriptionTextBox.Location = new System.Drawing.Point(83, 64);
            this.descriptionTextBox.Multiline = true;
            this.descriptionTextBox.Name = "descriptionTextBox";
            this.descriptionTextBox.Size = new System.Drawing.Size(321, 66);
            this.descriptionTextBox.TabIndex = 19;
            // 
            // codeTextBox
            // 
            this.codeTextBox.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.codeTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.lookupItemBindingSource, "Code", true));
            this.codeTextBox.Location = new System.Drawing.Point(83, 37);
            this.codeTextBox.Name = "codeTextBox";
            this.codeTextBox.Size = new System.Drawing.Size(295, 21);
            this.codeTextBox.TabIndex = 17;
            // 
            // btnCancel
            // 
            this.btnCancel.Location = new System.Drawing.Point(240, 136);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(62, 23);
            this.btnCancel.TabIndex = 20;
            this.btnCancel.Text = "Cancel";
            this.btnCancel.UseVisualStyleBackColor = true;
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // LookupEdit
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.ClientSize = new System.Drawing.Size(416, 162);
            this.Controls.Add(this.btnCancel);
            this.Controls.Add(descriptionLabel);
            this.Controls.Add(this.nameTextBox);
            this.Controls.Add(codeLabel);
            this.Controls.Add(this.descriptionTextBox);
            this.Controls.Add(nameLabel);
            this.Controls.Add(this.codeTextBox);
            this.Controls.Add(this.saveToolStripButton);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "LookupEdit";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Lookup View";
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.lookupItemBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.BindingSource lookupItemBindingSource;
        private System.Windows.Forms.ErrorProvider errorProvider;
        private System.Windows.Forms.Button saveToolStripButton;
        private System.Windows.Forms.Button btnCancel;
        private System.Windows.Forms.TextBox nameTextBox;
        private System.Windows.Forms.TextBox descriptionTextBox;
        private System.Windows.Forms.TextBox codeTextBox;
    }
}