ALTER TABLE [dbo].[netsqlazman_AuthorizationsTable]
    ADD CONSTRAINT [CK_objectSidWhereDefinedCheck] CHECK ([objectSidWhereDefined]>=(0) AND [objectSidWhereDefined]<=(4));

