ALTER TABLE [fixedasset].[asset]
    ADD CONSTRAINT [df_item_status] DEFAULT ((1)) FOR [status];

