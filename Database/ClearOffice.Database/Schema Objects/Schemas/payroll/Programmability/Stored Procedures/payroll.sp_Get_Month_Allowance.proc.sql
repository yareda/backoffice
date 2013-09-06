CREATE PROCEDURE [payroll].[sp_Get_Month_Allowance](
@StartDate as datetime,
@EndDate as datetime,
@EmployeeId as int
)
AS 

SELECT payroll.employee_allowance.employee_id,payroll.employee_allowance.allowance_amount, 
	   payroll.employee_allowance.param_id,payroll.employee_allowance.effective_date
FROM payroll.employee_allowance
WHERE payroll.employee_allowance.effective_date BETWEEN @StartDate AND @EndDate 
AND payroll.employee_allowance.employee_id = @EmployeeId