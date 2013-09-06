namespace ClearOffice.Security.Views
{
    partial class CreateUserView
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
            System.Windows.Forms.Label userNameLabel;
            System.Windows.Forms.Label fullNameLabel;
            System.Windows.Forms.Label passwordLabel;
            this.userDetailBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.userNameTextEdit = new DevExpress.XtraEditors.TextEdit();
            this.fullNameTextEdit = new DevExpress.XtraEditors.TextEdit();
            this.passwordTextEdit = new DevExpress.XtraEditors.TextEdit();
            this.labelControl1 = new DevExpress.XtraEditors.LabelControl();
            this.confirmPasswordTextEdit = new DevExpress.XtraEditors.TextEdit();
            this.passwordNeverExpiresCheckEdit = new DevExpress.XtraEditors.CheckEdit();
            this.canNotChangePasswordCheckEdit = new DevExpress.XtraEditors.CheckEdit();
            this.closeCommand = new DevExpress.XtraEditors.SimpleButton();
            this.createCommand = new DevExpress.XtraEditors.SimpleButton();
            this.errorProvider1 = new System.Windows.Forms.ErrorProvider(this.components);
            userNameLabel = new System.Windows.Forms.Label();
            fullNameLabel = new System.Windows.Forms.Label();
            passwordLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.userDetailBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.userNameTextEdit.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.fullNameTextEdit.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.passwordTextEdit.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.confirmPasswordTextEdit.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.passwordNeverExpiresCheckEdit.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.canNotChangePasswordCheckEdit.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).BeginInit();
            this.SuspendLayout();
            // 
            // userNameLabel
            // 
            userNameLabel.AutoSize = true;
            userNameLabel.Location = new System.Drawing.Point(19, 15);
            userNameLabel.Name = "userNameLabel";
            userNameLabel.Size = new System.Drawing.Size(63, 13);
            userNameLabel.TabIndex = 0;
            userNameLabel.Text = "User Name:";
            // 
            // fullNameLabel
            // 
            fullNameLabel.AutoSize = true;
            fullNameLabel.Location = new System.Drawing.Point(19, 41);
            fullNameLabel.Name = "fullNameLabel";
            fullNameLabel.Size = new System.Drawing.Size(57, 13);
            fullNameLabel.TabIndex = 2;
            fullNameLabel.Text = "Full Name:";
            // 
            // passwordLabel
            // 
            passwordLabel.AutoSize = true;
            passwordLabel.Location = new System.Drawing.Point(19, 71);
            passwordLabel.Name = "passwordLabel";
            passwordLabel.Size = new System.Drawing.Size(57, 13);
            passwordLabel.TabIndex = 4;
            passwordLabel.Text = "Password:";
            // 
            // userDetailBindingSource
            // 
            this.userDetailBindingSource.DataSource = typeof(ClearOffice.Security.Data.User);
            this.userDetailBindingSource.CurrentItemChanged += new System.EventHandler(this.userDetailBindingSource_CurrentItemChanged);
            // 
            // userNameTextEdit
            // 
            this.userNameTextEdit.DataBindings.Add(new System.Windows.Forms.Binding("EditValue", this.userDetailBindingSource, "UserName", true, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged));
            this.userNameTextEdit.Location = new System.Drawing.Point(85, 12);
            this.userNameTextEdit.Name = "userNameTextEdit";
            this.userNameTextEdit.Size = new System.Drawing.Size(177, 20);
            this.userNameTextEdit.TabIndex = 1;
            // 
            // fullNameTextEdit
            // 
            this.fullNameTextEdit.DataBindings.Add(new System.Windows.Forms.Binding("EditValue", this.userDetailBindingSource, "FullName", true, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged));
            this.fullNameTextEdit.Location = new System.Drawing.Point(85, 38);
            this.fullNameTextEdit.Name = "fullNameTextEdit";
            this.fullNameTextEdit.Size = new System.Drawing.Size(177, 20);
            this.fullNameTextEdit.TabIndex = 3;
            // 
            // passwordTextEdit
            // 
            this.passwordTextEdit.DataBindings.Add(new System.Windows.Forms.Binding("EditValue", this.userDetailBindingSource, "Password", true));
            this.passwordTextEdit.Location = new System.Drawing.Point(115, 68);
            this.passwordTextEdit.Name = "passwordTextEdit";
            this.passwordTextEdit.Properties.PasswordChar = '*';
            this.passwordTextEdit.Size = new System.Drawing.Size(147, 20);
            this.passwordTextEdit.TabIndex = 5;
            // 
            // labelControl1
            // 
            this.labelControl1.Location = new System.Drawing.Point(19, 97);
            this.labelControl1.Name = "labelControl1";
            this.labelControl1.Size = new System.Drawing.Size(90, 13);
            this.labelControl1.TabIndex = 6;
            this.labelControl1.Text = "Confirm password:";
            // 
            // confirmPasswordTextEdit
            // 
            this.confirmPasswordTextEdit.Location = new System.Drawing.Point(115, 94);
            this.confirmPasswordTextEdit.Name = "confirmPasswordTextEdit";
            this.confirmPasswordTextEdit.Properties.PasswordChar = '*';
            this.confirmPasswordTextEdit.Size = new System.Drawing.Size(147, 20);
            this.confirmPasswordTextEdit.TabIndex = 7;
            // 
            // passwordNeverExpiresCheckEdit
            // 
            this.passwordNeverExpiresCheckEdit.DataBindings.Add(new System.Windows.Forms.Binding("EditValue", this.userDetailBindingSource, "PasswordNeverExpires", true));
            this.passwordNeverExpiresCheckEdit.Location = new System.Drawing.Point(20, 138);
            this.passwordNeverExpiresCheckEdit.Name = "passwordNeverExpiresCheckEdit";
            this.passwordNeverExpiresCheckEdit.Properties.Caption = "Password never expires";
            this.passwordNeverExpiresCheckEdit.Size = new System.Drawing.Size(218, 19);
            this.passwordNeverExpiresCheckEdit.TabIndex = 9;
            // 
            // canNotChangePasswordCheckEdit
            // 
            this.canNotChangePasswordCheckEdit.DataBindings.Add(new System.Windows.Forms.Binding("EditValue", this.userDetailBindingSource, "CanNotChangePassword", true));
            this.canNotChangePasswordCheckEdit.Location = new System.Drawing.Point(20, 163);
            this.canNotChangePasswordCheckEdit.Name = "canNotChangePasswordCheckEdit";
            this.canNotChangePasswordCheckEdit.Properties.Caption = "User can not change password";
            this.canNotChangePasswordCheckEdit.Size = new System.Drawing.Size(203, 19);
            this.canNotChangePasswordCheckEdit.TabIndex = 10;
            // 
            // closeCommand
            // 
            this.closeCommand.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.closeCommand.Location = new System.Drawing.Point(187, 202);
            this.closeCommand.Name = "closeCommand";
            this.closeCommand.Size = new System.Drawing.Size(75, 23);
            this.closeCommand.TabIndex = 11;
            this.closeCommand.Text = "Close";
            this.closeCommand.Click += new System.EventHandler(this.closeCommand_Click);
            // 
            // createCommand
            // 
            this.createCommand.Location = new System.Drawing.Point(106, 202);
            this.createCommand.Name = "createCommand";
            this.createCommand.Size = new System.Drawing.Size(75, 23);
            this.createCommand.TabIndex = 12;
            this.createCommand.Text = "Create";
            this.createCommand.Click += new System.EventHandler(this.createCommand_Click);
            // 
            // errorProvider1
            // 
            this.errorProvider1.ContainerControl = this;
            this.errorProvider1.DataSource = this.userDetailBindingSource;
            // 
            // CreateUserView
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CancelButton = this.closeCommand;
            this.ClientSize = new System.Drawing.Size(283, 238);
            this.Controls.Add(this.createCommand);
            this.Controls.Add(this.closeCommand);
            this.Controls.Add(this.canNotChangePasswordCheckEdit);
            this.Controls.Add(this.passwordNeverExpiresCheckEdit);
            this.Controls.Add(this.confirmPasswordTextEdit);
            this.Controls.Add(this.labelControl1);
            this.Controls.Add(passwordLabel);
            this.Controls.Add(this.passwordTextEdit);
            this.Controls.Add(fullNameLabel);
            this.Controls.Add(this.fullNameTextEdit);
            this.Controls.Add(userNameLabel);
            this.Controls.Add(this.userNameTextEdit);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "CreateUserView";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "User Information";
            ((System.ComponentModel.ISupportInitialize)(this.userDetailBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.userNameTextEdit.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.fullNameTextEdit.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.passwordTextEdit.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.confirmPasswordTextEdit.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.passwordNeverExpiresCheckEdit.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.canNotChangePasswordCheckEdit.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.BindingSource userDetailBindingSource;
        private DevExpress.XtraEditors.TextEdit userNameTextEdit;
        private DevExpress.XtraEditors.TextEdit fullNameTextEdit;
        private DevExpress.XtraEditors.TextEdit passwordTextEdit;
        private DevExpress.XtraEditors.LabelControl labelControl1;
        private DevExpress.XtraEditors.TextEdit confirmPasswordTextEdit;
        private DevExpress.XtraEditors.CheckEdit passwordNeverExpiresCheckEdit;
        private DevExpress.XtraEditors.CheckEdit canNotChangePasswordCheckEdit;
        private DevExpress.XtraEditors.SimpleButton closeCommand;
        private DevExpress.XtraEditors.SimpleButton createCommand;
        private System.Windows.Forms.ErrorProvider errorProvider1;
    }
}