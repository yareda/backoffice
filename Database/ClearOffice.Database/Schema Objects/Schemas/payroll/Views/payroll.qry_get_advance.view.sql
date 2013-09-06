CREATE VIEW [payroll].[qry_get_advance]
AS
SELECT     [hrm].employee.employee_id, payroll.payroll_current.amount AS Advance
FROM         payroll.payroll_current INNER JOIN
                      [hrm].employee ON payroll.payroll_current.employee_id = [hrm].employee.employee_id
WHERE     (payroll.payroll_current.param_id = 41)