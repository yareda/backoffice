CREATE VIEW [payroll].[qry_get_telephone_allowance]
AS
SELECT     [hrm].employee.employee_id, payroll.payroll_current.amount AS TellAllowance
FROM         [hrm].employee INNER JOIN
                      payroll.payroll_current ON [hrm].employee.employee_id = payroll.payroll_current.employee_id
WHERE     (payroll.payroll_current.param_id = 45)