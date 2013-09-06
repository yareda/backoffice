CREATE VIEW wms.customer_equipment_info
AS
SELECT     wms.equipment.equipment_id, wms.equipment.category_id, wms.equipment.contract_id, wms.equipment.renewal_id, wms.equipment.status_id, 
                      wms.equipment.make, wms.equipment.model, wms.equipment.serial, wms.equipment.date_installed, wms.equipment.mileage, wms.equipment.hours, 
                      wms.equipment.base_mileage, wms.equipment.base_hours, wms.equipment.base_date, wms.equipment.assigned, wms.equipment.photo, 
                      wms.contract_info.contract_type, wms.contract_info.contract_no, wms.contract_info.is_default_contract, wms.contract_info.customer_id, 
                      wms.contract_info.contract_date, wms.contract_info.customer_name, wms.contract_info.customer_type
FROM         wms.equipment INNER JOIN
                      wms.contract_info ON wms.equipment.contract_id = wms.contract_info.contract_id