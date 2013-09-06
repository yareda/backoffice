ALTER TABLE [payroll].[payroll_parameter]
    ADD CONSTRAINT [fk_pparam_ref_pvaluetype] FOREIGN KEY ([value_type_id]) REFERENCES [payroll].[payroll_value_type] ([value_type_id]) ON DELETE NO ACTION ON UPDATE NO ACTION;


GO
ALTER TABLE [payroll].[payroll_parameter] NOCHECK CONSTRAINT [fk_pparam_ref_pvaluetype];

