CREATE TABLE [dbo].[netsqlazman_ApplicationAttributesTable] (
    [ApplicationAttributeId] INT             IDENTITY (1, 1) NOT NULL,
    [ApplicationId]          INT             NOT NULL,
    [AttributeKey]           NVARCHAR (255)  NOT NULL,
    [AttributeValue]         NVARCHAR (4000) NOT NULL
);

