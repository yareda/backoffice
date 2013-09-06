CREATE VIEW [wms].[equipment_list_info]
AS
SELECT     wms.equipment.serial, wms.equipment.description, lookup_item_2.name AS catagory_text, wms.equipment.contract_id, wms.lookup_item.name AS make_text, 
                      lookup_item_1.name AS model_text, wms.equipment.model, wms.equipment.make, wms.equipment.equipment_id, wms.equipment.category_id, 
                      wms.contract.customer_id
FROM         wms.equipment INNER JOIN
                      wms.contract ON wms.equipment.contract_id = wms.contract.contract_id LEFT OUTER JOIN
                      wms.lookup_item AS lookup_item_2 ON wms.equipment.category_id = lookup_item_2.item_id LEFT OUTER JOIN
                      wms.lookup_item ON wms.equipment.make = wms.lookup_item.item_id LEFT OUTER JOIN
                      wms.lookup_item AS lookup_item_1 ON wms.equipment.model = lookup_item_1.item_id