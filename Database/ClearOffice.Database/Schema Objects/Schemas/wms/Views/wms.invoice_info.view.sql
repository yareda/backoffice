CREATE VIEW wms.invoice_info
AS
SELECT     wms.invoice.id, wms.invoice.invoice_no, wms.invoice.invoice_date, wms.invoice_received_amount_info.received_total AS recieved_total, wms.invoice.due_date, 
                      work_order_value_total.work_order_no, work_order_value_total.name AS customer, wms.calculate_invoice_total(wms.invoice.id) AS invoice_total, 
                      wms.calculate_invoice_total(wms.invoice.id) - wms.invoice_received_amount_info.received_total AS remaining_amount, 
                      wms.work_order.total_cost AS work_order_total, wms.lookup_item.name AS invoice_status_text, wms.lookup_item.item_id
FROM         wms.invoice INNER JOIN
                      wms.work_order ON wms.invoice.work_order_id = wms.work_order.work_order_id LEFT OUTER JOIN
                      wms.lookup_item ON wms.invoice.status = wms.lookup_item.item_id LEFT OUTER JOIN
                      wms.invoice_received_amount_info ON wms.invoice_received_amount_info.invoice_id = wms.invoice.id LEFT OUTER JOIN
                      wms.work_order_value_total AS work_order_value_total ON wms.invoice.work_order_id = work_order_value_total.work_order_id