ALTER TABLE [fixedasset].[adjustment]
    ADD CONSTRAINT [fk_adjustme_reference_item] FOREIGN KEY ([asset_id]) REFERENCES [fixedasset].[asset] ([asset_id]) ON DELETE CASCADE ON UPDATE NO ACTION;

