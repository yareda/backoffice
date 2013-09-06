CREATE VIEW payroll.vw_rpt_payroll_sheet_history
AS
SELECT DISTINCT 
                      hrm.employee.employee_id, hrm.employee.salary, hrm.person.first_name + ' ' + hrm.person.last_name AS full_name, 
                      payroll.payroll_result_history.net_pay AS netpay, payroll.payroll_result_history.income_tax AS incometax, 
                      payroll.payroll_result_history.gross_salary AS grosssalary, payroll.payroll_result_history.tol_deductions AS toldeductions, 
                      payroll.payroll_result_history.tol_earnings AS tolearnings, payroll.qry_get_PF10_history.PF10 AS PF10Amount, payroll.qry_get_PF15_history.PF15 AS PF15Amount, 
                      payroll.qry_get_transport_allowance_history.Transport, payroll.qry_get_other_earnings_history.OtherEarnings, 
                      payroll.qry_get_other_deductions_history.OtherDeductions, payroll.qry_get_special_allowance_history.Special, hrm.organization.node_name AS department, 
                      hrm.organization.node_id, payroll.payroll_result_history.pay_period
FROM         hrm.employee INNER JOIN
                      hrm.person ON hrm.employee.person_id = hrm.person.person_id INNER JOIN
                      payroll.payroll_result_history ON hrm.employee.employee_id = payroll.payroll_result_history.employee_id INNER JOIN
                      payroll.qry_get_PF10_history ON hrm.employee.employee_id = payroll.qry_get_PF10_history.employee_id INNER JOIN
                      payroll.qry_get_PF15_history ON hrm.employee.employee_id = payroll.qry_get_PF15_history.employee_id INNER JOIN
                      payroll.qry_get_transport_allowance_history ON hrm.employee.employee_id = payroll.qry_get_transport_allowance_history.employee_id INNER JOIN
                      payroll.qry_get_other_earnings_history ON hrm.employee.employee_id = payroll.qry_get_other_earnings_history.employee_id INNER JOIN
                      payroll.qry_get_other_deductions_history ON hrm.employee.employee_id = payroll.qry_get_other_deductions_history.employee_id LEFT OUTER JOIN
                      payroll.qry_get_special_allowance_history ON hrm.employee.employee_id = payroll.qry_get_special_allowance_history.employee_id INNER JOIN
                      hrm.organization ON hrm.employee.node_id = hrm.organization.node_id
WHERE     (hrm.employee.deleted = 0)