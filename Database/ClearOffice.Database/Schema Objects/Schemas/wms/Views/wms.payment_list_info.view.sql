/*CREATE VIEW wms.payment_list_info
AS
SELECT     wms.payment_record.payment_id, wms.payment_record.invoice_id, wms.payment_record.amount_received, wms.payment_record.payment_method, 
                      wms.payment_record.payment_date, reference, 
                      wms.get_payment_method_text(wms.payment_record.payment_method) AS payment_method_text
FROM         wms.payment_record INNER JOIN
                      wms.invoice ON wms.payment_record.invoice_id = wms.invoice.id*/