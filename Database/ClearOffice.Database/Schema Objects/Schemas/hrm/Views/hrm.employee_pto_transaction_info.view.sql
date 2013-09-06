CREATE VIEW hrm.employee_pto_transaction_info
AS
SELECT     hrm.employee_pto_transaction.transaction_id, hrm.employee_pto_transaction.employee_id, hrm.employee_pto_transaction.year, 
                      hrm.employee_pto_transaction.no_days, hrm.employee_pto_transaction.approved_date, hrm.employee_pto_transaction.approved_by, hrm.employee.employee_no, 
                      hrm.person.first_name + ' ' + hrm.person.last_name + ' ' + hrm.person.grand_father_name AS full_name, hrm.employee.hire_date
FROM         hrm.employee_pto_transaction INNER JOIN
                      hrm.employee ON hrm.employee_pto_transaction.employee_id = hrm.employee.employee_id INNER JOIN
                      hrm.person ON hrm.employee.person_id = hrm.person.person_id