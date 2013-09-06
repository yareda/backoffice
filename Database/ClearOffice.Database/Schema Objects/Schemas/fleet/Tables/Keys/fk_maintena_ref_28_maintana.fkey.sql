ALTER TABLE [fleet].[maintenance_part]
    ADD CONSTRAINT [fk_maintena_ref_28_maintana] FOREIGN KEY ([maintenance_id]) REFERENCES [fleet].[maintanance] ([maintenance_id]) ON DELETE CASCADE ON UPDATE NO ACTION;

