CREATE PROCEDURE [payroll].[sp_Reset_Parameter_Value]
 (
 @EmployeeId as int,
 @ParamID as int
 )
 
 AS
 
 DECLARE @Count as int
 DECLARE @Count2 as int
 SELECT @Count = payroll.payroll_current.employee_id FROM payroll.payroll_current
 WHERE payroll.payroll_current.employee_id = @EmployeeId AND payroll.payroll_current.param_id = @ParamID
 
 IF(@Count>0)
	BEGIN
		UPDATE payroll.payroll_current
		SET amount = 0
		WHERE payroll.payroll_current.employee_id = @EmployeeId AND 
		payroll.payroll_current.param_id = @ParamID AND
		payroll.payroll_current.istransfer = 0
		
	END
	
 SELECT @Count2 = payroll.payroll_parameter_setting.employee_id FROM payroll.payroll_parameter_setting
		INNER JOIN payroll.payroll_current ON payroll.payroll_parameter_setting.param_id = payroll.payroll_current.param_id AND
										  payroll.payroll_parameter_setting.employee_id = payroll.payroll_current.employee_id
 WHERE payroll.payroll_parameter_setting.employee_id = @EmployeeId 
	   AND payroll.payroll_parameter_setting.param_id = @ParamID AND 
	   payroll.payroll_current.isapprove = 0
 
 IF(@Count2>0)
	BEGIN
		UPDATE payroll.payroll_parameter_setting 
		SET is_active = 0
		WHERE payroll.payroll_parameter_setting.employee_id = @EmployeeId AND 
		payroll.payroll_parameter_setting.param_id = @ParamID	
	END