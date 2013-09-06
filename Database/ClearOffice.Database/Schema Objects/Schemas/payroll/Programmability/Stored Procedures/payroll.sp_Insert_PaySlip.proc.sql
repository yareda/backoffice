CREATE PROCEDURE [payroll].[sp_Insert_PaySlip]
(
	@EmployeeID as int,
	@Earnings as ntext,
	@EarningsVal as ntext,
	@Deductions as ntext,
	@DeductionsVal as ntext
)

AS 

INSERT INTO payroll_pay_slip
(
	employee_id,earnings,deductions,earnvals,deducvals
)
VALUES 
(
	@EmployeeID,@Earnings,@Deductions,@EarningsVal,@DeductionsVal
)