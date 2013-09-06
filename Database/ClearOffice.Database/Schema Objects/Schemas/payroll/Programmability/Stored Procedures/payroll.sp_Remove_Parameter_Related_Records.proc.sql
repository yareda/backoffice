CREATE PROCEDURE [payroll].[sp_Remove_Parameter_Related_Records]
(
	@ParamId as int
)

AS 

DELETE FROM payroll_current
WHERE payroll_current.param_id = @ParamId

DELETE FROM payroll_parameter_setting
WHERE payroll_parameter_setting.param_id = @ParamId

DELETE FROM payroll_periodic_deduction
WHERE payroll_periodic_deduction.param_id = @ParamId