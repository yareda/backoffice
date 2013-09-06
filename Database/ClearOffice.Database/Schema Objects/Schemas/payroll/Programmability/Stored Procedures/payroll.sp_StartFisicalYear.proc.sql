CREATE PROCEDURE [payroll].[sp_StartFisicalYear]

AS 

DECLARE @EmployeeId int,
		@YearCount int,
		@Managment bit,
		@CurrentDays decimal(18,2),
		@AccruedDays decimal(18,2),
		@HireDate datetime, 
		@Diff int,
		@NewVal decimal(18,2),
		@Max int, @Min int, @DiffVal int
		
DECLARE FisicalYearCursor CURSOR FOR

SELECT employee.employee_id,employee.hire_date,employee.is_managment, employee.accrued_leave,
	   employee.current_leave_days,employee.year_count
FROM employee WHERE employee.deleted = 0 

OPEN FisicalYearCursor

FETCH NEXT FROM FisicalYearCursor
INTO @EmployeeId,@HireDate,@Managment,@AccruedDays,@CurrentDays,@YearCount

WHILE @@FETCH_STATUS =0 

BEGIN
	SET @Diff = DATEDIFF(YEAR,@HireDate,GETDATE())
	
	IF(@Managment = 1)
		BEGIN
			SELECT @Max = max_managment FROM leave_setting
			SELECT @Min = initial_mng FROM leave_setting
			
			SET @DiffVal = @Max - @Min
			
			IF(@YearCount =1)
				BEGIN
					IF(@Diff < @DiffVal)
						BEGIN
							SET @NewVal = @CurrentDays + 21 + @Diff
							UPDATE employee
							SET current_leave_days = @NewVal, year_count = 2
							WHERE employee.employee_id = @EmployeeId
						END
					ELSE IF(@Diff = 0)
						BEGIN
							SET @NewVal = 21
							
							UPDATE employee
							SET current_leave_days = @NewVal, year_count = 2
							WHERE employee.employee_id = @EmployeeId
						END
					ELSE
						BEGIN
							SET @NewVal = @CurrentDays + 30
							
							UPDATE employee
							SET current_leave_days = @NewVal, year_count = 2
							WHERE employee.employee_id = @EmployeeId
						END
				END
			ELSE
				BEGIN
					IF(@Diff < @DiffVal)
						BEGIN
							SET @NewVal = 21 + @Diff
							
							UPDATE employee
							SET current_leave_days = @NewVal, year_count = 2
							WHERE employee.employee_id = @EmployeeId
						END
					ELSE IF(@Diff = 0)
						BEGIN
							SET @NewVal = 21
							UPDATE employee
							SET current_leave_days = @NewVal, year_count = 2
							WHERE employee.employee_id = @EmployeeId
						END
					ELSE
						BEGIN
							SET @NewVal = 30
							UPDATE employee
							SET current_leave_days = @NewVal, year_count = 2
							WHERE employee.employee_id = @EmployeeId
						END
				END
		END
	ELSE
		BEGIN
			SELECT @Max = max_none_mng FROM leave_setting
			SELECT @Min = initial_none_mng FROM leave_setting
			
			SET @DiffVal = @Max - @Min
			
			IF(@YearCount =1)
				BEGIN
					IF(@Diff < @DiffVal)
						BEGIN
							SET @NewVal = @CurrentDays + 18 + @Diff
							UPDATE employee
							SET current_leave_days = @NewVal, year_count = 2
							WHERE employee.employee_id = @EmployeeId
						END
					ELSE IF(@Diff = 0)
						BEGIN
							SET @NewVal = 18
							
							UPDATE employee
							SET current_leave_days = @NewVal, year_count = 2
							WHERE employee.employee_id = @EmployeeId
						END
					ELSE
						BEGIN
							SET @NewVal = @CurrentDays + 26
							
							UPDATE employee
							SET current_leave_days = @NewVal, year_count = 2
							WHERE employee.employee_id = @EmployeeId
						END
				END
			ELSE
				BEGIN
					IF(@Diff < @DiffVal)
						BEGIN
							SET @NewVal = 18 + @Diff
							
							UPDATE employee
							SET current_leave_days = @NewVal, year_count = 2
							WHERE employee.employee_id = @EmployeeId
						END
					ELSE IF(@Diff = 0)
						BEGIN
							SET @NewVal = 18
							UPDATE employee
							SET current_leave_days = @NewVal, year_count = 2
							WHERE employee.employee_id = @EmployeeId
						END
					ELSE
						BEGIN
							SET @NewVal = 26
							UPDATE employee
							SET current_leave_days = @NewVal, year_count = 2
							WHERE employee.employee_id = @EmployeeId
						END
				END
		END
	
	FETCH NEXT FROM FisicalYearCursor
	INTO @EmployeeId,@HireDate,@Managment,@AccruedDays,@CurrentDays,@YearCount
END

CLOSE FisicalYearCursor
DEALLOCATE FisicalYearCursor