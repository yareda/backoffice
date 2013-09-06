CREATE VIEW wms.maintenance_task_info
AS
SELECT     wms.maintenance_task.task_id, wms.maintenance_task.work_order_id, wms.maintenance_task.is_itemized, wms.maintenance_task.service_type_id, 
                      wms.maintenance_task.parts_cost, wms.maintenance_task.labour_cost, wms.maintenance_task.note, wms.work_order.equipment_id, wms.work_order.contract_id, 
                      wms.work_order.customer_id, wms.work_order.work_order_no, wms.work_order.priority AS workorder_priority, wms.work_order.issue_date AS workorder_issued_date,
                       wms.work_order.start_date AS workorder_start_date, wms.work_order.end_date AS workorder_end_date, wms.work_order.assigned_to AS workorder_assigned_to, 
                      wms.work_order.status AS workorder_status
FROM         wms.maintenance_task INNER JOIN
                      wms.work_order ON wms.maintenance_task.work_order_id = wms.work_order.work_order_id