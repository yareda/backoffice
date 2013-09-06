CREATE PROCEDURE [payroll].[sp_Get_PeriodicParameter]

AS 
SELECT * FROM payroll_parameter
WHERE payroll_parameter.value_type_id = 6