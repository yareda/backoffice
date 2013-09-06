ALTER TABLE [fleet].[vehicle_tire]
    ADD CONSTRAINT [fk_tire_reference_vehicle] FOREIGN KEY ([vehicle_id]) REFERENCES [fleet].[vehicle] ([vehicle_id]) ON DELETE CASCADE ON UPDATE NO ACTION;

