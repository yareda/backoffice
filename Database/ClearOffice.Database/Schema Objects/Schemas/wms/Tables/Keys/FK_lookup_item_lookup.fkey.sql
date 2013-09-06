ALTER TABLE [wms].[lookup_item]
    ADD CONSTRAINT [FK_lookup_item_lookup] FOREIGN KEY ([lookup_id]) REFERENCES [wms].[lookup] ([lookup_id]) ON DELETE NO ACTION ON UPDATE NO ACTION;

