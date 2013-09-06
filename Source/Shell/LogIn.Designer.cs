namespace ClearOffice.Infrastructure.Shell
{
    partial class LogIn
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(LogIn));
            this.okCommand = new System.Windows.Forms.Button();
            this.cancelCommand = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.errorProvider1 = new System.Windows.Forms.ErrorProvider(this.components);
            this.userTextEdit = new System.Windows.Forms.TextBox();
            this.passwordTextEdit = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).BeginInit();
            this.SuspendLayout();
            // 
            // okCommand
            // 
            this.okCommand.Location = new System.Drawing.Point(115, 124);
            this.okCommand.Name = "okCommand";
            this.okCommand.Size = new System.Drawing.Size(75, 23);
            this.okCommand.TabIndex = 2;
            this.okCommand.Text = "Ok";
            this.okCommand.UseVisualStyleBackColor = true;
            this.okCommand.Click += new System.EventHandler(this.okCommand_Click);
            // 
            // cancelCommand
            // 
            this.cancelCommand.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.cancelCommand.Location = new System.Drawing.Point(197, 124);
            this.cancelCommand.Name = "cancelCommand";
            this.cancelCommand.Size = new System.Drawing.Size(75, 23);
            this.cancelCommand.TabIndex = 3;
            this.cancelCommand.Text = "Cancel";
            this.cancelCommand.UseVisualStyleBackColor = true;
            this.cancelCommand.Click += new System.EventHandler(this.cancelCommand_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(54, 8);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(142, 19);
            this.label1.TabIndex = 2;
            this.label1.Text = "Enter your credentials";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(55, 29);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(215, 26);
            this.label3.TabIndex = 4;
            this.label3.Text = "These credentials will be used to connect to\r\nClearOffice server.";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(14, 70);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(61, 13);
            this.label2.TabIndex = 8;
            this.label2.Text = "User name:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(14, 96);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(56, 13);
            this.label4.TabIndex = 9;
            this.label4.Text = "Password:";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::ClearOffice.Infrastructure.Shell.Properties.Resources.UserKey_32x32;
            this.pictureBox1.Location = new System.Drawing.Point(12, 8);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(38, 38);
            this.pictureBox1.TabIndex = 7;
            this.pictureBox1.TabStop = false;
            // 
            // errorProvider1
            // 
            this.errorProvider1.ContainerControl = this;
            // 
            // userTextEdit
            // 
            this.userTextEdit.Location = new System.Drawing.Point(79, 70);
            this.userTextEdit.Name = "userTextEdit";
            this.userTextEdit.Size = new System.Drawing.Size(192, 20);
            this.userTextEdit.TabIndex = 0;
            // 
            // passwordTextEdit
            // 
            this.passwordTextEdit.Location = new System.Drawing.Point(79, 96);
            this.passwordTextEdit.Name = "passwordTextEdit";
            this.passwordTextEdit.PasswordChar = '*';
            this.passwordTextEdit.Size = new System.Drawing.Size(193, 20);
            this.passwordTextEdit.TabIndex = 1;
            // 
            // LogIn
            // 
            this.AcceptButton = this.okCommand;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.CancelButton = this.cancelCommand;
            this.ClientSize = new System.Drawing.Size(290, 162);
            this.Controls.Add(this.passwordTextEdit);
            this.Controls.Add(this.userTextEdit);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.cancelCommand);
            this.Controls.Add(this.okCommand);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "LogIn";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "ClearOffice Security";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button okCommand;
        private System.Windows.Forms.Button cancelCommand;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ErrorProvider errorProvider1;
        private System.Windows.Forms.TextBox passwordTextEdit;
        private System.Windows.Forms.TextBox userTextEdit;

    }
}