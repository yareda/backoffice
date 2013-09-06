CREATE VIEW hrm.employee_pto_info
AS
SELECT     hrm.employee_pto.pto_id, hrm.employee_pto.employee_id, hrm.employee_pto.[from], hrm.employee_pto.[to], hrm.employee_pto.num_days, 
                      hrm.employee_pto.remark, hrm.person.first_name + ' ' + hrm.person.last_name + ' ' + hrm.person.grand_father_name AS employee_full_name, 
                      hrm.employee_pto.status
FROM         hrm.employee_pto INNER JOIN
                      hrm.employee ON hrm.employee_pto.employee_id = hrm.employee.employee_id INNER JOIN
                      hrm.person ON hrm.employee.person_id = hrm.person.person_id