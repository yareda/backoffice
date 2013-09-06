CREATE VIEW [payroll].[qry_rpt_bank_account_net_pay]
AS
SELECT     payroll.payroll_result.netpay, [hrm].employee.employee_no, [hrm].employee.account_no, 
                      [hrm].person.first_name + ' ' + [hrm].person.last_name + ' ' + [hrm].person.grand_father_name AS FullName
FROM         payroll.payroll_result INNER JOIN
                      [hrm].employee ON payroll.payroll_result.employee_id = [hrm].employee.employee_id RIGHT OUTER JOIN
                      [hrm].person ON [hrm].employee.person_id = [hrm].person.person_id
WHERE     ([hrm].employee.deleted = 0)