ALTER TABLE [wms].[equipment_insurance]
    ADD CONSTRAINT [fk_equipmen_equi_insu_equipmen] FOREIGN KEY ([equipment_id]) REFERENCES [wms].[equipment] ([equipment_id]) ON DELETE CASCADE ON UPDATE NO ACTION;













