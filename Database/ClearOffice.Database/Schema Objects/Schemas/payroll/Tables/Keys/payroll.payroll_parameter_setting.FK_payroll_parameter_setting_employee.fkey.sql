ALTER TABLE [payroll].[payroll_parameter_setting]
    ADD CONSTRAINT [FK_payroll_parameter_setting_employee] FOREIGN KEY ([employee_id]) REFERENCES [hrm].[employee] ([employee_id]) ON DELETE NO ACTION ON UPDATE NO ACTION;

