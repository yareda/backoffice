CREATE PROCEDURE [payroll].[sp_Add_Pay_Data]
(
  @EmployeeId as int,
  @ParamId as int,
  @Value as decimal(18,2),
  @IsHourly as int,
  @IsTransfered as int
)

AS 

DECLARE @count as int

SELECT @count = count(*) FROM payroll_current
WHERE employee_id = @EmployeeId AND param_id = @ParamId

BEGIN 
	IF(@count >0)
	BEGIN
		IF(@IsHourly = 1)
		BEGIN
			UPDATE payroll_current 
			SET hrs = @Value, istransfer = @IsTransfered
			WHERE employee_id = @EmployeeId AND param_id = @ParamId
		END
		ELSE
		BEGIN
			UPDATE payroll_current
			SET amount = @Value, istransfer = @IsTransfered
			WHERE employee_id = @EmployeeId AND param_id = @ParamId
		END
	END
	ELSE
	BEGIN
		IF(@IsHourly = 1)
		BEGIN
			INSERT INTO payroll_current (employee_id,param_id,hrs, istransfer) VALUES (@EmployeeId,@ParamId,@Value, @IsTransfered)
		END
		ELSE
		BEGIN
			INSERT INTO payroll_current (employee_id,param_id,amount, istransfer) VALUES (@EmployeeId,@ParamId,@Value, @IsTransfered)
		END
	END
	
	SELECT @count = count(*) FROM payroll_parameter_setting
	WHERE payroll_parameter_setting.employee_id = @EmployeeId AND payroll_parameter_setting.param_id = @ParamId
	
	IF(@count>0)
	BEGIN
		UPDATE payroll_parameter_setting
		SET payroll_parameter_setting.is_active = 1
		WHERE payroll_parameter_setting.employee_id = @EmployeeId AND payroll_parameter_setting.param_id = @ParamId
	END
	ELSE
	BEGIN
		INSERT INTO payroll_parameter_setting (employee_id,param_id,is_active) VALUES (@EmployeeId,@ParamId,1)
	END
END