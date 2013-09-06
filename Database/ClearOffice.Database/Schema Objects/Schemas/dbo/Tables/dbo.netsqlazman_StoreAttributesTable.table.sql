CREATE TABLE [dbo].[netsqlazman_StoreAttributesTable] (
    [StoreAttributeId] INT             IDENTITY (1, 1) NOT NULL,
    [StoreId]          INT             NOT NULL,
    [AttributeKey]     NVARCHAR (255)  NOT NULL,
    [AttributeValue]   NVARCHAR (4000) NOT NULL
);

