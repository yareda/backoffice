ALTER TABLE [wms].[pm_service_part]
    ADD CONSTRAINT [FK_pm_service_part_pm_service] FOREIGN KEY ([service_id]) REFERENCES [wms].[pm_service] ([pm_service_id]) ON DELETE CASCADE ON UPDATE CASCADE;



