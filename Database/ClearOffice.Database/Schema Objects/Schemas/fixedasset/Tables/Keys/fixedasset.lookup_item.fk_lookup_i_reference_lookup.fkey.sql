ALTER TABLE [fixedasset].[lookup_item]
    ADD CONSTRAINT [fk_lookup_i_reference_lookup] FOREIGN KEY ([lookup_id]) REFERENCES [fixedasset].[lookup] ([lookup_id]) ON DELETE NO ACTION ON UPDATE NO ACTION;

