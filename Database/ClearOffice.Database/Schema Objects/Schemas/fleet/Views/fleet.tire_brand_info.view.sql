CREATE VIEW fleet.tire_brand_info
AS
SELECT     lookup_item_id, lookup_id, item_name
FROM         fleet.lookup_item
WHERE     (lookup_id = 17)