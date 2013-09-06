CREATE VIEW wms.part_list_info
AS
SELECT     wms.maintenance_part.maintained_part_id, wms.maintenance_part.work_order_id, wms.maintenance_part.task_id, wms.part.part_name, 
                      wms.maintenance_part.quantity, wms.maintenance_part.unit_cost, wms.maintenance_part.description, wms.part.part_id
FROM         wms.maintenance_part LEFT OUTER JOIN
                      wms.part ON wms.maintenance_part.part_id = wms.part.part_id