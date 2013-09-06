CREATE VIEW wms.invoice_list_info
AS
SELECT     wms.invoice.id, wms.invoice.invoice_no, wms.invoice.invoice_date, wms.invoice_status_lookup_info.name AS invoice_status, wms.work_order_value_total.part_total,
                       wms.work_order_value_total.labor_total, wms.invoice.work_order_id, wms.invoice_received_amount_info.received_total, 
                      wms.work_order_value_total.labor_total + wms.work_order_value_total.part_total - wms.invoice_received_amount_info.received_total AS remaining_amount, 
                      wms.invoice.due_date, wms.customer.name AS Customer, wms.work_order_value_total.labor_total + wms.work_order_value_total.part_total AS TotalCost, 
                      wms.work_order_value_total.work_order_no
FROM         wms.work_order_value_total RIGHT OUTER JOIN
                      wms.invoice_received_amount_info RIGHT OUTER JOIN
                      wms.invoice ON wms.invoice_received_amount_info.invoice_id = wms.invoice.id ON 
                      wms.work_order_value_total.work_order_id = wms.invoice.work_order_id LEFT OUTER JOIN
                      wms.customer ON wms.invoice.customer_id = wms.customer.customer_id LEFT OUTER JOIN
                      wms.invoice_status_lookup_info ON wms.invoice.status = wms.invoice_status_lookup_info.item_id