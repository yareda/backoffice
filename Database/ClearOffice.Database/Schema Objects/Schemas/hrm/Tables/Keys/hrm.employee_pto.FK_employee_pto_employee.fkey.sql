ALTER TABLE [hrm].[employee_pto]
    ADD CONSTRAINT [FK_employee_pto_employee] FOREIGN KEY ([employee_id]) REFERENCES [hrm].[employee] ([employee_id]) ON DELETE CASCADE ON UPDATE NO ACTION;

