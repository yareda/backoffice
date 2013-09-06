CREATE VIEW wms.work_order_value_total
AS
SELECT     wms.work_order.work_order_id, SUM(mp.unit_cost * mp.quantity) AS part_total, SUM(ml.hour * ml.labour_rate) AS labor_total, wms.work_order.work_order_no, 
                      wms.customer.name, wms.customer.contact, wms.customer.address, wms.customer.city
FROM         wms.work_order INNER JOIN
                      wms.customer ON wms.work_order.customer_id = wms.customer.customer_id LEFT OUTER JOIN
                      wms.maintenance_labour AS ml ON wms.work_order.work_order_id = ml.work_order_id LEFT OUTER JOIN
                      wms.maintenance_part AS mp ON wms.work_order.work_order_id = mp.work_order_id
GROUP BY wms.work_order.work_order_id, wms.work_order.work_order_no, wms.customer.name, wms.customer.contact, wms.customer.address, wms.customer.city