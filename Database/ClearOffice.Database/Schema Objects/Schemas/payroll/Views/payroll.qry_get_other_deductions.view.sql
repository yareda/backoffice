CREATE VIEW [payroll].[qry_get_other_deductions]
AS
SELECT     [hrm].employee.employee_id, SUM(payroll.payroll_current.amount) AS OtherDeductions
FROM         [hrm].employee INNER JOIN
                      payroll.payroll_current ON [hrm].employee.employee_id = payroll.payroll_current.employee_id LEFT OUTER JOIN
                      payroll.payroll_parameter ON payroll.payroll_current.param_id = payroll.payroll_parameter.param_id
WHERE     (payroll.payroll_parameter.parameter_group_id = 3) AND ([hrm].employee.deleted = 0)
GROUP BY [hrm].employee.employee_id