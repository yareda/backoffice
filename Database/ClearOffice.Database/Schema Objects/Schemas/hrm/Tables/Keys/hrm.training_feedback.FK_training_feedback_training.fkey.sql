ALTER TABLE [hrm].[training_feedback]
    ADD CONSTRAINT [FK_training_feedback_training] FOREIGN KEY ([training_id]) REFERENCES [hrm].[training] ([training_id]) ON DELETE CASCADE ON UPDATE NO ACTION;



