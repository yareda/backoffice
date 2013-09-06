CREATE VIEW wms.work_order_info
AS
SELECT     wms.work_order.work_order_id, wms.work_order.equipment_id, wms.work_order.contract_id, wms.work_order.customer_id, wms.work_order.work_order_no, 
                      wms.work_order.end_date, wms.work_order.issue_date, wms.work_order.priority, wms.workorder_equipment_info.identification, wms.work_order.status, 
                      wms.lookup_item.name AS status_text, wms.work_order.total_cost
FROM         wms.work_order LEFT OUTER JOIN
                      wms.lookup_item ON wms.work_order.status = wms.lookup_item.item_id LEFT OUTER JOIN
                      wms.workorder_equipment_info ON wms.work_order.equipment_id = wms.workorder_equipment_info.equipment_id