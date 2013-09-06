ALTER TABLE [wms].[equipment_attachment]
    ADD CONSTRAINT [FK_equipment_attachment_equipment] FOREIGN KEY ([equipment_id]) REFERENCES [wms].[equipment] ([equipment_id]) ON DELETE CASCADE ON UPDATE CASCADE;

