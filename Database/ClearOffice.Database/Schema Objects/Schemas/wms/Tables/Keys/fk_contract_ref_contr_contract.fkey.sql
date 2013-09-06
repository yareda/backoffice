ALTER TABLE [wms].[contract_renewal]
    ADD CONSTRAINT [fk_contract_ref_contr_contract] FOREIGN KEY ([contract_id]) REFERENCES [wms].[contract] ([contract_id]) ON DELETE CASCADE ON UPDATE CASCADE;



