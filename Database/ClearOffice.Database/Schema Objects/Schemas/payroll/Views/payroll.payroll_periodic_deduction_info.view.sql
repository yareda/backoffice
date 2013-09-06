CREATE VIEW [payroll].[payroll_periodic_deduction_info]
AS
SELECT     payroll.payroll_periodic_deduction.periodic_id, payroll.payroll_periodic_deduction.employee_id, payroll.payroll_periodic_deduction.param_id, 
                      payroll.payroll_periodic_deduction.monthly_amount, payroll.payroll_periodic_deduction.pay_period, payroll.payroll_periodic_deduction.remaining_period, 
                      payroll.payroll_periodic_deduction.initail_amount, payroll.payroll_periodic_deduction.balance, payroll.payroll_periodic_deduction.data_version, 
                      payroll.payroll_periodic_deduction.loan_id, payroll.payroll_parameter.param_name
FROM         payroll.payroll_periodic_deduction INNER JOIN
                      payroll.payroll_parameter ON payroll.payroll_periodic_deduction.param_id = payroll.payroll_parameter.param_id