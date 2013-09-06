CREATE PROCEDURE [payroll].[sp_Add_Payroll_Result]
(
	@EmployeeId as int,
	@BasicSalary as decimal (18,2),
	@TotalEarnings as decimal (18,2),
	@TotalDeductions as decimal (18,2),
	@GrossSalary as decimal (18,2),
	@IncomeTax as decimal (18,2),
	@NetPay as decimal (18,2),
	@OverPay as decimal (18,2)
)

AS 

DECLARE @count as int

SELECT @count = COUNT(*) FROM payroll_result
WHERE payroll_result.employee_id = @EmployeeId

BEGIN 
	IF(@count>0)
		BEGIN
			UPDATE payroll_result
			SET basic_salary = @BasicSalary,
			tolearnings = @TotalEarnings,
			toldeductions = @TotalDeductions,
			grosssalary = @GrossSalary,
			incometax = @IncomeTax,
			netpay = @NetPay,
			overpay = @OverPay
			WHERE payroll_result.employee_id = @EmployeeId
		END
	ELSE
		BEGIN 
			INSERT INTO payroll_result (employee_id,basic_salary,tolearnings,toldeductions,grosssalary,incometax,netpay,overpay)
			VALUES (@EmployeeId,@BasicSalary,@TotalEarnings,@TotalDeductions,@GrossSalary,@IncomeTax,@NetPay,@OverPay)		
		END 
END