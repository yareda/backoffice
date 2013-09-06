CREATE VIEW wms.miscellaneous_total_info
AS
SELECT     wms.invoice.id, SUM(mi.unit_price * mi.quantity) AS miscellaneous_total, mi.invoice_id
FROM         wms.invoice LEFT OUTER JOIN
                      wms.miscellaneous_items AS mi ON wms.invoice.id = mi.invoice_id
GROUP BY wms.invoice.id, mi.invoice_id