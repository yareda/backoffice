ALTER TABLE [dbo].[netsqlazman_AuthorizationsTable]
    ADD CONSTRAINT [CK_ownerSidWhereDefined] CHECK ([ownerSidWhereDefined]>=(2) AND [ownerSidWhereDefined]<=(4));

