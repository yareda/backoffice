CREATE TABLE [stock].[supplier] (
    [supplier_id]    INT            IDENTITY (1, 1) NOT NULL,
    [name]           NVARCHAR (200) NULL,
    [description]    NVARCHAR (MAX) NULL,
    [address]        NVARCHAR (MAX) NULL,
    [contact_person] NVARCHAR (MAX) NULL
);

