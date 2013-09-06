namespace ClearOffice.Wms.Views
{
    partial class VendorDetail
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
            System.Windows.Forms.Label nameLabel;
            System.Windows.Forms.Label addressLabel;
            System.Windows.Forms.Label emailLabel;
            System.Windows.Forms.Label cityLabel;
            System.Windows.Forms.Label faxLabel;
            System.Windows.Forms.Label postalCodeLabel;
            System.Windows.Forms.Label vendorTypeLabel;
            System.Windows.Forms.Label countryLabel;
            System.Windows.Forms.Label contactLabel1;
            System.Windows.Forms.Label phone1Label;
            System.Windows.Forms.Label phone2Label;
            System.Windows.Forms.Label remarkLabel;
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(VendorDetail));
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.saveToolStripButton = new System.Windows.Forms.ToolStripButton();
            this.nameTextBox = new System.Windows.Forms.TextBox();
            this.vendorBindingSource = new System.Windows.Forms.BindingSource();
            this.addressTextBox = new System.Windows.Forms.TextBox();
            this.emailTextBox = new System.Windows.Forms.TextBox();
            this.cityTextBox = new System.Windows.Forms.TextBox();
            this.faxTextBox = new System.Windows.Forms.TextBox();
            this.postalCodeTextBox = new System.Windows.Forms.TextBox();
            this.vendorTypeLookUpEdit = new DevExpress.XtraEditors.LookUpEdit();
            this.VendorTypeBindingSource = new System.Windows.Forms.BindingSource();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.phone2TextBox = new System.Windows.Forms.TextBox();
            this.phone1TextBox = new System.Windows.Forms.TextBox();
            this.contactTextBox = new System.Windows.Forms.TextBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.countryLookUpEdit = new DevExpress.XtraEditors.LookUpEdit();
            this.CountryBindingSource = new System.Windows.Forms.BindingSource();
            this.statusStrip1 = new System.Windows.Forms.StatusStrip();
            this.errorProvider1 = new System.Windows.Forms.ErrorProvider();
            this.remarkTextBox = new System.Windows.Forms.TextBox();
            nameLabel = new System.Windows.Forms.Label();
            addressLabel = new System.Windows.Forms.Label();
            emailLabel = new System.Windows.Forms.Label();
            cityLabel = new System.Windows.Forms.Label();
            faxLabel = new System.Windows.Forms.Label();
            postalCodeLabel = new System.Windows.Forms.Label();
            vendorTypeLabel = new System.Windows.Forms.Label();
            countryLabel = new System.Windows.Forms.Label();
            contactLabel1 = new System.Windows.Forms.Label();
            phone1Label = new System.Windows.Forms.Label();
            phone2Label = new System.Windows.Forms.Label();
            remarkLabel = new System.Windows.Forms.Label();
            this.toolStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.vendorBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.vendorTypeLookUpEdit.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.VendorTypeBindingSource)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.countryLookUpEdit.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.CountryBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).BeginInit();
            this.SuspendLayout();
            // 
            // nameLabel
            // 
            nameLabel.AutoSize = true;
            nameLabel.Location = new System.Drawing.Point(29, 20);
            nameLabel.Name = "nameLabel";
            nameLabel.Size = new System.Drawing.Size(38, 13);
            nameLabel.TabIndex = 1;
            nameLabel.Text = "Name:";
            // 
            // addressLabel
            // 
            addressLabel.AutoSize = true;
            addressLabel.Location = new System.Drawing.Point(18, 44);
            addressLabel.Name = "addressLabel";
            addressLabel.Size = new System.Drawing.Size(50, 13);
            addressLabel.TabIndex = 3;
            addressLabel.Text = "Address:";
            // 
            // emailLabel
            // 
            emailLabel.AutoSize = true;
            emailLabel.Location = new System.Drawing.Point(304, 158);
            emailLabel.Name = "emailLabel";
            emailLabel.Size = new System.Drawing.Size(35, 13);
            emailLabel.TabIndex = 5;
            emailLabel.Text = "Email:";
            // 
            // cityLabel
            // 
            cityLabel.AutoSize = true;
            cityLabel.Location = new System.Drawing.Point(41, 156);
            cityLabel.Name = "cityLabel";
            cityLabel.Size = new System.Drawing.Size(30, 13);
            cityLabel.TabIndex = 9;
            cityLabel.Text = "City:";
            // 
            // faxLabel
            // 
            faxLabel.AutoSize = true;
            faxLabel.Location = new System.Drawing.Point(310, 107);
            faxLabel.Name = "faxLabel";
            faxLabel.Size = new System.Drawing.Size(29, 13);
            faxLabel.TabIndex = 11;
            faxLabel.Text = "Fax:";
            // 
            // postalCodeLabel
            // 
            postalCodeLabel.AutoSize = true;
            postalCodeLabel.Location = new System.Drawing.Point(271, 131);
            postalCodeLabel.Name = "postalCodeLabel";
            postalCodeLabel.Size = new System.Drawing.Size(68, 13);
            postalCodeLabel.TabIndex = 13;
            postalCodeLabel.Text = "Postal Code:";
            // 
            // vendorTypeLabel
            // 
            vendorTypeLabel.AutoSize = true;
            vendorTypeLabel.Location = new System.Drawing.Point(35, 104);
            vendorTypeLabel.Name = "vendorTypeLabel";
            vendorTypeLabel.Size = new System.Drawing.Size(35, 13);
            vendorTypeLabel.TabIndex = 15;
            vendorTypeLabel.Text = "Type:";
            // 
            // countryLabel
            // 
            countryLabel.AutoSize = true;
            countryLabel.Location = new System.Drawing.Point(21, 131);
            countryLabel.Name = "countryLabel";
            countryLabel.Size = new System.Drawing.Size(50, 13);
            countryLabel.TabIndex = 16;
            countryLabel.Text = "Country:";
            // 
            // contactLabel1
            // 
            contactLabel1.AutoSize = true;
            contactLabel1.Location = new System.Drawing.Point(22, 24);
            contactLabel1.Name = "contactLabel1";
            contactLabel1.Size = new System.Drawing.Size(49, 13);
            contactLabel1.TabIndex = 5;
            contactLabel1.Text = "Contact:";
            // 
            // phone1Label
            // 
            phone1Label.AutoSize = true;
            phone1Label.Location = new System.Drawing.Point(24, 51);
            phone1Label.Name = "phone1Label";
            phone1Label.Size = new System.Drawing.Size(47, 13);
            phone1Label.TabIndex = 6;
            phone1Label.Text = "Phone1:";
            // 
            // phone2Label
            // 
            phone2Label.AutoSize = true;
            phone2Label.Location = new System.Drawing.Point(292, 51);
            phone2Label.Name = "phone2Label";
            phone2Label.Size = new System.Drawing.Size(47, 13);
            phone2Label.TabIndex = 7;
            phone2Label.Text = "Phone2:";
            // 
            // remarkLabel
            // 
            remarkLabel.AutoSize = true;
            remarkLabel.Location = new System.Drawing.Point(33, 318);
            remarkLabel.Name = "remarkLabel";
            remarkLabel.Size = new System.Drawing.Size(47, 13);
            remarkLabel.TabIndex = 19;
            remarkLabel.Text = "Remark:";
            // 
            // toolStrip1
            // 
            this.toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.saveToolStripButton});
            this.toolStrip1.Location = new System.Drawing.Point(0, 0);
            this.toolStrip1.Name = "toolStrip1";
            this.toolStrip1.Size = new System.Drawing.Size(587, 25);
            this.toolStrip1.TabIndex = 5;
            this.toolStrip1.Text = "toolStrip1";
            // 
            // saveToolStripButton
            // 
            this.saveToolStripButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.saveToolStripButton.Image = ((System.Drawing.Image)(resources.GetObject("saveToolStripButton.Image")));
            this.saveToolStripButton.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.saveToolStripButton.Name = "saveToolStripButton";
            this.saveToolStripButton.Size = new System.Drawing.Size(23, 22);
            this.saveToolStripButton.Text = "Save";
            this.saveToolStripButton.Click += new System.EventHandler(this.saveToolStripButton_Click);
            // 
            // nameTextBox
            // 
            this.nameTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.vendorBindingSource, "Name", true));
            this.nameTextBox.Location = new System.Drawing.Point(77, 17);
            this.nameTextBox.Name = "nameTextBox";
            this.nameTextBox.Size = new System.Drawing.Size(476, 21);
            this.nameTextBox.TabIndex = 0;
            // 
            // vendorBindingSource
            // 
            this.vendorBindingSource.DataSource = typeof(ClearOffice.Wms.Business.Vendor);
            this.vendorBindingSource.CurrentItemChanged += new System.EventHandler(this.vendorBindingSource_CurrentItemChanged);
            // 
            // addressTextBox
            // 
            this.addressTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.vendorBindingSource, "Address", true));
            this.addressTextBox.Location = new System.Drawing.Point(77, 43);
            this.addressTextBox.Multiline = true;
            this.addressTextBox.Name = "addressTextBox";
            this.addressTextBox.Size = new System.Drawing.Size(476, 53);
            this.addressTextBox.TabIndex = 1;
            // 
            // emailTextBox
            // 
            this.emailTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.vendorBindingSource, "Email", true));
            this.emailTextBox.Location = new System.Drawing.Point(352, 155);
            this.emailTextBox.Name = "emailTextBox";
            this.emailTextBox.Size = new System.Drawing.Size(201, 21);
            this.emailTextBox.TabIndex = 7;
            // 
            // cityTextBox
            // 
            this.cityTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.vendorBindingSource, "City", true));
            this.cityTextBox.Location = new System.Drawing.Point(77, 154);
            this.cityTextBox.Name = "cityTextBox";
            this.cityTextBox.Size = new System.Drawing.Size(188, 21);
            this.cityTextBox.TabIndex = 6;
            // 
            // faxTextBox
            // 
            this.faxTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.vendorBindingSource, "Fax", true));
            this.faxTextBox.Location = new System.Drawing.Point(352, 102);
            this.faxTextBox.Name = "faxTextBox";
            this.faxTextBox.Size = new System.Drawing.Size(201, 21);
            this.faxTextBox.TabIndex = 3;
            // 
            // postalCodeTextBox
            // 
            this.postalCodeTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.vendorBindingSource, "PostalCode", true));
            this.postalCodeTextBox.Location = new System.Drawing.Point(352, 128);
            this.postalCodeTextBox.Name = "postalCodeTextBox";
            this.postalCodeTextBox.Size = new System.Drawing.Size(201, 21);
            this.postalCodeTextBox.TabIndex = 5;
            // 
            // vendorTypeLookUpEdit
            // 
            this.vendorTypeLookUpEdit.DataBindings.Add(new System.Windows.Forms.Binding("EditValue", this.vendorBindingSource, "VendorType", true));
            this.vendorTypeLookUpEdit.Location = new System.Drawing.Point(77, 102);
            this.vendorTypeLookUpEdit.Name = "vendorTypeLookUpEdit";
            this.vendorTypeLookUpEdit.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.vendorTypeLookUpEdit.Properties.Columns.AddRange(new DevExpress.XtraEditors.Controls.LookUpColumnInfo[] {
            new DevExpress.XtraEditors.Controls.LookUpColumnInfo("Name", "Name", 37, DevExpress.Utils.FormatType.None, "", true, DevExpress.Utils.HorzAlignment.Near)});
            this.vendorTypeLookUpEdit.Properties.DataSource = this.VendorTypeBindingSource;
            this.vendorTypeLookUpEdit.Properties.DisplayMember = "Name";
            this.vendorTypeLookUpEdit.Properties.NullText = "[Vendor Type]";
            this.vendorTypeLookUpEdit.Properties.ValueMember = "ItemId";
            this.vendorTypeLookUpEdit.Size = new System.Drawing.Size(188, 20);
            this.vendorTypeLookUpEdit.TabIndex = 2;
            // 
            // VendorTypeBindingSource
            // 
            this.VendorTypeBindingSource.DataSource = typeof(ClearOffice.Wms.Business.LookupItem);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(phone2Label);
            this.groupBox1.Controls.Add(this.phone2TextBox);
            this.groupBox1.Controls.Add(phone1Label);
            this.groupBox1.Controls.Add(this.phone1TextBox);
            this.groupBox1.Controls.Add(contactLabel1);
            this.groupBox1.Controls.Add(this.contactTextBox);
            this.groupBox1.Location = new System.Drawing.Point(9, 228);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(573, 81);
            this.groupBox1.TabIndex = 5;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Contact Information";
            // 
            // phone2TextBox
            // 
            this.phone2TextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.vendorBindingSource, "Phone2", true));
            this.phone2TextBox.Location = new System.Drawing.Point(352, 48);
            this.phone2TextBox.Name = "phone2TextBox";
            this.phone2TextBox.Size = new System.Drawing.Size(201, 21);
            this.phone2TextBox.TabIndex = 3;
            // 
            // phone1TextBox
            // 
            this.phone1TextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.vendorBindingSource, "Phone1", true));
            this.phone1TextBox.Location = new System.Drawing.Point(77, 48);
            this.phone1TextBox.Name = "phone1TextBox";
            this.phone1TextBox.Size = new System.Drawing.Size(188, 21);
            this.phone1TextBox.TabIndex = 2;
            // 
            // contactTextBox
            // 
            this.contactTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.vendorBindingSource, "Contact", true));
            this.contactTextBox.Location = new System.Drawing.Point(77, 21);
            this.contactTextBox.Name = "contactTextBox";
            this.contactTextBox.Size = new System.Drawing.Size(476, 21);
            this.contactTextBox.TabIndex = 1;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(countryLabel);
            this.groupBox2.Controls.Add(this.countryLookUpEdit);
            this.groupBox2.Controls.Add(this.nameTextBox);
            this.groupBox2.Controls.Add(nameLabel);
            this.groupBox2.Controls.Add(vendorTypeLabel);
            this.groupBox2.Controls.Add(this.addressTextBox);
            this.groupBox2.Controls.Add(this.vendorTypeLookUpEdit);
            this.groupBox2.Controls.Add(addressLabel);
            this.groupBox2.Controls.Add(postalCodeLabel);
            this.groupBox2.Controls.Add(this.emailTextBox);
            this.groupBox2.Controls.Add(this.postalCodeTextBox);
            this.groupBox2.Controls.Add(emailLabel);
            this.groupBox2.Controls.Add(faxLabel);
            this.groupBox2.Controls.Add(this.faxTextBox);
            this.groupBox2.Controls.Add(cityLabel);
            this.groupBox2.Controls.Add(this.cityTextBox);
            this.groupBox2.Location = new System.Drawing.Point(9, 27);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(573, 192);
            this.groupBox2.TabIndex = 4;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Basic Information";
            // 
            // countryLookUpEdit
            // 
            this.countryLookUpEdit.DataBindings.Add(new System.Windows.Forms.Binding("EditValue", this.vendorBindingSource, "Country", true));
            this.countryLookUpEdit.Location = new System.Drawing.Point(77, 128);
            this.countryLookUpEdit.Name = "countryLookUpEdit";
            this.countryLookUpEdit.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.countryLookUpEdit.Properties.Columns.AddRange(new DevExpress.XtraEditors.Controls.LookUpColumnInfo[] {
            new DevExpress.XtraEditors.Controls.LookUpColumnInfo("Name", "Name", 37, DevExpress.Utils.FormatType.None, "", true, DevExpress.Utils.HorzAlignment.Near)});
            this.countryLookUpEdit.Properties.DataSource = this.CountryBindingSource;
            this.countryLookUpEdit.Properties.DisplayMember = "Name";
            this.countryLookUpEdit.Properties.NullText = "[Country]";
            this.countryLookUpEdit.Properties.ValueMember = "CountryId";
            this.countryLookUpEdit.Size = new System.Drawing.Size(188, 20);
            this.countryLookUpEdit.TabIndex = 4;
            // 
            // CountryBindingSource
            // 
            this.CountryBindingSource.DataSource = typeof(ClearOffice.Wms.Business.Country);
            // 
            // statusStrip1
            // 
            this.statusStrip1.Location = new System.Drawing.Point(0, 392);
            this.statusStrip1.Name = "statusStrip1";
            this.statusStrip1.Size = new System.Drawing.Size(587, 22);
            this.statusStrip1.TabIndex = 2;
            this.statusStrip1.Text = "statusStrip1";
            // 
            // errorProvider1
            // 
            this.errorProvider1.ContainerControl = this;
            // 
            // remarkTextBox
            // 
            this.remarkTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.vendorBindingSource, "Remark", true));
            this.remarkTextBox.Location = new System.Drawing.Point(86, 315);
            this.remarkTextBox.Multiline = true;
            this.remarkTextBox.Name = "remarkTextBox";
            this.remarkTextBox.Size = new System.Drawing.Size(476, 74);
            this.remarkTextBox.TabIndex = 20;
            // 
            // VendorDetail
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.ClientSize = new System.Drawing.Size(587, 414);
            this.Controls.Add(remarkLabel);
            this.Controls.Add(this.remarkTextBox);
            this.Controls.Add(this.statusStrip1);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.toolStrip1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "VendorDetail";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Vendor Information";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.VendorDetail_FormClosing);
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.vendorBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.vendorTypeLookUpEdit.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.VendorTypeBindingSource)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.countryLookUpEdit.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.CountryBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.BindingSource vendorBindingSource;
        private System.Windows.Forms.ToolStrip toolStrip1;
        private System.Windows.Forms.ToolStripButton saveToolStripButton;
        private System.Windows.Forms.TextBox nameTextBox;
        private System.Windows.Forms.TextBox addressTextBox;
        private System.Windows.Forms.TextBox emailTextBox;
        private System.Windows.Forms.TextBox cityTextBox;
        private System.Windows.Forms.TextBox faxTextBox;
        private System.Windows.Forms.TextBox postalCodeTextBox;
        private DevExpress.XtraEditors.LookUpEdit vendorTypeLookUpEdit;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.StatusStrip statusStrip1;
        private System.Windows.Forms.ErrorProvider errorProvider1;
        private DevExpress.XtraEditors.LookUpEdit countryLookUpEdit;
        private System.Windows.Forms.BindingSource VendorTypeBindingSource;
        private System.Windows.Forms.BindingSource CountryBindingSource;
        private System.Windows.Forms.TextBox phone2TextBox;
        private System.Windows.Forms.TextBox phone1TextBox;
        private System.Windows.Forms.TextBox contactTextBox;
        private System.Windows.Forms.TextBox remarkTextBox;
    }
}