CREATE VIEW payroll.vw_transfer_list
AS
SELECT     payroll.payroll_parameter.param_name, payroll.payroll_current.param_id, payroll.payroll_current.employee_id, payroll.payroll_current.hrs, 
                      payroll.payroll_current.amount, payroll.payroll_parameter_setting.is_active, payroll.payroll_parameter.value_type_id, payroll.payroll_current.current_record_id
FROM         payroll.payroll_current INNER JOIN
                      payroll.payroll_parameter ON payroll.payroll_current.param_id = payroll.payroll_parameter.param_id INNER JOIN
                      payroll.payroll_parameter_setting ON payroll.payroll_current.employee_id = payroll.payroll_parameter_setting.employee_id AND 
                      payroll.payroll_current.param_id = payroll.payroll_parameter_setting.param_id
WHERE     (payroll.payroll_parameter_setting.is_active = 1)