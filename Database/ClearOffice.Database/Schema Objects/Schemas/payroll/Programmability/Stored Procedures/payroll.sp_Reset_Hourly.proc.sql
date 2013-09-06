CREATE PROCEDURE [payroll].[sp_Reset_Hourly]

 AS

 UPDATE payroll_current 
 SET hrs = 0,
 amount = 0
 WHERE payroll_current.param_id IN  (SELECT payroll_parameter.param_id FROM payroll_parameter WHERE payroll_parameter.is_ot =1)