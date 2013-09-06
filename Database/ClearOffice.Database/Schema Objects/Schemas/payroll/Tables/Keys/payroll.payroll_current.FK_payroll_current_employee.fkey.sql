ALTER TABLE [payroll].[payroll_current]
    ADD CONSTRAINT [FK_payroll_current_employee] FOREIGN KEY ([employee_id]) REFERENCES [hrm].[employee] ([employee_id]) ON DELETE NO ACTION ON UPDATE NO ACTION;

