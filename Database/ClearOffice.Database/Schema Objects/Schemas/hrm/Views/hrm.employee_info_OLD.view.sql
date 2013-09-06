/*CREATE VIEW [hrm].[employee_info_OLD]
AS
SELECT     hrm.person.first_name + ' ' + hrm.person.last_name + ' ' + hrm.person.grand_father_name AS full_name, hrm.person.sex, hrm.person.dob, hrm.person.place_of_birth, 
                      hrm.person.person_id, hrm.employee.employee_id, department.name AS department_name, employment_status.name AS status_name, hrm.employee.hire_date, 
                      hrm.employee.status, hrm.employee.struct_id, hrm.employee.job_title
FROM         hrm.employee INNER JOIN
                      hrm.person ON hrm.employee.person_id = hrm.person.person_id LEFT OUTER JOIN
                      hrm.lookup_item AS positions ON hrm.employee.job_title = positions.item_id LEFT OUTER JOIN
                      hrm.lookup_item AS employment_status ON hrm.employee.status = employment_status.item_id LEFT OUTER JOIN
                      hrm.lookup_item AS department ON hrm.employee.struct_id = department.item_id*/