ALTER TABLE [hrm].[language_skill]
    ADD CONSTRAINT [fk_language_reference_language] FOREIGN KEY ([language_id]) REFERENCES [hrm].[language] ([language_id]) ON DELETE NO ACTION ON UPDATE NO ACTION;

