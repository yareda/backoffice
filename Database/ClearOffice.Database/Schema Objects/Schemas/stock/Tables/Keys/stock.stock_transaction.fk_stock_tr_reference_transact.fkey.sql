ALTER TABLE [stock].[stock_transaction]
    ADD CONSTRAINT [fk_stock_tr_reference_transact] FOREIGN KEY ([transaction_type_id]) REFERENCES [stock].[transaction_type] ([transaction_type_id]) ON DELETE NO ACTION ON UPDATE NO ACTION;

