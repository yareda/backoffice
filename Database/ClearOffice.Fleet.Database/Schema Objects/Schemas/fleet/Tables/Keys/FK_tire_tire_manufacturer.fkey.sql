ALTER TABLE [fleet].[tire]
    ADD CONSTRAINT [FK_tire_tire_manufacturer] FOREIGN KEY ([brand]) REFERENCES [fleet].[tire_manufacturer] ([id]) ON DELETE NO ACTION ON UPDATE NO ACTION;

