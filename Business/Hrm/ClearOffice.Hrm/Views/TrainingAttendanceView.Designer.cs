namespace ClearOffice.Hrm.Views
{
    partial class TrainingAttendanceView
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
            this.attendanceBindingSource = new System.Windows.Forms.BindingSource();
            this.trainingEmployeeGrid = new DevExpress.XtraGrid.GridControl();
            this.gridView1 = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.colEmployeeNo = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colFullName = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colJobTitle = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colNodeName = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colAttended = new DevExpress.XtraGrid.Columns.GridColumn();
            this.btnSave = new DevExpress.XtraEditors.SimpleButton();
            this.btnCancel = new DevExpress.XtraEditors.SimpleButton();
            ((System.ComponentModel.ISupportInitialize)(this.attendanceBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.trainingEmployeeGrid)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // attendanceBindingSource
            // 
            this.attendanceBindingSource.DataSource = typeof(ClearOffice.Hrm.Business.Data.EmployeeInfoTraining);
            // 
            // trainingEmployeeGrid
            // 
            this.trainingEmployeeGrid.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.trainingEmployeeGrid.DataSource = this.attendanceBindingSource;
            this.trainingEmployeeGrid.Location = new System.Drawing.Point(5, 10);
            this.trainingEmployeeGrid.MainView = this.gridView1;
            this.trainingEmployeeGrid.Name = "trainingEmployeeGrid";
            this.trainingEmployeeGrid.Size = new System.Drawing.Size(660, 357);
            this.trainingEmployeeGrid.TabIndex = 1;
            this.trainingEmployeeGrid.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridView1});
            // 
            // gridView1
            // 
            this.gridView1.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.colEmployeeNo,
            this.colFullName,
            this.colJobTitle,
            this.colNodeName,
            this.colAttended});
            this.gridView1.GridControl = this.trainingEmployeeGrid;
            this.gridView1.Name = "gridView1";
            this.gridView1.OptionsView.ShowAutoFilterRow = true;
            this.gridView1.OptionsView.ShowGroupPanel = false;
            // 
            // colEmployeeNo
            // 
            this.colEmployeeNo.FieldName = "EmployeeNo";
            this.colEmployeeNo.Name = "colEmployeeNo";
            this.colEmployeeNo.OptionsColumn.AllowEdit = false;
            this.colEmployeeNo.Visible = true;
            this.colEmployeeNo.VisibleIndex = 2;
            this.colEmployeeNo.Width = 198;
            // 
            // colFullName
            // 
            this.colFullName.FieldName = "FullName";
            this.colFullName.Name = "colFullName";
            this.colFullName.OptionsColumn.AllowEdit = false;
            this.colFullName.Visible = true;
            this.colFullName.VisibleIndex = 1;
            this.colFullName.Width = 198;
            // 
            // colJobTitle
            // 
            this.colJobTitle.Caption = "Position";
            this.colJobTitle.FieldName = "JobTitle";
            this.colJobTitle.Name = "colJobTitle";
            this.colJobTitle.OptionsColumn.AllowEdit = false;
            this.colJobTitle.Visible = true;
            this.colJobTitle.VisibleIndex = 3;
            this.colJobTitle.Width = 198;
            // 
            // colNodeName
            // 
            this.colNodeName.Caption = "Department";
            this.colNodeName.FieldName = "NodeName";
            this.colNodeName.Name = "colNodeName";
            this.colNodeName.OptionsColumn.AllowEdit = false;
            this.colNodeName.Visible = true;
            this.colNodeName.VisibleIndex = 4;
            this.colNodeName.Width = 201;
            // 
            // colAttended
            // 
            this.colAttended.Caption = "Select Attendees ";
            this.colAttended.FieldName = "Attended";
            this.colAttended.Name = "colAttended";
            this.colAttended.Visible = true;
            this.colAttended.VisibleIndex = 0;
            this.colAttended.Width = 20;
            // 
            // btnSave
            // 
            this.btnSave.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.btnSave.Location = new System.Drawing.Point(256, 373);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(75, 23);
            this.btnSave.TabIndex = 1;
            this.btnSave.Text = "Save";
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // btnCancel
            // 
            this.btnCancel.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.btnCancel.CausesValidation = false;
            this.btnCancel.Location = new System.Drawing.Point(337, 373);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(75, 23);
            this.btnCancel.TabIndex = 2;
            this.btnCancel.Text = "Cancel";
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // TrainingAttendanceView
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(669, 406);
            this.Controls.Add(this.trainingEmployeeGrid);
            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.btnSave);
            this.Name = "TrainingAttendanceView";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Attendance";
            ((System.ComponentModel.ISupportInitialize)(this.attendanceBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.trainingEmployeeGrid)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.BindingSource attendanceBindingSource;
        private DevExpress.XtraGrid.GridControl trainingEmployeeGrid;
        private DevExpress.XtraGrid.Views.Grid.GridView gridView1;
        private DevExpress.XtraGrid.Columns.GridColumn colFullName;
        private DevExpress.XtraGrid.Columns.GridColumn colEmployeeNo;
        private DevExpress.XtraGrid.Columns.GridColumn colJobTitle;
        private DevExpress.XtraGrid.Columns.GridColumn colNodeName;
        private DevExpress.XtraGrid.Columns.GridColumn colAttended;
        private DevExpress.XtraEditors.SimpleButton btnSave;
        private DevExpress.XtraEditors.SimpleButton btnCancel;
    }
}