CREATE PROCEDURE [payroll].[sp_set_param_to_current]
( @employeeId as int, @paramId as int)


AS 

INSERT INTO payroll.payroll_current (employee_id,param_id) VALUES (@employeeId,@paramId)