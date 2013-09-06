ALTER TABLE [fleet].[maintenance_activity]
    ADD CONSTRAINT [fk_maintena_reference_maintana] FOREIGN KEY ([maintenance_id]) REFERENCES [fleet].[maintanance] ([maintenance_id]) ON DELETE CASCADE ON UPDATE NO ACTION;

