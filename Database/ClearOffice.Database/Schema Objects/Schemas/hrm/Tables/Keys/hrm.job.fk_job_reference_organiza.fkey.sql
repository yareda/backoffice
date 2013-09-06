ALTER TABLE [hrm].[job]
    ADD CONSTRAINT [fk_job_reference_organiza] FOREIGN KEY ([node_id]) REFERENCES [hrm].[organization] ([node_id]) ON DELETE NO ACTION ON UPDATE NO ACTION;

