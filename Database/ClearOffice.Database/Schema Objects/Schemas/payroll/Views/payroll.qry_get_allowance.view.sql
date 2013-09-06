CREATE VIEW [payroll].[qry_get_allowance]
AS
SELECT     [hrm].employee.employee_id, payroll.payroll_current.amount AS Allowance
FROM         payroll.payroll_current INNER JOIN
                      [hrm].employee ON payroll.payroll_current.employee_id = [hrm].employee.employee_id
WHERE     (payroll.payroll_current.param_id = 42)