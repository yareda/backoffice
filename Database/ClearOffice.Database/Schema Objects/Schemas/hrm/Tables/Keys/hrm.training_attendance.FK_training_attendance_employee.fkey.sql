ALTER TABLE [hrm].[training_attendance]
    ADD CONSTRAINT [FK_training_attendance_employee] FOREIGN KEY ([employee_id]) REFERENCES [hrm].[employee] ([employee_id]) ON DELETE NO ACTION ON UPDATE NO ACTION;





