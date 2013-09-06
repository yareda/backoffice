ALTER TABLE [fleet].[tire]
    ADD CONSTRAINT [FK_tire_vendor] FOREIGN KEY ([vendor]) REFERENCES [fleet].[vendor] ([id]) ON DELETE NO ACTION ON UPDATE NO ACTION;

