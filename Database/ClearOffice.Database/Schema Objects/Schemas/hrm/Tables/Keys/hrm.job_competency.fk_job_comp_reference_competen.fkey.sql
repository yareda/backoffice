ALTER TABLE [hrm].[job_competency]
    ADD CONSTRAINT [fk_job_comp_reference_competen] FOREIGN KEY ([competency_type_id]) REFERENCES [hrm].[competency_type] ([competency_type_id]) ON DELETE NO ACTION ON UPDATE NO ACTION;

