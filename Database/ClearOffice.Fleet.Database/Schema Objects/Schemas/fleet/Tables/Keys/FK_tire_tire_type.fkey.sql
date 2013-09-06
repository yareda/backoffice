ALTER TABLE [fleet].[tire]
    ADD CONSTRAINT [FK_tire_tire_type] FOREIGN KEY ([tire_type]) REFERENCES [fleet].[tire_type] ([id]) ON DELETE NO ACTION ON UPDATE NO ACTION;

