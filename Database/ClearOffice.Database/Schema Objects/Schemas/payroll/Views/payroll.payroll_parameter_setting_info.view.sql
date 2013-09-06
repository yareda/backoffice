CREATE VIEW [payroll].[payroll_parameter_setting_info]
AS
SELECT     payroll.payroll_parameter_setting.param_id, payroll.payroll_parameter_setting.employee_id, payroll.payroll_parameter_setting.is_active, 
                      payroll.payroll_parameter_setting.param_setting_id, payroll.payroll_parameter.param_name
FROM         payroll.payroll_parameter_setting INNER JOIN
                      payroll.payroll_parameter ON payroll.payroll_parameter_setting.param_id = payroll.payroll_parameter.param_id