CREATE VIEW [payroll].[qry_get_total_result]
AS
SELECT     SUM(payroll.payroll_result.tolearnings) AS TotalEarnings, SUM(payroll.payroll_result.toldeductions) AS TotalDeductions, SUM(payroll.payroll_result.incometax) 
                      AS TotalIncomeTax, SUM(payroll.payroll_result.netpay) AS TotalNetPay, SUM(payroll.payroll_result.overpay) AS TotalOverPay
FROM         payroll.payroll_result INNER JOIN
                      [hrm].employee ON payroll.payroll_result.employee_id = [hrm].employee.employee_id
WHERE     ([hrm].employee.deleted = 0)