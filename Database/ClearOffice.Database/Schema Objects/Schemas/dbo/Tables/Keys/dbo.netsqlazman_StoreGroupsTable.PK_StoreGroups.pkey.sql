﻿ALTER TABLE [dbo].[netsqlazman_StoreGroupsTable]
    ADD CONSTRAINT [PK_StoreGroups] PRIMARY KEY CLUSTERED ([StoreGroupId] ASC) WITH (ALLOW_PAGE_LOCKS = ON, ALLOW_ROW_LOCKS = ON, PAD_INDEX = OFF, IGNORE_DUP_KEY = OFF, STATISTICS_NORECOMPUTE = OFF);

