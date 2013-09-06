CREATE VIEW [payroll].[payroll_tax_table_info]
AS
SELECT     tax_table_id, govno, dec_date, min_sal, max_sal, tax_percent, deduction, data_version
FROM         payroll.payroll_tax_table