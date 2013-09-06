CREATE PROCEDURE [payroll].[DeleteEmployee]
@employeeId int
as

UPDATE employee
SET deleted=1
WHERE employee_id=@employeeId