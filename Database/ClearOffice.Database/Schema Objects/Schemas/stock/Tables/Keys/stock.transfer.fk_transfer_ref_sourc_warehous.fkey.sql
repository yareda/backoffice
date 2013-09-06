ALTER TABLE [stock].[transfer]
    ADD CONSTRAINT [fk_transfer_ref_sourc_warehous] FOREIGN KEY ([warehouse_from]) REFERENCES [stock].[warehouse] ([warehouse_id]) ON DELETE NO ACTION ON UPDATE NO ACTION;

