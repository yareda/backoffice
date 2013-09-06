CREATE VIEW wms.maintenance_task_list_info
AS
SELECT     wms.maintenance_task.task_id, wms.maintenance_task.work_order_id, wms.maintenance_task.labour_cost, wms.maintenance_task.parts_cost, 
                      wms.pm_service.task_name
FROM         wms.maintenance_task LEFT OUTER JOIN
                      wms.pm_service ON wms.maintenance_task.service_type_id = wms.pm_service.pm_service_id