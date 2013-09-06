CREATE FUNCTION [payroll].[GetNoEmployeeOnStructureUnit](@StructId as int)

RETURNS int

BEGIN
DECLARE @Value as int

SELECT @Value= COUNT(employee.employee_id) FROM employee
WHERE employee.struct_id = @StructId AND employee.deleted = 0

RETURN @Value
END