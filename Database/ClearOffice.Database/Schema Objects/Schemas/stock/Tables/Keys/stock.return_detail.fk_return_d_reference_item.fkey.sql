ALTER TABLE [stock].[return_detail]
    ADD CONSTRAINT [fk_return_d_reference_item] FOREIGN KEY ([item_id]) REFERENCES [stock].[item] ([item_id]) ON DELETE NO ACTION ON UPDATE NO ACTION;

