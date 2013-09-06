
CREATE PROCEDURE [payroll].[sp_Delete_PaySlip]
(
	@EmployeeId as int
)
AS
DELETE FROM payroll_pay_slip WHERE payroll_pay_slip.employee_id = @EmployeeId