CREATE VIEW stock.warehouse_item_info
AS
SELECT     stock.item_info.item_id, stock.item_info.item_no, stock.item_info.description, stock.item_info.unit_name, stock.item_info.category_name, 
                      stock.item_info.sub_category_name, stock.stock_status.warehouse_id
FROM         stock.stock_status INNER JOIN
                      stock.item_info ON stock.stock_status.item_id = stock.item_info.item_id