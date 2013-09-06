CREATE VIEW [payroll].[qry_get_pay_periods]
AS
SELECT DISTINCT pay_period, result_history_id
FROM         payroll.payroll_result_history