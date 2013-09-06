CREATE PROCEDURE [payroll].[sp_Set_Periodic_Deduction]
(
  @EmployeeId as int,
  @ParamId as int,
  @MonthlyAmount as decimal(18,2),
  @PayPeriod as int,
  @RemainingPeriod as int,
  @InitialAmount as decimal(18,2),
  @Balance as decimal(18,2)
)

AS

DECLARE @count as int
DECLARE @count2 as int
DECLARE @count3 as int

SELECT @count = COUNT(*) FROM payroll_periodic_deduction
WHERE payroll_periodic_deduction.employee_id = @EmployeeId AND payroll_periodic_deduction.param_id = @ParamId

BEGIN 
	IF(@count >0)
		BEGIN 
			UPDATE payroll_periodic_deduction
			SET payroll_periodic_deduction.monthly_amount = @MonthlyAmount,
			payroll_periodic_deduction.pay_period = @PayPeriod,
			payroll_periodic_deduction.remaining_period = @RemainingPeriod,
			payroll_periodic_deduction.initail_amount = @InitialAmount,
			payroll_periodic_deduction.balance = @Balance
			WHERE payroll_periodic_deduction.employee_id = @EmployeeId AND payroll_periodic_deduction.param_id = @ParamId
			
			SELECT @count2 = count(*) FROM payroll_current
			WHERE payroll_current.employee_id = @EmployeeId AND payroll_current.param_id = @ParamId
			
			IF(@count2>0)
				BEGIN
					UPDATE payroll_current
					SET payroll_current.amount = @MonthlyAmount 
					WHERE payroll_current.employee_id = @EmployeeId AND payroll_current.param_id = @ParamId
				END
			ELSE
				BEGIN
					INSERT INTO payroll_current (payroll_current.employee_id,payroll_current.param_id,payroll_current.amount) VALUES (@EmployeeId,@ParamId,@MonthlyAmount)
				END
				
			SELECT @count3 = count(*) FROM payroll_parameter_setting
			WHERE payroll_parameter_setting.employee_id = @EmployeeId AND payroll_parameter_setting.param_id = @ParamId
			
			IF(@count3>0)
				BEGIN
					UPDATE payroll_parameter_setting
					SET payroll_parameter_setting.is_active = 1
					WHERE payroll_parameter_setting.employee_id = @EmployeeId AND payroll_parameter_setting.param_id = @ParamId
				END
			ELSE
				BEGIN
					INSERT INTO payroll_parameter_setting (payroll_parameter_setting.employee_id,payroll_parameter_setting.param_id,payroll_parameter_setting.is_active) 
					VALUES (@EmployeeId,@ParamId,1)
				END
			
		END
	ELSE
		BEGIN
			INSERT INTO payroll_periodic_deduction (employee_id,param_id,monthly_amount,pay_period,remaining_period,initail_amount,balance)
			VALUES (@EmployeeId,@ParamId,@MonthlyAmount,@PayPeriod,@RemainingPeriod,@InitialAmount,@Balance)
			
			SELECT @count2 = count(*) FROM payroll_current
			WHERE payroll_current.employee_id = @EmployeeId AND payroll_current.param_id = @ParamId
			
			IF(@count2>0)
				BEGIN
					UPDATE payroll_current
					SET payroll_current.amount = @MonthlyAmount 
					WHERE payroll_current.employee_id = @EmployeeId AND payroll_current.param_id = @ParamId
				END
			ELSE
				BEGIN
					INSERT INTO payroll_current (payroll_current.employee_id,payroll_current.param_id,payroll_current.amount) VALUES (@EmployeeId,@ParamId,@MonthlyAmount)
				END
				
			SELECT @count3 = count(*) FROM payroll_parameter_setting
			WHERE payroll_parameter_setting.employee_id = @EmployeeId AND payroll_parameter_setting.param_id = @ParamId
			
			IF(@count3>0)
				BEGIN
					UPDATE payroll_parameter_setting
					SET payroll_parameter_setting.is_active = 1
					WHERE payroll_parameter_setting.employee_id = @EmployeeId AND payroll_parameter_setting.param_id = @ParamId
				END
			ELSE
				BEGIN
					INSERT INTO payroll_parameter_setting (payroll_parameter_setting.employee_id,payroll_parameter_setting.param_id,payroll_parameter_setting.is_active) 
					VALUES (@EmployeeId,@ParamId,1)
				END
		END
END