CREATE PROCEDURE [payroll].[sp_set_param_to_setting]
( @employeeId as int, @paramId as int)


AS 

INSERT INTO payroll.payroll_parameter_setting (employee_id,param_id,is_active) VALUES (@employeeId,@paramId,1)