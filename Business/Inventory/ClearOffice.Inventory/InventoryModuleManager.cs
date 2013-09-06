using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using ClearOffice.Infrastructure;
using ClearOffice.Inventory.Views;

namespace ClearOffice.Inventory
{
    public class InventoryModuleManager:IModule
    {
        #region IModule Members
        
        public void Run()
        {
            throw new NotImplementedException();
        }

        public void AddServices()
        {
            throw new NotImplementedException();
        }

        public void AddViews()
        {
            throw new NotImplementedException();
        }

        public void ExtendRibbon()
        {
            throw new NotImplementedException();
        }

        public void ExtendStatusBar()
        {
            throw new NotImplementedException();
        } 

        #endregion

        #region Inventory Module Public Methods

        public ItemsListView ShowInventoryItemsList()
        {
            return new ItemsListView();
        }

        public ReceivingList ShowReceivings()
        {
            return new ReceivingList();
        }

        public StockStatusView ShowStockStatus()
        {
            return  new StockStatusView();
        }

        public IssueListView ShowIssueList()
        {
            return new IssueListView();
        }

        public ReturnListView ShowReturnList()
        {
            return new ReturnListView();
        }

        public TransferListView ShowTranferList()
        {
            return new TransferListView();
        }
        #endregion
    }
}
