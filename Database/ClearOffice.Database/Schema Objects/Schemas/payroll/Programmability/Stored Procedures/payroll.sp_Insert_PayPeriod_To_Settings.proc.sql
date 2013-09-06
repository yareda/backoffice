CREATE PROCEDURE [payroll].[sp_Insert_PayPeriod_To_Settings]

@PayPeriod as datetime

 AS

 UPDATE payroll_setting
 SET pay_period = @PayPeriod