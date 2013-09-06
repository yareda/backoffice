ALTER TABLE [hrm].[training]
    ADD CONSTRAINT [FK_training_training_request] FOREIGN KEY ([training_request_id]) REFERENCES [hrm].[training_request] ([training_request_id]) ON DELETE CASCADE ON UPDATE NO ACTION;



