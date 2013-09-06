/*CREATE VIEW wms.pm_service_part_info
AS
SELECT     wms.pm_service_part.pm_part_id, wms.pm_service_part.service_id, wms.pm_service_part.part_id, wms.pm_service_part.quantity, wms.part.part_name, 
                      wms.part.manufacturer, wms.part.unit_measure, wms.part.unit_cost
FROM         wms.pm_service_part INNER JOIN
                      wms.part ON wms.pm_service_part.part_id = wms.part.part_id*/