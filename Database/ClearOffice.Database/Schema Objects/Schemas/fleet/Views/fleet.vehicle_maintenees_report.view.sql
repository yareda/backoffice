CREATE VIEW fleet.vehicle_maintenees_report
AS
SELECT     fleet.vehicle.plate_number, SUM(fleet.expense.amount) AS expense_amount, fleet.maintanance.completion_date, fleet.maintanance.closing_remark, 
                      fleet.lookup_item.item_name AS maintenance_type_text, fleet.vehicle.vehicle_type, lookup_item_1.item_name AS vehicle_type_text
FROM         fleet.maintanance INNER JOIN
                      fleet.vehicle ON fleet.vehicle.vehicle_id = fleet.maintanance.vehicle_id AND fleet.vehicle.vehicle_id = fleet.maintanance.vehicle_id INNER JOIN
                      fleet.maintenance_expense ON fleet.maintanance.maintenance_id = fleet.maintenance_expense.maintenance_id LEFT OUTER JOIN
                      fleet.expense ON fleet.maintenance_expense.expense_id = fleet.expense.expense_id LEFT OUTER JOIN
                      fleet.lookup_item ON fleet.maintanance.service_type_id = fleet.lookup_item.lookup_item_id LEFT OUTER JOIN
                      fleet.lookup_item AS lookup_item_1 ON fleet.vehicle.vehicle_type = lookup_item_1.lookup_item_id
GROUP BY fleet.vehicle.plate_number, fleet.expense.amount, fleet.maintanance.completion_date, fleet.maintanance.closing_remark, fleet.lookup_item.item_name, 
                      fleet.vehicle.vehicle_type, lookup_item_1.item_name