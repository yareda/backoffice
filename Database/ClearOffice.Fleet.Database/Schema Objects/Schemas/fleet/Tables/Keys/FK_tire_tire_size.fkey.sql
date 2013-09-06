ALTER TABLE [fleet].[tire]
    ADD CONSTRAINT [FK_tire_tire_size] FOREIGN KEY ([size]) REFERENCES [fleet].[tire_size] ([id]) ON DELETE NO ACTION ON UPDATE NO ACTION;

