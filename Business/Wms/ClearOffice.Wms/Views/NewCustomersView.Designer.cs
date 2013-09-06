namespace ClearOffice.Wms.Views
{
    partial class NewCustomersView
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
            System.Windows.Forms.Label emailLabel;
            System.Windows.Forms.Label phone2Label;
            System.Windows.Forms.Label postalCodeLabel;
            System.Windows.Forms.Label remarkLabel;
            System.Windows.Forms.Label faxLabel;
            System.Windows.Forms.Label phone1Label;
            System.Windows.Forms.Label cityLabel;
            System.Windows.Forms.Label nameLabel;
            System.Windows.Forms.Label addressLabel;
            System.Windows.Forms.Label contactLabel;
            System.Windows.Forms.Label typeLabel;
            this.panelControl1 = new DevExpress.XtraEditors.PanelControl();
            this.typeLookUpEdit = new DevExpress.XtraEditors.LookUpEdit();
            this.CustomerDataBindingSource = new System.Windows.Forms.BindingSource();
            this.customerTypeBindingSource = new System.Windows.Forms.BindingSource();
            this.contactTextBox = new System.Windows.Forms.TextBox();
            this.addressTextBox = new System.Windows.Forms.TextBox();
            this.remarkTextBox = new System.Windows.Forms.TextBox();
            this.postalCodeTextBox = new System.Windows.Forms.TextBox();
            this.phone2TextBox = new System.Windows.Forms.TextBox();
            this.emailTextBox = new System.Windows.Forms.TextBox();
            this.faxTextBox = new System.Windows.Forms.TextBox();
            this.phone1TextBox = new System.Windows.Forms.TextBox();
            this.cityTextBox = new System.Windows.Forms.TextBox();
            this.nameTextBox = new System.Windows.Forms.TextBox();
            this.errorProvider = new System.Windows.Forms.ErrorProvider();
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.saveToolStripButton = new System.Windows.Forms.ToolStripButton();
            this.btnSaveAndNew = new System.Windows.Forms.ToolStripButton();
            emailLabel = new System.Windows.Forms.Label();
            phone2Label = new System.Windows.Forms.Label();
            postalCodeLabel = new System.Windows.Forms.Label();
            remarkLabel = new System.Windows.Forms.Label();
            faxLabel = new System.Windows.Forms.Label();
            phone1Label = new System.Windows.Forms.Label();
            cityLabel = new System.Windows.Forms.Label();
            nameLabel = new System.Windows.Forms.Label();
            addressLabel = new System.Windows.Forms.Label();
            contactLabel = new System.Windows.Forms.Label();
            typeLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.panelControl1)).BeginInit();
            this.panelControl1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.typeLookUpEdit.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.CustomerDataBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.customerTypeBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider)).BeginInit();
            this.toolStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // emailLabel
            // 
            emailLabel.AutoSize = true;
            emailLabel.Location = new System.Drawing.Point(309, 192);
            emailLabel.Name = "emailLabel";
            emailLabel.Size = new System.Drawing.Size(35, 13);
            emailLabel.TabIndex = 24;
            emailLabel.Text = "Email:";
            // 
            // phone2Label
            // 
            phone2Label.AutoSize = true;
            phone2Label.Location = new System.Drawing.Point(309, 163);
            phone2Label.Name = "phone2Label";
            phone2Label.Size = new System.Drawing.Size(47, 13);
            phone2Label.TabIndex = 25;
            phone2Label.Text = "Phone2:";
            // 
            // postalCodeLabel
            // 
            postalCodeLabel.AutoSize = true;
            postalCodeLabel.Location = new System.Drawing.Point(309, 136);
            postalCodeLabel.Name = "postalCodeLabel";
            postalCodeLabel.Size = new System.Drawing.Size(68, 13);
            postalCodeLabel.TabIndex = 26;
            postalCodeLabel.Text = "Postal Code:";
            // 
            // remarkLabel
            // 
            remarkLabel.AutoSize = true;
            remarkLabel.Location = new System.Drawing.Point(9, 256);
            remarkLabel.Name = "remarkLabel";
            remarkLabel.Size = new System.Drawing.Size(47, 13);
            remarkLabel.TabIndex = 27;
            remarkLabel.Text = "Remark:";
            // 
            // faxLabel
            // 
            faxLabel.AutoSize = true;
            faxLabel.Location = new System.Drawing.Point(9, 192);
            faxLabel.Name = "faxLabel";
            faxLabel.Size = new System.Drawing.Size(29, 13);
            faxLabel.TabIndex = 22;
            faxLabel.Text = "Fax:";
            // 
            // phone1Label
            // 
            phone1Label.AutoSize = true;
            phone1Label.Location = new System.Drawing.Point(9, 163);
            phone1Label.Name = "phone1Label";
            phone1Label.Size = new System.Drawing.Size(47, 13);
            phone1Label.TabIndex = 21;
            phone1Label.Text = "Phone1:";
            // 
            // cityLabel
            // 
            cityLabel.AutoSize = true;
            cityLabel.Location = new System.Drawing.Point(9, 136);
            cityLabel.Name = "cityLabel";
            cityLabel.Size = new System.Drawing.Size(30, 13);
            cityLabel.TabIndex = 20;
            cityLabel.Text = "City:";
            // 
            // nameLabel
            // 
            nameLabel.AutoSize = true;
            nameLabel.Location = new System.Drawing.Point(9, 11);
            nameLabel.Name = "nameLabel";
            nameLabel.Size = new System.Drawing.Size(38, 13);
            nameLabel.TabIndex = 0;
            nameLabel.Text = "Name:";
            // 
            // addressLabel
            // 
            addressLabel.AutoSize = true;
            addressLabel.Location = new System.Drawing.Point(9, 64);
            addressLabel.Name = "addressLabel";
            addressLabel.Size = new System.Drawing.Size(50, 13);
            addressLabel.TabIndex = 28;
            addressLabel.Text = "Address:";
            // 
            // contactLabel
            // 
            contactLabel.AutoSize = true;
            contactLabel.Location = new System.Drawing.Point(9, 219);
            contactLabel.Name = "contactLabel";
            contactLabel.Size = new System.Drawing.Size(47, 26);
            contactLabel.TabIndex = 29;
            contactLabel.Text = "Contact\r\nPerson :";
            // 
            // typeLabel
            // 
            typeLabel.AutoSize = true;
            typeLabel.Location = new System.Drawing.Point(9, 37);
            typeLabel.Name = "typeLabel";
            typeLabel.Size = new System.Drawing.Size(35, 13);
            typeLabel.TabIndex = 29;
            typeLabel.Text = "Type:";
            // 
            // panelControl1
            // 
            this.panelControl1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panelControl1.Controls.Add(typeLabel);
            this.panelControl1.Controls.Add(this.typeLookUpEdit);
            this.panelControl1.Controls.Add(contactLabel);
            this.panelControl1.Controls.Add(this.contactTextBox);
            this.panelControl1.Controls.Add(addressLabel);
            this.panelControl1.Controls.Add(this.addressTextBox);
            this.panelControl1.Controls.Add(remarkLabel);
            this.panelControl1.Controls.Add(this.remarkTextBox);
            this.panelControl1.Controls.Add(postalCodeLabel);
            this.panelControl1.Controls.Add(this.postalCodeTextBox);
            this.panelControl1.Controls.Add(phone2Label);
            this.panelControl1.Controls.Add(this.phone2TextBox);
            this.panelControl1.Controls.Add(emailLabel);
            this.panelControl1.Controls.Add(this.emailTextBox);
            this.panelControl1.Controls.Add(faxLabel);
            this.panelControl1.Controls.Add(this.faxTextBox);
            this.panelControl1.Controls.Add(phone1Label);
            this.panelControl1.Controls.Add(this.phone1TextBox);
            this.panelControl1.Controls.Add(cityLabel);
            this.panelControl1.Controls.Add(this.cityTextBox);
            this.panelControl1.Controls.Add(nameLabel);
            this.panelControl1.Controls.Add(this.nameTextBox);
            this.panelControl1.Location = new System.Drawing.Point(0, 25);
            this.panelControl1.Name = "panelControl1";
            this.panelControl1.Size = new System.Drawing.Size(588, 335);
            this.panelControl1.TabIndex = 3;
            // 
            // typeLookUpEdit
            // 
            this.typeLookUpEdit.DataBindings.Add(new System.Windows.Forms.Binding("EditValue", this.CustomerDataBindingSource, "type", true));
            this.typeLookUpEdit.Location = new System.Drawing.Point(65, 37);
            this.typeLookUpEdit.Name = "typeLookUpEdit";
            this.typeLookUpEdit.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.typeLookUpEdit.Properties.Columns.AddRange(new DevExpress.XtraEditors.Controls.LookUpColumnInfo[] {
            new DevExpress.XtraEditors.Controls.LookUpColumnInfo("Name", "Name", 37, DevExpress.Utils.FormatType.None, "", true, DevExpress.Utils.HorzAlignment.Near)});
            this.typeLookUpEdit.Properties.DataSource = this.customerTypeBindingSource;
            this.typeLookUpEdit.Properties.DisplayMember = "Name";
            this.typeLookUpEdit.Properties.NullText = "[Select Customer Type]";
            this.typeLookUpEdit.Properties.ValueMember = "ItemId";
            this.typeLookUpEdit.Size = new System.Drawing.Size(216, 20);
            this.typeLookUpEdit.TabIndex = 1;
            // 
            // CustomerDataBindingSource
            // 
            this.CustomerDataBindingSource.DataSource = typeof(ClearOffice.Wms.Business.Customer);
            this.CustomerDataBindingSource.CurrentChanged += new System.EventHandler(this.CustomerDataBindingSource_CurrentChanged);
            // 
            // customerTypeBindingSource
            // 
            this.customerTypeBindingSource.DataSource = typeof(ClearOffice.Wms.Business.LookupItem);
            // 
            // contactTextBox
            // 
            this.contactTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.CustomerDataBindingSource, "Contact", true));
            this.contactTextBox.Location = new System.Drawing.Point(65, 219);
            this.contactTextBox.Name = "contactTextBox";
            this.contactTextBox.Size = new System.Drawing.Size(216, 21);
            this.contactTextBox.TabIndex = 9;
            // 
            // addressTextBox
            // 
            this.addressTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.CustomerDataBindingSource, "Address", true));
            this.addressTextBox.Location = new System.Drawing.Point(65, 64);
            this.addressTextBox.Multiline = true;
            this.addressTextBox.Name = "addressTextBox";
            this.addressTextBox.Size = new System.Drawing.Size(510, 67);
            this.addressTextBox.TabIndex = 2;
            // 
            // remarkTextBox
            // 
            this.remarkTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.CustomerDataBindingSource, "Remark", true));
            this.remarkTextBox.Location = new System.Drawing.Point(65, 256);
            this.remarkTextBox.Multiline = true;
            this.remarkTextBox.Name = "remarkTextBox";
            this.remarkTextBox.Size = new System.Drawing.Size(510, 65);
            this.remarkTextBox.TabIndex = 10;
            // 
            // postalCodeTextBox
            // 
            this.postalCodeTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.CustomerDataBindingSource, "PostalCode", true));
            this.postalCodeTextBox.Location = new System.Drawing.Point(383, 136);
            this.postalCodeTextBox.Name = "postalCodeTextBox";
            this.postalCodeTextBox.Size = new System.Drawing.Size(192, 21);
            this.postalCodeTextBox.TabIndex = 4;
            // 
            // phone2TextBox
            // 
            this.phone2TextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.CustomerDataBindingSource, "Phone2", true));
            this.phone2TextBox.Location = new System.Drawing.Point(383, 163);
            this.phone2TextBox.Name = "phone2TextBox";
            this.phone2TextBox.Size = new System.Drawing.Size(192, 21);
            this.phone2TextBox.TabIndex = 6;
            // 
            // emailTextBox
            // 
            this.emailTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.CustomerDataBindingSource, "Email", true));
            this.emailTextBox.Location = new System.Drawing.Point(383, 192);
            this.emailTextBox.Name = "emailTextBox";
            this.emailTextBox.Size = new System.Drawing.Size(192, 21);
            this.emailTextBox.TabIndex = 8;
            // 
            // faxTextBox
            // 
            this.faxTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.CustomerDataBindingSource, "Fax", true));
            this.faxTextBox.Location = new System.Drawing.Point(65, 192);
            this.faxTextBox.Name = "faxTextBox";
            this.faxTextBox.Size = new System.Drawing.Size(216, 21);
            this.faxTextBox.TabIndex = 7;
            // 
            // phone1TextBox
            // 
            this.phone1TextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.CustomerDataBindingSource, "Phone1", true));
            this.phone1TextBox.Location = new System.Drawing.Point(65, 163);
            this.phone1TextBox.Name = "phone1TextBox";
            this.phone1TextBox.Size = new System.Drawing.Size(216, 21);
            this.phone1TextBox.TabIndex = 5;
            // 
            // cityTextBox
            // 
            this.cityTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.CustomerDataBindingSource, "City", true));
            this.cityTextBox.Location = new System.Drawing.Point(65, 136);
            this.cityTextBox.Name = "cityTextBox";
            this.cityTextBox.Size = new System.Drawing.Size(216, 21);
            this.cityTextBox.TabIndex = 3;
            // 
            // nameTextBox
            // 
            this.nameTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.CustomerDataBindingSource, "Name", true));
            this.nameTextBox.Location = new System.Drawing.Point(65, 11);
            this.nameTextBox.Name = "nameTextBox";
            this.nameTextBox.Size = new System.Drawing.Size(510, 21);
            this.nameTextBox.TabIndex = 0;
            // 
            // errorProvider
            // 
            this.errorProvider.ContainerControl = this;
            // 
            // toolStrip1
            // 
            this.toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.saveToolStripButton,
            this.btnSaveAndNew});
            this.toolStrip1.Location = new System.Drawing.Point(0, 0);
            this.toolStrip1.Name = "toolStrip1";
            this.toolStrip1.Size = new System.Drawing.Size(588, 25);
            this.toolStrip1.TabIndex = 0;
            this.toolStrip1.Text = "toolStrip1";
            // 
            // saveToolStripButton
            // 
            this.saveToolStripButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.saveToolStripButton.Image = global::ClearOffice.Wms.Properties.Resources.Save_16x16;
            this.saveToolStripButton.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.saveToolStripButton.Name = "saveToolStripButton";
            this.saveToolStripButton.Size = new System.Drawing.Size(23, 22);
            this.saveToolStripButton.Text = "&Save";
            this.saveToolStripButton.Click += new System.EventHandler(this.saveToolStripButton_Click_1);
            // 
            // btnSaveAndNew
            // 
            this.btnSaveAndNew.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.btnSaveAndNew.Image = global::ClearOffice.Wms.Properties.Resources.Save_And_New_16x16;
            this.btnSaveAndNew.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnSaveAndNew.Name = "btnSaveAndNew";
            this.btnSaveAndNew.Size = new System.Drawing.Size(23, 22);
            this.btnSaveAndNew.Text = "toolStripButton1";
            this.btnSaveAndNew.ToolTipText = "Save & New";
            this.btnSaveAndNew.Click += new System.EventHandler(this.toolStripButton1_Click);
            // 
            // NewCustomersView
            // 
            this.AllowDrop = true;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.ClientSize = new System.Drawing.Size(588, 361);
            this.Controls.Add(this.toolStrip1);
            this.Controls.Add(this.panelControl1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "NewCustomersView";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "New Customer";
            ((System.ComponentModel.ISupportInitialize)(this.panelControl1)).EndInit();
            this.panelControl1.ResumeLayout(false);
            this.panelControl1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.typeLookUpEdit.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.CustomerDataBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.customerTypeBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider)).EndInit();
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private DevExpress.XtraEditors.PanelControl panelControl1;
        private System.Windows.Forms.ErrorProvider errorProvider;
        private System.Windows.Forms.BindingSource customerTypeBindingSource;
        private System.Windows.Forms.BindingSource CustomerDataBindingSource;
        private System.Windows.Forms.TextBox remarkTextBox;
        private System.Windows.Forms.TextBox postalCodeTextBox;
        private System.Windows.Forms.TextBox phone2TextBox;
        private System.Windows.Forms.TextBox emailTextBox;
        private System.Windows.Forms.TextBox faxTextBox;
        private System.Windows.Forms.TextBox phone1TextBox;
        private System.Windows.Forms.TextBox cityTextBox;
        private System.Windows.Forms.TextBox nameTextBox;
        private System.Windows.Forms.TextBox contactTextBox;
        private System.Windows.Forms.TextBox addressTextBox;
        private System.Windows.Forms.ToolStrip toolStrip1;
        private System.Windows.Forms.ToolStripButton saveToolStripButton;
        private DevExpress.XtraEditors.LookUpEdit typeLookUpEdit;
        private System.Windows.Forms.ToolStripButton btnSaveAndNew;
    }
}