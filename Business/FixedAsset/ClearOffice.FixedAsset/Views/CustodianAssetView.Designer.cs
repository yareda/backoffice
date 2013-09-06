namespace ClearOffice.FixedAsset.Views
{
    partial class CustodianAssetView
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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label4 = new System.Windows.Forms.Label();
            this.txtRemark = new System.Windows.Forms.TextBox();
            this.cutodianassetbindingSource = new System.Windows.Forms.BindingSource();
            this.cmbDateFrom = new DevExpress.XtraEditors.DateEdit();
            this.label5 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.cmbcustodian = new DevExpress.XtraEditors.GridLookUpEdit();
            this.cutodianbindingSource = new System.Windows.Forms.BindingSource();
            this.gridLookUpEdit1View = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.colBadgeNo = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colFirstName = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colLastName = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colStatusText = new DevExpress.XtraGrid.Columns.GridColumn();
            this.custodianasseterrorProvider = new System.Windows.Forms.ErrorProvider();
            this.btnAssignAsset = new DevExpress.XtraEditors.SimpleButton();
            this.btnCancel = new DevExpress.XtraEditors.SimpleButton();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.cutodianassetbindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cmbDateFrom.Properties.VistaTimeProperties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cmbDateFrom.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cmbcustodian.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cutodianbindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridLookUpEdit1View)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.custodianasseterrorProvider)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.txtRemark);
            this.groupBox1.Controls.Add(this.cmbDateFrom);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.cmbcustodian);
            this.groupBox1.Location = new System.Drawing.Point(12, 6);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(389, 176);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Assignment Information";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(18, 24);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(55, 13);
            this.label4.TabIndex = 11;
            this.label4.Text = "Custodian";
            // 
            // txtRemark
            // 
            this.txtRemark.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.cutodianassetbindingSource, "Remark", true));
            this.txtRemark.Location = new System.Drawing.Point(100, 76);
            this.txtRemark.Multiline = true;
            this.txtRemark.Name = "txtRemark";
            this.txtRemark.Size = new System.Drawing.Size(283, 85);
            this.txtRemark.TabIndex = 9;
            // 
            // cutodianassetbindingSource
            // 
            this.cutodianassetbindingSource.DataSource = typeof(ClearOffice.FixedAsset.DataAccess.CustodianAsset);
            // 
            // cmbDateFrom
            // 
            this.cmbDateFrom.DataBindings.Add(new System.Windows.Forms.Binding("EditValue", this.cutodianassetbindingSource, "DateFrom", true));
            this.cmbDateFrom.EditValue = null;
            this.cmbDateFrom.Location = new System.Drawing.Point(100, 50);
            this.cmbDateFrom.Name = "cmbDateFrom";
            this.cmbDateFrom.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.cmbDateFrom.Properties.VistaTimeProperties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton()});
            this.cmbDateFrom.Size = new System.Drawing.Size(272, 20);
            this.cmbDateFrom.TabIndex = 6;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(18, 80);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(43, 13);
            this.label5.TabIndex = 4;
            this.label5.Text = "Remark";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(18, 51);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(76, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Assigned Date";
            // 
            // cmbcustodian
            // 
            this.cmbcustodian.DataBindings.Add(new System.Windows.Forms.Binding("EditValue", this.cutodianassetbindingSource, "CustodianId", true));
            this.cmbcustodian.Location = new System.Drawing.Point(100, 24);
            this.cmbcustodian.Name = "cmbcustodian";
            this.cmbcustodian.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.cmbcustodian.Properties.DataSource = this.cutodianbindingSource;
            this.cmbcustodian.Properties.DisplayMember = "FirstName";
            this.cmbcustodian.Properties.NullText = "[Select Custodian]";
            this.cmbcustodian.Properties.ValueMember = "CustodianId";
            this.cmbcustodian.Properties.View = this.gridLookUpEdit1View;
            this.cmbcustodian.Size = new System.Drawing.Size(272, 20);
            this.cmbcustodian.TabIndex = 10;
            // 
            // cutodianbindingSource
            // 
            this.cutodianbindingSource.DataSource = typeof(ClearOffice.FixedAsset.DataAccess.ActiveCustodianStatus);
            // 
            // gridLookUpEdit1View
            // 
            this.gridLookUpEdit1View.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.colBadgeNo,
            this.colFirstName,
            this.colLastName,
            this.colStatusText});
            this.gridLookUpEdit1View.FocusRectStyle = DevExpress.XtraGrid.Views.Grid.DrawFocusRectStyle.RowFocus;
            this.gridLookUpEdit1View.Name = "gridLookUpEdit1View";
            this.gridLookUpEdit1View.OptionsSelection.EnableAppearanceFocusedCell = false;
            this.gridLookUpEdit1View.OptionsView.ShowGroupPanel = false;
            // 
            // colBadgeNo
            // 
            this.colBadgeNo.FieldName = "BadgeNo";
            this.colBadgeNo.Name = "colBadgeNo";
            this.colBadgeNo.Visible = true;
            this.colBadgeNo.VisibleIndex = 0;
            // 
            // colFirstName
            // 
            this.colFirstName.FieldName = "FirstName";
            this.colFirstName.Name = "colFirstName";
            this.colFirstName.Visible = true;
            this.colFirstName.VisibleIndex = 1;
            // 
            // colLastName
            // 
            this.colLastName.FieldName = "LastName";
            this.colLastName.Name = "colLastName";
            this.colLastName.Visible = true;
            this.colLastName.VisibleIndex = 2;
            // 
            // colStatusText
            // 
            this.colStatusText.Caption = "Status";
            this.colStatusText.FieldName = "StatusText";
            this.colStatusText.Name = "colStatusText";
            this.colStatusText.Visible = true;
            this.colStatusText.VisibleIndex = 3;
            // 
            // custodianasseterrorProvider
            // 
            this.custodianasseterrorProvider.ContainerControl = this;
            this.custodianasseterrorProvider.DataSource = this.cutodianassetbindingSource;
            // 
            // btnAssignAsset
            // 
            this.btnAssignAsset.Location = new System.Drawing.Point(138, 187);
            this.btnAssignAsset.Name = "btnAssignAsset";
            this.btnAssignAsset.Size = new System.Drawing.Size(75, 23);
            this.btnAssignAsset.TabIndex = 1;
            this.btnAssignAsset.Text = "Assign";
            this.btnAssignAsset.Click += new System.EventHandler(this.btnAssignAsset_Click);
            // 
            // btnCancel
            // 
            this.btnCancel.Location = new System.Drawing.Point(232, 187);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(75, 23);
            this.btnCancel.TabIndex = 2;
            this.btnCancel.Text = "Cancel";
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // CustodianAssetView
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(407, 213);
            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.btnAssignAsset);
            this.Controls.Add(this.groupBox1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "CustodianAssetView";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Assign Asset:";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.cutodianassetbindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cmbDateFrom.Properties.VistaTimeProperties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cmbDateFrom.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cmbcustodian.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cutodianbindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridLookUpEdit1View)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.custodianasseterrorProvider)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtRemark;
        private DevExpress.XtraEditors.DateEdit cmbDateFrom;
        private System.Windows.Forms.BindingSource cutodianassetbindingSource;
        private System.Windows.Forms.ErrorProvider custodianasseterrorProvider;
        private System.Windows.Forms.Label label4;
        private DevExpress.XtraEditors.GridLookUpEdit cmbcustodian;
        private DevExpress.XtraGrid.Views.Grid.GridView gridLookUpEdit1View;
        private DevExpress.XtraGrid.Columns.GridColumn colBadgeNo;
        private DevExpress.XtraGrid.Columns.GridColumn colFirstName;
        private DevExpress.XtraGrid.Columns.GridColumn colLastName;
        private DevExpress.XtraGrid.Columns.GridColumn colStatusText;
        private DevExpress.XtraEditors.SimpleButton btnAssignAsset;
        private System.Windows.Forms.BindingSource cutodianbindingSource;
        private DevExpress.XtraEditors.SimpleButton btnCancel;
    }
}