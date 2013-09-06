CREATE VIEW [payroll].[qry_get_PF15]
AS
SELECT     payroll.payroll_current.amount AS PF15, [hrm].employee.employee_id
FROM         payroll.payroll_current INNER JOIN
                      [hrm].employee ON payroll.payroll_current.employee_id = [hrm].employee.employee_id
WHERE     (payroll.payroll_current.param_id = 39)