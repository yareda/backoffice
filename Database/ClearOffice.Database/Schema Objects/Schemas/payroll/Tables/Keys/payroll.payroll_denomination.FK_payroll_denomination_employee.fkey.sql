ALTER TABLE [payroll].[payroll_denomination]
    ADD CONSTRAINT [FK_payroll_denomination_employee] FOREIGN KEY ([employee_id]) REFERENCES [hrm].[employee] ([employee_id]) ON DELETE NO ACTION ON UPDATE NO ACTION;

