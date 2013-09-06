CREATE VIEW [wms].[workorder_equipment_info]
AS
SELECT     wms.equipment.equipment_id, wms.equipment.make, wms.equipment.model, wms.equipment.serial, mk.name AS make_text, md.name AS model_text, 
                      md.name + ' ' + mk.name AS identification, wms.equipment.description
FROM         wms.equipment LEFT OUTER JOIN
                      wms.equipment_model_info AS md ON wms.equipment.model = md.item_id LEFT OUTER JOIN
                      wms.equipment_make_info AS mk ON wms.equipment.make = mk.item_id