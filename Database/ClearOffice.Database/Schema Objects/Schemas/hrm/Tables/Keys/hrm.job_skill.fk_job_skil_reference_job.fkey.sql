ALTER TABLE [hrm].[job_skill]
    ADD CONSTRAINT [fk_job_skil_reference_job] FOREIGN KEY ([job_id]) REFERENCES [hrm].[job] ([job_id]) ON DELETE CASCADE ON UPDATE NO ACTION;



