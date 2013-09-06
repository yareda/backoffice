ALTER TABLE [hrm].[person]
    ADD CONSTRAINT [fk_person_reference_religion] FOREIGN KEY ([religion_id]) REFERENCES [hrm].[religion] ([religion_id]) ON DELETE NO ACTION ON UPDATE NO ACTION;

