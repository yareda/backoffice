SELECT     wms.invoice.id, wms.invoice.invoice_no, wms.invoice.invoice_date, wms.return_invoice_status_text(wms.invoice.id) AS invoice_status, wms.invoice.work_order_id, 
                      wms.invoice_received_amount_info.received_total, wms.invoice.due_date, work_order_value_total.labor_total + work_order_value_total.part_total AS total_cost, 
                      work_order_value_total.work_order_no, work_order_value_total.name AS customer, wms.calculate_invoice_total(wms.invoice.id) AS invoice_total, 
                      wms.calculate_invoice_total(wms.invoice.id) - wms.invoice_received_amount_info.received_total AS remaining_amount
FROM         wms.invoice LEFT OUTER JOIN
                      wms.invoice_received_amount_info ON wms.invoice_received_amount_info.invoice_id = wms.invoice.id LEFT OUTER JOIN
                      wms.work_order_value_total AS work_order_value_total ON wms.invoice.work_order_id = work_order_value_total.work_order_id