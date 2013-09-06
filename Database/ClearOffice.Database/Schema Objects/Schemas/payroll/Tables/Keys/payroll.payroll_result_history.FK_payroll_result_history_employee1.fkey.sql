ALTER TABLE [payroll].[payroll_result_history]
    ADD CONSTRAINT [FK_payroll_result_history_employee1] FOREIGN KEY ([employee_id]) REFERENCES [hrm].[employee] ([employee_id]) ON DELETE NO ACTION ON UPDATE NO ACTION;

