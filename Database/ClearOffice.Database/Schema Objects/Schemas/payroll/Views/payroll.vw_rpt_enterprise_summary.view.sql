CREATE VIEW [payroll].[vw_rpt_enterprise_summary]
AS
SELECT     payroll.payroll_parameter.param_name AS parameter, payroll.payroll_parameter.param_id, SUM(payroll.payroll_current.amount) AS amount, 
                      payroll.qry_get_total_basic_salary.salary, payroll.qry_get_total_result.TotalEarnings, payroll.qry_get_total_result.TotalDeductions, payroll.qry_get_total_result.TotalIncomeTax, 
                      payroll.qry_get_total_result.TotalNetPay, payroll.qry_get_total_result.TotalOverPay
FROM         payroll.qry_get_total_basic_salary CROSS JOIN
                      payroll.qry_get_total_result CROSS JOIN
                      payroll.payroll_parameter INNER JOIN
                      payroll.payroll_current ON payroll.payroll_parameter.param_id = payroll.payroll_current.param_id INNER JOIN
                      [hrm].employee ON payroll.payroll_current.employee_id = [hrm].employee.employee_id
WHERE     (payroll.payroll_current.amount <> 0) AND ([hrm].employee.deleted = 0)
GROUP BY payroll.payroll_parameter.param_name, payroll.payroll_parameter.param_id, payroll.qry_get_total_basic_salary.salary, payroll.qry_get_total_result.TotalEarnings, 
                      payroll.qry_get_total_result.TotalDeductions, payroll.qry_get_total_result.TotalIncomeTax, payroll.qry_get_total_result.TotalNetPay, payroll.qry_get_total_result.TotalOverPay