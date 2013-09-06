ALTER TABLE [stock].[issue_detail]
    ADD CONSTRAINT [fk_issue_de_reference_issue] FOREIGN KEY ([issue_id]) REFERENCES [stock].[issue] ([issue_id]) ON DELETE NO ACTION ON UPDATE NO ACTION;

