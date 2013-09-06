CREATE PROCEDURE [payroll].[sp_GetMonthlyPTO](
@Starting datetime, @Ending datetime
)
AS

SELECT person.first_name + ' ' + person.last_name + ' ' + person.grand_father_name As full_name, employee.employee_id, 
	employee.current_leave_days As remaining,SUM(employee_leave.no_of_days) As no_days,
	organization_structure.unit_name As department
FROM employee LEFT JOIN employee_leave ON employee.employee_id = employee_leave.employee_id
INNER JOIN person ON employee.person_id= person.person_id
INNER JOIN organization_structure ON employee.struct_id = organization_structure.struct_id
WHERE employee.deleted = 0 AND (employee_leave.start_date BETWEEN @Starting AND @Ending) AND (employee_leave.end_date BETWEEN @Starting AND @Ending)

GROUP BY employee.employee_id, employee.current_leave_days,person.first_name , person.last_name , person.grand_father_name,organization_structure.unit_name