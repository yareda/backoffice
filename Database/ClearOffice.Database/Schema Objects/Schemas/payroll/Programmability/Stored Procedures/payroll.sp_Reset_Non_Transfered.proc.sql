CREATE PROCEDURE [payroll].[sp_Reset_Non_Transfered]

 AS
 
 UPDATE payroll.payroll_current
 SET amount = 0, hrs = 0
 WHERE payroll.payroll_current.istransfer = 0 
 											 
 UPDATE payroll.payroll_parameter_setting
 SET is_active = 0
 WHERE payroll.payroll_parameter_setting.param_id NOT IN (SELECT payroll.payroll_current.param_id FROM payroll.payroll_current
													  WHERE payroll.payroll_current.istransfer = 1)