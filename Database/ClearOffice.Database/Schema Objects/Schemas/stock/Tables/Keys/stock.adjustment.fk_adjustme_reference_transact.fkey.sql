ALTER TABLE [stock].[adjustment]
    ADD CONSTRAINT [fk_adjustme_reference_transact] FOREIGN KEY ([status_id]) REFERENCES [stock].[transaction_status] ([status_id]) ON DELETE NO ACTION ON UPDATE NO ACTION;

