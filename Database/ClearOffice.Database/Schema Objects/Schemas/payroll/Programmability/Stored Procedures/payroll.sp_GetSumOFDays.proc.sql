CREATE PROCEDURE [payroll].[sp_GetSumOFDays](
@EmployeeId as int, @StartDate as datetime, @EndDate as datetime)

AS
SELECT SUM(employee_leave.no_of_days) as no_days FROM employee_leave
WHERE employee_leave.employee_id = @EmployeeId AND (employee_leave.start_date BETWEEN @StartDate AND @EndDate) 
AND (employee_leave.end_date BETWEEN @StartDate AND @EndDate)