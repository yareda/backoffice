ALTER TABLE [stock].[receiving]
    ADD CONSTRAINT [fk_receivin_reference_supplier] FOREIGN KEY ([supplier_id]) REFERENCES [stock].[supplier] ([supplier_id]) ON DELETE NO ACTION ON UPDATE NO ACTION;

