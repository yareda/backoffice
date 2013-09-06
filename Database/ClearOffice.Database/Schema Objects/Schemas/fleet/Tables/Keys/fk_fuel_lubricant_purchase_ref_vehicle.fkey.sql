ALTER TABLE [fleet].[fuel_lubricant_purchase]
    ADD CONSTRAINT [fk_fuel_lubricant_purchase_ref_vehicle] FOREIGN KEY ([vehicle_id]) REFERENCES [fleet].[vehicle] ([vehicle_id]) ON DELETE NO ACTION ON UPDATE NO ACTION;







