CREATE VIEW [payroll].[qry_get_loan_credit]
AS
SELECT     payroll.payroll_current.employee_id, SUM(payroll.payroll_current.amount) AS Credit
FROM         payroll.payroll_current INNER JOIN
                      payroll.payroll_parameter ON payroll.payroll_current.param_id = payroll.payroll_parameter.param_id INNER JOIN
                      [hrm].employee ON payroll.payroll_current.employee_id = [hrm].employee.employee_id
WHERE     (payroll.payroll_parameter.parameter_group_id = 4) AND ([hrm].employee.deleted = 0)
GROUP BY payroll.payroll_current.employee_id