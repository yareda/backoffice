ALTER TABLE [stock].[issue_detail]
    ADD CONSTRAINT [fk_issue_de_reference_item] FOREIGN KEY ([item_id]) REFERENCES [stock].[item] ([item_id]) ON DELETE NO ACTION ON UPDATE NO ACTION;

