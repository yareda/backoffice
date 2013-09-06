namespace ClearOffice.Security.Views
{
    partial class SetPasswordView
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
            this.labelControl1 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl2 = new DevExpress.XtraEditors.LabelControl();
            this.passwordTextEdit = new DevExpress.XtraEditors.TextEdit();
            this.confirmPasswordTextEdit = new DevExpress.XtraEditors.TextEdit();
            this.cancelCommand = new DevExpress.XtraEditors.SimpleButton();
            this.okCommand = new DevExpress.XtraEditors.SimpleButton();
            ((System.ComponentModel.ISupportInitialize)(this.passwordTextEdit.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.confirmPasswordTextEdit.Properties)).BeginInit();
            this.SuspendLayout();
            // 
            // labelControl1
            // 
            this.labelControl1.Location = new System.Drawing.Point(13, 23);
            this.labelControl1.Name = "labelControl1";
            this.labelControl1.Size = new System.Drawing.Size(74, 13);
            this.labelControl1.TabIndex = 0;
            this.labelControl1.Text = "New password:";
            // 
            // labelControl2
            // 
            this.labelControl2.Location = new System.Drawing.Point(13, 50);
            this.labelControl2.Name = "labelControl2";
            this.labelControl2.Size = new System.Drawing.Size(90, 13);
            this.labelControl2.TabIndex = 1;
            this.labelControl2.Text = "Confirm password:";
            // 
            // passwordTextEdit
            // 
            this.passwordTextEdit.Location = new System.Drawing.Point(109, 19);
            this.passwordTextEdit.Name = "passwordTextEdit";
            this.passwordTextEdit.Properties.PasswordChar = '*';
            this.passwordTextEdit.Size = new System.Drawing.Size(192, 20);
            this.passwordTextEdit.TabIndex = 2;
            // 
            // confirmPasswordTextEdit
            // 
            this.confirmPasswordTextEdit.Location = new System.Drawing.Point(109, 46);
            this.confirmPasswordTextEdit.Name = "confirmPasswordTextEdit";
            this.confirmPasswordTextEdit.Properties.PasswordChar = '*';
            this.confirmPasswordTextEdit.Size = new System.Drawing.Size(192, 20);
            this.confirmPasswordTextEdit.TabIndex = 3;
            // 
            // cancelCommand
            // 
            this.cancelCommand.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.cancelCommand.Location = new System.Drawing.Point(161, 84);
            this.cancelCommand.Name = "cancelCommand";
            this.cancelCommand.Size = new System.Drawing.Size(75, 23);
            this.cancelCommand.TabIndex = 4;
            this.cancelCommand.Text = "Cancel";
            this.cancelCommand.Click += new System.EventHandler(this.cancelCommand_Click);
            // 
            // okCommand
            // 
            this.okCommand.Location = new System.Drawing.Point(80, 84);
            this.okCommand.Name = "okCommand";
            this.okCommand.Size = new System.Drawing.Size(75, 23);
            this.okCommand.TabIndex = 5;
            this.okCommand.Text = "Ok";
            this.okCommand.Click += new System.EventHandler(this.okCommand_Click);
            // 
            // SetPasswordView
            // 
            this.AcceptButton = this.okCommand;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CancelButton = this.cancelCommand;
            this.ClientSize = new System.Drawing.Size(317, 122);
            this.Controls.Add(this.okCommand);
            this.Controls.Add(this.cancelCommand);
            this.Controls.Add(this.confirmPasswordTextEdit);
            this.Controls.Add(this.passwordTextEdit);
            this.Controls.Add(this.labelControl2);
            this.Controls.Add(this.labelControl1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "SetPasswordView";
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "SetPasswordView";
            ((System.ComponentModel.ISupportInitialize)(this.passwordTextEdit.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.confirmPasswordTextEdit.Properties)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private DevExpress.XtraEditors.LabelControl labelControl1;
        private DevExpress.XtraEditors.LabelControl labelControl2;
        private DevExpress.XtraEditors.TextEdit passwordTextEdit;
        private DevExpress.XtraEditors.TextEdit confirmPasswordTextEdit;
        private DevExpress.XtraEditors.SimpleButton cancelCommand;
        private DevExpress.XtraEditors.SimpleButton okCommand;
    }
}