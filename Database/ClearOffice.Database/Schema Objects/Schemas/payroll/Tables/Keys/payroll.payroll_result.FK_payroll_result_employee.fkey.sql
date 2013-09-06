ALTER TABLE [payroll].[payroll_result]
    ADD CONSTRAINT [FK_payroll_result_employee] FOREIGN KEY ([employee_id]) REFERENCES [hrm].[employee] ([employee_id]) ON DELETE NO ACTION ON UPDATE NO ACTION;

