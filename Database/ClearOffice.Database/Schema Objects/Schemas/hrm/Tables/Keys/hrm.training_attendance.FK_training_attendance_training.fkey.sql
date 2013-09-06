ALTER TABLE [hrm].[training_attendance]
    ADD CONSTRAINT [FK_training_attendance_training] FOREIGN KEY ([training_id]) REFERENCES [hrm].[training] ([training_id]) ON DELETE CASCADE ON UPDATE NO ACTION;



