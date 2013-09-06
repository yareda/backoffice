CREATE VIEW [payroll].[search_payroll_employee]
AS
SELECT        [hrm].person.first_name, [hrm].person.last_name, [hrm].person.grand_father_name, payroll.payroll_employee_structure.employee_id, 
                         payroll.payroll_cost_center.cost_center
FROM            [hrm].employee INNER JOIN
                         payroll.payroll_employee_structure ON [hrm].employee.employee_id = payroll.payroll_employee_structure.employee_id INNER JOIN
                         [hrm].person ON [hrm].employee.person_id = [hrm].person.person_id INNER JOIN
                         payroll.payroll_cost_center ON payroll.payroll_employee_structure.cost_center_id = payroll.payroll_cost_center.cost_center_id