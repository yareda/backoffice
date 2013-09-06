CREATE VIEW payroll.employee_info
AS
SELECT     employee_id AS EmployeeId, hire_date AS HireDate, full_name AS FullName, employee_no AS EmployeeNo, status_id AS Status, is_managment AS IsManagment, 
                      payroll.GetYears(DATEDIFF(month, hire_date, GETDATE())) AS ServiceYear, payroll.GetMonths(DATEDIFF(month, hire_date, GETDATE())) AS ServiceMonth, salary, 
                      node_id
FROM         hrm.employee_info AS employee_info_1