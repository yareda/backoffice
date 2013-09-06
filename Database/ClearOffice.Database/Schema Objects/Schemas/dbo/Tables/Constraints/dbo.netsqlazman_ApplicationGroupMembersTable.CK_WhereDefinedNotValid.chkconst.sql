ALTER TABLE [dbo].[netsqlazman_ApplicationGroupMembersTable]
    ADD CONSTRAINT [CK_WhereDefinedNotValid] CHECK ([WhereDefined]>=(0) AND [WhereDefined]<=(4));

