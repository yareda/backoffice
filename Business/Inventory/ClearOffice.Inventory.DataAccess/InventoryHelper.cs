using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data.Objects;
using System.Linq;
using System.Text;
using System.Threading;
using System.Transactions;
using ClearOffice.Security;
using System.Data.EntityClient;
using System.Data.SqlClient;

namespace ClearOffice.Inventory.DataAccess
{
    public class InventoryHelper
    {
        private const string INVENTORY_CONNECTION = "InventoryEntities";

        #region Record Status Codes

        public const int STATUS_PENDING = 0;
        public const int STATUS_APPROVED = 1;
        public const int STATUS_REJECTED = 2;
        public const int STATUS_POSTED = 3;
        public const int STATUS_CLOSED = 4;
        public const int STATUS_UNKNOWN = 4;

        #endregion

        #region Transaction Owner Types

        public const int OWNER_RECEIVING = 1;
        public const int OWNER_ISSUE = 2;
        public const int OWNER_RETURN = 3;
        public const int OWNER_TRANSFER = 4;
        public const int OWNER_ADJUSTMENT = 5;
        public const int OWNER_OPENING_BALANCE = 6;

        #endregion

        #region Sequence Number Management Functions

        public static string GetNextGrnNo()
        {
            var context = new InventoryEntities();

            var sn = context.SequenceCounters.First();
            var current = sn.GRN;
            var values = current.Split('-');
            var no = values[1];
            var nextNo = Convert.ToInt32(no);
            nextNo = nextNo + 1;
            var formatted = nextNo.ToString();
            var temp = string.Empty;

            if (formatted.Length < 6)
            {
                for (int i = 0; i < (6 - formatted.Length); i++)
                {
                    temp += "0";
                }
                formatted = string.Format("GRN-{0}{1}", temp, formatted);
            }

            return formatted;
        }

        public static string GetNextIssueNo()
        {
            var context = new InventoryEntities();

            var sn = context.SequenceCounters.First();
            var current = sn.IssueNo;
            var values = current.Split('-');
            var no = values[1];
            var nextNo = Convert.ToInt32(no);
            nextNo = nextNo + 1;
            var formatted = nextNo.ToString();
            var temp = string.Empty;

            if (formatted.Length < 6)
            {
                for (int i = 0; i < (6 - formatted.Length); i++)
                {
                    temp += "0";
                }
                formatted = string.Format("GIN-{0}{1}", temp, formatted);
            }

            return formatted;
        }

        public static string GetNextTransferNo()
        {
            var context = new InventoryEntities();

            var sn = context.SequenceCounters.First();
            var current = sn.TransferNo;
            var values = current.Split('-');
            var no = values[1];
            var nextNo = Convert.ToInt32(no);
            nextNo = nextNo + 1;
            var formatted = nextNo.ToString();
            var temp = string.Empty;

            if (formatted.Length < 6)
            {
                for (int i = 0; i < (6 - formatted.Length); i++)
                {
                    temp += "0";
                }
                formatted = string.Format("TRN-{0}{1}", temp, formatted);
            }

            return formatted;
        }

        public static string GetNextReturnNo()
        {
            var context = new InventoryEntities();

            var sn = context.SequenceCounters.First();
            var current = sn.ReturnNo;
            var values = current.Split('-');
            var no = values[1];
            var nextNo = Convert.ToInt32(no);
            nextNo = nextNo + 1;
            var formatted = nextNo.ToString();
            var temp = string.Empty;

            if (formatted.Length < 6)
            {
                for (int i = 0; i < (6 - formatted.Length); i++)
                {
                    temp += "0";
                }
                formatted = string.Format("SRN-{0}{1}", temp, formatted);
            }

            return formatted;
        }

