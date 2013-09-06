CREATE VIEW fleet.maintenance_expense_info
AS
SELECT     fleet.maintenance_expense.maintenance_id, fleet.maintenance_expense.expense_id, fleet.expense.vehicle_id, fleet.expense.amount, 
                      fleet.expense.payment_type_id, dbo.payment_type_info.item_name AS payment_type_name
FROM         fleet.maintenance_expense INNER JOIN
                      fleet.expense ON fleet.maintenance_expense.expense_id = fleet.expense.expense_id LEFT OUTER JOIN
                      dbo.payment_type_info ON fleet.expense.payment_type_id = dbo.payment_type_info.lookup_item_id