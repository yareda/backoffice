ALTER TABLE [dbo].[netsqlazman_AuthorizationsTable]
    ADD CONSTRAINT [CK_AuthorizationTypeCheck] CHECK ([AuthorizationType]>=(0) AND [AuthorizationType]<=(3));

