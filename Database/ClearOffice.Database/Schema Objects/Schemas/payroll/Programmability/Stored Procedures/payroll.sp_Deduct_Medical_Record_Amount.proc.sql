CREATE PROCEDURE [payroll].[sp_Deduct_Medical_Record_Amount]
  (
	@EmployeeId as int,
	@Amount as decimal(18,2)
  )
  
  AS 
  
  DECLARE @Deposit as decimal(18,2)
  
  SELECT DISTINCT @Deposit =  employee.medical_deposit FROM employee 
  WHERE employee.employee_id = @EmployeeId
  
  SET @Deposit = @Deposit - @Amount
  
  UPDATE employee
  SET medical_deposit = @Deposit
  WHERE employee_id = @EmployeeId