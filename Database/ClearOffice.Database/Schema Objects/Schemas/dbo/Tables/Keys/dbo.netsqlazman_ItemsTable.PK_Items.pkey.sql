﻿ALTER TABLE [dbo].[netsqlazman_ItemsTable]
    ADD CONSTRAINT [PK_Items] PRIMARY KEY CLUSTERED ([ItemId] ASC) WITH (ALLOW_PAGE_LOCKS = ON, ALLOW_ROW_LOCKS = ON, PAD_INDEX = OFF, IGNORE_DUP_KEY = OFF, STATISTICS_NORECOMPUTE = OFF);
