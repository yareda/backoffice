CREATE VIEW fleet.vehicle_ownership_info
AS
SELECT     lookup_item_id, item_name
FROM         fleet.lookup_item
WHERE     (lookup_id = 8)