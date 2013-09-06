ALTER TABLE [fixedasset].[custodian_asset]
    ADD CONSTRAINT [fk_assign_custodian_custodian] FOREIGN KEY ([custodian_id]) REFERENCES [fixedasset].[custodian] ([custodian_id]) ON DELETE CASCADE ON UPDATE NO ACTION;

