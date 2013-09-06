CREATE VIEW wms.pm_service_info
AS
SELECT     wms.pm_service.pm_service_id, wms.pm_service.task_name, wms.pm_service.category, wms.pm_service.priority, wms.pm_service.fixed_date, 
                      wms.pm_service.recurring_date, wms.pm_service.fixed_hour, wms.pm_service.recurring_hour, wms.lookup_item.name AS catagory_name, 
                      wms.lookup_item.code AS catagory_code, wms.pm_service.category AS catagory, lookup_item_1.name AS priority_name, lookup_item_1.code AS priority_code
FROM         wms.pm_service LEFT OUTER JOIN
                      wms.lookup_item ON wms.pm_service.category = wms.lookup_item.item_id LEFT OUTER JOIN
                      wms.lookup_item AS lookup_item_1 ON wms.pm_service.priority = lookup_item_1.item_id