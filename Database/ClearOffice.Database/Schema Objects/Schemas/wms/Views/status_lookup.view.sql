CREATE VIEW wms.status_lookup
AS
SELECT     item_id, lookup_id, name
FROM         wms.lookup_item
WHERE     (lookup_id = 18)