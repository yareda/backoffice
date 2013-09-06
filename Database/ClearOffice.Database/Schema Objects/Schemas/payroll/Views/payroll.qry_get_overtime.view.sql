CREATE VIEW [payroll].[qry_get_overtime]
AS
SELECT     SUM(payroll.payroll_current.amount) AS OTAmount, payroll.payroll_current.employee_id
FROM         payroll.payroll_current INNER JOIN
                      payroll.payroll_parameter ON payroll.payroll_current.param_id = payroll.payroll_parameter.param_id
WHERE     (payroll.payroll_parameter.is_ot = 1)
GROUP BY payroll.payroll_current.employee_id