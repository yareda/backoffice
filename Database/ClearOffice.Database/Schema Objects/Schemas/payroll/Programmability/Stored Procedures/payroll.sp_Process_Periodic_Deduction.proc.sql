CREATE PROCEDURE [payroll].[sp_Process_Periodic_Deduction] 

AS 

DECLARE @EmployeeId as int,
		@ParamId as int,
		@MonthlyAmount as decimal,
		@PayPeriod as int,
		@RemainingPeriod as int,
		@InitialAmount as decimal,
		@Balance as decimal
		
		
DECLARE Periodic_Cursor CURSOR FOR
SELECT payroll_periodic_deduction.employee_id, payroll_periodic_deduction.param_id,
	   payroll_periodic_deduction.monthly_amount,payroll_periodic_deduction.pay_period,
	   payroll_periodic_deduction.remaining_period,payroll_periodic_deduction.initail_amount,
	   payroll_periodic_deduction.balance
FROM payroll_periodic_deduction 

OPEN Periodic_Cursor 
FETCH NEXT FROM Periodic_Cursor 
INTO @EmployeeId,@ParamId,@MonthlyAmount,@PayPeriod,@RemainingPeriod,@InitialAmount,@Balance

WHILE @@FETCH_STATUS =0
BEGIN
	IF(@RemainingPeriod>0)
		BEGIN
			SET @RemainingPeriod = @RemainingPeriod - 1
			SET @Balance = @Balance - @MonthlyAmount
			
			UPDATE payroll_periodic_deduction
			SET payroll_periodic_deduction.remaining_period = @RemainingPeriod,
			payroll_periodic_deduction.balance = @Balance
			WHERE payroll_periodic_deduction.employee_id = @EmployeeId AND 
			payroll_periodic_deduction.param_id = @ParamId
			
			UPDATE employee_loan
			SET balance_amount = @Balance, remaining_period = @RemainingPeriod
			WHERE employee_loan.employee_id = @EmployeeId AND employee_loan.param_id = @ParamId
			
			UPDATE payroll_current
			SET payroll_current.amount = @MonthlyAmount, payroll_current.istransfer = 1
			WHERE payroll_current.employee_id = @EmployeeId AND payroll_current.param_id = @ParamId
			
			UPDATE payroll_parameter_setting
			SET payroll_parameter_setting.is_active = 1
			WHERE payroll_parameter_setting.employee_id = @EmployeeId AND payroll_parameter_setting.param_id = @ParamId
			
		END
	ELSE
		BEGIN
			DELETE FROM payroll_periodic_deduction
			WHERE payroll_periodic_deduction.employee_id = @EmployeeId AND 
			payroll_periodic_deduction.param_id = @ParamId
			
			UPDATE payroll_current
			SET payroll_current.amount = 0, payroll_current.istransfer = 0
			WHERE payroll_current.employee_id = @EmployeeId AND payroll_current.param_id = @ParamId
			
			UPDATE payroll_parameter_setting
			SET payroll_parameter_setting.is_active = 0
			WHERE payroll_parameter_setting.employee_id = @EmployeeId AND 
			payroll_parameter_setting.param_id = @ParamId
		END
	FETCH NEXT FROM Periodic_Cursor 
	INTO @EmployeeId,@ParamId,@MonthlyAmount,@PayPeriod,@RemainingPeriod,@InitialAmount,@Balance
END
CLOSE Periodic_Cursor
DEALLOCATE Periodic_Cursor