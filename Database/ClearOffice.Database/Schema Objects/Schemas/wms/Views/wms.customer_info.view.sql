/*CREATE VIEW wms.customer_info
AS
SELECT     wms.customer.customer_id, wms.customer.type, wms.customer.name, wms.customer.contact, wms.customer.address, wms.customer.city, 
                      wms.customer.postal_code, wms.customer.phone1, wms.customer.phone2, wms.customer.fax, wms.customer.email, 
                      wms.lookup_item.name AS customer_type_name
FROM         wms.customer INNER JOIN
                      wms.lookup_item ON wms.customer.type = wms.lookup_item.item_id*/