CREATE VIEW fleet.maintenance_activity_type_info
AS
SELECT     TOP (100) PERCENT lookup_item_id, item_name
FROM         fleet.lookup_item
WHERE     (lookup_id = 3)
ORDER BY item_name