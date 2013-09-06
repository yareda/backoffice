/*CREATE VIEW wms.wo_maintenance_part_total
AS
SELECT     work_order_id, SUM(unit_cost * quantity) AS part_total
FROM         wms.maintenance_part
GROUP BY work_order_id*/