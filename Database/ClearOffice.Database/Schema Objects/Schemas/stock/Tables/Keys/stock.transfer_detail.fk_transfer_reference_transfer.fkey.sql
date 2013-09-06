ALTER TABLE [stock].[transfer_detail]
    ADD CONSTRAINT [fk_transfer_reference_transfer] FOREIGN KEY ([transfer_id]) REFERENCES [stock].[transfer] ([transfer_id]) ON DELETE NO ACTION ON UPDATE NO ACTION;

