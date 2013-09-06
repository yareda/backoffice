/*CREATE VIEW wms.pm_service_info
AS
SELECT     wms.lookup_item.name AS catagory_name, wms.lookup_item.code AS catagory_code, wms.pm_service.pm_service_id, wms.pm_service.task_name, 
                      wms.pm_service.category, wms.pm_service.priority, wms.pm_service.fixed_date, wms.pm_service.recurring_date, wms.pm_service.fixed_hour, 
                      wms.pm_service.recurring_hour, lookup_item_1.name AS priority_name
FROM         wms.lookup_item INNER JOIN
                      wms.pm_service ON wms.lookup_item.item_id = wms.pm_service.category INNER JOIN
                      wms.lookup_item AS lookup_item_1 ON wms.pm_service.priority = lookup_item_1.item_id*/