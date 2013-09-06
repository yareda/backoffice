CREATE PROCEDURE [payroll].[sp_Insert_Employee_Related]

@EmployeeID as int

AS 

DECLARE @ParamID as int, @Count as int

DECLARE Employee_Related_Cursor CURSOR FOR 

SELECT param_id FROM payroll_parameter

OPEN Employee_Related_Cursor

FETCH NEXT FROM Employee_Related_Cursor
INTO @ParamID

WHILE @@FETCH_STATUS=0

BEGIN 

	SELECT @Count = count(*) FROM payroll_parameter_setting
	WHERE payroll_parameter_setting.employee_id = @EmployeeID AND payroll_parameter_setting.param_id = @ParamID
	
	IF(@Count =0)
		BEGIN
			INSERT INTO payroll_Parameter_Setting (employee_id, param_id,is_active)
			VALUES 	(@EmployeeID, @ParamID,0)	
		END
	
	SELECT @Count = count(*) FROM payroll_current
	WHERE payroll_current.employee_id = @EmployeeID AND payroll_current.param_id = @ParamID
	
	IF(@Count =0)
		BEGIN
			INSERT INTO payroll_current (param_id,employee_id,hrs,amount,isapprove,istransfer)
			VALUES (@ParamID,@EmployeeID,0,0,0,0)
		END
 
	FETCH NEXT FROM Employee_Related_Cursor
	INTO @ParamID
END 

CLOSE Employee_Related_Cursor
DEALLOCATE Employee_Related_Cursor