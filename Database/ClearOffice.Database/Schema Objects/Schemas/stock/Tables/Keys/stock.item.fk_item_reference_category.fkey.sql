ALTER TABLE [stock].[item]
    ADD CONSTRAINT [fk_item_reference_category] FOREIGN KEY ([category_id]) REFERENCES [stock].[category] ([category_id]) ON DELETE NO ACTION ON UPDATE NO ACTION;

