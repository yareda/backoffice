ALTER TABLE [hrm].[employee_leave]
    ADD CONSTRAINT [FK_employee_leave_leave_type] FOREIGN KEY ([leave_type_id]) REFERENCES [hrm].[leave_type] ([leave_type_id]) ON DELETE NO ACTION ON UPDATE NO ACTION;

