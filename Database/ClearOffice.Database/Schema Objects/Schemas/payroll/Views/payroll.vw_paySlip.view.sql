CREATE VIEW payroll.vw_paySlip
AS
SELECT     payroll.payroll_current.employee_id, hrm.person.first_name + ' ' + hrm.person.last_name AS FullName, payroll.payroll_parameter.param_name, 
                      payroll.payroll_current.amount, (CASE payroll.payroll_parameter.type_id WHEN 1 THEN 1 ELSE 2 END) AS Earnings, 
                      (CASE payroll.payroll_parameter.type_id WHEN 2 THEN 2 ELSE 1 END) AS Deductions, payroll.payroll_result.grosssalary, payroll.payroll_result.incometax, 
                      payroll.payroll_result.toldeductions, payroll.payroll_result.tolearnings, payroll.payroll_result.netpay, payroll.payroll_result.overpay, 
                      payroll.payroll_parameter.param_id
FROM         payroll.payroll_current INNER JOIN
                      hrm.employee ON payroll.payroll_current.employee_id = hrm.employee.employee_id LEFT OUTER JOIN
                      hrm.person ON hrm.employee.person_id = hrm.person.person_id INNER JOIN
                      payroll.payroll_parameter ON payroll.payroll_current.param_id = payroll.payroll_parameter.param_id INNER JOIN
                      payroll.payroll_result ON payroll.payroll_current.employee_id = payroll.payroll_result.employee_id
WHERE     (payroll.payroll_current.amount <> 0)