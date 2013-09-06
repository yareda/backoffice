ALTER TABLE [wms].[equipment]
    ADD CONSTRAINT [FK_equipment_contract_renewal] FOREIGN KEY ([renewal_id]) REFERENCES [wms].[contract_renewal] ([renewal_id]) ON DELETE NO ACTION ON UPDATE NO ACTION;

