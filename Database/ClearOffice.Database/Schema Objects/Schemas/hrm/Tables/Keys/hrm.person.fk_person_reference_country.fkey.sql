ALTER TABLE [hrm].[person]
    ADD CONSTRAINT [fk_person_reference_country] FOREIGN KEY ([country_id]) REFERENCES [hrm].[country] ([country_id]) ON DELETE NO ACTION ON UPDATE NO ACTION;

