ALTER TABLE [payroll].[payroll_history]
    ADD CONSTRAINT [FK_payroll_history_employee] FOREIGN KEY ([employee_id]) REFERENCES [hrm].[employee] ([employee_id]) ON DELETE NO ACTION ON UPDATE NO ACTION;

