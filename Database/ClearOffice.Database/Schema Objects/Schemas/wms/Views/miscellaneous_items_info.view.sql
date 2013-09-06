CREATE VIEW wms.miscellaneous_items_info
AS
SELECT     wms.miscellaneous_items.mis_part_id, wms.miscellaneous_items.part_id, wms.miscellaneous_items.invoice_id, wms.miscellaneous_items.quantity, 
                      wms.miscellaneous_items.unit_price, wms.miscellaneous_items.description, wms.invoice.invoice_no
FROM         wms.miscellaneous_items INNER JOIN
                      wms.invoice ON wms.miscellaneous_items.invoice_id = wms.invoice.id