CREATE VIEW [payroll].[qry_get_other_deductions_history]
AS
SELECT     TOP (100) PERCENT [hrm].employee.employee_id, SUM(payroll.payroll_history.amount) AS OtherDeductions, payroll.payroll_history.pay_period
FROM         [hrm].employee INNER JOIN
                      payroll.payroll_history ON [hrm].employee.employee_id = payroll.payroll_history.employee_id LEFT OUTER JOIN
                      payroll.payroll_parameter ON payroll.payroll_history.param_id = payroll.payroll_parameter.param_id
WHERE     (payroll.payroll_parameter.parameter_group_id = 3) AND ([hrm].employee.deleted = 0)
GROUP BY [hrm].employee.employee_id, payroll.payroll_history.pay_period
ORDER BY [hrm].employee.employee_id