CREATE PROCEDURE [payroll].[sp_Get_Transfer_list_value]
(
	@EmployeeId as int,
	@ParamId as int
)

AS 

SELECT * FROM vw_transfer_list
WHERE payroll.vw_transfer_list.employee_id = @EmployeeId AND payroll.vw_transfer_list.param_id = @ParamId