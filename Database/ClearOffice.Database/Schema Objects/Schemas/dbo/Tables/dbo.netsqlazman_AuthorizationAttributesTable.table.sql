CREATE TABLE [dbo].[netsqlazman_AuthorizationAttributesTable] (
    [AuthorizationAttributeId] INT             IDENTITY (1, 1) NOT NULL,
    [AuthorizationId]          INT             NOT NULL,
    [AttributeKey]             NVARCHAR (255)  NOT NULL,
    [AttributeValue]           NVARCHAR (4000) NOT NULL
);

