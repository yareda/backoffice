ALTER TABLE [fixedasset].[disposal]
    ADD CONSTRAINT [fk_disposal_reference_item] FOREIGN KEY ([asset_id]) REFERENCES [fixedasset].[asset] ([asset_id]) ON DELETE CASCADE ON UPDATE NO ACTION;

