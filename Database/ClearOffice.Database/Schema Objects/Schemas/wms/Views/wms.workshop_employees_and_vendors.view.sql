/*CREATE VIEW wms.workshop_employees_and_vendors
AS
select wms.workshop_employees_info.employee_id as id, wms.workshop_employees_info.full_name as name,'employee' as type
from wms.workshop_employees_info
union
select wms.vendor.vendor_id as id,wms.vendor.name as name,'vendor' as type
from wms.vendor*/