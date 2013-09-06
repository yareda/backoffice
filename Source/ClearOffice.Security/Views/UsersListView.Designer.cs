namespace ClearOffice.Security.Views
{
    partial class UsersListView
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(UsersListView));
            DevExpress.XtraGrid.StyleFormatCondition styleFormatCondition1 = new DevExpress.XtraGrid.StyleFormatCondition();
            this.colDisabled = new DevExpress.XtraGrid.Columns.GridColumn();
            this.ribbonControl1 = new DevExpress.XtraBars.Ribbon.RibbonControl();
            this.smallImageCollection = new DevExpress.Utils.ImageCollection(this.components);
            this.addUserBarButtonItem = new DevExpress.XtraBars.BarButtonItem();
            this.refreshBarButtonItem = new DevExpress.XtraBars.BarButtonItem();
            this.disableBarButtonItem = new DevExpress.XtraBars.BarButtonItem();
            this.largeImageCollection = new DevExpress.Utils.ImageCollection(this.components);
            this.ribbonPage1 = new DevExpress.XtraBars.Ribbon.RibbonPage();
            this.ribbonPageGroup1 = new DevExpress.XtraBars.Ribbon.RibbonPageGroup();
            this.gridControl1 = new DevExpress.XtraGrid.GridControl();
            this.usersBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.gridView1 = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.colUserName = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colFullName = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colPasswordNeverExpires = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colCanNotChangePassword = new DevExpress.XtraGrid.Columns.GridColumn();
            this.resetPasswordBarButtonItem = new DevExpress.XtraBars.BarButtonItem();
            ((System.ComponentModel.ISupportInitialize)(this.ribbonControl1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.smallImageCollection)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.largeImageCollection)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridControl1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.usersBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // colDisabled
            // 
            this.colDisabled.FieldName = "Disabled";
            this.colDisabled.Name = "colDisabled";
            this.colDisabled.Visible = true;
            this.colDisabled.VisibleIndex = 3;
            // 
            // ribbonControl1
            // 
            this.ribbonControl1.ApplicationButtonText = null;
            // 
            // 
            // 
            this.ribbonControl1.ExpandCollapseItem.Id = 0;
            this.ribbonControl1.ExpandCollapseItem.Name = "";
            this.ribbonControl1.Images = this.smallImageCollection;
            this.ribbonControl1.Items.AddRange(new DevExpress.XtraBars.BarItem[] {
            this.ribbonControl1.ExpandCollapseItem,
            this.addUserBarButtonItem,
            this.refreshBarButtonItem,
            this.disableBarButtonItem,
            this.resetPasswordBarButtonItem});
            this.ribbonControl1.LargeImages = this.largeImageCollection;
            this.ribbonControl1.Location = new System.Drawing.Point(0, 0);
            this.ribbonControl1.MaxItemId = 5;
            this.ribbonControl1.Name = "ribbonControl1";
            this.ribbonControl1.Pages.AddRange(new DevExpress.XtraBars.Ribbon.RibbonPage[] {
            this.ribbonPage1});
            this.ribbonControl1.SelectedPage = this.ribbonPage1;
            this.ribbonControl1.Size = new System.Drawing.Size(786, 143);
            // 
            // smallImageCollection
            // 
            this.smallImageCollection.ImageStream = ((DevExpress.Utils.ImageCollectionStreamer)(resources.GetObject("smallImageCollection.ImageStream")));
            this.smallImageCollection.Images.SetKeyName(0, "Refresh_16x16.png");
            this.smallImageCollection.Images.SetKeyName(1, "user_add.png");
            this.smallImageCollection.Images.SetKeyName(2, "user_delete.png");
            this.smallImageCollection.Images.SetKeyName(3, "user_gray.png");
            this.smallImageCollection.Images.SetKeyName(4, "keys-16x16.png");
            // 
            // addUserBarButtonItem
            // 
            this.addUserBarButtonItem.Caption = "Add User";
            this.addUserBarButtonItem.Id = 1;
            this.addUserBarButtonItem.ImageIndex = 1;
            this.addUserBarButtonItem.Name = "addUserBarButtonItem";
            this.addUserBarButtonItem.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.addUserBarButtonItem_ItemClick);
            // 
            // refreshBarButtonItem
            // 
            this.refreshBarButtonItem.Caption = "Refresh";
            this.refreshBarButtonItem.Id = 2;
            this.refreshBarButtonItem.ImageIndex = 0;
            this.refreshBarButtonItem.LargeImageIndex = 0;
            this.refreshBarButtonItem.Name = "refreshBarButtonItem";
            this.refreshBarButtonItem.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.refreshBarButtonItem_ItemClick);
            // 
            // disableBarButtonItem
            // 
            this.disableBarButtonItem.Caption = "Disable/Enable";
            this.disableBarButtonItem.Id = 3;
            this.disableBarButtonItem.ImageIndex = 3;
            this.disableBarButtonItem.Name = "disableBarButtonItem";
            this.disableBarButtonItem.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.disableBarButtonItem_ItemClick);
            // 
            // largeImageCollection
            // 
            this.largeImageCollection.ImageSize = new System.Drawing.Size(32, 32);
            this.largeImageCollection.ImageStream = ((DevExpress.Utils.ImageCollectionStreamer)(resources.GetObject("largeImageCollection.ImageStream")));
            this.largeImageCollection.Images.SetKeyName(0, "GenerateData_32x32.png");
            // 
            // ribbonPage1
            // 
            this.ribbonPage1.Groups.AddRange(new DevExpress.XtraBars.Ribbon.RibbonPageGroup[] {
            this.ribbonPageGroup1});
            this.ribbonPage1.Name = "ribbonPage1";
            this.ribbonPage1.Text = "Administration";
            // 
            // ribbonPageGroup1
            // 
            this.ribbonPageGroup1.ItemLinks.Add(this.refreshBarButtonItem);
            this.ribbonPageGroup1.ItemLinks.Add(this.addUserBarButtonItem);
            this.ribbonPageGroup1.ItemLinks.Add(this.disableBarButtonItem);
            this.ribbonPageGroup1.ItemLinks.Add(this.resetPasswordBarButtonItem);
            this.ribbonPageGroup1.Name = "ribbonPageGroup1";
            this.ribbonPageGroup1.Text = "Security";
            // 
            // gridControl1
            // 
            this.gridControl1.DataSource = this.usersBindingSource;
            this.gridControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gridControl1.Location = new System.Drawing.Point(0, 143);
            this.gridControl1.MainView = this.gridView1;
            this.gridControl1.MenuManager = this.ribbonControl1;
            this.gridControl1.Name = "gridControl1";
            this.gridControl1.Size = new System.Drawing.Size(786, 380);
            this.gridControl1.TabIndex = 1;
            this.gridControl1.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridView1});
            // 
            // usersBindingSource
            // 
            this.usersBindingSource.DataSource = typeof(ClearOffice.Security.Data.User);
            // 
            // gridView1
            // 
            this.gridView1.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.colUserName,
            this.colFullName,
            this.colDisabled,
            this.colPasswordNeverExpires,
            this.colCanNotChangePassword});
            styleFormatCondition1.Appearance.BackColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            styleFormatCondition1.ApplyToRow = true;
            styleFormatCondition1.Column = this.colDisabled;
            styleFormatCondition1.Condition = DevExpress.XtraGrid.FormatConditionEnum.Equal;
            styleFormatCondition1.Expression = "[Disabled] == True";
            this.gridView1.FormatConditions.AddRange(new DevExpress.XtraGrid.StyleFormatCondition[] {
            styleFormatCondition1});
            this.gridView1.GridControl = this.gridControl1;
            this.gridView1.Name = "gridView1";
            this.gridView1.OptionsBehavior.Editable = false;
            this.gridView1.OptionsView.ShowAutoFilterRow = true;
            this.gridView1.OptionsView.ShowGroupPanel = false;
            // 
            // colUserName
            // 
            this.colUserName.FieldName = "UserName";
            this.colUserName.Name = "colUserName";
            this.colUserName.Visible = true;
            this.colUserName.VisibleIndex = 0;
            // 
            // colFullName
            // 
            this.colFullName.FieldName = "FullName";
            this.colFullName.Name = "colFullName";
            this.colFullName.Visible = true;
            this.colFullName.VisibleIndex = 1;
            // 
            // colPasswordNeverExpires
            // 
            this.colPasswordNeverExpires.FieldName = "PasswordNeverExpires";
            this.colPasswordNeverExpires.Name = "colPasswordNeverExpires";
            this.colPasswordNeverExpires.Visible = true;
            this.colPasswordNeverExpires.VisibleIndex = 2;
            // 
            // colCanNotChangePassword
            // 
            this.colCanNotChangePassword.FieldName = "CanNotChangePassword";
            this.colCanNotChangePassword.Name = "colCanNotChangePassword";
            this.colCanNotChangePassword.Visible = true;
            this.colCanNotChangePassword.VisibleIndex = 4;
            // 
            // resetPasswordBarButtonItem
            // 
            this.resetPasswordBarButtonItem.Caption = "Set Password";
            this.resetPasswordBarButtonItem.Id = 4;
            this.resetPasswordBarButtonItem.ImageIndex = 4;
            this.resetPasswordBarButtonItem.Name = "resetPasswordBarButtonItem";
            this.resetPasswordBarButtonItem.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.resetPasswordBarButtonItem_ItemClick);
            // 
            // UsersListView
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(786, 523);
            this.Controls.Add(this.gridControl1);
            this.Controls.Add(this.ribbonControl1);
            this.Name = "UsersListView";
            this.Text = "Users";
            this.Activated += new System.EventHandler(this.UsersListView_Activated);
            ((System.ComponentModel.ISupportInitialize)(this.ribbonControl1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.smallImageCollection)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.largeImageCollection)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridControl1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.usersBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraBars.Ribbon.RibbonControl ribbonControl1;
        private DevExpress.XtraBars.Ribbon.RibbonPage ribbonPage1;
        private DevExpress.XtraBars.Ribbon.RibbonPageGroup ribbonPageGroup1;
        private DevExpress.XtraGrid.GridControl gridControl1;
        private DevExpress.XtraGrid.Views.Grid.GridView gridView1;
        private DevExpress.XtraBars.BarButtonItem addUserBarButtonItem;
        private DevExpress.XtraBars.BarButtonItem refreshBarButtonItem;
        private DevExpress.Utils.ImageCollection largeImageCollection;
        private DevExpress.Utils.ImageCollection smallImageCollection;
        private DevExpress.XtraBars.BarButtonItem disableBarButtonItem;
        private System.Windows.Forms.BindingSource usersBindingSource;
        private DevExpress.XtraGrid.Columns.GridColumn colUserName;
        private DevExpress.XtraGrid.Columns.GridColumn colFullName;
        private DevExpress.XtraGrid.Columns.GridColumn colDisabled;
        private DevExpress.XtraGrid.Columns.GridColumn colPasswordNeverExpires;
        private DevExpress.XtraGrid.Columns.GridColumn colCanNotChangePassword;
        private DevExpress.XtraBars.BarButtonItem resetPasswordBarButtonItem;
    }
}