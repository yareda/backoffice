ALTER TABLE [fixedasset].[custodian_asset]
    ADD CONSTRAINT [fk_assign_c_reference_item] FOREIGN KEY ([asset_id]) REFERENCES [fixedasset].[asset] ([asset_id]) ON DELETE CASCADE ON UPDATE NO ACTION;

