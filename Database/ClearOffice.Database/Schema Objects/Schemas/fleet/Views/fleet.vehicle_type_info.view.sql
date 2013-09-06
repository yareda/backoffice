CREATE VIEW fleet.vehicle_type_info
AS
SELECT     lookup_item_id, item_name
FROM         fleet.lookup_item
WHERE     (lookup_id = 6)