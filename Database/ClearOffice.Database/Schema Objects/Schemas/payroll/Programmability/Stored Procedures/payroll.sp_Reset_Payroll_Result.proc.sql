CREATE PROCEDURE [payroll].[sp_Reset_Payroll_Result]

AS 
UPDATE payroll_result 
SET 
	[tolearnings]=0,
    [toldeductions]=0,
    [grosssalary]=0,
    [incometax]=0,
    [netpay]=0,
    [overpay]=0