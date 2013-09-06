ALTER TABLE [payroll].[payroll_periodic_deduction]
    ADD CONSTRAINT [FK_payroll_periodic_deduction_employee] FOREIGN KEY ([employee_id]) REFERENCES [hrm].[employee] ([employee_id]) ON DELETE NO ACTION ON UPDATE NO ACTION;

