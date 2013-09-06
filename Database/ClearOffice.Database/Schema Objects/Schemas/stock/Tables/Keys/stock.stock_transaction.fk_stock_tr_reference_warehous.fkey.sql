ALTER TABLE [stock].[stock_transaction]
    ADD CONSTRAINT [fk_stock_tr_reference_warehous] FOREIGN KEY ([warehouse_id]) REFERENCES [stock].[warehouse] ([warehouse_id]) ON DELETE NO ACTION ON UPDATE NO ACTION;

