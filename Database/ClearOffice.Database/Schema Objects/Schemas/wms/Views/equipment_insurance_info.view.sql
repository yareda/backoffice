CREATE VIEW wms.equipment_insurance_info
AS
SELECT     wms.equipment_insurance.insurance_id, wms.equipment_insurance.equipment_id, wms.equipment_insurance.company_id, 
                      wms.equipment_insurance.policy_number, wms.equipment_insurance.start_date, wms.equipment_insurance.end_date, wms.equipment_insurance.payment, 
                      wms.equipment_insurance.deductable, wms.equipment_insurance.remark, wms.equipment.status_id, wms.equipment.make, wms.equipment.model, 
                      wms.equipment.contract_id, wms.equipment.renewal_id, wms.equipment.serial, wms.equipment.date_installed, wms.equipment.mileage, wms.equipment.hours, 
                      wms.equipment.base_mileage, wms.equipment.base_hours, wms.equipment.base_date, wms.equipment.assigned, wms.equipment.photo, 
                      wms.equipment_insurance.company_id AS insurance_company_id, wms.lookup_item.name AS insurance_company_name, wms.lookup_item.code
FROM         wms.equipment_insurance INNER JOIN
                      wms.equipment ON wms.equipment_insurance.equipment_id = wms.equipment.equipment_id INNER JOIN
                      wms.lookup_item ON wms.equipment_insurance.company_id = wms.lookup_item.item_id