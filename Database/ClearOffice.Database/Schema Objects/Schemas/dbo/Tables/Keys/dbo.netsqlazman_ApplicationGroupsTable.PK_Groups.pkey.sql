﻿ALTER TABLE [dbo].[netsqlazman_ApplicationGroupsTable]
    ADD CONSTRAINT [PK_Groups] PRIMARY KEY CLUSTERED ([ApplicationGroupId] ASC) WITH (ALLOW_PAGE_LOCKS = ON, ALLOW_ROW_LOCKS = ON, PAD_INDEX = OFF, IGNORE_DUP_KEY = OFF, STATISTICS_NORECOMPUTE = OFF);

