ALTER TABLE [fleet].[route_expense]
    ADD CONSTRAINT [fk_route_ex_reference_expense] FOREIGN KEY ([expense_id]) REFERENCES [fleet].[expense] ([expense_id]) ON DELETE CASCADE ON UPDATE NO ACTION;

