ALTER TABLE [stock].[sub_category]
    ADD CONSTRAINT [fk_sub_cate_reference_category] FOREIGN KEY ([category_id]) REFERENCES [stock].[category] ([category_id]) ON DELETE NO ACTION ON UPDATE NO ACTION;

