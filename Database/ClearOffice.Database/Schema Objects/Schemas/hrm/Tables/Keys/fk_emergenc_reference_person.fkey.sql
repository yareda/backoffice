ALTER TABLE [hrm].[emergency_contact]
    ADD CONSTRAINT [fk_emergenc_reference_person] FOREIGN KEY ([person_id]) REFERENCES [hrm].[person] ([person_id]) ON DELETE NO ACTION ON UPDATE NO ACTION;

