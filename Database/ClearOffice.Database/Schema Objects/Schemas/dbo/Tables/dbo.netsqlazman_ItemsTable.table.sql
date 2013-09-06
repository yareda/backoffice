CREATE TABLE [dbo].[netsqlazman_ItemsTable] (
    [ItemId]        INT             IDENTITY (1, 1) NOT NULL,
    [ApplicationId] INT             NOT NULL,
    [Name]          NVARCHAR (255)  NOT NULL,
    [Description]   NVARCHAR (1024) NOT NULL,
    [ItemType]      TINYINT         NOT NULL,
    [BizRuleId]     INT             NULL
);

