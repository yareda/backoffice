CREATE PROCEDURE [payroll].[sp_check_param_in_current_payroll]
( @employeeId as int, @paramId as int)

AS 

SELECT count(*) FROM payroll_current
WHERE employee_id = @employeeId AND param_id = @paramId