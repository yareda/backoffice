ALTER TABLE [hrm].[contact_address]
    ADD CONSTRAINT [fk_contact__reference_person] FOREIGN KEY ([person_id]) REFERENCES [hrm].[person] ([person_id]) ON DELETE NO ACTION ON UPDATE NO ACTION;

