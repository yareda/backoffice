CREATE VIEW wms.workshop_employees_info
AS
SELECT     hrm.employee.employee_id, hrm.employee.employee_no, hrm.person.first_name + ' ' + hrm.person.last_name + ' ' + hrm.person.grand_father_name AS full_name, 
                      hrm.person.photo, CASE WHEN hrm.person.sex = 1 THEN 'male' ELSE 'female' END AS sex_text
FROM         hrm.employee INNER JOIN
                      hrm.person ON hrm.employee.person_id = hrm.person.person_id