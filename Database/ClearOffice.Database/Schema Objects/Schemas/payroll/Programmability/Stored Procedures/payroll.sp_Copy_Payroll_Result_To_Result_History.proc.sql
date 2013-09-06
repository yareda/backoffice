-- =============================================
-- Author:		<Author,,Name>
-- Create date: <Create Date,,>
-- Description:	<Description,,>
-- =============================================
CREATE PROCEDURE payroll.[sp_Copy_Payroll_Result_To_Result_History] AS

DECLARE @EmployeeID as int,
	@BasicSalary as decimal(18,2),
    @TolEarnings as decimal(18,2),
	@TolDeductions as decimal(18,2),
	@GrossSalary as decimal(18,2),
	@IncomeTax as decimal(18,2),
	@NetPay as decimal(18,2),
	@OverPay as decimal(18,2),
	@PayPeriod as datetime


DECLARE Result_History_Cursor CURSOR FOR

SELECT payroll_result.employee_id,payroll_result.basic_salary,
	payroll_result.tolearnings,payroll_result.toldeductions,
	payroll_result.grosssalary,payroll_result.incometax,
	payroll_result.netpay,payroll_result.overpay,
	payroll_setting.pay_period 
FROM payroll_result, payroll_setting


OPEN Result_History_Cursor
FETCH NEXT FROM Result_History_Cursor

Into @EmployeeID,@BasicSalary,@TolEarnings,@TolDeductions,
     @GrossSalary,@IncomeTax,@NetPay,@OverPay,@PayPeriod

While @@Fetch_Status=0
Begin
    Insert into payroll_result_history
		(employee_id,basic_salary,
		 tol_earnings,tol_deductions,
		 gross_salary,income_tax,
		 net_pay,over_pay,pay_period)
    	values
		(@EmployeeID,@BasicSalary,
		 @TolEarnings,@TolDeductions,
	         @GrossSalary,@IncomeTax,
		 @NetPay,@OverPay,@PayPeriod)

   FETCH NEXT FROM Result_History_Cursor
Into @EmployeeID,@BasicSalary,@TolEarnings,@TolDeductions,
     @GrossSalary,@IncomeTax,@NetPay,@OverPay,@PayPeriod


End

close Result_History_Cursor
Deallocate Result_History_Cursor