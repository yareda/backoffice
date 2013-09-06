CREATE PROCEDURE [payroll].[sp_Get_Transfer_List]

AS 
SELECT * FROM payroll_parameter
WHERE payroll_parameter.value_type_id = 4 OR payroll_parameter.value_type_id = 8 OR 
	  payroll_parameter.value_type_id = 1 OR payroll_parameter.value_type_id = 5