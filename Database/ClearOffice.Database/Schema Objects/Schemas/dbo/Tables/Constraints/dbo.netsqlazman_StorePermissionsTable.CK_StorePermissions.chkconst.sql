ALTER TABLE [dbo].[netsqlazman_StorePermissionsTable]
    ADD CONSTRAINT [CK_StorePermissions] CHECK ([NetSqlAzManFixedServerRole]>=(0) AND [NetSqlAzManFixedServerRole]<=(2));

