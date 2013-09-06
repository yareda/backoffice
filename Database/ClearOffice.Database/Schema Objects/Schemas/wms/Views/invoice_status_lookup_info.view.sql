CREATE VIEW wms.invoice_status_lookup_info
AS
SELECT     item_id, name
FROM         wms.lookup_item
WHERE     (lookup_id = 19)