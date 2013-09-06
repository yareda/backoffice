CREATE VIEW [payroll].[vw_rpt_pf_transfer]
AS
SELECT     [hrm].person.first_name + ' ' + [hrm].person.last_name AS full_name, [hrm].employee.employee_id, payroll.qry_get_PF10.PF10, payroll.qry_get_PF15.PF15, 
                      [hrm].employee.pf_account_no, [hrm].person.person_id
FROM         [hrm].person LEFT OUTER JOIN
                      [hrm].employee ON [hrm].person.person_id = [hrm].employee.person_id LEFT OUTER JOIN
                      payroll.qry_get_PF10 ON [hrm].employee.employee_id = payroll.qry_get_PF10.employee_id LEFT OUTER JOIN
                      payroll.qry_get_PF15 ON [hrm].employee.employee_id = payroll.qry_get_PF15.employee_id
WHERE     ([hrm].employee.deleted = 0)