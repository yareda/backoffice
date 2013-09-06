ALTER TABLE [stock].[item]
    ADD CONSTRAINT [fk_item_reference_measurem] FOREIGN KEY ([unit_id]) REFERENCES [stock].[measurement_unit] ([unit_id]) ON DELETE NO ACTION ON UPDATE NO ACTION;

