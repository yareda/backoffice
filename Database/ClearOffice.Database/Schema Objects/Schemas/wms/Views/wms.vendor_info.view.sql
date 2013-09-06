/*CREATE VIEW wms.vendor_info
AS
SELECT     wms.vendor.vendor_id, wms.vendor.name, wms.vendor.contact, wms.vendor.address, wms.vendor.city, wms.vendor.postal_code, wms.vendor.country, 
                      wms.vendor.phone1, wms.vendor.phone2, wms.vendor.fax, wms.vendor.email, wms.lookup_item.name AS vendor_type
FROM         wms.vendor INNER JOIN
                      wms.lookup_item ON wms.vendor.vendor_type = wms.lookup_item.item_id*/