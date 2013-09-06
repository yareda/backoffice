ALTER TABLE [fleet].[vehicle_tire]
    ADD CONSTRAINT [FK_vehicle_tire_tire] FOREIGN KEY ([tire_id]) REFERENCES [fleet].[tire] ([tire_id]) ON DELETE NO ACTION ON UPDATE NO ACTION;

