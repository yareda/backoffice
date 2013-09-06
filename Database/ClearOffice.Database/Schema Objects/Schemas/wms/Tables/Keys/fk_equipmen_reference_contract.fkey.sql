ALTER TABLE [wms].[equipment]
    ADD CONSTRAINT [fk_equipmen_reference_contract] FOREIGN KEY ([contract_id]) REFERENCES [wms].[contract] ([contract_id]) ON DELETE CASCADE ON UPDATE CASCADE;