        public static string GetNextAdjustmentNo()
        {
            var context = new InventoryEntities();

            var sn = context.SequenceCounters.First();
            var current = sn.AdjustmentNo;
            var values = current.Split('-');
            var no = values[1];
            var nextNo = Convert.ToInt32(no);
            nextNo = nextNo + 1;
            var formatted = nextNo.ToString();
            var temp = string.Empty;

            if (formatted.Length < 6)
            {
                for (int i = 0; i < (6 - formatted.Length); i++)
                {
                    temp += "0";
                }
                formatted = string.Format("AJN-{0}{1}", temp, formatted);
            }

            return formatted;
        }

        public static void UpdateGRNumber(string nextNo)
        {
            using (var ctx = new InventoryEntities())
            {
                ctx.UpdateGrnNo(nextNo);
            }
        }

        public static void UpdateIssueNo(string nextNo)
        {
            using (var ctx = new InventoryEntities())
            {
                ctx.UpdateIssueNo(nextNo);
            }
        }

        public static void UpdateTransferNo(string nextNo)
        {
            using (var ctx = new InventoryEntities())
            {
                ctx.UpdateTransferNo(nextNo);
            }
        }

        public static void UpdateReturnNo(string nextNo)
        {
            using (var ctx = new InventoryEntities())
            {
                ctx.UpdateReturnNo(nextNo);
            }
        }

        public static void UpdateAdjustmentNo(string nextNo)
        {
            using (var ctx = new InventoryEntities())
            {
                ctx.UpdateAdjustmentNo(nextNo);
            }
        }

        #endregion

        #region Transaction Business Logic

        public static void PostReceiving(int receivingId)
        {
            // Open a connection manualy since EF has issues with MSDTC transactions
            var connection = new EntityConnection(ConfigurationManager.ConnectionStrings[INVENTORY_CONNECTION].ConnectionString);
            connection.Open();

            var context = new InventoryEntities(connection);

            var receiving = context.Receivings.Single(r => r.ReceivingId == receivingId);

            try
            {
                using (EntityTransaction scope = connection.BeginTransaction())
                {
                    foreach (var item in receiving.ReceivingItems)
                    {
                        // Check if the current item already exists in the 'stock_status' table
                        if (!context.StockStatus.Where(s => s.ItemId == item.ItemId && s.WarehouseId == receiving.WarehouseId).Any())
                        {
                            using (var c = new InventoryEntities())
                            {
                                var status = new StockStatus();
                                status.ItemId = item.ItemId.Value;
                                status.WarehouseId = receiving.WarehouseId;
                                status.Quantity = 0;
                                c.StockStatus.AddObject(status);
                                c.SaveChanges();
                            }
                        }

                        // If the item already exists in the table then update the quantity field
                        var statusUpdate = context.StockStatus.SingleOrDefault(
                                s => s.ItemId == item.ItemId && s.WarehouseId == receiving.WarehouseId);
                        statusUpdate.Quantity += item.Quantity;

                        // Add transaction log
                        var transaction = new StockTransaction();
                        transaction.TransactionTypeId = OWNER_RECEIVING;
                        transaction.OwnerId = receiving.ReceivingId;
                        transaction.ItemId = item.ItemId;
                        transaction.Quantity = item.Quantity;
                        transaction.WarehouseId = receiving.WarehouseId;
                        transaction.TransactionDate = DateTime.Now;
                        AddTransactionRecord(transaction);
                    }
                    // Update PostedDate and PostedBy fields for the Receiving record
                    receiving.StatusId = STATUS_POSTED;
                    receiving.PostedDate = DateTime.Now;  //TODO: Consider getting the date from the server instead of the client.
                    var user = SecurityHelper.GetUserDetail(Thread.CurrentPrincipal.Identity.Name);
                    receiving.PostedBy = string.Format("{0} ({1})", user.FullName, user.UserName);

                    // SEND ALL CHANGES TO THE DATABASE - MIGHTY SAVE!!!!!!
                    context.SaveChanges();

                    scope.Commit();
                }

            }
            catch (Exception exception)
            {
                throw new ApplicationException("Error occured while posting the current receiving.", exception);
            }

            // Close the connection
            connection.Close();
        }

