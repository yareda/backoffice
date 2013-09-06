ALTER TABLE [dbo].[netsqlazman_ApplicationPermissionsTable]
    ADD CONSTRAINT [CK_ApplicationPermissions] CHECK ([NetSqlAzManFixedServerRole]>=(0) AND [NetSqlAzManFixedServerRole]<=(2));

