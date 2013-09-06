CREATE VIEW hrm.employee_info
AS
SELECT     hrm.person.first_name + ' ' + hrm.person.last_name + ' ' + hrm.person.grand_father_name AS full_name, hrm.employee.hire_date, hrm.employee.employee_no, 
                      hrm.employee.salary, hrm.employee.employee_id, hrm.job.job_title, hrm.organization.node_name, hrm.employee.job_id, hrm.employee.node_id, 
                      hrm.employee.status_id, hrm.employee.is_managment
FROM         hrm.employee INNER JOIN
                      hrm.person ON hrm.employee.person_id = hrm.person.person_id LEFT OUTER JOIN
                      hrm.organization ON hrm.employee.node_id = hrm.organization.node_id LEFT OUTER JOIN
                      hrm.job ON hrm.employee.job_id = hrm.job.job_id