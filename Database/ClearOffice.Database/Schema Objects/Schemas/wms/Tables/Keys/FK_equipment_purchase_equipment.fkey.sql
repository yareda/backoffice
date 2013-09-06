ALTER TABLE [wms].[equipment_purchase]
    ADD CONSTRAINT [FK_equipment_purchase_equipment] FOREIGN KEY ([equipment_id]) REFERENCES [wms].[equipment] ([equipment_id]) ON DELETE CASCADE ON UPDATE CASCADE;











