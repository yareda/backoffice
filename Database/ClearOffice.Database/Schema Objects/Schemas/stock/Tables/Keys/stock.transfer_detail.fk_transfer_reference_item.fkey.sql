ALTER TABLE [stock].[transfer_detail]
    ADD CONSTRAINT [fk_transfer_reference_item] FOREIGN KEY ([item_id]) REFERENCES [stock].[item] ([item_id]) ON DELETE NO ACTION ON UPDATE NO ACTION;

