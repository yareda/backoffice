ALTER TABLE [hrm].[person]
    ADD CONSTRAINT [fk_person_reference_national] FOREIGN KEY ([nationality_id]) REFERENCES [hrm].[nationality] ([nationality_id]) ON DELETE NO ACTION ON UPDATE NO ACTION;

