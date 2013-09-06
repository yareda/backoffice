ALTER TABLE [stock].[receiving_detail]
    ADD CONSTRAINT [fk_receivin_reference_receivin] FOREIGN KEY ([receiving_id]) REFERENCES [stock].[receiving] ([receiving_id]) ON DELETE NO ACTION ON UPDATE NO ACTION;

