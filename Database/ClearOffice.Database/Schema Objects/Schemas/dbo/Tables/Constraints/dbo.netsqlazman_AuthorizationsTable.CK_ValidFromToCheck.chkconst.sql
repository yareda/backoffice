ALTER TABLE [dbo].[netsqlazman_AuthorizationsTable]
    ADD CONSTRAINT [CK_ValidFromToCheck] CHECK ([ValidFrom] IS NULL OR [ValidTo] IS NULL OR [ValidFrom]<=[ValidTo]);

