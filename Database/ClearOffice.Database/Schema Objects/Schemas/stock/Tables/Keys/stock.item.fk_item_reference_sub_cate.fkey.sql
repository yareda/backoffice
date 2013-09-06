ALTER TABLE [stock].[item]
    ADD CONSTRAINT [fk_item_reference_sub_cate] FOREIGN KEY ([sub_category_id]) REFERENCES [stock].[sub_category] ([sub_category_id]) ON DELETE NO ACTION ON UPDATE NO ACTION;

