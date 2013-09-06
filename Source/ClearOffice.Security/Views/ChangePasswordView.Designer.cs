namespace ClearOffice.Security.Views
{
    partial class ChangePasswordView
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
            this.simpleButton1 = new DevExpress.XtraEditors.SimpleButton();
            this.cancelCommand = new DevExpress.XtraEditors.SimpleButton();
            this.labelControl1 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl2 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl3 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl4 = new DevExpress.XtraEditors.LabelControl();
            this.userNameTextEdit = new DevExpress.XtraEditors.TextEdit();
            this.oldPasswordTextEdit = new DevExpress.XtraEditors.TextEdit();
            this.newPasswordTextEdit = new DevExpress.XtraEditors.TextEdit();
            this.confirmTextEdit = new DevExpress.XtraEditors.TextEdit();
            this.errorProvider1 = new System.Windows.Forms.ErrorProvider();
            ((System.ComponentModel.ISupportInitialize)(this.userNameTextEdit.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.oldPasswordTextEdit.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.newPasswordTextEdit.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.confirmTextEdit.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).BeginInit();
            this.SuspendLayout();
            // 
            // simpleButton1
            // 
            this.simpleButton1.Location = new System.Drawing.Point(108, 109);
            this.simpleButton1.Name = "simpleButton1";
            this.simpleButton1.Size = new System.Drawing.Size(75, 23);
            this.simpleButton1.TabIndex = 0;
            this.simpleButton1.Text = "Ok";
            this.simpleButton1.Click += new System.EventHandler(this.simpleButton1_Click);
            // 
            // cancelCommand
            // 
            this.cancelCommand.Location = new System.Drawing.Point(190, 109);
            this.cancelCommand.Name = "cancelCommand";
            this.cancelCommand.Size = new System.Drawing.Size(75, 23);
            this.cancelCommand.TabIndex = 1;
            this.cancelCommand.Text = "Cancel";
            this.cancelCommand.Click += new System.EventHandler(this.cancelCommand_Click);
            // 
            // labelControl1
            // 
            this.labelControl1.Location = new System.Drawing.Point(11, 11);
            this.labelControl1.Name = "labelControl1";
            this.labelControl1.Size = new System.Drawing.Size(55, 13);
            this.labelControl1.TabIndex = 2;
            this.labelControl1.Text = "User name:";
            // 
            // labelControl2
            // 
            this.labelControl2.Location = new System.Drawing.Point(11, 34);
            this.labelControl2.Name = "labelControl2";
            this.labelControl2.Size = new System.Drawing.Size(69, 13);
            this.labelControl2.TabIndex = 3;
            this.labelControl2.Text = "Old password:";
            // 
            // labelControl3
            // 
            this.labelControl3.Location = new System.Drawing.Point(11, 59);
            this.labelControl3.Name = "labelControl3";
            this.labelControl3.Size = new System.Drawing.Size(74, 13);
            this.labelControl3.TabIndex = 4;
            this.labelControl3.Text = "New password:";
            // 
            // labelControl4
            // 
            this.labelControl4.Location = new System.Drawing.Point(11, 83);
            this.labelControl4.Name = "labelControl4";
            this.labelControl4.Size = new System.Drawing.Size(90, 13);
            this.labelControl4.TabIndex = 5;
            this.labelControl4.Text = "Confirm password:";
            // 
            // userNameTextEdit
            // 
            this.userNameTextEdit.Enabled = false;
            this.userNameTextEdit.Location = new System.Drawing.Point(106, 11);
            this.userNameTextEdit.Name = "userNameTextEdit";
            this.userNameTextEdit.Size = new System.Drawing.Size(200, 20);
            this.userNameTextEdit.TabIndex = 6;
            // 
            // oldPasswordTextEdit
            // 
            this.oldPasswordTextEdit.Location = new System.Drawing.Point(106, 34);
            this.oldPasswordTextEdit.Name = "oldPasswordTextEdit";
            this.oldPasswordTextEdit.Size = new System.Drawing.Size(200, 20);
            this.oldPasswordTextEdit.TabIndex = 7;
            // 
            // newPasswordTextEdit
            // 
            this.newPasswordTextEdit.Location = new System.Drawing.Point(106, 59);
            this.newPasswordTextEdit.Name = "newPasswordTextEdit";
            this.newPasswordTextEdit.Size = new System.Drawing.Size(200, 20);
            this.newPasswordTextEdit.TabIndex = 8;
            // 
            // confirmTextEdit
            // 
            this.confirmTextEdit.Location = new System.Drawing.Point(106, 83);
            this.confirmTextEdit.Name = "confirmTextEdit";
            this.confirmTextEdit.Size = new System.Drawing.Size(200, 20);
            this.confirmTextEdit.TabIndex = 9;
            // 
            // errorProvider1
            // 
            this.errorProvider1.ContainerControl = this;
            // 
            // ChangePasswordView
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(324, 151);
            this.Controls.Add(this.confirmTextEdit);
            this.Controls.Add(this.newPasswordTextEdit);
            this.Controls.Add(this.oldPasswordTextEdit);
            this.Controls.Add(this.userNameTextEdit);
            this.Controls.Add(this.labelControl4);
            this.Controls.Add(this.labelControl3);
            this.Controls.Add(this.labelControl2);
            this.Controls.Add(this.labelControl1);
            this.Controls.Add(this.cancelCommand);
            this.Controls.Add(this.simpleButton1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "ChangePasswordView";
            this.Text = "ChangePasswordView";
            ((System.ComponentModel.ISupportInitialize)(this.userNameTextEdit.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.oldPasswordTextEdit.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.newPasswordTextEdit.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.confirmTextEdit.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private DevExpress.XtraEditors.SimpleButton simpleButton1;
        private DevExpress.XtraEditors.SimpleButton cancelCommand;
        private DevExpress.XtraEditors.LabelControl labelControl1;
        private DevExpress.XtraEditors.LabelControl labelControl2;
        private DevExpress.XtraEditors.LabelControl labelControl3;
        private DevExpress.XtraEditors.LabelControl labelControl4;
        private DevExpress.XtraEditors.TextEdit userNameTextEdit;
        private DevExpress.XtraEditors.TextEdit oldPasswordTextEdit;
        private DevExpress.XtraEditors.TextEdit newPasswordTextEdit;
        private DevExpress.XtraEditors.TextEdit confirmTextEdit;
        private System.Windows.Forms.ErrorProvider errorProvider1;
    }
}