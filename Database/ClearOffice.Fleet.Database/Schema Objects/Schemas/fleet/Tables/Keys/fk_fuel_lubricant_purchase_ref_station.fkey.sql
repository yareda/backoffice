ALTER TABLE [fleet].[fuel_lubricant_purchase]
    ADD CONSTRAINT [fk_fuel_lubricant_purchase_ref_station] FOREIGN KEY ([fuel_station_id]) REFERENCES [fleet].[fuel_station] ([fuel_station_id]) ON DELETE NO ACTION ON UPDATE NO ACTION;

