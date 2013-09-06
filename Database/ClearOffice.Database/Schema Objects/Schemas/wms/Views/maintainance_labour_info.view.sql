CREATE VIEW wms.maintainance_labour_info
AS
SELECT     wms.maintenance_labour.labour_id, wms.maintenance_labour.work_order_id, wms.maintenance_labour.task_id, wms.maintenance_labour.performed_by, 
                      wms.maintenance_labour.performer_id, wms.maintenance_labour.labour_rate, wms.maintenance_labour.hour, wms.maintenance_labour.cost, 
                      wms.maintenance_labour.description, wms.maintenance_task.is_itemized, wms.maintenance_task.service_type_id, wms.maintenance_task.parts_cost, 
                      wms.GetPerformer(wms.maintenance_labour.performed_by, wms.maintenance_labour.performer_id) AS performer_name, wms.work_order.equipment_id, 
                      wms.work_order.work_order_no, wms.maintenance_task.labour_cost
FROM         wms.maintenance_labour LEFT OUTER JOIN
                      wms.work_order ON wms.maintenance_labour.work_order_id = wms.work_order.work_order_id LEFT OUTER JOIN
                      wms.maintenance_task ON wms.maintenance_labour.task_id = wms.maintenance_task.task_id