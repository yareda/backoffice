ALTER TABLE [hrm].[employee]
    ADD CONSTRAINT [FK_employee_job] FOREIGN KEY ([job_id]) REFERENCES [hrm].[job] ([job_id]) ON DELETE NO ACTION ON UPDATE NO ACTION;

