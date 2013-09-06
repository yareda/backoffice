ALTER TABLE [hrm].[employee_pto_status]
    ADD CONSTRAINT [FK_employee_pto_status_employee] FOREIGN KEY ([employee_id]) REFERENCES [hrm].[employee] ([employee_id]) ON DELETE CASCADE ON UPDATE NO ACTION;

