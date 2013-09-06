CREATE PROCEDURE [payroll].[sp_Insert_Parameters_Related]
@ParameterId as int
AS

DECLARE @ParamID as int,
	    @EmployeeID as int,
	    @Count as int

DECLARE Parameter_Related_Cursor CURSOR FOR 

SELECT hrm.employee.employee_id FROM hrm.employee

OPEN Parameter_Related_Cursor

FETCH NEXT FROM Parameter_Related_Cursor
INTO @EmployeeID

WHILE @@FETCH_STATUS=0

BEGIN 

	SELECT @Count = count(*) FROM payroll_parameter_setting
	WHERE payroll_parameter_setting.employee_id = @EmployeeId AND payroll_parameter_setting.param_id = @ParameterId
	IF(@Count = 0)
		BEGIN
			INSERT INTO payroll_parameter_setting (employee_id,param_id,is_active)
			VALUES (@EmployeeID, @ParameterId,0)
		END
	
	SELECT @Count = count(*) FROM payroll_current
	WHERE payroll_current.employee_id = @EmployeeID AND payroll_current.param_id = @ParameterId
	
	IF(@Count =0)
	BEGIN
		INSERT INTO payroll_current (param_id,employee_id,hrs,amount,isapprove,istransfer)
		VALUES (@ParameterId,@EmployeeID,0,0,0,0)
	END
	
	FETCH NEXT FROM Parameter_Related_Cursor
	INTO @EmployeeID
END 

CLOSE Parameter_Related_Cursor
DEALLOCATE Parameter_Related_Cursor