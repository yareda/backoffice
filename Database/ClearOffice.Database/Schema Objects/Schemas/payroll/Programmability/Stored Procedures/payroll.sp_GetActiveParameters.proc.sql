CREATE PROCEDURE [payroll].[sp_GetActiveParameters]

@EmployeeID as int,
@ParamType as int
 AS

 SELECT PP.param_id, PP.param_name, PP.type_id, PP.param_value, PP.value_type_id, PP.salary_percent, PP.rate, PS.employee_id, PS.is_active FROM payroll_parameter
 PP LEFT JOIN payroll_parameter_setting PS ON PP.param_id = PS.param_id
 WHERE PS.employee_id = @EmployeeID
 AND PP.type_id = @ParamType
 ORDER BY PP.param_id