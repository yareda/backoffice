CREATE VIEW payroll.vw_rpt_net_pay_transfer
AS
SELECT     hrm.person.first_name + ' ' + hrm.person.last_name AS full_name, hrm.employee.employee_id, hrm.employee.account_no, hrm.bank_branch.branch_name, 
                      payroll.payroll_result.netpay
FROM         hrm.person INNER JOIN
                      hrm.employee ON hrm.person.person_id = hrm.employee.person_id LEFT OUTER JOIN
                      hrm.bank_branch ON hrm.employee.bank_branch_id = hrm.bank_branch.bank_branch_id LEFT OUTER JOIN
                      payroll.payroll_result ON hrm.employee.employee_id = payroll.payroll_result.employee_id
WHERE     (hrm.employee.deleted = 0)