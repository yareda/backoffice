ALTER TABLE [fleet].[maintenance_expense]
    ADD CONSTRAINT [fk_maintena_reference_expense] FOREIGN KEY ([expense_id]) REFERENCES [fleet].[expense] ([expense_id]) ON DELETE CASCADE ON UPDATE NO ACTION;