        public static void PostIssue(int issueId)
        {
            // Open a connection manualy since EF has issues with MSDTC transactions
            var connection = new EntityConnection(ConfigurationManager.ConnectionStrings[INVENTORY_CONNECTION].ConnectionString);
            connection.Open();

            var context = new InventoryEntities(connection);
            var issue = context.Issues.Single(i => i.IssueId == issueId);
            var warehouse = issue.WarehouseId;
            try
            {
                using (EntityTransaction scope = connection.BeginTransaction())
                {
                    foreach (var item in issue.IssueItems)
                    {
                        // 1. Check the availablity of stock (ItemId and WarehouseId)    
                        var stock = context.StockStatus.Single(s => s.ItemId == item.ItemId && s.WarehouseId == warehouse);

                        // 2. If availalbe < requested then throw an error
                        if (stock.Quantity < item.Quantity)
                        {
                            var msg = "Error posting current record. The requested and available quantity do not match.\n";
                            msg += string.Format("Item: {0} \nAvailable Quantity: {1}\nRequested Quantity:{2}", item.ItemDetail.ItemNo, stock.Quantity, item.Quantity);
                            throw new ApplicationException(msg);
                        }

                        // 3. If available > requested then update balance and set status of issue to posted.
                        var status = context.StockStatus.Single(s => s.ItemId == item.ItemId && s.WarehouseId == warehouse);
                        status.Quantity -= item.Quantity;

                        // 4. Add transaction log to stock_transaction
                        var transaction = new StockTransaction();
                        transaction.TransactionTypeId = OWNER_ISSUE;
                        transaction.OwnerId = issue.IssueId;
                        transaction.ItemId = item.ItemId;
                        transaction.Quantity = item.Quantity;
                        transaction.WarehouseId = warehouse;
                        transaction.TransactionDate = DateTime.Now;
                        AddTransactionRecord(transaction);

                        issue.StatusId = STATUS_POSTED;
                        issue.PostedDate = DateTime.Now;  //TODO: Consider getting the date from the server instead of the client.
                        var user = SecurityHelper.GetUserDetail(Thread.CurrentPrincipal.Identity.Name);
                        issue.PostedBy = string.Format("{0} ({1})", user.FullName, user.UserName);

                        // SEND ALL CHANGES TO THE DATABASE - MIGHTY SAVE!!!!!!
                        context.SaveChanges();

                        scope.Commit();
                    }
                }
            }
            catch (Exception exception)
            {
                throw new ApplicationException("Error occured while posting the current issue.", exception);
            }
        }

