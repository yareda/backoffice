ALTER TABLE [fleet].[fuel_lubricant_purchase]
    ADD CONSTRAINT [FK_fuel_lubricant_purchase_vehicle] FOREIGN KEY ([vehicle_id]) REFERENCES [fleet].[vehicle] ([vehicle_id]) ON DELETE NO ACTION ON UPDATE NO ACTION;

