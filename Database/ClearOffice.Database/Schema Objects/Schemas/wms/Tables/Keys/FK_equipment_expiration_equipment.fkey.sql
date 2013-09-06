ALTER TABLE [wms].[equipment_expiration]
    ADD CONSTRAINT [FK_equipment_expiration_equipment] FOREIGN KEY ([equipment_id]) REFERENCES [wms].[equipment] ([equipment_id]) ON DELETE CASCADE ON UPDATE CASCADE;











