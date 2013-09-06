CREATE VIEW [payroll].[payroll_current_info]
AS
SELECT     payroll.payroll_current.amount, payroll.payroll_current.param_id, payroll.payroll_parameter.param_name, payroll.payroll_current.current_record_id, 
                      payroll.payroll_current.employee_id, payroll.payroll_current.hrs
FROM         payroll.payroll_current INNER JOIN
                      payroll.payroll_parameter ON payroll.payroll_current.param_id = payroll.payroll_parameter.param_id