ALTER TABLE [fixedasset].[asset]
    ADD CONSTRAINT [df_item_salvage_value] DEFAULT ((0)) FOR [salvage_value];

