ALTER TABLE [stock].[adjustment_detail]
    ADD CONSTRAINT [fk_adjustme_reference_adjustme] FOREIGN KEY ([adjustment_id]) REFERENCES [stock].[adjustment] ([adjustment_id]) ON DELETE NO ACTION ON UPDATE NO ACTION;

