CREATE VIEW stock.adjustment_info
AS
SELECT     stock.adjustment.*, stock.warehouse.name AS warehouse, stock.transaction_status.name AS status
FROM         stock.adjustment INNER JOIN
                      stock.warehouse ON stock.adjustment.warehouse_id = stock.warehouse.warehouse_id INNER JOIN
                      stock.transaction_status ON stock.adjustment.status_id = stock.transaction_status.status_id