CREATE VIEW stock.item_info
AS
SELECT     stock.item.*, stock.measurement_unit.name AS unit_name, stock.category.name AS category_name, stock.sub_category.name AS sub_category_name
FROM         stock.item LEFT OUTER JOIN
                      stock.sub_category ON stock.item.sub_category_id = stock.sub_category.sub_category_id LEFT OUTER JOIN
                      stock.category ON stock.sub_category.category_id = stock.category.category_id AND stock.item.category_id = stock.category.category_id LEFT OUTER JOIN
                      stock.measurement_unit ON stock.item.unit_id = stock.measurement_unit.unit_id