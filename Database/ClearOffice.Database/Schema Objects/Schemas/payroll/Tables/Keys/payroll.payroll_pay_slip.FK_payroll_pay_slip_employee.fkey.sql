ALTER TABLE [payroll].[payroll_pay_slip]
    ADD CONSTRAINT [FK_payroll_pay_slip_employee] FOREIGN KEY ([employee_id]) REFERENCES [hrm].[employee] ([employee_id]) ON DELETE NO ACTION ON UPDATE NO ACTION;

