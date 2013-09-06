CREATE VIEW wms.invoice_payment_info
AS
SELECT     wms.invoice_status_lookup_info.name AS Status_text, wms.invoice.invoice_date, wms.invoice.due_date, wms.invoice.invoice_no, wms.invoice.work_order_id, 
                      wms.invoice.customer_id, wms.invoice.id, wms.payment_record.payment_id, wms.payment_record.amount_received
FROM         wms.invoice INNER JOIN
                      wms.invoice_status_lookup_info ON wms.invoice.status = wms.invoice_status_lookup_info.item_id LEFT OUTER JOIN
                      wms.payment_record ON wms.invoice.id = wms.payment_record.invoice_id