ALTER TABLE [hrm].[job_function]
    ADD CONSTRAINT [fk_job_func_reference_job] FOREIGN KEY ([job_id]) REFERENCES [hrm].[job] ([job_id]) ON DELETE CASCADE ON UPDATE NO ACTION;



