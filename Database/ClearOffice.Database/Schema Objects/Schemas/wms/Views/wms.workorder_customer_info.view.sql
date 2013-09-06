/*CREATE VIEW wms.workorder_customer_info
AS
SELECT     wms.customer.name, wms.customer.contact, wms.customer.address, wms.work_order.work_order_id, wms.customer.city
FROM         wms.work_order INNER JOIN
                      wms.customer ON wms.customer.customer_id = wms.work_order.customer_id*/