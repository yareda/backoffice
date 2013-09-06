CREATE TABLE [dbo].[netsqlazman_StoreGroupsTable] (
    [StoreGroupId] INT             IDENTITY (1, 1) NOT NULL,
    [StoreId]      INT             NOT NULL,
    [objectSid]    VARBINARY (85)  NOT NULL,
    [Name]         NVARCHAR (255)  NOT NULL,
    [Description]  NVARCHAR (1024) NOT NULL,
    [LDapQuery]    NVARCHAR (4000) NULL,
    [GroupType]    TINYINT         NOT NULL
);

