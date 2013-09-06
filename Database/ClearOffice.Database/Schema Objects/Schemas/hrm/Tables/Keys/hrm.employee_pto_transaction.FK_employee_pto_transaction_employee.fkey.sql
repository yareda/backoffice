ALTER TABLE [hrm].[employee_pto_transaction]
    ADD CONSTRAINT [FK_employee_pto_transaction_employee] FOREIGN KEY ([employee_id]) REFERENCES [hrm].[employee] ([employee_id]) ON DELETE CASCADE ON UPDATE NO ACTION;

