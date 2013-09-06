ALTER TABLE [fleet].[maintanance]
    ADD CONSTRAINT [FK_maintanance_vehicle] FOREIGN KEY ([vehicle_id]) REFERENCES [fleet].[vehicle] ([vehicle_id]) ON DELETE NO ACTION ON UPDATE NO ACTION;

