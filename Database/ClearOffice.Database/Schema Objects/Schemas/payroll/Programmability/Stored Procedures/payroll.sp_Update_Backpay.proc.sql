CREATE PROCEDURE [payroll].[sp_Update_Backpay]
 (
	@EmployeeId as int,
	@Backpay as decimal(18,2)
 )
 
 AS 
 
 DECLARE @Total as decimal(18,2)
 
 SELECT @Total = employee.back_pay FROM payroll.employee
 
 SET @Total = @Total + @Backpay
 
 UPDATE employee
 SET back_pay = @Total
 WHERE employee.employee_id = @EmployeeId