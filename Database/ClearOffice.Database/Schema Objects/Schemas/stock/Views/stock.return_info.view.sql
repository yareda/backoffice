CREATE VIEW stock.return_info
AS
SELECT     stock.[return].*, stock.warehouse.name AS warehouse_name, stock.transaction_status.name AS status_name
FROM         stock.[return] INNER JOIN
                      stock.warehouse ON stock.[return].warehouse_id = stock.warehouse.warehouse_id INNER JOIN
                      stock.transaction_status ON stock.[return].status_id = stock.transaction_status.status_id