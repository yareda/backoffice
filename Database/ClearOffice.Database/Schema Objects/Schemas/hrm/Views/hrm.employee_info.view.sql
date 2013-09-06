CREATE VIEW hrm.employee_info
AS
SELECT     hrm.person.first_name + ' ' + hrm.person.last_name + ' ' + hrm.person.grand_father_name AS full_name, hrm.employee.hire_date, hrm.employee.employee_no, 
                      hrm.employee.salary, hrm.employee.employee_id
FROM         hrm.employee INNER JOIN
                      hrm.person ON hrm.employee.person_id = hrm.person.person_id