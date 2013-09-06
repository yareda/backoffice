CREATE TABLE [dbo].[netsqlazman_ItemAttributesTable] (
    [ItemAttributeId] INT             IDENTITY (1, 1) NOT NULL,
    [ItemId]          INT             NOT NULL,
    [AttributeKey]    NVARCHAR (255)  NOT NULL,
    [AttributeValue]  NVARCHAR (4000) NOT NULL
);

