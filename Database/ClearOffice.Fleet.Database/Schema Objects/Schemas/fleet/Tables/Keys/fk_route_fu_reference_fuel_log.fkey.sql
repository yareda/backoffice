ALTER TABLE [fleet].[route_fuel_log]
    ADD CONSTRAINT [fk_route_fu_reference_fuel_log] FOREIGN KEY ([fuel_log_id]) REFERENCES [fleet].[fuel_log] ([fuel_log_id]) ON DELETE CASCADE ON UPDATE NO ACTION;

