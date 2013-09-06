CREATE VIEW wms.part_info
AS
SELECT     part_id, part_name, description, manufacturer, unit_measure, unit_cost, '###' AS part_no
FROM         wms.part