CREATE PROCEDURE [payroll].[sp_Insert_Record_ToDenomination]

AS 

DELETE FROM payroll_denomination

DECLARE @EmployeeId as int,
		@NetPay as decimal(18,2)
		
DECLARE Denom_Cursor CURSOR FOR 
SELECT payroll_result.employee_id, payroll_result.netpay
FROM payroll_result 
WHERE payroll_result.netpay >0

OPEN Denom_Cursor 
FETCH NEXT FROM Denom_Cursor 
INTO @EmployeeId,@NetPay

WHILE @@FETCH_STATUS =0
BEGIN 
	INSERT INTO payroll_denomination (payroll_denomination.employee_id,payroll_denomination.net_pay) VALUES 
			    (@EmployeeId,@NetPay)
	FETCH NEXT FROM Denom_Cursor
	INTO @EmployeeId,@NetPay
END