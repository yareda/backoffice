CREATE VIEW hrm.employee_pto_status_info
AS
SELECT     hrm.person.first_name + ' ' + hrm.person.last_name + ' ' + hrm.person.grand_father_name AS employee_full_name, hrm.employee_pto_status.leave_status_id, 
                      hrm.employee_pto_status.current_count, hrm.employee_pto_status.prev_count + hrm.employee_pto_status.current_count AS total, hrm.employee.employee_no, 
                      hrm.employee.hire_date, hrm.employee.year_count AS service_year, hrm.employee.employee_id, hrm.employee_pto_status.prev_count
FROM         hrm.employee INNER JOIN
                      hrm.person ON hrm.employee.person_id = hrm.person.person_id LEFT OUTER JOIN
                      hrm.employee_pto_status ON hrm.employee.employee_id = hrm.employee_pto_status.employee_id