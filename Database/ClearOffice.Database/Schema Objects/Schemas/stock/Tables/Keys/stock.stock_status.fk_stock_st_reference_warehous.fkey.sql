ALTER TABLE [stock].[stock_status]
    ADD CONSTRAINT [fk_stock_st_reference_warehous] FOREIGN KEY ([warehouse_id]) REFERENCES [stock].[warehouse] ([warehouse_id]) ON DELETE NO ACTION ON UPDATE NO ACTION;

