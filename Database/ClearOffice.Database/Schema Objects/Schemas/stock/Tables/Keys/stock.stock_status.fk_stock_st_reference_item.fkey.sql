ALTER TABLE [stock].[stock_status]
    ADD CONSTRAINT [fk_stock_st_reference_item] FOREIGN KEY ([item_id]) REFERENCES [stock].[item] ([item_id]) ON DELETE NO ACTION ON UPDATE NO ACTION;

