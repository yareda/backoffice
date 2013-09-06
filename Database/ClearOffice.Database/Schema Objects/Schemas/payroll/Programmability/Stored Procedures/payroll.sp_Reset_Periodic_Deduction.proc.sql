CREATE PROCEDURE [payroll].[sp_Reset_Periodic_Deduction]
 (
	@EmployeeId as int,
	@ParamId as int
 )
 
 AS
 
 DECLARE @Count as int
 DECLARE @Count2 as int 
 DECLARE @Count3 as int
 
 SELECT @Count = payroll.payroll_periodic_deduction.employee_id FROM payroll.payroll_periodic_deduction
 WHERE payroll.payroll_periodic_deduction.employee_id = @EmployeeId AND payroll.payroll_periodic_deduction.param_id = @ParamId
 
 IF (@Count >0)
	BEGIN 
		DELETE FROM payroll.payroll_periodic_deduction
		WHERE payroll.payroll_periodic_deduction.employee_id = @EmployeeId AND payroll.payroll_periodic_deduction.param_id = @ParamId
		
		SELECT @Count2 = payroll.payroll_current.employee_id FROM payroll.payroll_current
		WHERE payroll.payroll_current.employee_id = @EmployeeId AND payroll.payroll_current.param_id = @ParamId
		
		IF (@Count2>0)		
			BEGIN
				UPDATE payroll.payroll_current
				SET amount = 0, istransfer = 0
				WHERE employee_id = @EmployeeId AND param_id = @ParamId		
			END
		SELECT @Count3 = payroll.payroll_parameter_setting.employee_id FROM payroll.payroll_parameter_setting
		WHERE payroll.payroll_parameter_setting.employee_id = @EmployeeId AND payroll.payroll_parameter_setting.param_id = @ParamId
		
		IF(@Count3>0)
			BEGIN
				UPDATE payroll.payroll_parameter_setting
				SET is_active = 0
				WHERE payroll.payroll_parameter_setting.employee_id = @EmployeeId AND payroll.payroll_parameter_setting.param_id = @ParamId
			END
	END