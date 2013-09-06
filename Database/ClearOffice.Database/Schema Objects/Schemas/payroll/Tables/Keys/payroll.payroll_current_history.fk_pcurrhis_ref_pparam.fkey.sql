ALTER TABLE [payroll].[payroll_current_history]
    ADD CONSTRAINT [fk_pcurrhis_ref_pparam] FOREIGN KEY ([param_id]) REFERENCES [payroll].[payroll_parameter] ([param_id]) ON DELETE NO ACTION ON UPDATE NO ACTION;

