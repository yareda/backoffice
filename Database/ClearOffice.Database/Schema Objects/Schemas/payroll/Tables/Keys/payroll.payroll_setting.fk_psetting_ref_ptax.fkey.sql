ALTER TABLE [payroll].[payroll_setting]
    ADD CONSTRAINT [fk_psetting_ref_ptax] FOREIGN KEY ([tax_table_id]) REFERENCES [payroll].[payroll_tax_table] ([tax_table_id]) ON DELETE NO ACTION ON UPDATE NO ACTION;

