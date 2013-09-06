ALTER TABLE [fixedasset].[asset]
    ADD CONSTRAINT [df_item_value] DEFAULT ((0)) FOR [asset_value];

