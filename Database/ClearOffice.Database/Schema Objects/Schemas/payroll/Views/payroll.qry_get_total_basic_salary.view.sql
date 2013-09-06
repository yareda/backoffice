CREATE VIEW [payroll].[qry_get_total_basic_salary]
AS
SELECT     SUM(salary) AS salary
FROM         [hrm].employee
WHERE     (deleted = 0)