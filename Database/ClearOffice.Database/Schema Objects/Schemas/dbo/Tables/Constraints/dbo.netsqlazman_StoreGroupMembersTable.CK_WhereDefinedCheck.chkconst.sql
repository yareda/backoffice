ALTER TABLE [dbo].[netsqlazman_StoreGroupMembersTable]
    ADD CONSTRAINT [CK_WhereDefinedCheck] CHECK ([WhereDefined]=(0) OR [WhereDefined]>=(2) AND [WhereDefined]<=(4));

