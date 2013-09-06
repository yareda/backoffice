ALTER TABLE [hrm].[person]
    ADD CONSTRAINT [fk_person_reference_ethnicit] FOREIGN KEY ([ethnicity_id]) REFERENCES [hrm].[ethnicity] ([ethnicity_id]) ON DELETE NO ACTION ON UPDATE NO ACTION;

