ALTER TABLE [payroll].[payroll_parameter_setting]
    ADD CONSTRAINT [fk_pparam_sett_ref_pparam] FOREIGN KEY ([param_id]) REFERENCES [payroll].[payroll_parameter] ([param_id]) ON DELETE NO ACTION ON UPDATE NO ACTION;

