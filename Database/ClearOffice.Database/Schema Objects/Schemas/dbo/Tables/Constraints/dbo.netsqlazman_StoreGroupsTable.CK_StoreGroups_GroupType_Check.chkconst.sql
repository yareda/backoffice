﻿ALTER TABLE [dbo].[netsqlazman_StoreGroupsTable]
    ADD CONSTRAINT [CK_StoreGroups_GroupType_Check] CHECK ([GroupType]>=(0) AND [GroupType]<=(1));

