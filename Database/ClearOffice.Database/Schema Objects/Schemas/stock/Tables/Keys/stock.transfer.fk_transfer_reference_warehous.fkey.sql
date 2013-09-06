ALTER TABLE [stock].[transfer]
    ADD CONSTRAINT [fk_transfer_reference_warehous] FOREIGN KEY ([warehouse_to]) REFERENCES [stock].[warehouse] ([warehouse_id]) ON DELETE NO ACTION ON UPDATE NO ACTION;

