ALTER TABLE [hrm].[job_skill]
    ADD CONSTRAINT [fk_job_skil_reference_job_skil] FOREIGN KEY ([skill_id]) REFERENCES [hrm].[job_skill_type] ([skill_id]) ON DELETE NO ACTION ON UPDATE NO ACTION;

