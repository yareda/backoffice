CREATE VIEW payroll.vw_rpt_contract_payroll_sheet
AS
SELECT     hrm.employee.employee_id, hrm.employee.salary, hrm.person.first_name + ' ' + hrm.person.last_name AS full_name, payroll.payroll_result.netpay, 
                      payroll.payroll_result.incometax, payroll.payroll_result.grosssalary, payroll.payroll_result.toldeductions, payroll.payroll_result.tolearnings, 
                      payroll.qry_get_PF10.PF10 AS PF10Amount, payroll.qry_get_PF15.PF15 AS PF15Amount, payroll.qry_get_transport_allowance.Transport, 
                      payroll.qry_get_other_earnings.OtherEarnings, payroll.qry_get_other_deductions.OtherDeductions, hrm.organization.node_name AS department, 
                      payroll.qry_get_special_allowance.Special, hrm.organization.node_id
FROM         hrm.person INNER JOIN
                      hrm.employee ON hrm.person.person_id = hrm.employee.person_id LEFT OUTER JOIN
                      payroll.payroll_result ON hrm.employee.employee_id = payroll.payroll_result.employee_id LEFT OUTER JOIN
                      payroll.qry_get_PF10 ON hrm.employee.employee_id = payroll.qry_get_PF10.employee_id LEFT OUTER JOIN
                      payroll.qry_get_PF15 ON hrm.employee.employee_id = payroll.qry_get_PF15.employee_id LEFT OUTER JOIN
                      payroll.qry_get_transport_allowance ON hrm.employee.employee_id = payroll.qry_get_transport_allowance.employee_id LEFT OUTER JOIN
                      payroll.qry_get_other_earnings ON hrm.employee.employee_id = payroll.qry_get_other_earnings.employee_id LEFT OUTER JOIN
                      payroll.qry_get_other_deductions ON hrm.employee.employee_id = payroll.qry_get_other_deductions.employee_id INNER JOIN
                      hrm.organization ON hrm.employee.node_id = hrm.organization.node_id LEFT OUTER JOIN
                      payroll.qry_get_special_allowance ON hrm.employee.employee_id = payroll.qry_get_special_allowance.employee_id
WHERE     (hrm.employee.deleted = 0) AND (hrm.employee.employee_type = 4)