CREATE VIEW stock.transfer_info
AS
SELECT     stock.transfer.transfer_id, stock.transfer.status_id, stock.transfer.transfer_no, stock.transfer.transfer_date, stock.transfer.transfer_by, stock.transfer.posted_date, 
                      stock.transfer.posted_by, stock.transfer.warehouse_from, stock.transfer.warehouse_to, stock.transfer.remark, source.name AS source_warehouse, 
                      destination.name AS destination_warehouse, stock.transaction_status.name AS status
FROM         stock.transfer INNER JOIN
                      stock.warehouse AS source ON stock.transfer.warehouse_from = source.warehouse_id INNER JOIN
                      stock.warehouse AS destination ON stock.transfer.warehouse_to = destination.warehouse_id INNER JOIN
                      stock.transaction_status ON stock.transfer.status_id = stock.transaction_status.status_id