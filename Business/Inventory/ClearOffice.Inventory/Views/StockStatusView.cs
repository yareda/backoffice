using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using DevExpress.XtraEditors;
using ClearOffice.Infrastructure;
using ClearOffice.Inventory.DataAccess;

namespace ClearOffice.Inventory.Views
{
    public partial class StockStatusView : DevExpress.XtraEditors.XtraForm, IListForm
    {
        private InventoryEntities context;

        public StockStatusView()
        {
            InitializeComponent();
            context = new InventoryEntities();
        }

        public void ShowList()
        {
            stockStatusbindingSource.DataSource = context.StockStatusInfoes.ToList();
        }

        public void OpenSelectedItem()
        {
            throw new NotImplementedException();
        }

        public object GetSelectedItem()
        {
            return stockStatusbindingSource.Current;
        }

        public void RefreshList()
        {
            context = new InventoryEntities();
            ShowList();
        }

        public void AuthorizeForm()
        {
            throw new NotImplementedException();
        }

        private void refreshBarButtonItem_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            RefreshList();
        }
    }
}