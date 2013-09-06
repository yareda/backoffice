CREATE VIEW wms.vendor_type_info
AS
SELECT     item_id, name
FROM         wms.lookup_item
WHERE     (lookup_id = 16)