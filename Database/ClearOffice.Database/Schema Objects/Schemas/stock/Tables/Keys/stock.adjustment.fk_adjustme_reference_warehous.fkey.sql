ALTER TABLE [stock].[adjustment]
    ADD CONSTRAINT [fk_adjustme_reference_warehous] FOREIGN KEY ([warehouse_id]) REFERENCES [stock].[warehouse] ([warehouse_id]) ON DELETE NO ACTION ON UPDATE NO ACTION;

