CREATE VIEW wms.customer_type_info
AS
SELECT     name AS customer_type_name, item_id
FROM         wms.lookup_item
WHERE     (lookup_id = 1)