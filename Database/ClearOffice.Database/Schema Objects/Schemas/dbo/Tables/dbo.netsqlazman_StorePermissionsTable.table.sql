CREATE TABLE [dbo].[netsqlazman_StorePermissionsTable] (
    [StorePermissionId]          INT            IDENTITY (1, 1) NOT NULL,
    [StoreId]                    INT            NOT NULL,
    [SqlUserOrRole]              NVARCHAR (128) NOT NULL,
    [IsSqlRole]                  BIT            NOT NULL,
    [NetSqlAzManFixedServerRole] TINYINT        NOT NULL
);

