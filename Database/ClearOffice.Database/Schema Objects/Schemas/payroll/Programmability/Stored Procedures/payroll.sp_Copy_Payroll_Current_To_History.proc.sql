-- =============================================
-- Author:		<Author,,Name>
-- Create date: <Create Date,,>
-- Description:	<Description,,>
-- =============================================
CREATE PROCEDURE payroll.[sp_Copy_Payroll_Current_To_History] AS

DECLARE @EmployeeID as int,
	@ParamID as int,
	@Hrs as decimal(18,2),
	@Amount as decimal(18,2),
    @PayPeriod as datetime,
    @IsApproved as bit,
    @IsTransferd as bit

DECLARE History_Cursor CURSOR FOR

SELECT payroll_current.employee_id, payroll_current.param_id,
	payroll_current.hrs,payroll_current.amount,
	payroll_setting.pay_period,payroll_current.isapprove,payroll_current.istransfer 
FROM payroll_current, payroll_setting


OPEN History_Cursor
FETCH NEXT FROM History_Cursor
Into @EmployeeID,@ParamID,@Hrs,@Amount,@PayPeriod,@IsApproved,@IsTransferd

While @@Fetch_Status=0
Begin
    Insert into payroll_history(employee_id,param_id,hrs,amount,pay_period,is_approved,is_transfer)
    values(@EmployeeID,@ParamID,@Hrs,@Amount,@PayPeriod,@IsApproved,@IsTransferd)

   FETCH NEXT FROM History_Cursor
   Into @EmployeeID,@ParamID,@Hrs,@Amount,@PayPeriod,@IsApproved,@IsTransferd

End

close History_Cursor
Deallocate History_Cursor