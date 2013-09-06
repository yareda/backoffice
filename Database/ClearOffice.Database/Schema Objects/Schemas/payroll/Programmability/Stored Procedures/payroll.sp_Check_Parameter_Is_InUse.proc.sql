CREATE PROCEDURE [payroll].[sp_Check_Parameter_Is_InUse]
(
  @ParamId as int
)
AS 

SELECT payroll_current.param_id FROM payroll_current
INNER JOIN payroll_parameter_setting ON payroll_current.param_id = payroll_parameter_setting.param_id
WHERE payroll_current.param_id = @ParamId AND payroll_parameter_setting.is_active = 1
GROUP BY payroll_current.param_id, payroll_parameter_setting.param_id