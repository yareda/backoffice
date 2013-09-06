CREATE TABLE [dbo].[netsqlazman_ApplicationPermissionsTable] (
    [ApplicationPermissionId]    INT            IDENTITY (1, 1) NOT NULL,
    [ApplicationId]              INT            NOT NULL,
    [SqlUserOrRole]              NVARCHAR (128) NOT NULL,
    [IsSqlRole]                  BIT            NOT NULL,
    [NetSqlAzManFixedServerRole] TINYINT        NOT NULL
);

