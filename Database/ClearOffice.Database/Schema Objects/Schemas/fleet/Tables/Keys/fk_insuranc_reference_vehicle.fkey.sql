ALTER TABLE [fleet].[insurance_history]
    ADD CONSTRAINT [fk_insuranc_reference_vehicle] FOREIGN KEY ([vehicle_id]) REFERENCES [fleet].[vehicle] ([vehicle_id]) ON DELETE CASCADE ON UPDATE NO ACTION;