        public static void PostReturn(int returnId)
        {
            // Open a connection manualy since EF has issues with MSDTC transactions
            var connection = new EntityConnection(ConfigurationManager.ConnectionStrings[INVENTORY_CONNECTION].ConnectionString);
            connection.Open();

            var context = new InventoryEntities(connection);

            var returnItem = context.ItemReturns.Single(r => r.ReturnId == returnId);

            try
            {
                using (EntityTransaction scope = connection.BeginTransaction())
                {
                    foreach (var item in returnItem.ReturnedItems)
                    {
                        // Check if the current item already exists in the 'stock_status' table
                        if (!context.StockStatus.Where(s => s.ItemId == item.ItemId && s.WarehouseId == returnItem.WarehouseId).Any())
                        {
                            using (var c = new InventoryEntities())
                            {
                                var status = new StockStatus();
                                status.ItemId = item.ItemId.Value;
                                status.WarehouseId = returnItem.WarehouseId.Value;
                                status.Quantity = 0;
                                c.StockStatus.AddObject(status);
                                c.SaveChanges();
                            }
                        }

                        // If the item already exists in the table then update the quantity field
                        var statusUpdate = context.StockStatus.SingleOrDefault(
                                s => s.ItemId == item.ItemId && s.WarehouseId == returnItem.WarehouseId);
                        statusUpdate.Quantity += item.Quantity;

                        // Add transaction log
                        var transaction = new StockTransaction();
                        transaction.TransactionTypeId = OWNER_RETURN;
                        transaction.OwnerId = returnItem.ReturnId;
                        transaction.ItemId = item.ItemId;
                        transaction.Quantity = item.Quantity;
                        transaction.WarehouseId = returnItem.WarehouseId;
                        transaction.TransactionDate = DateTime.Now;
                        AddTransactionRecord(transaction);
                    }
                    // Update PostedDate and PostedBy fields for the Receiving record
                    returnItem.StatusId = STATUS_POSTED;
                    returnItem.PostedDate = DateTime.Now;  //TODO: Consider getting the date from the server instead of the client.
                    var user = SecurityHelper.GetUserDetail(Thread.CurrentPrincipal.Identity.Name);
                    returnItem.PostedBy = string.Format("{0} ({1})", user.FullName, user.UserName);

                    // SEND ALL CHANGES TO THE DATABASE - MIGHTY SAVE!!!!!!
                    context.SaveChanges();

                    scope.Commit();
                }

            }
            catch (Exception exception)
            {
                throw new ApplicationException("Error occured while posting stock return operation.", exception);
            }

            // Close the connection
            connection.Close();
        }

