ALTER TABLE [fleet].[maintanance]
    ADD CONSTRAINT [fk_maintana_reference_vendor] FOREIGN KEY ([serviced_by]) REFERENCES [fleet].[vendor] ([id]) ON DELETE CASCADE ON UPDATE NO ACTION;

