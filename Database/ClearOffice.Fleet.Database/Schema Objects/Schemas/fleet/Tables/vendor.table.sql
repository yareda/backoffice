CREATE TABLE [fleet].[vendor] (
    [id]          INT            IDENTITY (1, 1) NOT NULL,
    [name]        NVARCHAR (200) NOT NULL,
    [description] NVARCHAR (MAX) NULL,
    [service]     BIT            NULL,
    [dealer]      BIT            NULL,
    [parts]       BIT            NULL
);



