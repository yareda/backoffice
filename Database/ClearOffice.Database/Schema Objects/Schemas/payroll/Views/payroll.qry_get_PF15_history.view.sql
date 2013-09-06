CREATE VIEW [payroll].[qry_get_PF15_history]
AS
SELECT     payroll.payroll_history.amount AS PF15, payroll.payroll_history.pay_period, [hrm].employee.employee_id
FROM         payroll.payroll_history INNER JOIN
                      [hrm].employee ON payroll.payroll_history.employee_id = [hrm].employee.employee_id
WHERE     (payroll.payroll_history.param_id = 39) AND ([hrm].employee.deleted = 0)