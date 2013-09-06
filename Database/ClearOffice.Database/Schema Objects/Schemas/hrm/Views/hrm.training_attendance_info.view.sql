CREATE VIEW hrm.training_attendance_info
AS
SELECT     hrm.person.first_name + ' ' + hrm.person.last_name + ' ' + hrm.person.grand_father_name AS full_name, hrm.employee.employee_no, 
                      hrm.training_attendance.has_completed, hrm.training_attendance.training_atendant_id, hrm.organization.node_name AS departement, hrm.job.job_title AS position, 
                      hrm.training_attendance.training_id
FROM         hrm.training_attendance LEFT OUTER JOIN
                      hrm.employee ON hrm.training_attendance.employee_id = hrm.employee.employee_id LEFT OUTER JOIN
                      hrm.person ON hrm.employee.person_id = hrm.person.person_id LEFT OUTER JOIN
                      hrm.organization ON hrm.employee.node_id = hrm.organization.node_id LEFT OUTER JOIN
                      hrm.job ON hrm.employee.job_id = hrm.job.job_id