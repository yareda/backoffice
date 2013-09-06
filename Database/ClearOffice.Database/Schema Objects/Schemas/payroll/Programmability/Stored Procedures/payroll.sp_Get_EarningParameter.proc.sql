CREATE PROCEDURE [payroll].[sp_Get_EarningParameter]

AS 
SELECT * FROM payroll_parameter
WHERE payroll_parameter.type_id = 1