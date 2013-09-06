/*CREATE VIEW [wms].[invoice_list_infoo]
AS
SELECT     wms.work_order.work_order_no, wms.work_order.work_order_id, wms.customer.customer_id, wms.invoice_payment_info.Status_text, 
                      wms.invoice_payment_info.invoice_date, wms.invoice_payment_info.due_date, wms.invoice_payment_info.invoice_no, wms.customer.name, 
                      wms.invoice_payment_info.amount_received, wms.invoice_payment_info.payment_id, wms.invoice_payment_info.id, wms.total_info.Total
FROM         wms.customer LEFT OUTER JOIN
                      wms.invoice_payment_info ON wms.customer.customer_id = wms.invoice_payment_info.customer_id RIGHT OUTER JOIN
                      wms.work_order ON wms.invoice_payment_info.work_order_id = wms.work_order.work_order_id LEFT OUTER JOIN
                      wms.total_info ON wms.work_order.work_order_id = wms.total_info.work_order_id*/