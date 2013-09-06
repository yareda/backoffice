ALTER TABLE [hrm].[training_request]
    ADD CONSTRAINT [FK_training_request_training_category] FOREIGN KEY ([training_category_id]) REFERENCES [hrm].[training_category] ([training_category_id]) ON DELETE NO ACTION ON UPDATE NO ACTION;

