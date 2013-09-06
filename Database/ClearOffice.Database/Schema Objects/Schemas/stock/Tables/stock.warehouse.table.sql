CREATE TABLE [stock].[warehouse] (
    [warehouse_id]   INT            IDENTITY (1, 1) NOT NULL,
    [name]           NVARCHAR (200) NULL,
    [address]        NVARCHAR (MAX) NULL,
    [contact_person] NVARCHAR (MAX) NULL
);

