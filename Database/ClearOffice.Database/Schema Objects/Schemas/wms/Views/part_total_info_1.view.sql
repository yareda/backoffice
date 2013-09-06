/*CREATE VIEW wms.part_total_info
AS
SELECT     wms.maintenance_part.unit_cost * wms.maintenance_part.quantity + wms.maintenance_labour.cost AS partTotal, wms.work_order.work_order_id
FROM         wms.work_order LEFT OUTER JOIN
                      wms.maintenance_labour ON wms.work_order.work_order_id = wms.maintenance_labour.work_order_id LEFT OUTER JOIN
                      wms.maintenance_part ON wms.work_order.work_order_id = wms.maintenance_part.work_order_id*/