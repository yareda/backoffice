CREATE VIEW [payroll].[payroll_parameter_info]
AS
SELECT     param_id, type_id, condition_id, value_type_id, param_name, param_description, is_taxable, tax_above, param_value, rate, salary_percent, data_version, is_ot, 
                      is_other, parameter_group_id
FROM         payroll.payroll_parameter