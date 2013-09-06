CREATE VIEW wms.wo_maintenance_labor_total
AS
SELECT     work_order_id, SUM(labour_rate * cost) AS labor_total
FROM         wms.maintenance_labour
GROUP BY work_order_id