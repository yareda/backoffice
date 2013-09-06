ALTER TABLE [fleet].[maintenance_expense]
    ADD CONSTRAINT [fk_maintena_maint_act_maintana] FOREIGN KEY ([maintenance_id]) REFERENCES [fleet].[maintanance] ([maintenance_id]) ON DELETE CASCADE ON UPDATE NO ACTION;

