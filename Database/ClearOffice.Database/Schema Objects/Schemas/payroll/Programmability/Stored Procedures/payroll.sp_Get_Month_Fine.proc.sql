CREATE PROCEDURE [payroll].[sp_Get_Month_Fine](
@StartDate as datetime,
@EndDate as datetime,
@EmployeeId as int
)
AS 

SELECT payroll.employee_fine.fine_id, payroll.employee_fine.effective_date, payroll.employee_fine.monthly_fine,
	   payroll.employee_fine.employee_id
FROM payroll.employee_fine 
WHERE payroll.employee_fine.fine_duration = payroll.employee_fine.remaining_duration AND 
payroll.employee_fine.effective_date BETWEEN @StartDate AND @EndDate 
AND payroll.employee_fine.employee_id  = @EmployeeId