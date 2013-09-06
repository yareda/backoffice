CREATE PROCEDURE [payroll].[sp_Insert_Denomination] AS

DECLARE @EmployeeID int,
	    @NetPay as money

DELETE FROM payroll_denomination

DECLARE Denom_Cursor CURSOR FOR

SELECT  payroll_employee_structure.employee_id, payroll_result.netpay FROM payroll_employee_structure
INNER JOIN payroll_result ON payroll_employee_structure.employee_id = payroll_result.employee_id

OPEN Denom_Cursor
FETCH NEXT FROM Denom_Cursor
Into @EmployeeID,@NetPay

While @@Fetch_Status=0
Begin
   Insert into payroll_denomination(employee_id,net_pay)
   values(@EmployeeID,@NetPay)

   FETCH NEXT FROM Denom_Cursor
   Into @EmployeeID,@NetPay

End

close Denom_Cursor
Deallocate Denom_Cursor