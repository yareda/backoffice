CREATE VIEW stock.receiving_info
AS
SELECT     stock.receiving.*, stock.supplier.name AS supplier_name, stock.warehouse.name AS warehouse_name, stock.transaction_status.name AS status_name
FROM         stock.receiving LEFT OUTER JOIN
                      stock.supplier ON stock.receiving.supplier_id = stock.supplier.supplier_id LEFT OUTER JOIN
                      stock.warehouse ON stock.receiving.warehouse_id = stock.warehouse.warehouse_id LEFT OUTER JOIN
                      stock.transaction_status ON stock.receiving.status_id = stock.transaction_status.status_id