CREATE VIEW stock.stock_status_info
AS
SELECT     stock.stock_status.item_id, stock.stock_status.warehouse_id, stock.stock_status.quantity, stock.warehouse.name AS warehouse_name, stock.item_info.item_no, 
                      stock.item_info.unit_name, stock.item_info.category_name
FROM         stock.stock_status INNER JOIN
                      stock.warehouse ON stock.stock_status.warehouse_id = stock.warehouse.warehouse_id INNER JOIN
                      stock.item_info ON stock.stock_status.item_id = stock.item_info.item_id