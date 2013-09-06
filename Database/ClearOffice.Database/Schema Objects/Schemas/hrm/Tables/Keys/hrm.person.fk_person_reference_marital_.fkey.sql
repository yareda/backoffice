ALTER TABLE [hrm].[person]
    ADD CONSTRAINT [fk_person_reference_marital_] FOREIGN KEY ([marital_status_id]) REFERENCES [hrm].[marital_status] ([marital_status_id]) ON DELETE NO ACTION ON UPDATE NO ACTION;

