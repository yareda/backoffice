ALTER TABLE [wms].[miscellaneous_items]
    ADD CONSTRAINT [FK_miscellaneous_items_invoice] FOREIGN KEY ([invoice_id]) REFERENCES [wms].[invoice] ([id]) ON DELETE CASCADE ON UPDATE CASCADE;

