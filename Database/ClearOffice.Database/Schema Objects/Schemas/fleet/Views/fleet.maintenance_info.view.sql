CREATE VIEW fleet.maintenance_info
AS
SELECT     fleet.maintanance.maintenance_id, fleet.maintanance.vehicle_id, fleet.vehicle_info.plate_number, fleet.maintanance.service_request_no, 
                      fleet.maintanance.creation_date, fleet.maintanance.completion_date, SUM(fleet.maintenance_part.unit_price * fleet.maintenance_part.quantity) AS total_part_price, 
                      SUM(fleet.maintenance_activity.labor_units * fleet.maintenance_activity.unit_cost) AS total_activity_price, SUM(fleet.maintenance_expense_info.amount) 
                      AS total_expense_amount
FROM         fleet.maintanance LEFT OUTER JOIN
                      fleet.maintenance_expense_info ON fleet.maintanance.maintenance_id = fleet.maintenance_expense_info.maintenance_id LEFT OUTER JOIN
                      fleet.maintenance_activity ON fleet.maintanance.maintenance_id = fleet.maintenance_activity.maintenance_id LEFT OUTER JOIN
                      fleet.vehicle_info ON fleet.maintanance.vehicle_id = fleet.vehicle_info.vehicle_id LEFT OUTER JOIN
                      fleet.maintenance_part ON fleet.maintanance.maintenance_id = fleet.maintenance_part.maintenance_id
GROUP BY fleet.maintanance.maintenance_id, fleet.maintanance.vehicle_id, fleet.vehicle_info.plate_number, fleet.maintanance.service_request_no, 
                      fleet.maintanance.creation_date, fleet.maintanance.completion_date