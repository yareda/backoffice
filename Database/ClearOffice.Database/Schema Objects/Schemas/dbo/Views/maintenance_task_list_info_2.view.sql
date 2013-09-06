/*CREATE VIEW dbo.maintenance_task_list_info
AS
SELECT     wms.maintenance_task.task_id, wms.maintenance_task.work_order_id, wms.pm_service.pm_service_id, wms.pm_service.task_name, 
                      wms.maintenance_task.labour_cost, wms.maintenance_task.parts_cost, wms.pm_service.fixed_date, wms.pm_service.recurring_date
FROM         wms.maintenance_task INNER JOIN
                      wms.pm_service ON wms.pm_service.pm_service_id = wms.maintenance_task.task_id*/