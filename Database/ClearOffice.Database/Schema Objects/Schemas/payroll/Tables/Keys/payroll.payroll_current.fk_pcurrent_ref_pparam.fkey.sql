ALTER TABLE [payroll].[payroll_current]
    ADD CONSTRAINT [fk_pcurrent_ref_pparam] FOREIGN KEY ([param_id]) REFERENCES [payroll].[payroll_parameter] ([param_id]) ON DELETE NO ACTION ON UPDATE NO ACTION;

