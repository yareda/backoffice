ALTER TABLE [stock].[receiving]
    ADD CONSTRAINT [fk_receivin_reference_warehous] FOREIGN KEY ([warehouse_id]) REFERENCES [stock].[warehouse] ([warehouse_id]) ON DELETE NO ACTION ON UPDATE NO ACTION;

