CREATE VIEW wms.maintenance_part_info
AS
SELECT     wms.maintenance_part.maintained_part_id, wms.maintenance_part.work_order_id, wms.maintenance_part.task_id, wms.maintenance_part.vendor, 
                      wms.maintenance_part.quantity, wms.maintenance_part.unit_cost, wms.maintenance_task.is_itemized, wms.maintenance_task.service_type_id, 
                      wms.maintenance_task.parts_cost, wms.maintenance_task.labour_cost, wms.maintenance_task.note, wms.work_order.equipment_id, wms.work_order.contract_id, 
                      wms.work_order.customer_id, wms.work_order.work_order_no, wms.work_order.priority, wms.work_order.issue_date, wms.work_order.start_date, 
                      wms.work_order.end_date, wms.work_order.assigned_to, wms.work_order.status, wms.maintenance_part.part_id
FROM         wms.maintenance_part LEFT OUTER JOIN
                      wms.maintenance_task ON wms.maintenance_part.task_id = wms.maintenance_task.task_id INNER JOIN
                      wms.work_order ON wms.maintenance_part.work_order_id = wms.work_order.work_order_id