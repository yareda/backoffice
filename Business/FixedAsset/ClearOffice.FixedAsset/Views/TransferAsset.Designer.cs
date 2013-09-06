namespace ClearOffice.FixedAsset.Views
{
    partial class TransferAsset
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
            this.custodianassettransferbindingSource = new System.Windows.Forms.BindingSource();
            this.newcustodianbindingSource = new System.Windows.Forms.BindingSource();
            this.errorProvider1 = new System.Windows.Forms.ErrorProvider();
            this.lookupitembindingSource = new System.Windows.Forms.BindingSource();
            this.cmdTransferasset = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.dateEdit1 = new DevExpress.XtraEditors.DateEdit();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.lookUpEdit2 = new DevExpress.XtraEditors.LookUpEdit();
            ((System.ComponentModel.ISupportInitialize)(this.custodianassettransferbindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.newcustodianbindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.lookupitembindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dateEdit1.Properties.VistaTimeProperties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dateEdit1.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.lookUpEdit2.Properties)).BeginInit();
            this.SuspendLayout();
            // 
            // custodianassettransferbindingSource
            // 
            this.custodianassettransferbindingSource.DataSource = typeof(ClearOffice.FixedAsset.DataAccess.CustodianAsset);
            // 
            // newcustodianbindingSource
            // 
            this.newcustodianbindingSource.DataSource = typeof(ClearOffice.FixedAsset.DataAccess.ActiveCustodianStatus);
            // 
            // errorProvider1
            // 
            this.errorProvider1.ContainerControl = this;
            // 
            // lookupitembindingSource
            // 
            this.lookupitembindingSource.DataSource = typeof(ClearOffice.FixedAsset.DataAccess.LookupItem);
            // 
            // cmdTransferasset
            // 
            this.cmdTransferasset.Location = new System.Drawing.Point(276, 92);
            this.cmdTransferasset.Name = "cmdTransferasset";
            this.cmdTransferasset.Size = new System.Drawing.Size(82, 23);
            this.cmdTransferasset.TabIndex = 5;
            this.cmdTransferasset.Text = "Transfer";
            this.cmdTransferasset.UseVisualStyleBackColor = true;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(23, 69);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(76, 13);
            this.label3.TabIndex = 13;
            this.label3.Text = "Assigned Date";
            // 
            // dateEdit1
            // 
            this.dateEdit1.DataBindings.Add(new System.Windows.Forms.Binding("EditValue", this.custodianassettransferbindingSource, "DateFrom", true));
            this.dateEdit1.EditValue = null;
            this.dateEdit1.Location = new System.Drawing.Point(112, 66);
            this.dateEdit1.Name = "dateEdit1";
            this.dateEdit1.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.dateEdit1.Properties.VistaTimeProperties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton()});
            this.dateEdit1.Size = new System.Drawing.Size(246, 20);
            this.dateEdit1.TabIndex = 12;
            // 
            // textBox1
            // 
            this.textBox1.Enabled = false;
            this.textBox1.Location = new System.Drawing.Point(112, 12);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(246, 21);
            this.textBox1.TabIndex = 11;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(23, 40);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(63, 13);
            this.label2.TabIndex = 10;
            this.label2.Text = "Transfer To";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(23, 12);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(75, 13);
            this.label1.TabIndex = 9;
            this.label1.Text = "Transfer From";
            // 
            // lookUpEdit2
            // 
            this.lookUpEdit2.DataBindings.Add(new System.Windows.Forms.Binding("EditValue", this.custodianassettransferbindingSource, "CustodianId", true));
            this.lookUpEdit2.Location = new System.Drawing.Point(112, 39);
            this.lookUpEdit2.Name = "lookUpEdit2";
            this.lookUpEdit2.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.lookUpEdit2.Properties.Columns.AddRange(new DevExpress.XtraEditors.Controls.LookUpColumnInfo[] {
            new DevExpress.XtraEditors.Controls.LookUpColumnInfo("FirstName", "First Name", 61, DevExpress.Utils.FormatType.None, "", true, DevExpress.Utils.HorzAlignment.Near),
            new DevExpress.XtraEditors.Controls.LookUpColumnInfo("LastName", "Last Name", 60, DevExpress.Utils.FormatType.None, "", true, DevExpress.Utils.HorzAlignment.Near),
            new DevExpress.XtraEditors.Controls.LookUpColumnInfo("StatusText", "Status Text", 66, DevExpress.Utils.FormatType.None, "", true, DevExpress.Utils.HorzAlignment.Near),
            new DevExpress.XtraEditors.Controls.LookUpColumnInfo("ItemName", "Item Name", 62, DevExpress.Utils.FormatType.None, "", true, DevExpress.Utils.HorzAlignment.Near)});
            this.lookUpEdit2.Properties.DataSource = this.newcustodianbindingSource;
            this.lookUpEdit2.Properties.DisplayMember = "FirstName";
            this.lookUpEdit2.Properties.NullText = "[Select Custodian]";
            this.lookUpEdit2.Properties.ValueMember = "CustodianId";
            this.lookUpEdit2.Size = new System.Drawing.Size(246, 20);
            this.lookUpEdit2.TabIndex = 8;
            // 
            // TransferAsset
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(377, 120);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.dateEdit1);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.lookUpEdit2);
            this.Controls.Add(this.cmdTransferasset);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "TransferAsset";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Transfer Asset";
            ((System.ComponentModel.ISupportInitialize)(this.custodianassettransferbindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.newcustodianbindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.lookupitembindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dateEdit1.Properties.VistaTimeProperties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dateEdit1.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.lookUpEdit2.Properties)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.BindingSource custodianassettransferbindingSource;
        private System.Windows.Forms.BindingSource newcustodianbindingSource;
        private System.Windows.Forms.ErrorProvider errorProvider1;
        private System.Windows.Forms.BindingSource lookupitembindingSource;
        private System.Windows.Forms.Button cmdTransferasset;
        private System.Windows.Forms.Label label3;
        private DevExpress.XtraEditors.DateEdit dateEdit1;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private DevExpress.XtraEditors.LookUpEdit lookUpEdit2;
    }
}