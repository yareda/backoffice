CREATE PROCEDURE [payroll].[sp_Set_Medical_Deduction]
 (@EmployeeId as int, @GradeId as int)
 
 AS 
 
 DECLARE @Count int
 
 SELECT @Count = payroll_parameter_setting.param_id FROM payroll_parameter_setting 
 WHERE payroll_parameter_setting.param_id = 47
 
 IF (@Count =0)
	BEGIN
		INSERT INTO payroll_parameter_setting(employee_id, is_active, param_id) VALUES (@EmployeeId, 1, 47)
	END
 ELSE 
	BEGIN
		UPDATE payroll_parameter_setting
		SET is_active = 1
		WHERE payroll_parameter_setting.employee_id = @EmployeeId AND payroll_parameter_setting.param_id = 47
	END 
 
 SELECT @Count = payroll_current.param_id FROM payroll_current
 WHERE payroll_current.employee_id = @EmployeeId AND payroll_current.param_id = 47
 
 IF (@Count =0)
	BEGIN
		INSERT INTO payroll_current(amount, employee_id, hrs,isapprove,istransfer,param_id) 
		VALUES (0,@EmployeeId, (SELECT employee_grade.medical_percentage FROM employee_grade WHERE employee_grade.grade_id = @GradeId), 0, 0, 47)
	END
 ELSE
	BEGIN
		UPDATE payroll_current 
		SET hrs = (SELECT employee_grade.medical_percentage FROM employee_grade WHERE employee_grade.grade_id = @GradeId)
		WHERE employee_id = @EmployeeId AND param_id = 47
	END