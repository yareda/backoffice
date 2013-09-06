CREATE PROCEDURE [payroll].[sp_Insert_Payroll_Result]
(
	@EmployeeID as int,
	@BasicSalary as decimal
)

 AS
 DECLARE @Count as int
 SELECT @Count = employee_id FROM payroll_result WHERE employee_id = @EmployeeID
 
 IF @Count >0
 BEGIN 
	UPDATE payroll_result
	SET employee_id = @EmployeeID,
		 basic_salary = @BasicSalary
	WHERE employee_id = @EmployeeID
 END
 ELSE 
 BEGIN
	INSERT INTO payroll_result
	(
		employee_id,
		basic_salary
	)
	VALUES 
	(
		@EmployeeID,
		@BasicSalary
	)
 END