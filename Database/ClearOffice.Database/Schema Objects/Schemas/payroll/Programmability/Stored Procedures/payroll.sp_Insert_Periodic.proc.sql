CREATE PROCEDURE [payroll].[sp_Insert_Periodic]
(@EmployeeId as int,
  @ParamId as int,
  @MonthlyAmount as decimal(18,2),
  @PayPeriod as int,
  @RemainingPeriod as int,
  @InitialAmount as decimal(18,2),
  @Balance as decimal(18,2)
 )
 AS
 
 DECLARE @count as int
 
 SELECT @count = COUNT(*) FROM payroll_periodic_deduction
 WHERE payroll_periodic_deduction.employee_id = @EmployeeId AND payroll_periodic_deduction.param_id = @ParamId

 IF(@count >0)
	BEGIN
		UPDATE payroll_periodic_deduction
			SET payroll_periodic_deduction.monthly_amount = @MonthlyAmount,
			payroll_periodic_deduction.pay_period = @PayPeriod,
			payroll_periodic_deduction.remaining_period = @RemainingPeriod,
			payroll_periodic_deduction.initail_amount = @InitialAmount,
			payroll_periodic_deduction.balance = @Balance
			WHERE payroll_periodic_deduction.employee_id = @EmployeeId AND payroll_periodic_deduction.param_id = @ParamId
	END
 ELSE
	BEGIN
		INSERT INTO payroll_periodic_deduction (employee_id,param_id,monthly_amount,pay_period,remaining_period,initail_amount,balance)
		VALUES (@EmployeeId,@ParamId,@MonthlyAmount,@PayPeriod,@RemainingPeriod,@InitialAmount,@Balance)
	END