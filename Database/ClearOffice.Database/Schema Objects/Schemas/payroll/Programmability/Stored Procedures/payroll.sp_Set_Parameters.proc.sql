CREATE PROCEDURE [payroll].[sp_Set_Parameters]
(
@EmployeeID as int,
@ParamID as int,
@IsActive as bit

)

 AS

 UPDATE Payroll_Parameter_Setting
 SET is_active = @IsActive 
 
 WHERE param_id = @ParamID AND employee_id = @EmployeeID