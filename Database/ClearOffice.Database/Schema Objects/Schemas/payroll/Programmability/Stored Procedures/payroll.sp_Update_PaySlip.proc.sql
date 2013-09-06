CREATE PROCEDURE [payroll].[sp_Update_PaySlip]
(
	@PaySlipID as int,
	@EmployeeID as int,
	@Earnings as ntext,
	@EarningsVal as ntext,
	@Deductions as ntext,
	@DeductionsVal as ntext
)

AS 

UPDATE payroll_pay_slip
SET 
	earnings = @Earnings,
	deductions =@Deductions,
	earnvals =@EarningsVal,
	deducvals=@DeductionsVal
WHERE employee_id = @EmployeeID AND pay_slip_id = @PaySlipID