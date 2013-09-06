CREATE function [payroll].[sp_GetSum_of_leave_Days](
@EmployeeId as int, @StartDate as datetime, @EndDate as datetime)

RETURNS DECIMAL(18,2)

begin
DECLARE @Val as decimal(18,2)
SELECT @Val = SUM(employee_leave.no_of_days)  FROM employee_leave
WHERE employee_leave.employee_id = @EmployeeId AND (employee_leave.start_date BETWEEN @StartDate AND @EndDate) 
AND (employee_leave.end_date BETWEEN @StartDate AND @EndDate) 

RETURN @Val
end