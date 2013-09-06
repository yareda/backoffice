ALTER TABLE [stock].[stock_transaction]
    ADD CONSTRAINT [fk_stock_tr_reference_item] FOREIGN KEY ([item_id]) REFERENCES [stock].[item] ([item_id]) ON DELETE NO ACTION ON UPDATE NO ACTION;

