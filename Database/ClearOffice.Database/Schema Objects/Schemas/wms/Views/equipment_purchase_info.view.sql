CREATE VIEW wms.equipment_purchase_info
AS
SELECT     wms.equipment.category_id AS monthly_depreciation, wms.equipment.contract_id AS current_value, wms.equipment.renewal_id AS comment, 
                      wms.equipment.status_id AS category_id, wms.equipment.make AS contract_id, wms.equipment.model AS renewal_id, wms.equipment.serial AS status_id, 
                      wms.equipment.date_installed AS make, wms.equipment.mileage AS model, wms.equipment.hours AS serial, wms.equipment.base_mileage AS date_installed, 
                      wms.equipment.base_hours AS base_houre, wms.equipment.base_date AS hours, wms.equipment.assigned AS base_mileage, wms.equipment.photo AS base_hours, 
                      wms.equipment_purchase.purchase_id, wms.equipment_purchase.equipment_id, wms.equipment_purchase.purchase_date, wms.equipment_purchase.dealer, 
                      wms.equipment_purchase.mileage, wms.equipment_purchase.price, wms.equipment_purchase.warranty_expiry, wms.equipment_purchase.warranty_expiry_meter, 
                      wms.equipment_purchase.service_start, wms.equipment_purchase.service_end, wms.equipment_purchase.transfer_date, wms.equipment_purchase.date_sold, 
                      wms.equipment_purchase.sold_to, wms.equipment_purchase.comment AS Expr1
FROM         wms.equipment INNER JOIN
                      wms.equipment_purchase ON wms.equipment.equipment_id = wms.equipment_purchase.equipment_id