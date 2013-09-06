CREATE PROCEDURE [payroll].[sp_check_param_in_setting]
( @employeeId as int, @paramId as int)

AS 

SELECT count(*) FROM payroll_parameter_setting
WHERE employee_id = @employeeId AND param_id = @paramId