ALTER TABLE [fleet].[fuel_lubricant_purchase]
    ADD CONSTRAINT [fk_fuel_lubricant_purchase_ref_driver] FOREIGN KEY ([driver_id]) REFERENCES [fleet].[driver] ([driver_id]) ON DELETE NO ACTION ON UPDATE NO ACTION;

