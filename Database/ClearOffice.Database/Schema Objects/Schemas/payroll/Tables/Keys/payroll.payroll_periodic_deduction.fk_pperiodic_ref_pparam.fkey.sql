ALTER TABLE [payroll].[payroll_periodic_deduction]
    ADD CONSTRAINT [fk_pperiodic_ref_pparam] FOREIGN KEY ([param_id]) REFERENCES [payroll].[payroll_parameter] ([param_id]) ON DELETE NO ACTION ON UPDATE NO ACTION;

