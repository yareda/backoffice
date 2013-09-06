namespace ClearOffice.Inventory.Views
{
    partial class InventoryLookupListView
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(InventoryLookupListView));
            System.Windows.Forms.ListViewGroup listViewGroup1 = new System.Windows.Forms.ListViewGroup("All List", System.Windows.Forms.HorizontalAlignment.Left);
            this.lookupItembindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.btnNewtoolstrip = new System.Windows.Forms.ToolStripButton();
            this.btndelete = new System.Windows.Forms.ToolStripButton();
            this.colLookupItemId = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colLookupId = new DevExpress.XtraGrid.Columns.GridColumn();
            this.collookup = new DevExpress.XtraGrid.Columns.GridColumn();
            this.splitContainer1 = new System.Windows.Forms.SplitContainer();
            this.gridView1 = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.colItemName = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridControl1 = new DevExpress.XtraGrid.GridControl();
            this.columnHeader1 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.inventorycategorylist = new System.Windows.Forms.ListView();
            ((System.ComponentModel.ISupportInitialize)(this.lookupItembindingSource)).BeginInit();
            this.toolStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).BeginInit();
            this.splitContainer1.Panel1.SuspendLayout();
            this.splitContainer1.Panel2.SuspendLayout();
            this.splitContainer1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridControl1)).BeginInit();
            this.SuspendLayout();
            // 
            // lookupItembindingSource
            // 
            this.lookupItembindingSource.DataSource = typeof(ClearOffice.Inventory.DataAccess.LookupItem);
            // 
            // toolStrip1
            // 
            this.toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.btnNewtoolstrip,
            this.btndelete});
            this.toolStrip1.Location = new System.Drawing.Point(0, 0);
            this.toolStrip1.Name = "toolStrip1";
            this.toolStrip1.Size = new System.Drawing.Size(552, 25);
            this.toolStrip1.TabIndex = 0;
            this.toolStrip1.Text = "toolStrip1";
            // 
            // btnNewtoolstrip
            // 
            this.btnNewtoolstrip.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.btnNewtoolstrip.Enabled = false;
            this.btnNewtoolstrip.Image = ((System.Drawing.Image)(resources.GetObject("btnNewtoolstrip.Image")));
            this.btnNewtoolstrip.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnNewtoolstrip.Name = "btnNewtoolstrip";
            this.btnNewtoolstrip.Size = new System.Drawing.Size(23, 22);
            this.btnNewtoolstrip.Text = "&New";
            this.btnNewtoolstrip.Click += new System.EventHandler(this.btnNewtoolstrip_Click);
            // 
            // btndelete
            // 
            this.btndelete.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.btndelete.Enabled = false;
            this.btndelete.Image = ((System.Drawing.Image)(resources.GetObject("btndelete.Image")));
            this.btndelete.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btndelete.Name = "btndelete";
            this.btndelete.Size = new System.Drawing.Size(23, 22);
            this.btndelete.Text = "toolStripButton1";
            this.btndelete.Click += new System.EventHandler(this.btndelete_Click);
            // 
            // colLookupItemId
            // 
            this.colLookupItemId.FieldName = "LookupItemId";
            this.colLookupItemId.Name = "colLookupItemId";
            this.colLookupItemId.Visible = true;
            this.colLookupItemId.VisibleIndex = 0;
            // 
            // colLookupId
            // 
            this.colLookupId.FieldName = "LookupId";
            this.colLookupId.Name = "colLookupId";
            this.colLookupId.Visible = true;
            this.colLookupId.VisibleIndex = 1;
            // 
            // collookup
            // 
            this.collookup.FieldName = "lookup";
            this.collookup.Name = "collookup";
            this.collookup.Visible = true;
            this.collookup.VisibleIndex = 3;
            // 
            // splitContainer1
            // 
            this.splitContainer1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer1.Location = new System.Drawing.Point(0, 0);
            this.splitContainer1.Name = "splitContainer1";
            // 
            // splitContainer1.Panel1
            // 
            this.splitContainer1.Panel1.Controls.Add(this.inventorycategorylist);
            // 
            // splitContainer1.Panel2
            // 
            this.splitContainer1.Panel2.Controls.Add(this.gridControl1);
            this.splitContainer1.Panel2.Controls.Add(this.toolStrip1);
            this.splitContainer1.Size = new System.Drawing.Size(772, 390);
            this.splitContainer1.SplitterDistance = 216;
            this.splitContainer1.TabIndex = 0;
            // 
            // gridView1
            // 
            this.gridView1.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.colItemName});
            this.gridView1.GridControl = this.gridControl1;
            this.gridView1.Name = "gridView1";
            this.gridView1.OptionsBehavior.Editable = false;
            this.gridView1.OptionsView.ShowGroupPanel = false;
            // 
            // colItemName
            // 
            this.colItemName.Caption = "Item";
            this.colItemName.FieldName = "ItemName";
            this.colItemName.Name = "colItemName";
            this.colItemName.Visible = true;
            this.colItemName.VisibleIndex = 0;
            // 
            // gridControl1
            // 
            this.gridControl1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.gridControl1.DataSource = this.lookupItembindingSource;
            this.gridControl1.Location = new System.Drawing.Point(3, 28);
            this.gridControl1.MainView = this.gridView1;
            this.gridControl1.Name = "gridControl1";
            this.gridControl1.Size = new System.Drawing.Size(546, 359);
            this.gridControl1.TabIndex = 10;
            this.gridControl1.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridView1});
            this.gridControl1.Click += new System.EventHandler(this.gridControl1_Click);
            this.gridControl1.DoubleClick += new System.EventHandler(this.gridControl1_DoubleClick);
            // 
            // columnHeader1
            // 
            this.columnHeader1.Text = "Lookup Categories";
            this.columnHeader1.Width = 248;
            // 
            // inventorycategorylist
            // 
            this.inventorycategorylist.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader1});
            this.inventorycategorylist.Dock = System.Windows.Forms.DockStyle.Fill;
            listViewGroup1.Header = "All List";
            listViewGroup1.Name = "listViewGroup1";
            this.inventorycategorylist.Groups.AddRange(new System.Windows.Forms.ListViewGroup[] {
            listViewGroup1});
            this.inventorycategorylist.Location = new System.Drawing.Point(0, 0);
            this.inventorycategorylist.Name = "inventorycategorylist";
            this.inventorycategorylist.Size = new System.Drawing.Size(216, 390);
            this.inventorycategorylist.TabIndex = 1;
            this.inventorycategorylist.UseCompatibleStateImageBehavior = false;
            this.inventorycategorylist.View = System.Windows.Forms.View.Details;
            this.inventorycategorylist.SelectedIndexChanged += new System.EventHandler(this.inventorycategorylist_SelectedIndexChanged);
            // 
            // InventoryLookupListView
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(772, 390);
            this.Controls.Add(this.splitContainer1);
            this.Name = "InventoryLookupListView";
            this.Text = "Inventory Lookup List View";
            ((System.ComponentModel.ISupportInitialize)(this.lookupItembindingSource)).EndInit();
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
            this.splitContainer1.Panel1.ResumeLayout(false);
            this.splitContainer1.Panel2.ResumeLayout(false);
            this.splitContainer1.Panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).EndInit();
            this.splitContainer1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridControl1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.BindingSource lookupItembindingSource;
        private System.Windows.Forms.ToolStrip toolStrip1;
        private System.Windows.Forms.ToolStripButton btnNewtoolstrip;
        private DevExpress.XtraGrid.Columns.GridColumn colLookupItemId;
        private DevExpress.XtraGrid.Columns.GridColumn colLookupId;
        private DevExpress.XtraGrid.Columns.GridColumn collookup;
        private System.Windows.Forms.SplitContainer splitContainer1;
        private System.Windows.Forms.ToolStripButton btndelete;
        private System.Windows.Forms.ListView inventorycategorylist;
        private System.Windows.Forms.ColumnHeader columnHeader1;
        private DevExpress.XtraGrid.GridControl gridControl1;
        private DevExpress.XtraGrid.Views.Grid.GridView gridView1;
        private DevExpress.XtraGrid.Columns.GridColumn colItemName;
    }
}