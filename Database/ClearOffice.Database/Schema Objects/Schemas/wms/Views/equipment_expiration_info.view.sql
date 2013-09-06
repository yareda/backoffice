CREATE VIEW wms.equipment_expiration_info
AS
SELECT     wms.equipment_expiration.expiration_id, wms.equipment_expiration.equipment_id, wms.equipment_expiration.expiration_type, 
                      wms.equipment_expiration.expiration_date, wms.equipment.contract_id, wms.equipment.category_id, wms.equipment.renewal_id, wms.equipment.status_id, 
                      wms.equipment.make, wms.equipment.model, wms.equipment.serial, wms.equipment.date_installed, wms.equipment.mileage, wms.equipment.hours, 
                      wms.equipment.base_mileage, wms.equipment.base_hours, wms.equipment.base_date, wms.equipment.assigned, wms.equipment.photo, 
                      wms.equipment_expiration.expiration_type AS expiration_type_id, wms.lookup_item.name
FROM         wms.equipment_expiration INNER JOIN
                      wms.equipment ON wms.equipment_expiration.equipment_id = wms.equipment.equipment_id INNER JOIN
                      wms.lookup_item ON wms.equipment_expiration.expiration_type = wms.lookup_item.item_id