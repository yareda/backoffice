ALTER TABLE [fleet].[fuel_log]
    ADD CONSTRAINT [fk_fuel_log_reference_vehicle] FOREIGN KEY ([vehicle_id]) REFERENCES [fleet].[vehicle] ([vehicle_id]) ON DELETE CASCADE ON UPDATE NO ACTION;

