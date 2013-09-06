ALTER TABLE [payroll].[payroll_parameter]
    ADD CONSTRAINT [fk_pparam_ref_pparamtype] FOREIGN KEY ([type_id]) REFERENCES [payroll].[payroll_parameter_type] ([type_id]) ON DELETE NO ACTION ON UPDATE NO ACTION;


GO
ALTER TABLE [payroll].[payroll_parameter] NOCHECK CONSTRAINT [fk_pparam_ref_pparamtype];

