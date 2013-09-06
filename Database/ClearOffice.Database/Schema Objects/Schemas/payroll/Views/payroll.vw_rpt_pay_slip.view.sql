CREATE VIEW [payroll].[vw_rpt_pay_slip]
AS
SELECT     payroll.payroll_pay_slip.earnings, payroll.payroll_pay_slip.earnvals, payroll.payroll_pay_slip.deductions, payroll.payroll_pay_slip.deducvals, payroll.payroll_pay_slip.pay_slip_id, 
                      hrm.person.first_name + ' ' + hrm.person.last_name AS FullName, payroll.payroll_result.netpay, payroll.payroll_result.incometax, payroll.payroll_result.toldeductions, 
                      payroll.payroll_result.tolearnings, payroll.payroll_result.grosssalary, hrm.employee.employee_id
FROM         hrm.person INNER JOIN
                      hrm.employee ON hrm.person.person_id = hrm.employee.person_id LEFT OUTER JOIN
                      payroll.payroll_pay_slip ON hrm.employee.employee_id = payroll.payroll_pay_slip.employee_id LEFT OUTER JOIN
                      payroll.payroll_result ON hrm.employee.employee_id = payroll.payroll_result.employee_id
WHERE     (hrm.employee.deleted = 0)