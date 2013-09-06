CREATE PROCEDURE [payroll].[sp_Set_Payroll_Information]
(@State as int)
AS 

DECLARE @count as int

SELECT @count = count(payroll_information.status) FROM payroll_information

BEGIN 
	if @count >0
		UPDATE payroll_information 
		SET payroll_information.status = @State;
	else 
		INSERT INTO payroll_information (payroll_information.status) VALUES (@State)
END