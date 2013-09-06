ALTER TABLE [fleet].[lookup_item]
    ADD CONSTRAINT [FK_lookup_item_lookup] FOREIGN KEY ([lookup_id]) REFERENCES [fleet].[lookup] ([lookup_id]) ON DELETE CASCADE ON UPDATE NO ACTION;

