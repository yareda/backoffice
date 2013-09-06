/*CREATE VIEW dbo.customer_equipment_info
AS
SELECT     wms.equipment.equipment_id, wms.equipment.category_id, wms.equipment.contract_id, wms.equipment.renewal_id, wms.equipment.status_id, 
                      wms.equipment.make, wms.equipment.model, wms.equipment.serial, wms.equipment.date_installed, wms.equipment.mileage, wms.equipment.hours, 
                      wms.equipment.base_mileage, wms.equipment.base_hours, wms.equipment.base_date, wms.equipment.assigned, wms.equipment.photo, 
                      wms.equipment.description, wms.equipment.remark AS equipment_remark, wms.contract_info.status_text, wms.contract_info.status AS contract_status, 
                      wms.contract_info.contract_type_name, wms.contract_info.amount AS ammount, wms.contract_info.payment_terms, wms.contract_info.expiry_date, 
                      wms.contract_info.start_date, wms.contract_info.customer_name, wms.contract_info.address, wms.contract_info.postal_code, wms.contract_info.city, 
                      wms.contract_info.email, wms.contract_info.customer_id, wms.contract_info.contract_date, wms.contract_info.remark, wms.contract_info.contract_no, 
                      wms.contract_info.date_renewed
FROM         wms.equipment INNER JOIN
                      wms.contract_info ON wms.equipment.contract_id = wms.contract_info.contract_id OR wms.equipment.renewal_id = wms.contract_info.renewal_id*/