CREATE VIEW [payroll].[qry_get_transport_allowance_history]
AS
SELECT     TOP (100) PERCENT payroll.payroll_history.employee_id, SUM(payroll.payroll_history.amount) AS Transport, payroll.payroll_history.pay_period
FROM         payroll.payroll_history INNER JOIN
                      payroll.payroll_parameter ON payroll.payroll_history.param_id = payroll.payroll_parameter.param_id INNER JOIN
                      [hrm].employee ON payroll.payroll_history.employee_id = [hrm].employee.employee_id
WHERE     (payroll.payroll_parameter.parameter_group_id = 6) AND ([hrm].employee.deleted = 0)
GROUP BY payroll.payroll_history.employee_id, payroll.payroll_history.pay_period
ORDER BY payroll.payroll_history.employee_id