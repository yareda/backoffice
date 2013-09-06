ALTER TABLE [payroll].[payroll_parameter]
    ADD CONSTRAINT [fk_payroll_parameter_reference_parameter_group] FOREIGN KEY ([parameter_group_id]) REFERENCES [payroll].[payroll_parameter_group] ([parameter_group_id]) ON DELETE NO ACTION ON UPDATE NO ACTION;


GO
ALTER TABLE [payroll].[payroll_parameter] NOCHECK CONSTRAINT [fk_payroll_parameter_reference_parameter_group];

