CREATE VIEW wms.work_order_value_total
AS
SELECT     wms.work_order.work_order_id, SUM(mp.unit_cost * mp.quantity) AS part_total, SUM(ml.hour * ml.labour_rate) AS labor_total, wms.work_order.work_order_no
FROM         wms.maintenance_labour AS ml RIGHT OUTER JOIN
                      wms.work_order ON ml.work_order_id = wms.work_order.work_order_id LEFT OUTER JOIN
                      wms.maintenance_part AS mp ON wms.work_order.work_order_id = mp.work_order_id
GROUP BY wms.work_order.work_order_id, wms.work_order.work_order_no