/*CREATE VIEW [wms].[total_info]
AS
SELECT     TOP (100) PERCENT wms.work_order.work_order_id, SUM(wms.part_total_info.partTotal) AS Total
FROM         wms.work_order INNER JOIN
                      wms.part_total_info ON wms.work_order.work_order_id = wms.part_total_info.work_order_id
GROUP BY wms.work_order.work_order_id, wms.part_total_info.partTotal
ORDER BY wms.work_order.work_order_id*/