        public static void PostTransfer(int transferId)
        {
            // Open a connection manualy since EF has issues with MSDTC transactions
            var connection = new EntityConnection(ConfigurationManager.ConnectionStrings[INVENTORY_CONNECTION].ConnectionString);
            connection.Open();

            var context = new InventoryEntities(connection);

            // Tasks:
            // 1. Check if requested transfer amount exist at the source warehouse
            // 2. Check if transfered item exist in stock status @ destination warehouse
            // 3. Decrease source warehouse balance and increase destination warehouse
            // 4. Post transfer record and update audit log.

            var transfer = context.Transfers.Single(t => t.TransferId == transferId);
            var source = transfer.WarehouseFrom;
            var destination = transfer.WarehouseTo;
            try
            {
                using (EntityTransaction scope = connection.BeginTransaction())
                {
                    foreach (var item in transfer.TransferItems)
                    {
                        var itemId = item.ItemId;

                        // Check if requested transfer amount exist in source warehouse.
                        var sourceStatus =
                            context.StockStatus.Single(
                                s => s.ItemId == itemId && s.WarehouseId == source);
                        if (sourceStatus.Quantity < item.Quantity)
                        {
                            throw new ApplicationException(
                                "The current balance at the source warehouse is less than the requested transfer amount.");
                        }

                        // Check if we have a stock status record at the destination warehouse with the current item id. If not then we need to create one.
                        if (!context.StockStatus.Where(s => s.ItemId == itemId && s.WarehouseId == destination).Any())
                        {
                            using (var c = new InventoryEntities())
                            {
                                var status = new StockStatus();
                                status.ItemId = itemId.Value;
                                status.WarehouseId = destination.Value;
                                status.Quantity = 0;
                                c.StockStatus.AddObject(status);
                                c.SaveChanges();
                            }
                        }

                        // Decrease the quantity field for the source status update and increase that of the destination status update
                        var sourceStatusUpdate = context.StockStatus.SingleOrDefault(
                                s => s.ItemId == itemId && s.WarehouseId == source);
                        sourceStatusUpdate.Quantity -= item.Quantity;

                        var destinationStatusUpdate =
                            context.StockStatus.SingleOrDefault(
                                d => d.ItemId == itemId && d.WarehouseId == destination);
                        destinationStatusUpdate.Quantity += item.Quantity;

                        // Add transaction log
                        var transaction = new StockTransaction();
                        transaction.TransactionTypeId = OWNER_TRANSFER;
                        transaction.OwnerId = transfer.TransferId;
                        transaction.ItemId = itemId;
                        transaction.Quantity = item.Quantity;
                        transaction.WarehouseId = transfer.WarehouseFrom;
                        transaction.TransactionDate = DateTime.Now;
                        AddTransactionRecord(transaction);
                    }

                    // Update PostedDate and PostedBy fields for the Receiving record
                    transfer.StatusId = STATUS_POSTED;
                    transfer.PostedDate = DateTime.Now;  //TODO: Consider getting the date from the server instead of the client.
                    var user = SecurityHelper.GetUserDetail(Thread.CurrentPrincipal.Identity.Name);
                    transfer.PostedBy = string.Format("{0} ({1})", user.FullName, user.UserName);

                    // SEND ALL CHANGES TO THE DATABASE - MIGHTY SAVE!!!!!!
                    context.SaveChanges();

                    scope.Commit();
                }
            }

            catch (Exception exception)
            {
                throw new ApplicationException("Error occured while posting stock transfer operation.", exception);
            }

            connection.Close();
        }
        public static void PostAdjustment(int adjustmentId)
        {
            var connection =new EntityConnection(ConfigurationManager.ConnectionStrings[INVENTORY_CONNECTION].ConnectionString);
            connection.Open();

            var context = new InventoryEntities(connection);
            var adjust = context.Adjustments.Single(r => r.AdjustmentId == adjustmentId);
            try
            {
                using (EntityTransaction scope = connection.BeginTransaction())
                {
                    foreach (var item in adjust.adjustment_detail)
                    {
                        // Checking if the current item already exists in the 'stock_status' table
                        if (
                            !context.StockStatus.Where(
                                s => s.ItemId == item.ItemId && s.WarehouseId == adjust.WarehouseId).
                                 Any())
                        {
                            using (var c = new InventoryEntities())
                            {
                                var status = new StockStatus();
                                status.ItemId = item.ItemId.Value;
                                status.WarehouseId = adjust.WarehouseId.Value;
                                status.Quantity = item.AdjustedQuantity;
                                c.StockStatus.AddObject(status);
                                c.SaveChanges();
                            }
                        }
                        // If the item already exists in the table then update the quantity field
                        var statusUpdate = context.StockStatus.SingleOrDefault(
                            s => s.ItemId == item.ItemId && s.WarehouseId == adjust.WarehouseId);
                        statusUpdate.Quantity = item.AdjustedQuantity;

                        // Adding to stock transaction log
                        var transaction = new StockTransaction();
                        transaction.TransactionTypeId = OWNER_ADJUSTMENT;
                        transaction.OwnerId = adjust.AdjustmentId;
                        transaction.ItemId = item.ItemId;
                        transaction.Quantity = item.AdjustedQuantity;
                        transaction.WarehouseId = adjust.WarehouseId;
                        transaction.TransactionDate = DateTime.Now;
                        AddTransactionRecord(transaction);

                        adjust.StatusId = STATUS_POSTED;
                        adjust.PostedDate = DateTime.Now;
                        var user = SecurityHelper.GetUserDetail(Thread.CurrentPrincipal.Identity.Name);
                        adjust.PostedBy = string.Format("{0} ({1})", user.FullName, user.UserName);

                        // SEND ALL CHANGES TO THE DATABASE - MIGHTY SAVE!!!!!!
                        context.SaveChanges();

                        scope.Commit();
                    }

                    connection.Close();
                }

            }
            catch (Exception exception)
            {
                throw new ApplicationException("Unable to post adjustment", exception);
            }

        }

        private static void AddTransactionRecord(StockTransaction transaction)
        {
            var context = new InventoryEntities();
            try
            {
                context.StockTransactions.AddObject(transaction);
                context.SaveChanges();
            }
            catch (Exception exception)
            {
                throw new ApplicationException("Unable to save transaction log", exception);
            }
        }
        
        #endregion

        
    }
}
