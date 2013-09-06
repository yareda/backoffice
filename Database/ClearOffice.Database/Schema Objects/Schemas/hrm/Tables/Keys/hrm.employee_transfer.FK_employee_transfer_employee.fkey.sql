ALTER TABLE [hrm].[employee_transfer]
    ADD CONSTRAINT [FK_employee_transfer_employee] FOREIGN KEY ([employee_id]) REFERENCES [hrm].[employee] ([employee_id]) ON DELETE NO ACTION ON UPDATE NO ACTION;

