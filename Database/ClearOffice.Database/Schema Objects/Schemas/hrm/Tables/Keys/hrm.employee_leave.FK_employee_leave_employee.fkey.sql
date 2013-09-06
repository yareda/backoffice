ALTER TABLE [hrm].[employee_leave]
    ADD CONSTRAINT [FK_employee_leave_employee] FOREIGN KEY ([employee_id]) REFERENCES [hrm].[employee] ([employee_id]) ON DELETE CASCADE ON UPDATE NO ACTION;

