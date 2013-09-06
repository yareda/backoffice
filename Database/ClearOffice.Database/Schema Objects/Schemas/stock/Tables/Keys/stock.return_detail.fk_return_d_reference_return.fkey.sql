ALTER TABLE [stock].[return_detail]
    ADD CONSTRAINT [fk_return_d_reference_return] FOREIGN KEY ([return_id]) REFERENCES [stock].[return] ([return_id]) ON DELETE NO ACTION ON UPDATE NO ACTION;

