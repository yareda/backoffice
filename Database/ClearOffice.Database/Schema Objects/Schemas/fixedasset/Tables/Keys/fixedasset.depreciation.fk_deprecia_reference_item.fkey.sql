ALTER TABLE [fixedasset].[depreciation]
    ADD CONSTRAINT [fk_deprecia_reference_item] FOREIGN KEY ([asset_id]) REFERENCES [fixedasset].[asset] ([asset_id]) ON DELETE CASCADE ON UPDATE NO ACTION;

