CREATE PROCEDURE [payroll].[sp_Copy_Current_Payroll]

 AS

DECLARE @EmployeeID as nvarchar(50)
DECLARE @ParamID as int
DECLARE @Hrs as decimal(18,3)
DECLARE @Amount decimal(18,3)

if exists (select * from payroll.sysobjects where id = object_id(N'[payroll].[Copy_payroll_current]') and OBJECTPROPERTY(id, N'IsUserTable') = 1)
            drop table [payroll].[Copy_payroll_current]

CREATE TABLE [payroll].[Copy_payroll_current]
	( employee_id [int],
	  param_id [int],
	  hrs [decimal] (18,2),
	  amount [decimal] (18,2)
             )

DECLARE Copy_Current_Payroll_Cursor CURSOR FOR 

SELECT payroll_current.employee_id, payroll_current.param_id, payroll_current.hrs, payroll_current.amount FROM payroll_current

OPEN Copy_Current_Payroll_Cursor
FETCH NEXT FROM Copy_Current_Payroll_Cursor
INTO @EmployeeID, @ParamID, @Hrs, @Amount

WHILE @@Fetch_Status = 0

BEGIN
	INSERT INTO Copy_payroll_current (employee_id, param_id, hrs,amount)
	VALUES (@EmployeeID,@ParamID,@Hrs,@Amount)

	FETCH NEXT FROM Copy_Current_Payroll_Cursor
	INTO @EmployeeID, @ParamID, @Hrs, @Amount

END 

CLOSE Copy_Current_Payroll_Cursor
DEALLOCATE Copy_Current_Payroll_Cursor