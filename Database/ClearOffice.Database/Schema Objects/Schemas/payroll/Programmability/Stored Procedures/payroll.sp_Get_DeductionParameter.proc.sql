CREATE PROCEDURE [payroll].[sp_Get_DeductionParameter]

AS 
SELECT * FROM payroll_parameter
WHERE payroll_parameter.type_id = 2