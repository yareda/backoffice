CREATE VIEW wms.workorder_list_info
AS
SELECT     wms.work_order.work_order_id, wms.work_order.work_order_no, wms.customer.name, wms.customer.contact, wms.customer.address, wms.customer.city
FROM         wms.work_order LEFT OUTER JOIN
                      wms.customer ON wms.customer.customer_id = wms.work_order.customer_id