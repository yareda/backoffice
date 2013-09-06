ALTER TABLE [stock].[transfer]
    ADD CONSTRAINT [fk_transfer_reference_transact] FOREIGN KEY ([status_id]) REFERENCES [stock].[transaction_status] ([status_id]) ON DELETE NO ACTION ON UPDATE NO ACTION;

